Imports System.Math
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vA As Double
        Dim vB As Double
        Dim vC As Double
        Dim a As Double

        If VarA.Text = "" Or VarB.Text = "" Or VarC.Text = "" Then
            MsgBox("Has d'introduir tots els parametres!!")
        Else
            vA = CDbl(VarA.Text)
            vB = CDbl(VarB.Text)
            vC = CDbl(VarC.Text)
            a = vB ^ 2 - 4 * vA * vC

            Poli.Text = VarA.Text + "x^2 + " + VarB.Text + "x + " + VarC.Text

            If a <= 0 Then
                MsgBox("No es pot resoldre")
            Else
                ResulNeg.Text = (-vB - Sqrt(a)) / (2 * vA)
                ResulPos.Text = (-vB + Sqrt(a)) / (2 * vA)
            End If
        End If

    End Sub

    Private Sub Poli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Poli.KeyPress, ResulNeg.KeyPress, ResulPos.KeyPress
        e.Handled = True
    End Sub

    Private Sub VarA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VarA.KeyPress, VarB.KeyPress, VarC.KeyPress
        Dim h, p As Integer
        Dim cadena As String
        Dim com As Boolean = False

        cadena = VarA.Text
        h = Len(VarA.Text)

        For p = 1 To h
            If Mid(cadena, p, 1) = "." Then
                com = True
                Exit For
            Else
                com = False
            End If
        Next p

        If com = True Then
            If InStr(1, "0123456789-" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If

    End Sub

End Class
