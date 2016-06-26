<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class EnvironmentVariables
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
        Me.ListViewVariables = New System.Windows.Forms.ListView
        Me.EnvironmentVariable = New System.Windows.Forms.ColumnHeader
        Me.LabelProcessesDescription = New System.Windows.Forms.Label
        Me.LabelSeparator = New System.Windows.Forms.Label
        Me.LabelVariable = New System.Windows.Forms.Label
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
        Me.LabelTitle.Size = New System.Drawing.Size(213, 25)
        Me.LabelTitle.TabIndex = 7
        Me.LabelTitle.Text = "Environment Variables"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.CMD_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 6
        Me.PictureBoxPanel.TabStop = False
        '
        'ListViewProcesses
        '
        Me.ListViewVariables.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewVariables.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EnvironmentVariable})
        Me.ListViewVariables.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewVariables.ForeColor = System.Drawing.Color.Black
        Me.ListViewVariables.FullRowSelect = True
        Me.ListViewVariables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewVariables.LabelWrap = False
        Me.ListViewVariables.Location = New System.Drawing.Point(16, 108)
        Me.ListViewVariables.MultiSelect = False
        Me.ListViewVariables.Name = "ListViewProcesses"
        Me.ListViewVariables.Size = New System.Drawing.Size(482, 264)
        Me.ListViewVariables.TabIndex = 51
        Me.ListViewVariables.UseCompatibleStateImageBehavior = False
        Me.ListViewVariables.View = System.Windows.Forms.View.Details
        '
        'EnvironmentVariable
        '
        Me.EnvironmentVariable.Text = "Environment Variable"
        Me.EnvironmentVariable.Width = 455
        '
        'LabelProcessesDescription
        '
        Me.LabelProcessesDescription.AutoSize = True
        Me.LabelProcessesDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelProcessesDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProcessesDescription.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelProcessesDescription.Location = New System.Drawing.Point(16, 76)
        Me.LabelProcessesDescription.Name = "LabelProcessesDescription"
        Me.LabelProcessesDescription.Size = New System.Drawing.Size(258, 17)
        Me.LabelProcessesDescription.TabIndex = 50
        Me.LabelProcessesDescription.Text = "Click Environment Variable to expand it."
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
        'LabelTotalProcesses
        '
        Me.LabelVariable.AutoSize = True
        Me.LabelVariable.BackColor = System.Drawing.Color.Transparent
        Me.LabelVariable.Location = New System.Drawing.Point(16, 390)
        Me.LabelVariable.Name = "LabelTotalProcesses"
        Me.LabelVariable.Size = New System.Drawing.Size(106, 15)
        Me.LabelVariable.TabIndex = 53
        Me.LabelVariable.Text = "Expanded Variable:"
        '
        'EnvironmentVariables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.LabelVariable)
        Me.Controls.Add(Me.ListViewVariables)
        Me.Controls.Add(Me.LabelProcessesDescription)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "EnvironmentVariables"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents ListViewVariables As System.Windows.Forms.ListView
    Private WithEvents EnvironmentVariable As System.Windows.Forms.ColumnHeader
    Private WithEvents LabelProcessesDescription As System.Windows.Forms.Label
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Friend WithEvents LabelVariable As System.Windows.Forms.Label

End Class
