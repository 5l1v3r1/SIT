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

Public Class Network
    Inherits SystemInformation.TaskPanelBase

    Private Shared panelInstance As Network

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As Network
        If (panelInstance Is Nothing) Then
            panelInstance = New Network()
        End If
        Return panelInstance
    End Function

    Private _Info As New InformationClass

#Region " Network Events "

    Private Sub Network_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            Dim i As Integer

            ' Show the wait form.
            WaitForm.Show()
            Application.DoEvents()

            ' Get Information
            _Info.Initialize(InformationClass.Initializers.GetNetAdaptorInfo)
            _Info.Initialize(InformationClass.Initializers.GetNetInterfaceInfo)

            ' Check if network is configured
            If _Info.NetNumberOfAdapters = 0 Then
                LabelNetworkID.Text = "No network Is configured on this computer."
                ListViewInterface.Enabled = False
                ListViewInterface.Visible = False
                Exit Sub
            Else
                If _Info.OSPartOfDomain = True Then
                    LabelNetworkID.Text = "Domain: " & _Info.OSDomain _
                        & " Computer: " & _Info.OSMachineName
                Else
                    LabelNetworkID.Text = "Workgroup: " & _Info.OSDomain _
                        & " Computer: " & _Info.OSMachineName
                End If

                ' Clear combobox.
                ComboBoxInterface.Items.Clear()

                ' Add interface descriptions.
                For i = 0 To _Info.NetNumberOfAdapters - 1
                    ComboBoxInterface.Items.Add(_Info.NetProductName(i))
                Next

                ' Clear listview.
                ListViewInterface.Items.Clear()

                ' Select first item.
                ComboBoxInterface.SelectedIndex = 0

            End If

            ' Close the wait form.
            WaitForm.Close()

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Network panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region " ComboBox Events "

    Private Sub ComboBoxInterface_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ComboBoxInterface.SelectedIndexChanged

        Try
            ListViewInterface.Items.Clear()

            Dim i As Integer = ComboBoxInterface.SelectedIndex

            If _Info.NetManufacturer.Item(i) <> "N/A" Then

                ListViewInterface.Items.Add("Manufacturer: " & _Info.NetManufacturer.Item(i))

            End If

            If _Info.NetAdapterType.Item(i) <> "N/A" Then

                ListViewInterface.Items.Add("Adaptor Type: " & _Info.NetAdapterType.Item(i))

            End If

            If _Info.NetAutoSense.Item(i) <> "N/A" Then

                ListViewInterface.Items.Add("Auto Sense: " & _Info.NetAutoSense.Item(i))

            End If

            If _Info.NetMaxSpeed.Item(i) <> "N/A" Then

                ListViewInterface.Items.Add("Maximum Speed: " & _Info.NetMaxSpeed.Item(i))

            End If

            If _Info.NetSpeed.Item(i) <> "N/A" Then

                ListViewInterface.Items.Add("Speed: " & _Info.NetSpeed.Item(i))

            End If

            If _Info.NetConnectionId.Item(i) <> "N/A" Then

                ListViewInterface.Items.Add("Connection ID: " & _Info.NetConnectionId.Item(i))

            End If

            If _Info.NetConnectionStatus.Item(i) <> "N/A" Then

                ListViewInterface.Items.Add("Connection Status: " & _Info.NetConnectionStatus.Item(i))

            End If

            If _Info.NetMacAddress.Item(i) <> "N/A" Then

                ListViewInterface.Items.Add("MAC Address: " & _Info.NetMacAddress.Item(i))

            End If

            If _Info.NetIPEnabled.Item(i) = True Then

                If _Info.NetIPAddress.Item(i) <> "N/A" Then

                    ListViewInterface.Items.Add("IP Address: " & _Info.NetIPAddress.Item(i))

                End If

                If _Info.NetHostName.Item(i) <> "N/A" Then

                    ListViewInterface.Items.Add("DNS Host Name: " & _Info.NetHostName.Item(i))

                End If

                If _Info.NetDomain.Item(i) <> "N/A" Then

                    ListViewInterface.Items.Add("DNS Domain: " & _Info.NetDomain.Item(i))

                End If

                If _Info.NetTcpNumConnections.Item(i) <> "N/A" Then

                    ListViewInterface.Items.Add("Number of Connections: " & _Info.NetTcpNumConnections.Item(i))

                End If

                If _Info.NetDefaultTtl.Item(i) <> "N/A" Then

                    ListViewInterface.Items.Add("Default Time-to-Live (TTL): " & _Info.NetDefaultTtl.Item(i))

                End If

                If _Info.NetMtu.Item(i) <> "N/A" Then

                    ListViewInterface.Items.Add("Maximum Transmission Unit (MTU): " & _Info.NetMtu.Item(i))

                End If

                If _Info.NetTcpWindowSize.Item(i) <> "N/A" Then

                    ListViewInterface.Items.Add("TCP Window Size: " & _Info.NetTcpWindowSize.Item(i))

                End If

            End If

            If _Info.NetDhcpEnabled.Item(i) = True Then

                If _Info.NetDhcpLeaseObtained.Item(i) <> "N/A" Then

                    ListViewInterface.Items.Add("DHCP Lease Obtained: " & _Info.NetDhcpLeaseObtained.Item(i))

                End If

                If _Info.NetDhcpLeaseExpires.Item(i) <> "N/A" Then

                    ListViewInterface.Items.Add("DHCP Lease Expires: " & _Info.NetDhcpLeaseExpires.Item(i))

                End If

                If _Info.NetDhcpServer.Item(i) <> "N/A" Then

                    ListViewInterface.Items.Add("DHCP Server: " & _Info.NetDhcpServer.Item(i))

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Network panel ComboBox." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
