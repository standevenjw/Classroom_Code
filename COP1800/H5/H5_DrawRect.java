/**
 * Homework 5: Draw Rectangle Program
 * Programmed by: James Standeven
 * Date: March 14, 2012
 * File name: H5_DrawRect.java
 * Function: Draws a rectangle according to the height and width the user enters.
 */

import java.applet.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.geom.*;

public class H5_DrawRect extends Applet implements ActionListener, KeyListener, FocusListener
{
	//Variable declarations
	int height = 0, // height of rectangle
		width = 0; // width of rectangle

	//Components
	Panel outerPanel = new Panel(new BorderLayout()); // panel to be placed on the applet
	Label insLabel = new Label("Enter the height and width of the rectangle."); // instruction label
	Panel innerPanel = new Panel(new GridLayout(2, 2)); // label and textfield holder
	Label heightLabel = new Label("Height: ");
	TextField heightField = new TextField();
	Label widthLabel = new Label("Width: ");
	TextField widthField = new TextField();
	Button drawButton = new Button("Draw");
	Label errorLabel = new Label("");

	public void init()
	{
		setLayout(new BorderLayout()); // applet layout
		setBackground(Color.black); // applet fill color

		heightLabel.setForeground(Color.blue); // sets font color
		innerPanel.add(heightLabel);
		heightField.addKeyListener(this); // listens for "enter" key release
		heightField.addFocusListener(this); // listens for focus gain
		innerPanel.add(heightField);
		widthLabel.setForeground(Color.blue); // sets font color
		innerPanel.add(widthLabel);
		widthField.addKeyListener(this); // listens for "enter" key release
		widthField.addFocusListener(this); // listens for focus gain
		innerPanel.add(widthField);

		insLabel.setForeground(Color.blue); // sets font color
		outerPanel.add(insLabel, BorderLayout.NORTH);
		outerPanel.add(innerPanel, BorderLayout.CENTER);
		drawButton.addActionListener(this); // listens for click action
		drawButton.addKeyListener(this); // listens for "enter" key release
		outerPanel.add(drawButton, BorderLayout.SOUTH);
		
		add(outerPanel, BorderLayout.NORTH);
		add(errorLabel, BorderLayout.SOUTH);
	}

	public void paint(Graphics g)
	{
		Graphics2D g2 = (Graphics2D) g;
		g2.setPaint(Color.blue); // sets rect color
		g2.fill(new Rectangle.Double(10, 100, width, height));
	}

	public void actionPerformed(ActionEvent e)
	{
		if(e.getSource() == drawButton)
		{
			errorLabel.setText(""); // resets error label

			height = Integer.parseInt(heightField.getText()); // reads-in user-defined height
			width = Integer.parseInt(widthField.getText()); // reads-in user-defined width

			if(height > 0 && height <= 400 && width > 0 && width <= 400)
			{
				this.repaint(); // adds the paint() to the queue
			}
			else
			{
				errorLabel.setForeground(Color.red); // sets font color
				errorLabel.setText("The width and height must be between 1 and 400 inclusive."); // sets error label text
			}
		}
	}

	public void keyReleased(KeyEvent e)
	{
		if(e.getKeyCode() == KeyEvent.VK_ENTER)
		{
			ActionEvent ae = new ActionEvent((Object)drawButton, ActionEvent.ACTION_PERFORMED, ""); // creates a drawButton action event
			Toolkit.getDefaultToolkit().getSystemEventQueue().postEvent(ae); // adds the previously created event to the system queue
		}
	}
	
	public void keyPressed(KeyEvent e){} // will not compile if this method is not overriden
	public void keyTyped(KeyEvent e){} // will not compile if this method is not overriden
	
	public void focusGained(FocusEvent e)
	{
		if(heightField.isFocusOwner()) // checks to see if heightField has the focus
			heightField.selectAll(); // selects all text in the heightField
		
		if(widthField.isFocusOwner()) // checks to see if widthField has the focus
			widthField.selectAll();	// selects all text in the widthField
	}
	
	public void focusLost(FocusEvent e){} // will not compile if this method is not overriden
}
