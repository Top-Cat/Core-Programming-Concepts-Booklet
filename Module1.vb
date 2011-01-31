Module Module1

    Sub Main()
        Dim marks As Hashtable = New Hashtable
        Dim n As String
        For i As Byte = 1 To 10 'Get 10 marks, change the number for more :D
            addmark(marks)
        Next

        'Could have a menu?

        Console.WriteLine("What student's mark would you like? ") : n = Console.ReadLine
        Console.WriteLine(marks(n))

        Dim dd = From c In marks _
         Order By c.Value _
         Select c           'Order the list. Omnomnom

        Dim da As DictionaryEntry = dd(0)
        Dim db As DictionaryEntry = dd(marks.Count - 1)
        Console.WriteLine("Lowest Mark : " & da.Key & ", Mark : " & da.Value) 'Display lowest score
        Console.WriteLine("Highest Mark : " & db.Key & ", Mark : " & db.Value) 'Display highest score

        Console.ReadLine()
    End Sub

    Sub addmark(ByRef m As Hashtable)
        Dim n As String
        Dim i As Byte = 101
        Console.WriteLine("Enter student's name: ") : n = Console.ReadLine()
        While i > 100
            Console.WriteLine("Enter their mark (/100): ") : i = Val(Console.ReadLine())
        End While
        If m.ContainsKey(n) Then
            m(n) = i
        Else
            m.Add(n, i)
        End If
    End Sub

End Module