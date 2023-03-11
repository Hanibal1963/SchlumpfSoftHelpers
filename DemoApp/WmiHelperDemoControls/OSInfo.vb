'
'****************************************************************************************************************
'OSInfo.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'

Friend Class OSInfo

    Private Const OSInfoText = "Gefundene Informationen über das Betriebssystem:" & vbCrLf & 
        "Name: {0}" & vbCrLf & "Version: {1}" & vbCrLf & "Buildnummer: {2}" & vbCrLf & 
        "Seriennummer: {3}" & vbCrLf & "Architektur: {4}"

    Private ReadOnly helper As New SchlumpfSoft.WmiHelper

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub ButtonOsInfoLoad_Click(sender As Object, e As EventArgs) Handles ButtonOsInfoLoad.Click

        Label.Text = String.Format(OSInfoText, New Object() {
                                   helper.GetSystemInfo(SchlumpfSoft.WmiHelper.SystemInfo.Name),
                                   helper.GetSystemInfo(SchlumpfSoft.WmiHelper.SystemInfo.Version),
                                   helper.GetSystemInfo(SchlumpfSoft.WmiHelper.SystemInfo.BuildNumber),
                                   helper.GetSystemInfo(SchlumpfSoft.WmiHelper.SystemInfo.SerialNumber),
                                   helper.GetSystemInfo(SchlumpfSoft.WmiHelper.SystemInfo.Architecture)})

    End Sub

End Class
