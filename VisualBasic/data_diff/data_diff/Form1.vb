Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dies As Integer
        dies = DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value)
        MsgBox("Hi ha " + Str(Math.Abs(dies)) + " dies de diferencia")
    End Sub
End Class
