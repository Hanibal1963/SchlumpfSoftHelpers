<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OSInfo
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
		Dim Panel As System.Windows.Forms.Panel
		Me.Label = New System.Windows.Forms.Label()
		Me.ButtonOsInfoLoad = New System.Windows.Forms.Button()
		Panel = New System.Windows.Forms.Panel()
		Panel.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel
		'
		Panel.AutoScroll = True
		Panel.Controls.Add(Me.Label)
		Panel.Location = New System.Drawing.Point(8, 48)
		Panel.Name = "Panel"
		Panel.Size = New System.Drawing.Size(356, 220)
		Panel.TabIndex = 1
		'
		'Label
		'
		Me.Label.AutoSize = True
		Me.Label.Location = New System.Drawing.Point(4, 4)
		Me.Label.Name = "Label"
		Me.Label.Size = New System.Drawing.Size(0, 13)
		Me.Label.TabIndex = 0
		Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ButtonOsInfoLoad
		'
		Me.ButtonOsInfoLoad.Location = New System.Drawing.Point(12, 12)
		Me.ButtonOsInfoLoad.Name = "ButtonOsInfoLoad"
		Me.ButtonOsInfoLoad.Size = New System.Drawing.Size(132, 24)
		Me.ButtonOsInfoLoad.TabIndex = 0
		Me.ButtonOsInfoLoad.Text = "Informationen laden"
		Me.ButtonOsInfoLoad.UseVisualStyleBackColor = True
		'
		'OSInfo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Panel)
		Me.Controls.Add(Me.ButtonOsInfoLoad)
		Me.Name = "OSInfo"
		Me.Size = New System.Drawing.Size(372, 275)
		Panel.ResumeLayout(False)
		Panel.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Private WithEvents ButtonOsInfoLoad As Button
    Private WithEvents Label As Label
End Class
