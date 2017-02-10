Imports System.ComponentModel

Public Class Form1
    Dim s As Double
    Private Sub StartButton_Click(ByVal sender As System.Object,
                                  ByVal e As System.EventArgs) Handles StartButton.Click
        If Not (BackgroundWorker1.IsBusy) Then BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub StopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopButton.Click
        BackgroundWorker1.CancelAsync()
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, _
                                         ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Obtener el objeto BackgroundWorker que provocó este evento
        Dim helperBW As BackgroundWorker = CType(sender, BackgroundWorker)
        e.Result = Proceso(e.Argument, helperBW, e)
    End Sub

    Function Proceso(ByVal n As Integer,
                   ByVal worker As BackgroundWorker,
                   ByVal e As DoWorkEventArgs) As Long
        Dim result As Long = 0
        Do
            If worker.CancellationPending Then
                e.Cancel = True
                Return result
            End If
            s = s + 1
            System.Threading.Thread.Sleep(1000)
            BackgroundWorker1.ReportProgress(s)
        Loop
        Return result
    End Function

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Label1.Text = s
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, _
              ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If (e.Cancelled) Then MessageBox.Show(("La tasca ha estat cancelada i s=") & s)
    End Sub
    
    Private Sub RichTextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = ""
    End Sub
End Class
