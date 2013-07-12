/**
 * Homework 4: GUI Tic Tac Toe Game
 * Program by: James Standeven
 * File Name: H4_GUI
 * Date: February 24, 2012
 */
 
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class H4_GUI extends JFrame
{
	
	//Members
	private static int turn = 0; // turn counter
	
	//North position on border layout
	private JLabel gameResult; // displays winner and draw message 
	private JPanel title; // holds gameResult and allows background color change
	
	//Center position on border layout
	private JPanel gamePanel; // panel to hold the game buttons
	private GridLayout gameGridLayout; // layout to use within gamePanel.
	
	//South position on border layout
	private JButton[] button; // game buttons
	private JPanel controlPanel; // panel that holds the control buttons and score
	private GridLayout controlGridLayout; // layout to use within controlPanel
	private JButton[] control; // control buttons
	private JLabel[] playerScore; // labels to show the score
	
	
	//Used for processes in the background
	private int [] score = {0, 0}; // keeps player scores
	private Icon [] pic;
	private Font message = new Font("", Font.BOLD, 16);
	
	//Methods
	public H4_GUI() // this is a constructor
	{
		pic = new ImageIcon[2];
		pic[0] = new ImageIcon(getClass().getResource("SvSB25.jpg")); // image for the black spy
		pic[1] = new ImageIcon(getClass().getResource("SvSW25.jpg")); // image for the white spy
		
		title = new JPanel();
		gameResult = new JLabel(); // label to show the game result
		
		gamePanel = new JPanel();
		gamePanel.setBackground(Color.black);
		gameGridLayout = new GridLayout(3, 3, 5, 5); // sets gameGridLayout to a 3x3 grid		
		button = new JButton[9]; // game buttons
		
		controlPanel = new JPanel();
		controlGridLayout = new GridLayout(2, 3, 5, 5); // sets controlGridLayout to a 3x2 grid
		control = new JButton[2]; // control buttons
		String[] controlName = {"Play Again", "Exit"}; // control button names
		playerScore = new JLabel [4]; // labels to show player scores
		String[] scoreName = {"Black wins: ", "0", "White wins: ", "0"}; // score label names
		
		
		setLayout(new BorderLayout());
		gamePanel.setLayout(gameGridLayout);
		controlPanel.setLayout(controlGridLayout);
		title.setLayout(new FlowLayout());
		
		gameResult.setFont(message);
		gameResult.setForeground(Color.white);
		gameResult.setText("Good luck");
		title.setBackground(Color.green);
		title.add(gameResult);
		add(title, BorderLayout.NORTH); // adds gameResult to the BorderLayout
		
		//Create instance of each game button and populate gamePanel
		for (int i = 0; i < button.length; i++)
		{
			button[i] = new JButton(); // create buttons	
			button[i].setPreferredSize(new Dimension(100, 150)); // set each button's size
			button[i].addActionListener(new MessageListener()); // add a listener to each button
			gamePanel.add(button[i]); // add buttons to the frame
		}
		
		add(gamePanel, BorderLayout.CENTER); // adds panel to H4_GUI frame
		
		//Create instance of each control button and playerScore label, and populate controlPanel
		for(int i = 0; i < 4; i++)
		{
			playerScore[i] = new JLabel(); // create the labels
			playerScore[i].setText(scoreName[i]); // set the text
			controlPanel.add(playerScore[i]); // add label to the control panel
			if(i == 1) // add a button at the end of the first row
			{
				control[0] = new JButton(); // create the button
				control[0].setText(controlName[0]); // set the text
				control[0].addActionListener(new MessageListener()); // add a listener to the button
				controlPanel.add(control[0]); // add the button to the control panel
			}
			if(i == 3) // add a button to the end of the last row
			{
				control[1] = new JButton(); // create the button
				control[1].setText(controlName[1]); // set the text
				control[1].addActionListener(new MessageListener()); // add a listener to the button
				controlPanel.add(control[1]); // add the button to the control panel
			}
		}
		
		getRootPane().setDefaultButton(control[0]); // sets the play again button as default
		control[0].setEnabled(false);
		add(controlPanel, BorderLayout.SOUTH); // adds panel to H4_GUI frame
	}
	
		private void resultTest()
		{
			boolean result = false;
			int column = 3;
			int row = 3;
			int numPlayer = 2;

			for(int testImage = 0; testImage < numPlayer && result == false; testImage++) // testImage represents the position in the image array that holds an image
			{
				int C; // Loop index

				//Test vertical
				for(C = 0; C < column; C++) // Check each column
				{
					int I; // Loop index
	
					for(I = 0; I < row * column - 1 && button[C + I].getIcon() == pic[testImage]; I += column); // Test each position in a column
						if(I > column * (row - 1)) result = true; // If all positions in a column are the same, change result to true
				}

				//Test horizontal
				for(C = 0; C < row * column -1; C += column) // Check each row
				{
					int I; // Loop index
	
					for(I = 0; I < column && button[C + I].getIcon() == pic[testImage]; I++); // Test each position in a row
						if(I > column - 1) result = true; // If all positionss in a row are the same, change result to true
				}

				if(row == column) // A diagonal test is only required if the row and column sizes are the same.
				{
					//Test diagonal
					int I = 0; // Counter

					for(C = 0; C < column * row; C += column + 1) // From the upper left position on the grid check diagonally 
					{
						if(button[C].getIcon() == pic[testImage]) I++; // Test the next diagonal position
			
						if(I > column - 1) result = true; // If all positions in a diagonal are the same, change result to true 
					}

					I = 0; // Counter

					for(C = column - 1; C < (column * (row - 1)) + 1; C += column - 1) // From the upper right position on the grid check diagonally 
					{
						if(button[C].getIcon() == pic[testImage]) I++; // Test the next diagonal position
		
						if(I > column - 1) result = true; // If all positions in a diagonal are the same, change result to true 
					}
				}
		
				//Congratulate winner
				if(result == true)
				{
					if(pic[testImage] == pic[0])
					{
						gameResult.setForeground(Color.black); // sets text color to black
						title.setBackground(Color.white); // sets background color to white
						gameResult.setText("Congratulations Black, you win!"); 
						playerScore[1].setText(Integer.toString(++score[0])); // displays the score for black
					}
					else
					{	
						gameResult.setForeground(Color.white); // sets text color to white
						title.setBackground(Color.black); // sets background color to black
						gameResult.setText("Congratulations White, you win!");
						playerScore[3].setText(Integer.toString(++score[1])); // displays the score for black
					}
			
					for(int bI = 0; bI < button.length; bI++)
						button[bI].setEnabled(false);
				}

				//Test for a draw

				if(result == false && turn == row * column)
				{		
					gameResult.setForeground(Color.white);
					title.setBackground(Color.red);
					gameResult.setText("That was a draw. Please try again.");
					result = true;
											
					for(int bI = 0; bI < button.length; bI++)
						button[bI].setEnabled(false);
				}
				
				if(result == true)
					control[0].setEnabled(true); // allows the use of the play again button
			}
		}
	
		
	//Private inner class
	private class MessageListener implements ActionListener
	{
		public void actionPerformed(ActionEvent event)
		{
			if(event.getSource() == control[0]) // play again button
				for(int bI = 0; bI < button.length; bI++)
				{
					button[bI].setIcon(null);
					button[bI].setEnabled(true);
					turn = 0;
					gameResult.setForeground(Color.white);
					gameResult.setText("Good luck");
					title.setBackground(Color.green);
					control[0].setEnabled(false); // disable the play again button
				}
			
			if(event.getSource() == control[1]) // exit button
				dispose();
				
			for(int i = 0; i < button.length; i++)
			{
				if(event.getSource() == button[i])
				{
					if(button[i].getIcon() == null)
					{
						if(turn % 2 == 0)
						{
							button[i].setIcon(pic[0]); // sets button icon to the black spy's image 
							turn++; // increment the turn counter	
						} 
						else
						{	
							button[i].setIcon(pic[1]); // sets button icon to the white spy's image
							turn++; // increment the turn counter
						}
					}
					resultTest();
				}	
			}
		}
	}
}
