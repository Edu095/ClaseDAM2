Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(560, 405)
        'TODO: esta línea de código carga datos en la tabla 'LaboratoriDataSet.forElem' Puede moverla o quitarla según sea necesario.
        Me.ForElemTableAdapter.Fill(Me.LaboratoriDataSet.forElem)
        'TODO: esta línea de código carga datos en la tabla 'LaboratoriDataSet.element' Puede moverla o quitarla según sea necesario.
        Me.ElementTableAdapter.Fill(Me.LaboratoriDataSet.element)
        'TODO: esta línea de código carga datos en la tabla 'LaboratoriDataSet.formula' Puede moverla o quitarla según sea necesario.
        Me.FormulaTableAdapter.Fill(Me.LaboratoriDataSet.formula)

    End Sub

    Public Sub FiltrarDadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltrarDadesToolStripMenuItem.Click
        Dim tabI
        Me.Size = New System.Drawing.Size(750, 405)
        FiltrarDadesToolStripMenuItem.Enabled = False
        Select Case TabControl1.SelectedIndex
            Case 0
                Me.FormulaTableAdapter.Fill(Me.LaboratoriDataSet.formula)
                tabI = FormulaDataGridView
                DataGridViewForElem.Visible = True
                dadesTaules(tabI)
            Case 1
                Me.ElementTableAdapter.Fill(Me.LaboratoriDataSet.element)
                tabI = ElementDataGridView
                ForElemDataGridView1.Visible = True
                dadesTaules(tabI)
            Case 2
                Me.ForElemTableAdapter.Fill(Me.LaboratoriDataSet.forElem)
                Me.Size = New System.Drawing.Size(560, 405)
                'tabI = ForElemDataGridView
        End Select
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If FiltrarDadesToolStripMenuItem.Enabled = False Then
            FiltrarDadesToolStripMenuItem_Click(sender, e)
        End If
    End Sub

    Private Sub MostrarTaulesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarTaulesToolStripMenuItem.Click
        Me.Size = New System.Drawing.Size(560, 405)
        FiltrarDadesToolStripMenuItem.Enabled = True
        'Taula Formules
        DataGridViewForElem.Visible = False
        Me.FormulaTableAdapter.Fill(Me.LaboratoriDataSet.formula)
        'Taula Element
        ForElemDataGridView1.Visible = False
        Me.ElementTableAdapter.Fill(Me.LaboratoriDataSet.element)
        'Taula Element Formula
        Me.ForElemTableAdapter.Fill(Me.LaboratoriDataSet.forElem)

    End Sub
    Sub modFormula()
        Select Case TabControl1.SelectedIndex
            Case 0
                'Mostre la formula del combobox a la taula
                Try
                    Me.FormulaTableAdapter.FillBy(Me.LaboratoriDataSet.formula, ComboBox1.Text)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                'Mostre els elements de la formula seleccionada al combobox
                Try
                    Me.ForElemTableAdapter.FillByFE(Me.LaboratoriDataSet.forElem, FormulaDataGridView.Rows(0).Cells(0).Value)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                LabelFiltre.Text = "Formula"
                ButtonDelete.Enabled = True
            Case 1
                'Mostre el element del combobox a la taula
                Try
                    Me.ElementTableAdapter.FillByCBox(Me.LaboratoriDataSet.element, ComboBox1.Text)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                'Mostre les formules del element seleccionat al combobox
                Try
                    Me.ForElemTableAdapter.FillByEF(Me.LaboratoriDataSet.forElem, ElementDataGridView.Rows(0).Cells(0).Value)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                LabelFiltre.Text = "Element"
                ButtonDelete.Enabled = True
            Case 2
                LabelFiltre.Text = "Element per Fromula"
                ComboBox1.Items.Clear()
                ButtonDelete.Enabled = False
        End Select

    End Sub
    Sub dadesTaules(tabI)
        Dim dr = tabI.RowCount
        Dim i As Integer = 0
        ComboBox1.Items.Clear()
        If dr > 0 Then
            While i <> dr
                ComboBox1.Items.Add(tabI.Rows(i).Cells(1).Value)
                i += 1
            End While
            ComboBox1.SelectedIndex = 0
        End If
        modFormula()
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        modFormula()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim out As Integer
        out = MsgBox("Es borraran tots els registres de l'element o formula seleccionats i les seves relacions!!",
                     vbExclamation + vbYesNo + vbDefaultButton2, "Ojo!")

        If (out = 6) Then 'Eliminar Formula
            Dim dr
            If TabControl1.SelectedIndex = 0 Then
                dr = DataGridView3.RowCount
                Dim i As Integer = 0
                While i <> dr
                    If DataGridView3.Rows(i).Cells(0).Value = FormulaDataGridView.Rows(0).Cells(0).Value Then
                        ForElemTableAdapter.Delete(DataGridView3.Rows(i).Cells(0).Value,
                                                   DataGridView3.Rows(i).Cells(1).Value,
                                                   DataGridView3.Rows(i).Cells(2).Value)
                    End If
                    i += 1
                End While
                FormulaTableAdapter.Delete(FormulaDataGridView.Rows(0).Cells(0).Value,
                                           FormulaDataGridView.Rows(0).Cells(1).Value,
                                           FormulaDataGridView.Rows(0).Cells(2).Value,
                                           FormulaDataGridView.Rows(0).Cells(3).Value)
                FiltrarDadesToolStripMenuItem_Click(sender, e)

            ElseIf TabControl1.SelectedIndex = 1 Then 'Eliminar Element
                dr = DataGridView3.RowCount
                Dim formules As New List(Of String)
                Dim i As Integer = 0
                While i <> dr 'Eliminar Element de la taula ForElem
                    If DataGridView3.Rows(i).Cells(1).Value = ElementDataGridView.Rows(0).Cells(0).Value Then
                        If Not formules.Contains(DataGridView3.Rows(i).Cells(0).Value) Then
                            formules.Add(DataGridView3.Rows(i).Cells(0).Value)
                        End If

                        ForElemTableAdapter.Delete(DataGridView3.Rows(i).Cells(0).Value,
                                                   DataGridView3.Rows(i).Cells(1).Value,
                                                   DataGridView3.Rows(i).Cells(2).Value)
                    End If
                    i += 1
                End While

                Me.ForElemTableAdapter.Fill(Me.LaboratoriDataSet.forElem)
                dr = DataGridView3.RowCount
                i = 0
                While i <> dr 'Eliminar Formules de la taula ForElem que utilitzen aquell element
                    If formules.Contains(DataGridView3.Rows(i).Cells(0).Value) Then
                        ForElemTableAdapter.Delete(DataGridView3.Rows(i).Cells(0).Value,
                                                   DataGridView3.Rows(i).Cells(1).Value,
                                                   DataGridView3.Rows(i).Cells(2).Value)
                    End If
                    i += 1
                End While

                Me.FormulaTableAdapter.Fill(Me.LaboratoriDataSet.formula)
                Me.ForElemTableAdapter.Fill(Me.LaboratoriDataSet.forElem)
                dr = FormulaDataGridView.RowCount
                i = 0
                While i <> dr 'Eliminar Formules de la taula formules
                    If formules.Contains(FormulaDataGridView.Rows(i).Cells(0).Value) Then
                        FormulaTableAdapter.Delete(FormulaDataGridView.Rows(i).Cells(0).Value,
                                                   FormulaDataGridView.Rows(i).Cells(1).Value,
                                                   FormulaDataGridView.Rows(i).Cells(2).Value,
                                                   FormulaDataGridView.Rows(i).Cells(3).Value)
                    End If
                    i += 1
                End While

                ElementTableAdapter.Delete(ElementDataGridView.Rows(0).Cells(0).Value,
                                           ElementDataGridView.Rows(0).Cells(1).Value,
                                           ElementDataGridView.Rows(0).Cells(2).Value)

                FiltrarDadesToolStripMenuItem_Click(sender, e)
                Form1.FormulaTableAdapter.Fill(Form1.LaboratoriDataSet.formula)
            End If
            MsgBox("S'han actualitzar els registres")
        End If
    End Sub
End Class