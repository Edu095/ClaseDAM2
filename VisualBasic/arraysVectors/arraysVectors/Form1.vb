Public Class Form1
    Dim a(2) As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a(0) = "P"
        a(1) = "e"
        a(2) = "p"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, elem As Integer
        Dim alum As String

        elem = InputBox("Quants alumnes vols ficar?") 'PROIBIDO USAR IMPUT BOX EN EL EXAMENT
        ReDim a(elem - 1)

        For i = 0 To a.GetUpperBound(0)
            alum = InputBox("Alumne " + Str(i))
            TextBox1.Text += alum & vbCrLf
        Next
        Dim ctrl As Control
        For Each ctrl In Controls
            TextBox1.Text += ctrl.Name & vbCrLf
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
End Class
