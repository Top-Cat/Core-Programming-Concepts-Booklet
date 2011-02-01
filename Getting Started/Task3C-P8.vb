Module Module1

    Sub Main()
        Const price As Single = 19.95
        Const discount As Integer = 30
        Dim discountAmm As Single = Math.Round(((discount / 100) * price) * 100) / 100 'Round to 2dp (Could use format, but this is simpler)
        Dim newPrice = price - discountAmm

        Console.WriteLine("Original price: {0}, New Price: {1}", price, newPrice)
        Console.ReadKey()
    End Sub

End Module