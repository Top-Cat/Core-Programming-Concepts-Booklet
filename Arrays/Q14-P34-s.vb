Imports System.Math
Module Module1

    Sub Main()
        Dim names(10) As String
        Dim marks(10) As Integer
        Dim lowest, highest As Integer
        Dim lowestn, highestn As String
        Dim n As String

        For i = 1 To 10
            addmark(names(i), marks(i))
        Next

        Console.WriteLine("What student's mark would you like? ") : n = Console.ReadLine
        For i = 1 To 10
            If i = 1 Then
                lowest = marks(i)
                highest = marks(i)
                lowestn = names(i)
                highestn = names(i)
            Else
                lowest = Min(lowest, marks(i))
                highest = Max(lowest, marks(i))
                If lowest = marks(i) Then
                    lowestn = names(i)
                End If
                If highest = marks(i) Then
                    highestn = names(i)
                End If
            End If
            If names(i) = n Then
                Console.WriteLine(marks(i))
            End If
        Next
        Console.WriteLine("Lowest Mark : " & lowestn & ", Mark : " & lowest) 'Display lowest score
        Console.WriteLine("Highest Mark : " & highestn & ", Mark : " & highest) 'Display lowest score

        Console.ReadLine()
    End Sub

    Sub addmark(ByRef name As String, ByRef score As Integer)
        Console.WriteLine("Enter student's name: ") : name = Console.ReadLine()
        Do
            Console.WriteLine("Enter their mark (/100): ") : score = Val(Console.ReadLine())
        Loop While score > 100
    End Sub

End Module