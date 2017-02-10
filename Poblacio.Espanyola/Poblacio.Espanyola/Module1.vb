Module Module1
    Public ruta As String
    Public Function abrir() As String   'Per aconseguir la ruta només
        Form1.OpenFileDialog1.FileName = ""
        Form1.OpenFileDialog1.InitialDirectory = "c:\desktop"
        Form1.OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|all files (*.*)|*.*"
        Form1.OpenFileDialog1.FilterIndex = 1

        Form1.OpenFileDialog1.ShowDialog()

        Return Form1.OpenFileDialog1.FileName
    End Function
End Module
