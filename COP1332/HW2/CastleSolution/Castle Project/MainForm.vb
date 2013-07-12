Public Class MainForm
    'James Standeven
    'Date 1/12/2012
    'Castle's Ice Cream Parlor - Hmwk 2

    Private Sub extButton_Click(sender As Object, e As System.EventArgs) Handles extButton.Click
        Me.Close()

    End Sub

    Private Sub bananaButton_Click(sender As Object, e As System.EventArgs) Handles bananaButton.Click
        priceTextBox.Text = "4.99"

    End Sub

    Private Sub sundaeButton_Click(sender As Object, e As System.EventArgs) Handles sundaeButton.Click
        priceTextBox.Text = "2.99"

    End Sub

    Private Sub milkshkButton_Click(sender As Object, e As System.EventArgs) Handles milkshkButton.Click
        priceTextBox.Text = "3.99"

    End Sub
End Class
