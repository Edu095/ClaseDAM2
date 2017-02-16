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
        PictureBox1.Image = ImageCorredores.Images(0)

        For Each ctl In Controls
            If TypeOf ctl Is PictureBox Then
                ctl.tag 'switch case 1,2,3,4 = imageCorredors.1/2/3/4
            End If
        Next

        th1 = New Thread(Sub() Me.carrera(PictureBox1, PictureBox1, 4))
        th2 = New Thread(Sub() Me.carrera(PictureBox2, PictureBox1, 4))
        th3 = New Thread(Sub() Me.carrera(PictureBox3, PictureBox1, 4))
        th4 = New Thread(Sub() Me.carrera(PictureBox4, PictureBox1, 4))
        th5 = New Thread(Sub() Me.carrera(PictureBox5, PictureBox1, 4))
        th6 = New Thread(Sub() Me.carrera(PictureBox6, PictureBox1, 4))
        th7 = New Thread(Sub() Me.carrera(PictureBox7, PictureBox1, 4))
        th8 = New Thread(Sub() Me.carrera(PictureBox8, PictureBox1, 4))
        th9 = New Thread(Sub() Me.carrera(PictureBox9, PictureBox1, 4))
        th10 = New Thread(Sub() Me.carrera(PictureBox10, PictureBox1, 4))
        th11 = New Thread(Sub() Me.carrera(PictureBox11, PictureBox1, 4))
        th12 = New Thread(Sub() Me.carrera(PictureBox12, PictureBox1, 4))
        th13 = New Thread(Sub() Me.carrera(PictureBox13, PictureBox1, 4))
        th14 = New Thread(Sub() Me.carrera(PictureBox14, PictureBox1, 4))
        th15 = New Thread(Sub() Me.carrera(PictureBox15, PictureBox1, 4))
        th16 = New Thread(Sub() Me.carrera(PictureBox16, PictureBox1, 4))

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub carrera(ByRef pbox As PictureBox, ByRef pboxFi As PictureBox, ByVal yCorr As Integer)

        While pboxFi.Location.X
            If pbox.Location.X > 687 And pbox.Location.Y < yCorr Then
                Curva(90, 270, derX, izDerY, corr1)
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
        Curva(90, 270, derX, izDerY, corr1)


        pY = 137 'posicio Y recta superior
        While pX >= 258 ' <----------- p
            pX -= 4
            PictureBox1.Location = New Point(pX, pY)
            Thread.CurrentThread.Sleep(10)
            Label1.Text = "Player 1: " + Str(pX) + ", " + Str(pY) 'Posicio player
            'Me.Refresh()
        End While
        Curva(270, 90, izX, izDerY, corr1)
    End Sub

    Private Sub Curva(ByVal grd As Integer, ByVal topObot As Integer, ByVal posX As Integer, ByVal posY As Integer, ByVal radio As Integer)
        Dim rad As Decimal
        Dim rx, ry As Integer
        While grd <> topObot
            rad = ((grd / radio) * radio) * (PI / 180) 'calculo el radiantede grad
            rx = radio * Cos(rad) 'asigno la posicion x del objeto
            ry = radio * Sin(rad) 'asigno la posicion y del objeto
            PictureBox1.Location = New Point(posX + rx, posY + ry)
            If grd <= 270 And topObot = 90 Then grd -= 2 'si esta a la curva de l'esquerra
            If (grd <= 90 Or grd <= 360) And topObot = 270 Then 'si esta a la curva de la dreta
                If grd = 0 Then grd = 360
                grd -= 2
            End If
            Thread.CurrentThread.Sleep(10)
            Label1.Text = "Player 1: " + Str(posX + rx) + ", " + Str(posY + ry) 'Posicio player
            'Me.Refresh()
        End While
    End Sub

End Class
