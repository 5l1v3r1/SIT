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

Public Class Cpu
    Inherits SystemInformation.TaskPanelBase

    Private Shared panelInstance As Cpu

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As Cpu
        If (panelInstance Is Nothing) Then
            panelInstance = New Cpu()
        End If
        Return panelInstance
    End Function

    Private _Info As New InformationClass

#Region " Cpu Events "

    Private Sub Cpu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            ' Show wait form.
            WaitForm.Show()
            Application.DoEvents()

            ' Get Information
            _Info.Initialize(InformationClass.Initializers.GetCpuInfo)

            ' Fill in labels
            LabelAddressWidth.Text = _Info.CpuAddressWidth
            LabelDescription.Text = _Info.CpuDescription
            LabelFSBSpeed.Text = _Info.CpuFsbSpeed
            LabelL2CacheSize.Text = _Info.CpuL2CacheSize
            LabelL2CacheSpeed.Text = _Info.CpuL2CacheSpeed
            LabelManufacturer.Text = _Info.CpuManufacturer
            LabelName.Text = _Info.CpuName.Replace("  ", " ").Trim
            LabelProcessorSocket.Text = _Info.CpuSocket
            LabelProcessorSpeed.Text = _Info.CpuSpeed
            LabelProcessorId.Text = _Info.CpuProcessorId

            ' Fill in Power Management Info.
            If _Info.CpuPowerManagementSupported Then
                LabelPowerManagementSupported.Text = "Yes"
                LabelPowerManagementCapabilities.Visible = True
                LabelPowerManagementCapabilities.Text = _Info.CpuPowerManagementCapabilities
            Else
                LabelPowerManagementSupported.Text = "No"
                LabelPowerManagementCapabilities.Visible = False
                LabelPowerManagementCapabilities.Text = ""
            End If

            ' Beginning with Windows Vista, NumberOfCores and NumberOfLogicalProcessors are available.
            If _Info.OSMajorVersion > 5 Then
                LabelNumCoresDesc.Visible = True
                LabelNumCoresDesc.Text = "Number of CPU Cores:"
                LabelNumberCores.Text = _Info.CpuNumberOfCores.ToString
                LabelNumLogicalProcDesc.Visible = True
                LabelNumLogicalProc.Visible = True
                LabelNumLogicalProc.Text = _Info.CpuNumberOfLogicalProcessors.ToString
            Else
                LabelNumCoresDesc.Visible = True
                LabelNumCoresDesc.Text = "Number of Processors:"
                LabelNumberCores.Text = _Info.CpuNumberOfProcessors.ToString
                LabelNumLogicalProcDesc.Visible = False
                LabelNumLogicalProc.Visible = False
            End If

            ' Close the wait form.
            WaitForm.Close()

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Cpu panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
