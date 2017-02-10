Public Class Form2
    Dim tempsVista As Integer = 150
    Dim tempsPlay As Integer = 200
    Dim lvl As Integer = 1
    Dim nCart As Integer = 8 'numero de cartes per nivell
    Dim click1 As Integer = -1 'contol de cliks
    Dim click2 As Integer = -1 'control de cliks
    Dim tagCarta(nCart - 1) As Integer 'control de imatjes assignades a picturebox


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Visible = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Size = New System.Drawing.Size(680, 376)
        LabelLvL.Text = Str(lvl)

        For Each clt In Controls
            If TypeOf clt Is PictureBox And clt.Tag < nCart Then
                clt.BackgroundImage = ImageListBG.Images(bgCarta) ' es carregaran el numero de cartes del nivell amb els seus backgrounds
            End If
        Next

        Select Case bgCarta 'assignem el imagelist a utilitzar
            Case 0
                ImageListFinal = ImageListHS
            Case 1
                ImageListFinal = ImageListPokemon
            Case 2
                ImageListFinal = ImageListMine
            Case 3
                ImageListFinal = ImageListPortal
        End Select
    End Sub


    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Dim x As Integer = 0
        Dim y As Boolean = True
        Randomize()
        Dim cartas2((nCart / 2) - 1) 'guardarem en un vector el nombre de vegades que surt una carta per a nomes nostrarla 2 cops


        For Each clt In Controls
            If TypeOf clt Is PictureBox And clt.Tag < nCart Then
                While y
                    x = Rnd() * ((nCart / 2) - 1)
                    If cartas2(x) < 2 Then 'si la carta x no s'ha utilitzat mes de dos cops entra
                        clt.BackgroundImage = ImageListFinal.Images(x) 'assigna una imatge
                        tagCarta(clt.Tag) = ImageListFinal.Tag(x)
                        cartas2(x) += 1
                        y = False
                    End If
                End While
                y = True
            End If
        Next

        Timer1.Start() ' s'inicia el temps en el que podem memoritzar les cartes
        ButtonStart.Enabled = False 'es desabilite el boto

        ' es donarà la volta a les cartes
        ' s'hiniciarà el segon Timer per la conta enrrere per trobar les parelles

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'conte enrrere per memoritzar les parelles
        If tempsVista > 0 Then
            tempsVista -= 1
            LabelTimer.Text = tempsVista / 10
        Else
            Timer1.Stop()
            LabelTimer.Text = "Comença!!"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'conte enrrere per trobar les parelles
        If tempsPlay > 0 Then
            tempsPlay -= 1
            LabelTimer.Text = tempsPlay / 10
        Else
            Timer1.Stop()
            LabelTimer.Text = "Temps"
        End If
    End Sub



    Private Sub ClickPictureBox(ByVal tag As Integer)
        'controlem que nomes es clickin dos cartes
        If click1 = -1 Then
            click1 = tag
            For Each clt In Controls
                If TypeOf clt Is PictureBox And clt.Tag = click1 Then
                    clt.BackgroundImage = ImageListFinal.Images(tagCarta(click1)) 'si clickem un cop es "done la volta" a la carta clickada
                End If
            Next
        Else
            click2 = tag
            For Each clt In Controls
                If TypeOf clt Is PictureBox And clt.Tag = click2 Then
                    clt.BackgroundImage = ImageListFinal.Images(tagCarta(click2)) 'si clickem un segon cop es "done la volta" a la carta clickada
                End If
            Next
        End If
        If click1 > -1 And click2 > -1 Then
            'comparem que les dos clickades tingon el mateix tag de imatge
            If ImageListFinal.Tag(tagCarta(click1)) <> ImageListFinal.Tag(tagCarta(click2)) Then
                For Each clt In Controls
                    If TypeOf clt Is PictureBox And clt.Tag = click1 Or clt.Tag = click2 Then
                        clt.BackgroundImage = ImageListBG.Images(bgCarta) 'si son diferents les tornem a girar, sino no fem re
                    End If
                Next
            End If
            click1 = -1 'reiniciem el control de clicks
            click2 = -1
        End If
    End Sub

    'Controlem els PictureBox que s'han clickat enviant el numero del tag del picturebox
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ClickPictureBox(0)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ClickPictureBox(1)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ClickPictureBox(2)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ClickPictureBox(3)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ClickPictureBox(4)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        ClickPictureBox(5)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        ClickPictureBox(6)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        ClickPictureBox(7)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        ClickPictureBox(8)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        ClickPictureBox(9)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        ClickPictureBox(10)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        ClickPictureBox(11)
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        ClickPictureBox(12)
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        ClickPictureBox(13)
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        ClickPictureBox(14)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        ClickPictureBox(15)
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        ClickPictureBox(16)
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        ClickPictureBox(17)
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        ClickPictureBox(18)
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        ClickPictureBox(19)
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        ClickPictureBox(20)
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        ClickPictureBox(21)
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        ClickPictureBox(22)
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        ClickPictureBox(23)
    End Sub
End Class