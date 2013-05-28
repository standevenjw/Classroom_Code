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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.displayVotesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.can1Label = New System.Windows.Forms.Label()
        Me.canOut1Label = New System.Windows.Forms.Label()
        Me.can2Label = New System.Windows.Forms.Label()
        Me.can3Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.candidateListBox = New System.Windows.Forms.ListBox()
        Me.canOut2Label = New System.Windows.Forms.Label()
        Me.canOut3Label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addButton = New System.Windows.Forms.Button()
        Me.resetVotesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.displayVotesMenuItem, Me.resetVotesMenuItem, Me.exitMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(289, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'displayVotesMenuItem
        '
        Me.displayVotesMenuItem.Name = "displayVotesMenuItem"
        Me.displayVotesMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.displayVotesMenuItem.Text = "&Display Votes"
        '
        'exitMenuItem
        '
        Me.exitMenuItem.Name = "exitMenuItem"
        Me.exitMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.exitMenuItem.Size = New System.Drawing.Size(45, 24)
        Me.exitMenuItem.Text = "E&xit"
        '
        'can1Label
        '
        Me.can1Label.AutoSize = True
        Me.can1Label.Location = New System.Drawing.Point(13, 18)
        Me.can1Label.Name = "can1Label"
        Me.can1Label.Size = New System.Drawing.Size(84, 17)
        Me.can1Label.TabIndex = 0
        Me.can1Label.Text = "Candidate 1"
        '
        'canOut1Label
        '
        Me.canOut1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.canOut1Label.Location = New System.Drawing.Point(16, 39)
        Me.canOut1Label.Name = "canOut1Label"
        Me.canOut1Label.Size = New System.Drawing.Size(85, 23)
        Me.canOut1Label.TabIndex = 1
        Me.canOut1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'can2Label
        '
        Me.can2Label.AutoSize = True
        Me.can2Label.Location = New System.Drawing.Point(13, 65)
        Me.can2Label.Name = "can2Label"
        Me.can2Label.Size = New System.Drawing.Size(84, 17)
        Me.can2Label.TabIndex = 2
        Me.can2Label.Text = "Candidate 2"
        '
        'can3Label
        '
        Me.can3Label.AutoSize = True
        Me.can3Label.Location = New System.Drawing.Point(13, 111)
        Me.can3Label.Name = "can3Label"
        Me.can3Label.Size = New System.Drawing.Size(84, 17)
        Me.can3Label.TabIndex = 4
        Me.can3Label.Text = "Candidate 3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Candidate"
        '
        'candidateListBox
        '
        Me.candidateListBox.FormattingEnabled = True
        Me.candidateListBox.ItemHeight = 16
        Me.candidateListBox.Items.AddRange(New Object() {"Patel, Sheima", "Perez, Sam", "Stone, Mark"})
        Me.candidateListBox.Location = New System.Drawing.Point(15, 65)
        Me.candidateListBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.candidateListBox.Name = "candidateListBox"
        Me.candidateListBox.Size = New System.Drawing.Size(120, 52)
        Me.candidateListBox.TabIndex = 2
        '
        'canOut2Label
        '
        Me.canOut2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.canOut2Label.Location = New System.Drawing.Point(16, 85)
        Me.canOut2Label.Name = "canOut2Label"
        Me.canOut2Label.Size = New System.Drawing.Size(85, 23)
        Me.canOut2Label.TabIndex = 3
        Me.canOut2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'canOut3Label
        '
        Me.canOut3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.canOut3Label.Location = New System.Drawing.Point(16, 130)
        Me.canOut3Label.Name = "canOut3Label"
        Me.canOut3Label.Size = New System.Drawing.Size(85, 23)
        Me.canOut3Label.TabIndex = 5
        Me.canOut3Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.can2Label)
        Me.Panel1.Controls.Add(Me.canOut2Label)
        Me.Panel1.Controls.Add(Me.can3Label)
        Me.Panel1.Controls.Add(Me.canOut3Label)
        Me.Panel1.Controls.Add(Me.can1Label)
        Me.Panel1.Controls.Add(Me.canOut1Label)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(173, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(116, 164)
        Me.Panel1.TabIndex = 4
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(15, 123)
        Me.addButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(120, 57)
        Me.addButton.TabIndex = 3
        Me.addButton.Text = "&Add Vote"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'resetVotesMenuItem
        '
        Me.resetVotesMenuItem.Name = "resetVotesMenuItem"
        Me.resetVotesMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.resetVotesMenuItem.Text = "&Reset Votes"
        '
        'MainForm
        '
        Me.AcceptButton = Me.addButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 192)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.candidateListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warren High School"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents displayVotesMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents can1Label As System.Windows.Forms.Label
    Friend WithEvents canOut1Label As System.Windows.Forms.Label
    Friend WithEvents can2Label As System.Windows.Forms.Label
    Friend WithEvents can3Label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents candidateListBox As System.Windows.Forms.ListBox
    Friend WithEvents canOut2Label As System.Windows.Forms.Label
    Friend WithEvents canOut3Label As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents resetVotesMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
