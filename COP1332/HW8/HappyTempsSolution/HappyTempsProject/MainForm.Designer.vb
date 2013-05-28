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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.doubleRadioButton = New System.Windows.Forms.RadioButton()
        Me.flatRadioButton = New System.Windows.Forms.RadioButton()
        Me.daysTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.salaryLabel = New System.Windows.Forms.Label()
        Me.salaryTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(267, 365)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(140, 29)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.doubleRadioButton)
        Me.GroupBox1.Controls.Add(Me.flatRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'doubleRadioButton
        '
        Me.doubleRadioButton.AutoSize = True
        Me.doubleRadioButton.Checked = True
        Me.doubleRadioButton.Location = New System.Drawing.Point(6, 28)
        Me.doubleRadioButton.Name = "doubleRadioButton"
        Me.doubleRadioButton.Size = New System.Drawing.Size(129, 21)
        Me.doubleRadioButton.TabIndex = 0
        Me.doubleRadioButton.TabStop = True
        Me.doubleRadioButton.Text = "&Doubling Salary"
        Me.doubleRadioButton.UseVisualStyleBackColor = True
        '
        'flatRadioButton
        '
        Me.flatRadioButton.AutoSize = True
        Me.flatRadioButton.Location = New System.Drawing.Point(6, 58)
        Me.flatRadioButton.Name = "flatRadioButton"
        Me.flatRadioButton.Size = New System.Drawing.Size(96, 21)
        Me.flatRadioButton.TabIndex = 1
        Me.flatRadioButton.Text = "&Flat Salary"
        Me.flatRadioButton.UseVisualStyleBackColor = True
        '
        'daysTextBox
        '
        Me.daysTextBox.Location = New System.Drawing.Point(267, 187)
        Me.daysTextBox.Name = "daysTextBox"
        Me.daysTextBox.Size = New System.Drawing.Size(140, 27)
        Me.daysTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(267, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Number of days:"
        '
        'salaryLabel
        '
        Me.salaryLabel.AutoSize = True
        Me.salaryLabel.Location = New System.Drawing.Point(267, 222)
        Me.salaryLabel.Name = "salaryLabel"
        Me.salaryLabel.Size = New System.Drawing.Size(136, 20)
        Me.salaryLabel.TabIndex = 3
        Me.salaryLabel.Text = "Fla&t salary increase:"
        Me.salaryLabel.Visible = False
        '
        'salaryTextBox
        '
        Me.salaryTextBox.Location = New System.Drawing.Point(267, 245)
        Me.salaryTextBox.Name = "salaryTextBox"
        Me.salaryTextBox.Size = New System.Drawing.Size(140, 27)
        Me.salaryTextBox.TabIndex = 4
        Me.salaryTextBox.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(386, 120)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total"
        '
        'totalTextBox
        '
        Me.totalTextBox.Location = New System.Drawing.Point(267, 303)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.ReadOnly = True
        Me.totalTextBox.Size = New System.Drawing.Size(140, 27)
        Me.totalTextBox.TabIndex = 8
        Me.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(121, 365)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(140, 29)
        Me.calcButton.TabIndex = 5
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(423, 411)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.totalTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.salaryTextBox)
        Me.Controls.Add(Me.salaryLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.daysTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Text = "Happy Temps"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents doubleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents flatRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents daysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents salaryLabel As System.Windows.Forms.Label
    Friend WithEvents salaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents totalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button

End Class
