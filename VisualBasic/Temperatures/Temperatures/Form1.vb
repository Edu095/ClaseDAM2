Public Class Form1
    Dim vf As Decimal
    Dim vc As Decimal
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        manual.Checked = True
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles manual.CheckedChanged
        HScrollBarC.Enabled = False
        HScrollBarF.Enabled = False
        Label1.Enabled = False
        Label4.Enabled = False
        gF.Enabled = True
        gC.Enabled = True
        Label2.Enabled = True
        Label3.Enabled = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles scroll.CheckedChanged
        HScrollBarC.Enabled = True
        HScrollBarF.Enabled = True
        Label1.Enabled = True
        Label4.Enabled = True
        gF.Enabled = False
        gC.Enabled = False
        Label2.Enabled = False
        Label3.Enabled = False
    End Sub
    Private Sub restricciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gF.KeyPress, gC.KeyPress
        If InStr(1, "0123456789,.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = "." Then e.KeyChar = ","
    End Sub
    Private Sub gF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gF.KeyPress
        If e.KeyChar = vbCr Then
            If gF.Text = "" Then
                gF.Text = "0"
            End If
            vf = CDec(gF.Text)
            If vf > 122 Then vf = 122
            If vf < -58 Then vf = -58
            vc = (vf - 32) / 1.8
            gC.Text = Format(vc, "###0.00")
            gF.Text = Format(vf, "###0.00")
        End If
    End Sub

    Private Sub gC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gC.KeyPress
        If e.KeyChar = vbCr Then
            If gC.Text = "" Then
                gC.Text = "32"
            End If
            vc = CDec(gC.Text)
            If vc > 50 Then vc = 50
            If vc < -50 Then vc = -50
            vf = (vc * 1.8) + 32
            gC.Text = Format(vc, "###0.00")
            gF.Text = Format(vf, "###0.00")
        End If
    End Sub

    Private Sub HScrollBarF_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarF.Scroll
        vf = CDec(HScrollBarF.Value)
        vc = (vf - 32) / 1.8
        HScrollBarC.Value = vc
        gC.Text = Format(vc, "###0.00")
        gF.Text = Format(vf, "###0.00")

    End Sub

    Private Sub HScrollBarC_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarC.Scroll
        vc = CDec(HScrollBarC.Value)
        vf = (vc * 1.8) + 32
        HScrollBarF.Value = vf
        gC.Text = Format(vc, "###0.00")
        gF.Text = Format(vf, "###0.00")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
