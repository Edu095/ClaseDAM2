Imports System.Threading

Public Class Form1
    Dim RandomNo As New Random()
    Dim StopThread As Boolean = True
    Dim StopThread2 As Boolean = True
    Dim StopThread3 As Boolean = True
    Dim StopThread4 As Boolean = True
    Dim WorkerThread1 As Thread
    Dim WorkerThread2 As Thread
    Dim WorkerThread3 As Thread
    Dim WorkerThread4 As Thread

    Dim a As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If StopThread = False Then
            StopThread = True
            StopThread2 = True
            StopThread3 = True
            StopThread4 = True
        Else
            StopThread = False
            StopThread2 = False
            StopThread3 = False
            StopThread4 = False
            WorkerThread1 = New Thread(AddressOf ThreadTask)
            WorkerThread1.IsBackground = True
            WorkerThread1.Start()
            WorkerThread2 = New Thread(AddressOf ThreadTask2)
            WorkerThread2.IsBackground = True
            WorkerThread2.Start()
            WorkerThread3 = New Thread(AddressOf ThreadTask3)
            WorkerThread3.IsBackground = True
            WorkerThread3.Start()
            WorkerThread4 = New Thread(AddressOf ThreadTask4)
            WorkerThread4.IsBackground = True
            WorkerThread4.Start()
        End If

    End Sub

    Private Sub ThreadTask()
        Do Until StopThread = True
            'If PictureBox2.Location.X >= 660 Then
            '    MsgBox("Ha guanyat el blau")
            '    StopThread = True
            'End If
            'If PictureBox3.Location.X >= 660 Then
            '    MsgBox("Ha guanyat el verd")
            '    StopThread = True
            'End If
            'If PictureBox4.Location.X >= 660 Then
            '    MsgBox("Ha guanyat el vermell")
            '    StopThread = True
            'End If
            'If PictureBox5.Location.X >= 660 Then
            '    MsgBox("Ha guanyat el groc")
            '    StopThread = True
            'End If

            PictureBox2.Invoke(New MethodInvoker(AddressOf Invokepicturebox2))
            'PictureBox3.Invoke(New MethodInvoker(AddressOf Invokepicturebox3))
            'PictureBox4.Invoke(New MethodInvoker(AddressOf Invokepicturebox4))
            'PictureBox5.Invoke(New MethodInvoker(AddressOf Invokepicturebox5))
            Thread.Sleep(100)
        Loop
    End Sub
    Private Sub ThreadTask2()
        Do Until StopThread2 = True
            Dim RandomNo As New Random()
            PictureBox3.Invoke(New MethodInvoker(AddressOf Invokepicturebox3))
            Thread.Sleep(100)
        Loop
    End Sub
    Private Sub ThreadTask3()
        Do Until StopThread3 = True
            Dim RandomNo As New Random()
            PictureBox4.Invoke(New MethodInvoker(AddressOf Invokepicturebox4))
            Thread.Sleep(100)
        Loop
    End Sub
    Private Sub ThreadTask4()
        Do Until StopThread4 = True
            Dim RandomNo As New Random()
            PictureBox5.Invoke(New MethodInvoker(AddressOf Invokepicturebox5))
            Thread.Sleep(100)
        Loop
    End Sub
    Private Sub Invokepicturebox2()
        If PictureBox2.Location.X < 157 Then
            Me.PictureBox2.Left = PictureBox2.Left + RandomNo.Next(1, a)
        End If
        If PictureBox2.Location.X >= 157 Then
            PictureBox2.BackColor = Color.Red
            If PictureBox6.Left < 301 Then
                Me.PictureBox6.Left = PictureBox6.Left + RandomNo.Next(1, a)
            End If
        End If
        If PictureBox6.Location.X >= 301 Then
            PictureBox6.BackColor = Color.Red
            If PictureBox7.Location.X < 464 Then
                Me.PictureBox7.Left = PictureBox7.Left + RandomNo.Next(1, a)
            Else
                PictureBox7.BackColor = Color.Red

                Me.PictureBox8.Left = PictureBox8.Left + RandomNo.Next(1, a)
                If PictureBox8.Location.X >= 660 Then

                    StopThread = True
                    StopThread2 = True
                    StopThread3 = True
                    StopThread4 = True
                    MsgBox("Guanyadors els blaus")
                End If
            End If
        End If
    End Sub
    Private Sub Invokepicturebox3()
        If PictureBox3.Location.X < 157 Then
            Me.PictureBox3.Left = PictureBox3.Left + RandomNo.Next(1, a)
        End If
        If PictureBox3.Location.X >= 157 Then
            PictureBox3.BackColor = Color.Red
            If PictureBox9.Left < 301 Then
                Me.PictureBox9.Left = PictureBox9.Left + RandomNo.Next(1, a)
            End If
        End If
        If PictureBox9.Location.X >= 301 Then
            PictureBox9.BackColor = Color.Red
            If PictureBox10.Location.X < 464 Then
                Me.PictureBox10.Left = PictureBox10.Left + RandomNo.Next(1, a)
            Else
                PictureBox10.BackColor = Color.Red
                Me.PictureBox11.Left = PictureBox11.Left + RandomNo.Next(1, a)
                If PictureBox11.Location.X >= 660 Then

                    StopThread = True
                    StopThread2 = True
                    StopThread3 = True
                    StopThread4 = True
                    MsgBox("Guanyadors els verds")
                End If
            End If
        End If
    End Sub
    Private Sub Invokepicturebox4()
        If PictureBox4.Location.X < 157 Then
            Me.PictureBox4.Left = PictureBox4.Left + RandomNo.Next(1, a)
        End If
        If PictureBox4.Location.X >= 157 Then
            PictureBox4.BackColor = Color.Red
            If PictureBox12.Left < 301 Then
                Me.PictureBox12.Left = PictureBox12.Left + RandomNo.Next(1, a)
            End If
        End If
        If PictureBox12.Location.X >= 301 Then
            PictureBox12.BackColor = Color.Red
            If PictureBox13.Location.X < 464 Then
                Me.PictureBox13.Left = PictureBox13.Left + RandomNo.Next(1, a)
            Else
                PictureBox13.BackColor = Color.Red
                Me.PictureBox14.Left = PictureBox14.Left + RandomNo.Next(1, a)
                If PictureBox14.Location.X >= 660 Then

                    StopThread = True
                    StopThread2 = True
                    StopThread3 = True
                    StopThread4 = True
                    MsgBox("Guanyadors els vermells")
                End If
            End If
        End If
    End Sub
    Private Sub Invokepicturebox5()
        If PictureBox5.Location.X < 157 Then
            Me.PictureBox5.Left = PictureBox5.Left + RandomNo.Next(1, a)
        End If
        If PictureBox5.Location.X >= 157 Then
            PictureBox5.BackColor = Color.Red
            If PictureBox15.Left < 301 Then
                Me.PictureBox15.Left = PictureBox15.Left + RandomNo.Next(1, a)
            End If
        End If
        If PictureBox15.Location.X >= 301 Then
            PictureBox15.BackColor = Color.Red
            If PictureBox16.Location.X < 464 Then
                Me.PictureBox16.Left = PictureBox16.Left + RandomNo.Next(1, a)
            Else
                PictureBox16.BackColor = Color.Red
                Me.PictureBox17.Left = PictureBox17.Left + RandomNo.Next(1, a)
                If PictureBox17.Location.X >= 660 Then

                    StopThread = True
                    StopThread2 = True
                    StopThread3 = True
                    StopThread4 = True
                    MsgBox("Guanyadors els grocs")
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            StopThread = True
        End If
        If RadioButton2.Checked = True Then
            StopThread2 = True
        End If
        If RadioButton3.Checked = True Then
            StopThread3 = True
        End If
        If RadioButton4.Checked = True Then
            StopThread4 = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a = HScrollBar1.Value
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
