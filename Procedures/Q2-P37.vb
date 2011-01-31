Module Module2

    Sub Main()
        Dim name As String = ""
        out(proc(input(name)))
    End Sub

    Function input(ByRef name) As String
        p("What's your name?", name)
        Return name
    End Function

    Function proc(ByVal name) As Integer
        Return name.ToString.Length
    End Function

    Sub out(ByVal len)
        p("There are {0} letters in your name", len)
    End Sub

    Sub p(ByVal s As String, Optional ByRef arg0 As Object = "", Optional ByVal b As Boolean = True)
        Console.WriteLine(s, arg0)
        If b Then
            arg0 = Console.ReadLine()
        End If
    End Sub

End Module