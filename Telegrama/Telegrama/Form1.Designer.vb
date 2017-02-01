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
        Me.ComboDelimitador = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.ButtonPrice = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ComboDelimitador
        '
        Me.ComboDelimitador.Enabled = False
        Me.ComboDelimitador.FormattingEnabled = True
        Me.ComboDelimitador.Items.AddRange(New Object() {"space", ";", ",", "tab", "-"})
        Me.ComboDelimitador.Location = New System.Drawing.Point(12, 36)
        Me.ComboDelimitador.Name = "ComboDelimitador"
        Me.ComboDelimitador.Size = New System.Drawing.Size(121, 21)
        Me.ComboDelimitador.TabIndex = 0
        Me.ComboDelimitador.Text = "Seleciona..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Delimitador"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Fitxer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(9, 66)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(39, 13)
        Me.LabelName.TabIndex = 3
        Me.LabelName.Text = "Arxiu..."
        '
        'ButtonPrice
        '
        Me.ButtonPrice.Enabled = False
        Me.ButtonPrice.Location = New System.Drawing.Point(239, 34)
        Me.ButtonPrice.Name = "ButtonPrice"
        Me.ButtonPrice.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrice.TabIndex = 4
        Me.ButtonPrice.Text = "Preu"
        Me.ButtonPrice.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 93)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(307, 116)
        Me.TextBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 222)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonPrice)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboDelimitador)
        Me.Name = "Form1"
        Me.Text = "Telegrama"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboDelimitador As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelName As Label
    Friend WithEvents ButtonPrice As Button
    Friend WithEvents TextBox1 As TextBox
End Class
