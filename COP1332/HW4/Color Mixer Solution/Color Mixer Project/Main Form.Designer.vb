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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.redTextBox = New System.Windows.Forms.TextBox()
        Me.greenTextBox = New System.Windows.Forms.TextBox()
        Me.blueTextBox = New System.Windows.Forms.TextBox()
        Me.viewButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.colorOvalShape = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Red (0 to 255):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Green (0 to 255):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Blue (0 to 255):"
        '
        'redTextBox
        '
        Me.redTextBox.BackColor = System.Drawing.Color.Tomato
        Me.redTextBox.Location = New System.Drawing.Point(155, 31)
        Me.redTextBox.Name = "redTextBox"
        Me.redTextBox.Size = New System.Drawing.Size(53, 27)
        Me.redTextBox.TabIndex = 1
        Me.redTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'greenTextBox
        '
        Me.greenTextBox.BackColor = System.Drawing.Color.LimeGreen
        Me.greenTextBox.Location = New System.Drawing.Point(155, 67)
        Me.greenTextBox.Name = "greenTextBox"
        Me.greenTextBox.Size = New System.Drawing.Size(53, 27)
        Me.greenTextBox.TabIndex = 3
        Me.greenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'blueTextBox
        '
        Me.blueTextBox.BackColor = System.Drawing.Color.RoyalBlue
        Me.blueTextBox.Location = New System.Drawing.Point(155, 103)
        Me.blueTextBox.Name = "blueTextBox"
        Me.blueTextBox.Size = New System.Drawing.Size(53, 27)
        Me.blueTextBox.TabIndex = 5
        Me.blueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'viewButton
        '
        Me.viewButton.Location = New System.Drawing.Point(34, 145)
        Me.viewButton.Name = "viewButton"
        Me.viewButton.Size = New System.Drawing.Size(97, 34)
        Me.viewButton.TabIndex = 6
        Me.viewButton.Text = "&View Color"
        Me.viewButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(137, 145)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(71, 34)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.colorOvalShape})
        Me.ShapeContainer1.Size = New System.Drawing.Size(378, 228)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'colorOvalShape
        '
        Me.colorOvalShape.BackColor = System.Drawing.Color.White
        Me.colorOvalShape.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.colorOvalShape.Location = New System.Drawing.Point(244, 32)
        Me.colorOvalShape.Name = "colorOvalShape"
        Me.colorOvalShape.Size = New System.Drawing.Size(99, 143)
        '
        'MainForm
        '
        Me.AcceptButton = Me.viewButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 228)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.viewButton)
        Me.Controls.Add(Me.blueTextBox)
        Me.Controls.Add(Me.greenTextBox)
        Me.Controls.Add(Me.redTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Mixer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents redTextBox As System.Windows.Forms.TextBox
    Friend WithEvents greenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents blueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents viewButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents colorOvalShape As Microsoft.VisualBasic.PowerPacks.OvalShape

End Class
