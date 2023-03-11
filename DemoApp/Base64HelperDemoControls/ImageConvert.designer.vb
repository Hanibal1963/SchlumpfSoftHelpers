<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImageConvert
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
		Dim SplitContainer As System.Windows.Forms.SplitContainer
		Me.PictureBox = New System.Windows.Forms.PictureBox()
		Me.ButtonLoadBase64Code = New System.Windows.Forms.Button()
		Me.ButtonLoadImage = New System.Windows.Forms.Button()
		Me.ButtonSaveAsBase64 = New System.Windows.Forms.Button()
		Me.WebView = New Microsoft.Web.WebView2.WinForms.WebView2()
		Me.ButtonLoadImageAsHtml = New System.Windows.Forms.Button()
		SplitContainer = New System.Windows.Forms.SplitContainer()
		CType(SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
		SplitContainer.Panel1.SuspendLayout()
		SplitContainer.Panel2.SuspendLayout()
		SplitContainer.SuspendLayout()
		CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WebView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SplitContainer
		'
		SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
		SplitContainer.Location = New System.Drawing.Point(0, 0)
		SplitContainer.Name = "SplitContainer"
		'
		'SplitContainer.Panel1
		'
		SplitContainer.Panel1.Controls.Add(Me.PictureBox)
		SplitContainer.Panel1.Controls.Add(Me.ButtonLoadBase64Code)
		SplitContainer.Panel1.Controls.Add(Me.ButtonLoadImage)
		SplitContainer.Panel1.Controls.Add(Me.ButtonSaveAsBase64)
		'
		'SplitContainer.Panel2
		'
		SplitContainer.Panel2.Controls.Add(Me.WebView)
		SplitContainer.Panel2.Controls.Add(Me.ButtonLoadImageAsHtml)
		SplitContainer.Size = New System.Drawing.Size(575, 400)
		SplitContainer.SplitterDistance = 279
		SplitContainer.TabIndex = 3
		'
		'PictureBox
		'
		Me.PictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox.Location = New System.Drawing.Point(8, 40)
		Me.PictureBox.Name = "PictureBox"
		Me.PictureBox.Size = New System.Drawing.Size(260, 320)
		Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox.TabIndex = 2
		Me.PictureBox.TabStop = False
		'
		'ButtonLoadBase64Code
		'
		Me.ButtonLoadBase64Code.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonLoadBase64Code.Location = New System.Drawing.Point(144, 8)
		Me.ButtonLoadBase64Code.Name = "ButtonLoadBase64Code"
		Me.ButtonLoadBase64Code.Size = New System.Drawing.Size(124, 23)
		Me.ButtonLoadBase64Code.TabIndex = 0
		Me.ButtonLoadBase64Code.Text = "lade Code ..."
		Me.ButtonLoadBase64Code.UseVisualStyleBackColor = True
		'
		'ButtonLoadImage
		'
		Me.ButtonLoadImage.Location = New System.Drawing.Point(8, 8)
		Me.ButtonLoadImage.Name = "ButtonLoadImage"
		Me.ButtonLoadImage.Size = New System.Drawing.Size(124, 24)
		Me.ButtonLoadImage.TabIndex = 0
		Me.ButtonLoadImage.Text = "lade Bild ..."
		Me.ButtonLoadImage.UseVisualStyleBackColor = True
		'
		'ButtonSaveAsBase64
		'
		Me.ButtonSaveAsBase64.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonSaveAsBase64.Location = New System.Drawing.Point(8, 368)
		Me.ButtonSaveAsBase64.Name = "ButtonSaveAsBase64"
		Me.ButtonSaveAsBase64.Size = New System.Drawing.Size(260, 23)
		Me.ButtonSaveAsBase64.TabIndex = 1
		Me.ButtonSaveAsBase64.Text = "speichere Base64 Code als Datei ..."
		Me.ButtonSaveAsBase64.UseVisualStyleBackColor = True
		'
		'WebView
		'
		Me.WebView.AllowExternalDrop = True
		Me.WebView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.WebView.CreationProperties = Nothing
		Me.WebView.DefaultBackgroundColor = System.Drawing.Color.White
		Me.WebView.Location = New System.Drawing.Point(8, 40)
		Me.WebView.Name = "WebView"
		Me.WebView.Size = New System.Drawing.Size(272, 348)
		Me.WebView.TabIndex = 1
		Me.WebView.ZoomFactor = 1.0R
		'
		'ButtonLoadImageAsHtml
		'
		Me.ButtonLoadImageAsHtml.Location = New System.Drawing.Point(8, 8)
		Me.ButtonLoadImageAsHtml.Name = "ButtonLoadImageAsHtml"
		Me.ButtonLoadImageAsHtml.Size = New System.Drawing.Size(276, 24)
		Me.ButtonLoadImageAsHtml.TabIndex = 0
		Me.ButtonLoadImageAsHtml.Text = "Zeige Bild als Html"
		Me.ButtonLoadImageAsHtml.UseVisualStyleBackColor = True
		'
		'ImageConvert
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(SplitContainer)
		Me.Name = "ImageConvert"
		Me.Size = New System.Drawing.Size(575, 400)
		SplitContainer.Panel1.ResumeLayout(False)
		SplitContainer.Panel2.ResumeLayout(False)
		CType(SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
		SplitContainer.ResumeLayout(False)
		CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WebView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Private WithEvents ButtonLoadImage As Button
	Private WithEvents PictureBox As PictureBox
	Private WithEvents ButtonSaveAsBase64 As Button
	Private WithEvents ButtonLoadBase64Code As Button
	Private WithEvents ButtonLoadImageAsHtml As Button
	Private WithEvents WebView As Microsoft.Web.WebView2.WinForms.WebView2
End Class
