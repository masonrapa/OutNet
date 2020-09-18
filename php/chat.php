<?php
$myfile = fopen("logs.txt", "r");
$text = fgets($myfile);
fclose($myfile);
?>
<div id="datos">
	<span style="color: #000000;"><?php echo str_replace("^^^^","<br>", $text);?></span>
</div>
