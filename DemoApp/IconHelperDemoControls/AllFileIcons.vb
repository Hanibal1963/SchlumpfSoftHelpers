'
'****************************************************************************************************************
'AllFileIcons.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************

Friend Class AllFileIcons

    Private Const ALLFILEICONSFILTER = "Symboldateien (*.exe,*.dll)|*exe;*.dll"
    Private ReadOnly helper As New SchlumpfSoft.IconHelper
    Private ReadOnly ofd As New OpenFileDialog
    Private pbx As PictureBox
    Private iconcount As Integer = 0

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        ofd.Title = "eine Datei mit Symbolen öffnen"
        ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System)
        ofd.Filter = ALLFILEICONSFILTER
        LabelIconCount.Text = iconcount.ToString

    End Sub

    Private Sub ButtonOpenFile_Click(sender As Object, e As EventArgs) Handles ButtonOpenFile.Click

        Dim result As DialogResult = ofd.ShowDialog()

        If result = DialogResult.OK Then

            iconcount = helper.GetIconCount(ofd.FileName)
            LabelIconCount.Text = iconcount.ToString

            For i As Integer = 0 To iconcount - 1

                pbx = New PictureBox With {
                    .SizeMode = PictureBoxSizeMode.AutoSize,
                    .Image = helper.ExtractIcon(ofd.FileName, i, SchlumpfSoft.IconHelper.IconSizes.x16)
                }

                FlowLayoutPanel.Controls.Add(pbx)

                pbx = New PictureBox With {
                    .SizeMode = PictureBoxSizeMode.AutoSize,
                    .Image = helper.ExtractIcon(ofd.FileName, i, SchlumpfSoft.IconHelper.IconSizes.x32)
                }

                FlowLayoutPanel.Controls.Add(pbx)

            Next

        Else

            FlowLayoutPanel.Controls.Clear()

        End If

    End Sub

End Class
