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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PB1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouJocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetejarPuntuacionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PB2 = New System.Windows.Forms.PictureBox()
        Me.PB3 = New System.Windows.Forms.PictureBox()
        Me.PB4 = New System.Windows.Forms.PictureBox()
        Me.PB5 = New System.Windows.Forms.PictureBox()
        Me.PB6 = New System.Windows.Forms.PictureBox()
        Me.PB7 = New System.Windows.Forms.PictureBox()
        Me.PB8 = New System.Windows.Forms.PictureBox()
        Me.PB9 = New System.Windows.Forms.PictureBox()
        Me.AxWinsock1 = New AxMSWinsockLib.AxWinsock()
        Me.AxWinsock2 = New AxMSWinsockLib.AxWinsock()
        Me.LocalIPTextBox = New System.Windows.Forms.TextBox()
        Me.RemotIpTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServerButton = New System.Windows.Forms.Button()
        Me.ClientButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.TimerTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxPuntsO = New System.Windows.Forms.TextBox()
        Me.PictureBoxX = New System.Windows.Forms.PictureBox()
        Me.PictureBoxO = New System.Windows.Forms.PictureBox()
        Me.TextBoxPuntsX = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBoxImg = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBoxBg = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWinsock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWinsock2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB1
        '
        Me.PB1.BackColor = System.Drawing.Color.Transparent
        Me.PB1.Enabled = False
        Me.PB1.Location = New System.Drawing.Point(197, 88)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(90, 90)
        Me.PB1.TabIndex = 0
        Me.PB1.TabStop = False
        Me.PB1.Tag = "1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JocToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JocToolStripMenuItem
        '
        Me.JocToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouJocToolStripMenuItem, Me.ToolStripSeparator1, Me.ResetejarPuntuacionsToolStripMenuItem})
        Me.JocToolStripMenuItem.Name = "JocToolStripMenuItem"
        Me.JocToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.JocToolStripMenuItem.Text = "Joc"
        '
        'NouJocToolStripMenuItem
        '
        Me.NouJocToolStripMenuItem.Name = "NouJocToolStripMenuItem"
        Me.NouJocToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.NouJocToolStripMenuItem.Text = "Nou Joc..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        Me.ToolStripSeparator1.Visible = False
        '
        'ResetejarPuntuacionsToolStripMenuItem
        '
        Me.ResetejarPuntuacionsToolStripMenuItem.Name = "ResetejarPuntuacionsToolStripMenuItem"
        Me.ResetejarPuntuacionsToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ResetejarPuntuacionsToolStripMenuItem.Text = "Resetejar puntuacions"
        Me.ResetejarPuntuacionsToolStripMenuItem.Visible = False
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'PB2
        '
        Me.PB2.BackColor = System.Drawing.Color.Transparent
        Me.PB2.Enabled = False
        Me.PB2.Location = New System.Drawing.Point(317, 88)
        Me.PB2.Name = "PB2"
        Me.PB2.Size = New System.Drawing.Size(90, 90)
        Me.PB2.TabIndex = 2
        Me.PB2.TabStop = False
        Me.PB2.Tag = "2"
        '
        'PB3
        '
        Me.PB3.BackColor = System.Drawing.Color.Transparent
        Me.PB3.Enabled = False
        Me.PB3.Location = New System.Drawing.Point(437, 88)
        Me.PB3.Name = "PB3"
        Me.PB3.Size = New System.Drawing.Size(90, 90)
        Me.PB3.TabIndex = 3
        Me.PB3.TabStop = False
        Me.PB3.Tag = "3"
        '
        'PB4
        '
        Me.PB4.BackColor = System.Drawing.Color.Transparent
        Me.PB4.Enabled = False
        Me.PB4.Location = New System.Drawing.Point(197, 208)
        Me.PB4.Name = "PB4"
        Me.PB4.Size = New System.Drawing.Size(90, 90)
        Me.PB4.TabIndex = 6
        Me.PB4.TabStop = False
        Me.PB4.Tag = "4"
        '
        'PB5
        '
        Me.PB5.BackColor = System.Drawing.Color.Transparent
        Me.PB5.Enabled = False
        Me.PB5.Location = New System.Drawing.Point(317, 208)
        Me.PB5.Name = "PB5"
        Me.PB5.Size = New System.Drawing.Size(90, 90)
        Me.PB5.TabIndex = 5
        Me.PB5.TabStop = False
        Me.PB5.Tag = "5"
        '
        'PB6
        '
        Me.PB6.BackColor = System.Drawing.Color.Transparent
        Me.PB6.Enabled = False
        Me.PB6.Location = New System.Drawing.Point(437, 208)
        Me.PB6.Name = "PB6"
        Me.PB6.Size = New System.Drawing.Size(90, 90)
        Me.PB6.TabIndex = 4
        Me.PB6.TabStop = False
        Me.PB6.Tag = "6"
        '
        'PB7
        '
        Me.PB7.BackColor = System.Drawing.Color.Transparent
        Me.PB7.Enabled = False
        Me.PB7.Location = New System.Drawing.Point(197, 328)
        Me.PB7.Name = "PB7"
        Me.PB7.Size = New System.Drawing.Size(90, 90)
        Me.PB7.TabIndex = 9
        Me.PB7.TabStop = False
        Me.PB7.Tag = "7"
        '
        'PB8
        '
        Me.PB8.BackColor = System.Drawing.Color.Transparent
        Me.PB8.Enabled = False
        Me.PB8.Location = New System.Drawing.Point(317, 328)
        Me.PB8.Name = "PB8"
        Me.PB8.Size = New System.Drawing.Size(90, 90)
        Me.PB8.TabIndex = 8
        Me.PB8.TabStop = False
        Me.PB8.Tag = "8"
        '
        'PB9
        '
        Me.PB9.BackColor = System.Drawing.Color.Transparent
        Me.PB9.Enabled = False
        Me.PB9.Location = New System.Drawing.Point(437, 328)
        Me.PB9.Name = "PB9"
        Me.PB9.Size = New System.Drawing.Size(90, 90)
        Me.PB9.TabIndex = 7
        Me.PB9.TabStop = False
        Me.PB9.Tag = "9"
        '
        'AxWinsock1
        '
        Me.AxWinsock1.Enabled = True
        Me.AxWinsock1.Location = New System.Drawing.Point(488, 27)
        Me.AxWinsock1.Name = "AxWinsock1"
        Me.AxWinsock1.OcxState = CType(resources.GetObject("AxWinsock1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWinsock1.Size = New System.Drawing.Size(28, 28)
        Me.AxWinsock1.TabIndex = 11
        '
        'AxWinsock2
        '
        Me.AxWinsock2.Enabled = True
        Me.AxWinsock2.Location = New System.Drawing.Point(522, 27)
        Me.AxWinsock2.Name = "AxWinsock2"
        Me.AxWinsock2.OcxState = CType(resources.GetObject("AxWinsock2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWinsock2.Size = New System.Drawing.Size(28, 28)
        Me.AxWinsock2.TabIndex = 12
        '
        'LocalIPTextBox
        '
        Me.LocalIPTextBox.Enabled = False
        Me.LocalIPTextBox.Location = New System.Drawing.Point(12, 95)
        Me.LocalIPTextBox.Name = "LocalIPTextBox"
        Me.LocalIPTextBox.Size = New System.Drawing.Size(147, 20)
        Me.LocalIPTextBox.TabIndex = 13
        Me.LocalIPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RemotIpTextBox
        '
        Me.RemotIpTextBox.Location = New System.Drawing.Point(12, 153)
        Me.RemotIpTextBox.Name = "RemotIpTextBox"
        Me.RemotIpTextBox.Size = New System.Drawing.Size(147, 20)
        Me.RemotIpTextBox.TabIndex = 14
        Me.RemotIpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "IP Local:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "IP Remota:"
        '
        'ServerButton
        '
        Me.ServerButton.Location = New System.Drawing.Point(12, 211)
        Me.ServerButton.Name = "ServerButton"
        Me.ServerButton.Size = New System.Drawing.Size(147, 23)
        Me.ServerButton.TabIndex = 17
        Me.ServerButton.Text = "Crear Servidor"
        Me.ServerButton.UseVisualStyleBackColor = True
        '
        'ClientButton
        '
        Me.ClientButton.Location = New System.Drawing.Point(12, 241)
        Me.ClientButton.Name = "ClientButton"
        Me.ClientButton.Size = New System.Drawing.Size(147, 23)
        Me.ClientButton.TabIndex = 18
        Me.ClientButton.Text = "Connectar"
        Me.ClientButton.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Enabled = False
        Me.StartButton.Location = New System.Drawing.Point(15, 310)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(144, 45)
        Me.StartButton.TabIndex = 19
        Me.StartButton.Text = "Començar Partida"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'TimerTextBox
        '
        Me.TimerTextBox.BackColor = System.Drawing.Color.White
        Me.TimerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerTextBox.Location = New System.Drawing.Point(55, 463)
        Me.TimerTextBox.Multiline = True
        Me.TimerTextBox.Name = "TimerTextBox"
        Me.TimerTextBox.Size = New System.Drawing.Size(59, 46)
        Me.TimerTextBox.TabIndex = 20
        Me.TimerTextBox.Text = "30"
        Me.TimerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 424)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 29)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Temps"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.TextBoxPuntsO)
        Me.GroupBox1.Controls.Add(Me.PictureBoxX)
        Me.GroupBox1.Controls.Add(Me.PictureBoxO)
        Me.GroupBox1.Controls.Add(Me.TextBoxPuntsX)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(197, 424)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 107)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Puntuacions"
        '
        'TextBoxPuntsO
        '
        Me.TextBoxPuntsO.Enabled = False
        Me.TextBoxPuntsO.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPuntsO.Location = New System.Drawing.Point(268, 42)
        Me.TextBoxPuntsO.Multiline = True
        Me.TextBoxPuntsO.Name = "TextBoxPuntsO"
        Me.TextBoxPuntsO.Size = New System.Drawing.Size(34, 34)
        Me.TextBoxPuntsO.TabIndex = 29
        Me.TextBoxPuntsO.Text = "0"
        Me.TextBoxPuntsO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBoxX
        '
        Me.PictureBoxX.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxX.Location = New System.Drawing.Point(23, 35)
        Me.PictureBoxX.Name = "PictureBoxX"
        Me.PictureBoxX.Size = New System.Drawing.Size(50, 50)
        Me.PictureBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxX.TabIndex = 28
        Me.PictureBoxX.TabStop = False
        Me.PictureBoxX.Tag = "12"
        '
        'PictureBoxO
        '
        Me.PictureBoxO.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxO.Location = New System.Drawing.Point(197, 35)
        Me.PictureBoxO.Name = "PictureBoxO"
        Me.PictureBoxO.Size = New System.Drawing.Size(50, 50)
        Me.PictureBoxO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxO.TabIndex = 27
        Me.PictureBoxO.TabStop = False
        Me.PictureBoxO.Tag = "13"
        '
        'TextBoxPuntsX
        '
        Me.TextBoxPuntsX.Enabled = False
        Me.TextBoxPuntsX.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPuntsX.Location = New System.Drawing.Point(95, 42)
        Me.TextBoxPuntsX.Multiline = True
        Me.TextBoxPuntsX.Name = "TextBoxPuntsX"
        Me.TextBoxPuntsX.Size = New System.Drawing.Size(34, 34)
        Me.TextBoxPuntsX.TabIndex = 0
        Me.TextBoxPuntsX.Text = "0"
        Me.TextBoxPuntsX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StateTextBox
        '
        Me.StateTextBox.Enabled = False
        Me.StateTextBox.Location = New System.Drawing.Point(240, 39)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(242, 20)
        Me.StateTextBox.TabIndex = 23
        Me.StateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(194, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Estat:"
        '
        'PictureBoxImg
        '
        Me.PictureBoxImg.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxImg.Location = New System.Drawing.Point(109, 33)
        Me.PictureBoxImg.Name = "PictureBoxImg"
        Me.PictureBoxImg.Size = New System.Drawing.Size(50, 50)
        Me.PictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxImg.TabIndex = 25
        Me.PictureBoxImg.TabStop = False
        Me.PictureBoxImg.Tag = "11"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "bg90.png")
        Me.ImageList1.Images.SetKeyName(1, "X.png")
        Me.ImageList1.Images.SetKeyName(2, "O.png")
        '
        'PictureBoxBg
        '
        Me.PictureBoxBg.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxBg.Location = New System.Drawing.Point(197, 88)
        Me.PictureBoxBg.Name = "PictureBoxBg"
        Me.PictureBoxBg.Size = New System.Drawing.Size(330, 330)
        Me.PictureBoxBg.TabIndex = 26
        Me.PictureBoxBg.TabStop = False
        Me.PictureBoxBg.Tag = "14"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(562, 543)
        Me.Controls.Add(Me.PictureBoxImg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TimerTextBox)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ClientButton)
        Me.Controls.Add(Me.ServerButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RemotIpTextBox)
        Me.Controls.Add(Me.LocalIPTextBox)
        Me.Controls.Add(Me.AxWinsock2)
        Me.Controls.Add(Me.AxWinsock1)
        Me.Controls.Add(Me.PB7)
        Me.Controls.Add(Me.PB8)
        Me.Controls.Add(Me.PB9)
        Me.Controls.Add(Me.PB4)
        Me.Controls.Add(Me.PB5)
        Me.Controls.Add(Me.PB6)
        Me.Controls.Add(Me.PB3)
        Me.Controls.Add(Me.PB2)
        Me.Controls.Add(Me.PB1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBoxBg)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWinsock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWinsock2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PB1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents JocToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PB2 As PictureBox
    Friend WithEvents PB3 As PictureBox
    Friend WithEvents PB4 As PictureBox
    Friend WithEvents PB5 As PictureBox
    Friend WithEvents PB6 As PictureBox
    Friend WithEvents PB7 As PictureBox
    Friend WithEvents PB8 As PictureBox
    Friend WithEvents PB9 As PictureBox
    Friend WithEvents AxWinsock1 As AxMSWinsockLib.AxWinsock
    Friend WithEvents AxWinsock2 As AxMSWinsockLib.AxWinsock
    Friend WithEvents LocalIPTextBox As TextBox
    Friend WithEvents RemotIpTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ServerButton As Button
    Friend WithEvents ClientButton As Button
    Friend WithEvents NouJocToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartButton As Button
    Friend WithEvents TimerTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxPuntsX As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBoxO As PictureBox
    Friend WithEvents PictureBoxImg As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBoxX As PictureBox
    Friend WithEvents PictureBoxBg As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ResetejarPuntuacionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxPuntsO As TextBox
End Class
