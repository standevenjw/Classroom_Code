/***************************************************************
 * This program converts height in meters into height in feet. *
 * Written by Randolph Gibson - 1 August 2011                  *
 * Coded by James Standeven - 8 September 2011                 *
 ***************************************************************/

#include <iostream>//For cout & cin functions
using namespace std;//Defines context for cin & cout
#define FACTOR  2.54//Symbolic constant for the conversion rate for in. & cm

int main()
{	
	float HM;//Inputted height (in meters)
	int INCHES,//Calculated inches
		FEET;//Calculated feet
	
	/*Intro & Instructions*/
	cout << "Height Converting Program\n";//Title
	cout << "Designed by Randolph Gibson - 1 August 2011\n";//Designer
	cout << "Coded by James Standeven - 8 September 2011\n\n";//Coder
	
	cout << "This program will convert a person\'s height from meters\n";
	cout << "into feet and inches (rounded to the nearest inch) and\n";
	cout << "display the results on the screen. The height must be\n";
	cout << "entered in metric units and may contain decimal portions.\n";
	cout << "The answer will be displayed in whole feet and whole inches.\n\n";//Previous 5 lines are Intro.
	
	/*User input*/
	cout << "Enter the person\'s height in meters: ";//Prompt for value of HM
	cin  >> HM;//User input
	
	/*Calculations*/
	INCHES = static_cast<int> (HM * 100 / FACTOR + 0.5);//Turns meters into inches and rounds to the next inch
	FEET = INCHES / 12;//Gets number of feet and truncates remainder
    INCHES = INCHES % 12;//Gets number of inches by using the remainder
	
	
	/*Output*/
	cout << "\nThat height is equivalent to " << FEET 
         << " feet and " << INCHES << " inch(es).\n";//Displays results
	system("pause");//Helps to evaluate program
	return 0;//Returns zero error code to parent process
}
