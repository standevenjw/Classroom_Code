/************************************
 * Homework 2: Tic Tac Toe Game		*
 * Program by: James Standeven		*
 * File Name: H2_TicTacToe			*
 * Date: January 23, 2012			*
 ************************************/
 
 import java.io.*;
 import java.util.Scanner;
 
 public class H2_TicTacToe
 {
	public final int ROW = 3;// Number of rows in the grid
	public final int COLUMN = 3;// Number of columns in the grid
	public final int NUMPLAYER = 2;// The number of players
	
	public static void main(String[] args)throws IOException
	{
		/*Variable Declaration*/
		String[] gridPosition = new String[ROW * COLUMN];// Array that holds the grid positions
		String[] playerChar = {"X","O"};// Array that represents player characters
		int input; // Keyboard input 
		String inputS; // Keyboard input
		Scanner dataIn = new Scanner(System.in);
		Scanner dataIn2 = new Scanner(System.in);
		
		do
		{
			/*Variable Declaration*/
			int	turn = 0;// Turn counter
			boolean result = false;// This stores when a game ends(win or draw).
			
			/*Populate gridPosition*/
			loadArray(ROW, COLUMN, gridPosition);
	
			/*Advance the screen*/
			cls();
				
			/*Welcome Statement*/
			System.out.println("Welcome to Tic-tac-toe.");
			System.out.println("Enjoy the game.");
			
			/*Game loop*/
			// Loop until there is a winner or a tie
			while(result == false)
			{
				/*Display board and prompt for the user's move*/
				System.out.println("\n\nChoose the number associated with the space where you want to move: \n");
				displayGrid(ROW, COLUMN, gridPosition);
				System.out.print("\nWhat is your next move? ");
			
				/*Get input and update gridPosition[]*/
				input = dataIn.nextInt();
				turn = inputAssign(input, turn, playerChar, gridPosition, ROW, COLUMN, NUMPLAYER);
				
				/*Check the result*/
				result = resultTest(ROW, COLUMN, gridPosition, playerChar, NUMPLAYER, turn);
			}
			
			/*Prompt for another game*/
			System.out.print("\n\nPlay again?(Y/N) ");
			
			/*Fetch user response*/
			inputS = dataIn2.nextLine();
		
		}while(inputS.equals("Y") || inputS.equals("y"));	
	}
	
	/*loadArray puts numerals into an array whose size is defined by row times column*/
	public static void loadArray(int row, int column, String[] array)
	{
		for(int C = 0; C < row * column; C++)
		{
			String num = C + "";// convert C to a string
			array[C] = num;// assign num to array sub C
		}
	}
	
	/*displayGrid displays the array passed to it in a grid*/
	public static void displayGrid(int row, int column, String[] displayArray)
	{
		int C,// Loop index
			I,// Loop index
			X;// Loop index
			
		for(C = 0; C < row * column - 1; C += column)// Grid with "row" number of rows
		{
			System.out.print("\n ");// Newline and space to start a row

			for(I = 0; I < column; I++)// Grid with "column" number of columns
			{
				System.out.printf("%2s",displayArray[C + I]);
				if(I < column - 1)// Add spacer to the end of all but the last column
					System.out.print(" | ");
				if(I == column - 1 && C < column * (row - 1))// Add a row spacer to all but the last row
					{
					System.out.println("");// Newline
					for(X = 0; X < column - 1; X++)
						System.out.print("-----");// Each column needs 5 dashes
					System.out.print("----");// Last column needs 4 dashes 
					}
			}
		}
	
		System.out.print("\n\n");// Two newlines
	}
	
	/*inputAssign assigns a character stored in the array pointed to by player1 
	  into the array pointed to by move1 based on which turn it is. Works for "numPlayer" number of players.*/
	public static int inputAssign(int input1, int turn1, String[] player1, String[] move1, int row, int column, int numPlayer)
	{	
		if(input1 >= 0 && input1 < row * column)
		{
			String input = Integer.toString(input1);
			
			if(move1[input1].equals(input))// Check if the space has been filled
				{
					move1[input1] = player1[turn1 % numPlayer];// Assign user's choice
					turn1++;// Increment the turn counter
				
					/*Advance the screen*/
					cls();
				}
				else
				{	
					/*Advance the screen*/
					cls();
					
					System.out.println("\nThat position has already been selected.");// Notify the user if the position is taken
				}
		}
		else
		{
			/*Advance the screen*/
			cls();
			
			System.out.println("\nEnter a valid position number.");
		}	
		
	return turn1;
	}
	
	/*resultTest tests a String array for the same string in a row(horizontal, vertical, diagonal) on a grid*/
	public static boolean resultTest(int row, int column, String[] move2, String[] player2, int numPlayer, int turn1)
	{
		boolean result1 = false;
		for(int testChar = 0; testChar < numPlayer && result1 == false; testChar++)// testChar represents the position in the player2 array that holds a character
		{
			int C; // Loop index
			
			/*Test vertical*/
			for(C = 0; C < column; C++)// Check each column
			{
				int I; // Loop index
				
				for(I = 0; I < row * column - 1 && move2[C + I] == player2[testChar]; I += column);// Test each position in a column
					if(I > column * (row - 1)) result1 = true;// If all positions in a column are the same, change result1 to true
			}
			
			/*Test horizontal*/
			for(C = 0; C < row * column -1; C += column)// Check each row
			{
				int I;// Loop index
				
				for(I = 0; I < column && move2[C + I] == player2[testChar]; I++);// Test each position in a row
					if(I > column - 1) result1 = true;// If all positionss in a row are the same, change result1 to true
			}
			
			if(row == column)// A diagonal test is only required if the row and column sizes are the same.
			{
				/*Test diagonal*/
				int I = 0;// Counter

				for(C = 0; C < column * row; C += column + 1)// From the upper left position on the grid check diagonally 
				{
					if(move2[C] == player2[testChar]) I++;// Test the next diagonal position
						
					if(I > column - 1) result1 = true;// If all positions in a diagonal are the same, change result1 to true 
				}
			
				I = 0;// Counter

				for(C = column - 1; C < (column * (row - 1)) + 1; C += column - 1)// From the upper right position on the grid check diagonally 
				{
					if(move2[C] == player2[testChar]) I++;// Test the next diagonal position
					
					if(I > column - 1) result1 = true;// If all positions in a diagonal are the same, change result1 to true 
				}
			}
			/*Congratulate winner*/
			if(result1 == true)
			{
				System.out.println("Congratulations " + player2[testChar] + ", you win!\n");
				displayGrid(row, column, move2);
				System.out.println("\nCongratulations " + player2[testChar] + ", you win!");
			}
			
			/*Test for a draw*/
			
			if(result1 == false && turn1 == row * column)
			{					
				System.out.println("That was a draw. Please try again.\n");
				displayGrid(row, column, move2);
				System.out.println("\nThat was a draw. Please try again.");
				result1 = true;
			}
		}		

		return result1;
	}
	
	/*Adds 30 empty lines*/
	public static void cls()
	{
		for(int C = 0; C < 31; C++)
			System.out.println("");
	}
 }
 