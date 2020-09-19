# OutNet
This is an Advanced Chat plugin for Minecraft Servers developed using: #Python, #Java, #CSharp, #Php and #JavaScript (5 of my favourite coding languages).

# How To Install
**The First Step** is making a Java plugin with the files that are on the OutNet/Java's folder(Main.java and msg.java)<br>
But you have the full code in the folder "Download".<br>
After that, we have to "Export" the code to the plugin folder of your minecraft server as 'OutNet.jar'<br>
<br>
![photo](https://github.com/masonrapa/OutNet/blob/master/pictures/pic1.PNG?raw=true)<br>
<br>
**The Second Step** is going to the website's folder (var/www/html or C:/xampp/htdocs) and creating a folder named "OutNet" (C:/xampp/htdocs/OutNet/ on windows and /var/www/html/OutNet on linux)<br>
And after that, we have to paste the next files:<br>
![photo](https://github.com/masonrapa/OutNet/blob/master/pictures/pic2.PNG?raw=true)
- 'Ping folder' on OutNet/Python<br>
- 'chat.php' on OutNet/PHP<br>
- 'index.php' on OutNet/PHP<br>
- 'listener.php on OutNet/PHP<br>
- 'logs.txt' on OutNet/Others<br>
- 'photo.png' on OutNet/Others<br>
- 'players.py' on OutNet/Python<br>
- 'sound.mp3' on OutNet/Others<br>-
- 'styles.css' on OutNet/Others<br>
<br>
**The Third Step** is checking that the connection between Java plugin and Website works perfdectly, so, let's check!<br>
![photo](https://github.com/masonrapa/OutNet/blob/master/pictures/pic3.PNG?raw=true)<br>
And as we can see, the connection works perfectly<br>
_(My MC Username is 'Masonsito' and 'L' in the website)_<br>
<br>
**The Fourth Step** is creating the C#'s GUI<br>
Let's open a Windows Application Forms (.NET FRAMEWORK) on Visual Basic and creating the next files:<br>
![photo](https://github.com/masonrapa/OutNet/blob/master/pictures/pic5.PNG?raw=true)<br>
- 'Form0.cs' on OutNet/C#, This is the technic code of the Chat Screen made in C#<br>
- 'Form0.designer.cs' on OutNet/C#, This is the aesthetic code of the Chat Screen made in C#<br>
- 'Form1.cs' on OutNet/C#, This is the technic code of the Login Screen made in C#<br>
- 'Form1.designer.cs' on OutNet/C#, This is the aesthetic code of the Login Screen made in C#<br>
- 'Program.cs' on OutNet/C#, This is the Main config file<br>
- 'UNeedToAddthisPicture.jpg' on OutNet/C#, you need to import this picture and set as background of the Forms 0 and 1.<br>
<br>
**The Fifth Step** is checking that all of the last steps works perfectly:<br>
![photo](https://github.com/masonrapa/OutNet/blob/master/pictures/pic4.PNG?raw=true)<br>
As we can see, we are abled to chat between:<br>
- _'Masonsito' - (Minecraft Chat)_<br>
- _'L' - (Website Chat)_<br>
- _'Black' - (Windows GUI Chat)_<br>

**A simple explanation of that each coding language does:**<br>
<br>
**Java:** Analyze the msg.txt file for reading the messages and broadcast them on the Minecraft server, it also works reading the player messages and reporting them to logs.txt file.<br><br>
**JS:** with the 'setInterval(function(){ajax();}, 1000);', the JS code is executed sending get http requests to chat.php file, which read each 1k ms the log.txt and print the content on the main web container.<br><br>
**PHP:** index.php, chat.php and listener.php, the only function of the PHP files are printing the content of the messages file, they also write messages on the file of 2 ways: with <form> on index.php for the web messages and with $_POST(); of listener.php for the C# Post HTTP Requests.<br><br>
**C#:** Creates a windows GUI as remote chat that works using GET Requests in a 'while' and POST Requests in a Button Action<br><br>
**Python:** Returns number of players in the Minecraft Server and their names with a minecraft ping library for showing {Players.online}/{Players.max} and their game skins with a Foreach bucle in PHP.
