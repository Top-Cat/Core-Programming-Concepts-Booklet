Imports System.IO
Module Module1

    Sub Main()
        Dim fileReader As StreamReader = New StreamReader("C:\somefile.txt") ' Open file for reading
        Dim fileContent As String = fileReader.ReadToEnd ' Read entire file
        Dim lines, plines As Integer ' Count number of linebreaks
        For Each i As String In fileContent.Split(vbCrLf)
            If i.Trim.Length > 0 Then 'Only lines with words change the number of words
                plines += 1
            End If
            lines += 1
        Next
        Console.WriteLine(fileContent) ' Output file's contents
        Console.WriteLine("Lines: " & lines) ' Output the number of lines determined by spliting the string by linebreaks
        Console.WriteLine("Words: " & (fileContent.Split(" ").Length + (plines - 1))) ' Number of words
        Console.ReadKey()
    End Sub

End Module