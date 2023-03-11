<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StringConvert
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
		Me.TextBoxInput = New System.Windows.Forms.TextBox()
		Me.ButtonConvertToBase64 = New System.Windows.Forms.Button()
		Me.TextBoxBase64Output = New System.Windows.Forms.TextBox()
		Me.LabelTextOutput = New System.Windows.Forms.Label()
		Me.ButtonConvertToText = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'TextBoxInput
		'
		Me.TextBoxInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBoxInput.Location = New System.Drawing.Point(8, 8)
		Me.TextBoxInput.Name = "TextBoxInput"
		Me.TextBoxInput.Size = New System.Drawing.Size(432, 20)
		Me.TextBoxInput.TabIndex = 3
		'
		'ButtonConvertToBase64
		'
		Me.ButtonConvertToBase64.Location = New System.Drawing.Point(8, 36)
		Me.ButtonConvertToBase64.Name = "ButtonConvertToBase64"
		Me.ButtonConvertToBase64.Size = New System.Drawing.Size(180, 23)
		Me.ButtonConvertToBase64.TabIndex = 2
		Me.ButtonConvertToBase64.Text = "nach Base64 konvertieren"
		Me.ButtonConvertToBase64.UseVisualStyleBackColor = True
		'
		'TextBoxBase64Output
		'
		Me.TextBoxBase64Output.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBoxBase64Output.Location = New System.Drawing.Point(8, 68)
		Me.TextBoxBase64Output.Multiline = True
		Me.TextBoxBase64Output.Name = "TextBoxBase64Output"
		Me.TextBoxBase64Output.ReadOnly = True
		Me.TextBoxBase64Output.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.TextBoxBase64Output.Size = New System.Drawing.Size(432, 116)
		Me.TextBoxBase64Output.TabIndex = 1
		'
		'LabelTextOutput
		'
		Me.LabelTextOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LabelTextOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LabelTextOutput.Location = New System.Drawing.Point(8, 224)
		Me.LabelTextOutput.Name = "LabelTextOutput"
		Me.LabelTextOutput.Size = New System.Drawing.Size(432, 23)
		Me.LabelTextOutput.TabIndex = 0
		'
		'ButtonConvertToText
		'
		Me.ButtonConvertToText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.ButtonConvertToText.Location = New System.Drawing.Point(8, 192)
		Me.ButtonConvertToText.Name = "ButtonConvertToText"
		Me.ButtonConvertToText.Size = New System.Drawing.Size(180, 24)
		Me.ButtonConvertToText.TabIndex = 4
		Me.ButtonConvertToText.Text = "nach Text konvertieren"
		Me.ButtonConvertToText.UseVisualStyleBackColor = True
		'
		'StringConvert
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.ButtonConvertToText)
		Me.Controls.Add(Me.LabelTextOutput)
		Me.Controls.Add(Me.TextBoxBase64Output)
		Me.Controls.Add(Me.ButtonConvertToBase64)
		Me.Controls.Add(Me.TextBoxInput)
		Me.Name = "StringConvert"
		Me.Size = New System.Drawing.Size(450, 259)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents TextBoxInput As TextBox
    Private WithEvents ButtonConvertToBase64 As Button
    Private WithEvents TextBoxBase64Output As TextBox
    Private WithEvents LabelTextOutput As Label
	Private WithEvents ButtonConvertToText As Button
End Class
