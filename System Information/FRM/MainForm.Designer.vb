<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BIOS", 2, 2)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CPU", 3, 3)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drives", 4, 4)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Network", 5, 5)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sound", 6, 6)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Video", 7, 7)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Computer", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date and Time", 9, 9)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Installed Programs", 10, 10)
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Services", 11, 11)
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Processes", 17, 17)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Special Folders", 12, 12)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Environment Variables", 18, 18)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Startup Programs", 13, 13)
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OEM Information", 16, 16)
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User Information", 14, 14)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Visual Styles", 15, 15)
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Operating System", 19, 19, New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System Information", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode18})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TreeViewSystemInfo = New System.Windows.Forms.TreeView()
        Me.ImageListTree = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabelDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabelUpTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerTime = New System.Windows.Forms.Timer(Me.components)
        Me.TimerTimeUp = New System.Windows.Forms.Timer(Me.components)
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PictureBoxHeader = New System.Windows.Forms.PictureBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer
        '
        Me.SplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer.Location = New System.Drawing.Point(0, 65)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.TreeViewSystemInfo)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.AutoScroll = True
        Me.SplitContainer.Panel2.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.SplitContainer.Panel2MinSize = 100
        Me.SplitContainer.Size = New System.Drawing.Size(745, 435)
        Me.SplitContainer.SplitterDistance = 224
        Me.SplitContainer.SplitterWidth = 3
        Me.SplitContainer.TabIndex = 0
        '
        'TreeViewSystemInfo
        '
        Me.TreeViewSystemInfo.BackColor = System.Drawing.Color.White
        Me.TreeViewSystemInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeViewSystemInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewSystemInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewSystemInfo.ImageIndex = 0
        Me.TreeViewSystemInfo.ImageList = Me.ImageListTree
        Me.TreeViewSystemInfo.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewSystemInfo.Name = "TreeViewSystemInfo"
        TreeNode1.BackColor = System.Drawing.Color.Transparent
        TreeNode1.ImageIndex = 2
        TreeNode1.Name = "BIOS"
        TreeNode1.SelectedImageIndex = 2
        TreeNode1.Text = "BIOS"
        TreeNode1.ToolTipText = "Information about the Basic Input Output System."
        TreeNode2.BackColor = System.Drawing.Color.Transparent
        TreeNode2.ImageIndex = 3
        TreeNode2.Name = "CPU"
        TreeNode2.SelectedImageIndex = 3
        TreeNode2.Text = "CPU"
        TreeNode2.ToolTipText = "Information about the Central Processing Unit (Processor)."
        TreeNode3.BackColor = System.Drawing.Color.Transparent
        TreeNode3.ImageIndex = 4
        TreeNode3.Name = "Drives"
        TreeNode3.SelectedImageIndex = 4
        TreeNode3.Text = "Drives"
        TreeNode3.ToolTipText = "Information about hard drives, removable drives and volumes."
        TreeNode4.BackColor = System.Drawing.Color.Transparent
        TreeNode4.ImageIndex = 5
        TreeNode4.Name = "Network"
        TreeNode4.SelectedImageIndex = 5
        TreeNode4.Text = "Network"
        TreeNode4.ToolTipText = "Information about network interfaces."
        TreeNode5.BackColor = System.Drawing.Color.Transparent
        TreeNode5.ImageIndex = 6
        TreeNode5.Name = "Sound"
        TreeNode5.SelectedImageIndex = 6
        TreeNode5.Text = "Sound"
        TreeNode5.ToolTipText = "Information about sound controllers."
        TreeNode6.BackColor = System.Drawing.Color.Transparent
        TreeNode6.ImageIndex = 7
        TreeNode6.Name = "Video"
        TreeNode6.SelectedImageIndex = 7
        TreeNode6.Text = "Video"
        TreeNode6.ToolTipText = "Information about video controllers."
        TreeNode7.BackColor = System.Drawing.Color.Transparent
        TreeNode7.Checked = True
        TreeNode7.ImageIndex = 1
        TreeNode7.Name = "Computer"
        TreeNode7.SelectedImageIndex = 1
        TreeNode7.Text = "Computer"
        TreeNode7.ToolTipText = "General information about this computer."
        TreeNode8.ImageIndex = 9
        TreeNode8.Name = "DateTime"
        TreeNode8.SelectedImageIndex = 9
        TreeNode8.Text = "Date and Time"
        TreeNode8.ToolTipText = "Date and time information."
        TreeNode9.ImageIndex = 10
        TreeNode9.Name = "Installed Programs"
        TreeNode9.SelectedImageIndex = 10
        TreeNode9.Text = "Installed Programs"
        TreeNode9.ToolTipText = "List of all installed programs."
        TreeNode10.ImageIndex = 11
        TreeNode10.Name = "Services"
        TreeNode10.SelectedImageIndex = 11
        TreeNode10.Text = "Services"
        TreeNode10.ToolTipText = "List and description of all installed services."
        TreeNode11.ImageIndex = 17
        TreeNode11.Name = "Processes"
        TreeNode11.SelectedImageIndex = 17
        TreeNode11.Text = "Processes"
        TreeNode11.ToolTipText = "Running processes on this computer."
        TreeNode12.BackColor = System.Drawing.Color.Transparent
        TreeNode12.ImageIndex = 12
        TreeNode12.Name = "SpecialFolders"
        TreeNode12.SelectedImageIndex = 12
        TreeNode12.Text = "Special Folders"
        TreeNode12.ToolTipText = "List of Windows® Special Folders and their paths."
        TreeNode13.ImageIndex = 18
        TreeNode13.Name = "EnvironmentVariables"
        TreeNode13.SelectedImageIndex = 18
        TreeNode13.Text = "Environment Variables"
        TreeNode13.ToolTipText = "List of variables used at the command line."
        TreeNode14.ImageIndex = 13
        TreeNode14.Name = "Startup Programs"
        TreeNode14.SelectedImageIndex = 13
        TreeNode14.Text = "Startup Programs"
        TreeNode14.ToolTipText = "Programs that run when you login."
        TreeNode15.ImageIndex = 16
        TreeNode15.Name = "OEMInformation"
        TreeNode15.SelectedImageIndex = 16
        TreeNode15.Text = "OEM Information"
        TreeNode15.ToolTipText = "Information added by OEM."
        TreeNode16.ImageIndex = 14
        TreeNode16.Name = "UserInformation"
        TreeNode16.SelectedImageIndex = 14
        TreeNode16.Text = "User Information"
        TreeNode16.ToolTipText = "Information about user: owner and auto logon."
        TreeNode17.ImageIndex = 15
        TreeNode17.Name = "VisualStyles"
        TreeNode17.SelectedImageIndex = 15
        TreeNode17.Text = "Visual Styles"
        TreeNode17.ToolTipText = "Information about the visual style currently in use."
        TreeNode18.BackColor = System.Drawing.Color.Transparent
        TreeNode18.ImageIndex = 19
        TreeNode18.Name = "OperatingSystem"
        TreeNode18.SelectedImageIndex = 19
        TreeNode18.Text = "Operating System"
        TreeNode18.ToolTipText = "Information about the operating system."
        TreeNode19.BackColor = System.Drawing.Color.Transparent
        TreeNode19.ImageIndex = 0
        TreeNode19.Name = "SystemInformation"
        TreeNode19.SelectedImageIndex = 0
        TreeNode19.Text = "System Information"
        Me.TreeViewSystemInfo.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode19})
        Me.TreeViewSystemInfo.SelectedImageIndex = 0
        Me.TreeViewSystemInfo.ShowNodeToolTips = True
        Me.TreeViewSystemInfo.ShowPlusMinus = False
        Me.TreeViewSystemInfo.Size = New System.Drawing.Size(224, 435)
        Me.TreeViewSystemInfo.TabIndex = 0
        '
        'ImageListTree
        '
        Me.ImageListTree.ImageStream = CType(resources.GetObject("ImageListTree.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListTree.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListTree.Images.SetKeyName(0, "System Information_16x16.png")
        Me.ImageListTree.Images.SetKeyName(1, "Computer_16x16.png")
        Me.ImageListTree.Images.SetKeyName(2, "")
        Me.ImageListTree.Images.SetKeyName(3, "")
        Me.ImageListTree.Images.SetKeyName(4, "Drive_16x16.png")
        Me.ImageListTree.Images.SetKeyName(5, "Network_16x16.png")
        Me.ImageListTree.Images.SetKeyName(6, "")
        Me.ImageListTree.Images.SetKeyName(7, "Video_16x16.png")
        Me.ImageListTree.Images.SetKeyName(8, "")
        Me.ImageListTree.Images.SetKeyName(9, "Date-Time_16x16.png")
        Me.ImageListTree.Images.SetKeyName(10, "Installed Programs_16x16.png")
        Me.ImageListTree.Images.SetKeyName(11, "Services_16x16.png")
        Me.ImageListTree.Images.SetKeyName(12, "SpecialFolder_16x16.png")
        Me.ImageListTree.Images.SetKeyName(13, "Startup_16x16.png")
        Me.ImageListTree.Images.SetKeyName(14, "Users_16x16.png")
        Me.ImageListTree.Images.SetKeyName(15, "VisualStyles_16x16.png")
        Me.ImageListTree.Images.SetKeyName(16, "OEM_16x 16.png")
        Me.ImageListTree.Images.SetKeyName(17, "Processes_16x16.png")
        Me.ImageListTree.Images.SetKeyName(18, "CMD_16x16.png")
        Me.ImageListTree.Images.SetKeyName(19, "Windows_16x16.png")
        '
        'StatusStrip
        '
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabelDateTime, Me.StatusLabelUpTime})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 502)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(744, 22)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'StatusLabelDateTime
        '
        Me.StatusLabelDateTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabelDateTime.Name = "StatusLabelDateTime"
        Me.StatusLabelDateTime.Size = New System.Drawing.Size(142, 17)
        Me.StatusLabelDateTime.Text = "Monday, January 10, 2006"
        '
        'StatusLabelUpTime
        '
        Me.StatusLabelUpTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabelUpTime.Name = "StatusLabelUpTime"
        Me.StatusLabelUpTime.Size = New System.Drawing.Size(106, 17)
        Me.StatusLabelUpTime.Text = "Up Time: 0:00:0005"
        '
        'TimerTime
        '
        Me.TimerTime.Enabled = True
        Me.TimerTime.Interval = 1000
        '
        'TimerTimeUp
        '
        Me.TimerTimeUp.Interval = 1000
        '
        'PanelHeader
        '
        Me.PanelHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelHeader.BackColor = System.Drawing.SystemColors.Control
        Me.PanelHeader.BackgroundImage = Global.SystemInformation.My.Resources.Resources.aurora_header
        Me.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelHeader.Controls.Add(Me.PictureBoxHeader)
        Me.PanelHeader.Controls.Add(Me.LabelTitle)
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(744, 64)
        Me.PanelHeader.TabIndex = 1
        '
        'PictureBoxHeader
        '
        Me.PictureBoxHeader.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxHeader.Image = Global.SystemInformation.My.Resources.Resources.System_Information_48x48
        Me.PictureBoxHeader.Location = New System.Drawing.Point(616, 8)
        Me.PictureBoxHeader.Name = "PictureBoxHeader"
        Me.PictureBoxHeader.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxHeader.TabIndex = 1
        Me.PictureBoxHeader.TabStop = False
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.White
        Me.LabelTitle.Location = New System.Drawing.Point(44, 20)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(220, 25)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "System Information"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(744, 524)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.SplitContainer)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Information"
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabelDateTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ImageListTree As System.Windows.Forms.ImageList
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents TreeViewSystemInfo As System.Windows.Forms.TreeView
    Friend WithEvents TimerTime As System.Windows.Forms.Timer
    Friend WithEvents StatusLabelUpTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimerTimeUp As System.Windows.Forms.Timer
    Friend WithEvents PictureBoxHeader As System.Windows.Forms.PictureBox

End Class
