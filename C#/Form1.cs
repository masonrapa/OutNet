using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutNet {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        public static String ip;
        public static String nick;

        private void button1_Click(object sender, EventArgs e)
        {
            nick = textBox8.Text;
            ip = textBox1.Text;
            int nj = this.Controls.Count;
            for (int j = 0; j < nj; j++) {
                this.Controls.RemoveAt(0);
            }
            Form fh = new Form0() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Controls.Add(fh);
            this.Tag = fh;
            fh.Show();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
