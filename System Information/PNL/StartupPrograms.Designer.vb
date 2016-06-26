<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class StartupPrograms
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
        Me.LabelTitle = New System.Windows.Forms.Label
        Me.PictureBoxPanel = New System.Windows.Forms.PictureBox
        Me.ListViewStartup = New System.Windows.Forms.ListView
        Me.ItemName = New System.Windows.Forms.ColumnHeader
        Me.FileName = New System.Windows.Forms.ColumnHeader
        Me.Type = New System.Windows.Forms.ColumnHeader
        Me.Status = New System.Windows.Forms.ColumnHeader
        Me.DisplayCommand = New System.Windows.Forms.ColumnHeader
        Me.DisplayFilePath = New System.Windows.Forms.ColumnHeader
        Me.StartupImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelStartupDescription = New System.Windows.Forms.Label
        Me.LabelSeparator = New System.Windows.Forms.Label
        Me.LabelDetails = New System.Windows.Forms.Label
        Me.LabelSeparator2 = New System.Windows.Forms.Label
        Me.LabelCommandDesc = New System.Windows.Forms.Label
        Me.LabelFileVersionDesc = New System.Windows.Forms.Label
        Me.LabelDescriptionDesc = New System.Windows.Forms.Label
        Me.LabelCompanyDesc = New System.Windows.Forms.Label
        Me.LabelCommand = New System.Windows.Forms.Label
        Me.LabelFileVersion = New System.Windows.Forms.Label
        Me.LabelDescription = New System.Windows.Forms.Label
        Me.LabelCompany = New System.Windows.Forms.Label
        Me.LabelProductNameDesc = New System.Windows.Forms.Label
        Me.LabelProductName = New System.Windows.Forms.Label
        Me.LabelArgumentsDesc = New System.Windows.Forms.Label
        Me.LabelArguments = New System.Windows.Forms.Label
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
        Me.LabelTitle.Size = New System.Drawing.Size(171, 25)
        Me.LabelTitle.TabIndex = 7
        Me.LabelTitle.Text = "Startup Programs"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.Startup_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 6
        Me.PictureBoxPanel.TabStop = False
        '
        'ListViewStartup
        '
        Me.ListViewStartup.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewStartup.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItemName, Me.FileName, Me.Type, Me.Status, Me.DisplayCommand, Me.DisplayFilePath})
        Me.ListViewStartup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewStartup.ForeColor = System.Drawing.Color.Black
        Me.ListViewStartup.FullRowSelect = True
        Me.ListViewStartup.LabelWrap = False
        Me.ListViewStartup.Location = New System.Drawing.Point(16, 108)
        Me.ListViewStartup.MultiSelect = False
        Me.ListViewStartup.Name = "ListViewStartup"
        Me.ListViewStartup.Size = New System.Drawing.Size(482, 160)
        Me.ListViewStartup.SmallImageList = Me.StartupImageList
        Me.ListViewStartup.TabIndex = 51
        Me.ListViewStartup.UseCompatibleStateImageBehavior = False
        Me.ListViewStartup.View = System.Windows.Forms.View.Details
        '
        'ItemName
        '
        Me.ItemName.Text = "Item Name"
        Me.ItemName.Width = 160
        '
        'FileName
        '
        Me.FileName.Text = "File Name"
        Me.FileName.Width = 120
        '
        'Type
        '
        Me.Type.Text = "Location"
        Me.Type.Width = 117
        '
        'Status
        '
        Me.Status.Text = "Status"
        '
        'DisplayCommand
        '
        Me.DisplayCommand.Text = ""
        Me.DisplayCommand.Width = 0
        '
        'DisplayFilePath
        '
        Me.DisplayFilePath.Text = ""
        Me.DisplayFilePath.Width = 0
        '
        'StartupImageList
        '
        Me.StartupImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.StartupImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.StartupImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'LabelStartupDescription
        '
        Me.LabelStartupDescription.AutoSize = True
        Me.LabelStartupDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelStartupDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStartupDescription.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelStartupDescription.Location = New System.Drawing.Point(16, 76)
        Me.LabelStartupDescription.Name = "LabelStartupDescription"
        Me.LabelStartupDescription.Size = New System.Drawing.Size(321, 17)
        Me.LabelStartupDescription.TabIndex = 50
        Me.LabelStartupDescription.Text = "Programs that automatically run when you log on."
        '
        'LabelSeparator
        '
        Me.LabelSeparator.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator.Location = New System.Drawing.Point(16, 98)
        Me.LabelSeparator.Name = "LabelSeparator"
        Me.LabelSeparator.Size = New System.Drawing.Size(482, 3)
        Me.LabelSeparator.TabIndex = 49
        '
        'LabelDetails
        '
        Me.LabelDetails.AutoSize = True
        Me.LabelDetails.BackColor = System.Drawing.Color.Transparent
        Me.LabelDetails.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDetails.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelDetails.Location = New System.Drawing.Point(16, 275)
        Me.LabelDetails.Name = "LabelDetails"
        Me.LabelDetails.Size = New System.Drawing.Size(51, 17)
        Me.LabelDetails.TabIndex = 53
        Me.LabelDetails.Text = "Details"
        '
        'LabelSeparator2
        '
        Me.LabelSeparator2.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator2.Location = New System.Drawing.Point(16, 296)
        Me.LabelSeparator2.Name = "LabelSeparator2"
        Me.LabelSeparator2.Size = New System.Drawing.Size(482, 3)
        Me.LabelSeparator2.TabIndex = 52
        '
        'LabelCommandDesc
        '
        Me.LabelCommandDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelCommandDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelCommandDesc.Location = New System.Drawing.Point(16, 384)
        Me.LabelCommandDesc.Name = "LabelCommandDesc"
        Me.LabelCommandDesc.Size = New System.Drawing.Size(82, 15)
        Me.LabelCommandDesc.TabIndex = 61
        Me.LabelCommandDesc.Text = "Command:"
        '
        'LabelFileVersionDesc
        '
        Me.LabelFileVersionDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelFileVersionDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelFileVersionDesc.Location = New System.Drawing.Point(16, 364)
        Me.LabelFileVersionDesc.Name = "LabelFileVersionDesc"
        Me.LabelFileVersionDesc.Size = New System.Drawing.Size(82, 15)
        Me.LabelFileVersionDesc.TabIndex = 60
        Me.LabelFileVersionDesc.Text = "File Version:"
        '
        'LabelDescriptionDesc
        '
        Me.LabelDescriptionDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescriptionDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelDescriptionDesc.Location = New System.Drawing.Point(16, 344)
        Me.LabelDescriptionDesc.Name = "LabelDescriptionDesc"
        Me.LabelDescriptionDesc.Size = New System.Drawing.Size(82, 15)
        Me.LabelDescriptionDesc.TabIndex = 59
        Me.LabelDescriptionDesc.Text = "Description:"
        '
        'LabelCompanyDesc
        '
        Me.LabelCompanyDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelCompanyDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelCompanyDesc.Location = New System.Drawing.Point(16, 304)
        Me.LabelCompanyDesc.Name = "LabelCompanyDesc"
        Me.LabelCompanyDesc.Size = New System.Drawing.Size(82, 15)
        Me.LabelCompanyDesc.TabIndex = 58
        Me.LabelCompanyDesc.Text = "Company:"
        '
        'LabelCommand
        '
        Me.LabelCommand.BackColor = System.Drawing.Color.Transparent
        Me.LabelCommand.ForeColor = System.Drawing.Color.Black
        Me.LabelCommand.Location = New System.Drawing.Point(101, 384)
        Me.LabelCommand.Name = "LabelCommand"
        Me.LabelCommand.Size = New System.Drawing.Size(398, 36)
        Me.LabelCommand.TabIndex = 57
        '
        'LabelFileVersion
        '
        Me.LabelFileVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelFileVersion.ForeColor = System.Drawing.Color.Black
        Me.LabelFileVersion.Location = New System.Drawing.Point(101, 364)
        Me.LabelFileVersion.Name = "LabelFileVersion"
        Me.LabelFileVersion.Size = New System.Drawing.Size(398, 15)
        Me.LabelFileVersion.TabIndex = 56
        '
        'LabelDescription
        '
        Me.LabelDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescription.ForeColor = System.Drawing.Color.Black
        Me.LabelDescription.Location = New System.Drawing.Point(101, 344)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(398, 15)
        Me.LabelDescription.TabIndex = 55
        '
        'LabelCompany
        '
        Me.LabelCompany.BackColor = System.Drawing.Color.Transparent
        Me.LabelCompany.ForeColor = System.Drawing.Color.Black
        Me.LabelCompany.Location = New System.Drawing.Point(101, 304)
        Me.LabelCompany.Name = "LabelCompany"
        Me.LabelCompany.Size = New System.Drawing.Size(398, 15)
        Me.LabelCompany.TabIndex = 54
        '
        'LabelProductNameDesc
        '
        Me.LabelProductNameDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductNameDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelProductNameDesc.Location = New System.Drawing.Point(16, 324)
        Me.LabelProductNameDesc.Name = "LabelProductNameDesc"
        Me.LabelProductNameDesc.Size = New System.Drawing.Size(82, 15)
        Me.LabelProductNameDesc.TabIndex = 75
        Me.LabelProductNameDesc.Text = "Product:"
        '
        'LabelProductName
        '
        Me.LabelProductName.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductName.ForeColor = System.Drawing.Color.Black
        Me.LabelProductName.Location = New System.Drawing.Point(101, 324)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(398, 15)
        Me.LabelProductName.TabIndex = 74
        '
        'LabelArgumentsDesc
        '
        Me.LabelArgumentsDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelArgumentsDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelArgumentsDesc.Location = New System.Drawing.Point(16, 404)
        Me.LabelArgumentsDesc.Name = "LabelArgumentsDesc"
        Me.LabelArgumentsDesc.Size = New System.Drawing.Size(82, 15)
        Me.LabelArgumentsDesc.TabIndex = 76
        Me.LabelArgumentsDesc.Text = "Arguments:"
        Me.LabelArgumentsDesc.Visible = False
        '
        'LabelArguments
        '
        Me.LabelArguments.BackColor = System.Drawing.Color.Transparent
        Me.LabelArguments.ForeColor = System.Drawing.Color.Black
        Me.LabelArguments.Location = New System.Drawing.Point(101, 404)
        Me.LabelArguments.Name = "LabelArguments"
        Me.LabelArguments.Size = New System.Drawing.Size(398, 15)
        Me.LabelArguments.TabIndex = 77
        Me.LabelArguments.Visible = False
        '
        'StartupPrograms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.LabelArguments)
        Me.Controls.Add(Me.LabelArgumentsDesc)
        Me.Controls.Add(Me.LabelProductNameDesc)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.LabelCommandDesc)
        Me.Controls.Add(Me.LabelFileVersionDesc)
        Me.Controls.Add(Me.LabelDescriptionDesc)
        Me.Controls.Add(Me.LabelCompanyDesc)
        Me.Controls.Add(Me.LabelCommand)
        Me.Controls.Add(Me.LabelFileVersion)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelCompany)
        Me.Controls.Add(Me.LabelDetails)
        Me.Controls.Add(Me.LabelSeparator2)
        Me.Controls.Add(Me.ListViewStartup)
        Me.Controls.Add(Me.LabelStartupDescription)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "StartupPrograms"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents ListViewStartup As System.Windows.Forms.ListView
    Private WithEvents ItemName As System.Windows.Forms.ColumnHeader
    Private WithEvents Type As System.Windows.Forms.ColumnHeader
    Private WithEvents LabelStartupDescription As System.Windows.Forms.Label
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents FileName As System.Windows.Forms.ColumnHeader
    Private WithEvents Status As System.Windows.Forms.ColumnHeader
    Private WithEvents LabelDetails As System.Windows.Forms.Label
    Private WithEvents LabelSeparator2 As System.Windows.Forms.Label
    Private WithEvents LabelCommandDesc As System.Windows.Forms.Label
    Private WithEvents LabelFileVersionDesc As System.Windows.Forms.Label
    Private WithEvents LabelDescriptionDesc As System.Windows.Forms.Label
    Private WithEvents LabelCompanyDesc As System.Windows.Forms.Label
    Private WithEvents LabelCommand As System.Windows.Forms.Label
    Private WithEvents LabelFileVersion As System.Windows.Forms.Label
    Private WithEvents LabelDescription As System.Windows.Forms.Label
    Private WithEvents LabelCompany As System.Windows.Forms.Label
    Private WithEvents LabelProductNameDesc As System.Windows.Forms.Label
    Private WithEvents LabelProductName As System.Windows.Forms.Label
    Private WithEvents StartupImageList As System.Windows.Forms.ImageList
    Private WithEvents DisplayCommand As System.Windows.Forms.ColumnHeader
    Private WithEvents DisplayFilePath As System.Windows.Forms.ColumnHeader
    Private WithEvents LabelArgumentsDesc As System.Windows.Forms.Label
    Private WithEvents LabelArguments As System.Windows.Forms.Label

End Class
