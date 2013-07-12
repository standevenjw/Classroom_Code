<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.winnerLabel = New System.Windows.Forms.Label()
        Me.paperPictureBox = New System.Windows.Forms.PictureBox()
        Me.scissorsPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rockPictureBox = New System.Windows.Forms.PictureBox()
        Me.playerLabel = New System.Windows.Forms.Label()
        Me.computerLabel = New System.Windows.Forms.Label()
        Me.scrButton = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.compRectShape = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.playerRectShape = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        CType(Me.paperPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scissorsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rockPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(357, 208)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(55, 29)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        '
        'winnerLabel
        '
        Me.winnerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.winnerLabel.Location = New System.Drawing.Point(39, 164)
        Me.winnerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.winnerLabel.Name = "winnerLabel"
        Me.winnerLabel.Size = New System.Drawing.Size(373, 26)
        Me.winnerLabel.TabIndex = 5
        Me.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'paperPictureBox
        '
        Me.paperPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.paperPictureBox.Image = Global.RockPaperScissorsGame_Project.My.Resources.Resources.Paper
        Me.paperPictureBox.Location = New System.Drawing.Point(168, 54)
        Me.paperPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.paperPictureBox.Name = "paperPictureBox"
        Me.paperPictureBox.Size = New System.Drawing.Size(115, 86)
        Me.paperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.paperPictureBox.TabIndex = 9
        Me.paperPictureBox.TabStop = False
        '
        'scissorsPictureBox
        '
        Me.scissorsPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.scissorsPictureBox.Image = Global.RockPaperScissorsGame_Project.My.Resources.Resources.Scissors
        Me.scissorsPictureBox.Location = New System.Drawing.Point(297, 54)
        Me.scissorsPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.scissorsPictureBox.Name = "scissorsPictureBox"
        Me.scissorsPictureBox.Size = New System.Drawing.Size(115, 86)
        Me.scissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.scissorsPictureBox.TabIndex = 10
        Me.scissorsPictureBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Click the Rock, Paper, or Scissors image"
        '
        'rockPictureBox
        '
        Me.rockPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rockPictureBox.Image = Global.RockPaperScissorsGame_Project.My.Resources.Resources.Rock
        Me.rockPictureBox.Location = New System.Drawing.Point(39, 54)
        Me.rockPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.rockPictureBox.Name = "rockPictureBox"
        Me.rockPictureBox.Size = New System.Drawing.Size(115, 86)
        Me.rockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.rockPictureBox.TabIndex = 11
        Me.rockPictureBox.TabStop = False
        '
        'playerLabel
        '
        Me.playerLabel.AutoSize = True
        Me.playerLabel.BackColor = System.Drawing.Color.Transparent
        Me.playerLabel.ForeColor = System.Drawing.Color.Blue
        Me.playerLabel.Location = New System.Drawing.Point(41, 56)
        Me.playerLabel.Name = "playerLabel"
        Me.playerLabel.Size = New System.Drawing.Size(49, 20)
        Me.playerLabel.TabIndex = 3
        Me.playerLabel.Text = "Player"
        Me.playerLabel.Visible = False
        '
        'computerLabel
        '
        Me.computerLabel.AutoSize = True
        Me.computerLabel.BackColor = System.Drawing.Color.Transparent
        Me.computerLabel.ForeColor = System.Drawing.Color.Red
        Me.computerLabel.Location = New System.Drawing.Point(77, 118)
        Me.computerLabel.Name = "computerLabel"
        Me.computerLabel.Size = New System.Drawing.Size(75, 20)
        Me.computerLabel.TabIndex = 4
        Me.computerLabel.Text = "Computer"
        Me.computerLabel.Visible = False
        '
        'scrButton
        '
        Me.scrButton.Location = New System.Drawing.Point(297, 208)
        Me.scrButton.Margin = New System.Windows.Forms.Padding(2)
        Me.scrButton.Name = "scrButton"
        Me.scrButton.Size = New System.Drawing.Size(55, 29)
        Me.scrButton.TabIndex = 0
        Me.scrButton.Text = "&Score"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.compRectShape, Me.playerRectShape})
        Me.ShapeContainer1.Size = New System.Drawing.Size(447, 255)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'compRectShape
        '
        Me.compRectShape.BorderColor = System.Drawing.Color.Red
        Me.compRectShape.BorderWidth = 5
        Me.compRectShape.Location = New System.Drawing.Point(39, 54)
        Me.compRectShape.Name = "compRectShape"
        Me.compRectShape.Size = New System.Drawing.Size(115, 86)
        Me.compRectShape.Visible = False
        '
        'playerRectShape
        '
        Me.playerRectShape.BorderColor = System.Drawing.Color.Blue
        Me.playerRectShape.BorderWidth = 15
        Me.playerRectShape.Location = New System.Drawing.Point(39, 54)
        Me.playerRectShape.Name = "playerRectShape"
        Me.playerRectShape.Size = New System.Drawing.Size(115, 86)
        Me.playerRectShape.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 255)
        Me.Controls.Add(Me.playerLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.winnerLabel)
        Me.Controls.Add(Me.scrButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.computerLabel)
        Me.Controls.Add(Me.rockPictureBox)
        Me.Controls.Add(Me.paperPictureBox)
        Me.Controls.Add(Me.scissorsPictureBox)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rock, Paper, Scissors Game"
        CType(Me.paperPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scissorsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rockPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents winnerLabel As System.Windows.Forms.Label
    Friend WithEvents paperPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents scissorsPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rockPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents playerLabel As System.Windows.Forms.Label
    Friend WithEvents computerLabel As System.Windows.Forms.Label
    Friend WithEvents scrButton As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents compRectShape As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents playerRectShape As Microsoft.VisualBasic.PowerPacks.RectangleShape

End Class
