Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.authors' Puede moverla o quitarla según sea necesario.
        Me.AuthorsTableAdapter.Fill(Me.DataSet1.authors)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.authors' Puede moverla o quitarla según sea necesario.
        Me.AuthorsTableAdapter.FillBy(Me.DataSet1.authors)
    End Sub
End Class
