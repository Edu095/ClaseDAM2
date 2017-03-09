'EXEMPLE DE MODEL CONNECTAT: desde que ens conectem gastem recursos.

Imports System.Data.OleDb
' importem un espai de noms, ja el tenim instalat, es de microsoft
' en aquest cas es per al proveedor SQL
' funcionarie igual amb Imports System.Data.OleDb


Public Class Form1

    Public cn As OleDbConnection

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Establim la conexió amb la nostra base de dades

        Dim strconexion As String

        'Cadena amb tots els parametres a pasarli al crear la nova connexió a la B.D.

        'Per conectarte a una B.D. en xarxa, fora del teu PC
        'strconexion = "Data Source=java.informatica.local;" & "Initial Catalog=pr_jmperera;" & "user id=jmperera;" & "Password=caparrella"

        'Per conectarte a la B.D. del teu propi PC
        'strconexion = "Data Source=JOAN\SQLEXPRESS;" & "Initial Catalog=pubs;" & "Integrated Security = True"  'Integrated Security a true vol dir que entrem amb l'usuari de windows
        'strconexion = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=pubs2002.mdb"   ' OFFICCE 2007
        strconexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=pubs2002.mdb"   ' OFFICCE 2010
        'fem un try catch per controlar errors al conectar
        Try
            ' Obrim la connexió
            cn = New Data.OleDb.OleDbConnection(strconexion) 'creem nova conexio 
            cn.Open() 'obrim
            MessageBox.Show(" Connexió OK")
        Catch ex As Exception ' si hi ha un error treiem per pantalla el messagebox
            MessageBox.Show("Error al obrir la connexíó:" & vbCrLf & ex.Message)
            Exit Sub ' sortim
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ssql As String 'creem string on posarem la consulta
        'Dim resultat As Integer
        Dim dr As OleDbDataReader 'DataReader:  permet fer una lectura d'una base de dades pero sempre avant, sol lectura, 
        ssql = "SELECT * FROM authors" ' possem la consulta ke farem a ssql
        Dim comando As New OleDbCommand(ssql, cn) ' passem la consulta ssql amb la conexió cn
        dr = comando.ExecuteReader
        Do While dr.Read
            ListBox1.Items.Add(dr("au_fname") & vbTab & dr("au_id") & vbTab & dr("au_lname"))
        Loop
        
        dr.Close() 'tanquem el data reader
        cn.Close() ' tanquem la conexió a la base de dades
    End Sub

    

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
