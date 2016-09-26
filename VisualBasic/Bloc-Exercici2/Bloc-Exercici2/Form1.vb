Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vA As Double = CDbl(VarA.Text)
        Dim vB As Double = CDbl(VarB.Text)
        Dim vC As Double = CDbl(VarC.Text)

        Poli.Text = VarA.Text + "x^2 + " + VarB.Text + "x + " + VarC.Text

        ResulPos.Text = (-vB + (vB ^ 2 - 4 * vA * vC) ^ (1 / 2)) / 2 * vA
        ResulNeg.Text = (-vB - (vB ^ 2 - 4 * vA * vC) ^ (1 / 2)) / 2 * vA

    End Sub
End Class
