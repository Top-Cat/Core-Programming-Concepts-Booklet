Imports System.IO
Module Module1

    Sub Main()
        Dim fileReader = New StreamReader("C:\strings.txt")
        Dim i() As String = fileReader.ReadToEnd().Replace(vbCrLf, " ").Split(" ")
        Dim sentance = Join(i, " ")
        Console.WriteLine(sentance)
        Console.WriteLine(i.Length)
        Console.ReadLine()
        For j = 0 To i.Length - 1
            Console.WriteLine("Enter word: ")
            i(j) = Console.ReadLine
        Next
        sentance = Join(i, " ")
        Console.WriteLine(sentance)
        Console.ReadLine()
    End Sub

End Module