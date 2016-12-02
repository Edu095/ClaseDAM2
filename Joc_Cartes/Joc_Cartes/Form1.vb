Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Ventana Juego
        Form2.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Ventana configuración
        Form3.Show()
        Form3.Visible = True
    End Sub
End Class
