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

Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Public Class Drives
    Inherits SystemInformation.TaskPanelBase

    Private Shared panelInstance As Drives

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As Drives
        If (panelInstance Is Nothing) Then
            panelInstance = New Drives()
        End If
        Return panelInstance
    End Function

    Private _Info As New InformationClass

#Region " Drives Events "

    Private Sub Drives_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            Dim X As Integer
            Dim Y As Integer
            Dim index As Integer

            ' Show the wait form.
            WaitForm.Show()
            Application.DoEvents()

            ' Get Information
            _Info.Initialize(InformationClass.Initializers.GetDriveInformation)
            _Info.Initialize(InformationClass.Initializers.GetVolumeInfo)

            ' Clear ListViews
            ListViewVolumes.Items.Clear()
            ListViewDrives.Items.Clear()

            ' Fill Volume ListView
            If _Info.VolumeLetter IsNot Nothing Then
                For X = 0 To _Info.VolumeLetter.Count - 1
                    ' Get image list index for drive type
                    index = ReturnImageIndex(_Info.VolumeType.Item(X))
                    ListViewVolumes.Items.Add(_Info.VolumeLetter.Item(X), index)

                    If _Info.VolumeLabel IsNot Nothing Then
                        ListViewVolumes.Items(X).SubItems.Add(_Info.VolumeLabel.Item(X))
                    Else
                        ListViewVolumes.Items(X).SubItems.Add("N/A")
                    End If

                    If _Info.VolumeFileSystem IsNot Nothing Then
                        ListViewVolumes.Items(X).SubItems.Add(_Info.VolumeFileSystem.Item(X))
                    Else
                        ListViewVolumes.Items(X).SubItems.Add("N/A")
                    End If

                    If _Info.VolumeTotalSize IsNot Nothing Then
                        ListViewVolumes.Items(X).SubItems.Add(_Info.VolumeTotalSize.Item(X))
                    Else
                        ListViewVolumes.Items(X).SubItems.Add("N/A")
                    End If

                    If _Info.VolumeUsedSpace IsNot Nothing Then
                        ListViewVolumes.Items(X).SubItems.Add(_Info.VolumeUsedSpace.Item(X))
                    Else
                        ListViewVolumes.Items(X).SubItems.Add("N/A")
                    End If

                    If _Info.VolumeFreeSpace IsNot Nothing Then
                        ListViewVolumes.Items(X).SubItems.Add(_Info.VolumeFreeSpace.Item(X))
                    Else
                        ListViewVolumes.Items(X).SubItems.Add("N/A")
                    End If

                    If _Info.VolumePercentFreeSpace IsNot Nothing Then
                        ListViewVolumes.Items(X).SubItems.Add(_Info.VolumePercentFreeSpace.Item(X))
                    Else
                        ListViewVolumes.Items(X).SubItems.Add("N/A")
                    End If

                    If _Info.VolumeReady IsNot Nothing Then
                        If CBool(_Info.VolumeReady.Item(X)) = True Then
                            ListViewVolumes.Items(X).SubItems.Add("Y")
                        Else
                            ListViewVolumes.Items(X).SubItems.Add("N")
                        End If
                    Else
                        ListViewVolumes.Items(X).SubItems.Add("U")
                    End If

                Next X
            Else
                ListViewVolumes.Items.Add("")
                ListViewVolumes.Items(0).SubItems.Add("None")
            End If

            ' Add physical hard drive information
            If _Info.DriveCapacity IsNot Nothing Then
                For X = 0 To _Info.DriveCapacity.Count - 1

                    If _Info.DriveInterface.Item(X).ToString().ToUpper().Contains("USB") Then
                        ' If the drive model includes "USB" use USB image.
                        ListViewDrives.Items.Add(CStr(X), 4)
                    Else
                        ' Otherwise use hard drive image.
                        ListViewDrives.Items.Add(CStr(X), 1)
                    End If

                    If _Info.DriveInterface(X) <> "" Then
                        ListViewDrives.Items(X).SubItems.Add(_Info.DriveInterface.Item(X))
                    Else
                        ListViewDrives.Items(X).SubItems.Add("N/A")
                    End If

                    If _Info.DriveCapacity(X) <> "" Then
                        ListViewDrives.Items(X).SubItems.Add(_Info.DriveCapacity.Item(X))
                    Else
                        ListViewDrives.Items(X).SubItems.Add("N/A")
                    End If

                    If _Info.DriveModelNo(X) <> "" Then
                        ListViewDrives.Items(X).SubItems.Add(_Info.DriveModelNo.Item(X))
                    Else
                        ListViewDrives.Items(X).SubItems.Add("N/A")
                    End If

                    If _Info.DriveStatus(X) <> "" Then
                        ListViewDrives.Items(X).SubItems.Add(_Info.DriveStatus.Item(X))
                    Else
                        ListViewDrives.Items(X).SubItems.Add("")
                    End If

                Next
            Else
                ListViewDrives.Items.Add("")
                ListViewDrives.Items(0).SubItems.Add("Not Available")
            End If

            ' Add CDROM drive information to the end of hard drives
            If _Info.CDDrive IsNot Nothing Then
                For Y = 0 To _Info.CDDrive.Count - 1

                    ListViewDrives.Items.Add(CStr(Y + X), 3)

                    ' Drive type (interface) is undefined for CD drives.
                    ListViewDrives.Items(Y + X).SubItems.Add("")

                    If _Info.CDMediaSize(Y) <> "" Then
                        ListViewDrives.Items(Y + X).SubItems.Add(_Info.CDMediaSize.Item(Y))
                    Else
                        ListViewDrives.Items(Y + X).SubItems.Add("")
                    End If

                    If _Info.CDModel(Y) <> "" Then
                        ListViewDrives.Items(Y + X).SubItems.Add(_Info.CDModel.Item(Y))
                    Else
                        ListViewDrives.Items(Y + X).SubItems.Add("N/A")
                    End If

                    If _Info.CDStatus(Y) <> "" Then
                        ListViewDrives.Items(Y + X).SubItems.Add(_Info.CDStatus.Item(Y))
                    Else
                        ListViewDrives.Items(Y + X).SubItems.Add("N/A")
                    End If

                Next
            End If

            ' Close the wait form.
            WaitForm.Close()

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Drives panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region " Methods "

    ''' <summary>
    ''' Returns an integer that identifies the drive image in the image list.
    ''' </summary>
    Private Shared Function ReturnImageIndex(ByVal strDriveType As String) As Integer

        Select Case strDriveType.ToLower
            Case "removable"
                Return 0
            Case "fixed"
                Return 1
            Case "network"
                Return 2
            Case "cdrom"
                Return 3
            Case "usb"
                Return 4
            Case Else
                Return 5
        End Select

    End Function

#End Region

End Class
