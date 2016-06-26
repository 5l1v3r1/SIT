<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Drives
    Inherits SystemInformation.TaskPanelBase

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Drives))
        Me.LabelTitle = New System.Windows.Forms.Label
        Me.PictureBoxPanel = New System.Windows.Forms.PictureBox
        Me.LabelVolumes = New System.Windows.Forms.Label
        Me.LabelSeparator = New System.Windows.Forms.Label
        Me.ListViewVolumes = New System.Windows.Forms.ListView
        Me.Drive = New System.Windows.Forms.ColumnHeader
        Me.VolumeLabel = New System.Windows.Forms.ColumnHeader
        Me.FileSystem = New System.Windows.Forms.ColumnHeader
        Me.TotalSize = New System.Windows.Forms.ColumnHeader
        Me.UsedSpace = New System.Windows.Forms.ColumnHeader
        Me.FreeSpace = New System.Windows.Forms.ColumnHeader
        Me.PercentFree = New System.Windows.Forms.ColumnHeader
        Me.Ready = New System.Windows.Forms.ColumnHeader
        Me.ImageListDrives = New System.Windows.Forms.ImageList(Me.components)
        Me.ListViewDrives = New System.Windows.Forms.ListView
        Me.PhysDrive = New System.Windows.Forms.ColumnHeader
        Me.InterfaceType = New System.Windows.Forms.ColumnHeader
        Me.Capacity = New System.Windows.Forms.ColumnHeader
        Me.ModelNumber = New System.Windows.Forms.ColumnHeader
        Me.Status = New System.Windows.Forms.ColumnHeader
        Me.LabelPhysHD = New System.Windows.Forms.Label
        Me.LabelSeparator2 = New System.Windows.Forms.Label
        Me.LabelLegend = New System.Windows.Forms.Label
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelTitle.Location = New System.Drawing.Point(80, 28)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(67, 25)
        Me.LabelTitle.TabIndex = 7
        Me.LabelTitle.Text = "Drives"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.Drive_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 6
        Me.PictureBoxPanel.TabStop = False
        '
        'LabelVolumes
        '
        Me.LabelVolumes.AutoSize = True
        Me.LabelVolumes.BackColor = System.Drawing.Color.Transparent
        Me.LabelVolumes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVolumes.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelVolumes.Location = New System.Drawing.Point(16, 76)
        Me.LabelVolumes.Name = "LabelVolumes"
        Me.LabelVolumes.Size = New System.Drawing.Size(62, 17)
        Me.LabelVolumes.TabIndex = 15
        Me.LabelVolumes.Text = "Volumes"
        '
        'LabelSeparator
        '
        Me.LabelSeparator.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator.Location = New System.Drawing.Point(16, 98)
        Me.LabelSeparator.Name = "LabelSeparator"
        Me.LabelSeparator.Size = New System.Drawing.Size(482, 3)
        Me.LabelSeparator.TabIndex = 14
        '
        'ListViewVolumes
        '
        Me.ListViewVolumes.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewVolumes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Drive, Me.VolumeLabel, Me.FileSystem, Me.TotalSize, Me.UsedSpace, Me.FreeSpace, Me.PercentFree, Me.Ready})
        Me.ListViewVolumes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewVolumes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListViewVolumes.FullRowSelect = True
        Me.ListViewVolumes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewVolumes.Location = New System.Drawing.Point(16, 110)
        Me.ListViewVolumes.MultiSelect = False
        Me.ListViewVolumes.Name = "ListViewVolumes"
        Me.ListViewVolumes.ShowGroups = False
        Me.ListViewVolumes.Size = New System.Drawing.Size(482, 134)
        Me.ListViewVolumes.SmallImageList = Me.ImageListDrives
        Me.ListViewVolumes.TabIndex = 16
        Me.ListViewVolumes.UseCompatibleStateImageBehavior = False
        Me.ListViewVolumes.View = System.Windows.Forms.View.Details
        '
        'Drive
        '
        Me.Drive.Text = "Drive"
        Me.Drive.Width = 40
        '
        'VolumeLabel
        '
        Me.VolumeLabel.Text = "Volume Label"
        Me.VolumeLabel.Width = 90
        '
        'FileSystem
        '
        Me.FileSystem.Text = "F.S."
        Me.FileSystem.Width = 40
        '
        'TotalSize
        '
        Me.TotalSize.Text = "Total Size"
        Me.TotalSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalSize.Width = 70
        '
        'UsedSpace
        '
        Me.UsedSpace.Text = "Used Space"
        Me.UsedSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UsedSpace.Width = 72
        '
        'FreeSpace
        '
        Me.FreeSpace.Text = "Free Space"
        Me.FreeSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FreeSpace.Width = 70
        '
        'PercentFree
        '
        Me.PercentFree.Text = "% Free"
        Me.PercentFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PercentFree.Width = 52
        '
        'Ready
        '
        Me.Ready.Text = "R"
        Me.Ready.Width = 22
        '
        'ImageListDrives
        '
        Me.ImageListDrives.ImageStream = CType(resources.GetObject("ImageListDrives.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListDrives.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListDrives.Images.SetKeyName(0, "Floppy_16x16.png")
        Me.ImageListDrives.Images.SetKeyName(1, "Drive_16x16.png")
        Me.ImageListDrives.Images.SetKeyName(2, "NetworkDrive_16x16.png")
        Me.ImageListDrives.Images.SetKeyName(3, "CDROM_16x16.png")
        Me.ImageListDrives.Images.SetKeyName(4, "UsbDrive_16x16.png")
        Me.ImageListDrives.Images.SetKeyName(5, "Unknown_16x16.png")
        '
        'ListViewDrives
        '
        Me.ListViewDrives.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewDrives.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PhysDrive, Me.InterfaceType, Me.Capacity, Me.ModelNumber, Me.Status})
        Me.ListViewDrives.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewDrives.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListViewDrives.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewDrives.Location = New System.Drawing.Point(16, 288)
        Me.ListViewDrives.Name = "ListViewDrives"
        Me.ListViewDrives.ShowGroups = False
        Me.ListViewDrives.Size = New System.Drawing.Size(482, 134)
        Me.ListViewDrives.SmallImageList = Me.ImageListDrives
        Me.ListViewDrives.TabIndex = 19
        Me.ListViewDrives.UseCompatibleStateImageBehavior = False
        Me.ListViewDrives.View = System.Windows.Forms.View.Details
        '
        'PhysDrive
        '
        Me.PhysDrive.Text = "Drive"
        Me.PhysDrive.Width = 40
        '
        'InterfaceType
        '
        Me.InterfaceType.Text = "Type"
        Me.InterfaceType.Width = 50
        '
        'Capacity
        '
        Me.Capacity.Text = "Capacity"
        Me.Capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Capacity.Width = 80
        '
        'ModelNumber
        '
        Me.ModelNumber.Text = "Model Number"
        Me.ModelNumber.Width = 240
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 45
        '
        'LabelPhysHD
        '
        Me.LabelPhysHD.AutoSize = True
        Me.LabelPhysHD.BackColor = System.Drawing.Color.Transparent
        Me.LabelPhysHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhysHD.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelPhysHD.Location = New System.Drawing.Point(16, 255)
        Me.LabelPhysHD.Name = "LabelPhysHD"
        Me.LabelPhysHD.Size = New System.Drawing.Size(101, 17)
        Me.LabelPhysHD.TabIndex = 18
        Me.LabelPhysHD.Text = "Physical Drives"
        '
        'LabelSeparator2
        '
        Me.LabelSeparator2.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator2.Location = New System.Drawing.Point(16, 276)
        Me.LabelSeparator2.Name = "LabelSeparator2"
        Me.LabelSeparator2.Size = New System.Drawing.Size(482, 3)
        Me.LabelSeparator2.TabIndex = 17
        '
        'LabelLegend
        '
        Me.LabelLegend.AutoSize = True
        Me.LabelLegend.BackColor = System.Drawing.Color.Transparent
        Me.LabelLegend.ForeColor = System.Drawing.Color.Black
        Me.LabelLegend.Location = New System.Drawing.Point(344, 78)
        Me.LabelLegend.Name = "LabelLegend"
        Me.LabelLegend.Size = New System.Drawing.Size(154, 15)
        Me.LabelLegend.TabIndex = 20
        Me.LabelLegend.Text = "F.S = File System, R = Ready"
        Me.LabelLegend.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Drives
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.LabelLegend)
        Me.Controls.Add(Me.ListViewDrives)
        Me.Controls.Add(Me.LabelPhysHD)
        Me.Controls.Add(Me.LabelSeparator2)
        Me.Controls.Add(Me.ListViewVolumes)
        Me.Controls.Add(Me.LabelVolumes)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "Drives"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents LabelVolumes As System.Windows.Forms.Label
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents ListViewVolumes As System.Windows.Forms.ListView
    Private WithEvents ImageListDrives As System.Windows.Forms.ImageList
    Private WithEvents ListViewDrives As System.Windows.Forms.ListView
    Private WithEvents LabelPhysHD As System.Windows.Forms.Label
    Private WithEvents LabelSeparator2 As System.Windows.Forms.Label
    Private WithEvents Drive As System.Windows.Forms.ColumnHeader
    Private WithEvents VolumeLabel As System.Windows.Forms.ColumnHeader
    Private WithEvents FileSystem As System.Windows.Forms.ColumnHeader
    Private WithEvents TotalSize As System.Windows.Forms.ColumnHeader
    Private WithEvents UsedSpace As System.Windows.Forms.ColumnHeader
    Private WithEvents FreeSpace As System.Windows.Forms.ColumnHeader
    Private WithEvents PercentFree As System.Windows.Forms.ColumnHeader
    Private WithEvents Ready As System.Windows.Forms.ColumnHeader
    Private WithEvents LabelLegend As System.Windows.Forms.Label
    Private WithEvents PhysDrive As System.Windows.Forms.ColumnHeader
    Private WithEvents Capacity As System.Windows.Forms.ColumnHeader
    Private WithEvents ModelNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents InterfaceType As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader

End Class
