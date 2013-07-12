/*
 *Connect Four in Class 
 *Programmed by: James Standeven
 *Date: Aug 30, 2012
 */

#include <iostream>
#include <string>
#include <fstream>
using namespace std;

int main()
{
	string playerName1 = "Player 1";
	string playerName2 = "Player 2";
	int menuItem;

	/*** Read in data from a file and print welcome screen ***/
	// create string to read data
	string dataIn;
	//open pointer
	ifstream inputFile;
	ifstream instrucFile;
	//open file
	inputFile.open("welcomeScreen.txt");

	//Read in file
	getline(inputFile, dataIn);

	while(inputFile) //will return true or false indicating the last dataIn read was good
	{
		//dislplay data
		cout << dataIn << endl;
		//get next line of data
		getline(inputFile, dataIn);
	}

	inputFile.close();

	do
	{
		//output menu
		cout << " 1. Play Game\n";
		cout << " 2. View Instructions\n";
		cout << " 3. Exit\n";
		cout << "> ";
		//read in player input
		cin >> menuItem;

		//clear the screen
		system("cls");

		//write switch for menu
		switch(menuItem)
		{
			case 1: 
				cout << "\nLet\'s Play a game!!!\n";
				cout << "Player 1 please enter your first name: \n";
				cout << " > ";
				cin >> playerName1;
				cout << "Player 2 please enter your first name: \n";
				cout << " > ";
				cin >> playerName2;
				cout << "\nWelcome " << playerName1 << " and " << playerName2 << ".\n";
			break;
			case 2:
				instrucFile.open("instructions.txt");
				getline(instrucFile, dataIn);
				while(instrucFile)
				{
					cout << dataIn << endl;
					getline(instrucFile, dataIn);
				}

				break;
			case 3:
				cout << "Goodbye " << playerName1 << " and " << playerName2 << ".\n";
			break;
			default:
				cout << "That is not a menu option.\n";
			break;
		}
	}while(menuItem != 3);
	return 0;
}
