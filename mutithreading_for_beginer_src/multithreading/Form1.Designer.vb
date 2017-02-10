<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chk_Thread1 = New System.Windows.Forms.CheckBox
        Me.txt_ThreadStopCounter1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_ThreadCounter1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk_Thread2 = New System.Windows.Forms.CheckBox
        Me.txt_ThreadStopCounter2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_ThreadCounter2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chk_Thread3 = New System.Windows.Forms.CheckBox
        Me.txt_ThreadStopCounter3 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbl_ThreadCounter3 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chk_Thread4 = New System.Windows.Forms.CheckBox
        Me.txt_ThreadStopCounter4 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lbl_ThreadCounter4 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.multithreading.My.Resources.Resources.header
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(542, 109)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_Thread1)
        Me.GroupBox1.Controls.Add(Me.txt_ThreadStopCounter1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_ThreadCounter1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 74)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thread 1"
        '
        'chk_Thread1
        '
        Me.chk_Thread1.AutoSize = True
        Me.chk_Thread1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_Thread1.Location = New System.Drawing.Point(6, 54)
        Me.chk_Thread1.Name = "chk_Thread1"
        Me.chk_Thread1.Size = New System.Drawing.Size(12, 11)
        Me.chk_Thread1.TabIndex = 6
        Me.chk_Thread1.UseVisualStyleBackColor = True
        '
        'txt_ThreadStopCounter1
        '
        Me.txt_ThreadStopCounter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ThreadStopCounter1.ForeColor = System.Drawing.Color.Red
        Me.txt_ThreadStopCounter1.Location = New System.Drawing.Point(199, 48)
        Me.txt_ThreadStopCounter1.Name = "txt_ThreadStopCounter1"
        Me.txt_ThreadStopCounter1.Size = New System.Drawing.Size(59, 20)
        Me.txt_ThreadStopCounter1.TabIndex = 5
        Me.txt_ThreadStopCounter1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Stop Thread on Condition Counter = "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Counter :"
        '
        'lbl_ThreadCounter1
        '
        Me.lbl_ThreadCounter1.AutoSize = True
        Me.lbl_ThreadCounter1.Location = New System.Drawing.Point(229, 27)
        Me.lbl_ThreadCounter1.Name = "lbl_ThreadCounter1"
        Me.lbl_ThreadCounter1.Size = New System.Drawing.Size(13, 13)
        Me.lbl_ThreadCounter1.TabIndex = 2
        Me.lbl_ThreadCounter1.Text = "0"
        Me.lbl_ThreadCounter1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(65, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(7, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_Thread2)
        Me.GroupBox2.Controls.Add(Me.txt_ThreadStopCounter2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lbl_ThreadCounter2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(273, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 74)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thread 2"
        '
        'chk_Thread2
        '
        Me.chk_Thread2.AutoSize = True
        Me.chk_Thread2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_Thread2.Location = New System.Drawing.Point(6, 54)
        Me.chk_Thread2.Name = "chk_Thread2"
        Me.chk_Thread2.Size = New System.Drawing.Size(12, 11)
        Me.chk_Thread2.TabIndex = 6
        Me.chk_Thread2.UseVisualStyleBackColor = True
        '
        'txt_ThreadStopCounter2
        '
        Me.txt_ThreadStopCounter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ThreadStopCounter2.ForeColor = System.Drawing.Color.Red
        Me.txt_ThreadStopCounter2.Location = New System.Drawing.Point(199, 48)
        Me.txt_ThreadStopCounter2.Name = "txt_ThreadStopCounter2"
        Me.txt_ThreadStopCounter2.Size = New System.Drawing.Size(59, 20)
        Me.txt_ThreadStopCounter2.TabIndex = 5
        Me.txt_ThreadStopCounter2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Stop Thread on Condition Counter = "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(171, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Counter :"
        '
        'lbl_ThreadCounter2
        '
        Me.lbl_ThreadCounter2.AutoSize = True
        Me.lbl_ThreadCounter2.Location = New System.Drawing.Point(230, 27)
        Me.lbl_ThreadCounter2.Name = "lbl_ThreadCounter2"
        Me.lbl_ThreadCounter2.Size = New System.Drawing.Size(13, 13)
        Me.lbl_ThreadCounter2.TabIndex = 2
        Me.lbl_ThreadCounter2.Text = "0"
        Me.lbl_ThreadCounter2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(65, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 26)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(7, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(52, 26)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Start"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chk_Thread3)
        Me.GroupBox3.Controls.Add(Me.txt_ThreadStopCounter3)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lbl_ThreadCounter3)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 194)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 74)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thread 3"
        '
        'chk_Thread3
        '
        Me.chk_Thread3.AutoSize = True
        Me.chk_Thread3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_Thread3.Location = New System.Drawing.Point(6, 54)
        Me.chk_Thread3.Name = "chk_Thread3"
        Me.chk_Thread3.Size = New System.Drawing.Size(12, 11)
        Me.chk_Thread3.TabIndex = 6
        Me.chk_Thread3.UseVisualStyleBackColor = True
        '
        'txt_ThreadStopCounter3
        '
        Me.txt_ThreadStopCounter3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ThreadStopCounter3.ForeColor = System.Drawing.Color.Red
        Me.txt_ThreadStopCounter3.Location = New System.Drawing.Point(199, 48)
        Me.txt_ThreadStopCounter3.Name = "txt_ThreadStopCounter3"
        Me.txt_ThreadStopCounter3.Size = New System.Drawing.Size(59, 20)
        Me.txt_ThreadStopCounter3.TabIndex = 5
        Me.txt_ThreadStopCounter3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Stop Thread on Condition Counter = "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(171, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Counter :"
        '
        'lbl_ThreadCounter3
        '
        Me.lbl_ThreadCounter3.AutoSize = True
        Me.lbl_ThreadCounter3.Location = New System.Drawing.Point(230, 27)
        Me.lbl_ThreadCounter3.Name = "lbl_ThreadCounter3"
        Me.lbl_ThreadCounter3.Size = New System.Drawing.Size(13, 13)
        Me.lbl_ThreadCounter3.TabIndex = 2
        Me.lbl_ThreadCounter3.Text = "0"
        Me.lbl_ThreadCounter3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(65, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(52, 26)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Stop"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(7, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(52, 26)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Start"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chk_Thread4)
        Me.GroupBox4.Controls.Add(Me.txt_ThreadStopCounter4)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.lbl_ThreadCounter4)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Location = New System.Drawing.Point(273, 194)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 74)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thread 4"
        '
        'chk_Thread4
        '
        Me.chk_Thread4.AutoSize = True
        Me.chk_Thread4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_Thread4.Location = New System.Drawing.Point(6, 54)
        Me.chk_Thread4.Name = "chk_Thread4"
        Me.chk_Thread4.Size = New System.Drawing.Size(12, 11)
        Me.chk_Thread4.TabIndex = 6
        Me.chk_Thread4.UseVisualStyleBackColor = True
        '
        'txt_ThreadStopCounter4
        '
        Me.txt_ThreadStopCounter4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ThreadStopCounter4.ForeColor = System.Drawing.Color.Red
        Me.txt_ThreadStopCounter4.Location = New System.Drawing.Point(199, 48)
        Me.txt_ThreadStopCounter4.Name = "txt_ThreadStopCounter4"
        Me.txt_ThreadStopCounter4.Size = New System.Drawing.Size(59, 20)
        Me.txt_ThreadStopCounter4.TabIndex = 5
        Me.txt_ThreadStopCounter4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Stop Thread on Condition Counter = "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(171, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Counter :"
        '
        'lbl_ThreadCounter4
        '
        Me.lbl_ThreadCounter4.AutoSize = True
        Me.lbl_ThreadCounter4.Location = New System.Drawing.Point(230, 27)
        Me.lbl_ThreadCounter4.Name = "lbl_ThreadCounter4"
        Me.lbl_ThreadCounter4.Size = New System.Drawing.Size(13, 13)
        Me.lbl_ThreadCounter4.TabIndex = 2
        Me.lbl_ThreadCounter4.Text = "0"
        Me.lbl_ThreadCounter4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(65, 19)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(52, 26)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Stop"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(7, 19)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(52, 26)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Start"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 276)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chk_Thread1 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ThreadStopCounter1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_ThreadCounter1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Thread2 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ThreadStopCounter2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_ThreadCounter2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Thread3 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ThreadStopCounter3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_ThreadCounter3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Thread4 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ThreadStopCounter4 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_ThreadCounter4 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button

End Class
