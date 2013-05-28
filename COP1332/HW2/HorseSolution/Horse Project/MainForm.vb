Public Class MainForm
    'James Standeven
    'Date 1/12/2012
    'Horse Auction - Hmwk 2

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub rascalButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rascalButton.Click
        displayPictureBox.Image = rascalPictureBox.Image()
        nameLabel.Text = "Rascal"

    End Sub

    Private Sub abbyButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles abbyButton.Click
        displayPictureBox.Image = abbyPictureBox.Image
        nameLabel.Text = "Abby"

    End Sub
End Class
