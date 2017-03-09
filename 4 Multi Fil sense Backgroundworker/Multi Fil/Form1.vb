Imports System.Threading
Public Class Form1

    Dim n As Integer
    Dim WorkerThread As Thread                  'Crear hilo de trabajo
    Dim NewVal As Integer                       'Nuevo valor progress bar & textbox
    Dim StopThread As Boolean = True            'Boolean Valor usado para parar /arrancar bucle

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If StopThread = False Then
            StopThread = True
        Else
            StopThread = False
            WorkerThread = New Thread(AddressOf ThreadTask)
            WorkerThread.IsBackground = True
            WorkerThread.Start()
        End If
    End Sub

    Private Sub ThreadTask()
        Do Until StopThread = True
            NewVal += 1
            If NewVal = ProgressBar1.Maximum Then
                StopThread = True
            End If
            Me.ProgressBar1.Invoke(New MethodInvoker(AddressOf InvokeProgBar1))   ' Me.ProgressBar1.Value = CInt(NewVal)
            Me.TextBox1.Invoke(New MethodInvoker(AddressOf InvokeTextBox1))    ' Me.TextBox1.Text = CStr(NewVal)
            Thread.Sleep(100)

            'Hilos y Windows Forms 
            'http://www.elguille.info/NET/vs2005/trucos/acceder_a_un_control_desde_otro_hilo.htm

            '    Si intentaste utilizar una la clase  formulario de Windows Forms, seguramente te encontraras
            '    con la excepción InvalidOperationException al intentar modificar el valor de un textbox o cualquier otro control dentro del evento
            '    disparado por los hilos.

            '    Esto es porque no se puede tener acceso a un control de windows forms desde un proceso distinto al que lo creó. 
            '    Si utilizas una aplicación de consola no se tiene este inconveniente, pero si es necesario utilizar Windows Forms, 
            '    la forma de solucionar este problema es mediante un delegado y el método Invoke
            '
            '    Un delegado es una estructura de programación que nos permite invocar a uno o varios métodos a la vez. 
            '    Estos métodos pueden encontrarse en la misma clase desde la que se invocan o en clases distintas asociadas a ésta.
            '    Hablando "a bajo nivel", un delegado es un puntero seguro a una función (pero sin la complejidad de la administración
            '    propia de dicho puntero).

        Loop

    End Sub

    Private Sub InvokeProgBar1()
        Me.ProgressBar1.Value = CInt(NewVal)
    End Sub

    Private Sub InvokeTextBox1()
        Me.TextBox1.Text = CStr(NewVal)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Aquest es el fil o tasca principal")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox2.Text = n
        n = n + 1
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
