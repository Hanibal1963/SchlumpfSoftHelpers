<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllFileIcons
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
		Me.ButtonOpenFile = New System.Windows.Forms.Button()
		Me.LabelIconCount = New System.Windows.Forms.Label()
		Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
		Me.SuspendLayout()
		'
		'ButtonOpenFile
		'
		Me.ButtonOpenFile.Location = New System.Drawing.Point(16, 16)
		Me.ButtonOpenFile.Name = "ButtonOpenFile"
		Me.ButtonOpenFile.Size = New System.Drawing.Size(180, 24)
		Me.ButtonOpenFile.TabIndex = 0
		Me.ButtonOpenFile.Text = "Eine Datei auswählen"
		Me.ButtonOpenFile.UseVisualStyleBackColor = True
		'
		'LabelIconCount
		'
		Me.LabelIconCount.AutoSize = True
		Me.LabelIconCount.Location = New System.Drawing.Point(20, 56)
		Me.LabelIconCount.Name = "LabelIconCount"
		Me.LabelIconCount.Size = New System.Drawing.Size(82, 13)
		Me.LabelIconCount.TabIndex = 1
		Me.LabelIconCount.Text = "LabelIconCount"
		'
		'FlowLayoutPanel
		'
		Me.FlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FlowLayoutPanel.AutoScroll = True
		Me.FlowLayoutPanel.Location = New System.Drawing.Point(16, 80)
		Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
		Me.FlowLayoutPanel.Size = New System.Drawing.Size(388, 204)
		Me.FlowLayoutPanel.TabIndex = 2
		'
		'AllFileIcons
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.FlowLayoutPanel)
		Me.Controls.Add(Me.LabelIconCount)
		Me.Controls.Add(Me.ButtonOpenFile)
		Me.Name = "AllFileIcons"
		Me.Size = New System.Drawing.Size(423, 300)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents ButtonOpenFile As Button
    Private WithEvents LabelIconCount As Label
	Private WithEvents FlowLayoutPanel As FlowLayoutPanel
End Class
