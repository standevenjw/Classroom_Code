' Project name:         Happy Temps Project
' Project purpose:      Calculates the salary of a Temp worker
' Created/revised by:   James Standeven on March 1, 2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As System.EventArgs) Handles calcButton.Click
        Dim day As Integer
        Dim salary As Double
        Dim total As Double

        If doubleRadioButton.Checked = True Then
            Integer.TryParse(daysTextBox.Text, day)

            For c As Integer = 0 To day - 1
                total += Math.Pow(2, c)
            Next c
        End If

        If flatRadioButton.Checked = True Then
            Integer.TryParse(daysTextBox.Text, day)
            Double.TryParse(salaryTextBox.Text, salary)

            For c As Integer = 0 To day - 1
                total += salary
            Next c
        End If

        totalTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub doubleRadioButton_CheckedChanged(sender As Object, e As System.EventArgs) Handles doubleRadioButton.CheckedChanged
        If doubleRadioButton.Checked = True Then
            salaryLabel.Visible = False
            salaryTextBox.Visible = False
        End If

        If doubleRadioButton.Checked = False Then
            salaryLabel.Visible = True
            salaryTextBox.Visible = True
        End If
    End Sub

    Private Sub daysTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles daysTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub salaryTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles salaryTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
