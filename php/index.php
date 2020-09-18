<!DOCTYPE html>
<html>
<head>
	<title>Out Net</title>
	<link rel="stylesheet" type="text/css" href="styles.css">
	<script type="text/javascript">
		function ajax(){
			var req = new XMLHttpRequest();
			req.onreadystatechange = function(){
				if (req.readyState == 4 && req.status == 200) {
					document.getElementById('chat').innerHTML = req.responseText;
				}
			}
		req.open('GET', 'chat.php', true);
		req.send();
	}
	setInterval(function(){ajax();}, 1000);
	</script>
</head>
<body onload="ajax()">
	<div id="contenedor">
		<h2 style="font-size: 25px;border-radius: 15px 15px 15px 15px; border-color: black; border-style: solid; padding: 10px; float: left; background-color: rgba(0, 221, 255, 0.6);">Connected to: 192.168.0.27:666</h2>
		<h2 style="font-size: 25px;border-radius: 15px 15px 15px 15px; border-color: black; border-style: solid; padding: 10px; margin-left: 500px;background-color: rgba(0, 221, 255, 0.6);">Players: 
<?php
$get = exec("python players.py A 192.168.0.27:666");
print $get."	";
$jcd = exec("python players.py B 192.168.0.27:666");
$players = explode(",",$jcd);
foreach ($players as $player) {
	echo '<img src="https://mc-heads.net/avatar/'.$player.'/30.png"> ';
}

?></h2>
		<div id="caja-chat">
			<div id="chat"></div>
		</div>
		<br>
		<form method="POST" action="index.php">
			<input type="text" name="nombre" placeholder="Set Nickname">
			<textarea name="mensaje"> </textarea>
			<input type="submit" name="enviar" placeholder="Send Message" value="Send Message">
		</form>
		<?php
			if (isset($_POST["enviar"])) {
				$name = $_POST["nombre"];
				$message = $_POST['mensaje'];
				$file = fopen("logs.txt", "a");
				fwrite($file, "[".$name."] > ".$message."^^^^");
				fclose($file);
				$file = fopen("msg.txt", "a");
				fwrite($file, "[".$name."] > ".$message);
				fclose($file);
				echo "<embed loop='false' src='sound.mp3' hidden='true' autoplay='true'>";
			}
		?>
	</div>
<h4>By: @Masonrapa (ObsiTeam ©)</h4>
</body>
</html>
