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

Imports System.Environment

Public Class SpecialFolders
    Inherits SystemInformation.TaskPanelBase

    Private Shared panelInstance As SpecialFolders

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As SpecialFolders
        If (panelInstance Is Nothing) Then
            panelInstance = New SpecialFolders()
        End If
        Return panelInstance
    End Function

    Private _Info As New InformationClass

#Region " Special Folders Events "

    Private Sub SpecialFolders_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            ' Allow panel to paint.
            Application.DoEvents()

            ' Clear listview
            ListViewFolders.Items.Clear()

            ' Fill in Listview
            ListViewFolders.Items.Add(SpecialFolder.ApplicationData.ToString)
            ListViewFolders.Items(0).SubItems.Add(GetFolderPath(SpecialFolder.ApplicationData))
            ListViewFolders.Items.Add(SpecialFolder.CommonApplicationData.ToString)
            ListViewFolders.Items(1).SubItems.Add(GetFolderPath(SpecialFolder.CommonApplicationData))
            ListViewFolders.Items.Add(SpecialFolder.CommonProgramFiles.ToString)
            ListViewFolders.Items(2).SubItems.Add(GetFolderPath(SpecialFolder.CommonProgramFiles))
            ListViewFolders.Items.Add(SpecialFolder.Cookies.ToString)
            ListViewFolders.Items(3).SubItems.Add(GetFolderPath(SpecialFolder.Cookies))
            ListViewFolders.Items.Add(SpecialFolder.Desktop.ToString)
            ListViewFolders.Items(4).SubItems.Add(GetFolderPath(SpecialFolder.Desktop))
            ListViewFolders.Items.Add(SpecialFolder.DesktopDirectory.ToString)
            ListViewFolders.Items(5).SubItems.Add(GetFolderPath(SpecialFolder.DesktopDirectory))
            ListViewFolders.Items.Add(SpecialFolder.Favorites.ToString)
            ListViewFolders.Items(6).SubItems.Add(GetFolderPath(SpecialFolder.Favorites))
            ListViewFolders.Items.Add(SpecialFolder.History.ToString)
            ListViewFolders.Items(7).SubItems.Add(GetFolderPath(SpecialFolder.History))
            ListViewFolders.Items.Add(SpecialFolder.InternetCache.ToString)
            ListViewFolders.Items(8).SubItems.Add(GetFolderPath(SpecialFolder.InternetCache))
            ListViewFolders.Items.Add(SpecialFolder.LocalApplicationData.ToString)
            ListViewFolders.Items(9).SubItems.Add(GetFolderPath(SpecialFolder.LocalApplicationData))
            ListViewFolders.Items.Add(SpecialFolder.MyComputer.ToString)
            ListViewFolders.Items(10).SubItems.Add(GetFolderPath(SpecialFolder.MyComputer))
            ListViewFolders.Items.Add(SpecialFolder.MyDocuments.ToString)
            ListViewFolders.Items(11).SubItems.Add(GetFolderPath(SpecialFolder.MyDocuments))
            ListViewFolders.Items.Add(SpecialFolder.MyMusic.ToString)
            ListViewFolders.Items(12).SubItems.Add(GetFolderPath(SpecialFolder.MyMusic))
            ListViewFolders.Items.Add(SpecialFolder.MyPictures.ToString)
            ListViewFolders.Items(13).SubItems.Add(GetFolderPath(SpecialFolder.MyPictures))
            ListViewFolders.Items.Add(SpecialFolder.Personal.ToString)
            ListViewFolders.Items(14).SubItems.Add(GetFolderPath(SpecialFolder.Personal))
            ListViewFolders.Items.Add(SpecialFolder.ProgramFiles.ToString)
            ListViewFolders.Items(15).SubItems.Add(GetFolderPath(SpecialFolder.ProgramFiles))
            ListViewFolders.Items.Add(SpecialFolder.Programs.ToString)
            ListViewFolders.Items(16).SubItems.Add(GetFolderPath(SpecialFolder.Programs))
            ListViewFolders.Items.Add(SpecialFolder.Recent.ToString)
            ListViewFolders.Items(17).SubItems.Add(GetFolderPath(SpecialFolder.Recent))
            ListViewFolders.Items.Add(SpecialFolder.SendTo.ToString)
            ListViewFolders.Items(18).SubItems.Add(GetFolderPath(SpecialFolder.SendTo))
            ListViewFolders.Items.Add(SpecialFolder.StartMenu.ToString)
            ListViewFolders.Items(19).SubItems.Add(GetFolderPath(SpecialFolder.StartMenu))
            ListViewFolders.Items.Add(SpecialFolder.Startup.ToString)
            ListViewFolders.Items(20).SubItems.Add(GetFolderPath(SpecialFolder.Startup))
            ListViewFolders.Items.Add(SpecialFolder.System.ToString)
            ListViewFolders.Items(21).SubItems.Add(GetFolderPath(SpecialFolder.System))
            ListViewFolders.Items.Add(SpecialFolder.Templates.ToString)
            ListViewFolders.Items(22).SubItems.Add(GetFolderPath(SpecialFolder.Templates))

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Special Folders panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region " Listview Events "

    Private Sub ListViewFolders_ItemSelectionChanged(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) _
        Handles ListViewFolders.ItemSelectionChanged

        If e.IsSelected Then

            ' Copy path to clipboard.
            Dim folder As String = ListViewFolders.Items(e.ItemIndex).SubItems(1).Text
            Clipboard.SetText(folder, TextDataFormat.Text)

        End If

    End Sub

#End Region

End Class
