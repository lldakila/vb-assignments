<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnEncDec = New System.Windows.Forms.Button()
        Me.btnPalindrome = New System.Windows.Forms.Button()
        Me.btnFirstLetter = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEncDec
        '
        Me.btnEncDec.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncDec.Location = New System.Drawing.Point(109, 64)
        Me.btnEncDec.Name = "btnEncDec"
        Me.btnEncDec.Size = New System.Drawing.Size(200, 96)
        Me.btnEncDec.TabIndex = 7
        Me.btnEncDec.Text = "Encrypt Decrypt"
        Me.btnEncDec.UseVisualStyleBackColor = True
        '
        'btnPalindrome
        '
        Me.btnPalindrome.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPalindrome.Location = New System.Drawing.Point(109, 184)
        Me.btnPalindrome.Name = "btnPalindrome"
        Me.btnPalindrome.Size = New System.Drawing.Size(200, 96)
        Me.btnPalindrome.TabIndex = 8
        Me.btnPalindrome.Text = "Palindrome"
        Me.btnPalindrome.UseVisualStyleBackColor = True
        '
        'btnFirstLetter
        '
        Me.btnFirstLetter.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstLetter.Location = New System.Drawing.Point(109, 313)
        Me.btnFirstLetter.Name = "btnFirstLetter"
        Me.btnFirstLetter.Size = New System.Drawing.Size(200, 96)
        Me.btnFirstLetter.TabIndex = 9
        Me.btnFirstLetter.Text = "First Letter Case"
        Me.btnFirstLetter.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(272, 480)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 46)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FormItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 553)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnFirstLetter)
        Me.Controls.Add(Me.btnPalindrome)
        Me.Controls.Add(Me.btnEncDec)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormItems"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEncDec As Button
    Friend WithEvents btnPalindrome As Button
    Friend WithEvents btnFirstLetter As Button
    Friend WithEvents btnBack As Button
End Class
