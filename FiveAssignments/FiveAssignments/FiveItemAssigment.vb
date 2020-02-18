Imports System.Text.RegularExpressions

Public Class FormUsername
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text <> "" Then
            Me.Hide()
            MsgBox("Hi " & txtUsername.Text)
            FormItems.Show()

        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        Dim allowedChar As New Regex("[A-Za-z0-9]")
        'Dim allowedChar = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm" + vbBack

        If allowedChar.IsMatch(e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
