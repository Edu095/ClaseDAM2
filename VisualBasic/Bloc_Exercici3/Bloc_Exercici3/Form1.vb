Imports System.Math
Public Class Form1

    Dim c1 As Integer
    Dim monedes = {2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01}
    Dim message As String
    Dim eur As Decimal
    Dim i = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        eur = CDec(euros.Text)

        While i < 8
            c1 = Truncate(eur / monedes(i))
            eur = eur Mod monedes(i)
            If c1 > 0 Then
                message = message + Str(c1) + " de " + Str(monedes(i)) + "€" + vbCr
            End If
        End While

        MsgBox(message)
        message = Nothing
    End Sub
End Class
