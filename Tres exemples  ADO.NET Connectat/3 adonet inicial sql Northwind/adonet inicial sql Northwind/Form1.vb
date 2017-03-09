Imports System.Data.SqlClient
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myConnection As SqlConnection = New SqlConnection("Data Source=JOAN\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security = True")
        myConnection.Open()

        ' Inici transaccio inicial.
        Dim myTrans As SqlTransaction = myConnection.BeginTransaction()

        ' Preparo objecte Command dintre transaccio actual.
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        myCommand.Transaction = myTrans

        Try
            myCommand.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (100, 'Segria')"
            myCommand.ExecuteNonQuery()
            myCommand.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (101, 'Garrigues')"
            myCommand.ExecuteNonQuery()
            myTrans.Commit()
            TextBox1.Text = ("Els dos registres han estat guardats.")
        Catch ex1 As Exception
            Try
                myTrans.Rollback()
            Catch ex As SqlException
                If Not myTrans.Connection Is Nothing Then
                    TextBox1.Text = ("S'ha produït una excepció del tipus  " & ex.GetType().ToString() & _
                                      "mentre s'intentava tirar enrrera la transsació")
                End If
            End Try

            TextBox1.Text = ("S'ha produït una excepció " & e.GetType().ToString() & _
                              " mentre s'intentava inserir els registres." & vbCrLf)
            TextBox1.Text += ("Cap registre s'ha guardat a la BD.")
        Finally
            myConnection.Close()
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
