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

Imports System
Imports System.IO
Imports System.Security
Imports System.Diagnostics
Imports System.Reflection
Imports System.ComponentModel
Imports Microsoft.Win32

Public Class StartupPrograms
    Inherits SystemInformation.TaskPanelBase

    Private _Info As New InformationClass
    Private _Native As New NativeMethods
    Private ResourceManager As New  _
        System.Resources.ResourceManager("SystemInformation.Resources", GetType(StartupPrograms).Assembly)

    Private Shared panelInstance As StartupPrograms

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As StartupPrograms
        If (panelInstance Is Nothing) Then
            panelInstance = New StartupPrograms()
        End If
        Return panelInstance
    End Function

#Region " Constants and Variables "

    Private Const _RunKey As String = "Software\Microsoft\Windows\CurrentVersion\Run"
    Private Const _WowRunKey As String = "Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Run"
    Private _AllUsersStartup As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\"
    Private _CurrentUserStartup As String = Environment.GetFolderPath(Environment.SpecialFolder.Programs) & _
        "\Startup\"
    Private i As Integer                ' Counter for registry startup entries.
    Private _Ascending As Boolean        ' Used to toggle listview sorting.

    ' Listview column constants.
    Private Enum ListCol
        ItemName = 0
        FileName = 1
        Type = 2
        Status = 3
        Command = 4
        Path = 5
    End Enum

    ' Shortcut type (location) constants.
    Private Const HKCU As String = "Registry This User"
    Private Const WHKCU As String = "Registry: x86 Current User"
    Private Const HKLM As String = "Registry All Users"
    Private Const WHKLM As String = "Registry: x86 All Users"
    Private Const StartupUser As String = "Startup This User"
    Private Const StartupAllUsers As String = "Startup All Users"

#End Region

#Region " Startup Events "

    Private Sub Startup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            ' Show the wait form.
            WaitForm.Show()
            Application.DoEvents()

            ' Image list and listview.
            ListViewStartup.Items.Clear()
            StartupImageList.Images.Clear()

            ' Get all startup programs in HHEY_CURRENT_USER
            DisplayRegistryStartupEntries(HKCU)

            If _Info.OSIs64Bit Then
                ' Get all startup programs in Wow6432Node.
                DisplayRegistryStartupEntries(WHKCU)
            End If

            ' Get all startup programs in HKEY_LOCAL_MACHINE
            DisplayRegistryStartupEntries(HKLM)

            If _Info.OSIs64Bit Then
                ' Get all startup programs in Wow6432Node.
                DisplayRegistryStartupEntries(WHKLM)
            End If

            ' Get all startup shortcuts and programs in the Current User's Startup Folder.
            DisplayStartupShortcuts(StartupUser)

            ' Get all startup shortcuts and programs in the All Users' Startup Folder.
            DisplayStartupShortcuts(StartupAllUsers)

            ' Close the wait form.
            WaitForm.Close()

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Startup panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region " ListView Events "

    Private Sub ListViewStartup_ItemSelectionChanged(ByVal sender As Object, _
        ByVal e As ListViewItemSelectionChangedEventArgs) Handles ListViewStartup.ItemSelectionChanged

        Try
            If e.IsSelected Then

                ' Get command and file path stored in listview.
                Dim command As String = ListViewStartup.Items(e.ItemIndex).SubItems(ListCol.ItemName).Text
                Dim filePath As String = ListViewStartup.Items(e.ItemIndex).SubItems(ListCol.Path).Text

                ' Display the file information.
                If filePath.Contains("cmd.exe") Then

                    ' Since this is a command window, we will not be able to resolve the properties.
                    LabelCompany.Text = ""
                    LabelProductName.Text = ""
                    LabelDescription.Text = ""
                    LabelFileVersion.Text = ""
                    LabelCommand.Text = command

                    ' Only display arguments for shortcuts.
                    LabelArgumentsDesc.Visible = False
                    LabelArguments.Visible = False
                    LabelArguments.Text = ""
                ElseIf Path.GetExtension(filePath) = ".lnk" Then
                    If File.Exists(filePath) Then
                        ' Resolve the shortcut.
                        Dim sc As New ShortcutClass(filePath)

                        ' Get the file version information.
                        Dim selectedFileVersionInfo As FileVersionInfo = _
                            FileVersionInfo.GetVersionInfo(sc.Path)

                        ' Display the properties of the resolved shortcut. 
                        LabelCompany.Text = selectedFileVersionInfo.CompanyName
                        LabelProductName.Text = selectedFileVersionInfo.ProductName
                        LabelDescription.Text = selectedFileVersionInfo.FileDescription
                        LabelFileVersion.Text = selectedFileVersionInfo.FileVersion
                        LabelCommand.Text = sc.Path

                        ' Display arguments for shortcuts, but only if present.
                        If String.IsNullOrEmpty(sc.Arguments) Then
                            LabelArgumentsDesc.Visible = False
                            LabelArguments.Visible = False
                        Else
                            LabelArgumentsDesc.Visible = True
                            LabelArguments.Visible = True
                            LabelArguments.Text = sc.Arguments
                        End If
                    Else
                        LabelCompany.Text = "File cannot be found"
                        LabelProductName.Text = ""
                        LabelDescription.Text = ""
                        LabelFileVersion.Text = ""
                        LabelCommand.Text = ""
                    End If
                Else
                    If File.Exists(filePath) Then
                        ' Get the file version information.
                        Dim selectedFileVersionInfo As FileVersionInfo = _
                            FileVersionInfo.GetVersionInfo(filePath)

                        ' Display the file properties.
                        LabelCompany.Text = selectedFileVersionInfo.CompanyName
                        LabelProductName.Text = selectedFileVersionInfo.ProductName
                        LabelDescription.Text = selectedFileVersionInfo.FileDescription
                        LabelFileVersion.Text = selectedFileVersionInfo.FileVersion
                        LabelCommand.Text = command

                        ' Only display arguments for shortcuts.
                        LabelArgumentsDesc.Visible = False
                        LabelArguments.Visible = False
                        LabelArguments.Text = ""
                    Else
                        LabelCompany.Text = "File cannot be found"
                        LabelProductName.Text = ""
                        LabelDescription.Text = ""
                        LabelFileVersion.Text = ""
                        LabelCommand.Text = ""
                    End If
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Startup panel ListView." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' Set the ListViewItemSorter property to a new ListViewItemComparer 
    ''' object. Setting this property immediately sorts the 
    ''' ListView using the ListViewItemComparer object.
    ''' </summary>
    Private Sub ListViewStartup_ColumnClick(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListViewStartup.ColumnClick

        ' Toggle sort order.
        If _Ascending = False Then
            _Ascending = True
        Else
            _Ascending = False
        End If

        ' Perform sort of items in specified column.
        ListViewStartup.ListViewItemSorter = New ListViewItemComparer(e.Column, _Ascending)

    End Sub

#End Region

#Region " Methods "

    Private Sub DisplayRegistryStartupEntries(ByVal hive As String)

        Dim value As String
        Dim command As String
        Dim filePath As String
        Dim disabled As Boolean
        Dim rk As RegistryKey = Nothing

        Try
            If hive = HKCU Then
                ' Get all startup programs in HKEY_CURRENT_USER.
                rk = Registry.CurrentUser.OpenSubKey(_RunKey)
            ElseIf hive = HKLM Then
                ' Get all startup programs in HKEY_LOCAL_MACHINE.
                rk = Registry.LocalMachine.OpenSubKey(_RunKey)
            ElseIf hive = WHKCU Then
                rk = Registry.CurrentUser.OpenSubKey(_WowRunKey)
            ElseIf hive = WHKLM Then
                rk = Registry.LocalMachine.OpenSubKey(_WowRunKey)
            End If

            ' Get all of the entries.
            For Each value In rk.GetValueNames()

                ' Reset disabled flag.
                disabled = False

                ' Save complete command to collection.
                command = rk.GetValue(value).ToString()

                ' Check if command is disabled (begins with a ":")
                If command.StartsWith(":") Then

                    ' Flag this entry as disabled.
                    disabled = True

                    ' Remove semicolon so that path command work and save file path.
                    filePath = ReturnFilePath(command.Remove(0, 1))

                Else
                    ' Save file path.
                    filePath = ReturnFilePath(command)

                End If

                ' Attempt to get application image (icon).
                If _Native.GetIcon(filePath) IsNot Nothing Then

                    ' Add the icon to the image list so that the listview can access it.
                    StartupImageList.Images.Add(_Native.GetIcon(filePath))

                Else
                    ' If there is no icon, just add a blank image from resources to keep the indexes proper.
                    StartupImageList.Images.Add(CType(ResourceManager.GetObject("Blank"), System.Drawing.Image))

                End If

                ' Add entry description to listview.
                ListViewStartup.Items.Add(value.ToString(), i)

                ' Add file name (without path) to listview.
                ListViewStartup.Items(i).SubItems.Add(Path.GetFileName(filePath))

                ' Add location (type) information to listview.
                If hive = HKCU Then
                    ListViewStartup.Items(i).SubItems.Add(HKCU)
                ElseIf hive = WHKCU Then
                    ListViewStartup.Items(i).SubItems.Add(WHKCU)
                ElseIf hive = HKLM Then
                    ListViewStartup.Items(i).SubItems.Add(HKLM)
                ElseIf hive = WHKLM Then
                    ListViewStartup.Items(i).SubItems.Add(WHKLM)
                End If

                ' Add status information.
                If disabled Then
                    ListViewStartup.Items(i).SubItems.Add("Disabled")
                Else
                    ListViewStartup.Items(i).SubItems.Add("Enabled")
                End If

                ' Add startup command.
                ListViewStartup.Items(i).SubItems.Add(command)

                ' Add file path.
                ListViewStartup.Items(i).SubItems.Add(filePath)

                i += 1

            Next
        Catch ex As NullReferenceException
            ' Ignore
        Finally
            If rk IsNot Nothing Then
                ' Close the registry key.
                rk.Close()
            End If
        End Try

    End Sub

    Private Sub DisplayStartupShortcuts(ByVal type As String)

        Dim disabled As Boolean
        Dim command As String
        Dim filePath As String
        Dim link As String
        Dim folder As String

        If type = StartupUser Then

            ' Current users startup folder.
            folder = Environment.GetFolderPath(Environment.SpecialFolder.Startup)

        Else

            ' All users startup folder.
            folder = Environment.ExpandEnvironmentVariables("%AllUsersProfile%") & _
                "\Start Menu\Programs\Startup"

        End If

        For Each link In Directory.GetFiles(folder, "*.*")

            ' Only process shortcuts or executible files.
            If Path.GetExtension(link) = ".lnk" Or Path.GetExtension(link) = ".exe" Then

                ' Reset disabled flag.
                disabled = False

                ' Save command.
                command = link

                ' Save file path.
                filePath = ReturnFilePath(command)

                ' Resolve the shortcut.
                Dim sc As New ShortcutClass(filePath)

                ' Attempt to get application image (icon).
                If sc.Icon IsNot Nothing Then

                    ' First try getting icon from shortcut.
                    StartupImageList.Images.Add(sc.Icon)

                ElseIf _Native.GetIcon(sc.Path) IsNot Nothing Then

                    ' Then try getting icon from the resolved path.
                    StartupImageList.Images.Add(_Native.GetIcon(sc.Path))
                Else

                    ' If both methods fail, display a blank icon.
                    StartupImageList.Images.Add(CType(ResourceManager.GetObject("Blank"), System.Drawing.Image))
                End If

                ' Add entry description to listview.
                ListViewStartup.Items.Add(Path.GetFileNameWithoutExtension(link), i) ' temporary

                ' Add file name (without path) to listview.
                ListViewStartup.Items(i).SubItems.Add(Path.GetFileName(filePath))

                ' Add type information to listview.
                If type = StartupUser Then
                    ListViewStartup.Items(i).SubItems.Add(StartupUser)
                Else
                    ListViewStartup.Items(i).SubItems.Add(StartupAllUsers)
                End If

                ' Add status information.
                If disabled Then
                    ListViewStartup.Items(i).SubItems.Add("Disabled")
                Else
                    ListViewStartup.Items(i).SubItems.Add("Enabled")
                End If

                ' Add startup command.
                ListViewStartup.Items(i).SubItems.Add(command)

                ' Add file path.
                ListViewStartup.Items(i).SubItems.Add(filePath)

                i += 1

            End If

        Next

    End Sub

    Private Shared Function ReturnFilePath(ByVal value As String) As String

        Try
            Dim p As Integer

            ' Check for quotes, and if present, remove them.
            If value.Contains(Chr(34)) Then
                value = value.Replace(Chr(34), "")
            End If

            ' Check for hyphens, and if present, return the part before first one.
            If value.Contains("-") Then
                p = value.IndexOf("-")
                value = value.Substring(0, p - 1)
            End If

            ' Check for forward slashes, and if present, return the part before first one.
            If value.Contains("/") Then
                p = value.IndexOf("/")
                value = value.Substring(0, p - 1)
            End If

            ' Check for a space followed by a percent sign, and if present, return the part before the first one.
            If value.Contains(" %") Then
                p = value.IndexOf(" %")
                value = value.Substring(0, p)
            End If

            If value <> "" Then
                Return Path.GetFullPath(value)
            Else
                Return ""
            End If

        Catch ex As Exception
            'MessageBox.Show("An error has occurred in the Startup panel ReturnFilePath method." & vbCrLf & _
            '    "The system returned the following information:" & vbCrLf & _
            '    "Source : " & ex.Source & vbCrLf & _
            '    "Description: " & ex.Message & vbCrLf & "Command: " & value, Application.ProductName, _
            '        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try

    End Function

#End Region

End Class
