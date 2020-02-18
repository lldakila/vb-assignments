Imports System.Text.RegularExpressions

Public Class FormPalindrome
    Public Function stringReverse(src As String) As Boolean
        Dim palindrome As Boolean = True
        For i As Integer = 0 To src.Length \ 2
            If src(i) <> src(src.Length - i - 1) Then
                palindrome = False
                Exit For
            End If
        Next

        Return palindrome

    End Function

    Private Sub btnPaliTest_Click(sender As Object, e As EventArgs) Handles btnPaliTest.Click
        Dim regWhitespace As New Regex("\s")
        Dim strInput As String = txtInput.Text
        regWhitespace.Replace(strInput, String.Empty)
        Dim cleanedString As String = Regex.Replace(strInput, "\W", "")
        Dim result As Boolean = stringReverse(cleanedString.ToLower)

        If result = True Then
            lblOutput.Show()
            lblOutput.Text = "Input is a palindrome"
        Else
            lblOutput.Show()
            lblOutput.Text = "Input is not a palindrome"
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FormItems.Show()
    End Sub
End Class