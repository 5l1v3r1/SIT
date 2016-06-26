<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Computer
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
        Me.PictureBoxPanel = New System.Windows.Forms.PictureBox
        Me.LabelTitle = New System.Windows.Forms.Label
        Me.LabelGeneral = New System.Windows.Forms.Label
        Me.LabelSeparator = New System.Windows.Forms.Label
        Me.LabelMemory = New System.Windows.Forms.Label
        Me.LabelSeparator2 = New System.Windows.Forms.Label
        Me.LabelCompManufacturer = New System.Windows.Forms.Label
        Me.LabelCompModel = New System.Windows.Forms.Label
        Me.LabelBootupState = New System.Windows.Forms.Label
        Me.LabelTPDesc = New System.Windows.Forms.Label
        Me.LabelAPDesc = New System.Windows.Forms.Label
        Me.LabelTVDesc = New System.Windows.Forms.Label
        Me.LabelAVDesc = New System.Windows.Forms.Label
        Me.LabelTotalPhysical = New System.Windows.Forms.Label
        Me.LabelAvailablePhysical = New System.Windows.Forms.Label
        Me.LabelTotalVirtual = New System.Windows.Forms.Label
        Me.LabelAvailableVirtual = New System.Windows.Forms.Label
        Me.LabelMBModel = New System.Windows.Forms.Label
        Me.LabelMBManufacturer = New System.Windows.Forms.Label
        Me.LabelSystemType = New System.Windows.Forms.Label
        Me.LabelDescription = New System.Windows.Forms.Label
        Me.LabelUpTime = New System.Windows.Forms.Label
        Me.TimerTimeUp = New System.Windows.Forms.Timer(Me.components)
        Me.LabelUpTimeDesc = New System.Windows.Forms.Label
        Me.LabelBootupStateDesc = New System.Windows.Forms.Label
        Me.LabelSystemTypeDesc = New System.Windows.Forms.Label
        Me.LabelDescriptionDesc = New System.Windows.Forms.Label
        Me.LabelMainboardModelDesc = New System.Windows.Forms.Label
        Me.LabelMainboardMfgDesc = New System.Windows.Forms.Label
        Me.LabelComputerModelDesc = New System.Windows.Forms.Label
        Me.LabelComputerMfgDesc = New System.Windows.Forms.Label
        Me.LabelStartDateTimeDescription = New System.Windows.Forms.Label
        Me.LabelStartDateTime = New System.Windows.Forms.Label
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.Computer_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 0
        Me.PictureBoxPanel.TabStop = False
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelTitle.Location = New System.Drawing.Point(80, 28)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(102, 25)
        Me.LabelTitle.TabIndex = 1
        Me.LabelTitle.Text = "Computer"
        '
        'LabelGeneral
        '
        Me.LabelGeneral.AutoSize = True
        Me.LabelGeneral.BackColor = System.Drawing.Color.Transparent
        Me.LabelGeneral.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGeneral.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelGeneral.Location = New System.Drawing.Point(80, 72)
        Me.LabelGeneral.Name = "LabelGeneral"
        Me.LabelGeneral.Size = New System.Drawing.Size(55, 17)
        Me.LabelGeneral.TabIndex = 8
        Me.LabelGeneral.Text = "General"
        '
        'LabelSeparator
        '
        Me.LabelSeparator.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator.Location = New System.Drawing.Point(80, 94)
        Me.LabelSeparator.Name = "LabelSeparator"
        Me.LabelSeparator.Size = New System.Drawing.Size(420, 3)
        Me.LabelSeparator.TabIndex = 7
        '
        'LabelMemory
        '
        Me.LabelMemory.AutoSize = True
        Me.LabelMemory.BackColor = System.Drawing.Color.Transparent
        Me.LabelMemory.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMemory.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelMemory.Location = New System.Drawing.Point(80, 288)
        Me.LabelMemory.Name = "LabelMemory"
        Me.LabelMemory.Size = New System.Drawing.Size(59, 17)
        Me.LabelMemory.TabIndex = 10
        Me.LabelMemory.Text = "Memory"
        '
        'LabelSeparator2
        '
        Me.LabelSeparator2.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator2.Location = New System.Drawing.Point(80, 310)
        Me.LabelSeparator2.Name = "LabelSeparator2"
        Me.LabelSeparator2.Size = New System.Drawing.Size(420, 3)
        Me.LabelSeparator2.TabIndex = 9
        '
        'LabelCompManufacturer
        '
        Me.LabelCompManufacturer.BackColor = System.Drawing.Color.Transparent
        Me.LabelCompManufacturer.ForeColor = System.Drawing.Color.Black
        Me.LabelCompManufacturer.Location = New System.Drawing.Point(270, 104)
        Me.LabelCompManufacturer.Name = "LabelCompManufacturer"
        Me.LabelCompManufacturer.Size = New System.Drawing.Size(218, 15)
        Me.LabelCompManufacturer.TabIndex = 11
        '
        'LabelCompModel
        '
        Me.LabelCompModel.BackColor = System.Drawing.Color.Transparent
        Me.LabelCompModel.ForeColor = System.Drawing.Color.Black
        Me.LabelCompModel.Location = New System.Drawing.Point(270, 124)
        Me.LabelCompModel.Name = "LabelCompModel"
        Me.LabelCompModel.Size = New System.Drawing.Size(218, 15)
        Me.LabelCompModel.TabIndex = 12
        '
        'LabelBootupState
        '
        Me.LabelBootupState.BackColor = System.Drawing.Color.Transparent
        Me.LabelBootupState.ForeColor = System.Drawing.Color.Black
        Me.LabelBootupState.Location = New System.Drawing.Point(270, 224)
        Me.LabelBootupState.Name = "LabelBootupState"
        Me.LabelBootupState.Size = New System.Drawing.Size(218, 15)
        Me.LabelBootupState.TabIndex = 14
        '
        'LabelTPDesc
        '
        Me.LabelTPDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelTPDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelTPDesc.Location = New System.Drawing.Point(80, 320)
        Me.LabelTPDesc.Name = "LabelTPDesc"
        Me.LabelTPDesc.Size = New System.Drawing.Size(115, 13)
        Me.LabelTPDesc.TabIndex = 15
        Me.LabelTPDesc.Text = "Total Physical"
        '
        'LabelAPDesc
        '
        Me.LabelAPDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelAPDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelAPDesc.Location = New System.Drawing.Point(80, 340)
        Me.LabelAPDesc.Name = "LabelAPDesc"
        Me.LabelAPDesc.Size = New System.Drawing.Size(115, 13)
        Me.LabelAPDesc.TabIndex = 16
        Me.LabelAPDesc.Text = "Available Physical"
        '
        'LabelTVDesc
        '
        Me.LabelTVDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelTVDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelTVDesc.Location = New System.Drawing.Point(80, 360)
        Me.LabelTVDesc.Name = "LabelTVDesc"
        Me.LabelTVDesc.Size = New System.Drawing.Size(115, 13)
        Me.LabelTVDesc.TabIndex = 17
        Me.LabelTVDesc.Text = "Total Virtual"
        '
        'LabelAVDesc
        '
        Me.LabelAVDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelAVDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelAVDesc.Location = New System.Drawing.Point(80, 380)
        Me.LabelAVDesc.Name = "LabelAVDesc"
        Me.LabelAVDesc.Size = New System.Drawing.Size(115, 13)
        Me.LabelAVDesc.TabIndex = 18
        Me.LabelAVDesc.Text = "Available Virtual"
        '
        'LabelTotalPhysical
        '
        Me.LabelTotalPhysical.BackColor = System.Drawing.Color.Transparent
        Me.LabelTotalPhysical.ForeColor = System.Drawing.Color.Black
        Me.LabelTotalPhysical.Location = New System.Drawing.Point(270, 320)
        Me.LabelTotalPhysical.Name = "LabelTotalPhysical"
        Me.LabelTotalPhysical.Size = New System.Drawing.Size(70, 15)
        Me.LabelTotalPhysical.TabIndex = 19
        '
        'LabelAvailablePhysical
        '
        Me.LabelAvailablePhysical.BackColor = System.Drawing.Color.Transparent
        Me.LabelAvailablePhysical.ForeColor = System.Drawing.Color.Black
        Me.LabelAvailablePhysical.Location = New System.Drawing.Point(270, 340)
        Me.LabelAvailablePhysical.Name = "LabelAvailablePhysical"
        Me.LabelAvailablePhysical.Size = New System.Drawing.Size(70, 15)
        Me.LabelAvailablePhysical.TabIndex = 20
        '
        'LabelTotalVirtual
        '
        Me.LabelTotalVirtual.BackColor = System.Drawing.Color.Transparent
        Me.LabelTotalVirtual.ForeColor = System.Drawing.Color.Black
        Me.LabelTotalVirtual.Location = New System.Drawing.Point(270, 360)
        Me.LabelTotalVirtual.Name = "LabelTotalVirtual"
        Me.LabelTotalVirtual.Size = New System.Drawing.Size(70, 15)
        Me.LabelTotalVirtual.TabIndex = 21
        '
        'LabelAvailableVirtual
        '
        Me.LabelAvailableVirtual.BackColor = System.Drawing.Color.Transparent
        Me.LabelAvailableVirtual.ForeColor = System.Drawing.Color.Black
        Me.LabelAvailableVirtual.Location = New System.Drawing.Point(270, 380)
        Me.LabelAvailableVirtual.Name = "LabelAvailableVirtual"
        Me.LabelAvailableVirtual.Size = New System.Drawing.Size(70, 15)
        Me.LabelAvailableVirtual.TabIndex = 22
        '
        'LabelMBModel
        '
        Me.LabelMBModel.BackColor = System.Drawing.Color.Transparent
        Me.LabelMBModel.ForeColor = System.Drawing.Color.Black
        Me.LabelMBModel.Location = New System.Drawing.Point(270, 164)
        Me.LabelMBModel.Name = "LabelMBModel"
        Me.LabelMBModel.Size = New System.Drawing.Size(218, 15)
        Me.LabelMBModel.TabIndex = 24
        '
        'LabelMBManufacturer
        '
        Me.LabelMBManufacturer.BackColor = System.Drawing.Color.Transparent
        Me.LabelMBManufacturer.ForeColor = System.Drawing.Color.Black
        Me.LabelMBManufacturer.Location = New System.Drawing.Point(270, 144)
        Me.LabelMBManufacturer.Name = "LabelMBManufacturer"
        Me.LabelMBManufacturer.Size = New System.Drawing.Size(218, 15)
        Me.LabelMBManufacturer.TabIndex = 23
        '
        'LabelSystemType
        '
        Me.LabelSystemType.BackColor = System.Drawing.Color.Transparent
        Me.LabelSystemType.ForeColor = System.Drawing.Color.Black
        Me.LabelSystemType.Location = New System.Drawing.Point(270, 204)
        Me.LabelSystemType.Name = "LabelSystemType"
        Me.LabelSystemType.Size = New System.Drawing.Size(218, 15)
        Me.LabelSystemType.TabIndex = 26
        '
        'LabelDescription
        '
        Me.LabelDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescription.ForeColor = System.Drawing.Color.Black
        Me.LabelDescription.Location = New System.Drawing.Point(270, 184)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(218, 15)
        Me.LabelDescription.TabIndex = 25
        '
        'LabelUpTime
        '
        Me.LabelUpTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelUpTime.ForeColor = System.Drawing.Color.Black
        Me.LabelUpTime.Location = New System.Drawing.Point(270, 264)
        Me.LabelUpTime.Name = "LabelUpTime"
        Me.LabelUpTime.Size = New System.Drawing.Size(218, 15)
        Me.LabelUpTime.TabIndex = 27
        '
        'TimerTimeUp
        '
        Me.TimerTimeUp.Interval = 1000
        '
        'LabelUpTimeDesc
        '
        Me.LabelUpTimeDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelUpTimeDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelUpTimeDesc.Location = New System.Drawing.Point(80, 264)
        Me.LabelUpTimeDesc.Name = "LabelUpTimeDesc"
        Me.LabelUpTimeDesc.Size = New System.Drawing.Size(184, 13)
        Me.LabelUpTimeDesc.TabIndex = 43
        Me.LabelUpTimeDesc.Text = "Up Time:"
        '
        'LabelBootupStateDesc
        '
        Me.LabelBootupStateDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelBootupStateDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelBootupStateDesc.Location = New System.Drawing.Point(80, 224)
        Me.LabelBootupStateDesc.Name = "LabelBootupStateDesc"
        Me.LabelBootupStateDesc.Size = New System.Drawing.Size(184, 13)
        Me.LabelBootupStateDesc.TabIndex = 42
        Me.LabelBootupStateDesc.Text = "Bootup State:"
        '
        'LabelSystemTypeDesc
        '
        Me.LabelSystemTypeDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelSystemTypeDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelSystemTypeDesc.Location = New System.Drawing.Point(80, 204)
        Me.LabelSystemTypeDesc.Name = "LabelSystemTypeDesc"
        Me.LabelSystemTypeDesc.Size = New System.Drawing.Size(184, 13)
        Me.LabelSystemTypeDesc.TabIndex = 41
        Me.LabelSystemTypeDesc.Text = "System Type:"
        '
        'LabelDescriptionDesc
        '
        Me.LabelDescriptionDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescriptionDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelDescriptionDesc.Location = New System.Drawing.Point(80, 184)
        Me.LabelDescriptionDesc.Name = "LabelDescriptionDesc"
        Me.LabelDescriptionDesc.Size = New System.Drawing.Size(184, 13)
        Me.LabelDescriptionDesc.TabIndex = 40
        Me.LabelDescriptionDesc.Text = "Description:"
        '
        'LabelMainboardModelDesc
        '
        Me.LabelMainboardModelDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelMainboardModelDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelMainboardModelDesc.Location = New System.Drawing.Point(80, 164)
        Me.LabelMainboardModelDesc.Name = "LabelMainboardModelDesc"
        Me.LabelMainboardModelDesc.Size = New System.Drawing.Size(184, 13)
        Me.LabelMainboardModelDesc.TabIndex = 39
        Me.LabelMainboardModelDesc.Text = "Mainboard Model:"
        '
        'LabelMainboardMfgDesc
        '
        Me.LabelMainboardMfgDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelMainboardMfgDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelMainboardMfgDesc.Location = New System.Drawing.Point(80, 144)
        Me.LabelMainboardMfgDesc.Name = "LabelMainboardMfgDesc"
        Me.LabelMainboardMfgDesc.Size = New System.Drawing.Size(184, 13)
        Me.LabelMainboardMfgDesc.TabIndex = 38
        Me.LabelMainboardMfgDesc.Text = "Mainboard Manufacturer:"
        '
        'LabelComputerModelDesc
        '
        Me.LabelComputerModelDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelComputerModelDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelComputerModelDesc.Location = New System.Drawing.Point(80, 124)
        Me.LabelComputerModelDesc.Name = "LabelComputerModelDesc"
        Me.LabelComputerModelDesc.Size = New System.Drawing.Size(184, 13)
        Me.LabelComputerModelDesc.TabIndex = 37
        Me.LabelComputerModelDesc.Text = "Computer/Chipset Model:"
        '
        'LabelComputerMfgDesc
        '
        Me.LabelComputerMfgDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelComputerMfgDesc.ForeColor = System.Drawing.Color.Black
        Me.LabelComputerMfgDesc.Location = New System.Drawing.Point(80, 104)
        Me.LabelComputerMfgDesc.Name = "LabelComputerMfgDesc"
        Me.LabelComputerMfgDesc.Size = New System.Drawing.Size(184, 13)
        Me.LabelComputerMfgDesc.TabIndex = 36
        Me.LabelComputerMfgDesc.Text = "Computer/Chipset Manufacturer:"
        '
        'LabelStartDateTimeDescription
        '
        Me.LabelStartDateTimeDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelStartDateTimeDescription.ForeColor = System.Drawing.Color.Black
        Me.LabelStartDateTimeDescription.Location = New System.Drawing.Point(80, 244)
        Me.LabelStartDateTimeDescription.Name = "LabelStartDateTimeDescription"
        Me.LabelStartDateTimeDescription.Size = New System.Drawing.Size(184, 13)
        Me.LabelStartDateTimeDescription.TabIndex = 45
        Me.LabelStartDateTimeDescription.Text = "Start Date/Time:"
        '
        'LabelStartDateTime
        '
        Me.LabelStartDateTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelStartDateTime.ForeColor = System.Drawing.Color.Black
        Me.LabelStartDateTime.Location = New System.Drawing.Point(270, 244)
        Me.LabelStartDateTime.Name = "LabelStartDateTime"
        Me.LabelStartDateTime.Size = New System.Drawing.Size(218, 15)
        Me.LabelStartDateTime.TabIndex = 44
        '
        'Computer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.LabelStartDateTimeDescription)
        Me.Controls.Add(Me.LabelStartDateTime)
        Me.Controls.Add(Me.LabelUpTimeDesc)
        Me.Controls.Add(Me.LabelBootupStateDesc)
        Me.Controls.Add(Me.LabelSystemTypeDesc)
        Me.Controls.Add(Me.LabelDescriptionDesc)
        Me.Controls.Add(Me.LabelMainboardModelDesc)
        Me.Controls.Add(Me.LabelMainboardMfgDesc)
        Me.Controls.Add(Me.LabelComputerModelDesc)
        Me.Controls.Add(Me.LabelComputerMfgDesc)
        Me.Controls.Add(Me.LabelUpTime)
        Me.Controls.Add(Me.LabelSystemType)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelMBModel)
        Me.Controls.Add(Me.LabelMBManufacturer)
        Me.Controls.Add(Me.LabelAvailableVirtual)
        Me.Controls.Add(Me.LabelTotalVirtual)
        Me.Controls.Add(Me.LabelAvailablePhysical)
        Me.Controls.Add(Me.LabelTotalPhysical)
        Me.Controls.Add(Me.LabelAVDesc)
        Me.Controls.Add(Me.LabelTVDesc)
        Me.Controls.Add(Me.LabelAPDesc)
        Me.Controls.Add(Me.LabelTPDesc)
        Me.Controls.Add(Me.LabelBootupState)
        Me.Controls.Add(Me.LabelCompModel)
        Me.Controls.Add(Me.LabelCompManufacturer)
        Me.Controls.Add(Me.LabelMemory)
        Me.Controls.Add(Me.LabelSeparator2)
        Me.Controls.Add(Me.LabelGeneral)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "Computer"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents LabelGeneral As System.Windows.Forms.Label
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents LabelMemory As System.Windows.Forms.Label
    Private WithEvents LabelSeparator2 As System.Windows.Forms.Label
    Private WithEvents LabelCompManufacturer As System.Windows.Forms.Label
    Private WithEvents LabelCompModel As System.Windows.Forms.Label
    Private WithEvents LabelBootupState As System.Windows.Forms.Label
    Private WithEvents LabelTPDesc As System.Windows.Forms.Label
    Private WithEvents LabelAPDesc As System.Windows.Forms.Label
    Private WithEvents LabelTVDesc As System.Windows.Forms.Label
    Private WithEvents LabelAVDesc As System.Windows.Forms.Label
    Private WithEvents LabelTotalPhysical As System.Windows.Forms.Label
    Private WithEvents LabelAvailablePhysical As System.Windows.Forms.Label
    Private WithEvents LabelTotalVirtual As System.Windows.Forms.Label
    Private WithEvents LabelAvailableVirtual As System.Windows.Forms.Label
    Private WithEvents LabelMBModel As System.Windows.Forms.Label
    Private WithEvents LabelMBManufacturer As System.Windows.Forms.Label
    Private WithEvents LabelSystemType As System.Windows.Forms.Label
    Private WithEvents LabelDescription As System.Windows.Forms.Label
    Private WithEvents LabelUpTime As System.Windows.Forms.Label
    Private WithEvents TimerTimeUp As System.Windows.Forms.Timer
    Private WithEvents LabelUpTimeDesc As System.Windows.Forms.Label
    Private WithEvents LabelBootupStateDesc As System.Windows.Forms.Label
    Private WithEvents LabelSystemTypeDesc As System.Windows.Forms.Label
    Private WithEvents LabelDescriptionDesc As System.Windows.Forms.Label
    Private WithEvents LabelMainboardModelDesc As System.Windows.Forms.Label
    Private WithEvents LabelMainboardMfgDesc As System.Windows.Forms.Label
    Private WithEvents LabelComputerModelDesc As System.Windows.Forms.Label
    Private WithEvents LabelComputerMfgDesc As System.Windows.Forms.Label
    Private WithEvents LabelStartDateTimeDescription As System.Windows.Forms.Label
    Private WithEvents LabelStartDateTime As System.Windows.Forms.Label

End Class
