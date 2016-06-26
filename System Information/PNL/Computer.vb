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

Imports System.Management

Public Class Computer
    Inherits SystemInformation.TaskPanelBase

    Private Shared panelInstance As Computer

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As Computer
        If (panelInstance Is Nothing) Then
            panelInstance = New Computer()
        End If
        Return panelInstance
    End Function

    Private _Info As New InformationClass

#Region " Computer Events "

    Private Sub Computer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            ' Show the wait form.
            WaitForm.Show()
            Application.DoEvents()

            ' Get Information
            _Info.Initialize(InformationClass.Initializers.GetNone)

            ' Fill in general informat5ion
            LabelCompManufacturer.Text = _Info.CompManufacturer
            LabelCompModel.Text = _Info.CompModel
            LabelMBManufacturer.Text = _Info.MainBoardManufacturer
            LabelMBModel.Text = _Info.MainBoardModel
            LabelDescription.Text = _Info.CompDescription
            LabelSystemType.Text = _Info.CompSystemType
            LabelBootupState.Text = _Info.OSBootupState
            LabelStartDateTime.Text = _Info.OSStartTime.ToShortDateString & " " & _Info.OSStartTime.ToLongTimeString

            ' Fill in Memory Information
            LabelTotalPhysical.Text = _Info.MemTotalPhysical
            LabelAvailablePhysical.Text = _Info.MemAvailPhysical
            LabelTotalVirtual.Text = _Info.MemTotalVirtual
            LabelAvailableVirtual.Text = _Info.MemAvailVirtual

            ' enable timer
            TimerTimeUp.Enabled = True

            ' Close the wait form.
            WaitForm.Close()

        Catch ex As Security.SecurityException
            MessageBox.Show("An error has occurred in the Computer panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        Catch exp As NullReferenceException
            MessageBox.Show("An error has occurred in the Computer panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & exp.Source & vbCrLf & _
                "Description: " & exp.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region " Timer Events "

    Private Sub TimerTimeUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles TimerTimeUp.Tick

        LabelUpTime.Text = _Info.OSUptime
    End Sub

#End Region

End Class
