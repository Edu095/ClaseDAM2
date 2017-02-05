Imports System.Threading.Thread
Public Class Form1
    Dim a() As Control 'creamos el array de controles
    Dim num As Integer = 8 ' nivel 1 8 cartas, 2-12, 3-16, 4-20, 5-24 por defecto 8
    Dim comp As Integer = -1 '"variable para guardar el numero de tag del" primer click
    Dim comp2 As Integer = -1 '"                                         " segundo clcik
    Dim tiempo As Integer = 200  'variable de tiempo donde se almacena los segundos que tiene para memorizar
    Dim tiemporeset As Integer = 200 ' variable donde los timers actuan por defecto 200
    Dim tiemponivel As Integer = 20 'cada nivel resta 2 segundos del tiempo
    Dim NivelCartas As Integer = 1 'nivel del jugador

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        comenzar() ' comienza el juego
    End Sub

    Private Sub ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'limitamos la entrada para que solo pueda haber dos cartas boca arriba
        If comp = -1 And comp2 = -1 Or comp = -1 And comp2 > -1 Or comp > -1 And comp2 = -1 Then
            If comp = -1 Then
                comp = sender.tag ' guardamos el tag del primer picturebox que le hicimos click
                sender.BackgroundImage = ImageList1.Images(sender.tag) 'le ponemos la imagen que tiene en su tag para "darle" la vuelta

            ElseIf comp2 = -1 Then
                comp2 = sender.tag ' guardamos el segundo tag del picturebox que le hicimos click
                sender.BackgroundImage = ImageList1.Images(sender.tag) 'le ponemos la imagen que tiene en su tag para "darle" la vuelta
                For i As Integer = 0 To 30 ' un bucle para "parar" y ver si eran iguales o no
                    System.Threading.Thread.Sleep(10)
                    Application.DoEvents()
                Next
            End If
            If comp <> -1 And comp2 <> -1 Then 'si comp y comp2 no son iguales a -1 entonces entramos
                If comp = comp2 Then ' comprueba que comp y comp2 sean iguales
                    For n = 0 To num - 1 ' si son iguales hace un bucle for buscando el tag en la array
                        If comp = a(n).Tag Then ' cuando la encuentra no deja clickar y el tag cambia a true
                            a(n).Enabled = False
                            a(n).Tag = True
                        End If
                    Next
                    comp = -1 'reseteamos las variables a -1
                    comp2 = -1 'reseteamos las variables a -1
                    sender.Enabled = False 'a la imagen del ultimo click le indicamos que esté desactivada
                    sender.Tag = True ' y cambiamos su tag a true
                Else
                    For n = 0 To num - 1 ' si no son iguales resetea el tag y gira las cartas
                        If sender.tag = a(n).Tag Then ' buscamos el tag para girar la carta de nuevo y ponerla a 0
                            a(n).BackgroundImage = ImageList1.Images(0)
                        ElseIf comp = a(n).Tag Then
                            a(n).BackgroundImage = ImageList1.Images(0)
                        End If
                    Next
                    comp = -1 ' se resetean las variables de nuevo
                    comp2 = -1
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tiemporeset > 0 Then ' timer que cuando llegue al tiempo establecido por defecto (20 segundos) gira las cartas con background 0
            tiemporeset -= 1
            Label1.Text = "Tiempo:" & " " & tiemporeset / 10 & " segundos"
            For n = 0 To num - 1
                a(n).Enabled = False
            Next
        Else
            Timer1.Stop()
            Label1.Text = "Tiempoooo"
            For n = 0 To num - 1
                a(n).BackgroundImage = ImageList1.Images(0) ' cuando estan todas giradas llama a timer2 para continuar
                a(n).Enabled = True
                tiemporeset = tiempo
                Timer2.Start()
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To num - 1 'Cuando pasamos de nivel limpiamos todos los picturebox con este for
            Me.Controls.Remove(a(i))
        Next
        If NivelCartas = 2 Then
            Me.Size = New System.Drawing.Size(Me.Size.Width() + 240, Me.Size.Height())
        End If
        If NivelCartas = 3 Then
            Me.Size = New System.Drawing.Size(Me.Size.Width(), Me.Size.Height() + 240)
            Label1.Location = New Point(Label1.Location.X, Label1.Location.Y + 230)
            Label2.Location = New Point(Label2.Location.X, Label2.Location.Y + 230)
            Button1.Location = New Point(Button1.Location.X, Button1.Location.Y + 230)
        End If
        num += 4 'incrementamos el numero de cartas + 4 cada vez
        tiemporeset = tiempo - tiemponivel 'a tiemporeset le damos el valor de tiempo menos el valor de tiemponivel
        tiemponivel += 20 ' incrementamos la variable tiemponivel 2 segundos cada nivel
        Button1.Enabled = False
        comenzar()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim contador As Integer = 0 ' contador para tener la cuenta del nivel que estamos

        If tiemporeset > 0 Then ' timer de tiempo
            tiemporeset -= 1
            Label1.Text = "Tiempo:" & " " & tiemporeset / 10 & " segundos"
            For i = 0 To num - 1
                If a(i).Tag = True Then
                    contador += 1 ' le suma +1 a contador
                End If
                If contador = num Then ' si contador es igual a num entonces quiere decir que hemos ganado y pasamos al siguiente nivel
                    If NivelCartas <= 5 Then
                        Timer2.Stop()
                        MsgBox("Siguiente nivel")
                        NivelCartas += 1    'aumentamos el nivel del juego
                        Button1.Enabled = True 'activamos el boton de siguiente nivel
                    Else
                        Timer2.Stop()
                        MsgBox("Ganaste!!") ' si llegamos a nivel 5 y lo pasamos se acabó el juego
                        Me.Close() ' se cierra le juego
                    End If
                End If
            Next
        Else
            Timer2.Stop()  'cuando el tiempo se agota busca en la array el tag = true y cuenta cuantos hay
            If contador = num Then ' si contador es igual a num entonces quiere decir que hemos ganado y pasamos al siguiente nivel
                If NivelCartas <= 5 Then
                    MsgBox("Siguiente nivel")
                    NivelCartas += 1    'aumentamos el nivel del juego
                    Button1.Enabled = True 'activamos el boton de siguiente nivel
                Else
                    MsgBox("Ganaste!!") ' si llegamos a nivel 5 y lo pasamos se acabó el juego
                    Me.Close() ' se cierra le juego
                End If
            Else
                MsgBox("Perdiste")
                Me.Close()
            End If
        End If
    End Sub


    'Comienza el juego, genera las cartas dependiendo del nivel, les pone imagen random.
    Private Sub comenzar()
        Dim j As Integer = 1
        Dim x As Integer = 0
        Dim alt As Integer = 40
        Dim temporal As Integer = 0
        Dim index As Integer = 0
        ReDim a(num - 1)
        Dim cartas As New List(Of Integer)
        Dim rndcartas As New Random()
        Dim tcartas As Integer = 0
        Dim numeros As New List(Of Integer)
        Dim rnd As New Random()

        Button2.Hide()
        Timer1.Start()
        Label2.Text = "Nivel:" & " " & NivelCartas

        For i = 1 To 12 'llenamos el array de numeros del 1 al 12 que representan las cartas
            numeros.Add(i)
        Next
        ' creamos los objetos y le ponemos la imagen por defecto
        For n = 0 To num - 1
            a(n) = New PictureBox
            a(n).Name = n
            a(n).Top = x * 170 + alt
            a(n).Left = j * 30 + 10
            a(n).Width = 100
            a(n).Height = 160
            a(n).BackgroundImage = ImageList1.Images(0)
            Me.Controls.Add(a(n))
            AddHandler a(n).Click, AddressOf ClickEvent
            If n = 1 Or n = 3 Or n = 5 Or n = 7 Or n = 9 Then ' posicion de las cartas para que quede "bonito"
                j += 6
                x = -1
            ElseIf n = 11 Or n = 13 Or n = 15 Or n = 17 Or n = 19 Or n = 21 Or n = 24 Then
                If j = 31 Then ' posicion de las cartas para que quede "bonito"
                    j = -5
                    alt = 380
                End If
                j += 6
                x = -1
            End If
            x += 1
        Next

        'añadimos la cantidad de cartas que tenemos en la mesa a la lista cartas
        For i = 0 To num - 1
            cartas.Add(i)
        Next

        'le metemos una imagen y cambiamos su tag para poder compararlos

        For n = 0 To (num / 2) - 1                             'Esto vale 3 ahora mismo 0 1 2 3 - 4 cartas 2 veces
            temporal = numeros(rnd.Next(0, numeros.Count))          'saca un numero aleatorio de la lista de 24 objetos
            For Each x In numeros                                   'un for de esa lista
                If x = temporal Then                                'si un objeto es igual al que teniamos guardado entra en el if
                    index = numeros.IndexOf(x)                      'guardamos su index
                    For y = 0 To 1
                        tcartas = cartas(rnd.Next(0, cartas.Count)) 'posicion donde guardar 1 imagen en dos sitios diferentes
                        a(tcartas).Tag = temporal                       ' guardamos en el tag del numero de la carta
                        a(tcartas).BackgroundImage = ImageList1.Images(temporal)                     ' le ponemos la carta
                        cartas.RemoveAt(cartas.IndexOf(tcartas))               ' quitamos el index para no repetir cartas
                    Next
                End If
            Next
            numeros.RemoveAt(index) 'quitamos el numero de la lista numeros para no repetir
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        tiemporeset = HScrollBar1.Value * 10
    End Sub
End Class
