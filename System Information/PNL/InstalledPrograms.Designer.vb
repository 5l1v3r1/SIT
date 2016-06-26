<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InstalledPrograms
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
        Me.ListViewPrograms = New System.Windows.Forms.ListView
        Me.DisplayName = New System.Windows.Forms.ColumnHeader
        Me.Publisher = New System.Windows.Forms.ColumnHeader
        Me.DisplayVersion = New System.Windows.Forms.ColumnHeader
        Me.HelpLink = New System.Windows.Forms.ColumnHeader
        Me.HelpTelephone = New System.Windows.Forms.ColumnHeader
        Me.InstallDate = New System.Windows.Forms.ColumnHeader
        Me.EstimatedSize = New System.Windows.Forms.ColumnHeader
        Me.IconIndex = New System.Windows.Forms.ColumnHeader
        Me.SmallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelInstalledProgramsDescription = New System.Windows.Forms.Label
        Me.LabelSeparator = New System.Windows.Forms.Label
        Me.LabelDetails = New System.Windows.Forms.Label
        Me.LabelSeparator2 = New System.Windows.Forms.Label
        Me.LabelHelpTelephoneDesc = New System.Windows.Forms.Label
        Me.LabelHelpLinkDesc = New System.Windows.Forms.Label
        Me.LabelInstallDateDesc = New System.Windows.Forms.Label
        Me.LabelHelpTelephone = New System.Windows.Forms.Label
        Me.LabelInstallDate = New System.Windows.Forms.Label
        Me.LabelEstSizeDesc = New System.Windows.Forms.Label
        Me.LabelEstimatedSize = New System.Windows.Forms.Label
        Me.labelNumberPrograms = New System.Windows.Forms.Label
        Me.PictureBoxProgram = New System.Windows.Forms.PictureBox
        Me.LabelDisplayVersion = New System.Windows.Forms.Label
        Me.LabelDisplayVersionDesc = New System.Windows.Forms.Label
        Me.LabelDisplayName = New System.Windows.Forms.Label
        Me.LargeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.LinkLabelHelpLink = New System.Windows.Forms.LinkLabel
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProgram, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelTitle.Size = New System.Drawing.Size(179, 25)
        Me.LabelTitle.TabIndex = 7
        Me.LabelTitle.Text = "Installed Programs"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.Installed_Programs_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 6
        Me.PictureBoxPanel.TabStop = False
        '
        'ListViewPrograms
        '
        Me.ListViewPrograms.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewPrograms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DisplayName, Me.Publisher, Me.DisplayVersion, Me.HelpLink, Me.HelpTelephone, Me.InstallDate, Me.EstimatedSize, Me.IconIndex})
        Me.ListViewPrograms.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewPrograms.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListViewPrograms.FullRowSelect = True
        Me.ListViewPrograms.LabelWrap = False
        Me.ListViewPrograms.Location = New System.Drawing.Point(16, 108)
        Me.ListViewPrograms.MultiSelect = False
        Me.ListViewPrograms.Name = "ListViewPrograms"
        Me.ListViewPrograms.Size = New System.Drawing.Size(482, 191)
        Me.ListViewPrograms.SmallImageList = Me.SmallImageList
        Me.ListViewPrograms.TabIndex = 51
        Me.ListViewPrograms.UseCompatibleStateImageBehavior = False
        Me.ListViewPrograms.View = System.Windows.Forms.View.Details
        '
        'DisplayName
        '
        Me.DisplayName.Text = "Name"
        Me.DisplayName.Width = 280
        '
        'Publisher
        '
        Me.Publisher.Text = "Publisher"
        Me.Publisher.Width = 177
        '
        'DisplayVersion
        '
        Me.DisplayVersion.Text = "Version"
        Me.DisplayVersion.Width = 0
        '
        'HelpLink
        '
        Me.HelpLink.Text = "HelpLink"
        Me.HelpLink.Width = 0
        '
        'HelpTelephone
        '
        Me.HelpTelephone.Text = "HelpTelephone"
        Me.HelpTelephone.Width = 0
        '
        'InstallDate
        '
        Me.InstallDate.Text = "InstallDate"
        Me.InstallDate.Width = 0
        '
        'EstimatedSize
        '
        Me.EstimatedSize.Text = "EstimatedSize"
        Me.EstimatedSize.Width = 0
        '
        'IconIndex
        '
        Me.IconIndex.Text = "IconNumber"
        Me.IconIndex.Width = 0
        '
        'SmallImageList
        '
        Me.SmallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.SmallImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.SmallImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'LabelInstalledProgramsDescription
        '
        Me.LabelInstalledProgramsDescription.AutoSize = True
        Me.LabelInstalledProgramsDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelInstalledProgramsDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInstalledProgramsDescription.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelInstalledProgramsDescription.Location = New System.Drawing.Point(16, 76)
        Me.LabelInstalledProgramsDescription.Name = "LabelInstalledProgramsDescription"
        Me.LabelInstalledProgramsDescription.Size = New System.Drawing.Size(377, 17)
        Me.LabelInstalledProgramsDescription.TabIndex = 50
        Me.LabelInstalledProgramsDescription.Text = "Applications and other software installed on this computer."
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
        Me.LabelDetails.Location = New System.Drawing.Point(16, 307)
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
        Me.LabelSeparator2.Location = New System.Drawing.Point(16, 328)
        Me.LabelSeparator2.Name = "LabelSeparator2"
        Me.LabelSeparator2.Size = New System.Drawing.Size(482, 3)
        Me.LabelSeparator2.TabIndex = 52
        '
        'LabelHelpTelephoneDesc
        '
        Me.LabelHelpTelephoneDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelHelpTelephoneDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelHelpTelephoneDesc.Location = New System.Drawing.Point(76, 399)
        Me.LabelHelpTelephoneDesc.Name = "LabelHelpTelephoneDesc"
        Me.LabelHelpTelephoneDesc.Size = New System.Drawing.Size(76, 15)
        Me.LabelHelpTelephoneDesc.TabIndex = 61
        Me.LabelHelpTelephoneDesc.Text = "Help Phone:"
        Me.LabelHelpTelephoneDesc.Visible = False
        '
        'LabelHelpLinkDesc
        '
        Me.LabelHelpLinkDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelHelpLinkDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelHelpLinkDesc.Location = New System.Drawing.Point(76, 379)
        Me.LabelHelpLinkDesc.Name = "LabelHelpLinkDesc"
        Me.LabelHelpLinkDesc.Size = New System.Drawing.Size(76, 15)
        Me.LabelHelpLinkDesc.TabIndex = 60
        Me.LabelHelpLinkDesc.Text = "Help Link:"
        Me.LabelHelpLinkDesc.Visible = False
        '
        'LabelInstallDateDesc
        '
        Me.LabelInstallDateDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelInstallDateDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelInstallDateDesc.Location = New System.Drawing.Point(76, 359)
        Me.LabelInstallDateDesc.Name = "LabelInstallDateDesc"
        Me.LabelInstallDateDesc.Size = New System.Drawing.Size(76, 15)
        Me.LabelInstallDateDesc.TabIndex = 59
        Me.LabelInstallDateDesc.Text = "Install Date:"
        Me.LabelInstallDateDesc.Visible = False
        '
        'LabelHelpTelephone
        '
        Me.LabelHelpTelephone.BackColor = System.Drawing.Color.Transparent
        Me.LabelHelpTelephone.ForeColor = System.Drawing.Color.Black
        Me.LabelHelpTelephone.Location = New System.Drawing.Point(156, 399)
        Me.LabelHelpTelephone.Name = "LabelHelpTelephone"
        Me.LabelHelpTelephone.Size = New System.Drawing.Size(343, 15)
        Me.LabelHelpTelephone.TabIndex = 57
        Me.LabelHelpTelephone.Visible = False
        '
        'LabelInstallDate
        '
        Me.LabelInstallDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelInstallDate.ForeColor = System.Drawing.Color.Black
        Me.LabelInstallDate.Location = New System.Drawing.Point(156, 359)
        Me.LabelInstallDate.Name = "LabelInstallDate"
        Me.LabelInstallDate.Size = New System.Drawing.Size(128, 15)
        Me.LabelInstallDate.TabIndex = 55
        Me.LabelInstallDate.Visible = False
        '
        'LabelEstSizeDesc
        '
        Me.LabelEstSizeDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelEstSizeDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelEstSizeDesc.Location = New System.Drawing.Point(288, 359)
        Me.LabelEstSizeDesc.Name = "LabelEstSizeDesc"
        Me.LabelEstSizeDesc.Size = New System.Drawing.Size(92, 15)
        Me.LabelEstSizeDesc.TabIndex = 76
        Me.LabelEstSizeDesc.Text = "Estimated Size:"
        Me.LabelEstSizeDesc.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LabelEstSizeDesc.Visible = False
        '
        'LabelEstimatedSize
        '
        Me.LabelEstimatedSize.BackColor = System.Drawing.Color.Transparent
        Me.LabelEstimatedSize.ForeColor = System.Drawing.Color.Black
        Me.LabelEstimatedSize.Location = New System.Drawing.Point(384, 359)
        Me.LabelEstimatedSize.Name = "LabelEstimatedSize"
        Me.LabelEstimatedSize.Size = New System.Drawing.Size(115, 15)
        Me.LabelEstimatedSize.TabIndex = 77
        Me.LabelEstimatedSize.Visible = False
        '
        'labelNumberPrograms
        '
        Me.labelNumberPrograms.BackColor = System.Drawing.Color.Transparent
        Me.labelNumberPrograms.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNumberPrograms.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelNumberPrograms.Location = New System.Drawing.Point(394, 307)
        Me.labelNumberPrograms.Name = "labelNumberPrograms"
        Me.labelNumberPrograms.Size = New System.Drawing.Size(104, 17)
        Me.labelNumberPrograms.TabIndex = 78
        Me.labelNumberPrograms.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBoxProgram
        '
        Me.PictureBoxProgram.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxProgram.Location = New System.Drawing.Point(16, 339)
        Me.PictureBoxProgram.Name = "PictureBoxProgram"
        Me.PictureBoxProgram.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxProgram.TabIndex = 79
        Me.PictureBoxProgram.TabStop = False
        '
        'LabelDisplayVersion
        '
        Me.LabelDisplayVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelDisplayVersion.ForeColor = System.Drawing.Color.Black
        Me.LabelDisplayVersion.Location = New System.Drawing.Point(384, 339)
        Me.LabelDisplayVersion.Name = "LabelDisplayVersion"
        Me.LabelDisplayVersion.Size = New System.Drawing.Size(115, 15)
        Me.LabelDisplayVersion.TabIndex = 81
        Me.LabelDisplayVersion.Visible = False
        '
        'LabelDisplayVersionDesc
        '
        Me.LabelDisplayVersionDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelDisplayVersionDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelDisplayVersionDesc.Location = New System.Drawing.Point(328, 339)
        Me.LabelDisplayVersionDesc.Name = "LabelDisplayVersionDesc"
        Me.LabelDisplayVersionDesc.Size = New System.Drawing.Size(52, 15)
        Me.LabelDisplayVersionDesc.TabIndex = 80
        Me.LabelDisplayVersionDesc.Text = "Version:"
        Me.LabelDisplayVersionDesc.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LabelDisplayVersionDesc.Visible = False
        '
        'LabelDisplayName
        '
        Me.LabelDisplayName.BackColor = System.Drawing.Color.Transparent
        Me.LabelDisplayName.ForeColor = System.Drawing.Color.Black
        Me.LabelDisplayName.Location = New System.Drawing.Point(76, 339)
        Me.LabelDisplayName.Name = "LabelDisplayName"
        Me.LabelDisplayName.Size = New System.Drawing.Size(248, 15)
        Me.LabelDisplayName.TabIndex = 82
        '
        'LargeImageList
        '
        Me.LargeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.LargeImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'LinkLabelHelpLink
        '
        Me.LinkLabelHelpLink.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelHelpLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabelHelpLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabelHelpLink.Location = New System.Drawing.Point(156, 379)
        Me.LinkLabelHelpLink.Name = "LinkLabelHelpLink"
        Me.LinkLabelHelpLink.Size = New System.Drawing.Size(343, 15)
        Me.LinkLabelHelpLink.TabIndex = 83
        '
        'InstalledPrograms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.LinkLabelHelpLink)
        Me.Controls.Add(Me.LabelDisplayName)
        Me.Controls.Add(Me.LabelDisplayVersion)
        Me.Controls.Add(Me.LabelDisplayVersionDesc)
        Me.Controls.Add(Me.PictureBoxProgram)
        Me.Controls.Add(Me.labelNumberPrograms)
        Me.Controls.Add(Me.LabelEstimatedSize)
        Me.Controls.Add(Me.LabelEstSizeDesc)
        Me.Controls.Add(Me.LabelHelpTelephoneDesc)
        Me.Controls.Add(Me.LabelHelpLinkDesc)
        Me.Controls.Add(Me.LabelInstallDateDesc)
        Me.Controls.Add(Me.LabelHelpTelephone)
        Me.Controls.Add(Me.LabelInstallDate)
        Me.Controls.Add(Me.LabelDetails)
        Me.Controls.Add(Me.LabelSeparator2)
        Me.Controls.Add(Me.ListViewPrograms)
        Me.Controls.Add(Me.LabelInstalledProgramsDescription)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "InstalledPrograms"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProgram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents ListViewPrograms As System.Windows.Forms.ListView
    Private WithEvents DisplayName As System.Windows.Forms.ColumnHeader
    Private WithEvents LabelInstalledProgramsDescription As System.Windows.Forms.Label
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents LabelDetails As System.Windows.Forms.Label
    Private WithEvents LabelSeparator2 As System.Windows.Forms.Label
    Private WithEvents LabelHelpTelephoneDesc As System.Windows.Forms.Label
    Private WithEvents LabelHelpLinkDesc As System.Windows.Forms.Label
    Private WithEvents LabelInstallDateDesc As System.Windows.Forms.Label
    Private WithEvents LabelHelpTelephone As System.Windows.Forms.Label
    Private WithEvents LabelInstallDate As System.Windows.Forms.Label
    Private WithEvents SmallImageList As System.Windows.Forms.ImageList
    Private WithEvents LabelEstSizeDesc As System.Windows.Forms.Label
    Private WithEvents LabelEstimatedSize As System.Windows.Forms.Label
    Friend WithEvents Publisher As System.Windows.Forms.ColumnHeader
    Friend WithEvents DisplayVersion As System.Windows.Forms.ColumnHeader
    Friend WithEvents HelpLink As System.Windows.Forms.ColumnHeader
    Friend WithEvents HelpTelephone As System.Windows.Forms.ColumnHeader
    Friend WithEvents InstallDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents EstimatedSize As System.Windows.Forms.ColumnHeader
    Private WithEvents labelNumberPrograms As System.Windows.Forms.Label
    Private WithEvents PictureBoxProgram As System.Windows.Forms.PictureBox
    Private WithEvents LabelDisplayVersion As System.Windows.Forms.Label
    Private WithEvents LabelDisplayVersionDesc As System.Windows.Forms.Label
    Private WithEvents LabelDisplayName As System.Windows.Forms.Label
    Private WithEvents LargeImageList As System.Windows.Forms.ImageList
    Friend WithEvents IconIndex As System.Windows.Forms.ColumnHeader
    Friend WithEvents LinkLabelHelpLink As System.Windows.Forms.LinkLabel

End Class
