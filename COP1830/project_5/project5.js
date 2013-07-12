/*
   Filename: project5.js
   Authored by: James Standeven
   Date: October 31, 2012
*/
var UI = prompt("Enter a whole number to test as a prime number:", "0");
var TV = parseInt(UI, 10);
var HITS = 0;
var DD = TV;

while(DD > 0) {
	if(TV%DD === 0) {
		HITS++;
	}
	DD--;
}


document.write( UI + " is");
if(HITS > 2) {
	document.write(" not");
}
document.write(" a prime number.");
