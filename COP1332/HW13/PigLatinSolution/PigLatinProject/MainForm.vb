'Project name: Pig Latin Translator
'Project description: Translates user inputted sentence into pig latin
'Coded by: James Standeven on April 24, 2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub extButton_Click(sender As Object, e As System.EventArgs) Handles extButton.Click
        Me.Close()
    End Sub

    Private Sub transButton_Click(sender As Object, e As System.EventArgs) Handles transButton.Click
        'Translates the text into pig latin
        Dim inputStrg() As String = inputTextBox.Text.Split(CChar(" ")) 'splits the user input up if there is a sentence.
        Dim outStrg As String = "" 'reasembles the sentence

        For Each word As String In inputStrg
            outStrg = outStrg + " " + wordChange(word) 'calls wordChange and appends it to outStrg
        Next

        outputLabel.Text = outStrg
    End Sub

    Private Function wordChange(ByRef word As String) As String
        'Alters each word passed to it
        Dim altered As Boolean 'is true if the first letter is not a vowel
        Dim last As Integer = (word.Length - 1) 'used to mark the last position of the word
        Dim lastChar As Char = CChar(word.Substring(last)) 'used to check for punctuation
        Dim puncChar As Char 'stores the
        Dim puncInt As Integer
        Dim puncStrg As String = ""
        Dim puncBool As Boolean = False
        Dim quoteBool As Boolean = False
        Dim quoteStrg As String = ""
        Dim punctuation() As Char = word.ToCharArray

        'Removes quotation mark from the beginning
        If word(0) = Chr(34) Then
            quoteStrg = word.Substring(0, 1)
            word = word.Remove(0, 1)
            quoteBool = True
        End If

        'Removes punctuation from the end
        For c As Integer = 1 To punctuation.GetUpperBound(0)
            If Char.IsPunctuation(punctuation(c)) AndAlso puncBool = False Then
                puncChar = punctuation(c)
                puncBool = True
            End If
        Next
        If puncBool Then
            puncInt = word.IndexOf(puncChar)
            puncStrg = word.Substring(puncInt)
            word = word.Remove(puncInt)
        End If

        word = word + "-"
        If word.Substring(0, 1).ToUpper Like "[A-Z]" Then 'checks if the first character is a letter
            If word.Substring(0, 1).ToUpper = "Y" Then
                Do Until word.Substring(0, 1).ToUpper Like "[AEIOU]" 'checks if the first character is a vowel
                    word = word + word.Substring(0, 1) 'adds the first letter to the end of the string
                    word = word.Remove(0, 1) 'removes the first letter of the string
                    altered = True 'denotes that the word was altered
                Loop
            Else
                Do Until word.Substring(0, 1).ToUpper Like "[AEIOUY]" 'checks if the first character is a vowel
                    word = word + word.Substring(0, 1) 'adds the first letter to the end of the string
                    word = word.Remove(0, 1) 'removes the first letter of the string
                    altered = True 'denotes that the word was altered
                Loop
            End If

            If altered Then
                word = word + "ay" 'if the word was altered adds "ay" to the end
            Else
                word = word + "way" 'if the word was not altered adds "way" to the end
            End If
        Else
            word = word + "way" 'if the first character is not a letter adds "way" to the end
        End If

        'Adds the punctuation to the end of the word
        If puncBool Then
            word = word + puncStrg
        End If

        'Adds the quote back to the front of the word
        If quoteBool Then
            word = quoteStrg + word
        End If

        Return word
    End Function
End Class
