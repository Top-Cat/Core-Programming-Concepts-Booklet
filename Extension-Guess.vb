Module Module1

    Sub Main()
        Dim word, guess As String
        Console.WriteLine(The new word)  word = Console.ReadLine().ToUpper()
        Do
            Console.WriteLine(Your guess)  guess = Console.ReadLine().ToUpper()

            If word = guess Then
                Console.WriteLine(Correct)
            Else
                Console.WriteLine(Wrong)
            End If
        Loop Until guess = word Or guess = "NO MORE"
    End Sub

End Module