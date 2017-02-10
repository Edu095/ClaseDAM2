Imports System.IO
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fs As FileStream
        Dim bw As BinaryWriter
        Dim doble As Double = 2555555555555555555
        Dim senser As Int32 = 1234567
        fs = New FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        bw = New BinaryWriter(fs)
        bw.Seek(0, SeekOrigin.Begin)
        bw.Write("Escriure dades amb BinaryWriter 1ª")
        bw.Write(doble)
        bw.Write(senser)

        'bw.Write("Escriure dades amb BinaryWriter 2ª")
        'bw.Write(doble)
        'bw.Write(senser)

        bw.Close()
        fs.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fs As FileStream
        Dim br As BinaryReader
        Dim buffer() As Char
        Dim tamany As Long
        fs = New FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.Read)
        br = New BinaryReader(fs)
        tamany = fs.Length
        ReDim buffer(tamany)
        br.Read(buffer, 0, tamany)
        TextBox1.Text += buffer
        br.Close()
        fs.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fs As FileStream
        Dim br As BinaryReader
        fs = New FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.Read)
        br = New BinaryReader(fs)

        'Do While br.PeekChar <> -1
        TextBox2.Text = br.ReadString
        TextBox3.Text = br.ReadDouble
        TextBox4.Text = br.ReadInt32
        'Loop

        'Do While br.PeekChar <> -1
        '    ListBox1.Items.Add(br.ReadString)
        '    ListBox1.Items.Add(br.ReadDouble)
        '    ListBox1.Items.Add(br.ReadInt32)
        'Loop
        br.Close()
        fs.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

    