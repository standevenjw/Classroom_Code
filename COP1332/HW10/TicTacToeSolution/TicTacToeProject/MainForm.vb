' Project name:         TicTacToe Project
' Project purpose:      Creates a two player tic tac toe game
' Created/revised by:   James Standeven on April 2, 2012

Option Explicit On
Option Strict On
Option Infer Off


Public Class MainForm
    Const MAX As Integer = 8
    Dim gbLabels(MAX) As Label
    Dim turn As Integer = 0


    Private Sub MainForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        gbLabels(0) = gameLabel0
        gbLabels(1) = gameLabel1
        gbLabels(2) = gameLabel2
        gbLabels(3) = gameLabel3
        gbLabels(4) = gameLabel4
        gbLabels(5) = gameLabel5
        gbLabels(6) = gameLabel6
        gbLabels(7) = gameLabel7
        gbLabels(8) = gameLabel8

        For C As Integer = 0 To MAX
            gbLabels(C).Tag = (C + 2).ToString
        Next C
    End Sub

    Function winner() As Boolean
        Dim result As Boolean = False
        Dim C As Integer
        Dim R As Integer

        For C = 0 To 2
            R = 0
            Do While R < 6 AndAlso TryCast(gbLabels(C + R).Tag, String) = TryCast(gbLabels(C + R + 3).Tag, String)
                R += 3
            Loop

            If R > 5 Then
                result = True
            End If
        Next C

        For C = 0 To MAX Step 3
            R = 0
            Do While R < 2 AndAlso TryCast(gbLabels(C + R).Tag, String) = TryCast(gbLabels(C + R + 1).Tag, String)
                R += 1
            Loop

            If R > 1 Then
                result = True
            End If
        Next C


        R = 0
        Do While R < 8 AndAlso TryCast(gbLabels(R).Tag, String) = TryCast(gbLabels(R + 4).Tag, String)
            R += 4
        Loop

        If R > 7 Then
            result = True
        End If

        R = 2
        Do While R < 6 AndAlso TryCast(gbLabels(R).Tag, String) = TryCast(gbLabels(R + 2).Tag, String)
            R += 2
        Loop

        If R > 5 Then
            result = True
        End If

        Return result
    End Function

    Private Sub gameLabel_Click(sender As Object, e As System.EventArgs) Handles gameLabel0.Click, gameLabel1.Click, gameLabel2.Click, gameLabel3.Click, gameLabel4.Click, gameLabel5.Click, gameLabel6.Click, gameLabel7.Click, gameLabel8.Click
        Dim testLabel As Label = TryCast(sender, Label)
        Dim hit As Integer

        For C As Integer = 0 To MAX
            If testLabel.Name = gbLabels(C).Name Then
                hit = C
            End If
        Next C
        If TryCast(gbLabels(hit).Tag, String) <> "0" AndAlso TryCast(gbLabels(hit).Tag, String) <> "1" Then
            gbLabels(hit).Image = gameImageList.Images(turn Mod 2)
            gbLabels(hit).Tag = (turn Mod 2).ToString
            turn += 1
        End If


        If turn > 8 Then
            endGame(2)
        End If

        If winner() Then
            endGame((turn - 1) Mod 2)
        End If
    End Sub

    Private Sub endGame(ByVal winningPlayer As Integer)
        Dim scienceFont As New Font("Rockwell", 20)
        Dim godFont As New Font("Edwardian Script ITC", 30)
        Dim drawFont As New Font("Segeo UI", 20)
        Static scienceCount As Integer
        Static godCount As Integer

        For C As Integer = 0 To MAX
            gbLabels(C).Visible = False
        Next C

        Select Case winningPlayer
            Case 0
                winLabel.Font = scienceFont
                winLabel.Text = "Science wins"
                scienceCount += 1
                scienceLabel.Text = scienceCount.ToString
            Case 1
                winLabel.Font = godFont
                winLabel.Text = "God wins"
                godCount += 1
                godLabel.Text = godCount.ToString
            Case 2
                winLabel.Font = drawFont
                winLabel.Text = "Draw"
            Case Else

        End Select

        winLabel.Visible = True
    End Sub

    Private Sub extButton_Click(sender As Object, e As System.EventArgs) Handles extButton.Click
        Me.Close()
    End Sub

    Private Sub nwgmButton_Click(sender As Object, e As System.EventArgs) Handles nwgmButton.Click
        For C As Integer = 0 To MAX
            gbLabels(C).Image = Nothing
            gbLabels(C).Visible = True
            gbLabels(C).Tag = (C + 2).ToString
        Next C

        winLabel.Visible = False
        winLabel.Text = Nothing
        turn = 0

    End Sub
End Class
