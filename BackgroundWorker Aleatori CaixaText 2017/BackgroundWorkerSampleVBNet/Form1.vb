Imports System.ComponentModel
'El System.ComponentModel espacio de nombres proporciona clases que se utilizan para implementar
'el comportamiento de tiempo de ejecución y tiempo de diseño de componentes y controles.
'Este espacio de nombres incluye las clases bases e interfaces para implementar atributos y convertidores
'de tipos, orígenes de enlace a datos y licencias de componentes.

' BackgroundWorker1.Events 

'Obtiene la lista de controladores de eventos que se adjuntará a este Component.(Heredado de ComponentModel).



Public Class Form1
    Dim s As Double
    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        If Not (BackgroundWorker1.IsBusy) Then BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub StopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopButton.Click
        BackgroundWorker1.CancelAsync()
        BackgroundWorker1.Dispose()
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Obtener el objeto BackgroundWorker que provocó este evento
        Dim helperBW As BackgroundWorker = CType(sender, BackgroundWorker)
        e.Result = Proceso(e.Argument, helperBW, e)

    End Sub

    Function Proceso(ByVal n As Integer, ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Long
        Dim result As Long = 0
        Do
            If worker.CancellationPending Then
                e.Cancel = True
                Return result
            End If
            Dim aleatori As New Random
            s = aleatori.Next(10, 20)
            If s = 18 Then BackgroundWorker1.CancelAsync()
            System.Threading.Thread.Sleep(1000)
            BackgroundWorker1.ReportProgress(s)
        Loop
        Return result
    End Function

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        TextBox2.Text += e.ProgressPercentage & vbCrLf

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object,
              ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If (e.Cancelled) Then MessageBox.Show(("La tasca ha estat cancelada i numero aleatori=") & s)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
