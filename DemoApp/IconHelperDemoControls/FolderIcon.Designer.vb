<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolderIcon
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.ButtonOpenFolder = New System.Windows.Forms.Button()
		Me.PictureBoxSmallIcon = New System.Windows.Forms.PictureBox()
		Me.PictureBoxBigIcon = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBoxSmallIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBoxBigIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ButtonOpenFolder
		'
		Me.ButtonOpenFolder.Location = New System.Drawing.Point(12, 16)
		Me.ButtonOpenFolder.Name = "ButtonOpenFolder"
		Me.ButtonOpenFolder.Size = New System.Drawing.Size(268, 24)
		Me.ButtonOpenFolder.TabIndex = 0
		Me.ButtonOpenFolder.Text = "einen Ordner auswählen"
		Me.ButtonOpenFolder.UseVisualStyleBackColor = True
		'
		'PictureBoxSmallIcon
		'
		Me.PictureBoxSmallIcon.Location = New System.Drawing.Point(12, 52)
		Me.PictureBoxSmallIcon.Name = "PictureBoxSmallIcon"
		Me.PictureBoxSmallIcon.Size = New System.Drawing.Size(116, 100)
		Me.PictureBoxSmallIcon.TabIndex = 1
		Me.PictureBoxSmallIcon.TabStop = False
		'
		'PictureBoxBigIcon
		'
		Me.PictureBoxBigIcon.Location = New System.Drawing.Point(160, 52)
		Me.PictureBoxBigIcon.Name = "PictureBoxBigIcon"
		Me.PictureBoxBigIcon.Size = New System.Drawing.Size(116, 100)
		Me.PictureBoxBigIcon.TabIndex = 2
		Me.PictureBoxBigIcon.TabStop = False
		'
		'FolderIcon
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.PictureBoxBigIcon)
		Me.Controls.Add(Me.PictureBoxSmallIcon)
		Me.Controls.Add(Me.ButtonOpenFolder)
		Me.Name = "FolderIcon"
		Me.Size = New System.Drawing.Size(407, 242)
		CType(Me.PictureBoxSmallIcon, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBoxBigIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Private WithEvents ButtonOpenFolder As Button
	Private WithEvents PictureBoxSmallIcon As PictureBox
	Private WithEvents PictureBoxBigIcon As PictureBox
End Class
