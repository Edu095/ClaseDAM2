Public Class Form1

    Dim lvl As Integer = 1

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

    Private Sub SurtirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SurtirToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub NouJocToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouJocToolStripMenuItem.Click
        lvl = 1
    End Sub
End Class
