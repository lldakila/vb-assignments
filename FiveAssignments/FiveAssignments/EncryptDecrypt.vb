Imports System.Text.RegularExpressions

Public Class EncryptDecrypt
    Dim numSet As New Regex("[0-9]")
    Dim lowercaseSet As New Regex("[a-z]")
    Dim uppercaseSet As New Regex("[A-Z]")
    Dim numbersCrypt() As String = {")P", "!Q", "@W", "#E", "$R", "%T", "^Y", "&U", "*I", "(O"}
    Dim uppercaseCrypt(,) As String = {{"A", "a1$"},
                                        {"B", "b2%"},
                                        {"C", "c3+"},
                                        {"D", "d4:"},
                                        {"E", "e5."},
                                        {"F", "f6|"},
                                        {"G", "g7?"},
                                        {"H", "h8#"},
                                        {"I", "i9^"},
                                        {"J", "j0_"},
                                        {"K", "k1;"},
                                        {"L", "l2,"},
                                        {"M", "m3\"},
                                        {"N", "n4`"},
                                        {"O", "o5@"},
                                        {"P", "p6&"},
                                        {"Q", "q7)"},
                                        {"R", "r8" & Chr(34)},
                                        {"S", "s9<"},
                                        {"T", "t0/"},
                                        {"U", "u1]"},
                                        {"V", "v2!"},
                                        {"W", "w3*"},
                                        {"X", "x4("},
                                        {"Y", "y5" & Chr(39)},
                                        {"Z", "z6>"}}
    Dim lowercaseCrypt(,) As String = {{"a", "1!"},
                                        {"b", "2@"},
                                        {"c", "3#"},
                                        {"d", "4$"},
                                        {"e", "5%"},
                                        {"f", "6^"},
                                        {"g", "7&"},
                                        {"h", "8*"},
                                        {"i", "9("},
                                        {"j", "0)"},
                                        {"k", "1-"},
                                        {"l", "2_"},
                                        {"m", "3+"},
                                        {"n", "4="},
                                        {"o", "5{"},
                                        {"p", "6}"},
                                        {"q", "7["},
                                        {"r", "8]"},
                                        {"s", "9|"},
                                        {"t", "0\"},
                                        {"u", "1/"},
                                        {"v", "2>"},
                                        {"w", "3<"},
                                        {"x", "4:"},
                                        {"y", "5;"},
                                        {"z", "6" & Chr(34)}}
    Dim pols As String = "1234567890"



    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        txtEncrypted.Text = ""
        If txtInput.Text <> "" Then
            Dim inputText As String = txtInput.Text
            Dim encryptedText As String = ""



            For x As Integer = 1 To Len(inputText)
                If numSet.IsMatch(Mid(inputText, x, 1)) Then
                    encryptedText &= numbersCrypt(Val(Mid(inputText, x, 1)))
                ElseIf uppercaseSet.IsMatch(Mid(inputText, x, 1)) Then
                    For y As Integer = 0 To 25
                        If Mid(inputText, x, 1) = uppercaseCrypt(y, 0) Then
                            encryptedText &= uppercaseCrypt(y, 1)
                            Exit For
                        End If
                    Next
                ElseIf lowercaseSet.IsMatch(Mid(inputText, x, 1)) Then
                    For y As Integer = 0 To 25
                        If Mid(inputText, x, 1) = lowercaseCrypt(y, 0) Then
                            encryptedText &= lowercaseCrypt(y, 1)
                            Exit For
                        End If
                    Next
                End If
            Next
            txtEncrypted.Text = encryptedText
        Else
            MsgBox("No Input Was Read", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        Dim allowedChar As New Regex("[A-Za-z0-9]")

        If allowedChar.IsMatch(e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        txtDecrypted.Text = ""
        Dim specChar As New Regex("\W")
        'Dim stepSize As Integer = 2
        Dim decryptedText As String = ""
        Dim encryptedText As String = txtEncrypted.Text

        For x As Integer = 1 To Len(encryptedText)
            If specChar.IsMatch(Mid(encryptedText, x, 1)) Then
                For y As Integer = 0 To numbersCrypt.Length - 1
                    If (Mid(encryptedText, x, 2)) = numbersCrypt(y) Then
                        decryptedText &= y
                        'MsgBox("a")
                    End If
                Next
            ElseIf lowercaseSet.IsMatch(Mid(encryptedText, x, 1)) Then
                For y As Integer = 0 To 25
                    If Mid(encryptedText, x, 3) = uppercaseCrypt(y, 1) Then
                        decryptedText &= uppercaseCrypt(y, 0)
                        'MsgBox("b")
                        Exit For
                    End If
                Next
            ElseIf pols.Contains(Mid(encryptedText, x, 1)) = True Then
                For y As Integer = 0 To 25
                    If Mid(encryptedText, x, 2) = lowercaseCrypt(y, 1) Then
                        decryptedText &= lowercaseCrypt(y, 0)
                        'MsgBox("c")
                        Exit For
                    End If
                Next
            Else
                'MsgBox(Mid(encryptedText, 1, 1))
            End If
        Next
        txtDecrypted.Text = decryptedText
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FormItems.Show()
    End Sub
End Class