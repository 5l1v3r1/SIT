<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Services
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
        Me.ListViewServices = New System.Windows.Forms.ListView
        Me.DisplayName = New System.Windows.Forms.ColumnHeader
        Me.StartMode = New System.Windows.Forms.ColumnHeader
        Me.State = New System.Windows.Forms.ColumnHeader
        Me.PathName = New System.Windows.Forms.ColumnHeader
        Me.Description = New System.Windows.Forms.ColumnHeader
        Me.LabelServicesDescription = New System.Windows.Forms.Label
        Me.LabelSeparator = New System.Windows.Forms.Label
        Me.LabelDetails = New System.Windows.Forms.Label
        Me.LabelSeparator2 = New System.Windows.Forms.Label
        Me.LabelPathName = New System.Windows.Forms.Label
        Me.LabelDescription = New System.Windows.Forms.Label
        Me.TextBoxDescription = New System.Windows.Forms.TextBox
        Me.TextBoxPathName = New System.Windows.Forms.TextBox
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
        Me.LabelTitle.Size = New System.Drawing.Size(83, 25)
        Me.LabelTitle.TabIndex = 7
        Me.LabelTitle.Text = "Services"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.Services_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 6
        Me.PictureBoxPanel.TabStop = False
        '
        'ListViewServices
        '
        Me.ListViewServices.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DisplayName, Me.StartMode, Me.State, Me.PathName, Me.Description})
        Me.ListViewServices.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewServices.ForeColor = System.Drawing.Color.Black
        Me.ListViewServices.FullRowSelect = True
        Me.ListViewServices.LabelWrap = False
        Me.ListViewServices.Location = New System.Drawing.Point(16, 108)
        Me.ListViewServices.MultiSelect = False
        Me.ListViewServices.Name = "ListViewServices"
        Me.ListViewServices.Size = New System.Drawing.Size(482, 160)
        Me.ListViewServices.TabIndex = 51
        Me.ListViewServices.UseCompatibleStateImageBehavior = False
        Me.ListViewServices.View = System.Windows.Forms.View.Details
        '
        'DisplayName
        '
        Me.DisplayName.Text = "Display Name"
        Me.DisplayName.Width = 286
        '
        'StartMode
        '
        Me.StartMode.Text = "Start Mode"
        Me.StartMode.Width = 86
        '
        'State
        '
        Me.State.Text = "State"
        Me.State.Width = 86
        '
        'PathName
        '
        Me.PathName.Text = "PathName"
        Me.PathName.Width = 0
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 0
        '
        'LabelServicesDescription
        '
        Me.LabelServicesDescription.AutoSize = True
        Me.LabelServicesDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelServicesDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelServicesDescription.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelServicesDescription.Location = New System.Drawing.Point(16, 76)
        Me.LabelServicesDescription.Name = "LabelServicesDescription"
        Me.LabelServicesDescription.Size = New System.Drawing.Size(219, 17)
        Me.LabelServicesDescription.TabIndex = 50
        Me.LabelServicesDescription.Text = "Windows and Third-Party Services"
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
        'LabelPathName
        '
        Me.LabelPathName.BackColor = System.Drawing.Color.Transparent
        Me.LabelPathName.ForeColor = System.Drawing.Color.Black
        Me.LabelPathName.Location = New System.Drawing.Point(16, 304)
        Me.LabelPathName.Name = "LabelPathName"
        Me.LabelPathName.Size = New System.Drawing.Size(82, 15)
        Me.LabelPathName.TabIndex = 58
        Me.LabelPathName.Text = "Path:"
        '
        'LabelDescription
        '
        Me.LabelDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescription.ForeColor = System.Drawing.Color.Black
        Me.LabelDescription.Location = New System.Drawing.Point(16, 324)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(82, 15)
        Me.LabelDescription.TabIndex = 75
        Me.LabelDescription.Text = "Description:"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxDescription.Location = New System.Drawing.Point(16, 344)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDescription.Size = New System.Drawing.Size(480, 76)
        Me.TextBoxDescription.TabIndex = 78
        '
        'TextBoxPathName
        '
        Me.TextBoxPathName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxPathName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxPathName.Location = New System.Drawing.Point(101, 303)
        Me.TextBoxPathName.Multiline = True
        Me.TextBoxPathName.Name = "TextBoxPathName"
        Me.TextBoxPathName.ReadOnly = True
        Me.TextBoxPathName.Size = New System.Drawing.Size(393, 37)
        Me.TextBoxPathName.TabIndex = 77
        '
        'Services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.TextBoxPathName)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelPathName)
        Me.Controls.Add(Me.LabelDetails)
        Me.Controls.Add(Me.LabelSeparator2)
        Me.Controls.Add(Me.ListViewServices)
        Me.Controls.Add(Me.LabelServicesDescription)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "Services"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents ListViewServices As System.Windows.Forms.ListView
    Private WithEvents DisplayName As System.Windows.Forms.ColumnHeader
    Private WithEvents State As System.Windows.Forms.ColumnHeader
    Private WithEvents LabelServicesDescription As System.Windows.Forms.Label
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents StartMode As System.Windows.Forms.ColumnHeader
    Private WithEvents LabelDetails As System.Windows.Forms.Label
    Private WithEvents LabelSeparator2 As System.Windows.Forms.Label
    Private WithEvents LabelPathName As System.Windows.Forms.Label
    Private WithEvents LabelDescription As System.Windows.Forms.Label
    Private WithEvents PathName As System.Windows.Forms.ColumnHeader
    Private WithEvents Description As System.Windows.Forms.ColumnHeader
    Private WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Private WithEvents TextBoxPathName As System.Windows.Forms.TextBox

End Class
