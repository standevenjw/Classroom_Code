/**
 * Homework 4: GUI Tic Tac Toe Game
 * Program by: James Standeven
 * File Name: H4_TGUI
 * Date: February 24, 2012
 */
 
 import java.awt.*; // allows the use of certain properties
 import javax.swing.*;
 
 public class H4_SpyGUI
 {
	public static void main(String[] args)
	{
	
		//Create a new frame
		H4_GUI frame = new H4_GUI(); // "frame" is the object's name
		
		//Edit frame properties
		frame.setTitle("Spy vs. Spy"); // sets title bar text
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); // stops application upon closing the frame
		frame.pack(); // autosizes to fit components
		frame.setLocationRelativeTo(null); // sets the frame location
		//Must be last line of code
		frame.setVisible(true); // makes the frame visible
	}
 }
 