Imports System.IO
Imports System.Text
Public Class Form1
    Dim texto As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        Dim sr As StreamReader = Nothing
        Try
            ofd.ShowDialog()
            sr = New StreamReader(ofd.FileName, Encoding.Default)
            texto = sr.ReadToEnd
            TextBox1.Text = texto
            LabelName.Text = ofd.FileName
            ButtonPrice.Enabled = True
            ComboDelimitador.Enabled = True
            sr.Close()
            Me.Size = New System.Drawing.Size(347, 260)
        Catch ex As Exception
            ButtonPrice.Enabled = False
            ComboDelimitador.Enabled = False
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonPrice_Click(sender As Object, e As EventArgs) Handles ButtonPrice.Click
        Dim sw As StreamWriter = Nothing
        Dim paraules() As String
        Dim limit() As String = {" ", ";", ",", vbTab, "-"}
        Dim delim As Boolean = False
        Dim i As Integer = 0
        Dim preu As Decimal = 0

        Try
            paraules = Split(texto, limit(ComboDelimitador.SelectedIndex))
            delim = True
        Catch ex As Exception
            delim = False
            MsgBox("Selecciona el delimitador")
        End Try

        If delim = True Then
            If paraules.GetUpperBound(0) = 0 Then
                MsgBox("No existeix aquest delimitador")
            Else
                Do While i <= paraules.GetUpperBound(0)
                    Select Case paraules(i).Length
                        Case 1 To 2
                            preu += 0.25 * paraules(i).Length
                        Case 3 To 6
                            preu += 0.1 * paraules(i).Length
                        Case > 6
                            preu += 0.05 * paraules(i).Length
                    End Select
                    i += 1
                Loop
                Dim x As String = "El preu és " + Str(preu) + "€"
                Dim sf As New SaveFileDialog
                sf.Filter = ".txt|*.txt"
                sf.ShowDialog()
                Dim fs As New FileStream(sf.FileName, FileMode.Create, FileAccess.Write)
                sw = New StreamWriter(fs, Encoding.Default)
                sw.Write(x)
                sw.Close()
                fs.Close()
            End If
        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(347, 130)
    End Sub
End Class
