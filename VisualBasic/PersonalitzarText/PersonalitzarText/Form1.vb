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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fonts As New InstalledFontCollection

        For Each one As FontFamily In fonts.Families
            fontBox.Items.Add(one.Name)
        Next
    End Sub
End Class