Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LaboratoriDataSet.forElem' Puede moverla o quitarla según sea necesario.
        Me.ForElemTableAdapter.Fill(Me.LaboratoriDataSet.forElem)
        'TODO: esta línea de código carga datos en la tabla 'LaboratoriDataSet.element' Puede moverla o quitarla según sea necesario.
        Me.ElementTableAdapter.Fill(Me.LaboratoriDataSet.element)
        'TODO: esta línea de código carga datos en la tabla 'LaboratoriDataSet.formula' Puede moverla o quitarla según sea necesario.
        Me.FormulaTableAdapter.Fill(Me.LaboratoriDataSet.formula)
    End Sub

    Private Sub Inset_fButton1_Click(sender As Object, e As EventArgs) Handles Insert_fButton.Click
        Try
            If Codi_fTextBox.Text <> "" Then
                Me.FormulaTableAdapter.Insert(Codi_fTextBox.Text, Nom_fTextBox.Text, Date_fTimePicker.Value, Activa_fCheckBox.Checked)
                Me.FormulaTableAdapter.Fill(LaboratoriDataSet.formula)
                Form2.FormulaTableAdapter.Fill(Form2.LaboratoriDataSet.formula)
                limpiarCampos()
            Else
                MsgBox("Has d'introduïr un Codi valid")
            End If
        Catch ex As Exception
            MsgBox("Has d'introduïr un Codi valid")
        End Try
    End Sub

    Private Sub Inser_eButton_Click(sender As Object, e As EventArgs) Handles Inser_eButton.Click
        Try
            If Codi_eTextBox.Text <> "" Then
                Me.ElementTableAdapter.Insert(Codi_eTextBox.Text, Nom_eTextBox.Text, Date_eTimePicker.Value)
                Me.ElementTableAdapter.Fill(LaboratoriDataSet.element)
                Form2.ElementTableAdapter.Fill(Form2.LaboratoriDataSet.element)
                limpiarCampos()
            Else
                MsgBox("Has d'introduïr un Codi valid")
            End If
        Catch ex As Exception
            MsgBox("Has d'introduïr un Codi valid")
        End Try
    End Sub

    Private Sub Insert_efButton_Click(sender As Object, e As EventArgs) Handles Insert_efButton.Click
        Try
            If Qt_TextBox.Text <> "" And CDec(Qt_TextBox.Text) > 0 Then
                Me.ForElemTableAdapter.Insert(Codi_fComboBox.SelectedValue, Codi_eComboBox.SelectedValue, CDec(Qt_TextBox.Text))
                Me.ForElemTableAdapter.Fill(LaboratoriDataSet.forElem)
                Form2.ForElemTableAdapter.Fill(Form2.LaboratoriDataSet.forElem)
                limpiarCampos()
            Else
                MsgBox("Has d'introduïr una cantitat valid")
            End If
        Catch ex As Exception
            MsgBox("Has d'introduïr una cantitat valid")
        End Try
    End Sub

    Private Sub TaulesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaulesToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Sub limpiarCampos()
        Codi_fTextBox.Text = ""
        Nom_fTextBox.Text = ""
        Date_fTimePicker.Value = Date.Today
        Activa_fCheckBox.Checked = False

        Codi_eTextBox.Text = ""
        Nom_eTextBox.Text = ""
        Date_eTimePicker.Value = Date.Today

        Codi_fComboBox.Text = ""
        Codi_eComboBox.Text = ""
        Qt_TextBox.Text = ""
    End Sub
End Class
