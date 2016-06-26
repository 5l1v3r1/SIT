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

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Collections
Imports System.Diagnostics
Imports System.Threading
Imports System
Imports System.Text
Imports System.IO

Public Class Processes
    Inherits SystemInformation.TaskPanelBase

    Private ResourceManager As New  _
        System.Resources.ResourceManager("SystemInformation.Resources", GetType(Processes).Assembly)

    Private Shared panelInstance As Processes

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As Processes
        If (panelInstance Is Nothing) Then
            panelInstance = New Processes()
        End If
        Return panelInstance
    End Function

#Region " Constants and Variables "

    ' Boolean used to toggle listview sort.
    Private _Ascending As Boolean
    Private _SelectedIndex As Integer
    Private _Info As New InformationClass

#End Region

#Region " Processes Events "

    Private Sub Processes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            ' Clear listview.
            ListViewProcesses.Items.Clear()

            '' Add services info to listview.
            Dim allProcesses() As Diagnostics.Process = Diagnostics.Process.GetProcesses()

            Try
                For Each proc As Diagnostics.Process In allProcesses
                    Try
                        Dim lItem As ListViewItem = ListViewProcesses.Items.Add(proc.ProcessName)
                        lItem.SubItems.Add(proc.Id.ToString)
                        lItem.SubItems.Add(proc.Threads.Count.ToString)
                        Dim processPriority As String = "Normal"
                        Select Case proc.BasePriority
                            Case 13
                                processPriority = "High"
                            Case 4
                                processPriority = "Idle"
                            Case 8
                                processPriority = "Normal"
                            Case 24
                                processPriority = "Real Time"
                        End Select
                        lItem.SubItems.Add(processPriority)
                        lItem.SubItems.Add(FormatBytes(proc.PrivateMemorySize64))
                        lItem.SubItems.Add(proc.StartTime.ToShortTimeString)
                    Catch ex As Exception
                        ' Ignore
                    End Try
                Next
            Catch ex As Exception
                ' Access error: ignore.
            End Try

            ' Indicate number of processes.
            LabelTotalProcesses.Text = "Total Processes: " & allProcesses.Length.ToString("#,#")

            ' Sort the listview.
            ListViewProcesses.Sorting = SortOrder.Ascending
            ListViewProcesses.Sort()

            ' Close the wait form.
            'WaitForm.Close()

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Processes panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region " ListView Events "

    ''' <summary>
    ''' Set the ListViewItemSorter property to a new ListViewItemComparer 
    ''' object. Setting this property immediately sorts the 
    ''' ListView using the ListViewItemComparer object.
    ''' </summary>
    Private Sub ListViewProcesses_ColumnClick(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListViewProcesses.ColumnClick

        ' Toggle sort order.
        If _Ascending = False Then
            _Ascending = True
        Else
            _Ascending = False
        End If

        ' Perform sort of items in specified column.
        ListViewProcesses.ListViewItemSorter = New ListViewItemComparer(e.Column, _Ascending)

    End Sub

    Private Sub ListViewProcesses_ItemSelectionChanged(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ListViewProcesses.ItemSelectionChanged

        If e.IsSelected Then
            _SelectedIndex = e.ItemIndex
        End If

    End Sub

#End Region

#Region " Menu Events "

    Private Sub MenuEndProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MenuEndProcess.Click

        Dim processId As String = ListViewProcesses.Items(_SelectedIndex).SubItems(1).Text

        Diagnostics.Process.GetProcessById(CInt(processId), _Info.OSMachineName).Kill()

        ListViewProcesses.Items(_SelectedIndex).Remove()

    End Sub

#End Region

#Region " Private Methods "

    Private Shared Function FormatBytes(ByVal bytes As Double) As String
        Dim temp As Double

        If bytes >= 1024 And bytes <= 1073741823 Then
            temp = bytes / 1024 ' KB
            Return String.Format("{0:N0}", temp) & " KB"
        ElseIf bytes = 0 And bytes <= 1023 Then
            temp = bytes    ' bytes
            Return String.Format("{0:N0}", bytes) & " bytes"
        Else
            Return ""
        End If

    End Function

#End Region

End Class
