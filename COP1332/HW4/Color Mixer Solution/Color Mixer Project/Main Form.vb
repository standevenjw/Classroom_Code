' Programmed by: James Standeven
' Program: Homework 4 - Color Mixer
' Date: January 18, 2012

Option Explicit On
Option Infer On
Option Strict On

Public Class MainForm


    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub viewButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles viewButton.Click
        'Change the oval's color

        'Declare variables
        Dim inputRed As Integer
        Dim inputGreen As Integer
        Dim inputBlue As Integer

        'Assign input to variables
        Integer.TryParse(redTextBox.Text, inputRed)
        Integer.TryParse(greenTextBox.Text, inputGreen)
        Integer.TryParse(blueTextBox.Text, inputBlue)

        'Change color
        colorOvalShape.BackColor = Color.FromArgb(inputRed, inputGreen, inputBlue)


    End Sub
End Class
