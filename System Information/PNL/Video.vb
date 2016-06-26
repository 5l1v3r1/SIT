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

Public Class Video
    Inherits SystemInformation.TaskPanelBase

    Private Shared panelInstance As Video

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As Video
        If (panelInstance Is Nothing) Then
            panelInstance = New Video()
        End If
        Return panelInstance
    End Function

    Private _Info As New InformationClass

#Region " Video Events "

    Private Sub Video_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            ' Allow panel to paint.
            Application.DoEvents()

            Dim X As Integer

            ' Get information.
            _Info.Initialize(InformationClass.Initializers.GetVideoInfo)

            ' Display number of adaptors
            LabelNumberControllers.Text = "Number of Video Controllers: " & _
                _Info.VidNumberOfControllers.ToString

            ' Display dimensions
            If _Info.VidNumberOfControllers > 0 Then
                LabelScreenDimensions1.Text = "Primary Screen Dimensions: " & _
                    _Info.VidPrimaryScreenDimensions
                LabelScreenWorkingArea1.Text = "Primary Screen Working Area: " & _
                    _Info.VidPrimaryScreenWorkingArea
            End If

            ' Clear listview
            ListViewAdaptors.Items.Clear()

            ' Add information to listview
            If _Info.VidNumberOfControllers > 0 Then
                For X = 0 To _Info.VidNumberOfControllers - 1

                    Try
                        ListViewAdaptors.Items.Add("Video Controller: " & _
                            _Info.VidController.Item(X).ToString)
                    Catch
                        ListViewAdaptors.Items.Add("Video Controller: N/A")
                    End Try

                    Try
                        ListViewAdaptors.Items.Add("Number of Colors: " & _
                            _Info.VidScreenColors.Item(X).ToString)
                    Catch
                        ListViewAdaptors.Items.Add("Number of Colors: N/A")
                    End Try

                    Try
                        ListViewAdaptors.Items.Add("Refresh Rate: " & _
                            _Info.VidRefreshRate.Item(X).ToString)
                    Catch
                        ListViewAdaptors.Items.Add("Refresh Rate: N/A")
                    End Try

                    Try
                        ListViewAdaptors.Items.Add("Video RAM: " & _
                            _Info.VidRam.Item(X).ToString)
                    Catch
                        ListViewAdaptors.Items.Add("Video RAM: N/A")
                    End Try

                    ' Add blank line between adaptors
                    ListViewAdaptors.Items.Add("")
                Next

            End If

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Video panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
