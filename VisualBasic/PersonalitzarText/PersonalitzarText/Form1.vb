Public Class Form1
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        Dim font As String = fontBox.SelectedItem
        Dim sice As Integer = siceBox.SelectedItem

        If negButton.Checked = True Then
            TextBox.Font = New Font(font, sice, FontStyle.Bold)
        End If
        If cursButton.Checked = True Then
            TextBox.Font = New Font(font, sice, FontStyle.Italic)
        End If
        If subButton.Checked = True Then
            TextBox.Font = New Font(font, sice, FontStyle.Underline)
        End If
        If negButton.Checked = True And cursButton.Checked = True Then
            TextBox.Font = New Font(font, sice, FontStyle.Bold Or FontStyle.Italic)
        End If
        If negButton.Checked = True And subButton.Checked = True Then
            TextBox.Font = New Font(font, sice, FontStyle.Bold Or FontStyle.Underline)
        End If
        If cursButton.Checked = True And subButton.Checked = True Then
            TextBox.Font = New Font(font, sice, FontStyle.Italic Or FontStyle.Underline)
        End If
        If negButton.Checked = True And cursButton.Checked = True And subButton.Checked = True Then
            TextBox.Font = New Font(font, sice, FontStyle.Bold Or FontStyle.Underline Or FontStyle.Italic)
        End If

    End Sub
End Class