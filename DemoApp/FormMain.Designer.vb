<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
	Inherits System.Windows.Forms.Form

	'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
		Dim TabControl As System.Windows.Forms.TabControl
		Dim TabPage1 As System.Windows.Forms.TabPage
		Dim TabControlBase64Demo As System.Windows.Forms.TabControl
		Dim TabPage5 As System.Windows.Forms.TabPage
		Dim StringConvert As DemoApp.StringConvert
		Dim TabPage6 As System.Windows.Forms.TabPage
		Dim ImageConvert As DemoApp.ImageConvert
		Dim TabPage7 As System.Windows.Forms.TabPage
		Dim FileConvert As DemoApp.FileConvert
		Dim TabPage2 As System.Windows.Forms.TabPage
		Dim TabControlIconHelperDemo As System.Windows.Forms.TabControl
		Dim TabPage8 As System.Windows.Forms.TabPage
		Dim FolderIcon As DemoApp.FolderIcon
		Dim TabPage9 As System.Windows.Forms.TabPage
		Dim FileExtension As DemoApp.FileExtension
		Dim TabPage10 As System.Windows.Forms.TabPage
		Dim AllFileIcons As DemoApp.AllFileIcons
		Dim TabPage3 As System.Windows.Forms.TabPage
		Dim TabControlWmiHelperDemo As System.Windows.Forms.TabControl
		Dim TabPage11 As System.Windows.Forms.TabPage
		Dim DriveInfo As DemoApp.DriveInfo
		Dim TabPage12 As System.Windows.Forms.TabPage
		Dim TabPage4 As System.Windows.Forms.TabPage
		Dim MainboardInfo As DemoApp.MainboardInfo
		Dim TabPage13 As System.Windows.Forms.TabPage
		Dim OsInfo As DemoApp.OSInfo
		TabControl = New System.Windows.Forms.TabControl()
		TabPage1 = New System.Windows.Forms.TabPage()
		TabControlBase64Demo = New System.Windows.Forms.TabControl()
		TabPage5 = New System.Windows.Forms.TabPage()
		StringConvert = New DemoApp.StringConvert()
		TabPage6 = New System.Windows.Forms.TabPage()
		ImageConvert = New DemoApp.ImageConvert()
		TabPage7 = New System.Windows.Forms.TabPage()
		FileConvert = New DemoApp.FileConvert()
		TabPage2 = New System.Windows.Forms.TabPage()
		TabControlIconHelperDemo = New System.Windows.Forms.TabControl()
		TabPage8 = New System.Windows.Forms.TabPage()
		FolderIcon = New DemoApp.FolderIcon()
		TabPage9 = New System.Windows.Forms.TabPage()
		FileExtension = New DemoApp.FileExtension()
		TabPage10 = New System.Windows.Forms.TabPage()
		AllFileIcons = New DemoApp.AllFileIcons()
		TabPage3 = New System.Windows.Forms.TabPage()
		TabControlWmiHelperDemo = New System.Windows.Forms.TabControl()
		TabPage11 = New System.Windows.Forms.TabPage()
		DriveInfo = New DemoApp.DriveInfo()
		TabPage12 = New System.Windows.Forms.TabPage()
		TabPage4 = New System.Windows.Forms.TabPage()
		MainboardInfo = New DemoApp.MainboardInfo()
		TabPage13 = New System.Windows.Forms.TabPage()
		OsInfo = New DemoApp.OSInfo()
		TabControl.SuspendLayout()
		TabPage1.SuspendLayout()
		TabControlBase64Demo.SuspendLayout()
		TabPage5.SuspendLayout()
		TabPage6.SuspendLayout()
		TabPage7.SuspendLayout()
		TabPage2.SuspendLayout()
		TabControlIconHelperDemo.SuspendLayout()
		TabPage8.SuspendLayout()
		TabPage9.SuspendLayout()
		TabPage10.SuspendLayout()
		TabPage3.SuspendLayout()
		TabControlWmiHelperDemo.SuspendLayout()
		TabPage11.SuspendLayout()
		TabPage12.SuspendLayout()
		TabPage13.SuspendLayout()
		Me.SuspendLayout()
		'
		'TabControl
		'
		TabControl.Controls.Add(TabPage1)
		TabControl.Controls.Add(TabPage2)
		TabControl.Controls.Add(TabPage3)
		TabControl.Controls.Add(TabPage4)
		TabControl.Dock = System.Windows.Forms.DockStyle.Fill
		TabControl.Location = New System.Drawing.Point(0, 0)
		TabControl.Name = "TabControl"
		TabControl.SelectedIndex = 0
		TabControl.Size = New System.Drawing.Size(737, 487)
		TabControl.TabIndex = 0
		'
		'TabPage1
		'
		TabPage1.Controls.Add(TabControlBase64Demo)
		TabPage1.Location = New System.Drawing.Point(4, 22)
		TabPage1.Name = "TabPage1"
		TabPage1.Padding = New System.Windows.Forms.Padding(3)
		TabPage1.Size = New System.Drawing.Size(729, 461)
		TabPage1.TabIndex = 0
		TabPage1.Text = "Base64Helper Demo"
		TabPage1.UseVisualStyleBackColor = True
		'
		'TabControlBase64Demo
		'
		TabControlBase64Demo.Controls.Add(TabPage5)
		TabControlBase64Demo.Controls.Add(TabPage6)
		TabControlBase64Demo.Controls.Add(TabPage7)
		TabControlBase64Demo.Dock = System.Windows.Forms.DockStyle.Fill
		TabControlBase64Demo.Location = New System.Drawing.Point(3, 3)
		TabControlBase64Demo.Name = "TabControlBase64Demo"
		TabControlBase64Demo.SelectedIndex = 0
		TabControlBase64Demo.Size = New System.Drawing.Size(723, 455)
		TabControlBase64Demo.TabIndex = 0
		'
		'TabPage5
		'
		TabPage5.Controls.Add(StringConvert)
		TabPage5.Location = New System.Drawing.Point(4, 22)
		TabPage5.Name = "TabPage5"
		TabPage5.Padding = New System.Windows.Forms.Padding(3)
		TabPage5.Size = New System.Drawing.Size(715, 429)
		TabPage5.TabIndex = 0
		TabPage5.Text = "Text konvertieren"
		TabPage5.UseVisualStyleBackColor = True
		'
		'StringConvert
		'
		StringConvert.Dock = System.Windows.Forms.DockStyle.Fill
		StringConvert.Location = New System.Drawing.Point(3, 3)
		StringConvert.Name = "StringConvert"
		StringConvert.Size = New System.Drawing.Size(709, 423)
		StringConvert.TabIndex = 0
		'
		'TabPage6
		'
		TabPage6.Controls.Add(ImageConvert)
		TabPage6.Location = New System.Drawing.Point(4, 22)
		TabPage6.Name = "TabPage6"
		TabPage6.Padding = New System.Windows.Forms.Padding(3)
		TabPage6.Size = New System.Drawing.Size(715, 429)
		TabPage6.TabIndex = 1
		TabPage6.Text = "Bild konvertieren"
		TabPage6.UseVisualStyleBackColor = True
		'
		'ImageConvert
		'
		ImageConvert.Dock = System.Windows.Forms.DockStyle.Fill
		ImageConvert.Location = New System.Drawing.Point(3, 3)
		ImageConvert.Name = "ImageConvert"
		ImageConvert.Size = New System.Drawing.Size(709, 423)
		ImageConvert.TabIndex = 0
		'
		'TabPage7
		'
		TabPage7.Controls.Add(FileConvert)
		TabPage7.Location = New System.Drawing.Point(4, 22)
		TabPage7.Name = "TabPage7"
		TabPage7.Padding = New System.Windows.Forms.Padding(3)
		TabPage7.Size = New System.Drawing.Size(715, 429)
		TabPage7.TabIndex = 2
		TabPage7.Text = "beliebige Datei konvertieren"
		TabPage7.UseVisualStyleBackColor = True
		'
		'FileConvert
		'
		FileConvert.Dock = System.Windows.Forms.DockStyle.Fill
		FileConvert.Location = New System.Drawing.Point(3, 3)
		FileConvert.Name = "FileConvert"
		FileConvert.Size = New System.Drawing.Size(709, 423)
		FileConvert.TabIndex = 0
		'
		'TabPage2
		'
		TabPage2.Controls.Add(TabControlIconHelperDemo)
		TabPage2.Location = New System.Drawing.Point(4, 22)
		TabPage2.Name = "TabPage2"
		TabPage2.Padding = New System.Windows.Forms.Padding(3)
		TabPage2.Size = New System.Drawing.Size(729, 461)
		TabPage2.TabIndex = 1
		TabPage2.Text = "IconHelper Demo"
		TabPage2.UseVisualStyleBackColor = True
		'
		'TabControlIconHelperDemo
		'
		TabControlIconHelperDemo.Controls.Add(TabPage8)
		TabControlIconHelperDemo.Controls.Add(TabPage9)
		TabControlIconHelperDemo.Controls.Add(TabPage10)
		TabControlIconHelperDemo.Dock = System.Windows.Forms.DockStyle.Fill
		TabControlIconHelperDemo.Location = New System.Drawing.Point(3, 3)
		TabControlIconHelperDemo.Name = "TabControlIconHelperDemo"
		TabControlIconHelperDemo.SelectedIndex = 0
		TabControlIconHelperDemo.Size = New System.Drawing.Size(723, 455)
		TabControlIconHelperDemo.TabIndex = 0
		'
		'TabPage8
		'
		TabPage8.Controls.Add(FolderIcon)
		TabPage8.Location = New System.Drawing.Point(4, 22)
		TabPage8.Name = "TabPage8"
		TabPage8.Padding = New System.Windows.Forms.Padding(3)
		TabPage8.Size = New System.Drawing.Size(715, 429)
		TabPage8.TabIndex = 0
		TabPage8.Text = "Ordnersymbol anzeigen"
		TabPage8.UseVisualStyleBackColor = True
		'
		'FolderIcon
		'
		FolderIcon.Dock = System.Windows.Forms.DockStyle.Fill
		FolderIcon.Location = New System.Drawing.Point(3, 3)
		FolderIcon.Name = "FolderIcon"
		FolderIcon.Size = New System.Drawing.Size(709, 423)
		FolderIcon.TabIndex = 0
		'
		'TabPage9
		'
		TabPage9.Controls.Add(FileExtension)
		TabPage9.Location = New System.Drawing.Point(4, 22)
		TabPage9.Name = "TabPage9"
		TabPage9.Padding = New System.Windows.Forms.Padding(3)
		TabPage9.Size = New System.Drawing.Size(715, 429)
		TabPage9.TabIndex = 1
		TabPage9.Text = "Dateisymbol anzeigen"
		TabPage9.UseVisualStyleBackColor = True
		'
		'FileExtension
		'
		FileExtension.Dock = System.Windows.Forms.DockStyle.Fill
		FileExtension.Location = New System.Drawing.Point(3, 3)
		FileExtension.Name = "FileExtension"
		FileExtension.Size = New System.Drawing.Size(709, 423)
		FileExtension.TabIndex = 0
		'
		'TabPage10
		'
		TabPage10.Controls.Add(AllFileIcons)
		TabPage10.Location = New System.Drawing.Point(4, 22)
		TabPage10.Name = "TabPage10"
		TabPage10.Padding = New System.Windows.Forms.Padding(3)
		TabPage10.Size = New System.Drawing.Size(715, 429)
		TabPage10.TabIndex = 2
		TabPage10.Text = "alle Symbole in einer Datei anzeigen"
		TabPage10.UseVisualStyleBackColor = True
		'
		'AllFileIcons
		'
		AllFileIcons.Dock = System.Windows.Forms.DockStyle.Fill
		AllFileIcons.Location = New System.Drawing.Point(3, 3)
		AllFileIcons.Name = "AllFileIcons"
		AllFileIcons.Size = New System.Drawing.Size(709, 423)
		AllFileIcons.TabIndex = 0
		'
		'TabPage3
		'
		TabPage3.Controls.Add(TabControlWmiHelperDemo)
		TabPage3.Location = New System.Drawing.Point(4, 22)
		TabPage3.Name = "TabPage3"
		TabPage3.Size = New System.Drawing.Size(729, 461)
		TabPage3.TabIndex = 2
		TabPage3.Text = "WmiHelper Demo"
		TabPage3.UseVisualStyleBackColor = True
		'
		'TabControlWmiHelperDemo
		'
		TabControlWmiHelperDemo.Controls.Add(TabPage11)
		TabControlWmiHelperDemo.Controls.Add(TabPage12)
		TabControlWmiHelperDemo.Controls.Add(TabPage13)
		TabControlWmiHelperDemo.Dock = System.Windows.Forms.DockStyle.Fill
		TabControlWmiHelperDemo.Location = New System.Drawing.Point(0, 0)
		TabControlWmiHelperDemo.Name = "TabControlWmiHelperDemo"
		TabControlWmiHelperDemo.SelectedIndex = 0
		TabControlWmiHelperDemo.Size = New System.Drawing.Size(729, 461)
		TabControlWmiHelperDemo.TabIndex = 0
		'
		'TabPage11
		'
		TabPage11.Controls.Add(DriveInfo)
		TabPage11.Location = New System.Drawing.Point(4, 22)
		TabPage11.Name = "TabPage11"
		TabPage11.Padding = New System.Windows.Forms.Padding(3)
		TabPage11.Size = New System.Drawing.Size(721, 435)
		TabPage11.TabIndex = 0
		TabPage11.Text = "Laufwerksinformationen anzeigen"
		TabPage11.UseVisualStyleBackColor = True
		'
		'DriveInfo
		'
		DriveInfo.Dock = System.Windows.Forms.DockStyle.Fill
		DriveInfo.Location = New System.Drawing.Point(3, 3)
		DriveInfo.Name = "DriveInfo"
		DriveInfo.Size = New System.Drawing.Size(715, 429)
		DriveInfo.TabIndex = 1
		'
		'TabPage12
		'
		TabPage12.Controls.Add(MainboardInfo)
		TabPage12.Location = New System.Drawing.Point(4, 22)
		TabPage12.Name = "TabPage12"
		TabPage12.Padding = New System.Windows.Forms.Padding(3)
		TabPage12.Size = New System.Drawing.Size(721, 435)
		TabPage12.TabIndex = 1
		TabPage12.Text = "Mainboardinformationen anzeigen"
		TabPage12.UseVisualStyleBackColor = True
		'
		'TabPage4
		'
		TabPage4.Location = New System.Drawing.Point(4, 22)
		TabPage4.Name = "TabPage4"
		TabPage4.Size = New System.Drawing.Size(729, 461)
		TabPage4.TabIndex = 3
		TabPage4.Text = "TabPage4"
		TabPage4.UseVisualStyleBackColor = True
		'
		'MainboardInfo
		'
		MainboardInfo.Dock = System.Windows.Forms.DockStyle.Fill
		MainboardInfo.Location = New System.Drawing.Point(3, 3)
		MainboardInfo.Name = "MainboardInfo"
		MainboardInfo.Size = New System.Drawing.Size(715, 429)
		MainboardInfo.TabIndex = 0
		'
		'TabPage13
		'
		TabPage13.Controls.Add(OsInfo)
		TabPage13.Location = New System.Drawing.Point(4, 22)
		TabPage13.Name = "TabPage13"
		TabPage13.Size = New System.Drawing.Size(721, 435)
		TabPage13.TabIndex = 2
		TabPage13.Text = "Betriebssysteminformationen anzeigen"
		TabPage13.UseVisualStyleBackColor = True
		'
		'OsInfo
		'
		OsInfo.Dock = System.Windows.Forms.DockStyle.Fill
		OsInfo.Location = New System.Drawing.Point(0, 0)
		OsInfo.Name = "OsInfo"
		OsInfo.Size = New System.Drawing.Size(721, 435)
		OsInfo.TabIndex = 0
		'
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(737, 487)
		Me.Controls.Add(TabControl)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FormMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "SchlumpfSoftHelpers Demo"
		TabControl.ResumeLayout(False)
		TabPage1.ResumeLayout(False)
		TabControlBase64Demo.ResumeLayout(False)
		TabPage5.ResumeLayout(False)
		TabPage6.ResumeLayout(False)
		TabPage7.ResumeLayout(False)
		TabPage2.ResumeLayout(False)
		TabControlIconHelperDemo.ResumeLayout(False)
		TabPage8.ResumeLayout(False)
		TabPage9.ResumeLayout(False)
		TabPage10.ResumeLayout(False)
		TabPage3.ResumeLayout(False)
		TabControlWmiHelperDemo.ResumeLayout(False)
		TabPage11.ResumeLayout(False)
		TabPage12.ResumeLayout(False)
		TabPage13.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
End Class
