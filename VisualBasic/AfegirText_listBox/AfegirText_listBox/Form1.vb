Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cp As String = TextBox1.Text
        If ListBox1.Items.Contains(cp) Then
            MsgBox("Ja has introduit aixó")
        Else
            ListBox1.Items.Add(cp)
        End If
    End Sub
End Class
