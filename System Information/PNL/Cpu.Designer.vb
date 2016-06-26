<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Cpu
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
        Me.LabelTitle = New System.Windows.Forms.Label
        Me.PictureBoxPanel = New System.Windows.Forms.PictureBox
        Me.LabelManDesc = New System.Windows.Forms.Label
        Me.LabelProcessor = New System.Windows.Forms.Label
        Me.LabelSeparator = New System.Windows.Forms.Label
        Me.LabelNameDesc = New System.Windows.Forms.Label
        Me.LabelDescDesc = New System.Windows.Forms.Label
        Me.LabelAddrWdthDesc = New System.Windows.Forms.Label
        Me.LabelProcSpdDesc = New System.Windows.Forms.Label
        Me.LabelFSBSpdDesc = New System.Windows.Forms.Label
        Me.LabelL2CacheSzDesc = New System.Windows.Forms.Label
        Me.LabelL2CacheSpdDesc = New System.Windows.Forms.Label
        Me.LabelProcSockDesc = New System.Windows.Forms.Label
        Me.LabelNumCoresDesc = New System.Windows.Forms.Label
        Me.LabelManufacturer = New System.Windows.Forms.Label
        Me.LabelName = New System.Windows.Forms.Label
        Me.LabelDescription = New System.Windows.Forms.Label
        Me.LabelAddressWidth = New System.Windows.Forms.Label
        Me.LabelProcessorSpeed = New System.Windows.Forms.Label
        Me.LabelFSBSpeed = New System.Windows.Forms.Label
        Me.LabelL2CacheSize = New System.Windows.Forms.Label
        Me.LabelL2CacheSpeed = New System.Windows.Forms.Label
        Me.LabelProcessorSocket = New System.Windows.Forms.Label
        Me.LabelNumberCores = New System.Windows.Forms.Label
        Me.LabelNumLogicalProcDesc = New System.Windows.Forms.Label
        Me.LabelNumLogicalProc = New System.Windows.Forms.Label
        Me.LabelPowerManagementCapabilities = New System.Windows.Forms.Label
        Me.LabelPowerManagementCapabilitiesDesc = New System.Windows.Forms.Label
        Me.LabelPowerManagementSupported = New System.Windows.Forms.Label
        Me.LabelProcessorId = New System.Windows.Forms.Label
        Me.LabelPowerManagementSupportedDesc = New System.Windows.Forms.Label
        Me.LabelProcessorIdDesc = New System.Windows.Forms.Label
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
        Me.LabelTitle.Size = New System.Drawing.Size(50, 25)
        Me.LabelTitle.TabIndex = 7
        Me.LabelTitle.Text = "CPU"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.CPU_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 6
        Me.PictureBoxPanel.TabStop = False
        '
        'LabelManDesc
        '
        Me.LabelManDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelManDesc.Location = New System.Drawing.Point(80, 104)
        Me.LabelManDesc.Name = "LabelManDesc"
        Me.LabelManDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelManDesc.TabIndex = 14
        Me.LabelManDesc.Text = "Manufacturer:"
        '
        'LabelProcessor
        '
        Me.LabelProcessor.AutoSize = True
        Me.LabelProcessor.BackColor = System.Drawing.Color.Transparent
        Me.LabelProcessor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProcessor.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelProcessor.Location = New System.Drawing.Point(80, 72)
        Me.LabelProcessor.Name = "LabelProcessor"
        Me.LabelProcessor.Size = New System.Drawing.Size(67, 17)
        Me.LabelProcessor.TabIndex = 13
        Me.LabelProcessor.Text = "Processor"
        '
        'LabelSeparator
        '
        Me.LabelSeparator.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator.Location = New System.Drawing.Point(80, 94)
        Me.LabelSeparator.Name = "LabelSeparator"
        Me.LabelSeparator.Size = New System.Drawing.Size(420, 3)
        Me.LabelSeparator.TabIndex = 12
        '
        'LabelNameDesc
        '
        Me.LabelNameDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelNameDesc.Location = New System.Drawing.Point(80, 124)
        Me.LabelNameDesc.Name = "LabelNameDesc"
        Me.LabelNameDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelNameDesc.TabIndex = 15
        Me.LabelNameDesc.Text = "Model:"
        '
        'LabelDescDesc
        '
        Me.LabelDescDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescDesc.Location = New System.Drawing.Point(80, 144)
        Me.LabelDescDesc.Name = "LabelDescDesc"
        Me.LabelDescDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelDescDesc.TabIndex = 16
        Me.LabelDescDesc.Text = "Description:"
        '
        'LabelAddrWdthDesc
        '
        Me.LabelAddrWdthDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelAddrWdthDesc.Location = New System.Drawing.Point(80, 164)
        Me.LabelAddrWdthDesc.Name = "LabelAddrWdthDesc"
        Me.LabelAddrWdthDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelAddrWdthDesc.TabIndex = 18
        Me.LabelAddrWdthDesc.Text = "Address Width:"
        '
        'LabelProcSpdDesc
        '
        Me.LabelProcSpdDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelProcSpdDesc.Location = New System.Drawing.Point(80, 184)
        Me.LabelProcSpdDesc.Name = "LabelProcSpdDesc"
        Me.LabelProcSpdDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelProcSpdDesc.TabIndex = 19
        Me.LabelProcSpdDesc.Text = "Processor Speed:"
        '
        'LabelFSBSpdDesc
        '
        Me.LabelFSBSpdDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelFSBSpdDesc.Location = New System.Drawing.Point(80, 204)
        Me.LabelFSBSpdDesc.Name = "LabelFSBSpdDesc"
        Me.LabelFSBSpdDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelFSBSpdDesc.TabIndex = 20
        Me.LabelFSBSpdDesc.Text = "FSB Speed:"
        '
        'LabelL2CacheSzDesc
        '
        Me.LabelL2CacheSzDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelL2CacheSzDesc.Location = New System.Drawing.Point(80, 224)
        Me.LabelL2CacheSzDesc.Name = "LabelL2CacheSzDesc"
        Me.LabelL2CacheSzDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelL2CacheSzDesc.TabIndex = 21
        Me.LabelL2CacheSzDesc.Text = "Level 2 Cache Size:"
        '
        'LabelL2CacheSpdDesc
        '
        Me.LabelL2CacheSpdDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelL2CacheSpdDesc.Location = New System.Drawing.Point(80, 244)
        Me.LabelL2CacheSpdDesc.Name = "LabelL2CacheSpdDesc"
        Me.LabelL2CacheSpdDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelL2CacheSpdDesc.TabIndex = 22
        Me.LabelL2CacheSpdDesc.Text = "Level 2 Cache Speed:"
        '
        'LabelProcSockDesc
        '
        Me.LabelProcSockDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelProcSockDesc.Location = New System.Drawing.Point(80, 264)
        Me.LabelProcSockDesc.Name = "LabelProcSockDesc"
        Me.LabelProcSockDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelProcSockDesc.TabIndex = 23
        Me.LabelProcSockDesc.Text = "Processor Socket:"
        '
        'LabelNumCoresDesc
        '
        Me.LabelNumCoresDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelNumCoresDesc.Location = New System.Drawing.Point(80, 284)
        Me.LabelNumCoresDesc.Name = "LabelNumCoresDesc"
        Me.LabelNumCoresDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelNumCoresDesc.TabIndex = 24
        Me.LabelNumCoresDesc.Text = "Number of CPU Cores:"
        Me.LabelNumCoresDesc.Visible = False
        '
        'LabelManufacturer
        '
        Me.LabelManufacturer.BackColor = System.Drawing.Color.Transparent
        Me.LabelManufacturer.Location = New System.Drawing.Point(270, 104)
        Me.LabelManufacturer.Name = "LabelManufacturer"
        Me.LabelManufacturer.Size = New System.Drawing.Size(230, 15)
        Me.LabelManufacturer.TabIndex = 25
        '
        'LabelName
        '
        Me.LabelName.BackColor = System.Drawing.Color.Transparent
        Me.LabelName.Location = New System.Drawing.Point(270, 124)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(230, 15)
        Me.LabelName.TabIndex = 26
        '
        'LabelDescription
        '
        Me.LabelDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescription.Location = New System.Drawing.Point(270, 144)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(230, 15)
        Me.LabelDescription.TabIndex = 27
        '
        'LabelAddressWidth
        '
        Me.LabelAddressWidth.BackColor = System.Drawing.Color.Transparent
        Me.LabelAddressWidth.Location = New System.Drawing.Point(270, 164)
        Me.LabelAddressWidth.Name = "LabelAddressWidth"
        Me.LabelAddressWidth.Size = New System.Drawing.Size(230, 15)
        Me.LabelAddressWidth.TabIndex = 29
        '
        'LabelProcessorSpeed
        '
        Me.LabelProcessorSpeed.BackColor = System.Drawing.Color.Transparent
        Me.LabelProcessorSpeed.Location = New System.Drawing.Point(270, 184)
        Me.LabelProcessorSpeed.Name = "LabelProcessorSpeed"
        Me.LabelProcessorSpeed.Size = New System.Drawing.Size(230, 15)
        Me.LabelProcessorSpeed.TabIndex = 30
        '
        'LabelFSBSpeed
        '
        Me.LabelFSBSpeed.BackColor = System.Drawing.Color.Transparent
        Me.LabelFSBSpeed.Location = New System.Drawing.Point(270, 204)
        Me.LabelFSBSpeed.Name = "LabelFSBSpeed"
        Me.LabelFSBSpeed.Size = New System.Drawing.Size(230, 15)
        Me.LabelFSBSpeed.TabIndex = 31
        '
        'LabelL2CacheSize
        '
        Me.LabelL2CacheSize.BackColor = System.Drawing.Color.Transparent
        Me.LabelL2CacheSize.Location = New System.Drawing.Point(270, 224)
        Me.LabelL2CacheSize.Name = "LabelL2CacheSize"
        Me.LabelL2CacheSize.Size = New System.Drawing.Size(230, 15)
        Me.LabelL2CacheSize.TabIndex = 32
        '
        'LabelL2CacheSpeed
        '
        Me.LabelL2CacheSpeed.BackColor = System.Drawing.Color.Transparent
        Me.LabelL2CacheSpeed.Location = New System.Drawing.Point(270, 244)
        Me.LabelL2CacheSpeed.Name = "LabelL2CacheSpeed"
        Me.LabelL2CacheSpeed.Size = New System.Drawing.Size(230, 15)
        Me.LabelL2CacheSpeed.TabIndex = 33
        '
        'LabelProcessorSocket
        '
        Me.LabelProcessorSocket.BackColor = System.Drawing.Color.Transparent
        Me.LabelProcessorSocket.Location = New System.Drawing.Point(270, 264)
        Me.LabelProcessorSocket.Name = "LabelProcessorSocket"
        Me.LabelProcessorSocket.Size = New System.Drawing.Size(230, 15)
        Me.LabelProcessorSocket.TabIndex = 34
        '
        'LabelNumberCores
        '
        Me.LabelNumberCores.BackColor = System.Drawing.Color.Transparent
        Me.LabelNumberCores.Location = New System.Drawing.Point(270, 282)
        Me.LabelNumberCores.Name = "LabelNumberCores"
        Me.LabelNumberCores.Size = New System.Drawing.Size(230, 15)
        Me.LabelNumberCores.TabIndex = 35
        '
        'LabelNumLogicalProcDesc
        '
        Me.LabelNumLogicalProcDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelNumLogicalProcDesc.Location = New System.Drawing.Point(80, 304)
        Me.LabelNumLogicalProcDesc.Name = "LabelNumLogicalProcDesc"
        Me.LabelNumLogicalProcDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelNumLogicalProcDesc.TabIndex = 36
        Me.LabelNumLogicalProcDesc.Text = "Number of Logical Processors:"
        Me.LabelNumLogicalProcDesc.Visible = False
        '
        'LabelNumLogicalProc
        '
        Me.LabelNumLogicalProc.BackColor = System.Drawing.Color.Transparent
        Me.LabelNumLogicalProc.Location = New System.Drawing.Point(270, 302)
        Me.LabelNumLogicalProc.Name = "LabelNumLogicalProc"
        Me.LabelNumLogicalProc.Size = New System.Drawing.Size(230, 15)
        Me.LabelNumLogicalProc.TabIndex = 37
        Me.LabelNumLogicalProc.Visible = False
        '
        'LabelPowerManagementCapabilities
        '
        Me.LabelPowerManagementCapabilities.BackColor = System.Drawing.Color.Transparent
        Me.LabelPowerManagementCapabilities.Location = New System.Drawing.Point(270, 362)
        Me.LabelPowerManagementCapabilities.Name = "LabelPowerManagementCapabilities"
        Me.LabelPowerManagementCapabilities.Size = New System.Drawing.Size(230, 15)
        Me.LabelPowerManagementCapabilities.TabIndex = 43
        Me.LabelPowerManagementCapabilities.Visible = False
        '
        'LabelPowerManagementCapabilitiesDesc
        '
        Me.LabelPowerManagementCapabilitiesDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelPowerManagementCapabilitiesDesc.Location = New System.Drawing.Point(80, 364)
        Me.LabelPowerManagementCapabilitiesDesc.Name = "LabelPowerManagementCapabilitiesDesc"
        Me.LabelPowerManagementCapabilitiesDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelPowerManagementCapabilitiesDesc.TabIndex = 42
        Me.LabelPowerManagementCapabilitiesDesc.Text = "Power Management Capabilities:"
        Me.LabelPowerManagementCapabilitiesDesc.Visible = False
        '
        'LabelPowerManagementSupported
        '
        Me.LabelPowerManagementSupported.BackColor = System.Drawing.Color.Transparent
        Me.LabelPowerManagementSupported.Location = New System.Drawing.Point(270, 342)
        Me.LabelPowerManagementSupported.Name = "LabelPowerManagementSupported"
        Me.LabelPowerManagementSupported.Size = New System.Drawing.Size(230, 15)
        Me.LabelPowerManagementSupported.TabIndex = 41
        '
        'LabelProcessorId
        '
        Me.LabelProcessorId.BackColor = System.Drawing.Color.Transparent
        Me.LabelProcessorId.Location = New System.Drawing.Point(270, 324)
        Me.LabelProcessorId.Name = "LabelProcessorId"
        Me.LabelProcessorId.Size = New System.Drawing.Size(230, 15)
        Me.LabelProcessorId.TabIndex = 40
        '
        'LabelPowerManagementSupportedDesc
        '
        Me.LabelPowerManagementSupportedDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelPowerManagementSupportedDesc.Location = New System.Drawing.Point(80, 344)
        Me.LabelPowerManagementSupportedDesc.Name = "LabelPowerManagementSupportedDesc"
        Me.LabelPowerManagementSupportedDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelPowerManagementSupportedDesc.TabIndex = 39
        Me.LabelPowerManagementSupportedDesc.Text = "Power Management Supported:"
        '
        'LabelProcessorIdDesc
        '
        Me.LabelProcessorIdDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelProcessorIdDesc.Location = New System.Drawing.Point(80, 324)
        Me.LabelProcessorIdDesc.Name = "LabelProcessorIdDesc"
        Me.LabelProcessorIdDesc.Size = New System.Drawing.Size(188, 15)
        Me.LabelProcessorIdDesc.TabIndex = 38
        Me.LabelProcessorIdDesc.Text = "Processor ID:"
        '
        'Cpu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.LabelPowerManagementCapabilities)
        Me.Controls.Add(Me.LabelPowerManagementCapabilitiesDesc)
        Me.Controls.Add(Me.LabelPowerManagementSupported)
        Me.Controls.Add(Me.LabelProcessorId)
        Me.Controls.Add(Me.LabelPowerManagementSupportedDesc)
        Me.Controls.Add(Me.LabelProcessorIdDesc)
        Me.Controls.Add(Me.LabelNumLogicalProc)
        Me.Controls.Add(Me.LabelNumLogicalProcDesc)
        Me.Controls.Add(Me.LabelNumberCores)
        Me.Controls.Add(Me.LabelProcessorSocket)
        Me.Controls.Add(Me.LabelL2CacheSpeed)
        Me.Controls.Add(Me.LabelL2CacheSize)
        Me.Controls.Add(Me.LabelFSBSpeed)
        Me.Controls.Add(Me.LabelProcessorSpeed)
        Me.Controls.Add(Me.LabelAddressWidth)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.LabelManufacturer)
        Me.Controls.Add(Me.LabelNumCoresDesc)
        Me.Controls.Add(Me.LabelProcSockDesc)
        Me.Controls.Add(Me.LabelL2CacheSpdDesc)
        Me.Controls.Add(Me.LabelL2CacheSzDesc)
        Me.Controls.Add(Me.LabelFSBSpdDesc)
        Me.Controls.Add(Me.LabelProcSpdDesc)
        Me.Controls.Add(Me.LabelAddrWdthDesc)
        Me.Controls.Add(Me.LabelDescDesc)
        Me.Controls.Add(Me.LabelNameDesc)
        Me.Controls.Add(Me.LabelManDesc)
        Me.Controls.Add(Me.LabelProcessor)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "Cpu"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents LabelManDesc As System.Windows.Forms.Label
    Private WithEvents LabelProcessor As System.Windows.Forms.Label
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents LabelNameDesc As System.Windows.Forms.Label
    Private WithEvents LabelDescDesc As System.Windows.Forms.Label
    Private WithEvents LabelAddrWdthDesc As System.Windows.Forms.Label
    Private WithEvents LabelProcSpdDesc As System.Windows.Forms.Label
    Private WithEvents LabelFSBSpdDesc As System.Windows.Forms.Label
    Private WithEvents LabelL2CacheSzDesc As System.Windows.Forms.Label
    Private WithEvents LabelL2CacheSpdDesc As System.Windows.Forms.Label
    Private WithEvents LabelProcSockDesc As System.Windows.Forms.Label
    Private WithEvents LabelNumCoresDesc As System.Windows.Forms.Label
    Private WithEvents LabelManufacturer As System.Windows.Forms.Label
    Private WithEvents LabelName As System.Windows.Forms.Label
    Private WithEvents LabelDescription As System.Windows.Forms.Label
    Private WithEvents LabelAddressWidth As System.Windows.Forms.Label
    Private WithEvents LabelProcessorSpeed As System.Windows.Forms.Label
    Private WithEvents LabelFSBSpeed As System.Windows.Forms.Label
    Private WithEvents LabelL2CacheSize As System.Windows.Forms.Label
    Private WithEvents LabelL2CacheSpeed As System.Windows.Forms.Label
    Private WithEvents LabelProcessorSocket As System.Windows.Forms.Label
    Private WithEvents LabelNumberCores As System.Windows.Forms.Label
    Private WithEvents LabelNumLogicalProcDesc As System.Windows.Forms.Label
    Private WithEvents LabelNumLogicalProc As System.Windows.Forms.Label
    Private WithEvents LabelPowerManagementCapabilities As System.Windows.Forms.Label
    Private WithEvents LabelPowerManagementCapabilitiesDesc As System.Windows.Forms.Label
    Private WithEvents LabelPowerManagementSupported As System.Windows.Forms.Label
    Private WithEvents LabelProcessorId As System.Windows.Forms.Label
    Private WithEvents LabelPowerManagementSupportedDesc As System.Windows.Forms.Label
    Private WithEvents LabelProcessorIdDesc As System.Windows.Forms.Label

End Class
