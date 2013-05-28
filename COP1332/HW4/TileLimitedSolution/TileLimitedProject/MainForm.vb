'Progammed by: James Standeven
'Project: Homework 3 - Tile Limited
'Date: January 18, 2012

Option Explicit On
Option Infer On
Option Strict On

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub


    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        'Declare variables
        Dim length As Double
        Dim width As Double
        Dim price As Double
        Dim area As Double
        Dim total As Double

        'Use input from user
        Double.TryParse(lengthTextBox.Text, length)
        Double.TryParse(widthTextBox.Text, width)
        Double.TryParse(priceTextBox.Text, price)

        'Calculate and display area
        area = length * width
        areaLabel.Text = area.ToString("N2")

        'Calculate and display price
        total = area * price
        totalLabel.Text = total.ToString("C2")

    End Sub


    Private Sub clrButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clrButton.Click
        lengthTextBox.Text = String.Empty
        widthTextBox.Text = String.Empty
        priceTextBox.Text = String.Empty
        areaLabel.Text = String.Empty
        totalLabel.Text = String.Empty
        lengthTextBox.Focus()

    End Sub
End Class
