'
'****************************************************************************************************************
'MainboardInfo.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'

Friend Class MainboardInfo

    Private Const MainboardInfotext = "Gefundene Informationen über das Mainboard:" & vbCrLf & 
        "Hersteller: {0}"   & vbCrLf & "Bezeichnung: {1}" & vbCrLf & "Version: {2}" & vbCrLf & 
        "Seriennummer: {3}"

    Private ReadOnly helper As New SchlumpfSoft.WmiHelper

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub ButtonMainboardInfosLoad_Click(sender As Object, e As EventArgs) Handles ButtonMainboardInfosLoad.Click

        Label.Text = String.Format(MainboardInfotext, New Object() {
                                   helper.GetMainboardInfo(SchlumpfSoft.WmiHelper.BoardInfo.Manufacturer),
                                   helper.GetMainboardInfo(SchlumpfSoft.WmiHelper.BoardInfo.Product),
                                   helper.GetMainboardInfo(SchlumpfSoft.WmiHelper.BoardInfo.Version),
                                   helper.GetMainboardInfo(SchlumpfSoft.WmiHelper.BoardInfo.SerialNumber)})

    End Sub

End Class
