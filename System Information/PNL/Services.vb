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

Public Class Services
    Inherits SystemInformation.TaskPanelBase

    Private _Info As New InformationClass
    Private ResourceManager As New  _
        System.Resources.ResourceManager("SystemInformation.Resources", GetType(Services).Assembly)

    Private Shared panelInstance As Services

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As Services
        If (panelInstance Is Nothing) Then
            panelInstance = New Services()
        End If
        Return panelInstance
    End Function

#Region " Constants and Variables "

    ' Listview column constants.
    Private Enum ListCol
        DisplayName = 0
        StartMode = 1
        State = 2
        PathName = 3
        Description = 4
    End Enum

    ' Boolean used to toggle listview sort.
    Dim _Ascending As Boolean

#End Region

#Region " Services Events "

    Private Sub Services_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Dim i As Integer = 0
            Dim displayName As String

            ' Display the wait form.
            WaitForm.Show()
            Application.DoEvents()

            ' Get services info.
            _Info.Initialize(InformationClass.Initializers.GetAll)

            ' Clear listview.
            ListViewServices.Items.Clear()

            ' Add services info to listview.
            For Each displayName In _Info.ServiceDisplayName

                ListViewServices.Items.Add(_Info.ServiceDisplayName(i))
                ListViewServices.Items(i).SubItems.Add(_Info.ServiceStartMode(i))
                ListViewServices.Items(i).SubItems.Add(_Info.ServiceState(i))
                ListViewServices.Items(i).SubItems.Add(_Info.ServicePathName(i))
                ListViewServices.Items(i).SubItems.Add(_Info.ServiceDescription(i))

                i += 1

            Next

            ' Sort the listview.
            ListViewServices.Sorting = SortOrder.Ascending
            ListViewServices.Sort()

            ' Close the wait form.
            WaitForm.Close()

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Services panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region " ListView Events "

    Private Sub ListViewServices_ItemSelectionChanged(ByVal sender As Object, _
        ByVal e As ListViewItemSelectionChangedEventArgs) Handles ListViewServices.ItemSelectionChanged

        Try
            If e.IsSelected Then

                ' Display path and description.
                TextBoxPathName.Text = ListViewServices.Items(e.ItemIndex).SubItems(ListCol.PathName).Text
                TextBoxDescription.Text = ListViewServices.Items(e.ItemIndex).SubItems(ListCol.Description).Text

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
    Private Sub ListViewServices_ColumnClick(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListViewServices.ColumnClick

        ' Toggle sort order.
        If _Ascending = False Then
            _Ascending = True
        Else
            _Ascending = False
        End If

        ' Perform sort of items in specified column.
        ListViewServices.ListViewItemSorter = New ListViewItemComparer(e.Column, _Ascending)

    End Sub

#End Region

End Class
