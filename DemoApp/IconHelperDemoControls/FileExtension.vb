'
'****************************************************************************************************************
'FileExtension.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'

Friend Class FileExtension

    Private ReadOnly helper As New SchlumpfSoft.IconHelper

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        TextBoxFileExt.Text = String.Empty
        PictureBoxSmallIcon.Image = Nothing

    End Sub

    Private Sub ButtonFileExt_Click(sender As Object, e As EventArgs) Handles ButtonFileExt.Click

        PictureBoxSmallIcon.Image = helper.GetIconImage(TextBoxFileExt.Text, SchlumpfSoft.IconHelper.IconSizes.x16)
        PictureBoxBigIcon.Image = helper.GetIconImage(TextBoxFileExt.Text, SchlumpfSoft.IconHelper.IconSizes.x32)

    End Sub

    Private Sub TextBoxFileExt_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFileExt.TextChanged

        PictureBoxSmallIcon.Image = Nothing

    End Sub

End Class
