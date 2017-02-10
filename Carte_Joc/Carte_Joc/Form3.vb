Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        bgCarta = ListBox1.SelectedIndex
        Me.Visible = False

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.Image = ImageList1.Images(ListBox1.SelectedIndex)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.SelectedIndex = 0
    End Sub
End Class