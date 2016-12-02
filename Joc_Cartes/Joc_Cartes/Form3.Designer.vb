<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.ImageMine = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageHero = New System.Windows.Forms.ImageList(Me.components)
        Me.ImagePortal = New System.Windows.Forms.ImageList(Me.components)
        Me.ImagePokemon = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageFondos = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ImageMine
        '
        Me.ImageMine.ImageStream = CType(resources.GetObject("ImageMine.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageMine.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageMine.Images.SetKeyName(0, "mineChest0.png")
        Me.ImageMine.Images.SetKeyName(1, "mineChest1.png")
        Me.ImageMine.Images.SetKeyName(2, "minePicaxe2.png")
        Me.ImageMine.Images.SetKeyName(3, "mineAxe3.png")
        Me.ImageMine.Images.SetKeyName(4, "mineHoe4.png")
        Me.ImageMine.Images.SetKeyName(5, "mineRedstone5.png")
        Me.ImageMine.Images.SetKeyName(6, "mineSlime6.png")
        Me.ImageMine.Images.SetKeyName(7, "mineSnow7.png")
        Me.ImageMine.Images.SetKeyName(8, "mineCart8.png")
        Me.ImageMine.Images.SetKeyName(9, "mineEgg9.png")
        Me.ImageMine.Images.SetKeyName(10, "mineExp10.png")
        Me.ImageMine.Images.SetKeyName(11, "mineNether11.png")
        '
        'ImageHero
        '
        Me.ImageHero.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageHero.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageHero.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImagePortal
        '
        Me.ImagePortal.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImagePortal.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImagePortal.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImagePokemon
        '
        Me.ImagePokemon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImagePokemon.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImagePokemon.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageFondos
        '
        Me.ImageFondos.TransparentColor = System.Drawing.Color.Transparent
        '
        'ButtonOk
        '
        Me.ButtonOk.Location = New System.Drawing.Point(287, 313)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOk.TabIndex = 0
        Me.ButtonOk.Text = "Button1"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonOk)
        Me.Name = "Form3"
        Me.Text = "Configuració"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageMine As ImageList
    Friend WithEvents ImageHero As ImageList
    Friend WithEvents ImagePortal As ImageList
    Friend WithEvents ImagePokemon As ImageList
    Friend WithEvents ImageFondos As ImageList
    Friend WithEvents ButtonOk As Button
End Class
