Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aleatori As New Random
        Static a As Integer
        Dim b As Integer
        TextBox1.Text = aleatori.Next(10, 21)
        b = 5
        MsgBox(Str(Module1.n) + ", " + Str(a) + ", " + Str(b))
        a += 1
        b += 1
        Module1.n += 1

        Dim resul = MessageBox.Show("Hola pepito", "Chachi", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
        If (resul = DialogResult.Yes) Then
            Form2.Show()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
