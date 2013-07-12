'Project Name: Warren High School
'Preject Description: Keeps track of voting for the class president
'Coded by: James Standeven on April 19, 2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    'Class Variables
    Dim voteCount() As Integer = {0, 0, 0} 'stores each candidates vote count
    Dim canLbl(2) As Label 'candidate labels
    Dim canOutLbl(2) As Label 'candidate vote count labels

    Private Sub MainForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim strg1 As String 'used to manipulate strings passed from the candidateListBox

        'Populate label arrays
        canLbl(0) = can1Label
        canLbl(1) = can2Label
        canLbl(2) = can3Label
        canOutLbl(0) = canOut1Label
        canOutLbl(1) = canOut2Label
        canOutLbl(2) = canOut3Label

        Call readVotes()

        For C As Integer = 0 To 2
            strg1 = candidateListBox.Items(C).ToString 'passed a string from candidateListBox at subscript C
            canLbl(C).Text = strg1.Substring((strg1.IndexOf(",") + 2)) + " " + strg1.Remove(strg1.IndexOf(",")) 'adds the first name to the last name and assigns it to the label at subscript C
            canOutLbl(C).Text = voteCount(C).ToString 'assigns voteCount at sub C to canOutLbl at sub C
        Next C
    End Sub

    Private Sub exitMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles exitMenuItem.Click
        Me.Close()
    End Sub

    Private Sub svButton_Click(sender As Object, e As System.EventArgs) Handles addButton.Click

        Select Case candidateListBox.SelectedIndex 'captures which candidate is selected
            Case 0
                voteCount(0) += 1 'assigns a vote candidate 1
            Case 1
                voteCount(1) += 1 'assigns a vote candidate 2
            Case 2
                voteCount(2) += 1 'assigns a vote candidate 3
        End Select

        Call writeVotes()
    End Sub

    Private Sub displayVotesMenuItem_Click(sender As Object, e As System.EventArgs) Handles displayVotesMenuItem.Click
        Call readVotes()

        For C As Integer = 0 To 2
            canOutLbl(C).Text = voteCount(C).ToString 'assigns voteCount at sub C to canOutLbl at sub C
        Next C
    End Sub

    Private Sub resetVotesMenuItem_Click(sender As Object, e As System.EventArgs) Handles resetVotesMenuItem.Click

        For C As Integer = 0 To 2
            voteCount(C) = 0
            canOutLbl(C).Text = voteCount(C).ToString 'assigns voteCount at sub C to canOutLbl at sub C
        Next C

        Call writeVotes()
    End Sub

    Private Sub readVotes()
        Dim inFile As IO.StreamReader

        If IO.File.Exists("vote.txt") Then 'checks for a file called vote.txt in the projects bin folder
            inFile = IO.File.OpenText("vote.txt") 'opens a file and associates it with inFile

            Dim fileInput As String
            For C As Integer = 0 To 2
                fileInput = inFile.ReadLine 'discards the candidates name
                fileInput = inFile.ReadLine 'captures the candidates vote count
                Integer.TryParse(fileInput, voteCount(C)) 'outputs vote counts
            Next C

            inFile.Close() 'releases vote.txt
        Else
            MessageBox.Show("Error: No file exists.", "Warren High School", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub writeVotes()
        Dim outFile As IO.StreamWriter 'used to write to a file
        outFile = IO.File.CreateText("vote.txt") 'creates/opens a file and associates it with outFile

        Dim C As Integer = 0 'used to control the voteCount array position
        For Each candidate As String In candidateListBox.Items
            outFile.WriteLine(candidate) 'writes candidate name to file
            outFile.WriteLine(voteCount(C).ToString) 'writes candidate vote count to file
            C += 1 'increments the voteCount subscript
        Next candidate

        outFile.Close() 'release vote.txt
    End Sub
End Class
