Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data As Integer = DateTimePicker1.Value.Year
        Dim data2 As Integer = Now.Year()

        TextBox1.Text = "Tens " + Str(data2 - data) + " anys"


    End Sub
End Class
