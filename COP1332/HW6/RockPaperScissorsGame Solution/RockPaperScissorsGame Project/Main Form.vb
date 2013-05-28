' Project name:         RockPaperScissorsGame Project
' Project purpose:      Simulates the Rock, Paper, Scissors game
' Created/revised by:   James Standeven on February 6, 2012


Public Class MainForm
    'track wins, ties and loses
    Dim wins As Integer
    Dim ties As Integer
    Dim losses As Integer

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub scrButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles scrButton.Click
        playerLabel.Visible = False
        computerLabel.Visible = False
        playerRectShape.Visible = False
        compRectShape.Visible = False
        winnerLabel.Text = wins & " win(s), " & ties & " tie(s) and " & losses & " loss(es)."
    End Sub

    Private Sub paperPictureBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles paperPictureBox.Click

        'determines whether the game is tied or won
        Dim ranGen As New Random
        Dim compChoice As Integer

        'display the player's choice
        playerLabel.Location = New Point(170, playerLabel.Location.Y)
        playerLabel.Visible = True
        playerRectShape.Location = New Point(168, playerRectShape.Location.Y)
        playerRectShape.Visible = True

        'generate a random number from 1 through 3
        compChoice = ranGen.Next(1, 4)

        'display the computer's choice and the outcome
        Select Case compChoice
            Case 1 'rock 
                computerLabel.Location = New Point(77, computerLabel.Location.Y)
                computerLabel.Visible = True
                compRectShape.Location = New Point(39, compRectShape.Location.Y)
                compRectShape.Visible = True
                winnerLabel.Text = "Player wins because paper covers rock"
                wins += 1
            Case 2 'paper
                computerLabel.Location = New Point(206, computerLabel.Location.Y)
                computerLabel.Visible = True
                compRectShape.Location = New Point(168, compRectShape.Location.Y)
                compRectShape.Visible = True
                winnerLabel.Text = "Tie"
                ties += 1
            Case 3 'scissors
                computerLabel.Location = New Point(335, computerLabel.Location.Y)
                computerLabel.Visible = True
                compRectShape.Location = New Point(297, compRectShape.Location.Y)
                compRectShape.Visible = True
                winnerLabel.Text = "Computer wins because scissors cut paper"
                losses += 1
        End Select
    End Sub

    Private Sub rockPictureBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rockPictureBox.Click

        'determines whether the game is tied or won
        Dim ranGen As New Random
        Dim compChoice As Integer

        'display the player's choice
        playerLabel.Location = New Point(41, playerLabel.Location.Y)
        playerLabel.Visible = True
        playerRectShape.Location = New Point(39, playerRectShape.Location.Y)
        playerRectShape.Visible = True

        'generate a random number from 1 through 3
        compChoice = ranGen.Next(1, 4)

        'display the computer's choice and the outcome
        Select Case compChoice
            Case 1 'rock 
                computerLabel.Location = New Point(77, computerLabel.Location.Y)
                computerLabel.Visible = True
                compRectShape.Location = New Point(39, compRectShape.Location.Y)
                compRectShape.Visible = True
                winnerLabel.Text = "Tie"
                ties += 1
            Case 2 'paper
                computerLabel.Location = New Point(206, computerLabel.Location.Y)
                computerLabel.Visible = True
                compRectShape.Location = New Point(168, compRectShape.Location.Y)
                compRectShape.Visible = True
                winnerLabel.Text = "Computer wins because paper covers rock"
                losses += 1
            Case 3 'scissors
                computerLabel.Location = New Point(335, computerLabel.Location.Y)
                computerLabel.Visible = True
                compRectShape.Location = New Point(297, compRectShape.Location.Y)
                compRectShape.Visible = True
                winnerLabel.Text = "Player wins because rock breaks scissors"
                wins += 1
        End Select
    End Sub

    Private Sub scissorsPictureBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles scissorsPictureBox.Click

        'determines whether the game is tied or won
        Dim ranGen As New Random
        Dim compChoice As Integer

        'display the player's choice
        playerLabel.Location = New Point(299, playerLabel.Location.Y)
        playerLabel.Visible = True
        playerRectShape.Location = New Point(297, playerRectShape.Location.Y)
        playerRectShape.Visible = True

        'generate a random number from 1 through 3
        compChoice = ranGen.Next(1, 4)

        'display the computer's choice and the outcome
        Select Case compChoice
            Case 1 'rock 
                computerLabel.Location = New Point(77, computerLabel.Location.Y)
                computerLabel.Visible = True
                compRectShape.Location = New Point(39, compRectShape.Location.Y)
                compRectShape.Visible = True
                winnerLabel.Text = "Computer wins because rock breaks scissors"
                losses += 1
            Case 2 'paper
                computerLabel.Location = New Point(206, computerLabel.Location.Y)
                computerLabel.Visible = True
                compRectShape.Location = New Point(168, compRectShape.Location.Y)
                compRectShape.Visible = True
                winnerLabel.Text = "Player wins because scissors cut paper"
                wins += 1
            Case 3 'scissors
                computerLabel.Location = New Point(335, computerLabel.Location.Y)
                computerLabel.Visible = True
                compRectShape.Location = New Point(297, compRectShape.Location.Y)
                compRectShape.Visible = True
                winnerLabel.Text = "Tie"
                ties += 1
        End Select
    End Sub
End Class
