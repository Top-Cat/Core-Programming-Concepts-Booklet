Module Module1

    Sub Main()
        Dim intNum1, intNum2, intNum3 As Integer
        p("First Number:", intNum1)
        p("Second Number:", intNum2)
        p("Third Number:", intNum3)

        p("First was: {0}", intNum1, False)
        p("Second was: {0}", intNum2, False)
        p("Third was: {0}", intNum3)
    End Sub

    Sub p(ByVal s As String, Optional ByRef arg0 As Object = "", Optional ByVal b As Boolean = True)
        Console.WriteLine(s, arg0)
        If b Then
            arg0 = Val(Console.ReadLine())
        End If
    End Sub

End Module