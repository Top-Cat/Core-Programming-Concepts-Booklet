Imports System.IO

Module Module1

    Sub Main()
        Dim choice As Byte

        Do
            Console.Clear()
            Console.WriteLine("Please select an option from below:")
            Console.WriteLine(" 1 - write to a file")
            Console.WriteLine(" 2 - read from a file")
            Console.WriteLine(" 3 - quit")

            choice = Console.ReadLine


            Select Case choice
                Case 1 : Call WriteToFile()
                Case 2 : Call ReadFromFile()
                Case 3 : End
                Case Else
                    Console.WriteLine("Invalid option, press ENTER to continue")
                    Console.ReadLine()
                    Console.Clear()
            End Select
        Loop Until choice = 3
        Console.ReadLine()

    End Sub

    Sub ReadFromFile()

        Dim fileReader As StreamReader
        Dim fileName As String
        Dim strEntry As String

        fileName = "C:\writerExample.txt"
        fileReader = New StreamReader(fileName)

        Do While Not fileReader.EndOfStream
            strEntry = fileReader.ReadLine()
            Console.WriteLine(strEntry)
        Loop

        fileReader.Close()
        Console.ReadLine()
    End Sub

    Sub WriteToFile()
        Dim fileWriter As StreamWriter
        Dim fileName As String
        Dim strEntry As String
        Dim count As Integer

        fileName = "C:\writerExample.txt"
        fileWriter = New StreamWriter(fileName)

        For count = 1 To 5
            Console.WriteLine("Enter name no: {0}", count)
            strEntry = StrConv(Console.ReadLine(), VbStrConv.ProperCase)
            fileWriter.WriteLine(strEntry)
        Next count

        fileWriter.Close()

        Console.WriteLine("Names written to file. Press any key to exit")
        Console.ReadLine()


    End Sub

End Module