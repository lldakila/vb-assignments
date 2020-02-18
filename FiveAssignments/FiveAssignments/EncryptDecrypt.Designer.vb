<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EncryptDecrypt
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
        Me.txtEncrypted = New FiveAssignments.TextboxWatermark()
        Me.txtInput = New FiveAssignments.TextboxWatermark()
        Me.txtDecrypted = New FiveAssignments.TextboxWatermark()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEncrypted
        '
        Me.txtEncrypted.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEncrypted.Location = New System.Drawing.Point(12, 191)
        Me.txtEncrypted.Multiline = True
        Me.txtEncrypted.Name = "txtEncrypted"
        Me.txtEncrypted.ReadOnly = True
        Me.txtEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEncrypted.Size = New System.Drawing.Size(404, 121)
        Me.txtEncrypted.TabIndex = 4
        Me.txtEncrypted.WatermarkColor = System.Drawing.Color.Gray
        Me.txtEncrypted.WatermarkText = "Encrypted text here"
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(12, 12)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(404, 121)
        Me.txtInput.TabIndex = 3
        Me.txtInput.WatermarkColor = System.Drawing.Color.Gray
        Me.txtInput.WatermarkText = "Input your text here"
        '
        'txtDecrypted
        '
        Me.txtDecrypted.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecrypted.Location = New System.Drawing.Point(12, 370)
        Me.txtDecrypted.Multiline = True
        Me.txtDecrypted.Name = "txtDecrypted"
        Me.txtDecrypted.ReadOnly = True
        Me.txtDecrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDecrypted.Size = New System.Drawing.Size(404, 121)
        Me.txtDecrypted.TabIndex = 5
        Me.txtDecrypted.WatermarkColor = System.Drawing.Color.Gray
        Me.txtDecrypted.WatermarkText = "Decrypted text here"
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncrypt.Location = New System.Drawing.Point(12, 139)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(129, 46)
        Me.btnEncrypt.TabIndex = 6
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrypt.Location = New System.Drawing.Point(12, 318)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(129, 46)
        Me.btnDecrypt.TabIndex = 7
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(283, 497)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 46)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'EncryptDecrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 553)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.txtDecrypted)
        Me.Controls.Add(Me.txtEncrypted)
        Me.Controls.Add(Me.txtInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EncryptDecrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encrypt Decrypt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEncrypted As TextboxWatermark
    Friend WithEvents txtInput As TextboxWatermark
    Friend WithEvents txtDecrypted As TextboxWatermark
    Friend WithEvents btnEncrypt As Button
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents btnBack As Button
End Class
