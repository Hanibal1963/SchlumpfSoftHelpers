'
'****************************************************************************************************************
'DriveInfo.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'

Friend Class DriveInfo

    Private Const LogigDriveInfoBlock = "Laufwerk: {0}" & vbCrLf &
        "Laufwerksbezeichnung: {1}" & vbCrLf & "Komprimiert: {2}" & vbCrLf &
        "Dateisystem: {3}" & vbCrLf & "gesamter Speicherplatz: {4}" & vbCrLf &
        "freier Speicherplatz: {5}" & vbCrLf & "Volumebezeichnung: {6}" & vbCrLf &
        "Laufwerksart: {7}" & vbCrLf & "Netzwerkpfad: {8}" & vbCrLf & "Seriennummer: {9}"
    Private Const PhysicalDriveInfoBlock = "Laufwerk: {0}" & vbcrlf & "Modell: {1}" & vbCrLf & 
        "Interfacetyp: {2}" & vbCrLf & "Seriennummer: {3}" & vbCrLf & 
        "gesamter Speicherplatz: {4}"  & vbCrLf & "Anzahl der Partitionen: {5}"
    Private Const LogigDriveInfoText = "Informationen zu den Logischen Laufwerken:" & vbCrLf & "Anzahl der Laufwerke: {0}"
    Private Const PhysicalDriveInfoText = "Informationen zu den Physikalischen Laufwerken:" & vbCrLf & "Anzahl der Laufwerke: {0}"

    Private ReadOnly helper As New SchlumpfSoft.WmiHelper

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub ButtonDriveInfoLoad_Click(sender As Object, e As EventArgs) Handles ButtonDriveInfoLoad.Click

        Cursor = Cursors.WaitCursor

        'Physikalische Laufwerke durchlaufen
        Dim pysdricount As Integer = CInt(helper.GetPhysicalDriveInfo(SchlumpfSoft.WmiHelper.PhysicalDriveInfo.Count))
        Dim msgpysicaldrive As String = String.Format(PhysicalDriveInfoText, pysdricount.ToString)

        For i As Integer = 0 To pysdricount - 1
            msgpysicaldrive &= vbCrLf & vbCrLf & String.Format(PhysicalDriveInfoBlock,
                                New Object() {CStr(i + 1),
                                helper.GetPhysicalDriveInfo(SchlumpfSoft.WmiHelper.PhysicalDriveInfo.Model, i),
                                helper.GetPhysicalDriveInfo(SchlumpfSoft.WmiHelper.PhysicalDriveInfo.InterfaceType, i),
                                helper.GetPhysicalDriveInfo(SchlumpfSoft.WmiHelper.PhysicalDriveInfo.Serialnumber, i),
                                helper.GetPhysicalDriveInfo(SchlumpfSoft.WmiHelper.PhysicalDriveInfo.Size, i),
                                helper.GetPhysicalDriveInfo(SchlumpfSoft.WmiHelper.PhysicalDriveInfo.Partitions, i)
                                })

        Next

        LabelPysikalDrive.Text = msgpysicaldrive

        'Logische Laufwerke durchlaufen
        Dim logdricount As Integer = CInt(helper.GetLogigDriveInfo(SchlumpfSoft.WmiHelper.LogigDriveInfo.Count))
        Dim msglogigdrive As String = String.Format(LogigDriveInfoText, logdricount.ToString)

        For i As Integer = 0 To logdricount - 1

            msglogigdrive &= vbCrLf & vbCrLf & String.Format(LogigDriveInfoBlock,
                                New Object() {CStr(i + 1),
                                helper.GetLogigDriveInfo(SchlumpfSoft.WmiHelper.LogigDriveInfo.Name, i),
                                helper.GetLogigDriveInfo(SchlumpfSoft.WmiHelper.LogigDriveInfo.Compressed, i),
                                helper.GetLogigDriveInfo(SchlumpfSoft.WmiHelper.LogigDriveInfo.Filesystem, i),
                                helper.GetLogigDriveInfo(SchlumpfSoft.WmiHelper.LogigDriveInfo.Size, i),
                                helper.GetLogigDriveInfo(SchlumpfSoft.WmiHelper.LogigDriveInfo.Freespace, i),
                                helper.GetLogigDriveInfo(SchlumpfSoft.WmiHelper.LogigDriveInfo.Volumename, i),
                                helper.GetLogigDriveInfo(SchlumpfSoft.WmiHelper.LogigDriveInfo.Discreption, i),
                                helper.GetLogigDriveInfo(SchlumpfSoft.WmiHelper.LogigDriveInfo.Providername, i),
                                helper.GetLogigDriveInfo(SchlumpfSoft.WmiHelper.LogigDriveInfo.Volumeserialnumber, i)
                                })

        Next
        LabelLogigDrive.Text = msglogigdrive

        Cursor = Cursors.Default

    End Sub

End Class
