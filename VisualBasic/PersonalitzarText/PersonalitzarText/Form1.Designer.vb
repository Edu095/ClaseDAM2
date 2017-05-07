<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.fontBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sizeBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.negButton = New System.Windows.Forms.CheckBox()
        Me.cursButton = New System.Windows.Forms.CheckBox()
        Me.subButton = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeForm1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rBar = New System.Windows.Forms.TrackBar()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.gBar = New System.Windows.Forms.TrackBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.bBar = New System.Windows.Forms.TrackBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.rBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fontBox
        '
        Me.fontBox.FormattingEnabled = True
        Me.fontBox.Location = New System.Drawing.Point(12, 65)
        Me.fontBox.Name = "fontBox"
        Me.fontBox.Size = New System.Drawing.Size(111, 95)
        Me.fontBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Font"
        '
        'sizeBox
        '
        Me.sizeBox.FormattingEnabled = True
        Me.sizeBox.Items.AddRange(New Object() {"9", "10", "11", "12", "13", "14", "18"})
        Me.sizeBox.Location = New System.Drawing.Point(223, 116)
        Me.sizeBox.Name = "sizeBox"
        Me.sizeBox.Size = New System.Drawing.Size(42, 21)
        Me.sizeBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tamany"
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(12, 422)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(253, 20)
        Me.TextBox.TabIndex = 4
        Me.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Text"
        '
        'Button
        '
        Me.Button.Location = New System.Drawing.Point(200, 474)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(75, 23)
        Me.Button.TabIndex = 9
        Me.Button.Text = "Actualitza"
        Me.Button.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Estil"
        '
        'negButton
        '
        Me.negButton.AutoSize = True
        Me.negButton.Location = New System.Drawing.Point(138, 67)
        Me.negButton.Name = "negButton"
        Me.negButton.Size = New System.Drawing.Size(64, 17)
        Me.negButton.TabIndex = 11
        Me.negButton.Text = "Negreta"
        Me.negButton.UseVisualStyleBackColor = True
        '
        'cursButton
        '
        Me.cursButton.AutoSize = True
        Me.cursButton.Location = New System.Drawing.Point(138, 103)
        Me.cursButton.Name = "cursButton"
        Me.cursButton.Size = New System.Drawing.Size(61, 17)
        Me.cursButton.TabIndex = 12
        Me.cursButton.Text = "Cursiva"
        Me.cursButton.UseVisualStyleBackColor = True
        '
        'subButton
        '
        Me.subButton.AutoSize = True
        Me.subButton.Location = New System.Drawing.Point(138, 141)
        Me.subButton.Name = "subButton"
        Me.subButton.Size = New System.Drawing.Size(67, 17)
        Me.subButton.TabIndex = 13
        Me.subButton.Text = "Subrallat"
        Me.subButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(290, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerAyudaToolStripMenuItem, Me.AcercaDeForm1ToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'VerAyudaToolStripMenuItem
        '
        Me.VerAyudaToolStripMenuItem.Name = "VerAyudaToolStripMenuItem"
        Me.VerAyudaToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.VerAyudaToolStripMenuItem.Text = "Ver Ayuda"
        '
        'AcercaDeForm1ToolStripMenuItem
        '
        Me.AcercaDeForm1ToolStripMenuItem.Name = "AcercaDeForm1ToolStripMenuItem"
        Me.AcercaDeForm1ToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AcercaDeForm1ToolStripMenuItem.Text = "Acerca de PdT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Selecciona el color"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(229, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "R"
        '
        'rBar
        '
        Me.rBar.Location = New System.Drawing.Point(15, 211)
        Me.rBar.Maximum = 255
        Me.rBar.Name = "rBar"
        Me.rBar.Size = New System.Drawing.Size(196, 45)
        Me.rBar.TabIndex = 19
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(217, 224)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown1.TabIndex = 20
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(217, 275)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown2.TabIndex = 23
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gBar
        '
        Me.gBar.Location = New System.Drawing.Point(15, 262)
        Me.gBar.Maximum = 255
        Me.gBar.Name = "gBar"
        Me.gBar.Size = New System.Drawing.Size(196, 45)
        Me.gBar.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "G"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(217, 326)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown3.TabIndex = 26
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bBar
        '
        Me.bBar.Location = New System.Drawing.Point(15, 313)
        Me.bBar.Maximum = 255
        Me.bBar.Name = "bBar"
        Me.bBar.Size = New System.Drawing.Size(196, 45)
        Me.bBar.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(229, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "B"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(15, 364)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 20)
        Me.Panel1.TabIndex = 27
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 515)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.bBar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.gBar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.rBar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.subButton)
        Me.Controls.Add(Me.cursButton)
        Me.Controls.Add(Me.negButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sizeBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fontBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Personalitzador de Text"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.rBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fontBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sizeBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents negButton As CheckBox
    Friend WithEvents cursButton As CheckBox
    Friend WithEvents subButton As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeForm1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rBar As TrackBar
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents gBar As TrackBar
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents bBar As TrackBar
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
End Class
