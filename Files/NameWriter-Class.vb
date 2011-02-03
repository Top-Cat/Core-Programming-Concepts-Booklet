Imports System.IO
Module Module1

    Sub Main()
        Dim fileWriter As StreamWriter
        Dim fileName, strEntry, choice As String
        choice = ""
        'choice = yes will stop the loop

        fileName = "C:\example.txt"
        fileWriter = New StreamWriter(fileName)

        Do Until choice = "Y"
            Console.Write("Please enter your name: ")
            strEntry = StrConv(Console.ReadLine(), VbStrConv.ProperCase)
            fileWriter.WriteLine(strEntry)

            Do
                Console.Write("Do you want to stop? {Y/N} ")
                choice = Console.ReadLine
                If choice <> "Y" And choice <> "N" Then
                    Console.WriteLine("Please enter Y or N")
                End If
            Loop Until choice = "Y" Or choice = "N"
        Loop
        fileWriter.Close()
        Console.ReadLine()
    End Sub

End Module