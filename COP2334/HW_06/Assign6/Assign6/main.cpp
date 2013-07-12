/*Homework 6
  Coded by: James Standeven
  Date: November 1, 2012
*/

#include <iostream>
#include <string>
using namespace std;

//Function prototypes
void convertTo10(string, int, double, int, int, unsigned long long *); //converts to base 10
void convertFrom10(unsigned long long, int); //converts from base 10
void menu(char *); //displays menu options and prompts user for a response
void repeat(char *); //allows user to start from the beginning


int main() {
	char choice; //menu choice 
	int	tBase = 0, //target base
		count, //loop counter
		index; //string index
	unsigned long long value, //value passed to convertFrom10
					   result; //result passed to convertTo10
	string valueStr; //value passed to convertTo10
	double sBase; //source base

	menu(&choice); //initial menu prompt

	do {
		switch(choice) {
		case '1':
			sBase = 2.0; //from base 2
			tBase = 10; //to base 10
			result = 0; //reset result
			count = 0; //reset count

			break;
		case '2':
			sBase = 10.0; //from base 10
			tBase = 2; //to base 2
		
			break;
		case '3':
			sBase = 10.0; //from base 10
			tBase = 16; //to base 16

			break;
		case '4':
			sBase = 16.0; //from base 16
			tBase = 10; //to base 10
			result = 0; //reset result
			count = 0; //reset count

			break;
		case '5':
			cout << "\nExiting.\n\n"; //exit message
			break;
		default:
			menu(&choice); //Display menu if proper input is not received
		}

		if(tBase == 10) {
			cin.ignore();
			//Prompt user for appropriate value
			cout << "\n\nEnter a ";
			if(sBase == 2.0) cout << "binary";
			else cout << "hexadecimal";
			cout << " value: ";
			getline(cin, valueStr); //get value from user
			index = valueStr.length() - 1; //assign a value to index that points to the right most element
			convertTo10(valueStr, tBase, sBase, count, index, &result); //calculate the value
			cout << valueStr << " equals " << result << " in base 10.\n"; //output results
			repeat(&choice); //restart from the beginning
			tBase = 0; //reset tBase because it is used in exposed conditional statements			
		}
		else if(tBase == 2 || tBase == 16) {
			cout << "\n\nEnter a base 10 value: "; //prompt user for value
			cin >> value; //get value from user
			cout << "\n" << value << " equals "; 
			convertFrom10(value, tBase); //calculate and output results
			cout << " in ";
			if(tBase == 2) cout << "binary";
			else cout << "hexadecimal";
			cout << ".\n";
			repeat(&choice); //restart from the beginning
			tBase = 0; //reset tBase because it is used in exposed conditional statements
		}

	}while(choice != '5'); //repeat until choice is set to 5
}

void convertTo10(string value, int tBase, double sBase, int count, int index, unsigned long long *result) {
	if(index < 0) return; //exit when index reaches -1
	int num = 0; //stores a decimal value
	if(sBase == 16.0) {
		if(toupper(value[index]) > 64 && toupper(value[index]) < 71) { // 65 to 70 represent A to F
			num = toupper(value[index]) - 55; //produces valid hex numbers
		}
		else if(toupper(value[index]) > 47 && toupper(value[index]) < 59) { //48 to 58 represent 0 to 9
			num = value[index] - 48; //produces valid numbers
		}
		else { //all other values are invalid
			cout << "\n*** ERROR: Invalid input. ***\n\n";
			return;
		}
	}
	else if(sBase == 2.0) {
		if(value[index] > 47 && value[index] < 50) { //48 and 49 represent 0 and 1
			num = value[index] - 48; //produces valid numbers
		}
		else { //all other values are invalid
			cout << "\n*** ERROR: Invalid input. ***\n\n";
			return;
		}
	}

	*result += static_cast<unsigned long long>(num * pow(sBase, count)); //remainder * (base ^ count)

	count++;
	index--; //move index to the left
	convertTo10(value, tBase, sBase, count, index, result); //call recursively
}


void convertFrom10(unsigned long long value, int tBase) {
	if(value == 0) return ; //exit once value equals zero

	convertFrom10(value/tBase, tBase); //update value and call recursively
	
	switch (value % tBase) { //pass remainder to switch 
	case 10: //represented by A in hex
		cout << "A";
		break;
	case 11: //represented by B in hex
		cout << "B";
		break;
	case 12: //represented by C in hex
		cout << "C";
		break;
	case 13: //represented by D in hex
		cout << "D";
		break;
	case 14: //represented by E in hex
		cout << "E";
		break;
	case 15: //represented by F in hex
		cout << "F";
		break;
	default:
		cout << value % tBase; //values 0 to 9 sent to stdout
	}
}

void menu(char *choice){
	system("cls");
	cout << "**********************************************\n";
	cout << "*          Conversion Calculator             *\n";
	cout << "**********************************************\n\n";

	cout << "1. Binary to decimal.\n";
	cout << "2. Decimal to binary.\n";
	cout << "3. Decimal to hexadecimal.\n";
	cout << "4. Hexadecimal to Decimal.\n";
	cout << "5. Exit.\n\n";
	cout << "Select the conversion type to execute: ";
	cin >> *choice;
}

void repeat(char *choice) {
	char again;
	cout << "\nDo another conversion? [y/n] ";
	cin >> again;
	if(toupper(again) == 'Y') {
		menu(choice);
	}
	else *choice = '5'; //exits programm
}
