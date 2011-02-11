Imports System.IO
Module Module1

    Sub Main()
        Dim fileStream As FileStream = New FileStream("C:\students.txt", FileMode.Open)
        Dim bReader As BinaryReader = New BinaryReader(fileStream)
        Dim g As String

        Do While fileStream.Position < fileStream.Length
            Console.WriteLine("Name: " & bReader.ReadString())
            Console.WriteLine("Age: " & bReader.ReadByte)
            Console.WriteLine("Telephone: " & bReader.ReadString)

            If bReader.ReadBoolean() Then
                g = "Male"
            Else
                g = "Female"
            End If
            Console.WriteLine("Gender: " & g)
            Console.WriteLine()
        Loop

        bReader.Close()
        fileStream.Close()

        Console.ReadLine()

    End Sub

End Module