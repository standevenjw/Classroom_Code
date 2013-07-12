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
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lengthTextBox = New System.Windows.Forms.TextBox()
        Me.widthTextBox = New System.Windows.Forms.TextBox()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.areaLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.clrButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(25, 171)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(100, 29)
        Me.calcButton.TabIndex = 6
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(281, 171)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 29)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Length (feet):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Width (feet):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Price (sq. foot):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Area:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total price:"
        '
        'lengthTextBox
        '
        Me.lengthTextBox.Location = New System.Drawing.Point(25, 54)
        Me.lengthTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lengthTextBox.Name = "lengthTextBox"
        Me.lengthTextBox.Size = New System.Drawing.Size(100, 27)
        Me.lengthTextBox.TabIndex = 1
        Me.lengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'widthTextBox
        '
        Me.widthTextBox.Location = New System.Drawing.Point(153, 54)
        Me.widthTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.widthTextBox.Name = "widthTextBox"
        Me.widthTextBox.Size = New System.Drawing.Size(100, 27)
        Me.widthTextBox.TabIndex = 3
        Me.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(281, 54)
        Me.priceTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(100, 27)
        Me.priceTextBox.TabIndex = 5
        Me.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'areaLabel
        '
        Me.areaLabel.BackColor = System.Drawing.SystemColors.Control
        Me.areaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.areaLabel.Location = New System.Drawing.Point(25, 120)
        Me.areaLabel.Name = "areaLabel"
        Me.areaLabel.Size = New System.Drawing.Size(100, 21)
        Me.areaLabel.TabIndex = 10
        Me.areaLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Location = New System.Drawing.Point(153, 120)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(100, 21)
        Me.totalLabel.TabIndex = 12
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'clrButton
        '
        Me.clrButton.Location = New System.Drawing.Point(153, 171)
        Me.clrButton.Name = "clrButton"
        Me.clrButton.Size = New System.Drawing.Size(100, 29)
        Me.clrButton.TabIndex = 7
        Me.clrButton.Text = "Clea&r"
        Me.clrButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 230)
        Me.Controls.Add(Me.clrButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.areaLabel)
        Me.Controls.Add(Me.priceTextBox)
        Me.Controls.Add(Me.widthTextBox)
        Me.Controls.Add(Me.lengthTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Text = "Tile Limited"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lengthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents widthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents areaLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents clrButton As System.Windows.Forms.Button

End Class
