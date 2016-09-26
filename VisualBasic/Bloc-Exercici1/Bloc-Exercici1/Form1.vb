Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Et dius " + NomBox.Text + " i tens " + EdatBox.Text + " anys.")
    End Sub

    Private Sub NomBox_TextChanged(sender As Object, e As EventArgs) Handles NomBox.TextChanged

    End Sub

    Private Sub EdatBox_TextChanged(sender As Object, e As EventArgs) Handles EdatBox.TextChanged

    End Sub
End Class
