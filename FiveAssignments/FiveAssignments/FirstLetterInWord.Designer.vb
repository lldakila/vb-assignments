<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstLetterInWord
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
        Me.txtInput = New FiveAssignments.TextboxWatermark()
        Me.txtOutput = New FiveAssignments.TextboxWatermark()
        Me.btnPaliTest = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(12, 28)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(404, 121)
        Me.txtInput.TabIndex = 1
        Me.txtInput.WatermarkColor = System.Drawing.Color.Gray
        Me.txtInput.WatermarkText = "Input your text here"
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(12, 232)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(404, 121)
        Me.txtOutput.TabIndex = 2
        Me.txtOutput.WatermarkColor = System.Drawing.Color.Gray
        Me.txtOutput.WatermarkText = "Output text here"
        '
        'btnPaliTest
        '
        Me.btnPaliTest.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaliTest.Location = New System.Drawing.Point(12, 169)
        Me.btnPaliTest.Name = "btnPaliTest"
        Me.btnPaliTest.Size = New System.Drawing.Size(190, 46)
        Me.btnPaliTest.TabIndex = 3
        Me.btnPaliTest.Text = "Correct Input"
        Me.btnPaliTest.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(287, 437)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 46)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FirstLetterInWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 495)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnPaliTest)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FirstLetterInWord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "First Letter in Word"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextboxWatermark
    Friend WithEvents txtOutput As TextboxWatermark
    Friend WithEvents btnPaliTest As Button
    Friend WithEvents btnBack As Button
End Class
