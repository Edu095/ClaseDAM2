Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Me.Visible = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.Image = ImageList1.Images(ListBox1.SelectedIndex)
    End Sub
End Class