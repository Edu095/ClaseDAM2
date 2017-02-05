Public Class Form1
    Private Sub ButtonConfig_Click(sender As Object, e As EventArgs) Handles ButtonConfig.Click
        'Configuració
        Form3.Show()
        Form3.Visible = True
    End Sub

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        'Joc
        Form2.Show()
        Me.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
