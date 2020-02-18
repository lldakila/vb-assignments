<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPalindrome
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
        Me.btnPaliTest = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(12, 12)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(404, 121)
        Me.txtInput.TabIndex = 0
        Me.txtInput.WatermarkColor = System.Drawing.Color.Gray
        Me.txtInput.WatermarkText = "Input text here to test if palindrome"
        '
        'btnPaliTest
        '
        Me.btnPaliTest.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaliTest.Location = New System.Drawing.Point(12, 155)
        Me.btnPaliTest.Name = "btnPaliTest"
        Me.btnPaliTest.Size = New System.Drawing.Size(129, 46)
        Me.btnPaliTest.TabIndex = 2
        Me.btnPaliTest.Text = "Test It"
        Me.btnPaliTest.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(156, 164)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(210, 30)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "Is not a palindrome"
        Me.lblOutput.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(287, 437)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 46)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FormPalindrome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 495)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnPaliTest)
        Me.Controls.Add(Me.txtInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormPalindrome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Palindrome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextboxWatermark
    Friend WithEvents btnPaliTest As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnBack As Button
End Class
