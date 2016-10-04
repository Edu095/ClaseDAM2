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
        Me.diaBox = New System.Windows.Forms.ComboBox()
        Me.mesBox = New System.Windows.Forms.ComboBox()
        Me.anyBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'diaBox
        '
        Me.diaBox.FormattingEnabled = True
        Me.diaBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.diaBox.Location = New System.Drawing.Point(12, 38)
        Me.diaBox.Name = "diaBox"
        Me.diaBox.Size = New System.Drawing.Size(42, 21)
        Me.diaBox.TabIndex = 0
        '
        'mesBox
        '
        Me.mesBox.FormattingEnabled = True
        Me.mesBox.Items.AddRange(New Object() {"Gen", "Feb", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dec"})
        Me.mesBox.Location = New System.Drawing.Point(71, 38)
        Me.mesBox.Name = "mesBox"
        Me.mesBox.Size = New System.Drawing.Size(42, 21)
        Me.mesBox.TabIndex = 1
        '
        'anyBox
        '
        Me.anyBox.FormattingEnabled = True
        Me.anyBox.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016"})
        Me.anyBox.Location = New System.Drawing.Point(130, 38)
        Me.anyBox.Name = "anyBox"
        Me.anyBox.Size = New System.Drawing.Size(42, 21)
        Me.anyBox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Location = New System.Drawing.Point(54, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Mostrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(187, 155)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.anyBox)
        Me.Controls.Add(Me.mesBox)
        Me.Controls.Add(Me.diaBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents diaBox As ComboBox
    Friend WithEvents mesBox As ComboBox
    Friend WithEvents anyBox As ComboBox
    Friend WithEvents Button1 As Button
End Class
