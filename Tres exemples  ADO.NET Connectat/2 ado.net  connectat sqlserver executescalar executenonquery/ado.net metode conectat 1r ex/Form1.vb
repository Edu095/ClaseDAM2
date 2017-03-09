'EXEMPLE DE MODEL CONNECTAT: desde que ens conectem gastem recursos.

Imports System.Data.SqlClient  ' importem un espai de noms, ja el tenim instalat, es de microsoft
' en aquest cas es per al proveedor SQL
' funcionarie igual amb Imports System.Data.OleDb


Public Class Form1

    Public cn As SqlConnection

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Establim la conexió amb la nostra base de dades

        Dim strconexion As String

        'Cadena amb tots els parametres a pasarli al crear la nova connexió a la B.D.

        'Per conectarte a una B.D. en xarxa, fora del teu PC
        'strconexion = "Data Source=java.informatica.local;" & "Initial Catalog=pubs;" & "user id=sa;" & "Password="
        strconexion = "Data Source=JOAN\SQLEXPRESS;" & "Initial Catalog=pubs;" & "Integrated Security = True"  'Integrated Security a true vol dir que entrem amb l'usuari de windows
        'Per conectarte a la B.D. del teu propi PC
        'strconexion = "Data Source=B10\SQLEXPRESS;" & "Initial Catalog=pubs;" & "Integrated Security = True"  'Integrated Security a true vol dir que entrem amb l'usuari de windows

        'fem un try catch per controlar errors al conectar
        Try
            ' Obrim la connexió
            cn = New SqlConnection(strconexion) 'creem nova conexio 
            cn.Open() 'obrim
            MessageBox.Show(" Connexió OK")
        Catch ex As Exception ' si hi ha un error treiem per pantalla el messagebox
            MessageBox.Show("Error al obrir la conexíó:" & vbCrLf & ex.Message)
            Exit Sub ' sortim
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ssql As String 'creem string on posarem la consulta
        Dim resultat As Integer
        ssql = "SELECT COUNT(*) FROM authors" ' possem la consulta ke farem a ssql
        Dim comando As New SqlCommand(ssql, cn) ' passem la consulta ssql amb la conexió cn

        resultat = comando.ExecuteScalar() ' agafem el resultat retorne un valor escalar (un sol valor) perque a la consulta fem un count
        '.ExecuteNonQuery --> per a fer inserts, updates....
        TextBox1.Text = resultat ' mostrem al textbox el resultat

        cn.Close() ' tanquem la conexió a la base de dades
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ssql As String 'creem string on posarem la consulta
        Dim resultat As Integer
        ssql = "UPDATE authors SET state='CA' WHERE state='SP' " ' possem la consulta ke farem a ssql
        'ssql = "select * from authors*"
        Dim comando As New SqlCommand(ssql, cn) ' passem la consulta ssql amb la conexió cn
        resultat = comando.ExecuteNonQuery 'perque fem un update ens retorne les files afectades
        TextBox1.Text = resultat ' mostrem les files afectades al textbox

        cn.Close() ' tanquem la conexió a la base de dades
    End Sub
End Class
