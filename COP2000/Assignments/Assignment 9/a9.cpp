/****************************************************
 * Drawbox				 							*
 * Written by: Randolph Gibson	 					*
 * Coded by: James Standeven - November 15, 2011	*
 ****************************************************/

#include <iostream>
using namespace std;
#define MINDIM 2 // Minimum dimension of rectangle
#define MAXDIM 20 // Maximum dimension of rectangle

/*Prototypes*/
void Intro(int, int);
char AskSymbol();
void AskSizes(int, int, int *, int *);
void TopBot(char, int);
void Slice(char, int);

int main()
{
	char SYMB; // Symbol to draw the rectangle
	int WIDE, // Width of rectangle
		DEEP; // Depth of rectangle
	
	Intro(MINDIM, MAXDIM);
	SYMB = AskSymbol();
	AskSizes(MINDIM, MAXDIM, &DEEP, &WIDE);
	
	cout << endl;
	
	TopBot(SYMB, WIDE);
	
	for(int C = 1; C <= DEEP - 2; C++)Slice(SYMB, WIDE);
	
	TopBot(SYMB, WIDE);

	system("pause");
	return 0;
}

/*Intro function*/
void Intro(int MIN, int MAX) // Display program title and intro
{
	cout << "BOX DISPLAYING PROGRAM\n\n"
		 << "This program will display a rectangle made from a symbol\n"
		 << "specified by the user and of a width and depth specified\n"
		 << "by the user. The program will accept user input of width\n"
		 << "and depth values between" << MIN << " and " << MAX << " (inclusive) only.\n\n";
}

/*AskSymbol function*/
char AskSymbol() // Request and return a symbol to be used to display the rectangle
{
	char S; // Symbol to draw the rectangle
	cout << "Symbol to display? ";
	cin >> S;
	
	return S;
}

/*AskSizes function*/
void AskSizes(int MIN, int MAX, int *DPTR, int *WPTR) // Request and return only valid width & depth values between MIN and MAX inclusive.
{
	int D, // Depth of rectangle
		W; // Width of rectangle
		
	do // Request for width loop
	{
		cout << "Width (" << MIN << "-" << MAX << ")? ";
		cin >> W;
		
		if(W < MIN || W > MAX)
		{
			cout << "\aINVALID ENTRY: Enter a value between " << MIN 
			<< " and " << MAX << " inclusive -\n";
		}
	}while(W < MIN || W > MAX);
	
	/*Request for depth loop*/
	cout << "Depth (" << MIN << "-" << MAX << ")? ";
	cin >> D;
	
	while(D < MIN || D > MAX)
	{
		cout << "\aINVALID ENTRY: Enter a value between " << MIN 
			 << " and " << MAX << " inclusive -\n";
		
		cout << "Depth (" << MIN << "-" << MAX << ")? ";
		cin >> D;

	}
	
	*DPTR = D;
	*WPTR = W;
}

/*TopBot Function*/
void TopBot(char S, int W) // Display a line made from the passed-in symbol by repeating it the passed-in width times.
{
	for(int I = 1; I <= W; I++) cout << S;
	cout << endl;
}

/*Slice function*/
void Slice(char S, int W)
{
	cout << S;
	
	for(int I = 1; I <= W-2; I++) cout << " ";
	
	cout << S << endl;
}
