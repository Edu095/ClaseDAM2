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
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.TextBoxDNI = New System.Windows.Forms.TextBox()
        Me.ButtonIntroduir = New System.Windows.Forms.Button()
        Me.ButtonMostrar = New System.Windows.Forms.Button()
        Me.GroupBoxSex = New System.Windows.Forms.GroupBox()
        Me.RadioButtonFem = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMas = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ButtonSurt = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelDN = New System.Windows.Forms.Label()
        Me.LabelDNI = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaLlistaDalumnesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxInfo = New System.Windows.Forms.TextBox()
        Me.GroupBoxSex.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(50, 33)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxNom.TabIndex = 0
        '
        'TextBoxDNI
        '
        Me.TextBoxDNI.Location = New System.Drawing.Point(50, 116)
        Me.TextBoxDNI.Name = "TextBoxDNI"
        Me.TextBoxDNI.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxDNI.TabIndex = 1
        '
        'ButtonIntroduir
        '
        Me.ButtonIntroduir.Location = New System.Drawing.Point(175, 155)
        Me.ButtonIntroduir.Name = "ButtonIntroduir"
        Me.ButtonIntroduir.Size = New System.Drawing.Size(75, 45)
        Me.ButtonIntroduir.TabIndex = 2
        Me.ButtonIntroduir.Text = "Introduïr alumne"
        Me.ButtonIntroduir.UseVisualStyleBackColor = True
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(175, 208)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(75, 45)
        Me.ButtonMostrar.TabIndex = 3
        Me.ButtonMostrar.Text = "Mostrar noms"
        Me.ButtonMostrar.UseVisualStyleBackColor = True
        '
        'GroupBoxSex
        '
        Me.GroupBoxSex.Controls.Add(Me.RadioButtonFem)
        Me.GroupBoxSex.Controls.Add(Me.RadioButtonMas)
        Me.GroupBoxSex.Location = New System.Drawing.Point(18, 155)
        Me.GroupBoxSex.Name = "GroupBoxSex"
        Me.GroupBoxSex.Size = New System.Drawing.Size(98, 98)
        Me.GroupBoxSex.TabIndex = 4
        Me.GroupBoxSex.TabStop = False
        Me.GroupBoxSex.Text = "Sexe:"
        '
        'RadioButtonFem
        '
        Me.RadioButtonFem.AutoSize = True
        Me.RadioButtonFem.Location = New System.Drawing.Point(18, 61)
        Me.RadioButtonFem.Name = "RadioButtonFem"
        Me.RadioButtonFem.Size = New System.Drawing.Size(61, 17)
        Me.RadioButtonFem.TabIndex = 1
        Me.RadioButtonFem.TabStop = True
        Me.RadioButtonFem.Text = "Femení"
        Me.RadioButtonFem.UseVisualStyleBackColor = True
        '
        'RadioButtonMas
        '
        Me.RadioButtonMas.AutoSize = True
        Me.RadioButtonMas.Location = New System.Drawing.Point(18, 31)
        Me.RadioButtonMas.Name = "RadioButtonMas"
        Me.RadioButtonMas.Size = New System.Drawing.Size(63, 17)
        Me.RadioButtonMas.TabIndex = 0
        Me.RadioButtonMas.TabStop = True
        Me.RadioButtonMas.Text = "Masculí"
        Me.RadioButtonMas.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(50, 73)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'ButtonSurt
        '
        Me.ButtonSurt.Location = New System.Drawing.Point(18, 259)
        Me.ButtonSurt.Name = "ButtonSurt"
        Me.ButtonSurt.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSurt.TabIndex = 6
        Me.ButtonSurt.Text = "Sortir"
        Me.ButtonSurt.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(281, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(190, 228)
        Me.ComboBox1.TabIndex = 7
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(12, 36)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(32, 13)
        Me.LabelNom.TabIndex = 8
        Me.LabelNom.Text = "Nom:"
        '
        'LabelDN
        '
        Me.LabelDN.AutoSize = True
        Me.LabelDN.Location = New System.Drawing.Point(12, 78)
        Me.LabelDN.Name = "LabelDN"
        Me.LabelDN.Size = New System.Drawing.Size(32, 13)
        Me.LabelDN.TabIndex = 9
        Me.LabelDN.Text = "D_N:"
        '
        'LabelDNI
        '
        Me.LabelDNI.AutoSize = True
        Me.LabelDNI.Location = New System.Drawing.Point(15, 119)
        Me.LabelDNI.Name = "LabelDNI"
        Me.LabelDNI.Size = New System.Drawing.Size(29, 13)
        Me.LabelDNI.TabIndex = 10
        Me.LabelDNI.Text = "DNI:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(720, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaLlistaDalumnesToolStripMenuItem, Me.SortirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ArchivoToolStripMenuItem.Text = "Arxiu"
        '
        'NovaLlistaDalumnesToolStripMenuItem
        '
        Me.NovaLlistaDalumnesToolStripMenuItem.Name = "NovaLlistaDalumnesToolStripMenuItem"
        Me.NovaLlistaDalumnesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.NovaLlistaDalumnesToolStripMenuItem.Text = "Nova llista d'alumnes"
        '
        'SortirToolStripMenuItem
        '
        Me.SortirToolStripMenuItem.Name = "SortirToolStripMenuItem"
        Me.SortirToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SortirToolStripMenuItem.Text = "Sortir"
        '
        'TextBoxInfo
        '
        Me.TextBoxInfo.Location = New System.Drawing.Point(491, 81)
        Me.TextBoxInfo.Multiline = True
        Me.TextBoxInfo.Name = "TextBoxInfo"
        Me.TextBoxInfo.Size = New System.Drawing.Size(212, 122)
        Me.TextBoxInfo.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 298)
        Me.Controls.Add(Me.TextBoxInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelDNI)
        Me.Controls.Add(Me.LabelDN)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonSurt)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBoxSex)
        Me.Controls.Add(Me.ButtonMostrar)
        Me.Controls.Add(Me.ButtonIntroduir)
        Me.Controls.Add(Me.TextBoxDNI)
        Me.Controls.Add(Me.TextBoxNom)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBoxSex.ResumeLayout(False)
        Me.GroupBoxSex.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents TextBoxDNI As TextBox
    Friend WithEvents ButtonIntroduir As Button
    Friend WithEvents ButtonMostrar As Button
    Friend WithEvents GroupBoxSex As GroupBox
    Friend WithEvents RadioButtonFem As RadioButton
    Friend WithEvents RadioButtonMas As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ButtonSurt As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelDN As Label
    Friend WithEvents LabelDNI As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaLlistaDalumnesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxInfo As TextBox
End Class
