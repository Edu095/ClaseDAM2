Imports System.Threading
Imports System.Random
Public Class Form1

    Dim clsThreads As New List(Of Thread)
    Dim arribada As Integer = 0
    Dim tim1, tim2, tim3, tim4 As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ButtonVerd.Enabled = False
        ButtonBlau.Enabled = False
        ButtonGroc.Enabled = False
        ButtonRosa.Enabled = False

        For Each ctl In Controls
            If TypeOf ctl Is PictureBox Then
                Select Case ctl.Tag
                    Case 0 To 3
                        ctl.Image = ImageCorredores.Images(0)
                    Case 4 To 7
                        ctl.Image = ImageCorredores.Images(1)
                    Case 8 To 11
                        ctl.Image = ImageCorredores.Images(2)
                    Case 12 To 15
                        ctl.Image = ImageCorredores.Images(3)
                End Select
            End If
        Next

        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox1, PictureBox2)))
        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox2, PictureBox3)))
        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox3, PictureBox4)))
        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox4, PictureBox17)))

        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox5, PictureBox6)))
        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox6, PictureBox7)))
        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox7, PictureBox8)))
        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox8, PictureBox17)))

        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox9, PictureBox10)))
        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox10, PictureBox11)))
        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox11, PictureBox12)))
        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox12, PictureBox17)))

        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox13, PictureBox14)))
        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox14, PictureBox15)))
        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox15, PictureBox16)))
        clsThreads.Add(New Thread(Sub() Me.carrera(PictureBox16, PictureBox17)))

        For I As Integer = 0 To clsThreads.Count - 1
            clsThreads(I).Name = CStr(I)
        Next

    End Sub

    Sub carrera(ByRef pbox As PictureBox, ByRef pboxFi As PictureBox)
        Dim tg As Integer = pbox.Tag
        Dim vel As Integer = Int((6 * Rnd()) + 2)

        While (pbox.Location.X + 23) < pboxFi.Location.X
            pbox.Invoke(New MethodInvoker(Sub() Me.InvokePbox(tg, vel)))
            Thread.CurrentThread.Sleep(Int((50 * Rnd()) + 20))
        End While

        For I As Integer = 0 To clsThreads.Count - 1
            If clsThreads(I).Name = Thread.CurrentThread.Name Then
                If pboxFi.Tag <> "99" Then
                    clsThreads(I + 1).IsBackground = True
                    clsThreads(I + 1).Start()
                    Thread.CurrentThread.Abort()
                Else
                    Invoke(New MethodInvoker(Sub() Me.meta(clsThreads(I).Name)))
                    Thread.CurrentThread.Abort()
                End If
            End If
        Next

    End Sub
    Sub InvokePbox(ByVal tg As Integer, ByVal vel As Integer)
        For Each ctl In Controls
            If TypeOf ctl Is PictureBox Then
                If ctl.Tag = tg Then
                    ctl.Location = New Point(ctl.Location.X + vel, ctl.Location.Y)
                End If
            End If
        Next
    End Sub
    Sub meta(ByVal thName As String)
        If Not NouJocToolStripMenuItem.Enabled Then
            NouJocToolStripMenuItem.Enabled = True
        End If
        Dim equip As String
        If thName = Nothing Then
            MsgBox("Tots els equips han set eliminats")
            Timer1.Stop()
        Else
            If thName = "3" Then equip = "Verd"
            If thName = "7" Then equip = "Blau"
            If thName = "11" Then equip = "Groc"
            If thName = "15" Then equip = "Rosa"

            Select Case arribada
                Case 0
                    LabelMet1.Text = "Equip " + equip + " --> " + LabelSeconds.Text + ":" + LabelMilliseconds.Text
                    tim1 = (CInt(LabelSeconds.Text) * 100) + (CInt(LabelMilliseconds.Text))
                    arribada += 1
                Case 1
                    tim2 = tim1 - ((CInt(LabelSeconds.Text) * 100) + (CInt(LabelMilliseconds.Text)))
                    LabelMet2.Text = "Equip " + equip + " --> " + "+" + CStr((tim2 / 100) * -1)
                    arribada += 1
                Case 2
                    tim3 = tim1 - ((CInt(LabelSeconds.Text) * 100) + (CInt(LabelMilliseconds.Text)))
                    LabelMet3.Text = "Equip " + equip + " --> " + "+" + CStr((tim3 / 100) * -1)
                    arribada += 1
                Case 3
                    tim4 = tim1 - ((CInt(LabelSeconds.Text) * 100) + (CInt(LabelMilliseconds.Text)))
                    LabelMet4.Text = "Equip " + equip + " --> " + "+" + CStr((tim4 / 100) * -1)
                    arribada += 1
            End Select
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelMilliseconds.Text += 1
        If LabelMilliseconds.Text = "60" Then
            LabelMilliseconds.Text = "00"
            LabelSeconds.Text += 1
        End If
        Dim n As Integer = 0
        For I As Integer = 0 To clsThreads.Count - 1
            If clsThreads(I).IsAlive Then
                n += 1
            End If
        Next
        If arribada = 4 Or n = 0 Then
            Timer1.Stop()
            ButtonVerd.Enabled = False
            ButtonBlau.Enabled = False
            ButtonGroc.Enabled = False
            ButtonRosa.Enabled = False
        End If
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Timer1.Start()

        clsThreads(0).IsBackground = True
        clsThreads(0).Start()
        clsThreads(4).IsBackground = True
        clsThreads(4).Start()
        clsThreads(8).IsBackground = True
        clsThreads(8).Start()
        clsThreads(12).IsBackground = True
        clsThreads(12).Start()

        ButtonVerd.Enabled = True
        ButtonBlau.Enabled = True
        ButtonGroc.Enabled = True
        ButtonRosa.Enabled = True
        ButtonStart.Enabled = False

        NouJocToolStripMenuItem.Enabled = False

    End Sub

    Private Sub MinimitzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimitzaToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub NouJocToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouJocToolStripMenuItem.Click
        Application.Restart()
        Me.Refresh()
    End Sub

    Private Sub ButtonVerd_Click(sender As Object, e As EventArgs) Handles ButtonVerd.Click
        clsThreads(0).Abort()
        clsThreads(1).Abort()
        clsThreads(2).Abort()
        clsThreads(3).Abort()
        ButtonVerd.Enabled = False
        ctrlThAlive()
    End Sub

    Private Sub ButtonBlau_Click(sender As Object, e As EventArgs) Handles ButtonBlau.Click
        clsThreads(4).Abort()
        clsThreads(5).Abort()
        clsThreads(6).Abort()
        clsThreads(7).Abort()
        ButtonBlau.Enabled = False
        ctrlThAlive()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub ButtonGroc_Click(sender As Object, e As EventArgs) Handles ButtonGroc.Click
        clsThreads(8).Abort()
        clsThreads(9).Abort()
        clsThreads(10).Abort()
        clsThreads(11).Abort()
        ButtonGroc.Enabled = False
        ctrlThAlive()
    End Sub

    Private Sub ButtonRosa_Click(sender As Object, e As EventArgs) Handles ButtonRosa.Click
        clsThreads(12).Abort()
        clsThreads(13).Abort()
        clsThreads(14).Abort()
        clsThreads(15).Abort()
        ButtonRosa.Enabled = False
        ctrlThAlive()
    End Sub
    Sub ctrlThAlive()
        Dim n As Integer = 0
        For I As Integer = 0 To clsThreads.Count - 1
            If clsThreads(I).IsAlive Then
                n += 1
            End If
        Next
        If n = 0 Then meta(Nothing)
    End Sub

    Private Sub SurtirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SurtirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
