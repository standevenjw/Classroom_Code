/*
 *Connect Four 
 *Programmed by: James Standeven
 *Date: Oct. 4, 2012
 */

#include <iostream>
#include <string>
#include <cstring>
#include <time.h>
#include <fstream>
using namespace std;

#define ROW 6
#define COL 7
#define SIZE 20 //size of arrays that hold names
#define DATESIZE 12
#define FILE "highscore.txt"

/*Structures*/
struct gamerNode
{
	string name;
	int wins;
	char date[DATESIZE]; //c-string to hold the date
	gamerNode *nodePtr; //pointer to a gamerNode
};


//Function prototypes
void printFile(string fileName);//receives a file name and prints it to console
void populateBoard(char board[][COL]);//fills board with blank spaces
void printBoard(char board[][COL]);//prints stylised board to console
string playBoard(char board[][COL]);//puts player input to board
bool test(char board[][COL]);//tests for a win or tie
bool horizTest(char board[][COL]);//tests for a horizontal win
bool vertTest(char board[][COL]);//tests for a horizontal win
bool diagTest(char board[][COL]);//tests for a diagonal win
bool tie(char board[ROW][COL]);//tests for a tie
string congrats(char board[][COL], int nextMove, int play2);//congratulates winner
void readScore(gamerNode **ptr);//reads in highscore.txt file
void printList(gamerNode *ptr);//prints linked list
void addNode(gamerNode **ptr, string player);//adds a node to the linked list
void sortList(gamerNode **ptr);//sorts the linked list in decending order
void writeScore(gamerNode **ptr);//writes to highscore.txt file

//Global variables
char playerName1[SIZE] = "Player 1";//initialised in case "3. Exit" is run before "1. Play"
char playerName2[SIZE] = "Player 2";//initialised in case "3. Exit" is run before "1. Play"

int main()
{
	int	menuItem;//receives players menu choice
	char gameBoard[ROW][COL];//stores player moves
	gamerNode *headPtr = NULL; //head pointer
	string winner;//stores the game winner
	
	//Load highscores into linked list
	readScore(&headPtr);//if the highscore.txt file exists this function reads it into the linked list

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
			case 1: //get names and play
				cout << "\nLet\'s Play a game!!!\n";
				cout << "Player 1 please enter your first name: \n";
				cout << " > ";
				cin.ignore(1);//clear the <cr> of the menuItem read
				cin.getline(playerName1, SIZE);
				cout << "Player 2 please enter your first name: \n";
				cout << " > ";
				cin.getline(playerName2, SIZE);
				system("cls");
				
				//Load gameBoard with blank spaces
				populateBoard(gameBoard);
				//Greet users
				cout << "\nWelcome " << playerName1 << " and " << playerName2 << ".\n\n";
				printBoard(gameBoard);//first display of board
				//Play game and return winner
				winner = playBoard(gameBoard);
				if(winner != "tie")
					addNode(&headPtr, winner);
				sortList(&headPtr);
				writeScore(&headPtr);
			break;
			case 2://display instructions
				printFile("instructions.txt");
			break;
			case 3://display Highscores
				cout << "\nName\tWins\tDate\n\n";
				//readScore(&headPtr);
				sortList(&headPtr);
				printList(headPtr);
				cout << "\n\n";
			break;
			case 4://exit
				cout << "\nGoodbye " << playerName1 << " and " << playerName2 << ".\n\n";
			break;
			default:
				cout << "\nThat is not a menu option.\n\n";
			break;
		}
	}while(menuItem != 4);
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

string playBoard(char board[ROW][COL])
{
	int player1 = 1,//stores an int to represent an ASCII character
		player2 = 2,//stores an int to represent an ASCII character
		player = player1,//tracks player turn
		column;//stores player choice
	string winner;//used to return the winning player's name
	
	do
	{
		//prompt and fetch user column choice
		if(player == player1) cout << playerName1;
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
						if(player == player1) player = player2;
						else player = player1;
					}
				}
			}
			else cout << "\n\tThat column is full.\n";
		}
		else cout << "\n\tThat is not a valid column number.\n";

		cout << "\n\t" << playerName1 << " = " << char(player1) << "\t" << playerName2 << " = " << char(player2) << "\n\n";//display player name and symbol
		printBoard(board);//reprint board
	}while(test(board));

	system("cls");
	cout << endl;

	winner = congrats(board, player, player2);
	
	return winner;
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

string congrats(char board[ROW][COL], int nextMove, int play2)
{
	string winner = "tie";
	
	if((!horizTest(board)) || (!vertTest(board)) || (!diagTest(board)))//check if the game ended in a win
	{
		if(nextMove == play2)//nextMove represents the next move, play2 is int that represents player2
		{
			cout << playerName1;
			winner = playerName1;			
		}
		else
		{
			cout << playerName2;
			winner = playerName2;
		}
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
	
	return winner;
}

void readScore(gamerNode **ptr)
{
	ifstream fileIn; //file pointer
	gamerNode *temp;
	temp = new gamerNode;

	fileIn.open(FILE);

	if(fileIn.is_open())
	{
		while(fileIn >> temp -> name)
		{	
			fileIn >> temp -> wins;
			fileIn.ignore(1);
			fileIn.getline(temp -> date, DATESIZE, '\n');
			temp -> nodePtr = NULL;
			if(*ptr == NULL) //is the list empty
			{
				/*Setting the head pointer to the new node*/
				*ptr = temp;
			}
			else //need to add new node to end of list
			{
				gamerNode *move = *ptr;
				//traverse the list until it reaches the end of the list(NULL)
				while(move -> nodePtr != NULL)
					move = move -> nodePtr;
				//set last node to the pointer to the new node
				move -> nodePtr = temp;
			}
			//allocating memory for new gamerNode
			temp = new gamerNode;
		}
		fileIn.close();
	}
}

void printList(gamerNode *ptr)
{
	//the loop will print each node until the end of the list(NULL)
	while(ptr != NULL)
	{
		cout << (ptr ->name) << "\t" << (ptr ->wins) << "\t" << (ptr ->date) << endl;
		//move to next node
		ptr = ptr -> nodePtr;
	}
}

void addNode(gamerNode **ptr, string player)
{
	time_t now = time(0);
	char today[DATESIZE];
	gamerNode *temp;
	temp = new gamerNode;
	gamerNode *move;
	move = new gamerNode;
	struct tm *timeinfo;

	timeinfo = localtime(&now);
	strftime (today, DATESIZE, "%a %b %d", timeinfo);
	
	temp -> name = player;
	temp -> wins = 1;
	strncpy(temp -> date, today, DATESIZE);
	temp -> nodePtr = NULL;

	if(*ptr == NULL) //is the list empty
	{
		*ptr = temp;
	}
	else
	{
		move = *ptr;
		if((move -> name) == player)
		{
			move -> wins = (move -> wins) + 1;
			return;
		}
		//traverse the list until it reaches the end of the list(NULL)
		while(move -> nodePtr != NULL)
		{
			move = move -> nodePtr;

			if((move -> name) == player)
			{
				move -> wins = (move -> wins) + 1;
				return;
			}
		}
		
		//set last node to the pointer to the new node
		move -> nodePtr = temp;
	}
}

void sortList(gamerNode **ptr)
{
	//create temp node pointers
	gamerNode *temp1 = new gamerNode; //allocate mem
	gamerNode *temp2 = new gamerNode; //allocate mem
	
	//temp variables to store data
	int tempWins;
	char tempDate[DATESIZE];
	string tempName;


	//do the sort by num of wins in decending order
	for(temp1 = *ptr; temp1 != NULL; temp1 = temp1 -> nodePtr)//points to first node
	{
		for(temp2 = temp1 -> nodePtr; temp2 != NULL; temp2 = temp2 -> nodePtr)//points to second node
		{
			if(temp1 -> wins < temp2 -> wins)// if first node's win value is smaller
			{
				//save data from temp1
				tempWins = temp1 -> wins;
				strncpy(tempDate,temp1 -> date, DATESIZE);
				tempName = temp1 -> name;

				//transfer data from temp2 to temp1
				temp1 -> wins = temp2 -> wins;
				strncpy(temp1 -> date, temp2 -> date, DATESIZE);
				temp1 -> name = temp2 -> name;

				//transfer saved data to temp2
				temp2 -> wins = tempWins;
				strncpy(temp2 -> date, tempDate, DATESIZE);
				temp2 -> name = tempName;
			}
		}
	}
}

void writeScore(gamerNode **ptr)
{
	ofstream fileOut; //file pointer
	fileOut.open(FILE);
	int numWin = 0;

	gamerNode *temp;
	temp = new gamerNode;
	temp = *ptr;

	if(fileOut.is_open())
	{
		while(temp != NULL && numWin < 10)
		{
			fileOut << temp -> name << ' ';
			fileOut << temp -> wins << ' ';
			fileOut << temp -> date << endl;
			temp = temp -> nodePtr;
			numWin++;
		}
		fileOut.close();
	}
}
