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

Public Class VisualStyles
    Inherits SystemInformation.TaskPanelBase

    Private Shared panelInstance As VisualStyles

    ''' <summary>
    ''' Create a global instance of this panel
    ''' </summary>>
    Public Shared Function CreateInstance() As VisualStyles
        If (panelInstance Is Nothing) Then
            panelInstance = New VisualStyles()
        End If
        Return panelInstance
    End Function

    Private _Info As New InformationClass

#Region " Visual Styles Events "

    Private Sub VisualStyles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            ' Allow panel to paint.
            Application.DoEvents()

            ' Modify header label
            If _Info.VstIsEnabledByUser = False Then
                LabelCurrentVisualStyle.Text = "Visual Styles Are Not Enabled By The User"
                LabelAuthor.Visible = False
                LabelAuthorDesc.Visible = False
                LabelCntrlHiLiteHotDesc.Visible = False
                PictureBoxControlHighlightHot.Visible = False
                LabelColorScheme.Visible = False
                LabelColorSchemeDesc.Visible = False
                LabelCompany.Visible = False
                LabelColorSchemeDesc.Visible = False
                LabelCompany.Visible = False
                LabelCompanyDesc.Visible = False
                LabelCopyright.Visible = False
                LabelCopyrightDesc.Visible = False
                LabelCurrentVisualStyle.Visible = False
                LabelDescription.Visible = False
                LabelDescriptionDesc.Visible = False
                LabelDisplayName.Visible = False
                LabelDisplayNameDesc.Visible = False
                LabelMinColorDepDesc.Visible = False
                LabelMinimumColorDepth.Visible = False
                LabelTextCtrlBrdrDesc.Visible = False
                PictureBoxTextControlBorder.Visible = False
                LabelVersionDesc.Visible = False
                LabelVersion.Visible = False
                LabelEnabeUserDesc.Visible = True
                LabelIsEnabledByUser.Visible = True
                LabelIsSupportedByOS.Visible = True
                LabelSuportOSDesc.Visible = True
            ElseIf _Info.VstIsSupportedByOS = False Then
                LabelCurrentVisualStyle.Text = "Visual Styles Are Disabled Or Not Supported"
                LabelAuthor.Visible = False
                LabelAuthorDesc.Visible = False
                LabelCntrlHiLiteHotDesc.Visible = False
                PictureBoxControlHighlightHot.Visible = False
                LabelColorScheme.Visible = False
                LabelColorSchemeDesc.Visible = False
                LabelCompany.Visible = False
                LabelColorSchemeDesc.Visible = False
                LabelCompany.Visible = False
                LabelCompanyDesc.Visible = False
                LabelCopyright.Visible = False
                LabelCopyrightDesc.Visible = False
                LabelCurrentVisualStyle.Visible = False
                LabelDescription.Visible = False
                LabelDescriptionDesc.Visible = False
                LabelDisplayName.Visible = False
                LabelDisplayNameDesc.Visible = False
                LabelMinColorDepDesc.Visible = False
                LabelMinimumColorDepth.Visible = False
                LabelTextCtrlBrdrDesc.Visible = False
                PictureBoxTextControlBorder.Visible = False
                LabelVersionDesc.Visible = False
                LabelVersion.Visible = False
                LabelEnabeUserDesc.Visible = True
                LabelIsEnabledByUser.Visible = True
                LabelIsSupportedByOS.Visible = True
                LabelSuportOSDesc.Visible = True
            Else
                LabelCurrentVisualStyle.Text = "Current Visual Styles"
            End If

            ' Fill in labels
            LabelCompany.Text = _Info.VstCompany
            LabelCopyright.Text = _Info.VstCopyright
            LabelAuthor.Text = _Info.VstAuthor
            LabelVersion.Text = _Info.VstVersion
            LabelDisplayName.Text = _Info.VstDisplayName
            LabelDescription.Text = _Info.VstDescription
            LabelColorScheme.Text = _Info.VstColorScheme
            LabelIsEnabledByUser.Text = _Info.VstIsEnabledByUser.ToString
            LabelIsSupportedByOS.Text = _Info.VstIsSupportedByOS.ToString
            LabelMinimumColorDepth.Text = _Info.VstMinimumColorDepth.ToString
            PictureBoxControlHighlightHot.BackColor = _Info.VstControlHighlightHot
            PictureBoxTextControlBorder.BackColor = _Info.VstTextControlBorder

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the CPU panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
