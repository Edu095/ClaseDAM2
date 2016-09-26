Public Class Form1

    Private Sub HScrollBar1_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBar1.ValueChanged, HScrollBar2.ValueChanged, HScrollBar3.ValueChanged

        Dim rojo, verde, azul As Integer
        rojo = HScrollBar1.Value
        verde = HScrollBar2.Value
        azul = HScrollBar3.Value

        NumericUpDown1.Value = rojo
        NumericUpDown2.Value = verde
        NumericUpDown3.Value = azul

        Panel1.BackColor = Color.FromArgb(rojo, verde, azul)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged, NumericUpDown2.ValueChanged, HScrollBar3.ValueChanged
        HScrollBar1.Value = NumericUpDown1.Value
        HScrollBar2.Value = NumericUpDown2.Value
        HScrollBar3.Value = NumericUpDown3.Value
        Panel1.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
    End Sub
End Class
