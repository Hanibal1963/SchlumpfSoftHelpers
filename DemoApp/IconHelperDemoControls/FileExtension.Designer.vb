<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileExtension
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
		Dim Label1 As System.Windows.Forms.Label
		Me.TextBoxFileExt = New System.Windows.Forms.TextBox()
		Me.ButtonFileExt = New System.Windows.Forms.Button()
		Me.PictureBoxSmallIcon = New System.Windows.Forms.PictureBox()
		Me.PictureBoxBigIcon = New System.Windows.Forms.PictureBox()
		Label1 = New System.Windows.Forms.Label()
		CType(Me.PictureBoxSmallIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBoxBigIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Label1.AutoSize = True
		Label1.Location = New System.Drawing.Point(12, 16)
		Label1.Name = "Label1"
		Label1.Size = New System.Drawing.Size(352, 13)
		Label1.TabIndex = 0
		Label1.Text = "Bitte eine Dateierweiterung eingeben (mit vorangestelltem Punkt z.B: .txt):"
		'
		'TextBoxFileExt
		'
		Me.TextBoxFileExt.Location = New System.Drawing.Point(12, 36)
		Me.TextBoxFileExt.Name = "TextBoxFileExt"
		Me.TextBoxFileExt.Size = New System.Drawing.Size(352, 20)
		Me.TextBoxFileExt.TabIndex = 1
		'
		'ButtonFileExt
		'
		Me.ButtonFileExt.Location = New System.Drawing.Point(12, 68)
		Me.ButtonFileExt.Name = "ButtonFileExt"
		Me.ButtonFileExt.Size = New System.Drawing.Size(356, 24)
		Me.ButtonFileExt.TabIndex = 2
		Me.ButtonFileExt.Text = "Symbol für dies Erweiterung anzeigen"
		Me.ButtonFileExt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
		Me.ButtonFileExt.UseVisualStyleBackColor = True
		'
		'PictureBoxSmallIcon
		'
		Me.PictureBoxSmallIcon.Location = New System.Drawing.Point(12, 108)
		Me.PictureBoxSmallIcon.Name = "PictureBoxSmallIcon"
		Me.PictureBoxSmallIcon.Size = New System.Drawing.Size(128, 124)
		Me.PictureBoxSmallIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.PictureBoxSmallIcon.TabIndex = 3
		Me.PictureBoxSmallIcon.TabStop = False
		'
		'PictureBoxBigIcon
		'
		Me.PictureBoxBigIcon.Location = New System.Drawing.Point(168, 108)
		Me.PictureBoxBigIcon.Name = "PictureBoxBigIcon"
		Me.PictureBoxBigIcon.Size = New System.Drawing.Size(128, 124)
		Me.PictureBoxBigIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.PictureBoxBigIcon.TabIndex = 4
		Me.PictureBoxBigIcon.TabStop = False
		'
		'FileExtension
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.PictureBoxBigIcon)
		Me.Controls.Add(Me.PictureBoxSmallIcon)
		Me.Controls.Add(Me.ButtonFileExt)
		Me.Controls.Add(Me.TextBoxFileExt)
		Me.Controls.Add(Label1)
		Me.Name = "FileExtension"
		Me.Size = New System.Drawing.Size(499, 301)
		CType(Me.PictureBoxSmallIcon, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBoxBigIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents TextBoxFileExt As TextBox
	Private WithEvents ButtonFileExt As Button
	Private WithEvents PictureBoxSmallIcon As PictureBox
	Private WithEvents PictureBoxBigIcon As PictureBox
End Class
