Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Items.Count = 0 Then
            ComboBox1.Items.Add("Gener")
            ComboBox1.Items.Add("Febrer")
            ComboBox1.Items.Add("Març")
            ComboBox1.Items.Add("Abril")
            ComboBox1.Items.Add("Maig")
            ComboBox1.Items.Add("Juny")
            ComboBox1.Items.Add("Juliol")
            ComboBox1.Items.Add("Agost")
            ComboBox1.Items.Add("Septembre")
            ComboBox1.Items.Add("Octubre")
            ComboBox1.Items.Add("Nobembre")
            ComboBox1.Items.Add("Desembre")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cp As String = ComboBox1.SelectedItem
        ListBox1.Items.Add(cp)


    End Sub
End Class
