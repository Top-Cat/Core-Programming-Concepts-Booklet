Module Module1

    Sub Main()

        'Declare and dimension all variables
        Dim userdata(4) As String, items() As String = {"legs", "eyes", "feet", "hands"}
        Dim sentance() As String = {"Once upon a time, there lived a ", "who had huge ", "It lived in the town of ", "and it was called ", "They were only ", " years old"}
        Dim userdataDesc() As String = {"a fantasy creature name", "a town name", "your full name", "your ideal age"}

        'Ask the user for each peice of data in turn
        For a As Integer = 1 To userdataDesc.Length
            Console.Write("Please enter " & userdataDesc(a - 1) & ": ")
            userdata(a - 1) = Console.ReadLine()
            Console.Clear()
        Next

        'While loop until user chooses one of the provided values
        While userdata(4) < 1 Or userdata(4) > 4
            Console.WriteLine("Choose one:")
            For a As Integer = 1 To items.Length
                Console.WriteLine(a & ": " & items(a - 1))
            Next
            userdata(4) = Val(Console.ReadLine())
            Console.Clear()
            Console.WriteLine("Input invalid")
            Console.WriteLine("")
        End While
        Console.Clear()
        userdata(4) = items(userdata(4) - 1)

        ' Output the story
        Console.WriteLine(sentance(0) & userdata(0))
        Console.WriteLine(sentance(1) & userdata(4))
        Console.WriteLine(sentance(2) & userdata(1))
        Console.WriteLine(sentance(3) & userdata(2))
        Console.WriteLine(sentance(4) & userdata(3) & sentance(5))
        Console.ReadKey()

    End Sub

End Module