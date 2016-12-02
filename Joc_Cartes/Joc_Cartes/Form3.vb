Public Class Form3
    Public Test As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Test = "hola"
    End Sub

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        Me.Visible = False
    End Sub
End Class