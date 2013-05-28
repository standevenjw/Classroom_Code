' Project name:         Tri-County Electricity Project
' Project purpose:      Displays the monthly electric bill
' Created/revised by:   James Standeven on March 14, 2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub CalcResidentialTotal(ByVal units As Integer, ByRef charge As Double)
        'Calculates the total charge for a residential customer

        Const UnitCharge As Double = 0.09
        Const MinFee As Double = 17.65

        charge = units * UnitCharge
        If charge < MinFee Then
            charge = MinFee
        End If
    End Sub

    Private Function GetCommercialTotal(ByVal units As Integer) As Double
        'Calculates the total charge for a commercial customer

        Const UnitCharge As Double = 0.12
        Const MinFee As Double = 21.75
        Dim charge As Double

        charge = units * UnitCharge
        If charge < MinFee Then
            charge = MinFee
        End If

        Return charge
    End Function

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub SelectText(sender As Object, e As System.EventArgs) Handles currentTextBox.Enter, previousTextBox.Enter
        'Select existing text

        Dim thisTextBox As TextBox
        thisTextBox = TryCast(sender, TextBox)
        thisTextBox.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles currentTextBox.KeyPress, previousTextBox.KeyPress
        'Allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As System.EventArgs) Handles currentTextBox.TextChanged, previousTextBox.TextChanged, residentialRadioButton.Click, commercialRadioButton.Click
        'Clear calculated value

        usageLabel.Text = String.Empty
        totalLabel.Text = String.Empty
    End Sub

    Private Sub calcButton_Click(sender As Object, e As System.EventArgs) Handles calcButton.Click
        'Displays the monthly usage and the total charge

        Dim previous As Integer
        Dim current As Integer
        Dim usage As Integer
        Dim total As Double

        Integer.TryParse(previousTextBox.Text, previous)
        Integer.TryParse(currentTextBox.Text, current)

        If current >= previous Then
            usage = current - previous
            If residentialRadioButton.Checked = True Then
                Call CalcResidentialTotal(usage, total)
            Else
                total = GetCommercialTotal(usage)
            End If

            usageLabel.Text = usage.ToString("N0")
            totalLabel.Text = total.ToString("C2")
        Else
            MessageBox.Show("The current reading must " &
                "be greater than or equal to the " &
                "previous reading.", "Tri-County Electicity",
                MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
