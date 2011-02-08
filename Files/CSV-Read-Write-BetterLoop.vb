Imports System.IO
Module Module1

    Sub Main()
      

        Call writeCSV()
        Call readCSV()

        Console.ReadLine()

    End Sub

    Sub writeCSV()
        Dim fileWriter As StreamWriter
        Dim fileName, strEntry, strName, strSubject As String
        Dim intScore As Integer

        fileName = "C:\CSVWriterExample.csv"
        fileWriter = New StreamWriter(fileName)

        Console.Write("Enter the name : ") : strName = Console.ReadLine
        Console.Write("Enter the subject : ") : strSubject = Console.ReadLine
        Console.Write("Enter the mark : ") : intScore = Console.ReadLine

        strEntry = strName & "," & strSubject & ","

        fileWriter.WriteLine(strEntry & intScore)

        fileWriter.Close()

        Console.WriteLine("Finished writing csv file")

    End Sub
    Sub readCSV()
        Dim fileReader As StreamReader
        Dim fileName, strEntry, strName, strSubject As String
        Dim intScore, position, position2 As Integer

        fileName = "C:\CSVWriterExample.csv"
        fileReader = New StreamReader(fileName)

        Do Until fileReader.EndOfStream
            'the Split function returns an array of values
            Dim i() As String = fileReader.ReadLine().Split(",")
            Console.WriteLine("Name is:" & i(0))

            Console.WriteLine("subject is:" & i(1))

            Console.WriteLine("Score is:" & i(2))

        Loop
        fileReader.Close()

    End Sub
End Module