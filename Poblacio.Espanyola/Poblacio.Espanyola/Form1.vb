Imports System.IO
Public Class Form1
    Structure poblacio
        Dim cpro As String
        Dim provincia As String
        Dim cmun As String
        Dim nombre As String
        Dim total As String
        Dim hombres As String
        Dim mujeres As String
    End Structure
    Dim pob() As poblacio
    Dim pos As Integer = 0

    Private Sub ObrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObrirToolStripMenuItem.Click

        Dim sr As StreamReader = Nothing
        Dim conta As Integer
        ruta = abrir()

        Try
            sr = New StreamReader(ruta, True)
            Do While sr.Peek() >= 0
                ReDim Preserve pob(pos + 1)
                Dim c(0) As Char
                sr.Read(c, 0, c.Length)
                Select Case conta
                    Case 0
                        If c(0) <> vbTab Then
                            pob(pos).cpro = pob(pos).cpro + c(0)
                        Else
                            pob(pos).cpro = pob(pos).cpro + c(0)
                            conta = conta + 1
                            Exit Select
                        End If
                    Case 1
                        If c(0) <> vbTab Then
                            pob(pos).provincia = pob(pos).provincia + c(0)
                        Else
                            pob(pos).provincia = pob(pos).provincia + c(0)
                            If ComboBox1.Items.Contains(pob(pos).provincia) Then
                            Else
                                ComboBox1.Items.Add(pob(pos).provincia)
                            End If
                            If ComboBox3.Items.Contains(pob(pos).provincia) Then
                            Else
                                ComboBox3.Items.Add(pob(pos).provincia)
                            End If
                            conta = conta + 1
                            Exit Select
                        End If
                    Case 2
                        If c(0) <> vbTab Then
                            pob(pos).cmun = pob(pos).cmun + c(0)
                        Else
                            pob(pos).cmun = pob(pos).cmun + c(0)
                            conta = conta + 1
                            Exit Select
                        End If
                    Case 3
                        If c(0) <> vbTab Then
                            pob(pos).nombre = pob(pos).nombre + c(0)
                        Else
                            pob(pos).nombre = pob(pos).nombre + c(0)
                            If ComboBox2.Items.Contains(pob(pos).nombre) Then
                            Else
                                ComboBox2.Items.Add(pob(pos).nombre)
                            End If
                            conta = conta + 1
                            Exit Select
                        End If
                    Case 4
                        If c(0) <> vbTab Then
                            pob(pos).total = pob(pos).total + c(0)
                        Else
                            pob(pos).total = pob(pos).total + c(0)
                            conta = conta + 1
                            Exit Select
                        End If
                    Case 5
                        If c(0) <> vbTab Then
                            pob(pos).hombres = pob(pos).hombres + c(0)
                        Else
                            pob(pos).hombres = pob(pos).hombres + c(0)
                            conta = conta + 1
                            Exit Select
                        End If
                    Case 6
                        If c(0) <> vbCr Then
                            pob(pos).mujeres = pob(pos).mujeres + c(0)
                        Else
                            pob(pos).mujeres = pob(pos).mujeres + vbTab
                            conta = 0
                            pos = pos + 1
                        End If
                End Select
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If sr IsNot Nothing Then sr.Close()
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        For i = 0 To pos
            If ComboBox1.Text = pob(i).provincia Then
                ListBox1.Items.Add(pob(i).cpro + " " + pob(i).cmun + " " + pob(i).nombre + " " + pob(i).total + " " + pob(i).hombres + " " + pob(i).mujeres)
            End If
        Next
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ListBox1.Items.Clear()
        For i = 0 To pos
            If ComboBox2.Text = pob(i).nombre Then
                ListBox1.Items.Add(pob(i).cpro + " " + pob(i).provincia + " " + pob(i).cmun + " " + pob(i).total + " " + pob(i).hombres + " " + pob(i).mujeres)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conta As Integer = 0
        TextBox1.Text = ""
        For i = 0 To pos
            If ComboBox3.Text = pob(i).provincia Then
                conta += 1
            End If
        Next
        TextBox1.Text = conta
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox4.Text = ">" Then
            If RadioButton1.Checked = True Then
                ListBox2.Items.Clear()
                For i = 0 To pos
                    If pob(i).hombres > Val(TextBox2.Text) Then
                        ListBox2.Items.Add(pob(i).nombre)
                    End If
                Next
            End If
            If RadioButton2.Checked = True Then
                ListBox2.Items.Clear()
                For i = 0 To pos
                    If pob(i).mujeres > Val(TextBox2.Text) Then
                        ListBox2.Items.Add(pob(i).nombre)
                    End If
                Next
            End If
            If RadioButton3.Checked = True Then
                ListBox2.Items.Clear()
                For i = 0 To pos
                    If pob(i).total > Val(TextBox2.Text) Then
                        ListBox2.Items.Add(pob(i).nombre)
                    End If
                Next
            End If
        End If
        If ComboBox4.Text = "<" Then
            If RadioButton1.Checked = True Then
                ListBox2.Items.Clear()
                For i = 0 To pos
                    If pob(i).hombres < Val(TextBox2.Text) Then
                        ListBox2.Items.Add(pob(i).nombre)
                    End If
                Next
            End If
            If RadioButton2.Checked = True Then
                ListBox2.Items.Clear()
                For i = 0 To pos
                    If pob(i).mujeres < Val(TextBox2.Text) Then
                        ListBox2.Items.Add(pob(i).nombre)
                    End If
                Next
            End If
            If RadioButton3.Checked = True Then
                ListBox2.Items.Clear()
                For i = 0 To pos
                    If pob(i).total < Val(TextBox2.Text) Then
                        ListBox2.Items.Add(pob(i).nombre)
                    End If
                Next
            End If
        End If
        If ComboBox4.Text = "=" Then
            If RadioButton1.Checked = True Then
                ListBox2.Items.Clear()
                For i = 0 To pos
                    If pob(i).hombres = Val(TextBox2.Text) Then
                        ListBox2.Items.Add(pob(i).nombre)
                    End If
                Next
            End If
            If RadioButton2.Checked = True Then
                ListBox2.Items.Clear()
                For i = 0 To pos
                    If pob(i).mujeres = Val(TextBox2.Text) Then
                        ListBox2.Items.Add(pob(i).nombre)
                    End If
                Next
            End If
            If RadioButton3.Checked = True Then
                ListBox2.Items.Clear()
                For i = 0 To pos
                    If pob(i).total = Val(TextBox2.Text) Then
                        ListBox2.Items.Add(pob(i).nombre)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
