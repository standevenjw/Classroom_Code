' Project name:         Slot Machine Project
' Project purpose:      Simulates a slot machine
' Created/revised by:   James Standeven on February 28, 2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private tLeftIndex As Integer 'class variable for top picture of left reel
    Private leftIndex As Integer 'class variable that refrences an image
    Private bLeftIndex As Integer 'class variable for bottom picture of left reel

    Private tCenterIndex As Integer 'class variable for top picture of center reel
    Private centerIndex As Integer 'class variable that refrences an image
    Private bCenterIndex As Integer 'class variable for bottom picture of center reel

    Private tRightIndex As Integer 'class variable for top picture of right reel
    Private rightIndex As Integer 'class variable variable that refrences an image
    Private bRightIndex As Integer 'class variable for bottom picture of right reel

    Private stopped As Boolean 'class variable that is used to break the continuous loop



    Private Sub MainForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        leftIndex = 4 'index for the cherry picture
        centerIndex = 4 'index for the cherry picture
        rightIndex = 4 'index for the cherry picture

        tLeftIndex = leftIndex + 1 'tLeftIndex is one greater than leftIndex
        bLeftIndex = leftIndex - 1 'bLeftIndex is one less than leftIndex

        tCenterIndex = centerIndex + 1 'tCenterIndex is one greater than centerIndex
        bCenterIndex = centerIndex - 1 'bCenterIndex is one less than centerIndex

        tRightIndex = rightIndex + 1 'tRightIndex is one greater than rightIndex
        bRightIndex = rightIndex - 1 'bRightIndex is one less than rightIndex

        'Left reel images
        tLeftPictureBox.Image = topImageList.Images.Item(tLeftIndex) 'shows the picture at tLeftIndex position
        tLeftPictureBox.Refresh() 'refreshes the tLeftPictureBox

        mLeftPictureBox.Image = centerImageList.Images.Item(leftIndex) 'shows the picture at leftIndex position
        mLeftPictureBox.Refresh() 'refreshes the leftPictureBox

        bLeftPictureBox.Image = centerImageList.Images.Item(bLeftIndex) 'shows the picture at bLeftIndex position
        bLeftPictureBox.Refresh() 'refreshes the bLeftPictureBox

        'Center reel images
        tCenterPictureBox.Image = topImageList.Images.Item(tCenterIndex) 'shows the picture at tCenterIndex position
        tCenterPictureBox.Refresh() 'refreshes the tCenterPictureBox

        mCenterPictureBox.Image = centerImageList.Images.Item(centerIndex) 'shows the picture at centerIndex position
        mCenterPictureBox.Refresh() 'refreshes the centerPictureBox

        bCenterPictureBox.Image = centerImageList.Images.Item(bCenterIndex) 'shows the picture at bCenterIndex position
        bCenterPictureBox.Refresh() 'refreshes the bCenterPictureBox

        'Right reel images
        tRightPictureBox.Image = topImageList.Images.Item(tRightIndex) 'shows the picture at tRightIndex position
        tRightPictureBox.Refresh() 'refreshes the tRightPictureBox

        mRightPictureBox.Image = centerImageList.Images.Item(rightIndex) 'shows the picture at rightIndex position
        mRightPictureBox.Refresh() 'refreshes the rightPictureBox

        bRightPictureBox.Image = centerImageList.Images.Item(bRightIndex) 'shows the picture at bRightIndex position
        bRightPictureBox.Refresh() 'refreshes the bRightPictureBox
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close() 'closes the form
    End Sub

    Private Sub spinButton_Click(sender As Object, e As System.EventArgs) Handles spinButton.Click
        'Simulates a slot machine

        'Variable declaratons
        Dim ltime As Integer 'determines when the left reel stops
        Dim ctime As Integer 'determines when the left reel stops
        Dim rtime As Integer 'determines when the left reel stops
        Dim time As Integer = 25 'loop counter and speed
        Dim randGen As New Random 'variable used to create multiple random numbers
        stopped = False 'allows the loop to continue
        winLabel.Visible = False 'hides the winLabel

        ltime = randGen.Next(50, 76) 'generates random num from 50 to 75
        ctime = randGen.Next(50, 76) 'generates random num from 50 to 75
        rtime = randGen.Next(50, 76) 'generates random num from 50 to 75

        spinButton.Enabled = False 'disables the button
        stopButton.Enabled = True 'enables the button
        stopButton.Focus() 'gives the focus to the stop button
        exitButton.Enabled = False 'disables the button

        Do While time < 75 'loops until time reaches 76
            tLeftIndex = leftIndex + 1 'tLeftIndex is one greater than leftIndex
            bLeftIndex = leftIndex - 1 'bLeftIndex is one less than leftIndex

            tCenterIndex = centerIndex + 1 'tCenterIndex is one greater than centerIndex
            bCenterIndex = centerIndex - 1 'bCenterIndex is one less than centerIndex

            tRightIndex = rightIndex + 1 'tRightIndex is one greater than rightIndex
            bRightIndex = rightIndex - 1 'bRightIndex is one less than rightIndex

            Select Case leftIndex
                Case 0
                    bLeftIndex = 5 'index can't be a negative
                Case 5
                    tLeftIndex = 0 'index can't be greater than 5
                Case 6
                    leftIndex = 0 'index can't be greater than 5 
                    tLeftIndex = 1  'index can't be greater than 5
            End Select


            Select Case centerIndex
                Case 0
                    bCenterIndex = 5 'index can't be a negative
                Case 5
                    tCenterIndex = 0 'index can't be greater than 5
                Case 6
                    centerIndex = 0 'index can't be greater than 5 
                    tCenterIndex = 1  'index can't be greater than 5
            End Select


            Select Case rightIndex
                Case 0
                    bRightIndex = 5 'index can't be a negative
                Case 5
                    tRightIndex = 0 'index can't be greater than 5
                Case 6
                    rightIndex = 0 'index can't be greater than 5 
                    tRightIndex = 1  'index can't be greater than 5
            End Select

            If time < ltime Then
                tLeftPictureBox.Image = topImageList.Images.Item(tLeftIndex) 'shows the picture at tLeftIndex position
                tLeftPictureBox.Refresh() 'refreshes the tLeftPictureBox

                mLeftPictureBox.Image = centerImageList.Images.Item(leftIndex) 'shows the picture at leftIndex position
                mLeftPictureBox.Refresh() 'refreshes the leftPictureBox

                bLeftPictureBox.Image = centerImageList.Images.Item(bLeftIndex) 'shows the picture at bLeftIndex position
                bLeftPictureBox.Refresh() 'refreshes the bLeftPictureBox

                System.Threading.Thread.Sleep(time) 'pause

                leftIndex += 1 'increment the index

                If ctime <= time Then
                    System.Threading.Thread.Sleep(time) 'prevents this reel from speeding up when the center reel stops
                End If

                If rtime <= time Then
                    System.Threading.Thread.Sleep(time) 'prevents this reel from speeding up when the right reel stops
                End If
            End If

            If time < ctime Then
                tCenterPictureBox.Image = topImageList.Images.Item(tCenterIndex) 'shows the picture at tCenterIndex position
                tCenterPictureBox.Refresh() 'refreshes the tCenterPictureBox

                mCenterPictureBox.Image = centerImageList.Images.Item(centerIndex) 'shows the picture at centerIndex position
                mCenterPictureBox.Refresh() 'refreshes the centerPictureBox

                bCenterPictureBox.Image = centerImageList.Images.Item(bCenterIndex) 'shows the picture at bCenterIndex position
                bCenterPictureBox.Refresh() 'refreshes the bCenterPictureBox

                System.Threading.Thread.Sleep(time) 'pause

                centerIndex += 1 'increments the index

                If ltime <= time Then
                    System.Threading.Thread.Sleep(time) 'prevents this reel from speeding up when the left reel stops
                End If

                If rtime <= time Then
                    System.Threading.Thread.Sleep(time) 'prevents this reel from speeding up when the right reel stops
                End If
            End If

            If time < rtime Then
                tRightPictureBox.Image = topImageList.Images.Item(tRightIndex) 'shows the picture at tRightIndex position
                tRightPictureBox.Refresh() 'refreshes the tRightPictureBox

                mRightPictureBox.Image = centerImageList.Images.Item(rightIndex) 'shows the picture at rightIndex position
                mRightPictureBox.Refresh() 'refreshes the rightPictureBox

                bRightPictureBox.Image = centerImageList.Images.Item(bRightIndex) 'shows the picture at bRightIndex position
                bRightPictureBox.Refresh() 'refreshes the bRightPictureBox

                System.Threading.Thread.Sleep(time) 'pause

                rightIndex += 1 'increments the index

                If ltime <= time Then
                    System.Threading.Thread.Sleep(time) 'prevents this reel from speeding up when the left reel stops
                End If

                If ctime <= time Then
                    System.Threading.Thread.Sleep(time) 'prevents this reel from speeding up when the center reel stops
                End If
            End If

            Application.DoEvents() 'checks for other events and runs any that have been queued

            If stopped Then
                time += 1 'increments time if stopped is true
            End If
        Loop

        spinButton.Enabled = True 'enables the button
        spinButton.Focus() 'gives the spinButton the focus
        exitButton.Enabled = True 'enables the button


        If leftIndex = centerIndex AndAlso leftIndex = rightIndex Then
            winLabel.Visible = True 'displays "Winner!!!" when the middle images are all the same
        End If
    End Sub

    Private Sub stopButton_Click(sender As Object, e As System.EventArgs) Handles stopButton.Click
        stopButton.Enabled = False 'disables the button

        stopped = True 'stops the loop
    End Sub
End Class
