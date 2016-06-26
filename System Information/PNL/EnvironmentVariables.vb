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
Imports System.Windows.Forms
Imports System.Collections
Imports System.Text
Imports System.IO

Public Class EnvironmentVariables
    Inherits SystemInformation.TaskPanelBase

    Private ResourceManager As New  _
        System.Resources.ResourceManager("SystemInformation.Resources", GetType(Processes).Assembly)

    Private Shared panelInstance As EnvironmentVariables

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As EnvironmentVariables
        If (panelInstance Is Nothing) Then
            panelInstance = New EnvironmentVariables()
        End If
        Return panelInstance
    End Function

#Region " Constants and Variables "

    ' Boolean used to toggle listview sort.
    Private _SelectedIndex As Integer
    Private _Info As New InformationClass

#End Region

#Region " EnvironmentVariables Events "

    Private Sub EnvironmentVariables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            ' Clear listview.
            ListViewVariables.Items.Clear()

            ' Add all of the environment variables to the listview.
            For Each variable As String In GetEnvironmentVariables.Keys
                ListViewVariables.Items.Add(variable)
            Next

            ' Sort the listview.
            ListViewVariables.Sorting = SortOrder.Ascending
            ListViewVariables.Sort()

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Environment Variables panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region " ListView Events "

    Private Sub ListViewProcesses_ItemSelectionChanged(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ListViewVariables.ItemSelectionChanged

        If e.IsSelected Then
            _SelectedIndex = e.ItemIndex
            LabelVariable.Text = "Expanded Variable: " & GetEnvironmentVariable(ListViewVariables.FocusedItem.Text)
        End If

    End Sub

#End Region

End Class
