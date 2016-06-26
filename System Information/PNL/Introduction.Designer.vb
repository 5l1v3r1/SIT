<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Introduction
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
        Me.LabelDirections = New System.Windows.Forms.Label
        Me.LabelSeparator = New System.Windows.Forms.Label
        Me.LabelAbout = New System.Windows.Forms.Label
        Me.LabelAppVersion = New System.Windows.Forms.Label
        Me.LabelAppDescription = New System.Windows.Forms.Label
        Me.LabelAppCopyright = New System.Windows.Forms.Label
        Me.LabelLicenseTerms = New System.Windows.Forms.Label
        Me.LinkLabelEULA = New System.Windows.Forms.LinkLabel
        Me.LabelCustomerName = New System.Windows.Forms.Label
        Me.LabelCustomerOrganization = New System.Windows.Forms.Label
        Me.LabelTitleCompany = New System.Windows.Forms.Label
        Me.LabelWindows = New System.Windows.Forms.Label
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
        Me.LabelTitle.Size = New System.Drawing.Size(188, 25)
        Me.LabelTitle.TabIndex = 3
        Me.LabelTitle.Text = "System Information"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.System_Information_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 2
        Me.PictureBoxPanel.TabStop = False
        '
        'LabelDirections
        '
        Me.LabelDirections.AutoSize = True
        Me.LabelDirections.BackColor = System.Drawing.Color.Transparent
        Me.LabelDirections.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDirections.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelDirections.Location = New System.Drawing.Point(80, 80)
        Me.LabelDirections.Name = "LabelDirections"
        Me.LabelDirections.Size = New System.Drawing.Size(344, 17)
        Me.LabelDirections.TabIndex = 4
        Me.LabelDirections.Text = "Click a icon at the left for specific system information."
        '
        'LabelSeparator
        '
        Me.LabelSeparator.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator.Location = New System.Drawing.Point(80, 156)
        Me.LabelSeparator.Name = "LabelSeparator"
        Me.LabelSeparator.Size = New System.Drawing.Size(420, 3)
        Me.LabelSeparator.TabIndex = 5
        '
        'LabelAbout
        '
        Me.LabelAbout.AutoSize = True
        Me.LabelAbout.BackColor = System.Drawing.Color.Transparent
        Me.LabelAbout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAbout.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelAbout.Location = New System.Drawing.Point(80, 132)
        Me.LabelAbout.Name = "LabelAbout"
        Me.LabelAbout.Size = New System.Drawing.Size(172, 17)
        Me.LabelAbout.TabIndex = 6
        Me.LabelAbout.Text = "About System Information"
        '
        'LabelAppVersion
        '
        Me.LabelAppVersion.AutoSize = True
        Me.LabelAppVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelAppVersion.Location = New System.Drawing.Point(80, 172)
        Me.LabelAppVersion.Name = "LabelAppVersion"
        Me.LabelAppVersion.Size = New System.Drawing.Size(110, 15)
        Me.LabelAppVersion.TabIndex = 7
        Me.LabelAppVersion.Text = "Application Version"
        '
        'LabelAppDescription
        '
        Me.LabelAppDescription.AutoSize = True
        Me.LabelAppDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelAppDescription.Location = New System.Drawing.Point(80, 192)
        Me.LabelAppDescription.Name = "LabelAppDescription"
        Me.LabelAppDescription.Size = New System.Drawing.Size(131, 15)
        Me.LabelAppDescription.TabIndex = 8
        Me.LabelAppDescription.Text = "Application Description"
        '
        'LabelAppCopyright
        '
        Me.LabelAppCopyright.AutoSize = True
        Me.LabelAppCopyright.BackColor = System.Drawing.Color.Transparent
        Me.LabelAppCopyright.Location = New System.Drawing.Point(80, 212)
        Me.LabelAppCopyright.Name = "LabelAppCopyright"
        Me.LabelAppCopyright.Size = New System.Drawing.Size(124, 15)
        Me.LabelAppCopyright.TabIndex = 9
        Me.LabelAppCopyright.Text = "Application Copyright"
        '
        'LabelLicenseTerms
        '
        Me.LabelLicenseTerms.AutoSize = True
        Me.LabelLicenseTerms.BackColor = System.Drawing.Color.Transparent
        Me.LabelLicenseTerms.Location = New System.Drawing.Point(80, 240)
        Me.LabelLicenseTerms.Name = "LabelLicenseTerms"
        Me.LabelLicenseTerms.Size = New System.Drawing.Size(255, 15)
        Me.LabelLicenseTerms.TabIndex = 10
        Me.LabelLicenseTerms.Text = "This product is licensed under the terms of the "
        '
        'LinkLabelEULA
        '
        Me.LinkLabelEULA.AutoSize = True
        Me.LinkLabelEULA.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelEULA.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabelEULA.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabelEULA.Location = New System.Drawing.Point(80, 260)
        Me.LinkLabelEULA.Name = "LinkLabelEULA"
        Me.LinkLabelEULA.Size = New System.Drawing.Size(213, 15)
        Me.LinkLabelEULA.TabIndex = 11
        Me.LinkLabelEULA.TabStop = True
        Me.LinkLabelEULA.Text = "End User License Agreement (EULA) to:"
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.LabelCustomerName.Location = New System.Drawing.Point(80, 284)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.Size = New System.Drawing.Size(94, 15)
        Me.LabelCustomerName.TabIndex = 12
        Me.LabelCustomerName.Text = "Customer Name"
        '
        'LabelCustomerOrganization
        '
        Me.LabelCustomerOrganization.AutoSize = True
        Me.LabelCustomerOrganization.BackColor = System.Drawing.Color.Transparent
        Me.LabelCustomerOrganization.Location = New System.Drawing.Point(80, 304)
        Me.LabelCustomerOrganization.Name = "LabelCustomerOrganization"
        Me.LabelCustomerOrganization.Size = New System.Drawing.Size(130, 15)
        Me.LabelCustomerOrganization.TabIndex = 13
        Me.LabelCustomerOrganization.Text = "Customer Organization"
        '
        'LabelTitleCompany
        '
        Me.LabelTitleCompany.AutoSize = True
        Me.LabelTitleCompany.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitleCompany.Location = New System.Drawing.Point(80, 332)
        Me.LabelTitleCompany.Name = "LabelTitleCompany"
        Me.LabelTitleCompany.Size = New System.Drawing.Size(263, 15)
        Me.LabelTitleCompany.TabIndex = 14
        Me.LabelTitleCompany.Text = "Application Title is a product of Company Name"
        '
        'LabelWindows
        '
        Me.LabelWindows.AutoSize = True
        Me.LabelWindows.BackColor = System.Drawing.Color.Transparent
        Me.LabelWindows.Location = New System.Drawing.Point(80, 360)
        Me.LabelWindows.Name = "LabelWindows"
        Me.LabelWindows.Size = New System.Drawing.Size(334, 15)
        Me.LabelWindows.TabIndex = 16
        Me.LabelWindows.Text = "Windows® is a registered trademark of Microsoft Corporation"
        '
        'Introduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.LabelWindows)
        Me.Controls.Add(Me.LabelTitleCompany)
        Me.Controls.Add(Me.LabelCustomerOrganization)
        Me.Controls.Add(Me.LabelCustomerName)
        Me.Controls.Add(Me.LinkLabelEULA)
        Me.Controls.Add(Me.LabelLicenseTerms)
        Me.Controls.Add(Me.LabelAppCopyright)
        Me.Controls.Add(Me.LabelAppDescription)
        Me.Controls.Add(Me.LabelAppVersion)
        Me.Controls.Add(Me.LabelAbout)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelDirections)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "Introduction"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents LabelDirections As System.Windows.Forms.Label
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents LabelAbout As System.Windows.Forms.Label
    Private WithEvents LabelAppVersion As System.Windows.Forms.Label
    Private WithEvents LabelAppDescription As System.Windows.Forms.Label
    Private WithEvents LabelAppCopyright As System.Windows.Forms.Label
    Private WithEvents LabelLicenseTerms As System.Windows.Forms.Label
    Private WithEvents LinkLabelEULA As System.Windows.Forms.LinkLabel
    Private WithEvents LabelCustomerName As System.Windows.Forms.Label
    Private WithEvents LabelCustomerOrganization As System.Windows.Forms.Label
    Private WithEvents LabelTitleCompany As System.Windows.Forms.Label
    Private WithEvents LabelWindows As System.Windows.Forms.Label

End Class
