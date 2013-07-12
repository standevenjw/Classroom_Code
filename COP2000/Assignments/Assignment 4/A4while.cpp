/*********************************************
 * Apply									 *
 * Written by Randolph Gibson				 *
 * Coded by James Standeven	- Sept. 23, 2011 *
 *********************************************/

#include <iostream> // Allows the use of cout and cin
using namespace std;
#include <iomanip> // To manipulate output

#define ADULT 18 // Minimum age of applicant
#define SMWD 1000.00 // Salary multiplier for applicants with a college degree
#define SMWO 600.00 // Salary multiplier for applicants without a college degree
#define MINAGE 0 // Minimum value of AGE
#define MAXAGE 120 // Maximum value of AGE

int main()
{
	int AGE, // Applicant's age
		WHN; // When underage applicants should apply again
	char DEG; // Determines if applicant has a degree
	double SAL; // Salary offered to applicant
	char AGAIN; // Determines if the program should run again
	
	/*Clear screen*/
	system("cls");
	
	/*Title*/
	cout << "Applicant Screening Program\n\n";
	
    
    do
		{
		/*Age prompt and fetch*/
		cout << "How old are you? ";
		if(cin >> AGE)
			{
			while(AGE < MINAGE || AGE > MAXAGE) // Checks for valid input
				{
				cin.ignore(10,'\n'); // Clears register
				cout << "\nInvalid entry. Please enter a number between " << MINAGE << " and " << MAXAGE << ".\n"; // Displays range
				cout << "\nHow old are you? "; // Prompt again
				cin >> AGE; // Fetch again
				}
		
				if(AGE>=ADULT) // Determines if applicant is the right age
					{
					/*Degree prompt and fetch*/
					cin.ignore(10,'\n'); // Clears register
					cout << "Do you have a college degree (Y/N)? ";
					cin.get(DEG);
			
					/*Degree decision*/
					while(!(DEG == 'Y' || DEG == 'y' || DEG == 'N' || DEG == 'n'))
						{
						cin.ignore(10,'\n'); // Clears register
						cout << "\nInvalid entry. Please enter a Y or an N.\n";
						cout << "\nDo you have a college degree (Y/N)? "; // Prompt for degree
						cin.get(DEG); // Fetch answer 
						}
					/*Salary decision*/	
					if(DEG == 'Y' || DEG == 'y')
						{
						SAL = AGE * SMWD; // Salary with degree
						}
					else
						{
						SAL = AGE * SMWO; // Salary without degree
						}
					
					/*Job offer*/
					cout << "\nYou qualify!\n"
						 << "Your annual salary would be $" << setprecision(2) << fixed << SAL << endl
						 << "See our staff for an application.\n";
					}	
	
				/*Underage applicant*/
				else
					{
					WHN = ADULT - AGE; // Years till applicant can reapply
					/*Screen output*/
					cout << "\nSorry, you must be " << ADULT << " or older for this job.\n"
						 << "Please apply again in " << WHN << " years.\n";
					}
			
				cin.ignore(10,'\n'); // Clears register
				cout << "\n\nRun the program again (Y/N)? ";
				cin.get(AGAIN);
				cout << endl;

				while(!(AGAIN == 'Y' || AGAIN == 'y' || AGAIN == 'N' || AGAIN == 'n'))
					{
					cin.ignore(10,'\n'); // Clears register
					cout << "\nInvalid entry. Please enter a Y or an N.\n";
					cout << "\nRun the program again (Y/N)? "; // Prompt
					cin >> AGAIN; // Fetch answer 
					cout << endl;
					}
			}
		else
			{
			cin.ignore(10,'\n'); // Clears register
			cout << "\nSorry, you must be able to follow instructions for this job.\n"
				 << "Please apply again when you understand why this message displayed.\n";
			
			cout << "\n\nRun the program again (Y/N)? ";
			cin.get(AGAIN);
			cout << endl;

			while(!(AGAIN == 'Y' || AGAIN == 'y' || AGAIN == 'N' || AGAIN == 'n'))
				{
				cin.ignore(10,'\n'); // Clears register
				cout << "\nInvalid entry. Please enter a Y or an N.\n";
				cout << "\nRun the program again (Y/N)? "; // Prompt
				cin >> AGAIN; // Fetch answer 
				cout << endl;
				}
			}
	}while(AGAIN == 'Y' || AGAIN == 'y');	
	
	system("pause");
	return 0;
}
