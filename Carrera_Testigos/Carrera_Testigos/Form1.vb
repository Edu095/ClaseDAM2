Imports System.Math
Imports System.Threading
Public Class Form1


    Dim izX As Integer = 258 'eje x del centro de la circunferencia Izquierda
    Dim izDerY As Integer = 267 'eje y del centro de la circunferencia
    Dim derX As Integer = 670 'eje x del centro de la circunferencia Derecha
    'Dim pctBox() As PictureBox
    Dim corr1 As Integer = 130 'radio hasta el jugador 1
    Dim corr2 As Integer = 163 'radio hasta el jugador 2
    Dim corr3 As Integer = 195 'radio hasta el jugador 3
    Dim corr4 As Integer = 227 'radio hasta el jugador 4
    Dim pY As Integer = 397 'posicio Y recta inferior
    Dim pX As Integer = 258 'posicio X PictureBox1 començant esquerra

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()

        pY = 397
        pX = 258
        While pX < 670 ' p ---------->
            pX += 4
            PictureBox1.Location = New Point(pX, pY)
            Thread.Sleep((Rnd() * 5) + 10)
            Label1.Text = "Player 1: " + Str(pX) + ", " + Str(pY) 'Posicio player
            Me.Refresh()
        End While
        Curva(90, 270, derX, izDerY, corr1)


        pY = 137 'posicio Y recta superior
        While pX >= 258 ' <----------- p
            pX -= 4
            PictureBox1.Location = New Point(pX, pY)
            Thread.Sleep((Rnd() * 5) + 10)
            Label1.Text = "Player 1: " + Str(pX) + ", " + Str(pY) 'Posicio player
            Me.Refresh()
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
            Thread.Sleep((Rnd() * 5) + 10)
            Label1.Text = "Player 1: " + Str(posX + rx) + ", " + Str(posY + ry) 'Posicio player
            Me.Refresh()
        End While
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = ImageCorredores.Images(0)
    End Sub


    ' Dim cont As Integer = 10 '----128 'corregir desvio a y=137 (y+=9)
    '------ Posible error calculat de la semicircunferencia (posar al segon while)------
    'If cont = 0 And x > 560 Then
    '    pY += 1
    '    cont = 10
    'ElseIf cont = 0 And x <= 348 Then
    '    pY -= 1
    '    cont = 10
    'ElseIf x > 348 And x <= 560 Then
    '    cont = 10
    'Else
    '    cont -= 2
    'End If
End Class
