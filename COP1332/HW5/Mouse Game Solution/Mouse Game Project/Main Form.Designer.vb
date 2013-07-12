<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.startButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.mousePictureBox = New System.Windows.Forms.PictureBox()
        Me.notHerePictureBox = New System.Windows.Forms.PictureBox()
        Me.questionPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.winLabel = New System.Windows.Forms.Label()
        CType(Me.mousePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.notHerePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.questionPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(406, 185)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(103, 32)
        Me.startButton.TabIndex = 0
        Me.startButton.Text = "&Start Game"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(406, 223)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(103, 32)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'mousePictureBox
        '
        Me.mousePictureBox.Image = CType(resources.GetObject("mousePictureBox.Image"), System.Drawing.Image)
        Me.mousePictureBox.Location = New System.Drawing.Point(198, 163)
        Me.mousePictureBox.Name = "mousePictureBox"
        Me.mousePictureBox.Size = New System.Drawing.Size(75, 100)
        Me.mousePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mousePictureBox.TabIndex = 8
        Me.mousePictureBox.TabStop = False
        Me.mousePictureBox.Visible = False
        '
        'notHerePictureBox
        '
        Me.notHerePictureBox.Image = Global.Mouse_Game_Project.My.Resources.Resources.NotHere
        Me.notHerePictureBox.Location = New System.Drawing.Point(111, 163)
        Me.notHerePictureBox.Name = "notHerePictureBox"
        Me.notHerePictureBox.Size = New System.Drawing.Size(75, 100)
        Me.notHerePictureBox.TabIndex = 7
        Me.notHerePictureBox.TabStop = False
        Me.notHerePictureBox.Visible = False
        '
        'questionPictureBox
        '
        Me.questionPictureBox.BackColor = System.Drawing.SystemColors.Control
        Me.questionPictureBox.Image = Global.Mouse_Game_Project.My.Resources.Resources.Question
        Me.questionPictureBox.Location = New System.Drawing.Point(24, 163)
        Me.questionPictureBox.Name = "questionPictureBox"
        Me.questionPictureBox.Size = New System.Drawing.Size(75, 100)
        Me.questionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.questionPictureBox.TabIndex = 6
        Me.questionPictureBox.TabStop = False
        Me.questionPictureBox.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Location = New System.Drawing.Point(432, 49)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(75, 100)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(330, 49)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 100)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(228, 49)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(126, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(24, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Click the Start Game button and then click a rectangle to find the mouse."
        '
        'winLabel
        '
        Me.winLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.winLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winLabel.Location = New System.Drawing.Point(21, 191)
        Me.winLabel.Name = "winLabel"
        Me.winLabel.Size = New System.Drawing.Size(350, 40)
        Me.winLabel.TabIndex = 10
        Me.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 292)
        Me.Controls.Add(Me.winLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.mousePictureBox)
        Me.Controls.Add(Me.notHerePictureBox)
        Me.Controls.Add(Me.questionPictureBox)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.startButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find the Mouse Game"
        CType(Me.mousePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.notHerePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.questionPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents questionPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents notHerePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents mousePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents winLabel As System.Windows.Forms.Label

End Class
