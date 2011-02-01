Module Module1

    Sub Main()
        Const costPerShare As Single = 25.625
        Const shareCount As Integer = 400
        Dim totalcost As Single = costPerShare * shareCount

        Console.WriteLine("Total cost: " & totalcost)
        Console.ReadKey()
    End Sub

End Module