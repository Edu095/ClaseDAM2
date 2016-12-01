Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim MyGraphics As Graphics = Me.CreateGraphics
        Dim rotulador As Pen
        Dim i As Integer
        Dim top As Integer = 65
        Dim bot As Integer = 78
        rotulador = New Pen(Brushes.LightBlue, 4)
        MyGraphics.DrawLine(rotulador, 20, 65, 900, 65)
        MyGraphics.DrawLine(rotulador, 20, 335, 900, 335)
        rotulador = New Pen(Brushes.Black, 15)
        MyGraphics.DrawLine(rotulador, 900, 52, 900, 348)
        rotulador = New Pen(Brushes.White, 15)
        For i = 1 To 11
            MyGraphics.DrawLine(rotulador, 900, top, 900, bot)
            top += 26
            bot += 26
            Application.DoEvents()
        Next

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
