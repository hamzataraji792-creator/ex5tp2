Public Class Form1
    Function carre(x As Integer) As Integer
        Return x * x
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrEmpty(n.Text) Or Not IsNumeric(n.Text)) Then
            ErrorProvider1.SetError(n, "tapez un nombre")
        ElseIf CInt(n.Text) < 0 Then
            ErrorProvider1.SetError(n, "tapez nombre positive")
        Else
            aff.Text = carre(n.Text)
            ErrorProvider1.Clear()
        End If
    End Sub
End Class
