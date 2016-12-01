Public Class Form1

    Structure s_alumnes
        Dim nom As String
        Dim d_n As Date
        Dim dni As String
        Dim sexe As Boolean
    End Structure

    Dim alumne() As s_alumnes
    Dim conta As Integer = 0
    Dim nAlum As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(285, 337)
        TextBoxNom.Enabled = False
        TextBoxDNI.Enabled = False
        DateTimePicker1.Enabled = False
        GroupBoxSex.Enabled = False
        ButtonIntroduir.Enabled = False
        ButtonMostrar.Enabled = False

        nAlum = InputBox("Quants alumnes vols ficar)")
        ReDim alumne(nAlum - 1)

        TextBoxNom.Enabled = True
        TextBoxDNI.Enabled = True
        DateTimePicker1.Enabled = True
        GroupBoxSex.Enabled = True
        ButtonIntroduir.Enabled = True

    End Sub

    Private Sub TextBoxDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxDNI.KeyPress

        If Len(TextBoxDNI.Text) < 8 Then
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If
        If Len(TextBoxDNI.Text) = 8 Then
            TextBoxDNI.CharacterCasing = CharacterCasing.Upper
            If InStr(1, "TRWAGMYFPDXBNJZSQVHLCKE" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If
        If Len(TextBoxDNI.Text) = 9 Then
            If InStr(1, vbCr & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub ButtonIntroduir_Click(sender As Object, e As EventArgs) Handles ButtonIntroduir.Click
        If TextBoxNom.Text = "" Then
            MsgBox("Has d'introduir un nom.")
        Else
            If DateTimePicker1.Value.Year > 2013 Then
                MsgBox("No creus que es una mica jove?")
            Else
                If Len(TextBoxDNI.Text) < 9 Then
                    MsgBox("Has d'introduir un DNI correcte.")
                Else
                    If RadioButtonMas.Checked = False And RadioButtonFem.Checked = False Then
                        MsgBox("Has d'escollir un sexe.")
                    Else
                        If conta >= nAlum - 1 Then
                            ButtonIntroduir.Enabled = False
                            ButtonMostrar.Enabled = True
                        Else
                            alumne(conta).nom = TextBoxNom.Text
                            alumne(conta).d_n = DateTimePicker1.Value
                            alumne(conta).dni = TextBoxDNI.Text
                            If RadioButtonMas.Checked = True Then alumne(conta).sexe = True
                            If RadioButtonFem.Checked = True Then alumne(conta).sexe = False
                            conta += 1
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim i As Integer
        ComboBox1.Items.Clear()
        For i = 0 To nAlum - 1
            ComboBox1.Items.Add(alumne(i).nom)
        Next
        Me.Size = New System.Drawing.Size(500, 337)
    End Sub
End Class
