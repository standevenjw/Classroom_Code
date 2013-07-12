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
        Me.bananaButton = New System.Windows.Forms.Button()
        Me.sundaeButton = New System.Windows.Forms.Button()
        Me.milkshkButton = New System.Windows.Forms.Button()
        Me.extButton = New System.Windows.Forms.Button()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bananaButton
        '
        Me.bananaButton.AutoSize = True
        Me.bananaButton.Location = New System.Drawing.Point(29, 27)
        Me.bananaButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bananaButton.Name = "bananaButton"
        Me.bananaButton.Size = New System.Drawing.Size(123, 30)
        Me.bananaButton.TabIndex = 0
        Me.bananaButton.Text = "Banana Split"
        Me.bananaButton.UseVisualStyleBackColor = True
        '
        'sundaeButton
        '
        Me.sundaeButton.AutoSize = True
        Me.sundaeButton.Location = New System.Drawing.Point(29, 63)
        Me.sundaeButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sundaeButton.Name = "sundaeButton"
        Me.sundaeButton.Size = New System.Drawing.Size(123, 30)
        Me.sundaeButton.TabIndex = 1
        Me.sundaeButton.Text = "Sundae"
        Me.sundaeButton.UseVisualStyleBackColor = True
        '
        'milkshkButton
        '
        Me.milkshkButton.AutoSize = True
        Me.milkshkButton.Location = New System.Drawing.Point(29, 100)
        Me.milkshkButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.milkshkButton.Name = "milkshkButton"
        Me.milkshkButton.Size = New System.Drawing.Size(123, 30)
        Me.milkshkButton.TabIndex = 2
        Me.milkshkButton.Text = "Milkshake"
        Me.milkshkButton.UseVisualStyleBackColor = True
        '
        'extButton
        '
        Me.extButton.AutoSize = True
        Me.extButton.Location = New System.Drawing.Point(29, 136)
        Me.extButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.extButton.Name = "extButton"
        Me.extButton.Size = New System.Drawing.Size(123, 30)
        Me.extButton.TabIndex = 3
        Me.extButton.Text = "Exit"
        Me.extButton.UseVisualStyleBackColor = True
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(249, 86)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(66, 20)
        Me.priceLabel.TabIndex = 4
        Me.priceLabel.Text = "Price ($):"
        '
        'priceTextBox
        '
        Me.priceTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.priceTextBox.Location = New System.Drawing.Point(333, 83)
        Me.priceTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.ReadOnly = True
        Me.priceTextBox.Size = New System.Drawing.Size(54, 27)
        Me.priceTextBox.TabIndex = 5
        Me.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(253, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(399, 192)
        Me.Controls.Add(Me.priceTextBox)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.extButton)
        Me.Controls.Add(Me.milkshkButton)
        Me.Controls.Add(Me.sundaeButton)
        Me.Controls.Add(Me.bananaButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Castle's Ice Cream Parlor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bananaButton As System.Windows.Forms.Button
    Friend WithEvents sundaeButton As System.Windows.Forms.Button
    Friend WithEvents milkshkButton As System.Windows.Forms.Button
    Friend WithEvents extButton As System.Windows.Forms.Button
    Friend WithEvents priceLabel As System.Windows.Forms.Label
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
