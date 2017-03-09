Public Class frmTabControl
    Inherits System.Windows.Forms.Form
    'Array y Contador
    Dim aConcursantes(,) As String
    Dim cConcursantes, i As Integer
    Dim vAgregado As Boolean = False
    Dim vConcurso As Boolean = False

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCuadro As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDire As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboEspe As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents lvConcursantes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboAgregados As System.Windows.Forms.ComboBox
    Friend WithEvents chklPremios As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmdConcursar As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCuadro = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.lvConcursantes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cboEspe = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDire = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmdConcursar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chklPremios = New System.Windows.Forms.CheckedListBox()
        Me.cboAgregados = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCuadro.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso de Datos"
        '
        'tbCuadro
        '
        Me.tbCuadro.Controls.Add(Me.TabPage1)
        Me.tbCuadro.Controls.Add(Me.TabPage2)
        Me.tbCuadro.Controls.Add(Me.TabPage3)
        Me.tbCuadro.Location = New System.Drawing.Point(16, 56)
        Me.tbCuadro.Name = "tbCuadro"
        Me.tbCuadro.SelectedIndex = 0
        Me.tbCuadro.Size = New System.Drawing.Size(592, 296)
        Me.tbCuadro.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmdBorrar)
        Me.TabPage1.Controls.Add(Me.lvConcursantes)
        Me.TabPage1.Controls.Add(Me.cmdAgregar)
        Me.TabPage1.Controls.Add(Me.cboEspe)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtDire)
        Me.TabPage1.Controls.Add(Me.txtNombre)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(584, 270)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Concursante"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrar.Location = New System.Drawing.Point(424, 72)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(88, 32)
        Me.cmdBorrar.TabIndex = 9
        Me.cmdBorrar.Text = "Borrar"
        '
        'lvConcursantes
        '
        Me.lvConcursantes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvConcursantes.GridLines = True
        Me.lvConcursantes.Location = New System.Drawing.Point(24, 144)
        Me.lvConcursantes.Name = "lvConcursantes"
        Me.lvConcursantes.Size = New System.Drawing.Size(544, 112)
        Me.lvConcursantes.TabIndex = 8
        Me.lvConcursantes.UseCompatibleStateImageBehavior = False
        Me.lvConcursantes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre"
        Me.ColumnHeader1.Width = 165
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Dirección"
        Me.ColumnHeader2.Width = 211
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Espacialidad"
        Me.ColumnHeader3.Width = 163
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(424, 32)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(88, 32)
        Me.cmdAgregar.TabIndex = 7
        Me.cmdAgregar.Text = "Agregar"
        '
        'cboEspe
        '
        Me.cboEspe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspe.Items.AddRange(New Object() {"Abogado", "Contador", "Economista", "Ingeniero", "Médico"})
        Me.cboEspe.Location = New System.Drawing.Point(144, 104)
        Me.cboEspe.Name = "cboEspe"
        Me.cboEspe.Size = New System.Drawing.Size(232, 21)
        Me.cboEspe.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Especialidad:"
        '
        'txtDire
        '
        Me.txtDire.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDire.Location = New System.Drawing.Point(96, 64)
        Me.txtDire.Name = "txtDire"
        Me.txtDire.Size = New System.Drawing.Size(272, 20)
        Me.txtDire.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(96, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmdConcursar)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.chklPremios)
        Me.TabPage2.Controls.Add(Me.cboAgregados)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(584, 270)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Premios"
        '
        'cmdConcursar
        '
        Me.cmdConcursar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConcursar.Location = New System.Drawing.Point(240, 176)
        Me.cmdConcursar.Name = "cmdConcursar"
        Me.cmdConcursar.Size = New System.Drawing.Size(120, 32)
        Me.cmdConcursar.TabIndex = 11
        Me.cmdConcursar.Text = "Concursar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Premios"
        '
        'chklPremios
        '
        Me.chklPremios.CheckOnClick = True
        Me.chklPremios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklPremios.Items.AddRange(New Object() {"Curso ASP .Net", "Curso Net Remoting", "Track MCSD", "Track MCSE"})
        Me.chklPremios.Location = New System.Drawing.Point(48, 104)
        Me.chklPremios.MultiColumn = True
        Me.chklPremios.Name = "chklPremios"
        Me.chklPremios.Size = New System.Drawing.Size(472, 19)
        Me.chklPremios.TabIndex = 9
        '
        'cboAgregados
        '
        Me.cboAgregados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAgregados.Location = New System.Drawing.Point(176, 32)
        Me.cboAgregados.Name = "cboAgregados"
        Me.cboAgregados.Size = New System.Drawing.Size(304, 21)
        Me.cboAgregados.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Concursante"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(584, 270)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Concurso"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(152, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(284, 31)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Terminó el Concurso"
        '
        'frmTabControl
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 373)
        Me.Controls.Add(Me.tbCuadro)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTabControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Net Desarrollo  - Ing. Fernando Luque Sánchez - El Control TabControl"
        Me.tbCuadro.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        ReDim Preserve aConcursantes(2, cConcursantes)
        aConcursantes(0, cConcursantes) = txtNombre.Text
        aConcursantes(1, cConcursantes) = txtDire.Text
        aConcursantes(2, cConcursantes) = cboEspe.SelectedItem

        'Ingresar los datos al ListView
        lvConcursantes.Items.Add(aConcursantes(0, cConcursantes))
        lvConcursantes.Items(cConcursantes).SubItems.Add(aConcursantes(1, cConcursantes))
        lvConcursantes.Items(cConcursantes).SubItems.Add(aConcursantes(2, cConcursantes))

        cConcursantes += 1

        vAgregado = True
    End Sub

    Private Sub SeleccionPages(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles tbCuadro.SelectedIndexChanged
        'Seleccionar las páginas de Premios, Concurso y Puntajes 
        'sin agregar concursantes.-

        If vAgregado = False AndAlso tbCuadro.SelectedIndex > 0 Then
            tbCuadro.SelectedIndex = 0
            MessageBox.Show("Falta ingresar Concursantes", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf vAgregado = True And cConcursantes = 1 And tbCuadro.SelectedIndex = 1 Then
            tbCuadro.SelectedIndex = 0
            MessageBox.Show("Mínimo 02 Concursantes", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        ElseIf tbCuadro.SelectedIndex = 2 And vConcurso = False Then
            tbCuadro.SelectedIndex = 1
            MessageBox.Show("Falta Seleccionar Premios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        ElseIf tbCuadro.SelectedIndex = 1 Then
            If cboAgregados.Items.Count = 0 Then
                For i = 0 To aConcursantes.GetLength(1) - 1
                    cboAgregados.Items.Add(aConcursantes(0, i))
                Next
            End If
        End If
    End Sub

    Private Sub Concursar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConcursar.Click
        If cboAgregados.SelectedIndex = -1 Or chklPremios.SelectedIndices.Count = 0 Then
            MessageBox.Show("Seleccionar...", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        Else
            vConcurso = True
        End If
    End Sub

    Private Sub frmTabControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub Borrar(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles cmdBorrar.Click
        vAgregado = False
        vConcurso = False
        lvConcursantes.Items.Clear()
        cConcursantes = 0
        ReDim aConcursantes(2, 0)
    End Sub
End Class
