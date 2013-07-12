' Project name:         Mouse Game Project
' Project purpose:      Simulates the Find the Mouse game
' Created/revised by:   James Standeven on January 24th

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    ' class-level variable for storing a random number
    Dim randomNumber As Integer
    Dim clickCount As Integer

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub startButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles startButton.Click
        'prepares the interface for a new game

        Dim randomGenerator As New Random

        'generate random number from 1 through 5
        randomNumber = randomGenerator.Next(1, 6)

        'display the "Is the mouse here?" immage
        PictureBox1.Image = questionPictureBox.Image
        PictureBox2.Image = questionPictureBox.Image
        PictureBox3.Image = questionPictureBox.Image
        PictureBox4.Image = questionPictureBox.Image
        PictureBox5.Image = questionPictureBox.Image

        'set winLabel to empty
        winLabel.Text = String.Empty

        'set click counter to 0
        clickCount = 0

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'update click counter
        clickCount += 1

        'display the appropriate image
        If randomNumber = 1 Then
            PictureBox1.Image = mousePictureBox.Image
            If clickCount < 4 Then
                winLabel.Text = "Congratulations! You won in " + clickCount.ToString() + " click(s)."
            End If
            If clickCount = 5 Then
                winLabel.Text = "Give it up! You lost."
            End If
        Else
            PictureBox1.Image = notHerePictureBox.Image
            If clickCount = 4 Then
                winLabel.Text = "You lost."
            End If
        End If

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'update click counter
        clickCount += 1

        'display the appropriate image
        If randomNumber = 2 Then
            PictureBox2.Image = mousePictureBox.Image
            If clickCount < 4 Then
                winLabel.Text = "Congratulations! You won in " + clickCount.ToString() + " click(s)."
            End If
            If clickCount = 5 Then
                winLabel.Text = "Give it up! You lost."
            End If
        Else
            PictureBox2.Image = notHerePictureBox.Image
            If clickCount = 4 Then
                winLabel.Text = "You lost."
            End If
        End If

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'update click counter
        clickCount += 1

        'display the appropriate image
        If randomNumber = 3 Then
            PictureBox3.Image = mousePictureBox.Image
            If clickCount < 4 Then
                winLabel.Text = "Congratulations! You won in " + clickCount.ToString() + " click(s)."
            End If
            If clickCount = 5 Then
                winLabel.Text = "Give it up! You lost."
            End If
        Else
            PictureBox3.Image = notHerePictureBox.Image
            If clickCount = 4 Then
                winLabel.Text = "You lost."
            End If
        End If

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'update click counter
        clickCount += 1

        'display the appropriate image
        If randomNumber = 4 Then
            PictureBox4.Image = mousePictureBox.Image
            If clickCount < 4 Then
                winLabel.Text = "Congratulations! You won in " + clickCount.ToString() + " click(s)."
            End If
            If clickCount = 5 Then
                winLabel.Text = "Give it up! You lost."
            End If
        Else
            PictureBox4.Image = notHerePictureBox.Image
            If clickCount = 4 Then
                winLabel.Text = "You lost."
            End If
        End If

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        'update click counter
        clickCount += 1

        'display the appropriate image
        If randomNumber = 5 Then
            PictureBox5.Image = mousePictureBox.Image
            If clickCount < 4 Then
                winLabel.Text = "Congratulations! You won in " + clickCount.ToString() + " click(s)."
            End If
            If clickCount = 5 Then
                winLabel.Text = "Give it up! You lost."
            End If
        Else
            PictureBox5.Image = notHerePictureBox.Image
            If clickCount = 4 Then
                winLabel.Text = "You lost."
            End If
        End If

    End Sub

End Class
