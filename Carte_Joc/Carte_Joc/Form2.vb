Public Class Form2
    Dim tempsVista As Integer = 200

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Size = New System.Drawing.Size(680, 360)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Timer1.Start()

    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tempsVista > 0 Then
            tempsVista -= 1
            LabelTimer.Text = tempsVista / 10
        Else
            Timer1.Stop()
            LabelTimer.Text = "Temps"
        End If
    End Sub
End Class