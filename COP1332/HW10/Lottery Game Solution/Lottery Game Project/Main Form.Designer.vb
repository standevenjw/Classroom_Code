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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lotteryLabel = New System.Windows.Forms.Label()
        Me.getButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lottery numbers:"
        '
        'lotteryLabel
        '
        Me.lotteryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lotteryLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lotteryLabel.Location = New System.Drawing.Point(16, 220)
        Me.lotteryLabel.Name = "lotteryLabel"
        Me.lotteryLabel.Size = New System.Drawing.Size(221, 36)
        Me.lotteryLabel.TabIndex = 3
        Me.lotteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'getButton
        '
        Me.getButton.Location = New System.Drawing.Point(16, 270)
        Me.getButton.Name = "getButton"
        Me.getButton.Size = New System.Drawing.Size(124, 36)
        Me.getButton.TabIndex = 0
        Me.getButton.Text = "&Get Numbers"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(148, 270)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(89, 36)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lottery_Game_Project.My.Resources.Resources.j0157005
        Me.PictureBox1.Location = New System.Drawing.Point(16, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 318)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.getButton)
        Me.Controls.Add(Me.lotteryLabel)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lottery Game"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lotteryLabel As System.Windows.Forms.Label
    Friend WithEvents getButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
