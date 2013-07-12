/**
 * File name: H3_AgeGUI
 * Coded by: James Standeven on February 10, 2012
 * Description: Gets the user's age and displays a message, depending on that age, in a GUI.
 */

import javax.swing.*; // Allows JOptionPane class

public class H3_AgeGUI
{
	public static void main(String[] args)
	{
		boolean inputTest = false; // Changes when the input value is valid
		String enterAge = null; // Receives input from GUI object
		
		while(inputTest == false) // Tests user input
		{
			enterAge = JOptionPane.showInputDialog(null, "Enter your age, please."); // get user input
			
			int C; // loop counter
			
			for(C = 0; C < 151; C++)
			{
				if(enterAge.equals(C + "")) // compares enterAge to the string C
					inputTest = true; // assign true to inputTest when enterAge is valid
			}
			if(C > 150 && inputTest == false)
				JOptionPane.showMessageDialog(null, "That is not valid input."); // warning to user
		}

		int age = Integer.parseInt(enterAge); // assign a good value to age
		
		/*Message selection algorithm*/
		if(age < 13) // message for 12 and under
			JOptionPane.showMessageDialog(null, "You're " + age + "...Howdy youngster!");
		else if(age < 20) // message for 13 to 19
			JOptionPane.showMessageDialog(null, "You're " + age + "...Howdy, you're on your way!");
		else if(age < 40) // message for 20 to 39
			JOptionPane.showMessageDialog(null, "You're " + age + "...Howdy, you're a mover and a shaker!");
		else if(age < 91) // message for 40 to 90
			JOptionPane.showMessageDialog(null, "You're " + age + "...Howdy, old timer!");
		else if(age < 123) // message for 91 to 122
			JOptionPane.showMessageDialog(null, "You're " + age + "...Howdy! Are you really that old?");
		else if(age < 131) // message for 123 to 130
			JOptionPane.showMessageDialog(null, "You're " + age + "...Howdy! You've set a new record!");
		else // too large of a number
			JOptionPane.showMessageDialog(null, "That can't be right!");
	}
} 
