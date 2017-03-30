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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Qt_TextBox = New System.Windows.Forms.TextBox()
        Me.Insert_efButton = New System.Windows.Forms.Button()
        Me.Codi_eComboBox = New System.Windows.Forms.ComboBox()
        Me.ElementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaboratoriDataSet = New FLaboratori.laboratoriDataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Codi_fComboBox = New System.Windows.Forms.ComboBox()
        Me.FormulaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Date_eTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Inser_eButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Codi_eTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_eTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Date_fTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Insert_fButton = New System.Windows.Forms.Button()
        Me.Activa_fCheckBox = New System.Windows.Forms.CheckBox()
        Me.Nom_fTextBox = New System.Windows.Forms.TextBox()
        Me.Codi_fTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArxiuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormulaTableAdapter = New FLaboratori.laboratoriDataSetTableAdapters.formulaTableAdapter()
        Me.TableAdapterManager = New FLaboratori.laboratoriDataSetTableAdapters.TableAdapterManager()
        Me.ElementTableAdapter = New FLaboratori.laboratoriDataSetTableAdapters.elementTableAdapter()
        Me.ForElemTableAdapter = New FLaboratori.laboratoriDataSetTableAdapters.forElemTableAdapter()
        Me.ForElemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ElementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ForElemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(553, 455)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(545, 429)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Insertar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Qt_TextBox)
        Me.GroupBox3.Controls.Add(Me.Insert_efButton)
        Me.GroupBox3.Controls.Add(Me.Codi_eComboBox)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Codi_fComboBox)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 285)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(311, 138)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Element per Formula"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Quantitat"
        '
        'Qt_TextBox
        '
        Me.Qt_TextBox.Location = New System.Drawing.Point(99, 77)
        Me.Qt_TextBox.Name = "Qt_TextBox"
        Me.Qt_TextBox.Size = New System.Drawing.Size(69, 20)
        Me.Qt_TextBox.TabIndex = 15
        Me.Qt_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Insert_efButton
        '
        Me.Insert_efButton.Location = New System.Drawing.Point(174, 75)
        Me.Insert_efButton.Name = "Insert_efButton"
        Me.Insert_efButton.Size = New System.Drawing.Size(109, 23)
        Me.Insert_efButton.TabIndex = 14
        Me.Insert_efButton.Text = "Inserir"
        Me.Insert_efButton.UseVisualStyleBackColor = True
        '
        'Codi_eComboBox
        '
        Me.Codi_eComboBox.DataSource = Me.ElementBindingSource
        Me.Codi_eComboBox.DisplayMember = "nom"
        Me.Codi_eComboBox.FormattingEnabled = True
        Me.Codi_eComboBox.Location = New System.Drawing.Point(99, 48)
        Me.Codi_eComboBox.Name = "Codi_eComboBox"
        Me.Codi_eComboBox.Size = New System.Drawing.Size(184, 21)
        Me.Codi_eComboBox.TabIndex = 3
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Codi Element"
        '
        'Codi_fComboBox
        '
        Me.Codi_fComboBox.DataSource = Me.FormulaBindingSource
        Me.Codi_fComboBox.DisplayMember = "nom"
        Me.Codi_fComboBox.FormattingEnabled = True
        Me.Codi_fComboBox.Location = New System.Drawing.Point(99, 21)
        Me.Codi_fComboBox.Name = "Codi_fComboBox"
        Me.Codi_fComboBox.Size = New System.Drawing.Size(184, 21)
        Me.Codi_fComboBox.TabIndex = 1
        Me.Codi_fComboBox.ValueMember = "codi_f"
        '
        'FormulaBindingSource
        '
        Me.FormulaBindingSource.DataMember = "formula"
        Me.FormulaBindingSource.DataSource = Me.LaboratoriDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codi Formula"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Date_eTimePicker)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Inser_eButton)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Codi_eTextBox)
        Me.GroupBox2.Controls.Add(Me.Nom_eTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 129)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Element"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Data"
        '
        'Date_eTimePicker
        '
        Me.Date_eTimePicker.Location = New System.Drawing.Point(73, 72)
        Me.Date_eTimePicker.Name = "Date_eTimePicker"
        Me.Date_eTimePicker.Size = New System.Drawing.Size(210, 20)
        Me.Date_eTimePicker.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nom"
        '
        'Inser_eButton
        '
        Me.Inser_eButton.Location = New System.Drawing.Point(174, 100)
        Me.Inser_eButton.Name = "Inser_eButton"
        Me.Inser_eButton.Size = New System.Drawing.Size(109, 23)
        Me.Inser_eButton.TabIndex = 12
        Me.Inser_eButton.Text = "Inserir"
        Me.Inser_eButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Codi"
        '
        'Codi_eTextBox
        '
        Me.Codi_eTextBox.Location = New System.Drawing.Point(73, 20)
        Me.Codi_eTextBox.Name = "Codi_eTextBox"
        Me.Codi_eTextBox.Size = New System.Drawing.Size(210, 20)
        Me.Codi_eTextBox.TabIndex = 10
        '
        'Nom_eTextBox
        '
        Me.Nom_eTextBox.Location = New System.Drawing.Point(73, 46)
        Me.Nom_eTextBox.Name = "Nom_eTextBox"
        Me.Nom_eTextBox.Size = New System.Drawing.Size(210, 20)
        Me.Nom_eTextBox.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Date_fTimePicker)
        Me.GroupBox1.Controls.Add(Me.Insert_fButton)
        Me.GroupBox1.Controls.Add(Me.Activa_fCheckBox)
        Me.GroupBox1.Controls.Add(Me.Nom_fTextBox)
        Me.GroupBox1.Controls.Add(Me.Codi_fTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formula"
        '
        'Date_fTimePicker
        '
        Me.Date_fTimePicker.Location = New System.Drawing.Point(73, 78)
        Me.Date_fTimePicker.Name = "Date_fTimePicker"
        Me.Date_fTimePicker.Size = New System.Drawing.Size(210, 20)
        Me.Date_fTimePicker.TabIndex = 9
        '
        'Insert_fButton
        '
        Me.Insert_fButton.Location = New System.Drawing.Point(174, 106)
        Me.Insert_fButton.Name = "Insert_fButton"
        Me.Insert_fButton.Size = New System.Drawing.Size(109, 23)
        Me.Insert_fButton.TabIndex = 8
        Me.Insert_fButton.Text = "Inserir"
        Me.Insert_fButton.UseVisualStyleBackColor = True
        '
        'Activa_fCheckBox
        '
        Me.Activa_fCheckBox.AutoSize = True
        Me.Activa_fCheckBox.Location = New System.Drawing.Point(73, 110)
        Me.Activa_fCheckBox.Name = "Activa_fCheckBox"
        Me.Activa_fCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.Activa_fCheckBox.TabIndex = 7
        Me.Activa_fCheckBox.UseVisualStyleBackColor = True
        '
        'Nom_fTextBox
        '
        Me.Nom_fTextBox.Location = New System.Drawing.Point(73, 52)
        Me.Nom_fTextBox.Name = "Nom_fTextBox"
        Me.Nom_fTextBox.Size = New System.Drawing.Size(210, 20)
        Me.Nom_fTextBox.TabIndex = 5
        '
        'Codi_fTextBox
        '
        Me.Codi_fTextBox.Location = New System.Drawing.Point(73, 26)
        Me.Codi_fTextBox.Name = "Codi_fTextBox"
        Me.Codi_fTextBox.Size = New System.Drawing.Size(210, 20)
        Me.Codi_fTextBox.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Activa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codi"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(545, 429)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modificar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArxiuToolStripMenuItem, Me.TaulesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(577, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArxiuToolStripMenuItem
        '
        Me.ArxiuToolStripMenuItem.Name = "ArxiuToolStripMenuItem"
        Me.ArxiuToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ArxiuToolStripMenuItem.Text = "Arxiu"
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
        'ForElemBindingSource
        '
        Me.ForElemBindingSource.DataMember = "forElem"
        Me.ForElemBindingSource.DataSource = Me.LaboratoriDataSet
        '
        'TaulesToolStripMenuItem
        '
        Me.TaulesToolStripMenuItem.Name = "TaulesToolStripMenuItem"
        Me.TaulesToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.TaulesToolStripMenuItem.Text = "Taules"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 506)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
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
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ForElemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArxiuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaboratoriDataSet As laboratoriDataSet
    Friend WithEvents FormulaBindingSource As BindingSource
    Friend WithEvents FormulaTableAdapter As laboratoriDataSetTableAdapters.formulaTableAdapter
    Friend WithEvents TableAdapterManager As laboratoriDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Insert_efButton As Button
    Friend WithEvents Codi_eComboBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Codi_fComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Date_eTimePicker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Inser_eButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Codi_eTextBox As TextBox
    Friend WithEvents Nom_eTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Date_fTimePicker As DateTimePicker
    Friend WithEvents Insert_fButton As Button
    Friend WithEvents Activa_fCheckBox As CheckBox
    Friend WithEvents Nom_fTextBox As TextBox
    Friend WithEvents Codi_fTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ElementTableAdapter As laboratoriDataSetTableAdapters.elementTableAdapter
    Friend WithEvents ElementBindingSource As BindingSource
    Friend WithEvents ForElemTableAdapter As laboratoriDataSetTableAdapters.forElemTableAdapter
    Friend WithEvents ForElemBindingSource As BindingSource
    Friend WithEvents Label10 As Label
    Friend WithEvents Qt_TextBox As TextBox
    Friend WithEvents TaulesToolStripMenuItem As ToolStripMenuItem
End Class
