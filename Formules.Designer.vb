<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim Codi_fLabel As System.Windows.Forms.Label
        Dim NomLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim ActivaLabel As System.Windows.Forms.Label
        Dim Codi_eLabel As System.Windows.Forms.Label
        Dim NomLabel1 As System.Windows.Forms.Label
        Dim DataLabel1 As System.Windows.Forms.Label
        Dim QtLabel As System.Windows.Forms.Label
        Dim Codi_fLabel2 As System.Windows.Forms.Label
        Dim Codi_eLabel1 As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArxiuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonInsertElemForm = New System.Windows.Forms.Button()
        Me.Codi_eComboBox = New System.Windows.Forms.ComboBox()
        Me.ElementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaboratoriDataSet = New Formules.laboratoriDataSet()
        Me.Codi_fComboBox = New System.Windows.Forms.ComboBox()
        Me.FormulaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QtTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonInsertElem = New System.Windows.Forms.Button()
        Me.Codi_eTextBox = New System.Windows.Forms.TextBox()
        Me.NomTextBoxElem = New System.Windows.Forms.TextBox()
        Me.DataDateTimePickerElem = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Codi_fTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonInsertForm = New System.Windows.Forms.Button()
        Me.ActivaCheckBox = New System.Windows.Forms.CheckBox()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ForElemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormulaTableAdapter = New Formules.laboratoriDataSetTableAdapters.formulaTableAdapter()
        Me.TableAdapterManager = New Formules.laboratoriDataSetTableAdapters.TableAdapterManager()
        Me.ElementTableAdapter = New Formules.laboratoriDataSetTableAdapters.elementTableAdapter()
        Me.ForElemTableAdapter = New Formules.laboratoriDataSetTableAdapters.forElemTableAdapter()
        Codi_fLabel = New System.Windows.Forms.Label()
        NomLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        ActivaLabel = New System.Windows.Forms.Label()
        Codi_eLabel = New System.Windows.Forms.Label()
        NomLabel1 = New System.Windows.Forms.Label()
        DataLabel1 = New System.Windows.Forms.Label()
        QtLabel = New System.Windows.Forms.Label()
        Codi_fLabel2 = New System.Windows.Forms.Label()
        Codi_eLabel1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ElementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        CType(Me.ForElemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Codi_fLabel
        '
        Codi_fLabel.AutoSize = True
        Codi_fLabel.Location = New System.Drawing.Point(29, 22)
        Codi_fLabel.Name = "Codi_fLabel"
        Codi_fLabel.Size = New System.Drawing.Size(31, 13)
        Codi_fLabel.TabIndex = 1
        Codi_fLabel.Text = "Codi:"
        '
        'NomLabel
        '
        NomLabel.AutoSize = True
        NomLabel.Location = New System.Drawing.Point(29, 48)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(32, 13)
        NomLabel.TabIndex = 3
        NomLabel.Text = "Nom:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(29, 75)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 5
        DataLabel.Text = "Data:"
        '
        'ActivaLabel
        '
        ActivaLabel.AutoSize = True
        ActivaLabel.Location = New System.Drawing.Point(29, 102)
        ActivaLabel.Name = "ActivaLabel"
        ActivaLabel.Size = New System.Drawing.Size(40, 13)
        ActivaLabel.TabIndex = 7
        ActivaLabel.Text = "Activa:"
        '
        'Codi_eLabel
        '
        Codi_eLabel.AutoSize = True
        Codi_eLabel.Location = New System.Drawing.Point(29, 33)
        Codi_eLabel.Name = "Codi_eLabel"
        Codi_eLabel.Size = New System.Drawing.Size(31, 13)
        Codi_eLabel.TabIndex = 0
        Codi_eLabel.Text = "Codi:"
        '
        'NomLabel1
        '
        NomLabel1.AutoSize = True
        NomLabel1.Location = New System.Drawing.Point(29, 59)
        NomLabel1.Name = "NomLabel1"
        NomLabel1.Size = New System.Drawing.Size(32, 13)
        NomLabel1.TabIndex = 2
        NomLabel1.Text = "Nom:"
        '
        'DataLabel1
        '
        DataLabel1.AutoSize = True
        DataLabel1.Location = New System.Drawing.Point(29, 86)
        DataLabel1.Name = "DataLabel1"
        DataLabel1.Size = New System.Drawing.Size(33, 13)
        DataLabel1.TabIndex = 4
        DataLabel1.Text = "Data:"
        '
        'QtLabel
        '
        QtLabel.AutoSize = True
        QtLabel.Location = New System.Drawing.Point(21, 95)
        QtLabel.Name = "QtLabel"
        QtLabel.Size = New System.Drawing.Size(53, 13)
        QtLabel.TabIndex = 4
        QtLabel.Text = "Quantitat:"
        '
        'Codi_fLabel2
        '
        Codi_fLabel2.AutoSize = True
        Codi_fLabel2.Location = New System.Drawing.Point(21, 37)
        Codi_fLabel2.Name = "Codi_fLabel2"
        Codi_fLabel2.Size = New System.Drawing.Size(71, 13)
        Codi_fLabel2.TabIndex = 6
        Codi_fLabel2.Text = "Codi Formula:"
        '
        'Codi_eLabel1
        '
        Codi_eLabel1.AutoSize = True
        Codi_eLabel1.Location = New System.Drawing.Point(21, 65)
        Codi_eLabel1.Name = "Codi_eLabel1"
        Codi_eLabel1.Size = New System.Drawing.Size(72, 13)
        Codi_eLabel1.TabIndex = 7
        Codi_eLabel1.Text = "Codi Element:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArxiuToolStripMenuItem, Me.TaulesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(756, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArxiuToolStripMenuItem
        '
        Me.ArxiuToolStripMenuItem.Name = "ArxiuToolStripMenuItem"
        Me.ArxiuToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ArxiuToolStripMenuItem.Text = "Arxiu"
        '
        'TaulesToolStripMenuItem
        '
        Me.TaulesToolStripMenuItem.Name = "TaulesToolStripMenuItem"
        Me.TaulesToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.TaulesToolStripMenuItem.Text = "Taules"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(732, 458)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.ButtonDelete)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(724, 432)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Afegir"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(341, 211)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 9
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonInsertElemForm)
        Me.GroupBox3.Controls.Add(Me.Codi_eComboBox)
        Me.GroupBox3.Controls.Add(Me.Codi_fComboBox)
        Me.GroupBox3.Controls.Add(Codi_eLabel1)
        Me.GroupBox3.Controls.Add(Codi_fLabel2)
        Me.GroupBox3.Controls.Add(QtLabel)
        Me.GroupBox3.Controls.Add(Me.QtTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 299)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 127)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Element per Formula"
        '
        'ButtonInsertElemForm
        '
        Me.ButtonInsertElemForm.Location = New System.Drawing.Point(238, 98)
        Me.ButtonInsertElemForm.Name = "ButtonInsertElemForm"
        Me.ButtonInsertElemForm.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInsertElemForm.TabIndex = 11
        Me.ButtonInsertElemForm.Text = "Inserir"
        Me.ButtonInsertElemForm.UseVisualStyleBackColor = True
        '
        'Codi_eComboBox
        '
        Me.Codi_eComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElementBindingSource, "codi_e", True))
        Me.Codi_eComboBox.DataSource = Me.ElementBindingSource
        Me.Codi_eComboBox.DisplayMember = "nom"
        Me.Codi_eComboBox.FormattingEnabled = True
        Me.Codi_eComboBox.Location = New System.Drawing.Point(99, 62)
        Me.Codi_eComboBox.Name = "Codi_eComboBox"
        Me.Codi_eComboBox.Size = New System.Drawing.Size(175, 21)
        Me.Codi_eComboBox.TabIndex = 9
        Me.Codi_eComboBox.ValueMember = "codi_e"
        '
        'ElementBindingSource
        '
        Me.ElementBindingSource.DataMember = "element"
        Me.ElementBindingSource.DataSource = Me.LaboratoriDataSet
        '
        'LaboratoriDataSet
        '
        Me.LaboratoriDataSet.DataSetName = "laboratoriDataSet"
        Me.LaboratoriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Codi_fComboBox
        '
        Me.Codi_fComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormulaBindingSource, "codi_f", True))
        Me.Codi_fComboBox.DataSource = Me.FormulaBindingSource
        Me.Codi_fComboBox.DisplayMember = "nom"
        Me.Codi_fComboBox.FormattingEnabled = True
        Me.Codi_fComboBox.Location = New System.Drawing.Point(99, 32)
        Me.Codi_fComboBox.Name = "Codi_fComboBox"
        Me.Codi_fComboBox.Size = New System.Drawing.Size(175, 21)
        Me.Codi_fComboBox.TabIndex = 8
        Me.Codi_fComboBox.ValueMember = "codi_f"
        '
        'FormulaBindingSource
        '
        Me.FormulaBindingSource.DataMember = "formula"
        Me.FormulaBindingSource.DataSource = Me.LaboratoriDataSet
        '
        'QtTextBox
        '
        Me.QtTextBox.Location = New System.Drawing.Point(99, 93)
        Me.QtTextBox.Name = "QtTextBox"
        Me.QtTextBox.Size = New System.Drawing.Size(83, 20)
        Me.QtTextBox.TabIndex = 5
        Me.QtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonInsertElem)
        Me.GroupBox2.Controls.Add(Codi_eLabel)
        Me.GroupBox2.Controls.Add(Me.Codi_eTextBox)
        Me.GroupBox2.Controls.Add(NomLabel1)
        Me.GroupBox2.Controls.Add(Me.NomTextBoxElem)
        Me.GroupBox2.Controls.Add(DataLabel1)
        Me.GroupBox2.Controls.Add(Me.DataDateTimePickerElem)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 141)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Element"
        '
        'ButtonInsertElem
        '
        Me.ButtonInsertElem.Location = New System.Drawing.Point(238, 112)
        Me.ButtonInsertElem.Name = "ButtonInsertElem"
        Me.ButtonInsertElem.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInsertElem.TabIndex = 10
        Me.ButtonInsertElem.Text = "Inserir"
        Me.ButtonInsertElem.UseVisualStyleBackColor = True
        '
        'Codi_eTextBox
        '
        Me.Codi_eTextBox.Location = New System.Drawing.Point(74, 30)
        Me.Codi_eTextBox.Name = "Codi_eTextBox"
        Me.Codi_eTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Codi_eTextBox.TabIndex = 1
        '
        'NomTextBoxElem
        '
        Me.NomTextBoxElem.Location = New System.Drawing.Point(74, 56)
        Me.NomTextBoxElem.Name = "NomTextBoxElem"
        Me.NomTextBoxElem.Size = New System.Drawing.Size(200, 20)
        Me.NomTextBoxElem.TabIndex = 3
        '
        'DataDateTimePickerElem
        '
        Me.DataDateTimePickerElem.Location = New System.Drawing.Point(74, 82)
        Me.DataDateTimePickerElem.Name = "DataDateTimePickerElem"
        Me.DataDateTimePickerElem.Size = New System.Drawing.Size(200, 20)
        Me.DataDateTimePickerElem.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Codi_fTextBox)
        Me.GroupBox1.Controls.Add(Codi_fLabel)
        Me.GroupBox1.Controls.Add(Me.ButtonInsertForm)
        Me.GroupBox1.Controls.Add(NomLabel)
        Me.GroupBox1.Controls.Add(Me.ActivaCheckBox)
        Me.GroupBox1.Controls.Add(Me.NomTextBox)
        Me.GroupBox1.Controls.Add(ActivaLabel)
        Me.GroupBox1.Controls.Add(DataLabel)
        Me.GroupBox1.Controls.Add(Me.DataDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 125)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formula"
        '
        'Codi_fTextBox
        '
        Me.Codi_fTextBox.Location = New System.Drawing.Point(74, 15)
        Me.Codi_fTextBox.Name = "Codi_fTextBox"
        Me.Codi_fTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Codi_fTextBox.TabIndex = 10
        '
        'ButtonInsertForm
        '
        Me.ButtonInsertForm.Location = New System.Drawing.Point(238, 96)
        Me.ButtonInsertForm.Name = "ButtonInsertForm"
        Me.ButtonInsertForm.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInsertForm.TabIndex = 6
        Me.ButtonInsertForm.Text = "Inserir"
        Me.ButtonInsertForm.UseVisualStyleBackColor = True
        '
        'ActivaCheckBox
        '
        Me.ActivaCheckBox.Checked = True
        Me.ActivaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ActivaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FormulaBindingSource, "activa", True))
        Me.ActivaCheckBox.Location = New System.Drawing.Point(74, 97)
        Me.ActivaCheckBox.Name = "ActivaCheckBox"
        Me.ActivaCheckBox.Size = New System.Drawing.Size(17, 24)
        Me.ActivaCheckBox.TabIndex = 8
        Me.ActivaCheckBox.UseVisualStyleBackColor = True
        '
        'NomTextBox
        '
        Me.NomTextBox.Location = New System.Drawing.Point(74, 45)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomTextBox.TabIndex = 4
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.Location = New System.Drawing.Point(74, 71)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDateTimePicker.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(724, 432)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tractar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(207, 238)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TabControl2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(724, 432)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Llistar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(718, 432)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(710, 406)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Formula"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(710, 406)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Element"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(710, 406)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Formula - Element"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'ForElemBindingSource
        '
        Me.ForElemBindingSource.DataMember = "forElem"
        Me.ForElemBindingSource.DataSource = Me.LaboratoriDataSet
        '
        'FormulaTableAdapter
        '
        Me.FormulaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.elementTableAdapter = Nothing
        Me.TableAdapterManager.forElemTableAdapter = Nothing
        Me.TableAdapterManager.formulaTableAdapter = Me.FormulaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Formules.laboratoriDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ElementTableAdapter
        '
        Me.ElementTableAdapter.ClearBeforeFill = True
        '
        'ForElemTableAdapter
        '
        Me.ForElemTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 497)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ElementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratoriDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        CType(Me.ForElemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArxiuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonInsertForm As Button
    Friend WithEvents LaboratoriDataSet As laboratoriDataSet
    Friend WithEvents FormulaBindingSource As BindingSource
    Friend WithEvents FormulaTableAdapter As laboratoriDataSetTableAdapters.formulaTableAdapter
    Friend WithEvents TableAdapterManager As laboratoriDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomTextBox As TextBox
    Friend WithEvents DataDateTimePicker As DateTimePicker
    Friend WithEvents ActivaCheckBox As CheckBox
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ElementBindingSource As BindingSource
    Friend WithEvents ElementTableAdapter As laboratoriDataSetTableAdapters.elementTableAdapter
    Friend WithEvents Codi_eTextBox As TextBox
    Friend WithEvents NomTextBoxElem As TextBox
    Friend WithEvents DataDateTimePickerElem As DateTimePicker
    Friend WithEvents ForElemBindingSource As BindingSource
    Friend WithEvents ForElemTableAdapter As laboratoriDataSetTableAdapters.forElemTableAdapter
    Friend WithEvents QtTextBox As TextBox
    Friend WithEvents Codi_eComboBox As ComboBox
    Friend WithEvents Codi_fComboBox As ComboBox
    Friend WithEvents TaulesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ButtonInsertElemForm As Button
    Friend WithEvents ButtonInsertElem As Button
    Friend WithEvents Codi_fTextBox As TextBox
End Class
