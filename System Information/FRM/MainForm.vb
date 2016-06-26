'
' Copyright © 2006-2008 Herbert N Swearengen III (hswear3@swbell.net)
' All rights reserved.
'
' Redistribution and use in source and binary forms, with or without modification, 
' are permitted provided that the following conditions are met:
'
'   - Redistributions of source code must retain the above copyright notice, 
'     this list of conditions and the following disclaimer.
'
'   - Redistributions in binary form must reproduce the above copyright notice, 
'     this list of conditions and the following disclaimer in the documentation 
'     and/or other materials provided with the distribution.
' 
' THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
' ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
' IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
' INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
' NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, 
' OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
' WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
' ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY 
' OF SUCH DAMAGE.
'
Option Explicit On
Option Strict On

Public Class MainForm

    Private _Info As New InformationClass
    Private ResourceManager As New  _
        System.Resources.ResourceManager("SystemInformation.Resources", GetType(MainForm).Assembly)

#Region " TreeView Select "

    ' Display the correct panel based on the node that was selected.
    Private Sub treeviewSystemInfo_AfterSelect(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewSystemInfo.AfterSelect

        Select Case e.Node.Text
            Case "Computer"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(Computer.CreateInstance())
            Case "CPU"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(Cpu.CreateInstance())
            Case "BIOS"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(Bios.CreateInstance())
            Case "Drives"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(Drives.CreateInstance())
            Case "Network"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(Network.CreateInstance())
            Case "Sound"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(Sound.CreateInstance())
            Case "Video"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(Video.CreateInstance())
            Case "Operating System"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(OperatingSystem.CreateInstance())
            Case "Date and Time"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(DateAndTime.CreateInstance())
            Case "Installed Programs"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(InstalledPrograms.CreateInstance())
            Case "Services"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(Services.CreateInstance())
            Case "Startup Programs"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(StartupPrograms.CreateInstance())
            Case "Special Folders"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(SpecialFolders.CreateInstance())
            Case "Environment Variables"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(EnvironmentVariables.CreateInstance())
            Case "OEM Information"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(OemInformation.CreateInstance())
            Case "Processes"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(Processes.CreateInstance())
            Case "User Information"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(UserInformation.CreateInstance())
            Case "Visual Styles"
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(VisualStyles.CreateInstance())
            Case Else
                SplitContainer.Panel2.Controls.Clear()
                SplitContainer.Panel2.Controls.Add(Introduction.CreateInstance())
        End Select

    End Sub

#End Region

#Region " Form Events "

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            ' The last image in the image list holds the os image.
            Dim index As Integer = ImageListTree.Images.Count - 1

            ' Set OS icon on treeview
            Select Case _Info.OSShortVersion
                Case "5.0"  ' Windows 2000
                    ImageListTree.Images.Item(index) = _
                        CType(ResourceManager.GetObject("Windows2000_16x16"), System.Drawing.Image)
                Case "5.1"  ' Windows XP
                    ImageListTree.Images.Item(index) = _
                        CType(ResourceManager.GetObject("Windows_XP_16x16"), System.Drawing.Image)
                Case "6.0"  ' Windows Vista
                    ImageListTree.Images.Item(index) = _
                        CType(ResourceManager.GetObject("Windows_Vista_16x16"), System.Drawing.Image)
                Case Else
                    ImageListTree.Images.Item(index) = _
                        CType(ResourceManager.GetObject("Windows_16x16"), System.Drawing.Image)
            End Select

            ' Start with the tree fully expanded
            TreeViewSystemInfo.ExpandAll()
            TreeViewSystemInfo.Refresh()

            ' Add first panel
            SplitContainer.Panel2.Controls.Clear()
            SplitContainer.Panel2.Controls.Add(Introduction.CreateInstance())

            ' enable timer
            TimerTimeUp.Enabled = True

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the ""MainForm_Load"" procedure." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region " Timer Events "

    Private Sub timerTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles TimerTime.Tick

        'Update Date and Time.
        StatusLabelDateTime.Text = FormatDateTime(Now, DateFormat.LongDate) & "  " & _
           FormatDateTime(Now, DateFormat.LongTime)

    End Sub

    Private Sub timerTimeUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles TimerTimeUp.Tick

        'Update Up Time.
        StatusLabelUpTime.Text = "Up Time: " & _Info.OSUptime

    End Sub

#End Region

End Class
