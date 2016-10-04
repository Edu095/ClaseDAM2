Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As String = diaBox.SelectedItem
        Dim m As String = mesBox.SelectedItem
        Dim a As String = anyBox.SelectedItem
        Dim mostra As String

        Select Case m
            Case "Gen"
                m = "Gener"
            Case "Feb"
                m = "Febrer"
            Case "Mar"
                m = "Març"
            Case "Abr"
                m = "Abril"
            Case "Mai"
                m = "Maig"
            Case "Jun"
                m = "Juny"
            Case "Jul"
                m = "Juliol"
            Case "Ago"
                m = "Agost"
            Case "Sep"
                m = "Septembre"
            Case "Oct"
                m = "Octubre"
            Case "Nov"
                m = "Novembre"
            Case "Dec"
                m = "Decembre"
        End Select

        mostra = "Has seleccionat el dia " + d + " del mes de " + m + " de " + a + vbCr

        If d = "11" And m = "Novembre" And a = "1995" Then
            mostra = mostra + "Aquest dia un tio guai fa anys!!! :P <3"
        End If
        MsgBox(mostra)

    End Sub

End Class
