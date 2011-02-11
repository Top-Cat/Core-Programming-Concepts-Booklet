Imports System.IO
Module Module1

    Structure student
        Dim name As String
        Dim age As Byte
        Dim contactno As String
        Dim male As Boolean
    End Structure

    Sub Main()
        Dim studentcount As Integer = 5
        Dim students(studentcount) As student
        For i = 0 To studentcount - 1
            Console.Clear()
            Console.WriteLine("Enter student's name")
            students(i).name = Console.ReadLine

            Console.WriteLine("Enter student's age")
            students(i).age = Val(Console.ReadLine)

            Console.WriteLine("Enter student's telephone number")
            students(i).contactno = Console.ReadLine

            Dim g As Boolean = False
            While g = False
                g = True
                Console.WriteLine("Enter student's gender (M/F)")
                Select Case Console.ReadLine
                    Case "M"
                        students(i).male = True
                    Case "F"
                        students(i).male = False
                    Case Else
                        g = False
                End Select
            End While
        Next

        Dim fileStream As FileStream = New FileStream("C:\students.txt", FileMode.Create)
        Dim bWriter As BinaryWriter = New BinaryWriter(fileStream)

        For i = 0 To studentcount - 1
            bWriter.Write(students(i).name)
            bWriter.Write(students(i).age)
            bWriter.Write(students(i).contactno)
            bWriter.Write(students(i).male)
        Next

        bWriter.Close()
        fileStream.Close()

        Console.ReadLine()

    End Sub

End Module