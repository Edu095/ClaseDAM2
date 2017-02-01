Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "formato .jpg|*.jpg|formato .bmp|*.bmp|Tofos los formatos|*.*"
        OpenFileDialog1.FilterIndex = 3
        'OpenFileDialog1.ShowDialog()
        'picturebox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName) 
        Dim dr As DialogResult
        dr = OpenFileDialog1.ShowDialog()
        MessageBox.Show(dr)
        'La siguiente línea descarga el control de imagen
        'Picturebox1.Image = Nothing
    End Sub
End Class
