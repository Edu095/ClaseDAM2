Imports System.IO
Imports System.Text
Public Class Form1

    Dim texto As String
    Dim lineas() As String
    Dim paraules() As String
    Dim nMun As Integer = 0

    Dim habPro As Integer
    Dim homPro As Integer
    Dim donPro As Integer

    Dim dades As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(633, 430)
        TabPage2.Enabled = False
    End Sub


    Private Sub ImportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog
        Dim sr As StreamReader = Nothing
        Dim nPro As Integer = 0

        Try
            ofd.ShowDialog()
            sr = New StreamReader(ofd.FileName, Encoding.Default)
            sr.ReadLine()
            sr.ReadLine()
            texto = sr.ReadToEnd
            ToolTip2.SetToolTip(PictureBox2, ofd.FileName)
            sr.Close()
            PictureBox2.Visible = True
            Label3.Visible = True
            lineas = Split(texto, vbCrLf)

            Me.Size = New System.Drawing.Size(633, 444)
            LabelCarrega.Visible = True
            Me.Refresh()

            ComboBoxProvincies.Items.Add("Tots els Municipis")
            ComboBoxProvincies.SelectedItem = ComboBoxProvincies.Items.Item(0)

            For Each linea In lineas
                paraules = Split(linea, vbTab)
                If Not ComboBoxProvincies.Items.Contains(paraules(1)) Then
                    ComboBoxProvincies.Items.Add(paraules(1))
                    nPro += 1
                End If
                If Not ComboBoxMunicipis.Items.Contains(paraules(3)) Then
                    ComboBoxMunicipis.Items.Add(paraules(3))
                    nMun += 1
                End If
            Next
            ComboBoxMunicipis.Enabled = True
            ComboBoxProvincies.Enabled = True

            TextBoxNprov.Text = CStr(nPro)
            TextBoxNmun.Text = CStr(nMun)

            TextBoxHprov.Text = ""
            TextBoxHmun.Text = ""
            TextBoxHomPro.Text = ""
            TextBoxDonPro.Text = ""
            TextBoxHomMun.Text = ""
            TextBoxDonMun.Text = ""

            LabelCarrega.Visible = False
            TabPage2.Enabled = True
            Me.Size = New System.Drawing.Size(633, 430)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxProvinvies_Click(sender As Object, e As EventArgs) Handles ComboBoxProvincies.SelectedIndexChanged
        ComboBoxMunicipis.Items.Clear()
        nMun = 0

        Me.Size = New System.Drawing.Size(633, 444)
        LabelCarrega.Visible = True
        Me.Refresh()

        If ComboBoxProvincies.SelectedIndex = 0 Then
            For Each linea In lineas
                paraules = Split(linea, vbTab)
                If Not ComboBoxMunicipis.Items.Contains(paraules(3)) Then
                    ComboBoxMunicipis.Items.Add(paraules(3))
                    nMun += 1
                End If
            Next
            TextBoxNmun.Text = CStr(nMun)
            TextBoxHprov.Text = ""
            TextBoxHmun.Text = ""
            TextBoxHomPro.Text = ""
            TextBoxDonPro.Text = ""
            TextBoxHomMun.Text = ""
            TextBoxDonMun.Text = ""
        Else
            habPro = 0
            homPro = 0
            donPro = 0
            For Each linea In lineas
                paraules = Split(linea, vbTab)
                If ComboBoxProvincies.SelectedItem = paraules(1) Then
                    ComboBoxMunicipis.Items.Add(paraules(3))
                    habPro += paraules(4)
                    homPro += paraules(5)
                    donPro += paraules(6)
                    nMun += 1
                End If
            Next
            TextBoxHprov.Text = CStr(habPro)
            TextBoxHomPro.Text = CStr(homPro)
            TextBoxDonPro.Text = CStr(donPro)
            TextBoxNmun.Text = CStr(nMun)
            TextBoxHmun.Text = ""
            TextBoxHomMun.Text = ""
            TextBoxDonMun.Text = ""
        End If

        LabelCarrega.Visible = False
        Me.Size = New System.Drawing.Size(633, 430)

    End Sub

    Private Sub ComboBoxMunicipis_Click(sender As Object, e As EventArgs) Handles ComboBoxMunicipis.SelectedIndexChanged
        habPro = 0
        homPro = 0
        donPro = 0

        For Each linea In lineas
            paraules = Split(linea, vbTab)
            If ComboBoxMunicipis.SelectedItem = paraules(3) Then
                ComboBoxProvincies.SelectedItem = paraules(1)
                habPro += paraules(4)
                homPro += paraules(5)
                donPro += paraules(6)
                TextBoxHmun.Text = CStr(paraules(4))
                TextBoxHomMun.Text = CStr(paraules(5))
                TextBoxDonMun.Text = CStr(paraules(6))
            End If
        Next

    End Sub

    Private Sub MinimitzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimitzaToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SortirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SortirToolStripMenuItem1.Click
        If MessageBox.Show("Segur que vols tancar l'apicació?", "Sortir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Me.Size = New System.Drawing.Size(633, 430)
            TabControl1.Size = New System.Drawing.Size(594, 352)
        ElseIf TabControl1.SelectedIndex = 1 Then
            Me.Size = New System.Drawing.Size(426, 430)
            TabControl1.Size = New System.Drawing.Size(387, 352)
            ComboBoxCondicio.SelectedIndex = 2
        End If
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim sexe As Integer = 0
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        PictureBox1.Visible = True

        If RadioButtonTotal.Checked Then
            sexe = 4
        ElseIf RadioButtonHome.Checked Then
            sexe = 5
        ElseIf RadioButtonDona.Checked Then
            sexe = 6
        End If
        If NumericPoblacio.Value = vbEmpty Then
            NumericPoblacio.Value = 0
        End If

        If RadioButtonPro.Checked Then
            dades = 1
            LabelTop.Text = "Provincies"
            LabelBot.Text = "Té els municipis..."
            ToolTip1.SetToolTip(PictureBox1, "Selecciona una provincia de damunt")
        ElseIf RadioButtonMun.Checked Then
            dades = 3
            LabelTop.Text = "Municipis"
            LabelBot.Text = "És de la provincia de..."
            ToolTip1.SetToolTip(PictureBox1, "Selecciona un municipi de damunt")
        End If

        Me.Size = New System.Drawing.Size(426, 444)
        LabelCarrega.Visible = True
        Me.Refresh()

        Select Case ComboBoxCondicio.SelectedIndex
            Case 0
                For Each linea In lineas
                    paraules = Split(linea, vbTab)
                    If Not ListBox1.Items.Contains(paraules(dades)) And paraules(sexe) < NumericPoblacio.Value Then
                        ListBox1.Items.Add(paraules(dades))
                    End If
                Next
            Case 1
                For Each linea In lineas
                    paraules = Split(linea, vbTab)
                    If Not ListBox1.Items.Contains(paraules(dades)) And paraules(sexe) <= NumericPoblacio.Value Then
                        ListBox1.Items.Add(paraules(dades))
                    End If
                Next
            Case 2
                For Each linea In lineas
                    paraules = Split(linea, vbTab)
                    If Not ListBox1.Items.Contains(paraules(dades)) And paraules(sexe) = NumericPoblacio.Value Then
                        ListBox1.Items.Add(paraules(dades))
                    End If
                Next
            Case 3
                For Each linea In lineas
                    paraules = Split(linea, vbTab)
                    If Not ListBox1.Items.Contains(paraules(dades)) And paraules(sexe) >= NumericPoblacio.Value Then
                        ListBox1.Items.Add(paraules(dades))
                    End If
                Next
            Case 4
                For Each linea In lineas
                    paraules = Split(linea, vbTab)
                    If Not ListBox1.Items.Contains(paraules(dades)) And paraules(sexe) > NumericPoblacio.Value Then
                        ListBox1.Items.Add(paraules(dades))
                    End If
                Next
        End Select

        LabelCarrega.Visible = False
        Me.Size = New System.Drawing.Size(426, 430)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.Items.Clear()

        If dades = 1 Then
            For Each linea In lineas
                paraules = Split(linea, vbTab)
                If ListBox1.SelectedItem = paraules(1) And Not ListBox2.Items.Contains(paraules(3)) Then
                    ListBox2.Items.Add(paraules(3))
                End If
            Next
        ElseIf dades = 3 Then
            For Each linea In lineas
                paraules = Split(linea, vbTab)
                If ListBox1.SelectedItem = paraules(3) And Not ListBox2.Items.Contains(paraules(1)) Then
                    ListBox2.Items.Add(paraules(1))
                End If
            Next
        End If
    End Sub
End Class

