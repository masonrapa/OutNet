<?php
$name = $_POST["name"];
$message = $_POST["text"];
$file = fopen("logs.txt", "a");
fwrite($file, "[".$name."] > ".$message."^^^^");
fclose($file);
$file = fopen("msg.txt", "a");
fwrite($file, "[".$name."] > ".$message);
fclose($file);
echo "<embed loop='false' src='sound.mp3' hidden='true' autoplay='true'>";
?>
