Imports System.Drawing.Text
Public Class Form1

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        Dim font As String = fontBox.SelectedItem
        Dim size As Integer = 12
        If sizeBox.SelectedIndex > -1 Then
            size = sizeBox.SelectedItem
        End If

        If negButton.Checked = True Then
            TextBox.Font = New Font(font, size, FontStyle.Bold)
        End If
        If cursButton.Checked = True Then
            TextBox.Font = New Font(font, size, FontStyle.Italic)
        End If
        If subButton.Checked = True Then
            TextBox.Font = New Font(font, size, FontStyle.Underline)
        End If
        If negButton.Checked = True And cursButton.Checked = True Then
            TextBox.Font = New Font(font, size, FontStyle.Bold Or FontStyle.Italic)
        End If
        If negButton.Checked = True And subButton.Checked = True Then
            TextBox.Font = New Font(font, size, FontStyle.Bold Or FontStyle.Underline)
        End If
        If cursButton.Checked = True And subButton.Checked = True Then
            TextBox.Font = New Font(font, size, FontStyle.Italic Or FontStyle.Underline)
        End If
        If negButton.Checked = True And cursButton.Checked = True And subButton.Checked = True Then
            TextBox.Font = New Font(font, size, FontStyle.Bold Or FontStyle.Underline Or FontStyle.Italic)
        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AcercaDeForm1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeForm1ToolStripMenuItem.Click
        Dim cpr As String = Chr(169)
        MsgBox("Personalizador de Texto" + vbCr + "Version 2.0" + vbCr + cpr + " 2016 BuffuApps S.L.")
    End Sub

    Private Sub VerAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerAyudaToolStripMenuItem.Click
        MsgBox("Si necesites ajuda per utilitzar aquest programa es que tens problemes cerebrals greus. Jo que tu acudirie a un metje/psicoleg.")
    End Sub

    Private Sub rBar_ValueChanged(sender As Object, e As EventArgs) Handles rBar.ValueChanged, gBar.ValueChanged, bBar.ValueChanged
        Dim rojo, verde, azul As Integer
        rojo = rBar.Value
        verde = gBar.Value
        azul = bBar.Value

        NumericUpDown1.Value = rojo
        NumericUpDown2.Value = verde
        NumericUpDown3.Value = azul

        Panel1.BackColor = Color.FromArgb(rojo, verde, azul)
        TextBox.ForeColor = Color.FromArgb(rojo, verde, azul)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        rBar.Value = NumericUpDown1.Value
        gBar.Value = NumericUpDown2.Value
        bBar.Value = NumericUpDown3.Value
        Panel1.BackColor = Color.FromArgb(rBar.Value, gBar.Value, bBar.Value)
        TextBox.ForeColor = Color.FromArgb(rBar.Value, gBar.Value, bBar.Value)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fonts As New InstalledFontCollection

        For Each one As FontFamily In fonts.Families
            fontBox.Items.Add(one.Name)
        Next
    End Sub
End Class