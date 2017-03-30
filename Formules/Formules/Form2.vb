Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LaboratoriDataSet.forElem' Puede moverla o quitarla según sea necesario.
        Me.ForElemTableAdapter.Fill(Me.LaboratoriDataSet.forElem)
        'TODO: esta línea de código carga datos en la tabla 'LaboratoriDataSet.element' Puede moverla o quitarla según sea necesario.
        Me.ElementTableAdapter.Fill(Me.LaboratoriDataSet.element)
        'TODO: esta línea de código carga datos en la tabla 'LaboratoriDataSet.formula' Puede moverla o quitarla según sea necesario.
        Me.FormulaTableAdapter.Fill(Me.LaboratoriDataSet.formula)

    End Sub

End Class