Public Class FormItems
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FormUsername.Show()
    End Sub

    Private Sub btnEncDec_Click(sender As Object, e As EventArgs) Handles btnEncDec.Click
        Me.Hide()
        EncryptDecrypt.Show()
    End Sub

    Private Sub btnPalindrome_Click(sender As Object, e As EventArgs) Handles btnPalindrome.Click
        Me.Hide()
        FormPalindrome.Show()
    End Sub

    Private Sub btnFirstLetter_Click(sender As Object, e As EventArgs) Handles btnFirstLetter.Click
        Me.Hide()
        FirstLetterInWord.Show()
    End Sub
End Class