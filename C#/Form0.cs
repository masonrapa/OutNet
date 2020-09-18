using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Http;
using System.Net;
using System.IO;

namespace OutNet {
    public partial class Form0 : Form {
        public Form0() {
            InitializeComponent();
        }

        public static String before;
        public static String after;
        public static Boolean pause;
        private static readonly HttpClient client = new HttpClient();

        private void Form0_Load(object sender, EventArgs e) {
            label1.Text = "Hello "+Form1.nick.Replace("\r\n", "") + ", you are connected to: "+Form1.ip.Replace("\r\n", "");
            Thread t = new Thread(new ThreadStart(Threading));
            t.Start();
        }

        public static String responseFromServer;

        public void Threading() {
            while ("" == "") {
                if (pause == false) {
                    Thread.Sleep(1000);
                    try {
                        WebRequest request = WebRequest.Create("http://"+Form1.ip.Replace("\r\n","")+"/OutNet/logs.txt");
                        request.Credentials = CredentialCache.DefaultCredentials;
                        WebResponse response = request.GetResponse();
                        using (Stream dataStream = response.GetResponseStream()) {
                            StreamReader reader = new StreamReader(dataStream);
                            responseFromServer = reader.ReadToEnd();
                        }
                        response.Close();
                        //this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button2.Visible = true; });
                        before = responseFromServer;
                        if (before != after) {
                            after = responseFromServer;
                            responseFromServer = responseFromServer.Replace("^^^^", "\n");
                            List<string> arrayz = new List<string>(responseFromServer.Split(new string[] { "\n" }, StringSplitOptions.None));
                            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { listBox1.Items.Clear(); });
                            foreach (String alfa in arrayz) {
                                this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { listBox1.Items.Add(alfa); });
                            }
                        }
                    } catch {
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button2.Visible = false; });
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { listBox1.Items.Clear(); });
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { listBox1.Items.Add("Couln't connect to "+Form1.ip); });
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e) {
            var request = (HttpWebRequest)WebRequest.Create("http://"+Form1.ip.Replace("\r\n", "") + "/OutNet/listener.php");
            var postData = "text=" + Uri.EscapeDataString(textBox1.Text);
            postData += "&name=" + Uri.EscapeDataString(Form1.nick.Replace("\r\n", ""));
            var data = Encoding.ASCII.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pause == false) {
                pause = true;
                button1.Text = "Continue";
            } else if (pause == true) {
                pause = false;
                button1.Text = "Pause";
            }
        }
    }
}
