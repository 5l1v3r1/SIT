<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Network
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
        Me.LabelNetworkID = New System.Windows.Forms.Label
        Me.LabelSeparator = New System.Windows.Forms.Label
        Me.LabelInterface = New System.Windows.Forms.Label
        Me.ListViewInterface = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ComboBoxInterface = New System.Windows.Forms.ComboBox
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
        Me.LabelTitle.Size = New System.Drawing.Size(90, 25)
        Me.LabelTitle.TabIndex = 7
        Me.LabelTitle.Text = "Network"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.Network_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 6
        Me.PictureBoxPanel.TabStop = False
        '
        'LabelNetworkID
        '
        Me.LabelNetworkID.AutoSize = True
        Me.LabelNetworkID.BackColor = System.Drawing.Color.Transparent
        Me.LabelNetworkID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNetworkID.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelNetworkID.Location = New System.Drawing.Point(80, 72)
        Me.LabelNetworkID.Name = "LabelNetworkID"
        Me.LabelNetworkID.Size = New System.Drawing.Size(32, 17)
        Me.LabelNetworkID.TabIndex = 15
        Me.LabelNetworkID.Text = "      "
        '
        'LabelSeparator
        '
        Me.LabelSeparator.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator.Location = New System.Drawing.Point(80, 94)
        Me.LabelSeparator.Name = "LabelSeparator"
        Me.LabelSeparator.Size = New System.Drawing.Size(420, 3)
        Me.LabelSeparator.TabIndex = 14
        '
        'LabelInterface
        '
        Me.LabelInterface.AutoSize = True
        Me.LabelInterface.BackColor = System.Drawing.Color.Transparent
        Me.LabelInterface.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInterface.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelInterface.Location = New System.Drawing.Point(80, 108)
        Me.LabelInterface.Name = "LabelInterface"
        Me.LabelInterface.Size = New System.Drawing.Size(68, 17)
        Me.LabelInterface.TabIndex = 17
        Me.LabelInterface.Text = "Interfaces"
        '
        'ListViewInterface
        '
        Me.ListViewInterface.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewInterface.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListViewInterface.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewInterface.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListViewInterface.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListViewInterface.LabelWrap = False
        Me.ListViewInterface.Location = New System.Drawing.Point(80, 156)
        Me.ListViewInterface.Name = "ListViewInterface"
        Me.ListViewInterface.ShowGroups = False
        Me.ListViewInterface.Size = New System.Drawing.Size(420, 264)
        Me.ListViewInterface.TabIndex = 45
        Me.ListViewInterface.UseCompatibleStateImageBehavior = False
        Me.ListViewInterface.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 400
        '
        'ComboBoxInterface
        '
        Me.ComboBoxInterface.FormattingEnabled = True
        Me.ComboBoxInterface.Location = New System.Drawing.Point(80, 128)
        Me.ComboBoxInterface.Name = "ComboBoxInterface"
        Me.ComboBoxInterface.Size = New System.Drawing.Size(420, 23)
        Me.ComboBoxInterface.Sorted = True
        Me.ComboBoxInterface.TabIndex = 46
        '
        'Network
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.ComboBoxInterface)
        Me.Controls.Add(Me.ListViewInterface)
        Me.Controls.Add(Me.LabelInterface)
        Me.Controls.Add(Me.LabelNetworkID)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "Network"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents LabelNetworkID As System.Windows.Forms.Label
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents LabelInterface As System.Windows.Forms.Label
    Private WithEvents ListViewInterface As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents ComboBoxInterface As System.Windows.Forms.ComboBox

End Class
