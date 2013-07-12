<!DOCTYPE html>
<html>
<head>
	<meta charset='utf-8' />
	<title>Assignment 2</title>
</head>
<body>
<?php
	if(!empty($_GET)){//If the GET array is not empty
		echo "Result:<br />";
		if($_GET["convert"] === '1'){//radio button input for feet to meters.
			$output = (double)$_GET["usrinput"] / 3.2808;
			$format = "%.2f feet = %.2f meter(s).\n";
			
		} else{//radio button input for meters to feet
			$output = (double)$_GET["usrinput"] * 3.2808;
			$format = "%.2f meter(s) = %.2f feet.\n";
		}
		$dataOut = sprintf($format, $_GET["usrinput"], $output);//string with proper format and data
		echo $dataOut;
		file_put_contents("conversions.txt", $dataOut, FILE_APPEND);//Attach conversion to the end of a file
	}
	//Create form for input
	echo "<form method='get' action='assignment2.php'>";
	echo "<p>Select conversion direction:<br />";
	echo "<input type='radio' name='convert' value='1'>Feet to meters.</input><br />";
	echo "<input type='radio' name='convert' value='2'>Meters to feet.</input><br /></p>";
	echo "<p>Value to be converted:<br />";
	echo "<input type='text' name='usrinput' /></p>";
	echo "<input type='submit' value='Convert' />";
	echo "</form>";
	
?>
</body>
</html>