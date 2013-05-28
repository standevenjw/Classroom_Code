/*Inclass September 20, 2012*/

#include <iostream>
#include <string>
#include <time.h>
#include <fstream>

#define SIZE 12

using namespace std;

/*Structures*/
struct gamerNode{
	string name;
	int wins;
	char date[SIZE]; //c-string to hold the date
	gamerNode *nodePtr; //pointer to a gamerNode
};

/*Function Protocols*/
void readWin(gamerNode **ptr); //read in winner file
void printList(gamerNode *ptr); //print the singly linked list
void sortList(gamerNode **ptr); //sort the singly linked list

int main(){
	gamerNode *headPtr = NULL; //head pointer

	time_t cTime = time(0);
	cout << ctime(&cTime) << endl;
	readWin(&headPtr);
	sortList(&headPtr);
	printList(headPtr);
	return 0;
}

void readWin(gamerNode **ptr){
	ifstream fileIn; //file pointer
	fileIn.open("gamersWin.txt");

	gamerNode *temp;
	temp = new gamerNode;

	while(!fileIn.eof())
	{
		fileIn >> temp -> name;
		fileIn >> temp -> wins;
		fileIn.getline(temp -> date, SIZE, '\n');
		temp -> nodePtr = NULL;

		if(*ptr == NULL) //is the list empty
			/*Setting the head pointer to the new node*/
			*ptr = temp;
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

void printList(gamerNode *ptr)
{
	//the loop will print each node until the end of the list(NULL)
	while(ptr != NULL)
	{
		cout << ptr ->name << " " << ptr ->wins << ptr ->date << endl;
		//move to next node
		ptr = ptr ->nodePtr;
	}
}

void sortList(gamerNode **ptr)
{
	//create temp node pointers
	gamerNode *temp1 = new gamerNode; //allocate mem
	gamerNode *temp2 = new gamerNode; //allocate mem
	
	//temp variables to store data
	int tempWins;
	char tempDate[SIZE];
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
				strncpy(tempDate,temp1 -> date, SIZE);
				tempName = temp1 -> name;

				//transfer data from temp2 to temp1
				temp1 -> wins = temp2 -> wins;
				strncpy(temp1 -> date, temp2 -> date, SIZE);
				temp1 -> name = temp2 -> name;

				//transfer saved data to temp2
				temp2 -> wins = tempWins;
				strncpy(temp2 -> date, tempDate, SIZE);
				temp2 -> name = tempName;
			}
		}
	}
}
