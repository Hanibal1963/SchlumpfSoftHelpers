'
'****************************************************************************************************************
'FileConvert.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'

Friend Class FileConvert

    Private Const ALLFILESFILTER = "alle Dateien (*.*)|*.*"
    Private Const BASE64FILTER = "Base64 Codedateien (*.b64)|*.b64"

    Private ReadOnly ofd As New OpenFileDialog
    Private ReadOnly sfd As New SaveFileDialog
    Private ReadOnly helper As New SchlumpfSoft.Base64Helper

    Private filename As String
    Private base64code As String

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) _
        Handles ButtonOpenFile.Click, ButtonSaveAsFile.Click,
                ButtonSaveAsBase64.Click, ButtonLoadBase64.Click

        Select Case True

            Case sender Is ButtonOpenFile : OpenFile()
            Case sender Is ButtonSaveAsBase64 : SaveAsBase64()
            Case sender Is ButtonLoadBase64 : LoadBase64()
            Case sender Is ButtonSaveAsFile : SaveAsFile()

        End Select

    End Sub

    Private Sub SaveAsFile()

        With sfd

            .FileName = Nothing
            .Title = "beliebige Datei speichern"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .Filter = ALLFILESFILTER
            If .ShowDialog = DialogResult.OK Then filename = .FileName Else Exit Sub
            filename = .FileName

        End With

        helper.FileFromBase64(base64code, filename)
        filename = Nothing

    End Sub

    Private Sub LoadBase64()

        With ofd

            .FileName = Nothing
            .Title = "Base64 Code laden"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .Filter = BASE64FILTER
            If .ShowDialog = DialogResult.OK Then filename = .FileName Else Exit Sub
            filename = .FileName

        End With

        base64code = IO.File.ReadAllText(filename)
        filename = Nothing

    End Sub

    Private Sub SaveAsBase64()

        With sfd

            .FileName = Nothing
            .Title = "Base64 Code speichern"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .Filter = BASE64FILTER
            If .ShowDialog = DialogResult.OK Then filename = .FileName Else Exit Sub
            filename = .FileName

        End With

        IO.File.WriteAllText(filename, base64code)
        filename = Nothing

    End Sub

    Private Sub OpenFile()

        With ofd

            .FileName = Nothing
            .Title = "beliebige Datei öffnen"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .Filter = ALLFILESFILTER
            If .ShowDialog = DialogResult.OK Then filename = .FileName Else Exit Sub
            filename = .FileName

        End With

        base64code = helper.FileToBase64(filename)
        filename = Nothing

    End Sub

End Class
