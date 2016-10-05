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
        Me.siceBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.negButton = New System.Windows.Forms.CheckBox()
        Me.cursButton = New System.Windows.Forms.CheckBox()
        Me.subButton = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'fontBox
        '
        Me.fontBox.FormattingEnabled = True
        Me.fontBox.Items.AddRange(New Object() {"Arial", "Times New Roman", "Helvetica", "Comic Sans"})
        Me.fontBox.Location = New System.Drawing.Point(12, 38)
        Me.fontBox.Name = "fontBox"
        Me.fontBox.Size = New System.Drawing.Size(111, 95)
        Me.fontBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Font"
        '
        'siceBox
        '
        Me.siceBox.FormattingEnabled = True
        Me.siceBox.Items.AddRange(New Object() {"9", "10", "11", "12", "13", "14", "18"})
        Me.siceBox.Location = New System.Drawing.Point(223, 89)
        Me.siceBox.Name = "siceBox"
        Me.siceBox.Size = New System.Drawing.Size(42, 21)
        Me.siceBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tamany"
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(12, 172)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(253, 20)
        Me.TextBox.TabIndex = 4
        Me.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Text"
        '
        'Button
        '
        Me.Button.Location = New System.Drawing.Point(200, 224)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(75, 23)
        Me.Button.TabIndex = 9
        Me.Button.Text = "Actualitza"
        Me.Button.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Estil"
        '
        'negButton
        '
        Me.negButton.AutoSize = True
        Me.negButton.Location = New System.Drawing.Point(138, 40)
        Me.negButton.Name = "negButton"
        Me.negButton.Size = New System.Drawing.Size(64, 17)
        Me.negButton.TabIndex = 11
        Me.negButton.Text = "Negreta"
        Me.negButton.UseVisualStyleBackColor = True
        '
        'cursButton
        '
        Me.cursButton.AutoSize = True
        Me.cursButton.Location = New System.Drawing.Point(138, 76)
        Me.cursButton.Name = "cursButton"
        Me.cursButton.Size = New System.Drawing.Size(61, 17)
        Me.cursButton.TabIndex = 12
        Me.cursButton.Text = "Cursiva"
        Me.cursButton.UseVisualStyleBackColor = True
        '
        'subButton
        '
        Me.subButton.AutoSize = True
        Me.subButton.Location = New System.Drawing.Point(138, 114)
        Me.subButton.Name = "subButton"
        Me.subButton.Size = New System.Drawing.Size(67, 17)
        Me.subButton.TabIndex = 13
        Me.subButton.Text = "Subrallat"
        Me.subButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 259)
        Me.Controls.Add(Me.subButton)
        Me.Controls.Add(Me.cursButton)
        Me.Controls.Add(Me.negButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.siceBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fontBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fontBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents siceBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents negButton As CheckBox
    Friend WithEvents cursButton As CheckBox
    Friend WithEvents subButton As CheckBox
End Class
