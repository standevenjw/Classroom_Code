'Project name: Willow Health Club Project
'Project purpose: Calculate how many calories to consume based on gender, weight and activity level
'Programmed by: James Standeven on February 6, 2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        If MessageBox.Show("Would you like to close the program?", "Willow Health Club", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub weightTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles weightTextBox.KeyPress

        'limits the weightTextBox to numbers and the backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then e.Handled = True

    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click

        'holder for user input
        Dim weight As Integer

        'get input
        weight = getIntInput()

        'if the displayButton is pressed, display the appropriate answer
        displayLabel.Text = getAnswer(weight)

    End Sub

    Private Sub maleRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles maleRadioButton.CheckedChanged

        'holder for user input
        Dim weight As Integer

        'get input
        weight = getIntInput()

        'if the maleRadioButton is changed, display the appropriate answer
        displayLabel.Text = getAnswer(weight)

    End Sub

    Private Sub activeRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles activeRadioButton.CheckedChanged

        'holder for user input
        Dim weight As Integer

        'get input
        weight = getIntInput()

        'if the activeRadioButton is changed, display the appropriate answer
        displayLabel.Text = getAnswer(weight)

    End Sub

    Private Function getIntInput() As Integer

        'holder for user input
        Dim input As Integer

        'assign input to weight
        Integer.TryParse(weightTextBox.Text, input)

        Return input
    End Function

    Private Function getAnswer(ByRef wght As Integer) As String

        'holder for proper answer
        Dim answer As String = String.Empty

        Select Case True
            Case maleRadioButton.Checked 'male 
                If activeRadioButton.Checked Then
                    answer = CStr(wght * 15) 'active
                Else
                    answer = CStr(wght * 13) 'inactive
                End If
            Case femaleRadioButton.Checked 'female
                If activeRadioButton.Checked Then
                    answer = CStr(wght * 12) 'active
                Else
                    answer = CStr(wght * 10) 'inactive
                End If
        End Select

        Return answer
    End Function
End Class
