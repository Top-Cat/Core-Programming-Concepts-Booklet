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
            strEntry = fileReader.ReadLine
            Console.WriteLine(strEntry)
            position = InStr(1, strEntry, ",")
            strName = Left(strEntry, position - 1)
            'Console.WriteLine(position)
            Console.WriteLine("Name is : " & strName)

            position2 = InStr(position + 1, strEntry, ",")
            'Console.WriteLine(position2)
            strSubject = Mid(strEntry, position + 1, position2 - position - 1)
            Console.WriteLine("Subject is : " & strSubject)


            intScore = Right(strEntry, Len(strEntry) - position2)
            Console.WriteLine("score is : " & intScore)


        Loop
        fileReader.Close()

    End Sub
End Module