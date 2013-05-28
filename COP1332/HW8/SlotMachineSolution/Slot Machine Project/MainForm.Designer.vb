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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.spinButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.centerImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.stopButton = New System.Windows.Forms.Button()
        Me.winLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tLeftPictureBox = New System.Windows.Forms.PictureBox()
        Me.bLeftPictureBox = New System.Windows.Forms.PictureBox()
        Me.mLeftPictureBox = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.mRightPictureBox = New System.Windows.Forms.PictureBox()
        Me.bRightPictureBox = New System.Windows.Forms.PictureBox()
        Me.tRightPictureBox = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.mCenterPictureBox = New System.Windows.Forms.PictureBox()
        Me.bCenterPictureBox = New System.Windows.Forms.PictureBox()
        Me.tCenterPictureBox = New System.Windows.Forms.PictureBox()
        Me.topImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.tLeftPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bLeftPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mLeftPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.mRightPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bRightPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tRightPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.mCenterPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bCenterPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCenterPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spinButton
        '
        Me.spinButton.Font = New System.Drawing.Font("Bradley Hand ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spinButton.Location = New System.Drawing.Point(61, 244)
        Me.spinButton.Name = "spinButton"
        Me.spinButton.Size = New System.Drawing.Size(99, 61)
        Me.spinButton.TabIndex = 0
        Me.spinButton.Text = "&Spin"
        Me.spinButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Font = New System.Drawing.Font("Bradley Hand ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(280, 244)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 61)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'centerImageList
        '
        Me.centerImageList.ImageStream = CType(resources.GetObject("centerImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.centerImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.centerImageList.Images.SetKeyName(0, "j0436899.png")
        Me.centerImageList.Images.SetKeyName(1, "j0436903.png")
        Me.centerImageList.Images.SetKeyName(2, "j0441708.png")
        Me.centerImageList.Images.SetKeyName(3, "j0441718.png")
        Me.centerImageList.Images.SetKeyName(4, "j0441719.png")
        Me.centerImageList.Images.SetKeyName(5, "j0441720.png")
        '
        'stopButton
        '
        Me.stopButton.Enabled = False
        Me.stopButton.Font = New System.Drawing.Font("Bradley Hand ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopButton.Location = New System.Drawing.Point(171, 244)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(99, 61)
        Me.stopButton.TabIndex = 1
        Me.stopButton.Text = "S&top"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'winLabel
        '
        Me.winLabel.BackColor = System.Drawing.Color.Gray
        Me.winLabel.Font = New System.Drawing.Font("Felix Titling", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winLabel.ForeColor = System.Drawing.Color.Gold
        Me.winLabel.Location = New System.Drawing.Point(61, 53)
        Me.winLabel.Name = "winLabel"
        Me.winLabel.Size = New System.Drawing.Size(319, 165)
        Me.winLabel.TabIndex = 6
        Me.winLabel.Text = "Winner!!!"
        Me.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.winLabel.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tLeftPictureBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.bLeftPictureBox, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.mLeftPictureBox, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(61, 53)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(99, 163)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'tLeftPictureBox
        '
        Me.tLeftPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tLeftPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.tLeftPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tLeftPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.tLeftPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.tLeftPictureBox.Name = "tLeftPictureBox"
        Me.tLeftPictureBox.Size = New System.Drawing.Size(99, 40)
        Me.tLeftPictureBox.TabIndex = 0
        Me.tLeftPictureBox.TabStop = False
        '
        'bLeftPictureBox
        '
        Me.bLeftPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bLeftPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bLeftPictureBox.Location = New System.Drawing.Point(0, 121)
        Me.bLeftPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.bLeftPictureBox.Name = "bLeftPictureBox"
        Me.bLeftPictureBox.Size = New System.Drawing.Size(99, 42)
        Me.bLeftPictureBox.TabIndex = 0
        Me.bLeftPictureBox.TabStop = False
        '
        'mLeftPictureBox
        '
        Me.mLeftPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mLeftPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mLeftPictureBox.Location = New System.Drawing.Point(0, 40)
        Me.mLeftPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.mLeftPictureBox.Name = "mLeftPictureBox"
        Me.mLeftPictureBox.Size = New System.Drawing.Size(99, 81)
        Me.mLeftPictureBox.TabIndex = 0
        Me.mLeftPictureBox.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.mRightPictureBox, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.bRightPictureBox, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.tRightPictureBox, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(280, 53)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(99, 163)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'mRightPictureBox
        '
        Me.mRightPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mRightPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mRightPictureBox.Location = New System.Drawing.Point(0, 40)
        Me.mRightPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.mRightPictureBox.Name = "mRightPictureBox"
        Me.mRightPictureBox.Size = New System.Drawing.Size(99, 81)
        Me.mRightPictureBox.TabIndex = 0
        Me.mRightPictureBox.TabStop = False
        '
        'bRightPictureBox
        '
        Me.bRightPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bRightPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bRightPictureBox.Location = New System.Drawing.Point(0, 121)
        Me.bRightPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.bRightPictureBox.Name = "bRightPictureBox"
        Me.bRightPictureBox.Size = New System.Drawing.Size(99, 42)
        Me.bRightPictureBox.TabIndex = 0
        Me.bRightPictureBox.TabStop = False
        '
        'tRightPictureBox
        '
        Me.tRightPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tRightPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.tRightPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tRightPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.tRightPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.tRightPictureBox.Name = "tRightPictureBox"
        Me.tRightPictureBox.Size = New System.Drawing.Size(99, 40)
        Me.tRightPictureBox.TabIndex = 0
        Me.tRightPictureBox.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.mCenterPictureBox, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.bCenterPictureBox, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tCenterPictureBox, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(171, 53)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(99, 163)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'mCenterPictureBox
        '
        Me.mCenterPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mCenterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mCenterPictureBox.Location = New System.Drawing.Point(0, 40)
        Me.mCenterPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.mCenterPictureBox.Name = "mCenterPictureBox"
        Me.mCenterPictureBox.Size = New System.Drawing.Size(99, 81)
        Me.mCenterPictureBox.TabIndex = 0
        Me.mCenterPictureBox.TabStop = False
        '
        'bCenterPictureBox
        '
        Me.bCenterPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCenterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bCenterPictureBox.Location = New System.Drawing.Point(0, 121)
        Me.bCenterPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.bCenterPictureBox.Name = "bCenterPictureBox"
        Me.bCenterPictureBox.Size = New System.Drawing.Size(99, 42)
        Me.bCenterPictureBox.TabIndex = 0
        Me.bCenterPictureBox.TabStop = False
        '
        'tCenterPictureBox
        '
        Me.tCenterPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tCenterPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.tCenterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tCenterPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.tCenterPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.tCenterPictureBox.Name = "tCenterPictureBox"
        Me.tCenterPictureBox.Size = New System.Drawing.Size(99, 40)
        Me.tCenterPictureBox.TabIndex = 0
        Me.tCenterPictureBox.TabStop = False
        '
        'topImageList
        '
        Me.topImageList.ImageStream = CType(resources.GetObject("topImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.topImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.topImageList.Images.SetKeyName(0, "tj0436899.png")
        Me.topImageList.Images.SetKeyName(1, "tj0436903.png")
        Me.topImageList.Images.SetKeyName(2, "tj0441708.png")
        Me.topImageList.Images.SetKeyName(3, "tj0441718.png")
        Me.topImageList.Images.SetKeyName(4, "tj0441719.png")
        Me.topImageList.Images.SetKeyName(5, "tj0441720.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = Global.SlotMachineProject.My.Resources.Resources.slot_machine1
        Me.PictureBox1.Location = New System.Drawing.Point(-30, -115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(501, 502)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AcceptButton = Me.spinButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(441, 317)
        Me.ControlBox = False
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.spinButton)
        Me.Controls.Add(Me.winLabel)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slot Machine"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.tLeftPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bLeftPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mLeftPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.mRightPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bRightPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tRightPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.mCenterPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bCenterPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCenterPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mLeftPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents spinButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents centerImageList As System.Windows.Forms.ImageList
    Friend WithEvents stopButton As System.Windows.Forms.Button
    Friend WithEvents winLabel As System.Windows.Forms.Label
    Friend WithEvents tLeftPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bLeftPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents mRightPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents bRightPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents tRightPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents mCenterPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents bCenterPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents tCenterPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents topImageList As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
