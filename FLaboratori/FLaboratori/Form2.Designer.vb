<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Formules_TabPage = New System.Windows.Forms.TabPage()
        Me.DataGridViewForElem = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codie1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForElemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaboratoriDataSet = New FLaboratori.laboratoriDataSet()
        Me.FormulaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FormulaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Elements_TabPage = New System.Windows.Forms.TabPage()
        Me.ForElemDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElementDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElemForm_TabPage = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codie1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForElemDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarTaulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltrarDadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelFiltre = New System.Windows.Forms.Label()
        Me.FormulaTableAdapter = New FLaboratori.laboratoriDataSetTableAdapters.formulaTableAdapter()
        Me.TableAdapterManager = New FLaboratori.laboratoriDataSetTableAdapters.TableAdapterManager()
        Me.ElementTableAdapter = New FLaboratori.laboratoriDataSetTableAdapters.elementTableAdapter()
        Me.ForElemTableAdapter = New FLaboratori.laboratoriDataSetTableAdapters.forElemTableAdapter()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Formules_TabPage.SuspendLayout()
        CType(Me.DataGridViewForElem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForElemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Elements_TabPage.SuspendLayout()
        CType(Me.ForElemDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElementDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElemForm_TabPage.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForElemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Formules_TabPage)
        Me.TabControl1.Controls.Add(Me.Elements_TabPage)
        Me.TabControl1.Controls.Add(Me.ElemForm_TabPage)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(526, 330)
        Me.TabControl1.TabIndex = 0
        '
        'Formules_TabPage
        '
        Me.Formules_TabPage.AutoScroll = True
        Me.Formules_TabPage.Controls.Add(Me.DataGridViewForElem)
        Me.Formules_TabPage.Controls.Add(Me.FormulaDataGridView)
        Me.Formules_TabPage.Location = New System.Drawing.Point(4, 22)
        Me.Formules_TabPage.Name = "Formules_TabPage"
        Me.Formules_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.Formules_TabPage.Size = New System.Drawing.Size(518, 304)
        Me.Formules_TabPage.TabIndex = 0
        Me.Formules_TabPage.Text = "Formules"
        Me.Formules_TabPage.UseVisualStyleBackColor = True
        '
        'DataGridViewForElem
        '
        Me.DataGridViewForElem.AllowUserToAddRows = False
        Me.DataGridViewForElem.AllowUserToDeleteRows = False
        Me.DataGridViewForElem.AutoGenerateColumns = False
        Me.DataGridViewForElem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewForElem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.Codie1DataGridViewTextBoxColumn, Me.QtDataGridViewTextBoxColumn})
        Me.DataGridViewForElem.DataSource = Me.ForElemBindingSource
        Me.DataGridViewForElem.Location = New System.Drawing.Point(3, 69)
        Me.DataGridViewForElem.Name = "DataGridViewForElem"
        Me.DataGridViewForElem.ReadOnly = True
        Me.DataGridViewForElem.Size = New System.Drawing.Size(509, 229)
        Me.DataGridViewForElem.TabIndex = 4
        Me.DataGridViewForElem.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "codi_f1"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Codi Formula"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'Codie1DataGridViewTextBoxColumn
        '
        Me.Codie1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Codie1DataGridViewTextBoxColumn.DataPropertyName = "codi_e1"
        Me.Codie1DataGridViewTextBoxColumn.HeaderText = "Codi Element"
        Me.Codie1DataGridViewTextBoxColumn.Name = "Codie1DataGridViewTextBoxColumn"
        Me.Codie1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'QtDataGridViewTextBoxColumn
        '
        Me.QtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QtDataGridViewTextBoxColumn.DataPropertyName = "qt"
        Me.QtDataGridViewTextBoxColumn.HeaderText = "Quantitat"
        Me.QtDataGridViewTextBoxColumn.Name = "QtDataGridViewTextBoxColumn"
        Me.QtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ForElemBindingSource
        '
        Me.ForElemBindingSource.DataMember = "forElem"
        Me.ForElemBindingSource.DataSource = Me.LaboratoriDataSet
        '
        'LaboratoriDataSet
        '
        Me.LaboratoriDataSet.DataSetName = "laboratoriDataSet"
        Me.LaboratoriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormulaDataGridView
        '
        Me.FormulaDataGridView.AllowUserToAddRows = False
        Me.FormulaDataGridView.AllowUserToDeleteRows = False
        Me.FormulaDataGridView.AutoGenerateColumns = False
        Me.FormulaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FormulaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.FormulaDataGridView.DataSource = Me.FormulaBindingSource
        Me.FormulaDataGridView.Location = New System.Drawing.Point(3, 6)
        Me.FormulaDataGridView.Name = "FormulaDataGridView"
        Me.FormulaDataGridView.ReadOnly = True
        Me.FormulaDataGridView.Size = New System.Drawing.Size(509, 292)
        Me.FormulaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codi_f"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codi Formula"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nom"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "activa"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Activa"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'FormulaBindingSource
        '
        Me.FormulaBindingSource.DataMember = "formula"
        Me.FormulaBindingSource.DataSource = Me.LaboratoriDataSet
        '
        'Elements_TabPage
        '
        Me.Elements_TabPage.AutoScroll = True
        Me.Elements_TabPage.Controls.Add(Me.ForElemDataGridView1)
        Me.Elements_TabPage.Controls.Add(Me.ElementDataGridView)
        Me.Elements_TabPage.Location = New System.Drawing.Point(4, 22)
        Me.Elements_TabPage.Name = "Elements_TabPage"
        Me.Elements_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.Elements_TabPage.Size = New System.Drawing.Size(518, 304)
        Me.Elements_TabPage.TabIndex = 1
        Me.Elements_TabPage.Text = "Elements"
        Me.Elements_TabPage.UseVisualStyleBackColor = True
        '
        'ForElemDataGridView1
        '
        Me.ForElemDataGridView1.AllowUserToAddRows = False
        Me.ForElemDataGridView1.AllowUserToDeleteRows = False
        Me.ForElemDataGridView1.AutoGenerateColumns = False
        Me.ForElemDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ForElemDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.ForElemDataGridView1.DataSource = Me.ForElemBindingSource
        Me.ForElemDataGridView1.Location = New System.Drawing.Point(3, 69)
        Me.ForElemDataGridView1.Name = "ForElemDataGridView1"
        Me.ForElemDataGridView1.ReadOnly = True
        Me.ForElemDataGridView1.Size = New System.Drawing.Size(509, 229)
        Me.ForElemDataGridView1.TabIndex = 7
        Me.ForElemDataGridView1.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "codi_f1"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Codi Formula"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "codi_e1"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Codi Element"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "qt"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Quantitat"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'ElementDataGridView
        '
        Me.ElementDataGridView.AllowUserToAddRows = False
        Me.ElementDataGridView.AllowUserToDeleteRows = False
        Me.ElementDataGridView.AutoGenerateColumns = False
        Me.ElementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ElementDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ElementDataGridView.DataSource = Me.ElementBindingSource
        Me.ElementDataGridView.Location = New System.Drawing.Point(3, 6)
        Me.ElementDataGridView.Name = "ElementDataGridView"
        Me.ElementDataGridView.ReadOnly = True
        Me.ElementDataGridView.Size = New System.Drawing.Size(509, 292)
        Me.ElementDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "codi_e"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Codi Element"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nom"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'ElementBindingSource
        '
        Me.ElementBindingSource.DataMember = "element"
        Me.ElementBindingSource.DataSource = Me.LaboratoriDataSet
        '
        'ElemForm_TabPage
        '
        Me.ElemForm_TabPage.AutoScroll = True
        Me.ElemForm_TabPage.Controls.Add(Me.DataGridView3)
        Me.ElemForm_TabPage.Controls.Add(Me.ForElemDataGridView)
        Me.ElemForm_TabPage.Location = New System.Drawing.Point(4, 22)
        Me.ElemForm_TabPage.Name = "ElemForm_TabPage"
        Me.ElemForm_TabPage.Size = New System.Drawing.Size(518, 304)
        Me.ElemForm_TabPage.TabIndex = 2
        Me.ElemForm_TabPage.Text = "Element per Formula"
        Me.ElemForm_TabPage.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.Codie1DataGridViewTextBoxColumn1, Me.QtDataGridViewTextBoxColumn1})
        Me.DataGridView3.DataSource = Me.ForElemBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(3, 6)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(509, 292)
        Me.DataGridView3.TabIndex = 3
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "codi_f1"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Codi Formula"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'Codie1DataGridViewTextBoxColumn1
        '
        Me.Codie1DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Codie1DataGridViewTextBoxColumn1.DataPropertyName = "codi_e1"
        Me.Codie1DataGridViewTextBoxColumn1.HeaderText = "Codi Element"
        Me.Codie1DataGridViewTextBoxColumn1.Name = "Codie1DataGridViewTextBoxColumn1"
        Me.Codie1DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'QtDataGridViewTextBoxColumn1
        '
        Me.QtDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QtDataGridViewTextBoxColumn1.DataPropertyName = "qt"
        Me.QtDataGridViewTextBoxColumn1.HeaderText = "Quantitat"
        Me.QtDataGridViewTextBoxColumn1.Name = "QtDataGridViewTextBoxColumn1"
        Me.QtDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ForElemDataGridView
        '
        Me.ForElemDataGridView.AllowUserToAddRows = False
        Me.ForElemDataGridView.AllowUserToDeleteRows = False
        Me.ForElemDataGridView.AutoGenerateColumns = False
        Me.ForElemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ForElemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ForElemDataGridView.DataSource = Me.ForElemBindingSource
        Me.ForElemDataGridView.Location = New System.Drawing.Point(3, 6)
        Me.ForElemDataGridView.Name = "ForElemDataGridView"
        Me.ForElemDataGridView.ReadOnly = True
        Me.ForElemDataGridView.Size = New System.Drawing.Size(509, 292)
        Me.ForElemDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "codi_f1"
        Me.DataGridViewTextBoxColumn7.HeaderText = "codi_f1"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "codi_e1"
        Me.DataGridViewTextBoxColumn8.HeaderText = "codi_e1"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "qt"
        Me.DataGridViewTextBoxColumn9.HeaderText = "qt"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DadesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DadesToolStripMenuItem
        '
        Me.DadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarTaulesToolStripMenuItem, Me.FiltrarDadesToolStripMenuItem})
        Me.DadesToolStripMenuItem.Name = "DadesToolStripMenuItem"
        Me.DadesToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.DadesToolStripMenuItem.Text = "Filtrar dades"
        '
        'MostrarTaulesToolStripMenuItem
        '
        Me.MostrarTaulesToolStripMenuItem.Name = "MostrarTaulesToolStripMenuItem"
        Me.MostrarTaulesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.MostrarTaulesToolStripMenuItem.Text = "Totes les dades"
        '
        'FiltrarDadesToolStripMenuItem
        '
        Me.FiltrarDadesToolStripMenuItem.Name = "FiltrarDadesToolStripMenuItem"
        Me.FiltrarDadesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.FiltrarDadesToolStripMenuItem.Text = "Filtrar dades..."
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(544, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 268)
        Me.ComboBox1.TabIndex = 4
        '
        'LabelFiltre
        '
        Me.LabelFiltre.AutoSize = True
        Me.LabelFiltre.Location = New System.Drawing.Point(613, 33)
        Me.LabelFiltre.Name = "LabelFiltre"
        Me.LabelFiltre.Size = New System.Drawing.Size(29, 13)
        Me.LabelFiltre.TabIndex = 6
        Me.LabelFiltre.Text = "Nom"
        Me.LabelFiltre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormulaTableAdapter
        '
        Me.FormulaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.elementTableAdapter = Me.ElementTableAdapter
        Me.TableAdapterManager.forElemTableAdapter = Me.ForElemTableAdapter
        Me.TableAdapterManager.formulaTableAdapter = Me.FormulaTableAdapter
        Me.TableAdapterManager.UpdateOrder = FLaboratori.laboratoriDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ElementTableAdapter
        '
        Me.ElementTableAdapter.ClearBeforeFill = True
        '
        'ForElemTableAdapter
        '
        Me.ForElemTableAdapter.ClearBeforeFill = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(544, 313)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(178, 40)
        Me.ButtonDelete.TabIndex = 7
        Me.ButtonDelete.Text = "ELIMINAR REGISTRE"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 366)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.LabelFiltre)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Taules"
        Me.TabControl1.ResumeLayout(False)
        Me.Formules_TabPage.ResumeLayout(False)
        CType(Me.DataGridViewForElem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForElemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratoriDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Elements_TabPage.ResumeLayout(False)
        CType(Me.ForElemDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElementDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElemForm_TabPage.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForElemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Formules_TabPage As TabPage
    Friend WithEvents Elements_TabPage As TabPage
    Friend WithEvents ElemForm_TabPage As TabPage
    Friend WithEvents LaboratoriDataSet As laboratoriDataSet
    Friend WithEvents FormulaBindingSource As BindingSource
    Friend WithEvents FormulaTableAdapter As laboratoriDataSetTableAdapters.formulaTableAdapter
    Friend WithEvents TableAdapterManager As laboratoriDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FormulaDataGridView As DataGridView
    Friend WithEvents ElementTableAdapter As laboratoriDataSetTableAdapters.elementTableAdapter
    Friend WithEvents ElementBindingSource As BindingSource
    Friend WithEvents ElementDataGridView As DataGridView
    Friend WithEvents ForElemTableAdapter As laboratoriDataSetTableAdapters.forElemTableAdapter
    Friend WithEvents ForElemBindingSource As BindingSource
    Friend WithEvents ForElemDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FiltrarDadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarTaulesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewForElem As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelFiltre As Label
    Friend WithEvents Codif1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Codie1DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QtDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ForElemDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Codie1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButtonDelete As Button
End Class
