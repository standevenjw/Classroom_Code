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
        Me.abbyButton = New System.Windows.Forms.Button()
        Me.rascalButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.displayPictureBox = New System.Windows.Forms.PictureBox()
        Me.abbyPictureBox = New System.Windows.Forms.PictureBox()
        Me.rascalPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.abbyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rascalPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'abbyButton
        '
        Me.abbyButton.Location = New System.Drawing.Point(41, 204)
        Me.abbyButton.Name = "abbyButton"
        Me.abbyButton.Size = New System.Drawing.Size(75, 29)
        Me.abbyButton.TabIndex = 0
        Me.abbyButton.Text = "Abby"
        Me.abbyButton.UseVisualStyleBackColor = True
        '
        'rascalButton
        '
        Me.rascalButton.Location = New System.Drawing.Point(129, 204)
        Me.rascalButton.Name = "rascalButton"
        Me.rascalButton.Size = New System.Drawing.Size(75, 29)
        Me.rascalButton.TabIndex = 1
        Me.rascalButton.Text = "Rascal"
        Me.rascalButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(217, 204)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 29)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'nameLabel
        '
        Me.nameLabel.BackColor = System.Drawing.Color.White
        Me.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nameLabel.Location = New System.Drawing.Point(126, 13)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(80, 25)
        Me.nameLabel.TabIndex = 3
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayPictureBox
        '
        Me.displayPictureBox.BackColor = System.Drawing.Color.White
        Me.displayPictureBox.Location = New System.Drawing.Point(106, 41)
        Me.displayPictureBox.Name = "displayPictureBox"
        Me.displayPictureBox.Size = New System.Drawing.Size(120, 130)
        Me.displayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox.TabIndex = 4
        Me.displayPictureBox.TabStop = False
        '
        'abbyPictureBox
        '
        Me.abbyPictureBox.Image = CType(resources.GetObject("abbyPictureBox.Image"), System.Drawing.Image)
        Me.abbyPictureBox.Location = New System.Drawing.Point(23, 251)
        Me.abbyPictureBox.Name = "abbyPictureBox"
        Me.abbyPictureBox.Size = New System.Drawing.Size(120, 130)
        Me.abbyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.abbyPictureBox.TabIndex = 5
        Me.abbyPictureBox.TabStop = False
        '
        'rascalPictureBox
        '
        Me.rascalPictureBox.Image = CType(resources.GetObject("rascalPictureBox.Image"), System.Drawing.Image)
        Me.rascalPictureBox.Location = New System.Drawing.Point(190, 251)
        Me.rascalPictureBox.Name = "rascalPictureBox"
        Me.rascalPictureBox.Size = New System.Drawing.Size(120, 130)
        Me.rascalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rascalPictureBox.TabIndex = 6
        Me.rascalPictureBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(333, 399)
        Me.Controls.Add(Me.rascalPictureBox)
        Me.Controls.Add(Me.abbyPictureBox)
        Me.Controls.Add(Me.displayPictureBox)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.rascalButton)
        Me.Controls.Add(Me.abbyButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horse Auction"
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.abbyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rascalPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents abbyButton As System.Windows.Forms.Button
    Friend WithEvents rascalButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents displayPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents abbyPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents rascalPictureBox As System.Windows.Forms.PictureBox

End Class
