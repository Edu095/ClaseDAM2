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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.delElement = New System.Windows.Forms.Button()
        Me.delAll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 49)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 1
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(139, 49)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(92, 23)
        Me.addButton.TabIndex = 2
        Me.addButton.Text = "Afegir"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'delElement
        '
        Me.delElement.Location = New System.Drawing.Point(139, 84)
        Me.delElement.Name = "delElement"
        Me.delElement.Size = New System.Drawing.Size(92, 25)
        Me.delElement.TabIndex = 3
        Me.delElement.Text = "Esborra element"
        Me.delElement.UseVisualStyleBackColor = True
        '
        'delAll
        '
        Me.delAll.Location = New System.Drawing.Point(138, 121)
        Me.delAll.Name = "delAll"
        Me.delAll.Size = New System.Drawing.Size(93, 23)
        Me.delAll.TabIndex = 4
        Me.delAll.Text = "Esborra Llista"
        Me.delAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Introdueix Notes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 197)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.delAll)
        Me.Controls.Add(Me.delElement)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents addButton As Button
    Friend WithEvents delElement As Button
    Friend WithEvents delAll As Button
    Friend WithEvents Label1 As Label
End Class
