/*****************************************************
 * Account Generating Program						 *
 * Written by: Randolph Gibson						 *
 * Coded by: James Standeven - November 17, 2011	 *
 *****************************************************/

#include <iostream>
using namespace std;
#include <cstring>

#define NSIZE 15 // Maximum size of input names
#define SSNSIZE 9 // Maximum size of Social Security Number
#define USIZE 8 // Maximum size of Username
#define PSIZE 9 // Maximum size of Password

int main()
{
	char FIRST[NSIZE + 1], // Customer's First Name
		 LAST[NSIZE + 1], // Customer's Last Name
		 SSN[SSNSIZE + 1], // Customer's Social Security Number
		 UNAME[USIZE + 1], // Customer's Account Name
		 PWORD[PSIZE + 1]; // Customer's Password
	int PS, // Character position in a source string
		PT; // Character position in a target string
	
	/*Intro and Credits*/
	cout << "Account Generating Program.\n";
    cout << "Written by James Standeven - 11/17/2001\n\n";
    
	/*Prompt and Fetch first name*/
    cout << "First Name? ";
    cin.getline(FIRST, NSIZE + 1); // changed from (cin >> FIRST;)
	
	/*Make all lower case*/
	for(PS = 0;  PS < strlen(FIRST); PS++)
		if(isupper(FIRST[PS]))
			FIRST[PS] = tolower(FIRST[PS]);
	
	/*Prompt and Fetch last namre*/
	cout << "Last Name? ";
    cin.getline(LAST, NSIZE + 1); // changed from (cin >> LAST;)
	
	/*Make all lower case*/
	for(PS = 0;  PS < strlen(LAST); PS++)
		if(isupper(LAST[PS]))
			LAST[PS] = tolower(LAST[PS]);

	/*Prompt and Fetch Social Security of only 9 digits*/
	do
	{
		cout << "Social Security # (digits only)? ";
		cin >> SSN;
	}while(strlen(SSN) != SSNSIZE);
	
	/*Construct Username*/
	PT = 0;
	
	while(PT < USIZE && PT < strlen(LAST) + 4)
	{
		for(PS = 0; PS < 4 && PS < strlen(LAST); PS++)
		{
			UNAME[PT] = LAST[PS];
			PT++;
		}
		
		for(PS = 5; PS < SSNSIZE; PS++)
		{	
			UNAME[PT] = SSN[PS];
			PT++;
		}
	}

	UNAME[PT] = '\0';
	
	/*Construct Password*/
	PT = 0;
	
	while(PT < PSIZE && PT < strlen(FIRST) + 5)
	{
		for(PS = 0; PS < 5; PS++)
		{
			PWORD[PT] = SSN[PS];
			PT++;
		}
		
		for(PS = 0; PS < 4 && PS < strlen(FIRST); PS++)
		{	
			PWORD[PT] = FIRST[PS];
			PT++;
		}
	}

	PWORD[PT] = '\0';

	/*Display Username and Password*/
	cout << "\nUsername: " << UNAME << endl;
	cout << "Password: " << PWORD << endl;
	
	system("pause"); // for analysis
    return 0; // Return proper termination message to OS
}
