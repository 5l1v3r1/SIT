<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class UserInformation
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
        Me.LabelRegistration = New System.Windows.Forms.Label
        Me.LabelRegisteredUser = New System.Windows.Forms.Label
        Me.LabelRegisteredOrganization = New System.Windows.Forms.Label
        Me.TextBoxRegisteredUser = New System.Windows.Forms.TextBox
        Me.TextBoxRegisteredOrganization = New System.Windows.Forms.TextBox
        Me.ButtonSaveRegisteredUser = New System.Windows.Forms.Button
        Me.ButtonSaveRegisteredOrganization = New System.Windows.Forms.Button
        Me.ButtonSaveRegisteredOrganization2 = New System.Windows.Forms.Button
        Me.ButtonSaveRegisteredUser2 = New System.Windows.Forms.Button
        Me.TextBoxRegisteredOrganization2 = New System.Windows.Forms.TextBox
        Me.TextBoxRegisteredUser2 = New System.Windows.Forms.TextBox
        Me.LabelRegisteredOrganization2 = New System.Windows.Forms.Label
        Me.LabelRegisteredUser2 = New System.Windows.Forms.Label
        Me.LabelRegistration2 = New System.Windows.Forms.Label
        Me.LabelSeparator2 = New System.Windows.Forms.Label
        Me.LabelAutoLogon = New System.Windows.Forms.Label
        Me.LabelSeparator3 = New System.Windows.Forms.Label
        Me.TextBoxUserName = New System.Windows.Forms.TextBox
        Me.LabelUserName = New System.Windows.Forms.Label
        Me.LabelPassword = New System.Windows.Forms.Label
        Me.TextBoxPassword = New System.Windows.Forms.TextBox
        Me.ButtonClearAutoLogon = New System.Windows.Forms.Button
        Me.ButtonSetAutoLogon = New System.Windows.Forms.Button
        Me.LabelAutoLogonStatus = New System.Windows.Forms.Label
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
        Me.LabelTitle.Size = New System.Drawing.Size(165, 25)
        Me.LabelTitle.TabIndex = 7
        Me.LabelTitle.Text = "User Information"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.Users_48x48
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
        Me.LabelSeparator.TabIndex = 14
        '
        'LabelRegistration
        '
        Me.LabelRegistration.AutoEllipsis = True
        Me.LabelRegistration.BackColor = System.Drawing.Color.Transparent
        Me.LabelRegistration.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegistration.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelRegistration.Location = New System.Drawing.Point(16, 79)
        Me.LabelRegistration.Name = "LabelRegistration"
        Me.LabelRegistration.Size = New System.Drawing.Size(480, 17)
        Me.LabelRegistration.TabIndex = 18
        Me.LabelRegistration.Text = "Registration"
        '
        'LabelRegisteredUser
        '
        Me.LabelRegisteredUser.AutoSize = True
        Me.LabelRegisteredUser.BackColor = System.Drawing.Color.Transparent
        Me.LabelRegisteredUser.Location = New System.Drawing.Point(14, 122)
        Me.LabelRegisteredUser.Name = "LabelRegisteredUser"
        Me.LabelRegisteredUser.Size = New System.Drawing.Size(91, 15)
        Me.LabelRegisteredUser.TabIndex = 21
        Me.LabelRegisteredUser.Text = "Registered User:"
        '
        'LabelRegisteredOrganization
        '
        Me.LabelRegisteredOrganization.AutoSize = True
        Me.LabelRegisteredOrganization.BackColor = System.Drawing.Color.Transparent
        Me.LabelRegisteredOrganization.Location = New System.Drawing.Point(14, 150)
        Me.LabelRegisteredOrganization.Name = "LabelRegisteredOrganization"
        Me.LabelRegisteredOrganization.Size = New System.Drawing.Size(136, 15)
        Me.LabelRegisteredOrganization.TabIndex = 22
        Me.LabelRegisteredOrganization.Text = "Registered Organization:"
        '
        'TextBoxRegisteredUser
        '
        Me.TextBoxRegisteredUser.Location = New System.Drawing.Point(154, 118)
        Me.TextBoxRegisteredUser.Name = "TextBoxRegisteredUser"
        Me.TextBoxRegisteredUser.Size = New System.Drawing.Size(276, 23)
        Me.TextBoxRegisteredUser.TabIndex = 23
        '
        'TextBoxRegisteredOrganization
        '
        Me.TextBoxRegisteredOrganization.AcceptsReturn = True
        Me.TextBoxRegisteredOrganization.Location = New System.Drawing.Point(154, 146)
        Me.TextBoxRegisteredOrganization.Name = "TextBoxRegisteredOrganization"
        Me.TextBoxRegisteredOrganization.Size = New System.Drawing.Size(276, 23)
        Me.TextBoxRegisteredOrganization.TabIndex = 24
        '
        'ButtonSaveRegisteredUser
        '
        Me.ButtonSaveRegisteredUser.Enabled = False
        Me.ButtonSaveRegisteredUser.Location = New System.Drawing.Point(448, 118)
        Me.ButtonSaveRegisteredUser.Name = "ButtonSaveRegisteredUser"
        Me.ButtonSaveRegisteredUser.Size = New System.Drawing.Size(48, 23)
        Me.ButtonSaveRegisteredUser.TabIndex = 25
        Me.ButtonSaveRegisteredUser.Text = "Save"
        Me.ButtonSaveRegisteredUser.UseVisualStyleBackColor = True
        '
        'ButtonSaveRegisteredOrganization
        '
        Me.ButtonSaveRegisteredOrganization.Enabled = False
        Me.ButtonSaveRegisteredOrganization.Location = New System.Drawing.Point(448, 146)
        Me.ButtonSaveRegisteredOrganization.Name = "ButtonSaveRegisteredOrganization"
        Me.ButtonSaveRegisteredOrganization.Size = New System.Drawing.Size(48, 23)
        Me.ButtonSaveRegisteredOrganization.TabIndex = 26
        Me.ButtonSaveRegisteredOrganization.Text = "Save"
        Me.ButtonSaveRegisteredOrganization.UseVisualStyleBackColor = True
        '
        'ButtonSaveRegisteredOrganization2
        '
        Me.ButtonSaveRegisteredOrganization2.Enabled = False
        Me.ButtonSaveRegisteredOrganization2.Location = New System.Drawing.Point(448, 250)
        Me.ButtonSaveRegisteredOrganization2.Name = "ButtonSaveRegisteredOrganization2"
        Me.ButtonSaveRegisteredOrganization2.Size = New System.Drawing.Size(48, 23)
        Me.ButtonSaveRegisteredOrganization2.TabIndex = 34
        Me.ButtonSaveRegisteredOrganization2.Text = "Save"
        Me.ButtonSaveRegisteredOrganization2.UseVisualStyleBackColor = True
        '
        'ButtonSaveRegisteredUser2
        '
        Me.ButtonSaveRegisteredUser2.Enabled = False
        Me.ButtonSaveRegisteredUser2.Location = New System.Drawing.Point(448, 222)
        Me.ButtonSaveRegisteredUser2.Name = "ButtonSaveRegisteredUser2"
        Me.ButtonSaveRegisteredUser2.Size = New System.Drawing.Size(48, 23)
        Me.ButtonSaveRegisteredUser2.TabIndex = 33
        Me.ButtonSaveRegisteredUser2.Text = "Save"
        Me.ButtonSaveRegisteredUser2.UseVisualStyleBackColor = True
        '
        'TextBoxRegisteredOrganization2
        '
        Me.TextBoxRegisteredOrganization2.AcceptsReturn = True
        Me.TextBoxRegisteredOrganization2.Location = New System.Drawing.Point(154, 250)
        Me.TextBoxRegisteredOrganization2.Name = "TextBoxRegisteredOrganization2"
        Me.TextBoxRegisteredOrganization2.Size = New System.Drawing.Size(276, 23)
        Me.TextBoxRegisteredOrganization2.TabIndex = 32
        '
        'TextBoxRegisteredUser2
        '
        Me.TextBoxRegisteredUser2.Location = New System.Drawing.Point(154, 222)
        Me.TextBoxRegisteredUser2.Name = "TextBoxRegisteredUser2"
        Me.TextBoxRegisteredUser2.Size = New System.Drawing.Size(276, 23)
        Me.TextBoxRegisteredUser2.TabIndex = 31
        '
        'LabelRegisteredOrganization2
        '
        Me.LabelRegisteredOrganization2.AutoSize = True
        Me.LabelRegisteredOrganization2.BackColor = System.Drawing.Color.Transparent
        Me.LabelRegisteredOrganization2.Location = New System.Drawing.Point(14, 254)
        Me.LabelRegisteredOrganization2.Name = "LabelRegisteredOrganization2"
        Me.LabelRegisteredOrganization2.Size = New System.Drawing.Size(136, 15)
        Me.LabelRegisteredOrganization2.TabIndex = 30
        Me.LabelRegisteredOrganization2.Text = "Registered Organization:"
        '
        'LabelRegisteredUser2
        '
        Me.LabelRegisteredUser2.AutoSize = True
        Me.LabelRegisteredUser2.BackColor = System.Drawing.Color.Transparent
        Me.LabelRegisteredUser2.Location = New System.Drawing.Point(14, 226)
        Me.LabelRegisteredUser2.Name = "LabelRegisteredUser2"
        Me.LabelRegisteredUser2.Size = New System.Drawing.Size(91, 15)
        Me.LabelRegisteredUser2.TabIndex = 29
        Me.LabelRegisteredUser2.Text = "Registered User:"
        '
        'LabelRegistration2
        '
        Me.LabelRegistration2.AutoEllipsis = True
        Me.LabelRegistration2.BackColor = System.Drawing.Color.Transparent
        Me.LabelRegistration2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegistration2.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelRegistration2.Location = New System.Drawing.Point(15, 187)
        Me.LabelRegistration2.Name = "LabelRegistration2"
        Me.LabelRegistration2.Size = New System.Drawing.Size(482, 17)
        Me.LabelRegistration2.TabIndex = 28
        Me.LabelRegistration2.Text = "Registration (32-Bit Compatilibity Node)"
        '
        'LabelSeparator2
        '
        Me.LabelSeparator2.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator2.Location = New System.Drawing.Point(16, 208)
        Me.LabelSeparator2.Name = "LabelSeparator2"
        Me.LabelSeparator2.Size = New System.Drawing.Size(482, 3)
        Me.LabelSeparator2.TabIndex = 27
        '
        'LabelAutoLogon
        '
        Me.LabelAutoLogon.AutoSize = True
        Me.LabelAutoLogon.BackColor = System.Drawing.Color.Transparent
        Me.LabelAutoLogon.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAutoLogon.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelAutoLogon.Location = New System.Drawing.Point(15, 296)
        Me.LabelAutoLogon.Name = "LabelAutoLogon"
        Me.LabelAutoLogon.Size = New System.Drawing.Size(415, 17)
        Me.LabelAutoLogon.TabIndex = 39
        Me.LabelAutoLogon.Text = "Auto Logon (Note: Your Password Will Be Visible In The Registry)"
        '
        'LabelSeparator3
        '
        Me.LabelSeparator3.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator3.Location = New System.Drawing.Point(15, 316)
        Me.LabelSeparator3.Name = "LabelSeparator3"
        Me.LabelSeparator3.Size = New System.Drawing.Size(482, 3)
        Me.LabelSeparator3.TabIndex = 38
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Location = New System.Drawing.Point(89, 334)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(157, 23)
        Me.TextBoxUserName.TabIndex = 40
        '
        'LabelUserName
        '
        Me.LabelUserName.AutoSize = True
        Me.LabelUserName.BackColor = System.Drawing.Color.Transparent
        Me.LabelUserName.Location = New System.Drawing.Point(15, 337)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(68, 15)
        Me.LabelUserName.TabIndex = 42
        Me.LabelUserName.Text = "User Name:"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelPassword.Location = New System.Drawing.Point(274, 337)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(60, 15)
        Me.LabelPassword.TabIndex = 44
        Me.LabelPassword.Text = "Password:"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(340, 334)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(157, 23)
        Me.TextBoxPassword.TabIndex = 43
        '
        'ButtonClearAutoLogon
        '
        Me.ButtonClearAutoLogon.Enabled = False
        Me.ButtonClearAutoLogon.Location = New System.Drawing.Point(370, 372)
        Me.ButtonClearAutoLogon.Name = "ButtonClearAutoLogon"
        Me.ButtonClearAutoLogon.Size = New System.Drawing.Size(126, 23)
        Me.ButtonClearAutoLogon.TabIndex = 45
        Me.ButtonClearAutoLogon.Text = "Clear Auto Logon"
        Me.ButtonClearAutoLogon.UseVisualStyleBackColor = True
        '
        'ButtonSetAutoLogon
        '
        Me.ButtonSetAutoLogon.Enabled = False
        Me.ButtonSetAutoLogon.Location = New System.Drawing.Point(226, 372)
        Me.ButtonSetAutoLogon.Name = "ButtonSetAutoLogon"
        Me.ButtonSetAutoLogon.Size = New System.Drawing.Size(126, 23)
        Me.ButtonSetAutoLogon.TabIndex = 46
        Me.ButtonSetAutoLogon.Text = "Set Auto Logon"
        Me.ButtonSetAutoLogon.UseVisualStyleBackColor = True
        '
        'LabelAutoLogonStatus
        '
        Me.LabelAutoLogonStatus.AutoSize = True
        Me.LabelAutoLogonStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelAutoLogonStatus.Location = New System.Drawing.Point(15, 376)
        Me.LabelAutoLogonStatus.Name = "LabelAutoLogonStatus"
        Me.LabelAutoLogonStatus.Size = New System.Drawing.Size(129, 15)
        Me.LabelAutoLogonStatus.TabIndex = 47
        Me.LabelAutoLogonStatus.Text = "Auto Logon Is Disabled"
        '
        'UserInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.LabelAutoLogonStatus)
        Me.Controls.Add(Me.ButtonSetAutoLogon)
        Me.Controls.Add(Me.ButtonClearAutoLogon)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.LabelUserName)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Controls.Add(Me.LabelAutoLogon)
        Me.Controls.Add(Me.LabelSeparator3)
        Me.Controls.Add(Me.ButtonSaveRegisteredOrganization2)
        Me.Controls.Add(Me.ButtonSaveRegisteredUser2)
        Me.Controls.Add(Me.TextBoxRegisteredOrganization2)
        Me.Controls.Add(Me.TextBoxRegisteredUser2)
        Me.Controls.Add(Me.LabelRegisteredOrganization2)
        Me.Controls.Add(Me.LabelRegisteredUser2)
        Me.Controls.Add(Me.LabelRegistration2)
        Me.Controls.Add(Me.LabelSeparator2)
        Me.Controls.Add(Me.ButtonSaveRegisteredOrganization)
        Me.Controls.Add(Me.ButtonSaveRegisteredUser)
        Me.Controls.Add(Me.TextBoxRegisteredOrganization)
        Me.Controls.Add(Me.TextBoxRegisteredUser)
        Me.Controls.Add(Me.LabelRegisteredOrganization)
        Me.Controls.Add(Me.LabelRegisteredUser)
        Me.Controls.Add(Me.LabelRegistration)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "UserInformation"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents LabelRegistration As System.Windows.Forms.Label
    Private WithEvents LabelRegisteredUser As System.Windows.Forms.Label
    Private WithEvents LabelRegisteredOrganization As System.Windows.Forms.Label
    Private WithEvents TextBoxRegisteredUser As System.Windows.Forms.TextBox
    Private WithEvents TextBoxRegisteredOrganization As System.Windows.Forms.TextBox
    Private WithEvents ButtonSaveRegisteredUser As System.Windows.Forms.Button
    Private WithEvents ButtonSaveRegisteredOrganization As System.Windows.Forms.Button
    Private WithEvents ButtonSaveRegisteredOrganization2 As System.Windows.Forms.Button
    Private WithEvents ButtonSaveRegisteredUser2 As System.Windows.Forms.Button
    Private WithEvents TextBoxRegisteredOrganization2 As System.Windows.Forms.TextBox
    Private WithEvents TextBoxRegisteredUser2 As System.Windows.Forms.TextBox
    Private WithEvents LabelRegisteredOrganization2 As System.Windows.Forms.Label
    Private WithEvents LabelRegisteredUser2 As System.Windows.Forms.Label
    Private WithEvents LabelRegistration2 As System.Windows.Forms.Label
    Private WithEvents LabelSeparator2 As System.Windows.Forms.Label
    Private WithEvents LabelAutoLogon As System.Windows.Forms.Label
    Private WithEvents LabelSeparator3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUserName As System.Windows.Forms.TextBox
    Friend WithEvents LabelUserName As System.Windows.Forms.Label
    Friend WithEvents LabelPassword As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents ButtonClearAutoLogon As System.Windows.Forms.Button
    Friend WithEvents ButtonSetAutoLogon As System.Windows.Forms.Button
    Friend WithEvents LabelAutoLogonStatus As System.Windows.Forms.Label

End Class
