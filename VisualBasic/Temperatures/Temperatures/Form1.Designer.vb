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
        Me.HScrollBarC = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scroll = New System.Windows.Forms.RadioButton()
        Me.manual = New System.Windows.Forms.RadioButton()
        Me.gC = New System.Windows.Forms.TextBox()
        Me.gF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HScrollBarF = New System.Windows.Forms.HScrollBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HScrollBarC
        '
        Me.HScrollBarC.Enabled = False
        Me.HScrollBarC.Location = New System.Drawing.Point(119, 39)
        Me.HScrollBarC.Maximum = 50
        Me.HScrollBarC.Minimum = -50
        Me.HScrollBarC.Name = "HScrollBarC"
        Me.HScrollBarC.Size = New System.Drawing.Size(273, 18)
        Me.HScrollBarC.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Graus Centigrads"
        '
        'scroll
        '
        Me.scroll.AutoSize = True
        Me.scroll.Location = New System.Drawing.Point(6, 55)
        Me.scroll.Name = "scroll"
        Me.scroll.Size = New System.Drawing.Size(51, 17)
        Me.scroll.TabIndex = 2
        Me.scroll.Text = "Scroll"
        Me.scroll.UseVisualStyleBackColor = True
        '
        'manual
        '
        Me.manual.AutoSize = True
        Me.manual.Checked = True
        Me.manual.Location = New System.Drawing.Point(6, 27)
        Me.manual.Name = "manual"
        Me.manual.Size = New System.Drawing.Size(60, 17)
        Me.manual.TabIndex = 3
        Me.manual.TabStop = True
        Me.manual.Text = "Manual"
        Me.manual.UseVisualStyleBackColor = True
        '
        'gC
        '
        Me.gC.Location = New System.Drawing.Point(119, 95)
        Me.gC.Name = "gC"
        Me.gC.Size = New System.Drawing.Size(100, 20)
        Me.gC.TabIndex = 4
        Me.gC.Text = "0"
        '
        'gF
        '
        Me.gF.Location = New System.Drawing.Point(119, 138)
        Me.gF.Name = "gF"
        Me.gF.Size = New System.Drawing.Size(100, 20)
        Me.gF.TabIndex = 5
        Me.gF.Text = "32"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Graus Centigrads"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Graus Fahrenheit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(12, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Graus Fahrenheit"
        '
        'HScrollBarF
        '
        Me.HScrollBarF.Enabled = False
        Me.HScrollBarF.Location = New System.Drawing.Point(119, 194)
        Me.HScrollBarF.Maximum = 122
        Me.HScrollBarF.Minimum = -58
        Me.HScrollBarF.Name = "HScrollBarF"
        Me.HScrollBarF.Size = New System.Drawing.Size(273, 18)
        Me.HScrollBarF.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.manual)
        Me.GroupBox1.Controls.Add(Me.scroll)
        Me.GroupBox1.Location = New System.Drawing.Point(279, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 84)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mode de Conversió"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(405, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 218)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Sortir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "-50"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(360, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "50"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(360, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "122"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(126, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "-58"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 242)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HScrollBarF)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gF)
        Me.Controls.Add(Me.gC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HScrollBarC)
        Me.Name = "Form1"
        Me.Text = "Conversor de Temperatures"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HScrollBarC As HScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents scroll As RadioButton
    Friend WithEvents manual As RadioButton
    Friend WithEvents gC As TextBox
    Friend WithEvents gF As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HScrollBarF As HScrollBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
