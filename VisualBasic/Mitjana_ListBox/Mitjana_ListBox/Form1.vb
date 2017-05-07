Public Class Form1
    Dim sum As Integer

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        If IsNumeric(TextBox1.Text) Then
            Dim nota As Integer = CInt(TextBox1.Text)
            ListBox1.Items.Add(nota)
            sum += nota
            Dim numNot As Integer = ListBox1.Items.Count
            Dim mitja As Integer = sum / numNot
            Label1.Text = "La mitja es " + Str(mitja)
        Else
            MsgBox("Nomes pots utroduir notes del 0 al 10")
        End If


    End Sub

    Private Sub delElement_Click(sender As Object, e As EventArgs) Handles delElement.Click
        sum -= ListBox1.SelectedItem
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        Dim numNot As Integer = ListBox1.Items.Count
        Dim mitja As Integer = sum / numNot
        Label1.Text = "La mitja es " + Str(mitja)

    End Sub

    Private Sub delAll_Click(sender As Object, e As EventArgs) Handles delAll.Click
        ListBox1.Items.Clear()
        Label1.Text = "Introdueix Notes"
    End Sub


End Class
