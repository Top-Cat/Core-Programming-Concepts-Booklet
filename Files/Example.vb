Imports System.IO
Module Module1

    Sub Main()
        Dim fileWriter As StreamWriter
        Dim fileName, strEntry As String

        fileName = "C:\writerExample.txt"
        fileWriter = New StreamWriter(fileName)

        For count = 1 To 5
            Console.WriteLine("Enter a new no: {0}", count)
            strEntry = StrConv(Console.ReadLine(), VbStrConv.ProperCase)
            fileWriter.WriteLine(strEntry)
        Next

        fileWriter.Close()

        Console.WriteLine("Names written to file. Press any key to exit")
        Console.ReadKey()
    End Sub

End Module