' Project name:         Guess the Word Project
' Project purpose:      Simulates the Guess the 
'                       Word game 
' Created/revised by:   James Standeven on April 13 2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    'class-level variables
    Private word As String
    Private incorrect As Integer

    Private Sub EnableDisableButtons(ByVal setting As Boolean)
        ' enable or disable letter buttons

        aButton.Enabled = setting
        bButton.Enabled = setting
        cButton.Enabled = setting
        dButton.Enabled = setting
        eButton.Enabled = setting
        fButton.Enabled = setting
        gButton.Enabled = setting
        hButton.Enabled = setting
        iButton.Enabled = setting
        jButton.Enabled = setting
        kButton.Enabled = setting
        lButton.Enabled = setting
        mButton.Enabled = setting
        nButton.Enabled = setting
        oButton.Enabled = setting
        pButton.Enabled = setting
        qButton.Enabled = setting
        rButton.Enabled = setting
        sButton.Enabled = setting
        tButton.Enabled = setting
        uButton.Enabled = setting
        vButton.Enabled = setting
        wButton.Enabled = setting
        xButton.Enabled = setting
        yButton.Enabled = setting
        zButton.Enabled = setting

        'resets the backcolor of buttons

        aButton.BackColor = Nothing
        bButton.BackColor = Nothing
        cButton.BackColor = Nothing
        dButton.BackColor = Nothing
        eButton.BackColor = Nothing
        fButton.BackColor = Nothing
        gButton.BackColor = Nothing
        hButton.BackColor = Nothing
        iButton.BackColor = Nothing
        jButton.BackColor = Nothing
        kButton.BackColor = Nothing
        lButton.BackColor = Nothing
        mButton.BackColor = Nothing
        nButton.BackColor = Nothing
        oButton.BackColor = Nothing
        pButton.BackColor = Nothing
        qButton.BackColor = Nothing
        rButton.BackColor = Nothing
        sButton.BackColor = Nothing
        tButton.BackColor = Nothing
        uButton.BackColor = Nothing
        vButton.BackColor = Nothing
        wButton.BackColor = Nothing
        xButton.BackColor = Nothing
        yButton.BackColor = Nothing
        zButton.BackColor = Nothing

    End Sub

    Private Sub CheckStatus(ByVal dashStatus As Boolean)
        'determines whether the game is over

        If dashStatus Then
            If wordLabel.Text.Contains("-") = False Then
                'the game is over because the word was guessed
                MessageBox.Show("Great Guessing!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call EnableDisableButtons(False)
            End If
        Else
            incorrect += 1
            incorrectLabel.Text = incorrect.ToString
            If incorrect = 10 Then
                MessageBox.Show("Sorry, the word is " & word, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call EnableDisableButtons(False)
            End If
        End If
    End Sub

    Private Sub LetterButtons(ByVal sender As Object, ByVal e As System.EventArgs) Handles aButton.Click,
        bButton.Click, cButton.Click, dButton.Click, eButton.Click, jButton.Click, iButton.Click, hButton.Click,
        gButton.Click, fButton.Click, oButton.Click, nButton.Click, mButton.Click, lButton.Click, kButton.Click,
        tButton.Click, sButton.Click, rButton.Click, qButton.Click, pButton.Click, yButton.Click, xButton.Click,
        wButton.Click, vButton.Click, uButton.Click, zButton.Click
        'determines whether the buttons's letter is in the word

        Dim clickedBtn As Button
        Dim dashReplaced As Boolean

        clickedBtn = TryCast(sender, Button)
        clickedBtn.Enabled = False

        For index As Integer = 0 To (word.Length - 1)
            'if the current letter in the word
            'matches player 2's letter, replace the 
            'associated dash in the wordLabel with
            'player 2's letter and then indicate 
            'that a replacement was made
            If word.Substring(index, 1) = clickedBtn.Text Then
                wordLabel.Text = wordLabel.Text.Remove(index, 1)
                wordLabel.Text = wordLabel.Text.Insert(index, clickedBtn.Text)
                dashReplaced = True
            End If
            If dashReplaced Then
                clickedBtn.BackColor = Color.DarkGreen
            Else
                clickedBtn.BackColor = Color.Red
            End If
        Next index
        Call CheckStatus(dashReplaced)
    End Sub

    Private Sub gameExitMenuItem_Click(sender As Object, e As System.EventArgs) Handles gameExitMenuItem.Click
        Me.Close()
    End Sub

    Private Sub gameNewGameMenuItem_Click(sender As Object, e As System.EventArgs) Handles gameNewGameMenuItem.Click
        'prepares te application for a new game

        wordLabel.Text = String.Empty
        incorrect = 0
        incorrectLabel.Text = incorrect.ToString

        word = InputBox("Enter a word of 10 letters or less:", "Player 1").ToUpper
        'validate the word
        If word Like "*[!A-Z]*" Then
            MessageBox.Show("Please enter letters only", "Guess the Word", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf word.Length > 10 Then
            MessageBox.Show("Pleser enter a word of 10 letters or less", "Guess the Word", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For c As Integer = 0 To (word.Length - 1)
                wordLabel.Text = wordLabel.Text + "-"
            Next c
            Call EnableDisableButtons(True)
        End If
    End Sub
End Class
