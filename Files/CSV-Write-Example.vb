Imports System.IO
Module Module1

    Sub Main()
        Dim fileWriter As StreamWriter
        Dim fileName As String
        Dim strEntry As String, strName As String
        Dim strSubject As String
        Dim intScore As Integer

        fileName = "C:\CSVWriterExample.csv"
        fileWriter = New StreamWriter(fileName)

        strName = "Chris"
        strSubject = "English"
        intScore = 12

        strEntry = strName & "," & strSubject & ","

        fileWriter.WriteLine(strEntry & intScore)

        fileWriter.Close()

        Console.WriteLine("Finished Writing CSV file")

        Console.ReadLine()
    End Sub

End Module