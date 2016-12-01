Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a(2) As Control

        For n = 0 To 2
            a(n) = New TextBox
            a(n).Top = n * 30 + 40
            a(n).Left = n * 30 + 40
            Me.Controls.Add(a(n))
        Next


    End Sub
End Class