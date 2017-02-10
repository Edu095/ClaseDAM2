Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        'Iniciamos el trabajo

        If (Not BackgroundWorker1.IsBusy) Then

            BackgroundWorker1.RunWorkerAsync()
            BackgroundWorker2.RunWorkerAsync()

            btnCancelar.Enabled = True

            btnIniciar.Enabled = False

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'Solicitamos la cancelación de la operación

        BackgroundWorker1.CancelAsync()

        BackgroundWorker2.CancelAsync()

    End Sub

    

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i As Integer = 1 To 100

            'Realiza una tarea

            System.Threading.Thread.Sleep(100)

            BackgroundWorker1.ReportProgress(i)

            If (BackgroundWorker1.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'Notificar el progreso de la tarea

        progressBar1.Value = e.ProgressPercentage

        label1.Text = e.ProgressPercentage & "%"

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

        label1.Text = "Tarea terminada"

        btnCancelar.Enabled = False

        btnIniciar.Enabled = True

        progressBar1.Value = 0
    End Sub

    Private Sub BackgroundWorker2_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        For i As Integer = 1 To 100

            'Realiza una tarea

            System.Threading.Thread.Sleep(500)

            BackgroundWorker2.ReportProgress(i)

            If (BackgroundWorker2.CancellationPending) Then

                Return

            End If
        Next
    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        'Notificar el progreso de la tarea

        ProgressBar2.Value = e.ProgressPercentage

        Label2.Text = e.ProgressPercentage & "%"
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        'Realizamos las operaciones que haya que realizar al terminar el progreso
        Label2.Text = "Tarea terminada"
        btnCancelar.Enabled = False
        btnIniciar.Enabled = True
        ProgressBar2.Value = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
