<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriveInfo
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
		Dim TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
		Dim Label1 As System.Windows.Forms.Label
		Dim Panel1 As System.Windows.Forms.Panel
		Dim Panel2 As System.Windows.Forms.Panel
		Me.ButtonDriveInfoLoad = New System.Windows.Forms.Button()
		Me.LabelPysikalDrive = New System.Windows.Forms.Label()
		Me.LabelLogigDrive = New System.Windows.Forms.Label()
		TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
		Label1 = New System.Windows.Forms.Label()
		Panel1 = New System.Windows.Forms.Panel()
		Panel2 = New System.Windows.Forms.Panel()
		TableLayoutPanel.SuspendLayout()
		Panel1.SuspendLayout()
		Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'TableLayoutPanel
		'
		TableLayoutPanel.ColumnCount = 2
		TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		TableLayoutPanel.Controls.Add(Me.ButtonDriveInfoLoad, 0, 0)
		TableLayoutPanel.Controls.Add(Label1, 0, 1)
		TableLayoutPanel.Controls.Add(Panel1, 0, 2)
		TableLayoutPanel.Controls.Add(Panel2, 1, 2)
		TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
		TableLayoutPanel.Location = New System.Drawing.Point(0, 0)
		TableLayoutPanel.Name = "TableLayoutPanel"
		TableLayoutPanel.RowCount = 3
		TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
		TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
		TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		TableLayoutPanel.Size = New System.Drawing.Size(503, 265)
		TableLayoutPanel.TabIndex = 0
		'
		'ButtonDriveInfoLoad
		'
		Me.ButtonDriveInfoLoad.Location = New System.Drawing.Point(3, 3)
		Me.ButtonDriveInfoLoad.Name = "ButtonDriveInfoLoad"
		Me.ButtonDriveInfoLoad.Size = New System.Drawing.Size(189, 25)
		Me.ButtonDriveInfoLoad.TabIndex = 2
		Me.ButtonDriveInfoLoad.Text = "Laufwerksinformationen laden"
		Me.ButtonDriveInfoLoad.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Label1.AutoSize = True
		TableLayoutPanel.SetColumnSpan(Label1, 2)
		Label1.Dock = System.Windows.Forms.DockStyle.Top
		Label1.Location = New System.Drawing.Point(3, 31)
		Label1.Name = "Label1"
		Label1.Size = New System.Drawing.Size(497, 13)
		Label1.TabIndex = 1
		Label1.Text = "Im System wurden die folgenden Laufwerke gefunden:"
		'
		'Panel1
		'
		Panel1.AutoScroll = True
		Panel1.Controls.Add(Me.LabelPysikalDrive)
		Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Panel1.Location = New System.Drawing.Point(3, 47)
		Panel1.Name = "Panel1"
		Panel1.Size = New System.Drawing.Size(245, 215)
		Panel1.TabIndex = 3
		'
		'LabelPysikalDrive
		'
		Me.LabelPysikalDrive.AutoSize = True
		Me.LabelPysikalDrive.Dock = System.Windows.Forms.DockStyle.Top
		Me.LabelPysikalDrive.Location = New System.Drawing.Point(0, 0)
		Me.LabelPysikalDrive.Name = "LabelPysikalDrive"
		Me.LabelPysikalDrive.Size = New System.Drawing.Size(0, 13)
		Me.LabelPysikalDrive.TabIndex = 0
		'
		'Panel2
		'
		Panel2.AutoScroll = True
		Panel2.Controls.Add(Me.LabelLogigDrive)
		Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Panel2.Location = New System.Drawing.Point(254, 47)
		Panel2.Name = "Panel2"
		Panel2.Size = New System.Drawing.Size(246, 215)
		Panel2.TabIndex = 4
		'
		'LabelLogigDrive
		'
		Me.LabelLogigDrive.AutoSize = True
		Me.LabelLogigDrive.Dock = System.Windows.Forms.DockStyle.Top
		Me.LabelLogigDrive.Location = New System.Drawing.Point(0, 0)
		Me.LabelLogigDrive.Name = "LabelLogigDrive"
		Me.LabelLogigDrive.Size = New System.Drawing.Size(0, 13)
		Me.LabelLogigDrive.TabIndex = 1
		'
		'DriveInfo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(TableLayoutPanel)
		Me.Name = "DriveInfo"
		Me.Size = New System.Drawing.Size(503, 265)
		TableLayoutPanel.ResumeLayout(False)
		TableLayoutPanel.PerformLayout()
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		Panel2.ResumeLayout(False)
		Panel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Private WithEvents LabelPysikalDrive As Label
	Private WithEvents LabelLogigDrive As Label
	Private WithEvents ButtonDriveInfoLoad As Button
End Class
