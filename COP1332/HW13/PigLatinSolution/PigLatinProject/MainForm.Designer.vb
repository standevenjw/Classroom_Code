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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.extButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.outputLabel = New System.Windows.Forms.Label()
        Me.transButton = New System.Windows.Forms.Button()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Enter a word or sentence:"
        '
        'extButton
        '
        Me.extButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.extButton.Location = New System.Drawing.Point(328, 102)
        Me.extButton.Name = "extButton"
        Me.extButton.Size = New System.Drawing.Size(103, 29)
        Me.extButton.TabIndex = 1
        Me.extButton.Text = "E&xit"
        Me.extButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Translation:"
        '
        'outputLabel
        '
        Me.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.outputLabel.Location = New System.Drawing.Point(12, 95)
        Me.outputLabel.Name = "outputLabel"
        Me.outputLabel.Size = New System.Drawing.Size(310, 36)
        Me.outputLabel.TabIndex = 4
        Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'transButton
        '
        Me.transButton.Location = New System.Drawing.Point(328, 23)
        Me.transButton.Name = "transButton"
        Me.transButton.Size = New System.Drawing.Size(103, 29)
        Me.transButton.TabIndex = 5
        Me.transButton.Text = "&Translate"
        Me.transButton.UseVisualStyleBackColor = True
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(13, 30)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(309, 22)
        Me.inputTextBox.TabIndex = 6
        '
        'MainForm
        '
        Me.AcceptButton = Me.transButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.extButton
        Me.ClientSize = New System.Drawing.Size(441, 142)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.transButton)
        Me.Controls.Add(Me.outputLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.extButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Pig Latin Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents extButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents outputLabel As System.Windows.Forms.Label
    Friend WithEvents transButton As System.Windows.Forms.Button
    Friend WithEvents inputTextBox As System.Windows.Forms.TextBox

End Class
