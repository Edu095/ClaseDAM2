<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FormulaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FormulaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaboratoriDataSet = New Formules.laboratoriDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ElementDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.FormulaTableAdapter = New Formules.laboratoriDataSetTableAdapters.formulaTableAdapter()
        Me.TableAdapterManager = New Formules.laboratoriDataSetTableAdapters.TableAdapterManager()
        Me.ElementTableAdapter = New Formules.laboratoriDataSetTableAdapters.elementTableAdapter()
        Me.ForElemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ForElemTableAdapter = New Formules.laboratoriDataSetTableAdapters.forElemTableAdapter()
        Me.ForElemDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.FormulaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ElementDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ForElemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForElemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(470, 309)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.FormulaDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(462, 283)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Formules"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FormulaDataGridView
        '
        Me.FormulaDataGridView.AllowUserToAddRows = False
        Me.FormulaDataGridView.AllowUserToDeleteRows = False
        Me.FormulaDataGridView.AutoGenerateColumns = False
        Me.FormulaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FormulaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewCheckBoxColumn1})
        Me.FormulaDataGridView.DataSource = Me.FormulaBindingSource
        Me.FormulaDataGridView.Location = New System.Drawing.Point(3, 6)
        Me.FormulaDataGridView.Name = "FormulaDataGridView"
        Me.FormulaDataGridView.ReadOnly = True
        Me.FormulaDataGridView.Size = New System.Drawing.Size(453, 271)
        Me.FormulaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "codi_f"
        Me.DataGridViewTextBoxColumn7.HeaderText = "codi_f"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "nom"
        Me.DataGridViewTextBoxColumn8.HeaderText = "nom"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn9.HeaderText = "data"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "activa"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "activa"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'FormulaBindingSource
        '
        Me.FormulaBindingSource.DataMember = "formula"
        Me.FormulaBindingSource.DataSource = Me.LaboratoriDataSet
        '
        'LaboratoriDataSet
        '
        Me.LaboratoriDataSet.DataSetName = "laboratoriDataSet"
        Me.LaboratoriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ElementDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(462, 283)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Elements"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ElementDataGridView
        '
        Me.ElementDataGridView.AllowUserToAddRows = False
        Me.ElementDataGridView.AllowUserToDeleteRows = False
        Me.ElementDataGridView.AutoGenerateColumns = False
        Me.ElementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ElementDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ElementDataGridView.DataSource = Me.ElementBindingSource
        Me.ElementDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.ElementDataGridView.Name = "ElementDataGridView"
        Me.ElementDataGridView.ReadOnly = True
        Me.ElementDataGridView.Size = New System.Drawing.Size(358, 271)
        Me.ElementDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codi_e"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codi_e"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nom"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nom"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn3.HeaderText = "data"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'ElementBindingSource
        '
        Me.ElementBindingSource.DataMember = "element"
        Me.ElementBindingSource.DataSource = Me.LaboratoriDataSet
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.ForElemDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(462, 283)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Element per Formula"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'FormulaTableAdapter
        '
        Me.FormulaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.elementTableAdapter = Me.ElementTableAdapter
        Me.TableAdapterManager.formulaTableAdapter = Me.FormulaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Formules.laboratoriDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ElementTableAdapter
        '
        Me.ElementTableAdapter.ClearBeforeFill = True
        '
        'ForElemBindingSource
        '
        Me.ForElemBindingSource.DataMember = "forElem"
        Me.ForElemBindingSource.DataSource = Me.LaboratoriDataSet
        '
        'ForElemTableAdapter
        '
        Me.ForElemTableAdapter.ClearBeforeFill = True
        '
        'ForElemDataGridView
        '
        Me.ForElemDataGridView.AutoGenerateColumns = False
        Me.ForElemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ForElemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.ForElemDataGridView.DataSource = Me.ForElemBindingSource
        Me.ForElemDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ForElemDataGridView.Name = "ForElemDataGridView"
        Me.ForElemDataGridView.Size = New System.Drawing.Size(350, 220)
        Me.ForElemDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "qt"
        Me.DataGridViewTextBoxColumn6.HeaderText = "qt"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "codi_f1"
        Me.DataGridViewTextBoxColumn10.HeaderText = "codi_f1"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "codi_e1"
        Me.DataGridViewTextBoxColumn11.HeaderText = "codi_e1"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 333)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.FormulaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratoriDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ElementDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.ForElemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForElemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents LaboratoriDataSet As laboratoriDataSet
    Friend WithEvents FormulaBindingSource As BindingSource
    Friend WithEvents FormulaTableAdapter As laboratoriDataSetTableAdapters.formulaTableAdapter
    Friend WithEvents TableAdapterManager As laboratoriDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ElementTableAdapter As laboratoriDataSetTableAdapters.elementTableAdapter
    Friend WithEvents ElementBindingSource As BindingSource
    Friend WithEvents ElementDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents FormulaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents ForElemBindingSource As BindingSource
    Friend WithEvents ForElemTableAdapter As laboratoriDataSetTableAdapters.forElemTableAdapter
    Friend WithEvents ForElemDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
End Class
