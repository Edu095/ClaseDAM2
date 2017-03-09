Imports System.Math
Imports System.Threading
Public Class Form1

    Dim izXt As Integer = 242 'eje x del centro de la circunferencia Izquierda SUPERIOR
    Dim izDerY As Integer = 267 'eje y del centro de la circunferencia
    Dim derX As Integer = 687 'eje x del centro de la circunferencia Derecha
    Dim corr1 As Integer = 130 'radio hasta el jugador 1
    Dim corr2 As Integer = 163 'radio hasta el jugador 2
    Dim corr3 As Integer = 195 'radio hasta el jugador 3
    Dim corr4 As Integer = 227 'radio hasta el jugador 4
    Dim pY As Integer = 397 'posicio Y recta inferior
    Dim pX As Integer = 258 'posicio X PictureBox1 començant esquerra

    Dim th1, th2, th3, th4, th5, th6, th7, th8, th9, th10, th11, th12, th13, th14, th15, th16, thControl As Thread

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each ctl In Controls
            If TypeOf ctl Is PictureBox Then
                Select Case ctl.Tag
                    Case 1 To 4
                        ctl.Image = ImageCorredores.Images(0)
                    Case 5 To 8
                        ctl.Image = ImageCorredores.Images(1)
                    Case 9 To 12
                        ctl.Image = ImageCorredores.Images(2)
                    Case 13 To 16
                        ctl.Image = ImageCorredores.Images(3)
                End Select
            End If
        Next

        Dim g1 As Integer = 90
        Dim g2 As Integer = 70
        'g1(0) = (180 / PI) - 235
        'g2(0) = (180 / PI) - 210
        'g3(0) = (180 / PI) - 180
        'g4(0) = (180 / PI) - 150

        th1 = New Thread(Sub() Me.carrera(PictureBox1, PictureBox2, corr1, g1))
        th2 = New Thread(Sub() Me.carrera(PictureBox5, PictureBox6, corr2, g2))

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        th1.Start()
        th2.Start()
        'th3.Start()
        'th4.Start()

    End Sub

    Private Sub carrera(ByRef pbox As PictureBox, ByRef pboxFi As PictureBox, ByVal yCorr As Integer, ByVal gradC As Integer)

        If pbox.Location.X > (pboxFi.Location.X + 25) Then
            If pbox.Location.X >= derX Then
                Curva(gradC, 270, derX, izDerY, yCorr, pbox)
            Else
                ' Recta()
            End If
        End If
        th1.Abort()
        th2.Abort()
        'th3.Abort()
        'th4.Abort()

    End Sub

    Private Sub Curva(ByVal grd As Integer, ByVal topObot As Integer, ByVal posX As Integer, ByVal posY As Integer, ByVal radio As Integer, ByRef pbox As PictureBox)
        Dim rad As Decimal
        Dim rx, ry As Integer
        Dim tg As Integer = pbox.Tag
        While grd <> topObot
            rad = grd * (PI / 180) 'calculo el radiantede grad
            rx = radio * Cos(rad) 'asigno la posicion x del objeto
            ry = radio * Sin(rad) 'asigno la posicion y del objeto
            pbox.Invoke(New MethodInvoker(Sub() Me.InvokePbox(tg, posX, posY, rx, ry))) 'pbox.Location = New Point(posX + rx, posY + ry)
            If grd <= 270 And topObot = 90 Then grd -= 2 'si esta a la curva de l'esquerra
            If (grd <= 90 Or grd <= 360) And topObot = 270 Then 'si esta a la curva de la dreta
                If grd = 0 Then grd = 360
                grd -= 2
            End If
            Thread.CurrentThread.Sleep(10)
            'Label1.Text = "Player 1: " + Str(posX + rx) + ", " + Str(posY + ry) 'Posicio player
            'Me.Refresh()
        End While
    End Sub
    Sub InvokePbox(ByVal tg As Integer, ByVal px As Integer, ByVal py As Integer, ByVal rx As Integer, ByVal ry As Integer)
        For Each ctl In Controls
            If TypeOf ctl Is PictureBox Then
                If ctl.Tag = tg Then
                    ctl.Location = New Point(px + rx, py + ry)
                End If
            End If
        Next
    End Sub
    Sub Recta(ByRef pbox As PictureBox, ByRef pboxFi As PictureBox, ByVal yCorr As Integer)
        While pboxFi.Location.X
            If pbox.Location.X > 687 And pbox.Location.Y < yCorr Then
                Curva(90, 270, derX, izDerY, corr1, pbox)
            End If
        End While
        Randomize()

        pY = 397
        pX = 258
        While pX < 670 ' p ---------->
            pX += 4
            PictureBox1.Location = New Point(pX, pY)
            Thread.CurrentThread.Sleep(10)
            Label1.Text = "Player 1: " + Str(pX) + ", " + Str(pY) 'Posicio player
            'Me.Refresh()
        End While
        Curva(90, 270, derX, izDerY, corr1, pbox)


        pY = 137 'posicio Y recta superior
        While pX >= 258 ' <----------- p
            pX -= 4
            PictureBox1.Location = New Point(pX, pY)
            Thread.CurrentThread.Sleep(10)
            Label1.Text = "Player 1: " + Str(pX) + ", " + Str(pY) 'Posicio player
            'Me.Refresh()
        End While
        'Curva(270, 90, izX, izDerY, corr1)
    End Sub

End Class
