/************************************************************************************************
 * Lesson 3: Circumference of a Circle															*
 * Programmed by: James Standeven																*
 * File Name: H1_Circumference.java																*
 * Function: This program will calculate the circumference of a circle given the radius (int).	*
 ************************************************************************************************/
 
 import java.io.*; // import statement
 
 public class H1_Circumference
 {
	public static void main(String[] args)throws IOException
	{
		/*Variable Declarations*/
		String input1; //input for radius
		int r; //radius of the circle
		double circumference, 
			   pi = 3.14; //pi represented as 3.14
		
		/*BufferedReader class declaration*/
		BufferedReader dataIn = new BufferedReader(new InputStreamReader (System.in));
		
		/*Prompt user for radius*/
		System.out.println("Enter the radius of the circle -> ");
		
		/*Get input*/
		input1 = dataIn.readLine();
		
		/*Convert input1 for calculation*/
		r = Integer.parseInt(input1);
		
		/*Calculate the circumference*/
		circumference = 2*pi*r;
		
		/*Display the result*/
		System.out.println("The circumference of the circle is: " + circumference);
	}
 }