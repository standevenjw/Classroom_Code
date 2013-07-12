' Project name:         Debug Project
' Project purpose:      Calculates the number of positive
'                       integers, negative integers, 
'                       and zeros entered by the user
' Created/revised by:   James Standeven on February 9, 2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        If MessageBox.Show("Are you sure you want to close this program?", "Debug Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub enterButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles enterButton.Click
        ' displays the number of positive integers, 
        ' the number of negative integers, 
        ' and the number of zeros entered

        Const Prompt As String = "Enter an integer. Click Cancel to end. "
        Dim inputNumber As String
        Dim number As Integer
        Static positiveCounter As Integer
        Static negativeCounter As Integer
        Static zeroCounter As Integer


        Do
            inputNumber = InputBox(Prompt, "Number Entry")

            If inputNumber <> String.Empty Then
                Integer.TryParse(inputNumber, number)
                ' update appropriate counter
                If number > 0 Then
                    positiveCounter += 1
                ElseIf number < 0 Then
                    negativeCounter += 1
                Else
                    zeroCounter += 1
                End If
            End If
        Loop Until inputNumber = String.Empty

        ' display counters
        positiveLabel.Text = positiveCounter.ToString
        negativeLabel.Text = negativeCounter.ToString
        zeroLabel.Text = zeroCounter.ToString
    End Sub
End Class
