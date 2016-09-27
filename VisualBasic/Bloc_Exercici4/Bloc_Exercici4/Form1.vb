Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Double = CDbl(TextBox1.Text)
        Dim xiv As Boolean = False

        If num < 50 Then
            MsgBox(num ^ 2)
            xiv = True
        End If
        If num = 25 Or num = 30 Or num = 75 Then
            MsgBox(num ^ (1 / 2))
            xiv = True
        End If
        If num = 10 Or num > 100 Or (num > 3.8 And num < 77.9) Then
            MsgBox(num / 10)
            xiv = True
        End If
        If xiv=False Then
            MsgBox(num)
        End If

    End Sub
End Class
