Imports System.IO
Module Module1

    Sub Main()
        Dim fileReader As StreamReader
        Dim fileName, strEntry As String

        fileName = "C:\writerExample.txt"
        fileReader = New StreamReader(fileName)

        Do While Not fileReader.EndOfStream
            strEntry = fileReader.ReadLine
            Console.WriteLine(strEntry)
        Loop

        fileReader.Close()
        Console.ReadKey()
    End Sub

End Module