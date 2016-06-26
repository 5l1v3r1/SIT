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

Imports System.IO

Public Class Introduction
    Inherits SystemInformation.TaskPanelBase

    Private Shared panelInstance As Introduction

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As Introduction
        If (panelInstance Is Nothing) Then
            panelInstance = New Introduction()
        End If
        Return panelInstance
    End Function

    Private _Info As New InformationClass

#Region " Link Labels "

    Private Sub LinkLabelEULA_LinkClicked(ByVal sender As System.Object, _
        ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelEULA.LinkClicked

        If File.Exists(_Info.AppDirectory & "\EULA.pdf") Then
            Try
                ' Now display EULA
                Dim startInfo As New  _
                    ProcessStartInfo(_Info.AppDirectory & "\EULA.pdf")
                startInfo.WindowStyle = ProcessWindowStyle.Normal
                Process.Start(startInfo)
            Catch ex As IOException
                ' cannot find file
                MessageBox.Show("Adobe Reader cannot be found.", Application.ProductName, _
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            ' cannot find file
            MessageBox.Show("The EULA.pdf file cannot be found.", Application.ProductName, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

#End Region

#Region " Introduction Events "

    Private Sub Introduction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            ' Allow panel to paint.
            Application.DoEvents()

            Dim build As String

            LabelAppCopyright.Text = _Info.AppCopyright
            LabelAppDescription.Text = _Info.AppDescription
            If _Info.AppBuild = "0" Or String.IsNullOrEmpty(_Info.AppBuild) Then
                build = ""
            Else
                build = " Build " & _Info.AppBuild
            End If
            LabelAppVersion.Text = "Version " & _Info.AppShortVersion & _
                build
            LabelCustomerName.Text = _Info.UserRegisteredName
            LabelCustomerOrganization.Text = _Info.UserRegisteredOrganization
            LabelTitleCompany.Text = _Info.AppTitle & " is a product of " & _
                _Info.AppCompanyName

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Introduction panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
