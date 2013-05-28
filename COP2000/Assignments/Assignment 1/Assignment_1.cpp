/*This program calculates the area of a room and uses
that to calculate the cost to carpet the room*/
//Written by James Standeven

#include <iostream>//for input and output
#include <iomanip>//to create values to a certain decimal
using namespace std;

int main()
{
	const int SFPERSY = 9;//Constant for converting square yards to square feet

	double LENGTH, WIDTH;//user input for lenght and width of a room
	double AREA;//calculated output of the area of the room
	double PRICESY, PRICESF;//price of carpet in square yards and square feet
	double COST;//cost to carpet the room

	cout << "ROOM AREA AND CARPET PRICING CALCULATOR\n\n";//title
	cout << "Written by James Standeven - 01 September, 2011\n\n";//author and date
	cout << "This program will request the length and width of your"//intro
			" room and also the price\n";
	cout << "of your chosen carpet. It will then calculate the area of"//intro
			" the room and the price to\n";
	cout << "carpet it and display both results.\n\n";//intro
	
	cout << "How wide is your room in feet? ";
	cin >> WIDTH;//room width
	//cout << " feet\n";
	cout << "How long is your room in feet? ";
	cin >> LENGTH;//room length
	//cout << " feet\n";
	cout << "How much does the carpet cost per square yard? $";
	cin >> PRICESY;//price in square yards
	cout << "\n\n\n";
	
	AREA = LENGTH * WIDTH;//area of the room
	PRICESF = PRICESY / SFPERSY;//rate for carpet in square feet
	COST = AREA * PRICESF;//cost to carpet the room
	
	cout << setprecision (2);//set output to 2 decimal places
	cout << "The area of your room is: " << fixed << AREA << " square feet\n";//display of area
	cout << "The total cost to carpet your room would be: $" << fixed << COST <<endl;//display of cost
	system("pause");
	return (0);
	}
