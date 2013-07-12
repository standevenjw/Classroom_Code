<?php
// Coded by: James Standeven
// Date: February 7, 2013

function parse($str){ //parse the query string
	$strarr = explode(":", $str);
	return $strarr;
}

function convertL($arr) { //convert feet to meters and vice versa
	if($arr[2] == "1"){ //convert feet to meters
		$output = $arr[0] / 3.2808;
		$format = "%.2f feet = %.2f meter(s).";
		echo sprintf($format, $arr[0], $output);
	}
	else if($arr[2] == "2"){ //convert meters to feet
		$output = $arr[0] * 3.2808;
		$format = "%.2f meter(s) = %.2f feet.";
		echo sprintf($format, $arr[0], $output);
	}
	else
		echo "That is not valid input.";
}

function convertW($arr) { //convert pounds to kilograms and vice versa
	if($arr[2] == "1"){ //convert pounds to kilograms
		$output = $arr[0] / 2.2046;
		$format = "%.2f pound(s) = %.2f kilogram(s).";
		echo sprintf($format, $arr[0], $output);
	}
	else if($arr[2] == "2"){ //convert kilograms to pounds
		$output = $arr[0] * 2.2046;
		$format = "%.2f kilogram(s) = %.2f pound(s).";
		echo sprintf($format, $arr[0], $output);
	}
	else
		echo "That is not valid input.";
}

function convertV($arr) { //convert gallons to liters and vice versa
	if($arr[2] == "1"){ //convert gallons to liters
		$output = $arr[0] * 3.7854;
		$format = "%.2f gallon(s) = %.2f liter(s).";
		echo sprintf($format, $arr[0], $output);
	}
	else if($arr[2] == "2"){ //convert liters to gallons
		$output = $arr[0] / 3.7854;
		$format = "%.2f liter(s) = %.2f gallon(s).";
		echo sprintf($format, $arr[0], $output);
	}
	else
		echo "That is not valid input.";
}

$parsedarr = parse($_SERVER["QUERY_STRING"]);

switch ($parsedarr[1]){
	case "1":
		convertL($parsedarr); //relates to length
	break;
	case "2":
		convertW($parsedarr); //relates to weight
	break;
	case "3":
		convertV($parsedarr); //relates to volume
	break;
	default:
		echo "That is not valid input.";
}
?>
