' Programmed by: James Standeven
' Program: Homework 3 - Music Sampler
' Date: January 18, 2011

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub boomButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles boomButton.Click
        My.Computer.Audio.Play("BoomBoomPow.wav")

    End Sub

    Private Sub breakawayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles breakawayButton.Click
        My.Computer.Audio.Play("Breakaway.wav")

    End Sub

    Private Sub feelingButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles feelingButton.Click
        My.Computer.Audio.Play("FeelingGood.wav")

    End Sub

    Private Sub sydneyButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sydneyButton.Click
        My.Computer.Audio.Play("Sydney.wav")

    End Sub

    Private Sub thrillerButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles thrillerButton.Click
        My.Computer.Audio.Play("Thriller.wav")

    End Sub

    Private Sub treysonButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles treysonButton.Click
        My.Computer.Audio.Play("Treyson.wav")

    End Sub

    Private Sub colorButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorButton.Click
        colorDialog.Color = Me.BackColor
        colorDialog.ShowDialog()
        Me.BackColor = colorDialog.Color

    End Sub

    Private Sub printButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles printButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub
End Class
