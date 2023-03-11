'
'****************************************************************************************************************
'StringConvert.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'

Friend Class StringConvert

    Private ReadOnly helper As New SchlumpfSoft.Base64Helper

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) _
        Handles ButtonConvertToBase64.Click, ButtonConvertToText.Click

        Select Case True
            Case sender Is ButtonConvertToBase64 : ConvertToBase64
            Case sender Is ButtonConvertToText : ConvertToText
        End Select

    End Sub

    Private Sub ConvertToText()

        If String.IsNullOrEmpty(TextBoxBase64Output.Text) Then : Exit Sub : End If
        LabelTextOutput.Text = Helper.StringFromBase64(TextBoxBase64Output.Text)

    End Sub

    Private Sub ConvertToBase64()

        If String.IsNullOrEmpty(TextBoxInput.Text) Then : Exit Sub : End If
        TextBoxBase64Output.Text = Helper.StringToBase64(TextBoxInput.Text)

    End Sub

End Class
