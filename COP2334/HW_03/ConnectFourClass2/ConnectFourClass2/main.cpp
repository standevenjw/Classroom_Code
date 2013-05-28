/*
 *Connect Four in Class 
 *Programmed by: James Standeven
 *Date: Aug 30, 2012
 */

#include <iostream>
#include <string>
#include <fstream>
using namespace std;

#define ROW 6
#define COL 7
#define SIZE 60 //size of arrays that hold names

//Function prototypes
void printFile(string fileName);//receives a file name and prints it to console
void populateBoard(char board[][COL]);//fills board with blank spaces
void printBoard(char board[][COL]);//prints stylised board to console
void playBoard(char board[][COL], int p1, int p2);//puts player input to board
bool test(char board[][COL]);//tests for a win or tie
bool horizTest(char board[][COL]);//tests for a horizontal win
bool vertTest(char board[][COL]);//tests for a horizontal win
bool diagTest(char board[][COL]);//tests for a diagonal win
bool tie(char board[ROW][COL]);//tests for a tie
void congrats(char board[ROW][COL], int nextMove, int play2);//congratulates winner

//Global variables
char playerName1[SIZE] = "Player 1";//initialised in case "3. Exit" is run before "1. Play"
char playerName2[SIZE] = "Player 2";//initialised in case "3. Exit" is run before "1. Play"


int main()
{
	int player1 = 1,//stores an int to represent an ASCII character
		player2 = 2,//stores an int to represent an ASCII character
		menuItem;//receives players menu choice
	char gameBoard[ROW][COL];//stores player moves
	

	//Display welcome screen
	printFile("welcomeScreen.txt");

	do
	{
		//Print menu
		printFile("menu.txt");

		cout << "\nPlease choose an option: ";

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
				cin.ignore(1);
				cin.getline(playerName1, SIZE);
				cout << "Player 2 please enter your first name: \n";
				cout << " > ";
				cin.getline(playerName2, SIZE);
				system("cls");
				
				//Load gameBoard with blank spaces
				populateBoard(gameBoard);
				cout << "\nWelcome " << playerName1 << " and " << playerName2 << ".\n\n";
				printBoard(gameBoard);//first display of board
				playBoard(gameBoard, player1, player2);
			break;
			case 2:
				printFile("instructions.txt");
			break;
			case 3:
				cout << "\nGoodbye " << playerName1 << " and " << playerName2 << ".\n\n";
			break;
			default:
				cout << "\nThat is not a menu option.\n\n";
			break;
		}
	}while(menuItem != 3);
	return 0;
}

void printFile(string fileName)
{	
	/*** Read in data from a file and print the contents of a file ***/
	// create string to read data
	string dataIn;
	//open pointer
	ifstream inputFile;
	//open file
	inputFile.open(fileName);

	//Read in file
	getline(inputFile, dataIn);

	while(inputFile) //will return true or false indicating the last dataIn read was good
	{
		//dislplay data
		cout << dataIn << endl;
		//get next line of data
		getline(inputFile, dataIn);
	}
	//release the file
	inputFile.close();
}

void populateBoard(char board[ROW][COL])
{
	for(int r = 0; r < ROW; r++)
		for(int c = 0; c < COL; c++)
			board[r][c] = ' ';
}

void printBoard(char board[ROW][COL])
{	
	for(int r = 0; r <= ROW; r++)
	{
		/*** Build the board ***/
		cout << "\t";
		
		//Line spacer
		for(int c = 0; c < COL; c++)
		{
			cout << "----";
			if(c == COL - 1) cout << "-\n";
		}

		//Playable spaces
		if(r < ROW)
		{
			cout << "\t";
			for(int c = 0; c < COL; c++)
			{
				cout << "| " << board[r][c] << " ";
				if(c == COL - 1) cout << "|\n";
			}
		}
		
		
		//Label columns
		if(r == ROW)
		{
			cout << "\t";

			for(int c = 0; c < COL; c++)
			{
				cout << "  " << c + 1 << " "; // Columns are give a number one greater than their array subscript number
				if(c == COL - 1) cout << " \n\n";
			}
		}
	}	
}

void playBoard(char board[ROW][COL], int p1, int p2)
{
	int player = p1,//tracks player turn
		column;//stores player choice

	do
	{
		//prompt and fetch user column choice
		if(player == p1) cout << playerName1;
		else cout << playerName2;
		cout << ", in which column do you wish to place a piece[1-7]? ";
		cin >> column;
		
		system("cls");//clear screen
		if(column > 0 && column <= COL)//check that it is a valid column number
		{
			if(board[0][column-1] == ' ')
			{
				for(int r = ROW - 1; r >= 0; r--)
				{
					if(board[r][column - 1] == ' ')//check for blank space
					{
						board[r][column - 1] = player;//assign player's char to the board
						r = -1;//escape for loop
						//switch player characters
						if(player == p1) player = p2;
						else player = p1;
					}
				}
			}
			else cout << "\n\tThat column is full.\n";
		}
		else cout << "\n\tThat is not a valid column number.\n";

		cout << "\n\t" << playerName1 << " = " << char(p1) << "\t" << playerName2 << " = " << char(p2) << "\n\n";//display player name and symbol
		printBoard(board);//reprint board
	}while(test(board));

	system("cls");
	cout << endl;

	congrats(board, player, p2);
}

bool test(char board[ROW][COL])
{
	bool result = true;

	result = horizTest(board);
	if(result) result = vertTest(board);
	if(result) result = diagTest(board);
	if(result) result = tie(board);

	return result;
}

bool horizTest(char board[ROW][COL])
{
	bool result = true;

	for(int r = ROW - 1; r >= 0; r--)//check each row
	{
		int a = 1;//accumulator
		
		for(int c = 0; c < COL - 1; c++)//check each position on the row except the last
		{
			if(board[r][c] != ' ' && board[r][c] == board[r][c + 1])//compare non-empty positions against their neighbour 
			{
				a++;//increment the accumulator
				if(a == 4) result = false;//denote a winner has been found
			}
			else a = 1;//reset accumulator before moving on
		}
	}
	return result;//pass to parent
}

bool vertTest(char board[ROW][COL])
{
	bool result = true;

	for(int c = 0; c < COL; c++)//check each column
	{
		int a = 1;//accumulator

		for(int r = ROW - 1; r > 0; r--)//check each position in the column except the last
		{
			if(board[r][c] != ' ' && board[r][c] == board[r + 1][c])//compare non-empty positions against thier neighbour
			{
				a++;//increment the accumulator
				if(a == 4) result = false; //denote a winner has been found
			}
			else a = 1;//reset accumulator
		}
	}
	return result;//pass to parent
}

bool diagTest(char board[ROW][COL])
{
	bool result = true;
	for(int c = 0; c < COL/2 + 1; c++)//check columns 0 through 3
	{
		for(int r = ROW - 1; r > ROW/2 - 1; r--)//check positions 5 through 3 of each column checked
		{
			if(board[r][c] != ' ')//do the following if space is not empty
			{
				int x = 0;//accumulator
				while(board[r][c] == board[r - x][c + x])//check for rising diagonal
				{
					x++;//increment accumulator
					if(x == 4) result = false;//denote a winner has been found
				}
			}
		}
	}
	for(int c = 0; c < COL/2 + 1; c++)//check columns 0 through 3
	{
		for(int r = 0; r < ROW/2; r++)//check positions 0 through 2 on each column checked
		{
			if(board[r][c] != ' ')//do the following if space is not empty
			{
				int x = 0;//accumulator
				while(board[r][c] == board[r + x][c + x])//check for falling diagonal
				{
					x++;//increment accumulator
					if(x == 4) result = false;//denote a winner has been found
				}
			}
		}
	}
	return result;//return to parent
}

bool tie(char board[ROW][COL])
{
	bool result = true;
	int tie = 0;//accumulator

	for(int r = 0; r < ROW; r++)//check each row starting from the top
		for(int c = 0; c < COL; c++)//check each column in the row
			if(board[r][c] != ' ') tie++;//increment accumulator if the space is not empty
	if(tie == (ROW * COL)) result = false;//denote a tie if all spaces are filled

	return result;//pass to parent
}

void congrats(char board[ROW][COL], int nextMove, int play2)
{
	if((!horizTest(board)) || (!vertTest(board)) || (!diagTest(board)))//check if the game ended in a win
	{
		if(nextMove == play2)//nextMove represents the next move
			cout << playerName1;
		else cout << playerName2;
		cout << " won with a "; 
		if(!horizTest(board)) cout << "horizontal";//horizTest() returns false if a horizontal win is found
		else if(!vertTest(board)) cout << "vertical";//vertTest() returns false if a vertical win is found
		else cout << "diagonal";//diagTest() returns false if a diagonal win is found
		cout << " line. Congratulations!\n\n";
	}
	else//if no win is found
	{
		cout << "\nThe game ended in a tie. \nThanks for playing " << playerName1 
			 << " and " << playerName2 << "\n\n";
	}
	printBoard(board);
}