/*****************************************************
 * MathDrill(Assignment 7)							 *
 * Written by Randolph Gibson						 *
 * Coded by James Standeven - October 21, 2011		 *
 *****************************************************/

#include <iostream> // To enable cout and cin functions
using namespace std;
#include <cstdlib> // To use rand function to generate random numbers
#define SENT 4 // Loop sentinel to quit menu

/*Function Prototypes*/
void DisplayMenu();
int GetMenuChoice();
void Gen2Rand(int &, int &);
void DrillOneProb(int, int, int); 


int main()
{
	int c, // Menu choice
		r1, // First random integer
		r2; // Second random integer
	
	DisplayMenu(); // Call DisplayMenu
	c = GetMenuChoice(); // Call GetMenuChoice and pass value to c
	
	/*Main Body Loop*/
	while(c >= 1 && c < SENT)
	{
		Gen2Rand(r1, r2); // Call Gen2Rand and pass by reference r1 and r2
		DrillOneProb(c, r1, r2); // Call DrillOneProb and pass c, r1 and r2
		DisplayMenu(); // Call DisplayMenu 
		c = GetMenuChoice(); // Call GetMenuChoice and pass value to c
	}
	
	/*Program shutdown message*/
	cout << "Program complete\n";
	
    system ("pause"); // To help analyze the program
	return 0; // Returns value to parent process
}

void DisplayMenu() // Menu display function
{
	cout << "MENU OF OPERATIONS\n\n";
	cout << "1. Addition.\n";
	cout << "2. Subtraction.\n";
	cout << "3. Multiplication.\n";
	cout << "4. Quit.\n\n";
}

int GetMenuChoice () // User choice input function
{	
	int c; // Menu choice(1-4)
	
	/*Menu Choice Loop*/
	do
	{
		
		cout << "Enter the number of the operation to try (1-4): "; // Prompt for user choice
		cin >> c; // Fetch user choice
		
		/*Sentinel protection*/
		if(c < 1 || c > SENT)
		cout << "\aInput value is out of range.\n";		
	}while(c < 1 || c > SENT); // Loop checking for valid value
	
	return c; // Return value c to the main function
}

void Gen2Rand(int &r1, int &r2) // Random numbers between 2 and 12 generator function
{
	r1 = rand() % 11 + 2; // Random number 1
	r2 = rand() % 11 + 2; // Random number 2
}

void DrillOneProb(int c, int r1, int r2) // Math drill function
{
	int CorAns, // Correct answer to math question
		Reply; // Uesr's Reply to math question
	
	cout << "\nWhat is " << r1 << " "; // Start of prompt for user's answer
	
	switch(c) // Selection process using user's menu choice
	{
		case 1: cout << "+"; CorAns = r1 + r2; break; // Partial prompt + calculation for addition
		case 2: cout << "-"; CorAns = r1 - r2; break; // Partial prompt + calculation for subtraction 
		case 3: cout << "x"; CorAns = r1 * r2; break; // Partial prompt + calculation for multiplication
	}
	
	cout << " " << r2 << "? "; // End of prompt for user's answer
	cin >> Reply; // Fetch user's answer
	
	if(Reply == CorAns) // Compare user's answer with correct answer
		cout << "Yes, that is correct. Good Job!"; // Response for correct answer
	else
		cout << "No, the correct answer is: " << CorAns; // Response for wrong answer
	cout << "\n\n";
}
