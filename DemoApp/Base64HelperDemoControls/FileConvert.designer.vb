<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileConvert
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.ButtonOpenFile = New System.Windows.Forms.Button()
		Me.ButtonSaveAsBase64 = New System.Windows.Forms.Button()
		Me.ButtonLoadBase64 = New System.Windows.Forms.Button()
		Me.ButtonSaveAsFile = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'ButtonOpenFile
		'
		Me.ButtonOpenFile.Location = New System.Drawing.Point(8, 8)
		Me.ButtonOpenFile.Name = "ButtonOpenFile"
		Me.ButtonOpenFile.Size = New System.Drawing.Size(168, 23)
		Me.ButtonOpenFile.TabIndex = 3
		Me.ButtonOpenFile.Text = "beliebige Datei öffnen ..."
		Me.ButtonOpenFile.UseVisualStyleBackColor = True
		'
		'ButtonSaveAsBase64
		'
		Me.ButtonSaveAsBase64.Location = New System.Drawing.Point(8, 40)
		Me.ButtonSaveAsBase64.Name = "ButtonSaveAsBase64"
		Me.ButtonSaveAsBase64.Size = New System.Drawing.Size(168, 23)
		Me.ButtonSaveAsBase64.TabIndex = 2
		Me.ButtonSaveAsBase64.Text = "als Base64 Code speichern ..."
		Me.ButtonSaveAsBase64.UseVisualStyleBackColor = True
		'
		'ButtonLoadBase64
		'
		Me.ButtonLoadBase64.Location = New System.Drawing.Point(8, 72)
		Me.ButtonLoadBase64.Name = "ButtonLoadBase64"
		Me.ButtonLoadBase64.Size = New System.Drawing.Size(168, 23)
		Me.ButtonLoadBase64.TabIndex = 1
		Me.ButtonLoadBase64.Text = "Base64 Code laden ..."
		Me.ButtonLoadBase64.UseVisualStyleBackColor = True
		'
		'ButtonSaveAsFile
		'
		Me.ButtonSaveAsFile.Location = New System.Drawing.Point(8, 104)
		Me.ButtonSaveAsFile.Name = "ButtonSaveAsFile"
		Me.ButtonSaveAsFile.Size = New System.Drawing.Size(168, 23)
		Me.ButtonSaveAsFile.TabIndex = 0
		Me.ButtonSaveAsFile.Text = "als beliebige Datei speichern ..."
		Me.ButtonSaveAsFile.UseVisualStyleBackColor = True
		'
		'FileConvert
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.ButtonSaveAsFile)
		Me.Controls.Add(Me.ButtonLoadBase64)
		Me.Controls.Add(Me.ButtonSaveAsBase64)
		Me.Controls.Add(Me.ButtonOpenFile)
		Me.Name = "FileConvert"
		Me.Size = New System.Drawing.Size(361, 285)
		Me.ResumeLayout(False)

	End Sub

	Private WithEvents ButtonOpenFile As Button
    Private WithEvents ButtonSaveAsBase64 As Button
    Private WithEvents ButtonLoadBase64 As Button
    Private WithEvents ButtonSaveAsFile As Button
End Class
