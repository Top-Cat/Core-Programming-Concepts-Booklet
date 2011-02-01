Module Module1

    Sub Main()
        Const tonsPerAcre As Integer = 18
        Const Acres As Integer = 30
        Dim tons As Single = tonsPerAcre * Acres

        Console.WriteLine("Tons: {0}", tons)
        Console.ReadKey()
    End Sub

End Module