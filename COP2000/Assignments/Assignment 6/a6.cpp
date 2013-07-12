/*****************************************************
 * Title: One Month Calendar						 *
 * Written by Randolph Gibson						 *
 * Coded by: James Standeven October 5, 2011		 *
 *****************************************************/

#include <iostream>
using namespace std;
#include <iomanip>

int main()
{
	int COL, // Column counter
		DAY1, // Column of the first day
		QDAYS, // Quantity of days in the month
		DAYNUM; // Displayed day numeral
		
	/*Clear the screen*/
	system("cls");
	
	/*Program title and credits*/
	cout << "ONE MONTH CALENDAR\n";
	cout << "==================\n\n";
	cout << "Written by Randolph Gibson\n";
	cout << "Coded by James Standeven\n\n";
	
	/*User input instructions*/
	cout << "Select from the menu below the numeral indicating which day of the week\n";
	cout << "should appear as the first day of the month on your calendar.\n\n";
	
	/*Menu of starting days*/
	cout << "FIRST DAY OF MONTH MENU\n\n";
	cout << "1. Sunday\n2. Monday\n3. Tuesday\n4. Wednesday\n5. Thursday\n6. Friday\n7. Saturday\n";
	
	/*Input request and fetch loops*/
	do
	{
		cout << "\nNumeral (1-7)? ";
		cin >> DAY1;
	}
	while(DAY1 < 1 || DAY1 > 7); // For first day of the month
	
	do
	{
		cout << "\nHow many days are in this month (28-31)? ";
		cin >> QDAYS;
	}
	while(QDAYS < 28 || QDAYS > 31); // For number of days in the month
	
	/*Calendar Header*/
	cout << "\n+---------+---------+---------+---------+---------+---------+---------+\n";
	cout << "|   SUN   |   MON   |   TUE   |   WED   |   THU   |   FRI   |   SAT   |\n";
	cout << "+---------+---------+---------+---------+---------+---------+---------+\n";
	
	/*Initialize displayed day counter*/
	DAYNUM = 1;
	
	/*Calendar loops*/
	while(DAYNUM <= QDAYS) // Outter loop
	{
		/*Initialize column counter*/
		COL = 1;
		
		/*Column loop*/
		while(COL <= 7) // Inner (counting) loop
		{
			cout << "|"; // Calendar border
			
			/*First day placement selection*/
			if((DAYNUM == 1 && COL < DAY1) || DAYNUM > QDAYS)
			{
				cout << "         "; // Cell with no day
			}
			else
			{
				cout << setw(9) << left << DAYNUM; // Calendar body
				
				DAYNUM++; // Day counter increment
			}
		
			COL++; // Column increment
		}
	
		/*Remainder of calendar body*/	
		cout <<	"|\n";
		cout << "|         |         |         |         |         |         |         |\n";
		cout << "+---------+---------+---------+---------+---------+---------+---------+\n";
	}
	
	system("pause"); // For analysis
	return 0; // Returns zero error code to parent process
}
