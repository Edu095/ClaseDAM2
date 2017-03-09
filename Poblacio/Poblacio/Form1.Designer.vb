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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboBoxProvincies = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMunicipis = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonTotal = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDona = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHome = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonMun = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPro = New System.Windows.Forms.RadioButton()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextBoxNmun = New System.Windows.Forms.TextBox()
        Me.NumericPoblacio = New System.Windows.Forms.NumericUpDown()
        Me.LabelMunicipi = New System.Windows.Forms.Label()
        Me.LabelProvincies = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArxiuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimitzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBoxDonMun = New System.Windows.Forms.TextBox()
        Me.TextBoxHomMun = New System.Windows.Forms.TextBox()
        Me.TextBoxDonPro = New System.Windows.Forms.TextBox()
        Me.TextBoxHomPro = New System.Windows.Forms.TextBox()
        Me.TextBoxHmun = New System.Windows.Forms.TextBox()
        Me.TextBoxHprov = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxNprov = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelBot = New System.Windows.Forms.Label()
        Me.LabelTop = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxCondicio = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelCarrega = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericPoblacio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxProvincies
        '
        Me.ComboBoxProvincies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxProvincies.Enabled = False
        Me.ComboBoxProvincies.FormattingEnabled = True
        Me.ComboBoxProvincies.Location = New System.Drawing.Point(21, 39)
        Me.ComboBoxProvincies.Name = "ComboBoxProvincies"
        Me.ComboBoxProvincies.Size = New System.Drawing.Size(121, 267)
        Me.ComboBoxProvincies.TabIndex = 0
        '
        'ComboBoxMunicipis
        '
        Me.ComboBoxMunicipis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxMunicipis.Enabled = False
        Me.ComboBoxMunicipis.FormattingEnabled = True
        Me.ComboBoxMunicipis.Location = New System.Drawing.Point(171, 39)
        Me.ComboBoxMunicipis.Name = "ComboBoxMunicipis"
        Me.ComboBoxMunicipis.Size = New System.Drawing.Size(121, 267)
        Me.ComboBoxMunicipis.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonTotal)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDona)
        Me.GroupBox1.Controls.Add(Me.RadioButtonHome)
        Me.GroupBox1.Location = New System.Drawing.Point(139, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(64, 91)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexe"
        '
        'RadioButtonTotal
        '
        Me.RadioButtonTotal.AutoSize = True
        Me.RadioButtonTotal.Checked = True
        Me.RadioButtonTotal.Location = New System.Drawing.Point(7, 19)
        Me.RadioButtonTotal.Name = "RadioButtonTotal"
        Me.RadioButtonTotal.Size = New System.Drawing.Size(49, 17)
        Me.RadioButtonTotal.TabIndex = 2
        Me.RadioButtonTotal.TabStop = True
        Me.RadioButtonTotal.Text = "Total"
        Me.RadioButtonTotal.UseVisualStyleBackColor = True
        '
        'RadioButtonDona
        '
        Me.RadioButtonDona.AutoSize = True
        Me.RadioButtonDona.Location = New System.Drawing.Point(7, 65)
        Me.RadioButtonDona.Name = "RadioButtonDona"
        Me.RadioButtonDona.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonDona.TabIndex = 1
        Me.RadioButtonDona.Text = "Dona"
        Me.RadioButtonDona.UseVisualStyleBackColor = True
        '
        'RadioButtonHome
        '
        Me.RadioButtonHome.AutoSize = True
        Me.RadioButtonHome.Location = New System.Drawing.Point(7, 42)
        Me.RadioButtonHome.Name = "RadioButtonHome"
        Me.RadioButtonHome.Size = New System.Drawing.Size(53, 17)
        Me.RadioButtonHome.TabIndex = 0
        Me.RadioButtonHome.Text = "Home"
        Me.RadioButtonHome.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonMun)
        Me.GroupBox2.Controls.Add(Me.RadioButtonPro)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(83, 89)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dades de"
        '
        'RadioButtonMun
        '
        Me.RadioButtonMun.AutoSize = True
        Me.RadioButtonMun.Location = New System.Drawing.Point(7, 54)
        Me.RadioButtonMun.Name = "RadioButtonMun"
        Me.RadioButtonMun.Size = New System.Drawing.Size(64, 17)
        Me.RadioButtonMun.TabIndex = 1
        Me.RadioButtonMun.Text = "Municipi"
        Me.RadioButtonMun.UseVisualStyleBackColor = True
        '
        'RadioButtonPro
        '
        Me.RadioButtonPro.AutoSize = True
        Me.RadioButtonPro.Checked = True
        Me.RadioButtonPro.Location = New System.Drawing.Point(7, 26)
        Me.RadioButtonPro.Name = "RadioButtonPro"
        Me.RadioButtonPro.Size = New System.Drawing.Size(69, 17)
        Me.RadioButtonPro.TabIndex = 0
        Me.RadioButtonPro.TabStop = True
        Me.RadioButtonPro.Text = "Provincia"
        Me.RadioButtonPro.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonBuscar.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonBuscar.Location = New System.Drawing.Point(21, 198)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(182, 111)
        Me.ButtonBuscar.TabIndex = 4
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'TextBoxNmun
        '
        Me.TextBoxNmun.Enabled = False
        Me.TextBoxNmun.Location = New System.Drawing.Point(459, 65)
        Me.TextBoxNmun.Name = "TextBoxNmun"
        Me.TextBoxNmun.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxNmun.TabIndex = 5
        Me.TextBoxNmun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericPoblacio
        '
        Me.NumericPoblacio.Location = New System.Drawing.Point(104, 155)
        Me.NumericPoblacio.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.NumericPoblacio.Name = "NumericPoblacio"
        Me.NumericPoblacio.Size = New System.Drawing.Size(99, 20)
        Me.NumericPoblacio.TabIndex = 5
        Me.NumericPoblacio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelMunicipi
        '
        Me.LabelMunicipi.AutoSize = True
        Me.LabelMunicipi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMunicipi.Location = New System.Drawing.Point(171, 17)
        Me.LabelMunicipi.MinimumSize = New System.Drawing.Size(121, 0)
        Me.LabelMunicipi.Name = "LabelMunicipi"
        Me.LabelMunicipi.Size = New System.Drawing.Size(121, 19)
        Me.LabelMunicipi.TabIndex = 3
        Me.LabelMunicipi.Text = "Municipis"
        Me.LabelMunicipi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelProvincies
        '
        Me.LabelProvincies.AutoSize = True
        Me.LabelProvincies.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProvincies.Location = New System.Drawing.Point(21, 17)
        Me.LabelProvincies.MinimumSize = New System.Drawing.Size(121, 0)
        Me.LabelProvincies.Name = "LabelProvincies"
        Me.LabelProvincies.Size = New System.Drawing.Size(121, 19)
        Me.LabelProvincies.TabIndex = 2
        Me.LabelProvincies.Text = "Provincies"
        Me.LabelProvincies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArxiuToolStripMenuItem, Me.SortirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(617, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArxiuToolStripMenuItem
        '
        Me.ArxiuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ArxiuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarToolStripMenuItem})
        Me.ArxiuToolStripMenuItem.Name = "ArxiuToolStripMenuItem"
        Me.ArxiuToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ArxiuToolStripMenuItem.Text = "&Arxiu"
        '
        'ImportarToolStripMenuItem
        '
        Me.ImportarToolStripMenuItem.Image = CType(resources.GetObject("ImportarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImportarToolStripMenuItem.Name = "ImportarToolStripMenuItem"
        Me.ImportarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImportarToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ImportarToolStripMenuItem.Text = "&Importar..."
        '
        'SortirToolStripMenuItem
        '
        Me.SortirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimitzaToolStripMenuItem, Me.SortirToolStripMenuItem1})
        Me.SortirToolStripMenuItem.Name = "SortirToolStripMenuItem"
        Me.SortirToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SortirToolStripMenuItem.Text = "&Finestra"
        '
        'MinimitzaToolStripMenuItem
        '
        Me.MinimitzaToolStripMenuItem.Name = "MinimitzaToolStripMenuItem"
        Me.MinimitzaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MinimitzaToolStripMenuItem.Text = "&Minimitza"
        '
        'SortirToolStripMenuItem1
        '
        Me.SortirToolStripMenuItem1.Image = CType(resources.GetObject("SortirToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SortirToolStripMenuItem1.Name = "SortirToolStripMenuItem1"
        Me.SortirToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.SortirToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SortirToolStripMenuItem1.Text = "&Sortir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(202, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nº de municipis:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(594, 352)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.TextBoxDonMun)
        Me.TabPage1.Controls.Add(Me.TextBoxHomMun)
        Me.TabPage1.Controls.Add(Me.TextBoxDonPro)
        Me.TabPage1.Controls.Add(Me.TextBoxHomPro)
        Me.TabPage1.Controls.Add(Me.TextBoxHmun)
        Me.TabPage1.Controls.Add(Me.TextBoxHprov)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TextBoxNprov)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TextBoxNmun)
        Me.TabPage1.Controls.Add(Me.LabelProvincies)
        Me.TabPage1.Controls.Add(Me.LabelMunicipi)
        Me.TabPage1.Controls.Add(Me.ComboBoxMunicipis)
        Me.TabPage1.Controls.Add(Me.ComboBoxProvincies)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(586, 326)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dades"
        '
        'TextBoxDonMun
        '
        Me.TextBoxDonMun.Enabled = False
        Me.TextBoxDonMun.Location = New System.Drawing.Point(459, 290)
        Me.TextBoxDonMun.Name = "TextBoxDonMun"
        Me.TextBoxDonMun.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxDonMun.TabIndex = 21
        Me.TextBoxDonMun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxHomMun
        '
        Me.TextBoxHomMun.Enabled = False
        Me.TextBoxHomMun.Location = New System.Drawing.Point(459, 264)
        Me.TextBoxHomMun.Name = "TextBoxHomMun"
        Me.TextBoxHomMun.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxHomMun.TabIndex = 20
        Me.TextBoxHomMun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxDonPro
        '
        Me.TextBoxDonPro.Enabled = False
        Me.TextBoxDonPro.Location = New System.Drawing.Point(459, 215)
        Me.TextBoxDonPro.Name = "TextBoxDonPro"
        Me.TextBoxDonPro.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxDonPro.TabIndex = 19
        Me.TextBoxDonPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxHomPro
        '
        Me.TextBoxHomPro.Enabled = False
        Me.TextBoxHomPro.Location = New System.Drawing.Point(459, 189)
        Me.TextBoxHomPro.Name = "TextBoxHomPro"
        Me.TextBoxHomPro.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxHomPro.TabIndex = 18
        Me.TextBoxHomPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxHmun
        '
        Me.TextBoxHmun.Enabled = False
        Me.TextBoxHmun.Location = New System.Drawing.Point(459, 141)
        Me.TextBoxHmun.Name = "TextBoxHmun"
        Me.TextBoxHmun.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxHmun.TabIndex = 17
        Me.TextBoxHmun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxHprov
        '
        Me.TextBoxHprov.Enabled = False
        Me.TextBoxHprov.Location = New System.Drawing.Point(459, 115)
        Me.TextBoxHprov.Name = "TextBoxHprov"
        Me.TextBoxHprov.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxHprov.TabIndex = 16
        Me.TextBoxHprov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(323, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Homes per municipi:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(323, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Dones per municipi:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(323, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Dones per provincia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(323, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Homes per provincia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(323, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Habitants per municipi:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(323, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Habitants per provincia:"
        '
        'TextBoxNprov
        '
        Me.TextBoxNprov.Enabled = False
        Me.TextBoxNprov.Location = New System.Drawing.Point(459, 39)
        Me.TextBoxNprov.Name = "TextBoxNprov"
        Me.TextBoxNprov.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxNprov.TabIndex = 9
        Me.TextBoxNprov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nº de provincies:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.LabelBot)
        Me.TabPage2.Controls.Add(Me.LabelTop)
        Me.TabPage2.Controls.Add(Me.ListBox2)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.ComboBoxCondicio)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Controls.Add(Me.ButtonBuscar)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.NumericPoblacio)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(586, 326)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Buscar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(212, 188)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'LabelBot
        '
        Me.LabelBot.AutoSize = True
        Me.LabelBot.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBot.Location = New System.Drawing.Point(238, 170)
        Me.LabelBot.MinimumSize = New System.Drawing.Size(120, 0)
        Me.LabelBot.Name = "LabelBot"
        Me.LabelBot.Size = New System.Drawing.Size(120, 15)
        Me.LabelBot.TabIndex = 12
        Me.LabelBot.Text = "Té els municipis... "
        Me.LabelBot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTop
        '
        Me.LabelTop.AutoSize = True
        Me.LabelTop.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTop.Location = New System.Drawing.Point(238, 11)
        Me.LabelTop.MinimumSize = New System.Drawing.Size(120, 0)
        Me.LabelTop.Name = "LabelTop"
        Me.LabelTop.Size = New System.Drawing.Size(120, 18)
        Me.LabelTop.TabIndex = 11
        Me.LabelTop.Text = "Provincia"
        Me.LabelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(238, 188)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 121)
        Me.ListBox2.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Condició"
        '
        'ComboBoxCondicio
        '
        Me.ComboBoxCondicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCondicio.FormattingEnabled = True
        Me.ComboBoxCondicio.Items.AddRange(New Object() {"<", "<=", "=", ">=", ">"})
        Me.ComboBoxCondicio.Location = New System.Drawing.Point(21, 154)
        Me.ComboBoxCondicio.Name = "ComboBoxCondicio"
        Me.ComboBoxCondicio.Size = New System.Drawing.Size(45, 21)
        Me.ComboBoxCondicio.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(117, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Nº Població"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(238, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 121)
        Me.ListBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Arxiu carregat:"
        Me.Label3.Visible = False
        '
        'LabelCarrega
        '
        Me.LabelCarrega.AutoSize = True
        Me.LabelCarrega.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCarrega.ForeColor = System.Drawing.Color.Black
        Me.LabelCarrega.Location = New System.Drawing.Point(13, 382)
        Me.LabelCarrega.Name = "LabelCarrega"
        Me.LabelCarrega.Size = New System.Drawing.Size(132, 19)
        Me.LabelCarrega.TabIndex = 7
        Me.LabelCarrega.Text = "Carregant dades..."
        Me.LabelCarrega.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(202, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'ToolTip2
        '
        Me.ToolTip2.AutoPopDelay = 5000
        Me.ToolTip2.InitialDelay = 100
        Me.ToolTip2.IsBalloon = True
        Me.ToolTip2.ReshowDelay = 100
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(617, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.LabelCarrega)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Població Espanyola"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericPoblacio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxProvincies As ComboBox
    Friend WithEvents ComboBoxMunicipis As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonTotal As RadioButton
    Friend WithEvents RadioButtonDona As RadioButton
    Friend WithEvents RadioButtonHome As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonMun As RadioButton
    Friend WithEvents RadioButtonPro As RadioButton
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents TextBoxNmun As TextBox
    Friend WithEvents NumericPoblacio As NumericUpDown
    Friend WithEvents LabelMunicipi As Label
    Friend WithEvents LabelProvincies As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArxiuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelCarrega As Label
    Friend WithEvents TextBoxDonMun As TextBox
    Friend WithEvents TextBoxHomMun As TextBox
    Friend WithEvents TextBoxDonPro As TextBox
    Friend WithEvents TextBoxHomPro As TextBox
    Friend WithEvents TextBoxHmun As TextBox
    Friend WithEvents TextBoxHprov As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxNprov As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MinimitzaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBoxCondicio As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LabelBot As Label
    Friend WithEvents LabelTop As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolTip2 As ToolTip
End Class
