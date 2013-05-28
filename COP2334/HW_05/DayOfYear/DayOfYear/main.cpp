/*
  Homework 5
  Programmed by: James Standeven
  Date: Oct 15, 2012
*/

#include <iostream>
#include "DayOfYear.h"
using namespace std;

#define MIN 1
#define MAX 365

int main()
{
	int input;

	cout << "This program takes a number between "<< MIN << " and " << MAX
		 << "\nand converts it into a format with the month\n"
		 << "followed by the day of the month.\n\n\n";
	
	do {
	cout << "Please enter a number between " << MIN << " and " << MAX << " inclusive(0 to exit): ";
	cin >> input;
	system("cls");
	if(input >= MIN && input <= MAX) {
		cout << "That number converts to: ";
		DayOfYear(input).print();
	}
	if(input != 0 && (input < MIN || input > MAX))
		cout << "That number is not within range.\n";
	
	cout << endl;
	}while(input != 0);

	return 0;
}
