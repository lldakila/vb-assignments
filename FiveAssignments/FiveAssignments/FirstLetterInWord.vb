Imports System.Text.RegularExpressions

Public Class FirstLetterInWord

    Private Sub btnPaliTest_Click(sender As Object, e As EventArgs) Handles btnPaliTest.Click
        'Dim space As New Regex("\W")
        If txtInput.Text <> "" Then
            Dim inputText As String = txtInput.Text
            inputText = Trim(inputText)
            inputText = inputText.ToLower()
            'For i As Integer = 1 To Len(inputText) - 1
            '    If inputText(i) = " " Or i = 1 Then
            '        inputText = Char.ToUpper(inputText(i))
            '    End If
            'Next
            txtOutput.Text = StrConv(inputText, VbStrConv.ProperCase)
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FormItems.Show()
    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        'Dim allowedChar As New Regex("\d\W")
        ''Dim allowedChar = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm" + vbBack

        'If allowedChar.IsMatch(e.KeyChar) Then
        '    e.Handled = True
        'Else
        '    e.Handled = False
        'End If
    End Sub
End Class