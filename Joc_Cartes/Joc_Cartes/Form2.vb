Public Class Form2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Visible = True
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        LabelTimer.Text = Form3.Test
    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        Me.BackgroundImage = My.Resources.book1
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class