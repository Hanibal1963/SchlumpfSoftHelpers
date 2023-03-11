'
'****************************************************************************************************************
'ImageConvert.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'

Friend Class ImageConvert

    Private Const BASE64FILTER = "Base64 Codedateien (*.b64)|*.b64"
    Private Const IMAGEFILTER = "Bilddateien (*.bmp,*.jpg,*.gif,*.png)|*.bmp;*.jpg;*.gif;*.png"
    Private Const HTMLCONTENT = "<!DOCTYPE html>
                                    <html lang='de' xmlns='http://www.w3.org/1999/xhtml'>
                                    <head>
                                    <meta charset='utf-8' />
                                    <title></title>
                                    </head>
                                    <body>{0}</body>
                                    </html>"

    Private ReadOnly ofd As New OpenFileDialog
    Private ReadOnly sfd As New SaveFileDialog
    Private ReadOnly helper As New SchlumpfSoft.Base64Helper

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        WebView.Source = New Uri("http://localhost")

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) _
        Handles ButtonLoadImage.Click, ButtonSaveAsBase64.Click, ButtonLoadBase64Code.Click, ButtonLoadImageAsHtml.Click

        Select Case True
            Case sender Is ButtonLoadImage : LoadImage()
            Case sender Is ButtonLoadBase64Code : LoadCode()
            Case sender Is ButtonSaveAsBase64 : SaveCode()
            Case sender Is ButtonLoadImageAsHtml : ShowAsHtml()
        End Select

    End Sub

    Private Sub ShowAsHtml()

        If IsNothing(PictureBox.Image) Then Exit Sub

        Dim htmlcode As String = String.Format(HTMLCONTENT, helper.ImageToHtml(PictureBox.Image, 30))

        WebView.NavigateToString(htmlcode)

    End Sub

    Private Sub SaveCode()

        If IsNothing(PictureBox.Image) Then Exit Sub

        Dim filename As String

        With sfd

            .Title = "Base64-Code speichern"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .Filter = BASE64FILTER
            If .ShowDialog = DialogResult.OK Then filename = .FileName Else Exit Sub

        End With

        IO.File.WriteAllText(filename, helper.ImageToBase64(PictureBox.Image))
        filename = String.Empty

    End Sub

    Private Sub LoadCode()

        PictureBox.Image = Nothing

        Dim filename As String

        With ofd

            .Title = "Base64 Code laden"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            ofd.Filter = BASE64FILTER
            If .ShowDialog = DialogResult.OK Then filename = .FileName Else Exit Sub

        End With

        PictureBox.Image = helper.ImageFromBase64(IO.File.ReadAllText(filename))
        filename = String.Empty

    End Sub

    Private Sub LoadImage()

        Dim filename As String

        With ofd

            .Title = "Bild laden"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            .Filter = IMAGEFILTER

            If .ShowDialog = DialogResult.OK Then filename = .FileName Else Exit Sub

        End With

        PictureBox.Image = Image.FromFile(filename)
        filename = String.Empty

    End Sub

End Class
