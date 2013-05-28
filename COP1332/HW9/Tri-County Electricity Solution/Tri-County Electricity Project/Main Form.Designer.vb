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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.commercialRadioButton = New System.Windows.Forms.RadioButton()
        Me.residentialRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.previousTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currentTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usageLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.commercialRadioButton)
        Me.GroupBox1.Controls.Add(Me.residentialRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(112, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 90)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rate codes"
        '
        'commercialRadioButton
        '
        Me.commercialRadioButton.Location = New System.Drawing.Point(6, 55)
        Me.commercialRadioButton.Name = "commercialRadioButton"
        Me.commercialRadioButton.Size = New System.Drawing.Size(142, 29)
        Me.commercialRadioButton.TabIndex = 1
        Me.commercialRadioButton.Text = "&2. Commercial"
        Me.commercialRadioButton.UseVisualStyleBackColor = True
        '
        'residentialRadioButton
        '
        Me.residentialRadioButton.Checked = True
        Me.residentialRadioButton.Location = New System.Drawing.Point(6, 28)
        Me.residentialRadioButton.Name = "residentialRadioButton"
        Me.residentialRadioButton.Size = New System.Drawing.Size(142, 29)
        Me.residentialRadioButton.TabIndex = 0
        Me.residentialRadioButton.TabStop = True
        Me.residentialRadioButton.Text = "&1. Residential"
        Me.residentialRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(78, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Previous reading:"
        '
        'previousTextBox
        '
        Me.previousTextBox.Location = New System.Drawing.Point(82, 138)
        Me.previousTextBox.Name = "previousTextBox"
        Me.previousTextBox.Size = New System.Drawing.Size(105, 29)
        Me.previousTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(78, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Current &reading:"
        '
        'currentTextBox
        '
        Me.currentTextBox.Location = New System.Drawing.Point(82, 196)
        Me.currentTextBox.Name = "currentTextBox"
        Me.currentTextBox.Size = New System.Drawing.Size(105, 29)
        Me.currentTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(78, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Monthly usage:"
        '
        'usageLabel
        '
        Me.usageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usageLabel.Location = New System.Drawing.Point(82, 251)
        Me.usageLabel.Name = "usageLabel"
        Me.usageLabel.Size = New System.Drawing.Size(105, 25)
        Me.usageLabel.TabIndex = 8
        Me.usageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Location = New System.Drawing.Point(215, 251)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(105, 25)
        Me.totalLabel.TabIndex = 10
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(211, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total charge:"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(82, 284)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(105, 30)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(215, 284)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(105, 30)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tri_County_Electricity_Project.My.Resources.Resources.Lightning
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(400, 600)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.usageLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.currentTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.previousTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tri-County Electricity"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents commercialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents residentialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents previousTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents currentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents usageLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
