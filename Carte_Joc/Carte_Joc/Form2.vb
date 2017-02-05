Public Class Form2
    Dim tempsVista As Integer = 200
    Dim lvl As Integer = 1
    Dim nCart As Integer = 8
    Dim click1 As Integer = -1
    Dim click2 As Integer = -1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Size = New System.Drawing.Size(680, 360)
        LabelLvL.Text = Str(lvl)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Timer1.Start()
        ButtonStart.Enabled = False

    End Sub

    Private Sub ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'limitamos la entrada para que solo pueda haber dos cartas boca arriba
        If click1 = -1 And click2 = -1 Or click1 = -1 And click2 > -1 Or click1 > -1 And click2 = -1 Then
            If click1 = -1 Then
                click1 = sender.tag ' guardamos el tag del primer picturebox que le hicimos click
                sender.BackgroundImage = ImageList1.Images(sender.tag) 'le ponemos la imagen que tiene en su tag para "darle" la vuelta

            ElseIf click2 = -1 Then
                click2 = sender.tag ' guardamos el segundo tag del picturebox que le hicimos click
                sender.BackgroundImage = ImageList1.Images(sender.tag) 'le ponemos la imagen que tiene en su tag para "darle" la vuelta
                For i As Integer = 0 To 30 ' un bucle para "parar" y ver si eran iguales o no
                    System.Threading.Thread.Sleep(10)
                    Application.DoEvents()
                Next
            End If
            If click1 <> -1 And click2 <> -1 Then 'si comp y comp2 no son iguales a -1 entonces entramos
                If click1 = click2 Then ' comprueba que comp y comp2 sean iguales
                    For n = 0 To nCart - 1 ' si son iguales hace un bucle for buscando el tag en la array
                        If click1 = a(n).Tag Then ' cuando la encuentra no deja clickar y el tag cambia a true
                            a(n).Enabled = False
                            a(n).Tag = True
                        End If
                    Next
                    click1 = -1 'reseteamos las variables a -1
                    click2 = -1 'reseteamos las variables a -1
                    sender.Enabled = False 'a la imagen del ultimo click le indicamos que esté desactivada
                    sender.Tag = True ' y cambiamos su tag a true
                Else
                    For n = 0 To nCart - 1 ' si no son iguales resetea el tag y gira las cartas
                        If sender.tag = a(n).Tag Then ' buscamos el tag para girar la carta de nuevo y ponerla a 0
                            a(n).BackgroundImage = ImageList1.Images(0)
                        ElseIf click1 = a(n).Tag Then
                            a(n).BackgroundImage = ImageList1.Images(0)
                        End If
                    Next
                    click1 = -1 ' se resetean las variables de nuevo
                    click2 = -1
                End If
            End If
        End If
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tempsVista > 0 Then
            tempsVista -= 1
            LabelTimer.Text = tempsVista / 10
        Else
            Timer1.Stop()
            LabelTimer.Text = "Temps"
        End If
    End Sub
End Class