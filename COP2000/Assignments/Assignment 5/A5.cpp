//Bowling Score
//Written by James Standeven
//Coded by James Standeven

#include <iostream>
using namespace std;
#include <iomanip>

int main()
{
	int COUNT;// Counts the number of iterations
	float	SCORE,// Reads input and stores in AVESCORE
			AVESCORE;// Accumulates and then holds average
	
	/*Title and intro*/
	cout << "BOWLING TEAM AVERAGE PROGRAM\n";
	cout << "============================\n\n";
	cout << "This program will repeatedly request and store the score of\n";
	cout << "an individual bowler and accumulate and count each one until\n";
	cout << "the user enters a negative score. After that, the program will\n";
	cout << "calculate and display the rounded team average.\n\n";
	
	/*Assignment*/
	COUNT = 0;
	AVESCORE = 0.0;
	
	/*Prime Read*/
	cout << "Player\'s score(negative number when done)? ";
	cin >> SCORE;
	
	/*Loop to get all scores*/
	while(SCORE >= 0)
	{
		AVESCORE += SCORE;
		
		cout << "Player\'s score(negative number when done)? ";
		cin >> SCORE;
		
		COUNT++;
	}
	
	/*Avoid dividing by 0*/
	if(COUNT != 0)
	{
		AVESCORE /= COUNT;
	}
	
	
	/*Display average*/
	cout << "\nTeam average: " << fixed << setprecision(0) << AVESCORE << endl;
	
	system("pause");
	return 0;
}
