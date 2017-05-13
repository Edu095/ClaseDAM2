Imports AxMSWinsockLib

Public Class Form1
    Dim pb As New List(Of PictureBox)(9)
    Dim server As Boolean = False
    Dim cont As Integer
    Dim turn As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctl In Controls
            If TypeOf ctl Is PictureBox Then
                If ctl.Tag <= 9 Then
                    pb.Add(ctl)
                    ctl.BackgroundImage = ImageList1.Images(0)
                End If
            End If
        Next
        For i As Integer = 0 To 8
            pb(0).Tag = "0"
        Next

        PictureBoxX.Image = ImageList1.Images(1)
        PictureBoxO.Image = ImageList1.Images(2)

        LocalIPTextBox.Text = AxWinsock1.LocalIP
        AxWinsock1.LocalPort = 5777
        AxWinsock1.RemotePort = 5778
        AxWinsock2.LocalPort = 5778
        AxWinsock2.RemotePort = 5777
    End Sub

    Private Sub ServerButton_Click(sender As Object, e As EventArgs) Handles ServerButton.Click
        server = True
        turn = True
        AxWinsock1.Listen()
        ServerButton.Enabled = False
        ClientButton.Enabled = False
        RemotIpTextBox.Enabled = False
        StateTextBox.Text = "Esperando al segundo jugador..."
        PictureBoxImg.Image = ImageList1.Images(1)
        ToolStripSeparator1.Visible = True
        ResetejarPuntuacionsToolStripMenuItem.Visible = True
    End Sub

    Private Sub ClientButton_Click(sender As Object, e As EventArgs) Handles ClientButton.Click
        If AxWinsock2.CtlState = MSWinsockLib.StateConstants.sckClosed Then
            Try
                AxWinsock2.RemoteHost = RemotIpTextBox.Text
                AxWinsock2.Connect()
                PictureBoxImg.Image = ImageList1.Images(2)
                StateTextBox.Text = "Conectando..."
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub AxWinsock1_ConnectionRequest(sender As Object, e As DMSWinsockControlEvents_ConnectionRequestEvent) Handles AxWinsock1.ConnectionRequest
        If AxWinsock1.CtlState <> MSWinsockLib.StateConstants.sckClosed Then
            AxWinsock1.Close()
            AxWinsock1.Accept(e.requestID)
            StateTextBox.Text = "Conectado"
            turno("c")
            StartButton.Enabled = True
        End If
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        turno("start")
        cont = 30
        Timer1.Enabled = True
        For i As Integer = 0 To 8
            pb(i).Enabled = True
        Next
        StartButton.Enabled = False
    End Sub

    Private Sub turno(ByVal d As String)
        Try
            If server = True Then
                AxWinsock1.SendData(d)
            Else
                AxWinsock2.SendData(d)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AxWinsock2_DataArrival(sender As Object, e As DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock2.DataArrival
        Dim data As String = ""
        AxWinsock2.GetData(data, vbString, 1000)
        If data = "start" Then
            StartButton.Enabled = False
        ElseIf data = "c"
            StateTextBox.Text = "Conectado"
        Else
            For i As Integer = 0 To 8
                pb(i).Enabled = True
                If pb(i).Name = data Then
                    pb(i).BackgroundImage = ImageList1.Images(1)
                    pb(i).Tag = "1"
                End If
                If pb(i).Tag = "1" Then pb(i).Enabled = False
            Next
            TimerTextBox.BackColor = Color.SeaGreen
            turn = True
            cont = 30
            Timer1.Start()
        End If

    End Sub

    Private Sub AxWinsock1_DataArrival(sender As Object, e As DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock1.DataArrival
        Dim data As String = ""
        AxWinsock1.GetData(data, vbString, 1000)
        If data = "start" Then
            StartButton.Enabled = False
        Else
            For i As Integer = 0 To 8
                pb(i).Enabled = True
                If pb(i).Name = data Then
                    pb(i).BackgroundImage = ImageList1.Images(2)
                    pb(i).Tag = "1"
                End If
                If pb(i).Tag = "1" Then pb(i).Enabled = False
                TimerTextBox.BackColor = Color.SeaGreen
                turn = True
            Next
            cont = 30
            Timer1.Start()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim time As String
        cont -= 1
        time = Format(cont, "00")
        TimerTextBox.Text = time
        If cont = 0 Then
            Timer1.Enabled = False
            MsgBox("S'ha acabat el temps")
        End If
    End Sub

    Private Sub PB_Click(sender As Object, e As EventArgs) Handles PB1.Click, PB2.Click, PB3.Click,
        PB4.Click, PB5.Click, PB6.Click, PB7.Click, PB8.Click, PB9.Click

        Dim pic As PictureBox = DirectCast(sender, PictureBox)

        If server Then
            pic.BackgroundImage = ImageList1.Images(1)
        Else
            pic.BackgroundImage = ImageList1.Images(2)
        End If
        pic.Tag = "1"
        For i As Integer = 0 To 8
            pb(i).Enabled = False
        Next
        turno(pic.Name)
        TimerTextBox.BackColor = Color.White
        turn = False
        Timer1.Stop()
    End Sub

    Private Sub NouJocToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouJocToolStripMenuItem.Click
        For i As Integer = 0 To 8
            pb(i).BackgroundImage = ImageList1.Images(0)
        Next
    End Sub

    Private Sub ResetejarPuntuacionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetejarPuntuacionsToolStripMenuItem.Click
        TextBoxPuntsX.Text = ""
        TextBoxPuntsO.Text = ""
    End Sub
End Class
