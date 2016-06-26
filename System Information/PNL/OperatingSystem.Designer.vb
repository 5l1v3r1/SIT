<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OperatingSystem
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
        Me.LabelCodeName = New System.Windows.Forms.Label
        Me.LabelVersion = New System.Windows.Forms.Label
        Me.LabelFullName = New System.Windows.Forms.Label
        Me.LabelWindows = New System.Windows.Forms.Label
        Me.LabelSeparatorTop = New System.Windows.Forms.Label
        Me.LabelMachineName = New System.Windows.Forms.Label
        Me.LabelUserName = New System.Windows.Forms.Label
        Me.LabelFullVersion = New System.Windows.Forms.Label
        Me.LabelFrameworkServicePack = New System.Windows.Forms.Label
        Me.LabelCLRVersion = New System.Windows.Forms.Label
        Me.LabelFrameworkVersion = New System.Windows.Forms.Label
        Me.LabelFramework = New System.Windows.Forms.Label
        Me.LabelSeperatorBottom = New System.Windows.Forms.Label
        Me.LabelProductKey = New System.Windows.Forms.Label
        Me.LabelProductID = New System.Windows.Forms.Label
        Me.LabelType = New System.Windows.Forms.Label
        Me.TextBoxProductID = New System.Windows.Forms.TextBox
        Me.TextBoxProductKey = New System.Windows.Forms.TextBox
        Me.LabelInstallDate = New System.Windows.Forms.Label
        Me.TextBoxFullName = New System.Windows.Forms.TextBox
        Me.TextBoxVersion = New System.Windows.Forms.TextBox
        Me.TextBoxFullVersion = New System.Windows.Forms.TextBox
        Me.TextBoxType = New System.Windows.Forms.TextBox
        Me.TextBoxCodeName = New System.Windows.Forms.TextBox
        Me.TextBoxMachineName = New System.Windows.Forms.TextBox
        Me.TextBoxUserName = New System.Windows.Forms.TextBox
        Me.TextBoxInstallDate = New System.Windows.Forms.TextBox
        Me.TextBoxClrServicePack = New System.Windows.Forms.TextBox
        Me.TextBoxClrVersion = New System.Windows.Forms.TextBox
        Me.TextBoxFrameworkVersion = New System.Windows.Forms.TextBox
        Me.TextBoxServicePack = New System.Windows.Forms.TextBox
        Me.LabelServicePack = New System.Windows.Forms.Label
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
        Me.LabelTitle.Size = New System.Drawing.Size(170, 25)
        Me.LabelTitle.TabIndex = 3
        Me.LabelTitle.Text = "Operating System"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 2
        Me.PictureBoxPanel.TabStop = False
        '
        'LabelCodeName
        '
        Me.LabelCodeName.BackColor = System.Drawing.Color.Transparent
        Me.LabelCodeName.Location = New System.Drawing.Point(80, 204)
        Me.LabelCodeName.Name = "LabelCodeName"
        Me.LabelCodeName.Size = New System.Drawing.Size(100, 15)
        Me.LabelCodeName.TabIndex = 19
        Me.LabelCodeName.Text = "Code Name:      "
        '
        'LabelVersion
        '
        Me.LabelVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersion.Location = New System.Drawing.Point(80, 124)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(100, 15)
        Me.LabelVersion.TabIndex = 18
        Me.LabelVersion.Text = "Version:      "
        '
        'LabelFullName
        '
        Me.LabelFullName.BackColor = System.Drawing.Color.Transparent
        Me.LabelFullName.Location = New System.Drawing.Point(80, 104)
        Me.LabelFullName.Name = "LabelFullName"
        Me.LabelFullName.Size = New System.Drawing.Size(100, 15)
        Me.LabelFullName.TabIndex = 17
        Me.LabelFullName.Text = "Name:        "
        '
        'LabelWindows
        '
        Me.LabelWindows.AutoSize = True
        Me.LabelWindows.BackColor = System.Drawing.Color.Transparent
        Me.LabelWindows.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWindows.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelWindows.Location = New System.Drawing.Point(80, 72)
        Me.LabelWindows.Name = "LabelWindows"
        Me.LabelWindows.Size = New System.Drawing.Size(154, 17)
        Me.LabelWindows.TabIndex = 16
        Me.LabelWindows.Text = "Windows® Information"
        '
        'LabelSeparatorTop
        '
        Me.LabelSeparatorTop.BackColor = System.Drawing.Color.Black
        Me.LabelSeparatorTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparatorTop.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparatorTop.Location = New System.Drawing.Point(80, 94)
        Me.LabelSeparatorTop.Name = "LabelSeparatorTop"
        Me.LabelSeparatorTop.Size = New System.Drawing.Size(420, 3)
        Me.LabelSeparatorTop.TabIndex = 15
        '
        'LabelMachineName
        '
        Me.LabelMachineName.BackColor = System.Drawing.Color.Transparent
        Me.LabelMachineName.Location = New System.Drawing.Point(80, 224)
        Me.LabelMachineName.Name = "LabelMachineName"
        Me.LabelMachineName.Size = New System.Drawing.Size(100, 15)
        Me.LabelMachineName.TabIndex = 20
        Me.LabelMachineName.Text = "Machine Name:       "
        '
        'LabelUserName
        '
        Me.LabelUserName.BackColor = System.Drawing.Color.Transparent
        Me.LabelUserName.Location = New System.Drawing.Point(80, 244)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(100, 15)
        Me.LabelUserName.TabIndex = 21
        Me.LabelUserName.Text = "Current User:     "
        '
        'LabelFullVersion
        '
        Me.LabelFullVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelFullVersion.Location = New System.Drawing.Point(80, 144)
        Me.LabelFullVersion.Name = "LabelFullVersion"
        Me.LabelFullVersion.Size = New System.Drawing.Size(100, 15)
        Me.LabelFullVersion.TabIndex = 23
        Me.LabelFullVersion.Text = "Full Version:        "
        '
        'LabelFrameworkServicePack
        '
        Me.LabelFrameworkServicePack.BackColor = System.Drawing.Color.Transparent
        Me.LabelFrameworkServicePack.Location = New System.Drawing.Point(80, 400)
        Me.LabelFrameworkServicePack.Name = "LabelFrameworkServicePack"
        Me.LabelFrameworkServicePack.Size = New System.Drawing.Size(100, 15)
        Me.LabelFrameworkServicePack.TabIndex = 29
        Me.LabelFrameworkServicePack.Text = "Service Pack:"
        '
        'LabelCLRVersion
        '
        Me.LabelCLRVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelCLRVersion.Location = New System.Drawing.Point(80, 380)
        Me.LabelCLRVersion.Name = "LabelCLRVersion"
        Me.LabelCLRVersion.Size = New System.Drawing.Size(100, 15)
        Me.LabelCLRVersion.TabIndex = 27
        Me.LabelCLRVersion.Text = "CLR Version:    "
        '
        'LabelFrameworkVersion
        '
        Me.LabelFrameworkVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelFrameworkVersion.Location = New System.Drawing.Point(80, 360)
        Me.LabelFrameworkVersion.Name = "LabelFrameworkVersion"
        Me.LabelFrameworkVersion.Size = New System.Drawing.Size(100, 15)
        Me.LabelFrameworkVersion.TabIndex = 26
        Me.LabelFrameworkVersion.Text = "Version:     "
        '
        'LabelFramework
        '
        Me.LabelFramework.AutoSize = True
        Me.LabelFramework.BackColor = System.Drawing.Color.Transparent
        Me.LabelFramework.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFramework.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelFramework.Location = New System.Drawing.Point(80, 330)
        Me.LabelFramework.Name = "LabelFramework"
        Me.LabelFramework.Size = New System.Drawing.Size(187, 17)
        Me.LabelFramework.TabIndex = 25
        Me.LabelFramework.Text = ".NET Framework Information"
        '
        'LabelSeperatorBottom
        '
        Me.LabelSeperatorBottom.BackColor = System.Drawing.Color.Black
        Me.LabelSeperatorBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeperatorBottom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeperatorBottom.Location = New System.Drawing.Point(80, 350)
        Me.LabelSeperatorBottom.Name = "LabelSeperatorBottom"
        Me.LabelSeperatorBottom.Size = New System.Drawing.Size(420, 3)
        Me.LabelSeperatorBottom.TabIndex = 24
        '
        'LabelProductKey
        '
        Me.LabelProductKey.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductKey.Location = New System.Drawing.Point(80, 304)
        Me.LabelProductKey.Name = "LabelProductKey"
        Me.LabelProductKey.Size = New System.Drawing.Size(100, 16)
        Me.LabelProductKey.TabIndex = 30
        Me.LabelProductKey.Text = "Product Key:"
        '
        'LabelProductID
        '
        Me.LabelProductID.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductID.Location = New System.Drawing.Point(80, 284)
        Me.LabelProductID.Name = "LabelProductID"
        Me.LabelProductID.Size = New System.Drawing.Size(100, 15)
        Me.LabelProductID.TabIndex = 31
        Me.LabelProductID.Text = "Product ID:"
        '
        'LabelType
        '
        Me.LabelType.BackColor = System.Drawing.Color.Transparent
        Me.LabelType.Location = New System.Drawing.Point(80, 184)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(100, 15)
        Me.LabelType.TabIndex = 32
        Me.LabelType.Text = "Type:        "
        '
        'TextBoxProductID
        '
        Me.TextBoxProductID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxProductID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxProductID.Location = New System.Drawing.Point(184, 284)
        Me.TextBoxProductID.Name = "TextBoxProductID"
        Me.TextBoxProductID.ReadOnly = True
        Me.TextBoxProductID.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxProductID.TabIndex = 33
        '
        'TextBoxProductKey
        '
        Me.TextBoxProductKey.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxProductKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxProductKey.Location = New System.Drawing.Point(184, 304)
        Me.TextBoxProductKey.Name = "TextBoxProductKey"
        Me.TextBoxProductKey.ReadOnly = True
        Me.TextBoxProductKey.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxProductKey.TabIndex = 34
        '
        'LabelInstallDate
        '
        Me.LabelInstallDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelInstallDate.Location = New System.Drawing.Point(80, 264)
        Me.LabelInstallDate.Name = "LabelInstallDate"
        Me.LabelInstallDate.Size = New System.Drawing.Size(100, 15)
        Me.LabelInstallDate.TabIndex = 40
        Me.LabelInstallDate.Text = "Installation Date:"
        '
        'TextBoxFullName
        '
        Me.TextBoxFullName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxFullName.Location = New System.Drawing.Point(184, 103)
        Me.TextBoxFullName.Name = "TextBoxFullName"
        Me.TextBoxFullName.ReadOnly = True
        Me.TextBoxFullName.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxFullName.TabIndex = 41
        '
        'TextBoxVersion
        '
        Me.TextBoxVersion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxVersion.Location = New System.Drawing.Point(184, 124)
        Me.TextBoxVersion.Name = "TextBoxVersion"
        Me.TextBoxVersion.ReadOnly = True
        Me.TextBoxVersion.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxVersion.TabIndex = 42
        '
        'TextBoxFullVersion
        '
        Me.TextBoxFullVersion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxFullVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxFullVersion.Location = New System.Drawing.Point(184, 144)
        Me.TextBoxFullVersion.Name = "TextBoxFullVersion"
        Me.TextBoxFullVersion.ReadOnly = True
        Me.TextBoxFullVersion.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxFullVersion.TabIndex = 43
        '
        'TextBoxType
        '
        Me.TextBoxType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxType.Location = New System.Drawing.Point(184, 184)
        Me.TextBoxType.Name = "TextBoxType"
        Me.TextBoxType.ReadOnly = True
        Me.TextBoxType.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxType.TabIndex = 44
        '
        'TextBoxCodeName
        '
        Me.TextBoxCodeName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxCodeName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCodeName.Location = New System.Drawing.Point(184, 204)
        Me.TextBoxCodeName.Name = "TextBoxCodeName"
        Me.TextBoxCodeName.ReadOnly = True
        Me.TextBoxCodeName.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxCodeName.TabIndex = 45
        '
        'TextBoxMachineName
        '
        Me.TextBoxMachineName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxMachineName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxMachineName.Location = New System.Drawing.Point(184, 224)
        Me.TextBoxMachineName.Name = "TextBoxMachineName"
        Me.TextBoxMachineName.ReadOnly = True
        Me.TextBoxMachineName.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxMachineName.TabIndex = 46
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUserName.Location = New System.Drawing.Point(184, 244)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.ReadOnly = True
        Me.TextBoxUserName.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxUserName.TabIndex = 47
        '
        'TextBoxInstallDate
        '
        Me.TextBoxInstallDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxInstallDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxInstallDate.Location = New System.Drawing.Point(184, 264)
        Me.TextBoxInstallDate.Name = "TextBoxInstallDate"
        Me.TextBoxInstallDate.ReadOnly = True
        Me.TextBoxInstallDate.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxInstallDate.TabIndex = 48
        '
        'TextBoxClrServicePack
        '
        Me.TextBoxClrServicePack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxClrServicePack.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxClrServicePack.Location = New System.Drawing.Point(184, 400)
        Me.TextBoxClrServicePack.Name = "TextBoxClrServicePack"
        Me.TextBoxClrServicePack.ReadOnly = True
        Me.TextBoxClrServicePack.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxClrServicePack.TabIndex = 49
        '
        'TextBoxClrVersion
        '
        Me.TextBoxClrVersion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxClrVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxClrVersion.Location = New System.Drawing.Point(184, 380)
        Me.TextBoxClrVersion.Name = "TextBoxClrVersion"
        Me.TextBoxClrVersion.ReadOnly = True
        Me.TextBoxClrVersion.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxClrVersion.TabIndex = 50
        '
        'TextBoxFrameworkVersion
        '
        Me.TextBoxFrameworkVersion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxFrameworkVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxFrameworkVersion.Location = New System.Drawing.Point(184, 360)
        Me.TextBoxFrameworkVersion.Name = "TextBoxFrameworkVersion"
        Me.TextBoxFrameworkVersion.ReadOnly = True
        Me.TextBoxFrameworkVersion.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxFrameworkVersion.TabIndex = 51
        '
        'TextBoxServicePack
        '
        Me.TextBoxServicePack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxServicePack.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxServicePack.Location = New System.Drawing.Point(184, 164)
        Me.TextBoxServicePack.Name = "TextBoxServicePack"
        Me.TextBoxServicePack.ReadOnly = True
        Me.TextBoxServicePack.Size = New System.Drawing.Size(316, 16)
        Me.TextBoxServicePack.TabIndex = 53
        '
        'LabelServicePack
        '
        Me.LabelServicePack.BackColor = System.Drawing.Color.Transparent
        Me.LabelServicePack.Location = New System.Drawing.Point(80, 164)
        Me.LabelServicePack.Name = "LabelServicePack"
        Me.LabelServicePack.Size = New System.Drawing.Size(100, 15)
        Me.LabelServicePack.TabIndex = 52
        Me.LabelServicePack.Text = "Service Pack:    "
        '
        'OperatingSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.TextBoxServicePack)
        Me.Controls.Add(Me.LabelServicePack)
        Me.Controls.Add(Me.TextBoxFrameworkVersion)
        Me.Controls.Add(Me.TextBoxClrVersion)
        Me.Controls.Add(Me.TextBoxClrServicePack)
        Me.Controls.Add(Me.TextBoxInstallDate)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Controls.Add(Me.TextBoxMachineName)
        Me.Controls.Add(Me.TextBoxCodeName)
        Me.Controls.Add(Me.TextBoxType)
        Me.Controls.Add(Me.TextBoxFullVersion)
        Me.Controls.Add(Me.TextBoxVersion)
        Me.Controls.Add(Me.TextBoxFullName)
        Me.Controls.Add(Me.LabelInstallDate)
        Me.Controls.Add(Me.TextBoxProductKey)
        Me.Controls.Add(Me.TextBoxProductID)
        Me.Controls.Add(Me.LabelType)
        Me.Controls.Add(Me.LabelProductID)
        Me.Controls.Add(Me.LabelProductKey)
        Me.Controls.Add(Me.LabelFrameworkServicePack)
        Me.Controls.Add(Me.LabelCLRVersion)
        Me.Controls.Add(Me.LabelFrameworkVersion)
        Me.Controls.Add(Me.LabelFramework)
        Me.Controls.Add(Me.LabelSeperatorBottom)
        Me.Controls.Add(Me.LabelFullVersion)
        Me.Controls.Add(Me.LabelUserName)
        Me.Controls.Add(Me.LabelMachineName)
        Me.Controls.Add(Me.LabelCodeName)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.LabelFullName)
        Me.Controls.Add(Me.LabelWindows)
        Me.Controls.Add(Me.LabelSeparatorTop)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "OperatingSystem"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents LabelCodeName As System.Windows.Forms.Label
    Private WithEvents LabelVersion As System.Windows.Forms.Label
    Private WithEvents LabelFullName As System.Windows.Forms.Label
    Private WithEvents LabelWindows As System.Windows.Forms.Label
    Private WithEvents LabelSeparatorTop As System.Windows.Forms.Label
    Private WithEvents LabelMachineName As System.Windows.Forms.Label
    Private WithEvents LabelUserName As System.Windows.Forms.Label
    Private WithEvents LabelFullVersion As System.Windows.Forms.Label
    Private WithEvents LabelFrameworkServicePack As System.Windows.Forms.Label
    Private WithEvents LabelCLRVersion As System.Windows.Forms.Label
    Private WithEvents LabelFrameworkVersion As System.Windows.Forms.Label
    Private WithEvents LabelFramework As System.Windows.Forms.Label
    Private WithEvents LabelSeperatorBottom As System.Windows.Forms.Label
    Private WithEvents LabelProductKey As System.Windows.Forms.Label
    Private WithEvents LabelProductID As System.Windows.Forms.Label
    Private WithEvents LabelType As System.Windows.Forms.Label
    Friend WithEvents TextBoxProductID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProductKey As System.Windows.Forms.TextBox
    Private WithEvents LabelInstallDate As System.Windows.Forms.Label
    Friend WithEvents TextBoxFullName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxVersion As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFullVersion As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxType As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCodeName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMachineName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUserName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInstallDate As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxClrServicePack As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxClrVersion As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFrameworkVersion As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxServicePack As System.Windows.Forms.TextBox
    Private WithEvents LabelServicePack As System.Windows.Forms.Label

End Class
