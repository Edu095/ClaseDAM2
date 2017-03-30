Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LaboratoriDataSet.forElem' Puede moverla o quitarla según sea necesario.
        Me.ForElemTableAdapter.Fill(Me.LaboratoriDataSet.forElem)
        'TODO: esta línea de código carga datos en la tabla 'LaboratoriDataSet.element' Puede moverla o quitarla según sea necesario.
        Me.ElementTableAdapter.Fill(Me.LaboratoriDataSet.element)
        'TODO: esta línea de código carga datos en la tabla 'LaboratoriDataSet.formula' Puede moverla o quitarla según sea necesario.
        Me.FormulaTableAdapter.Fill(Me.LaboratoriDataSet.formula)
        LimpiarCampos()
    End Sub
    Private Sub TaulesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaulesToolStripMenuItem.Click
        Form2.Show()
    End Sub
    Private Sub ButtonInsertForm_Click(sender As Object, e As EventArgs) Handles ButtonInsertForm.Click
        Try
            If Codi_fTextBox.Text <> "" Then
                Me.FormulaTableAdapter.Insert(Codi_fTextBox.Text, NomTextBox.Text, DataDateTimePicker.Text, ActivaCheckBox.Checked)
                Me.FormulaTableAdapter.Fill(LaboratoriDataSet.formula)
                Form2.FormulaTableAdapter.Fill(Form2.LaboratoriDataSet.formula) 'carga Form2

                'Limpiar campos
                LimpiarCampos()

            Else
                MsgBox("Has d'introduïr un Codi valid")
            End If
        Catch ex As Exception
            MsgBox("Has d'introduïr un Codi valid")
        End Try
    End Sub
    Private Sub ButtonInsertElem_Click(sender As Object, e As EventArgs) Handles ButtonInsertElem.Click
        Try
            If Codi_eTextBox.Text <> "" Then
                Me.ElementTableAdapter.Insert(Codi_eTextBox.Text, NomTextBoxElem.Text, DataDateTimePickerElem.Text)
                Me.ElementTableAdapter.Fill(LaboratoriDataSet.element)
                Form2.ElementTableAdapter.Fill(Form2.LaboratoriDataSet.element) 'carga Form2

                'Limpiar campos
                LimpiarCampos()

            Else
                MsgBox("Has d'introduïr un Codi valid")
            End If
        Catch ex As Exception
            MsgBox("Has d'introduïr un Codi valid")
        End Try
    End Sub
    Private Sub ButtonInsertElemForm_Click(sender As Object, e As EventArgs) Handles ButtonInsertElemForm.Click
        'Try
        If QtTextBox.Text <> "" Then
            Me.ForElemTableAdapter.Insert(QtTextBox.Text.ToString, Codi_fComboBox.SelectedValue, Codi_eComboBox.SelectedValue)
            Me.ForElemTableAdapter.Fill(LaboratoriDataSet.forElem)
                Form2.ForElemTableAdapter.Fill(Form2.LaboratoriDataSet.forElem) 'carga Form2

                'Limpiar campos
                LimpiarCampos()

            Else
                MsgBox("Has d'introduïr un Codi valid")
            End If
        'Catch ex As Exception
        'MsgBox("Has d'introduïr un Codi valid")
        'End Try
    End Sub
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Me.FormulaTableAdapter.Delete(Codi_fTextBox.Text, NomTextBox.Text, DataDateTimePicker.Text, ActivaCheckBox.Checked)
        Me.FormulaTableAdapter.Fill(LaboratoriDataSet.formula)
        Form2.FormulaTableAdapter.Fill(Form2.LaboratoriDataSet.formula) 'carga Form2
    End Sub

    Sub LimpiarCampos()

        Codi_fTextBox.Text = ""
        NomTextBox.Text = ""
        DataDateTimePicker.Text = ""
        ActivaCheckBox.Checked = False

        Codi_eTextBox.Text = ""
        NomTextBoxElem.Text = ""
        DataDateTimePickerElem.Text = ""

        Codi_eComboBox.Text = ""
        Codi_fComboBox.Text = ""
        QtTextBox.Text = ""
    End Sub
End Class
