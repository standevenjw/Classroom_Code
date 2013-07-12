' Project name:         Lottery Game Project
' Project purpose:      Displays six unique random 
'                       numbers from 1 through 54
' Created/revised by:   James Standeven on April 2, 2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub getButton_Click(sender As System.Object, e As System.EventArgs) Handles getButton.Click
        'generates and displays six unique random
        'numbers from 1 through 54

        Dim numbers(5) As Integer
        Dim randGen As New Random
        Dim randomNum As Integer
        Dim subscript As Integer
        Dim searchSubscript As Integer
        Dim isFound As Boolean
        Dim highestSub As Integer = numbers.GetUpperBound(0)

        'generate the first random number and
        'store it in the first array element
        numbers(0) = randGen.Next(1, 55)


        'fill remaining array elements with 
        'unique random numbers
        subscript = 1
        Do While subscript <= highestSub
            randomNum = randGen.Next(1, 55)

            'search the array for the random number
            'stop the search when there are no more
            'elements or when the random number is found
            searchSubscript = 0
            isFound = False
            Do While searchSubscript < subscript AndAlso isFound = False

                'if the random number is in the current
                'array element, assign True and isFound
                'otherwise, examine the next element
                If numbers(searchSubscript) = randomNum Then
                    isFound = True
                Else
                    searchSubscript += 1
                End If
            Loop

            'if the random number is not in the array
            'assign the random number to the current array
            'element and then move to the next element
            If isFound = False Then
                numbers(subscript) = randomNum
                subscript += 1
            End If
        Loop

        'display the contents of the array
        lotteryLabel.Text = String.Empty
        For Each numElement As Integer In numbers
            lotteryLabel.Text = lotteryLabel.Text & " " & numElement.ToString
        Next numElement
    End Sub
End Class
