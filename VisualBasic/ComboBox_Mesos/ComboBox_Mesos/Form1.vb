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
        Dim cp As String = ComboBox1.SelectedItem 'retorne l'element seleccionat
        ListBox1.Items.Add(cp)
        TextBox1.Text = ListBox1.Items.Count()
        'Propietat Sorted activada te ordene la llista automaticament a mesura qu vas ficant coses
        'Tambe s'ordene pasant els elements a un array, ordenant l'array i tornant a pasro tot al listbox
        ListBox1.Items.Contains("Gener") 'torne true o false
        ListBox1.Items.IndexOf("Febrer") 'retorne la posició del element dins de la llista. Si n'hiha mes de un retorna el primer, si no hi es retorne -1
        ListBox1.Items.Insert(2, "hola") 'insete un nou element a la posició indicada, els demes tiren avall
        ListBox1.Items.Remove("Març") 'elimine l'element especificat
        ListBox1.Items.RemoveAt(3) 'elimine l'element de la posició especificada
        TextBox1.Text = ListBox1.Items(2)
        'Propietat MultiColumn si els elements no caben fa mes de una columna
        'Propietat ScrollAlwaysVisible mostra la barra de scroll si hiha molts elements
        'Propietat SelecteMode permet seleccionar mes de un item
        ListBox1.SetSelected(4, True)
        ListBox1.SetSelected(6, True)

        ListBox1.Items.Clear()

    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        If e.KeyChar = vbCr Then
            ComboBox2.Items.Add(ComboBox2.Text)
            ComboBox2.Text = ""

        End If
    End Sub

End Class
