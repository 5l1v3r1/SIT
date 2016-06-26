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

Public Class Sound
    Inherits SystemInformation.TaskPanelBase

    Private Shared panelInstance As Sound

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As Sound
        If (panelInstance Is Nothing) Then
            panelInstance = New Sound()
        End If
        Return panelInstance
    End Function

    Private _Info As New InformationClass

#Region " Sound Events "

    Private Sub Sound_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            ' Allow panel to paint.
            Application.DoEvents()

            Dim X As Integer

            ' Get information.
            _Info.Initialize(InformationClass.Initializers.GetSoundInfo)

            ' Display number of controllers
            LabelNumberControllers.Text = "Number of Sound Controllers: " & _
                _Info.SndNumberOfControllers.ToString

            ' Display controller detail
            If _Info.SndNumberOfControllers > 0 Then
                For X = 0 To _Info.SndNumberOfControllers - 1

                    Try
                        ListViewAdaptors.Items.Add("Manfacturer: " & _
                            _Info.SndManufacturer.Item(X).ToString)
                    Catch
                        ListViewAdaptors.Items.Add("Manfacturer: N/A")
                    End Try

                    Try
                        ListViewAdaptors.Items.Add("Controller: " & _
                            _Info.SndController.Item(X).ToString)
                    Catch
                        ListViewAdaptors.Items.Add("Controller: N/A")
                    End Try

                    Try
                        ListViewAdaptors.Items.Add("DMA Buffer Size: " & _
                            _Info.SndDmaBufferSize.Item(X).ToString)
                    Catch
                        ListViewAdaptors.Items.Add("DMA Buffer Size: N/A")
                    End Try

                    ' Add blank line between adaptors
                    ListViewAdaptors.Items.Add("")
                Next
            End If

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Sound panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
