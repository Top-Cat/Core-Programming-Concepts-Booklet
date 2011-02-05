Imports System.IO
Module Module1

    Dim fileName, strEntry As String

    Sub Main()
        fileName = "C:\writerExample.txt"
        While True
            Console.Clear()
            Console.WriteLine("*****************************" + vbCrLf + _
                              "* Select an option:         *" + vbCrLf + _
                              "*                           *" + vbCrLf + _
                              "* 1. Write to file          *" + vbCrLf + _
                              "* 2. Read from file         *" + vbCrLf + _
                              "* 3. Quit                   *" + vbCrLf + _
                              "*****************************" + vbCrLf)
            Select Case Val(Console.ReadLine())
                Case 1
                    Write()
                Case 2
                    Read()
                Case 3
                    Exit While
                Case Else
                    Console.WriteLine("Invalid choice, press enter to continue")
                    Console.ReadKey()
            End Select
        End While
    End Sub

    Sub Read()
        Dim fileReader As StreamReader = New StreamReader(fileName)

        Console.WriteLine("-- Reading from file --")

        Do While Not fileReader.EndOfStream
            strEntry = fileReader.ReadLine
            Console.WriteLine(strEntry)
        Loop

        close(fileReader)
    End Sub

    Sub Write()
        Dim fileWriter As StreamWriter = New StreamWriter(fileName)

        For count = 1 To 5
            Console.WriteLine("Enter a new no: {0}", count)
            strEntry = StrConv(Console.ReadLine(), VbStrConv.ProperCase)
            fileWriter.WriteLine(strEntry)
        Next

        close(fileWriter)
    End Sub

    Sub close(ByRef fileHandle As Object)
        fileHandle.Close()

        Console.WriteLine("Press any key to continue")
        Console.ReadKey()
    End Sub

End Module