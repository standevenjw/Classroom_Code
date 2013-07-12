/*
 * Project name: Connect_Four
 * Designed and Coded by: James Standeven
 * Date: Thurs. Aug. 30
 */

#include <iostream>
#include <string>
using namespace std;



int main()
{
	string player1 = "Player 1"; // holds player's name
	string player2 = "Player 2"; // holds another players name
	int mChoice; // receives user's menu choice

	do
	{
		cout << "1. Play Game\n2. View Instructions\n3. Exit\n";
		cout << "\nEnter your menu choice: ";
		cin >> mChoice;

		switch(mChoice)
	{
		case 1: 
			cout << "Let\'s Play a Game\n\n";
			cout << "Player 1 please enter your first name: ";
			cin >> p1;
			cout << "Player 2 please enter your first name: ";
			cin >> p2;
			cout << "\nWelcome " << p1 << " and " << p2 << "!\n\n";
		break;
		case 2:
			cout << "**********************Game Play Instructions***********************\n";
			cout << "* The goal of the game is to ";
		break;
		case 3:
			cout << "\n\nGoodbye " << p1 << " and " << p2 << ".\n";
		break;
	}
	}while(mChoice != 3);

	return 0;
}