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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouJocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SurtirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.ButtonConfig = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JocToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(647, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JocToolStripMenuItem
        '
        Me.JocToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouJocToolStripMenuItem, Me.SurtirToolStripMenuItem})
        Me.JocToolStripMenuItem.Name = "JocToolStripMenuItem"
        Me.JocToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.JocToolStripMenuItem.Text = "Joc"
        '
        'NouJocToolStripMenuItem
        '
        Me.NouJocToolStripMenuItem.Name = "NouJocToolStripMenuItem"
        Me.NouJocToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.NouJocToolStripMenuItem.Text = "Nou joc"
        '
        'SurtirToolStripMenuItem
        '
        Me.SurtirToolStripMenuItem.Name = "SurtirToolStripMenuItem"
        Me.SurtirToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SurtirToolStripMenuItem.Text = "Surtir"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Carte_Joc.My.Resources.Resources.titulo
        Me.PictureBox1.Location = New System.Drawing.Point(30, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(544, 96)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ButtonPlay
        '
        Me.ButtonPlay.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonPlay.Image = Global.Carte_Joc.My.Resources.Resources.botonJugar
        Me.ButtonPlay.Location = New System.Drawing.Point(430, 223)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(144, 53)
        Me.ButtonPlay.TabIndex = 2
        Me.ButtonPlay.UseVisualStyleBackColor = False
        '
        'ButtonConfig
        '
        Me.ButtonConfig.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonConfig.Image = Global.Carte_Joc.My.Resources.Resources.botoConfig
        Me.ButtonConfig.Location = New System.Drawing.Point(444, 291)
        Me.ButtonConfig.Name = "ButtonConfig"
        Me.ButtonConfig.Size = New System.Drawing.Size(117, 31)
        Me.ButtonConfig.TabIndex = 4
        Me.ButtonConfig.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Carte_Joc.My.Resources.Resources.book
        Me.ClientSize = New System.Drawing.Size(647, 363)
        Me.Controls.Add(Me.ButtonConfig)
        Me.Controls.Add(Me.ButtonPlay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Joc de memòria"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents JocToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouJocToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SurtirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonPlay As Button
    Friend WithEvents ButtonConfig As Button
End Class
