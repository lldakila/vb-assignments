<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsername
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlFull = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtUsername = New FiveAssignments.TextboxWatermark()
        Me.pnlFull.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFull
        '
        Me.pnlFull.Controls.Add(Me.Button1)
        Me.pnlFull.Controls.Add(Me.txtUsername)
        Me.pnlFull.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFull.Location = New System.Drawing.Point(0, 0)
        Me.pnlFull.Name = "pnlFull"
        Me.pnlFull.Size = New System.Drawing.Size(428, 171)
        Me.pnlFull.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(276, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Continue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(27, 30)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(378, 36)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.WatermarkColor = System.Drawing.Color.Gray
        Me.txtUsername.WatermarkText = "Username"
        '
        'FormUsername
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 171)
        Me.Controls.Add(Me.pnlFull)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormUsername"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Username"
        Me.pnlFull.ResumeLayout(False)
        Me.pnlFull.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFull As Panel
    Friend WithEvents txtUsername As TextboxWatermark
    Friend WithEvents Button1 As Button
End Class
