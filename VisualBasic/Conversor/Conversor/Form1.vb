Public Class Form1

    Dim pts = ""
    Dim eur = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox2.Text = "" Or TextBox1.Text <> pts Then
            TextBox2.Text = (CDbl(TextBox1.Text) / 166.386)
            pts = TextBox1.Text
            eur = TextBox2.Text
        ElseIf TextBox1.Text = "" Or TextBox2.Text <> eur Then
            TextBox1.Text = (CDbl(TextBox2.Text) * 166.386)
            pts = TextBox1.Text
            eur = TextBox2.Text
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

End Class
