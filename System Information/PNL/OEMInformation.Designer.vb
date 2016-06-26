<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OemInformation
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
        Me.LabelSeparator = New System.Windows.Forms.Label
        Me.LabelOEMInformation = New System.Windows.Forms.Label
        Me.LabelManufactuer = New System.Windows.Forms.Label
        Me.LabelModel = New System.Windows.Forms.Label
        Me.TextBoxManufacturer = New System.Windows.Forms.TextBox
        Me.TextBoxModel = New System.Windows.Forms.TextBox
        Me.ButtonClearOEMInfo = New System.Windows.Forms.Button
        Me.ButtonSaveOEMInfo = New System.Windows.Forms.Button
        Me.TextBoxSupportPhone = New System.Windows.Forms.TextBox
        Me.TextBoxSupportHours = New System.Windows.Forms.TextBox
        Me.LabelSupportPhone = New System.Windows.Forms.Label
        Me.LabelSupportHours = New System.Windows.Forms.Label
        Me.TextBoxSupportWebsite = New System.Windows.Forms.TextBox
        Me.LabelSupportWebsite = New System.Windows.Forms.Label
        Me.LabelWebsiteLink = New System.Windows.Forms.Label
        Me.LinkLabelOEMWebsite = New System.Windows.Forms.LinkLabel
        Me.ButtonRemoveLogo = New System.Windows.Forms.Button
        Me.ButtonAddLogo = New System.Windows.Forms.Button
        Me.LabelLogo = New System.Windows.Forms.Label
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox
        Me.LabelLogoNote = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelTitle.Size = New System.Drawing.Size(167, 25)
        Me.LabelTitle.TabIndex = 20
        Me.LabelTitle.Text = "OEM Information"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.OEM_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 6
        Me.PictureBoxPanel.TabStop = False
        '
        'LabelSeparator
        '
        Me.LabelSeparator.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator.Location = New System.Drawing.Point(16, 100)
        Me.LabelSeparator.Name = "LabelSeparator"
        Me.LabelSeparator.Size = New System.Drawing.Size(482, 3)
        Me.LabelSeparator.TabIndex = 18
        '
        'LabelOEMInformation
        '
        Me.LabelOEMInformation.AutoSize = True
        Me.LabelOEMInformation.BackColor = System.Drawing.Color.Transparent
        Me.LabelOEMInformation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOEMInformation.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelOEMInformation.Location = New System.Drawing.Point(16, 79)
        Me.LabelOEMInformation.Name = "LabelOEMInformation"
        Me.LabelOEMInformation.Size = New System.Drawing.Size(115, 17)
        Me.LabelOEMInformation.TabIndex = 19
        Me.LabelOEMInformation.Text = "OEM Information"
        '
        'LabelManufactuer
        '
        Me.LabelManufactuer.AutoSize = True
        Me.LabelManufactuer.BackColor = System.Drawing.Color.Transparent
        Me.LabelManufactuer.Location = New System.Drawing.Point(14, 122)
        Me.LabelManufactuer.Name = "LabelManufactuer"
        Me.LabelManufactuer.Size = New System.Drawing.Size(82, 15)
        Me.LabelManufactuer.TabIndex = 17
        Me.LabelManufactuer.Text = "Manufacturer:"
        '
        'LabelModel
        '
        Me.LabelModel.AutoSize = True
        Me.LabelModel.BackColor = System.Drawing.Color.Transparent
        Me.LabelModel.Location = New System.Drawing.Point(14, 150)
        Me.LabelModel.Name = "LabelModel"
        Me.LabelModel.Size = New System.Drawing.Size(44, 15)
        Me.LabelModel.TabIndex = 16
        Me.LabelModel.Text = "Model:"
        '
        'TextBoxManufacturer
        '
        Me.TextBoxManufacturer.Location = New System.Drawing.Point(154, 118)
        Me.TextBoxManufacturer.Name = "TextBoxManufacturer"
        Me.TextBoxManufacturer.Size = New System.Drawing.Size(344, 23)
        Me.TextBoxManufacturer.TabIndex = 0
        '
        'TextBoxModel
        '
        Me.TextBoxModel.AcceptsReturn = True
        Me.TextBoxModel.Location = New System.Drawing.Point(154, 146)
        Me.TextBoxModel.Name = "TextBoxModel"
        Me.TextBoxModel.Size = New System.Drawing.Size(344, 23)
        Me.TextBoxModel.TabIndex = 1
        '
        'ButtonClearOEMInfo
        '
        Me.ButtonClearOEMInfo.Enabled = False
        Me.ButtonClearOEMInfo.Location = New System.Drawing.Point(426, 286)
        Me.ButtonClearOEMInfo.Name = "ButtonClearOEMInfo"
        Me.ButtonClearOEMInfo.Size = New System.Drawing.Size(72, 23)
        Me.ButtonClearOEMInfo.TabIndex = 7
        Me.ButtonClearOEMInfo.Text = "Clear"
        Me.ButtonClearOEMInfo.UseVisualStyleBackColor = True
        '
        'ButtonSaveOEMInfo
        '
        Me.ButtonSaveOEMInfo.Enabled = False
        Me.ButtonSaveOEMInfo.Location = New System.Drawing.Point(348, 286)
        Me.ButtonSaveOEMInfo.Name = "ButtonSaveOEMInfo"
        Me.ButtonSaveOEMInfo.Size = New System.Drawing.Size(72, 23)
        Me.ButtonSaveOEMInfo.TabIndex = 6
        Me.ButtonSaveOEMInfo.Text = "Save"
        Me.ButtonSaveOEMInfo.UseVisualStyleBackColor = True
        '
        'TextBoxSupportPhone
        '
        Me.TextBoxSupportPhone.AcceptsReturn = True
        Me.TextBoxSupportPhone.Location = New System.Drawing.Point(154, 202)
        Me.TextBoxSupportPhone.Name = "TextBoxSupportPhone"
        Me.TextBoxSupportPhone.Size = New System.Drawing.Size(344, 23)
        Me.TextBoxSupportPhone.TabIndex = 3
        '
        'TextBoxSupportHours
        '
        Me.TextBoxSupportHours.Location = New System.Drawing.Point(154, 174)
        Me.TextBoxSupportHours.Name = "TextBoxSupportHours"
        Me.TextBoxSupportHours.Size = New System.Drawing.Size(344, 23)
        Me.TextBoxSupportHours.TabIndex = 2
        '
        'LabelSupportPhone
        '
        Me.LabelSupportPhone.AutoSize = True
        Me.LabelSupportPhone.BackColor = System.Drawing.Color.Transparent
        Me.LabelSupportPhone.Location = New System.Drawing.Point(14, 206)
        Me.LabelSupportPhone.Name = "LabelSupportPhone"
        Me.LabelSupportPhone.Size = New System.Drawing.Size(89, 15)
        Me.LabelSupportPhone.TabIndex = 14
        Me.LabelSupportPhone.Text = "Support Phone:"
        '
        'LabelSupportHours
        '
        Me.LabelSupportHours.AutoSize = True
        Me.LabelSupportHours.BackColor = System.Drawing.Color.Transparent
        Me.LabelSupportHours.Location = New System.Drawing.Point(14, 178)
        Me.LabelSupportHours.Name = "LabelSupportHours"
        Me.LabelSupportHours.Size = New System.Drawing.Size(87, 15)
        Me.LabelSupportHours.TabIndex = 15
        Me.LabelSupportHours.Text = "Support Hours:"
        '
        'TextBoxSupportWebsite
        '
        Me.TextBoxSupportWebsite.AcceptsReturn = True
        Me.TextBoxSupportWebsite.Location = New System.Drawing.Point(154, 230)
        Me.TextBoxSupportWebsite.Name = "TextBoxSupportWebsite"
        Me.TextBoxSupportWebsite.Size = New System.Drawing.Size(344, 23)
        Me.TextBoxSupportWebsite.TabIndex = 4
        '
        'LabelSupportWebsite
        '
        Me.LabelSupportWebsite.AutoSize = True
        Me.LabelSupportWebsite.BackColor = System.Drawing.Color.Transparent
        Me.LabelSupportWebsite.Location = New System.Drawing.Point(14, 234)
        Me.LabelSupportWebsite.Name = "LabelSupportWebsite"
        Me.LabelSupportWebsite.Size = New System.Drawing.Size(97, 15)
        Me.LabelSupportWebsite.TabIndex = 13
        Me.LabelSupportWebsite.Text = "Support Website:"
        '
        'LabelWebsiteLink
        '
        Me.LabelWebsiteLink.AutoSize = True
        Me.LabelWebsiteLink.BackColor = System.Drawing.Color.Transparent
        Me.LabelWebsiteLink.Location = New System.Drawing.Point(13, 262)
        Me.LabelWebsiteLink.Name = "LabelWebsiteLink"
        Me.LabelWebsiteLink.Size = New System.Drawing.Size(130, 15)
        Me.LabelWebsiteLink.TabIndex = 12
        Me.LabelWebsiteLink.Text = "Support Website (Link):"
        '
        'LinkLabelOEMWebsite
        '
        Me.LinkLabelOEMWebsite.AutoEllipsis = True
        Me.LinkLabelOEMWebsite.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelOEMWebsite.Location = New System.Drawing.Point(151, 262)
        Me.LinkLabelOEMWebsite.Name = "LinkLabelOEMWebsite"
        Me.LinkLabelOEMWebsite.Size = New System.Drawing.Size(347, 15)
        Me.LinkLabelOEMWebsite.TabIndex = 5
        '
        'ButtonRemoveLogo
        '
        Me.ButtonRemoveLogo.Enabled = False
        Me.ButtonRemoveLogo.Location = New System.Drawing.Point(364, 387)
        Me.ButtonRemoveLogo.Name = "ButtonRemoveLogo"
        Me.ButtonRemoveLogo.Size = New System.Drawing.Size(72, 23)
        Me.ButtonRemoveLogo.TabIndex = 9
        Me.ButtonRemoveLogo.Text = "Remove"
        Me.ButtonRemoveLogo.UseVisualStyleBackColor = True
        '
        'ButtonAddLogo
        '
        Me.ButtonAddLogo.Enabled = False
        Me.ButtonAddLogo.Location = New System.Drawing.Point(286, 387)
        Me.ButtonAddLogo.Name = "ButtonAddLogo"
        Me.ButtonAddLogo.Size = New System.Drawing.Size(72, 23)
        Me.ButtonAddLogo.TabIndex = 8
        Me.ButtonAddLogo.Text = "Add"
        Me.ButtonAddLogo.UseVisualStyleBackColor = True
        '
        'LabelLogo
        '
        Me.LabelLogo.AutoSize = True
        Me.LabelLogo.BackColor = System.Drawing.Color.Transparent
        Me.LabelLogo.Location = New System.Drawing.Point(108, 290)
        Me.LabelLogo.Name = "LabelLogo"
        Me.LabelLogo.Size = New System.Drawing.Size(37, 15)
        Me.LabelLogo.TabIndex = 11
        Me.LabelLogo.Text = "Logo:"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxLogo.Location = New System.Drawing.Point(151, 290)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(120, 120)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 55
        Me.PictureBoxLogo.TabStop = False
        '
        'LabelLogoNote
        '
        Me.LabelLogoNote.BackColor = System.Drawing.Color.Transparent
        Me.LabelLogoNote.Location = New System.Drawing.Point(283, 330)
        Me.LabelLogoNote.Name = "LabelLogoNote"
        Me.LabelLogoNote.Size = New System.Drawing.Size(215, 43)
        Me.LabelLogoNote.TabIndex = 10
        Me.LabelLogoNote.Text = "Note: Logo is a 120 X 120 pixel bitmap (*.bmp"")."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OEMInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.LabelLogoNote)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.LabelLogo)
        Me.Controls.Add(Me.ButtonRemoveLogo)
        Me.Controls.Add(Me.ButtonAddLogo)
        Me.Controls.Add(Me.LinkLabelOEMWebsite)
        Me.Controls.Add(Me.LabelWebsiteLink)
        Me.Controls.Add(Me.TextBoxSupportWebsite)
        Me.Controls.Add(Me.LabelSupportWebsite)
        Me.Controls.Add(Me.ButtonClearOEMInfo)
        Me.Controls.Add(Me.ButtonSaveOEMInfo)
        Me.Controls.Add(Me.TextBoxSupportPhone)
        Me.Controls.Add(Me.TextBoxSupportHours)
        Me.Controls.Add(Me.LabelSupportPhone)
        Me.Controls.Add(Me.LabelSupportHours)
        Me.Controls.Add(Me.TextBoxModel)
        Me.Controls.Add(Me.TextBoxManufacturer)
        Me.Controls.Add(Me.LabelModel)
        Me.Controls.Add(Me.LabelManufactuer)
        Me.Controls.Add(Me.LabelOEMInformation)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "OEMInformation"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents LabelOEMInformation As System.Windows.Forms.Label
    Private WithEvents LabelManufactuer As System.Windows.Forms.Label
    Private WithEvents LabelModel As System.Windows.Forms.Label
    Private WithEvents TextBoxManufacturer As System.Windows.Forms.TextBox
    Private WithEvents TextBoxModel As System.Windows.Forms.TextBox
    Private WithEvents ButtonClearOEMInfo As System.Windows.Forms.Button
    Private WithEvents ButtonSaveOEMInfo As System.Windows.Forms.Button
    Private WithEvents TextBoxSupportPhone As System.Windows.Forms.TextBox
    Private WithEvents TextBoxSupportHours As System.Windows.Forms.TextBox
    Private WithEvents LabelSupportPhone As System.Windows.Forms.Label
    Private WithEvents LabelSupportHours As System.Windows.Forms.Label
    Private WithEvents TextBoxSupportWebsite As System.Windows.Forms.TextBox
    Private WithEvents LabelSupportWebsite As System.Windows.Forms.Label
    Private WithEvents LabelWebsiteLink As System.Windows.Forms.Label
    Friend WithEvents LinkLabelOEMWebsite As System.Windows.Forms.LinkLabel
    Private WithEvents ButtonRemoveLogo As System.Windows.Forms.Button
    Private WithEvents ButtonAddLogo As System.Windows.Forms.Button
    Private WithEvents LabelLogo As System.Windows.Forms.Label
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Private WithEvents LabelLogoNote As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
