'
'****************************************************************************************************************
'FolderIcon.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'

Friend Class FolderIcon

    Private ReadOnly helper As New SchlumpfSoft.IconHelper
    Private ReadOnly fbd As New FolderBrowserDialog

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub ButtonOpenFolder_Click(sender As Object, e As EventArgs) Handles ButtonOpenFolder.Click

        Dim result As DialogResult = fbd.ShowDialog()
        If result = DialogResult.OK Then

            PictureBoxSmallIcon.Image = helper.GetIconImage(fbd.SelectedPath, SchlumpfSoft.IconHelper.IconSizes.x16)
            PictureBoxBigIcon.Image = helper.GetIconImage(fbd.SelectedPath, SchlumpfSoft.IconHelper.IconSizes.x32)

        Else

            PictureBoxSmallIcon.Image = Nothing
            PictureBoxBigIcon.Image = Nothing

        End If

    End Sub

End Class
