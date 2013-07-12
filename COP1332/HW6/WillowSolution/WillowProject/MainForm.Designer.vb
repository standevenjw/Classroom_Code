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
        Me.maleRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.femaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inactiveRadioButton = New System.Windows.Forms.RadioButton()
        Me.activeRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.weightTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.displayLabel = New System.Windows.Forms.Label()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'maleRadioButton
        '
        Me.maleRadioButton.AutoSize = True
        Me.maleRadioButton.Checked = True
        Me.maleRadioButton.Location = New System.Drawing.Point(12, 28)
        Me.maleRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.maleRadioButton.Name = "maleRadioButton"
        Me.maleRadioButton.Size = New System.Drawing.Size(59, 21)
        Me.maleRadioButton.TabIndex = 0
        Me.maleRadioButton.TabStop = True
        Me.maleRadioButton.Text = "&Male"
        Me.maleRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.femaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.maleRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(140, 105)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'femaleRadioButton
        '
        Me.femaleRadioButton.AutoSize = True
        Me.femaleRadioButton.Location = New System.Drawing.Point(12, 62)
        Me.femaleRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.femaleRadioButton.Name = "femaleRadioButton"
        Me.femaleRadioButton.Size = New System.Drawing.Size(75, 21)
        Me.femaleRadioButton.TabIndex = 1
        Me.femaleRadioButton.Text = "&Female"
        Me.femaleRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.inactiveRadioButton)
        Me.GroupBox2.Controls.Add(Me.activeRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(163, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(140, 105)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Activity Level"
        '
        'inactiveRadioButton
        '
        Me.inactiveRadioButton.AutoSize = True
        Me.inactiveRadioButton.Location = New System.Drawing.Point(13, 62)
        Me.inactiveRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.inactiveRadioButton.Name = "inactiveRadioButton"
        Me.inactiveRadioButton.Size = New System.Drawing.Size(77, 21)
        Me.inactiveRadioButton.TabIndex = 1
        Me.inactiveRadioButton.Text = "&Inactive"
        Me.inactiveRadioButton.UseVisualStyleBackColor = True
        '
        'activeRadioButton
        '
        Me.activeRadioButton.AutoSize = True
        Me.activeRadioButton.Checked = True
        Me.activeRadioButton.Location = New System.Drawing.Point(13, 28)
        Me.activeRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.activeRadioButton.Name = "activeRadioButton"
        Me.activeRadioButton.Size = New System.Drawing.Size(67, 21)
        Me.activeRadioButton.TabIndex = 0
        Me.activeRadioButton.TabStop = True
        Me.activeRadioButton.Text = "&Active"
        Me.activeRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Weight:"
        '
        'weightTextBox
        '
        Me.weightTextBox.Location = New System.Drawing.Point(16, 159)
        Me.weightTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.weightTextBox.Name = "weightTextBox"
        Me.weightTextBox.Size = New System.Drawing.Size(101, 27)
        Me.weightTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Daily calories:"
        '
        'displayLabel
        '
        Me.displayLabel.BackColor = System.Drawing.SystemColors.Control
        Me.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.displayLabel.Location = New System.Drawing.Point(16, 224)
        Me.displayLabel.Name = "displayLabel"
        Me.displayLabel.Size = New System.Drawing.Size(101, 26)
        Me.displayLabel.TabIndex = 7
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(176, 184)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(127, 29)
        Me.displayButton.TabIndex = 4
        Me.displayButton.Text = "&Display Calories"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(176, 221)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(127, 29)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.displayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(319, 268)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.displayLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.weightTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Willow Health Club"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents maleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents femaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents inactiveRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents activeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents weightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents displayLabel As System.Windows.Forms.Label
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
