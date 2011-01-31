Module Module1

    Sub Main()
        Const max As Integer = 12
        Dim ColNumber, RowNumber, Sum As Integer
        Dim lineb As String = vbCrLf & "-----------------------------------------------------" & vbCrLf
        Dim header As String = "| * |"

        For ColNumber = 1 To max
            If ColNumber < 10 Then
                header += " "
            End If
            header += " " & ColNumber
            header += "|"
        Next

        header += lineb

        For RowNumber = 1 To max
            header += "| "
            If RowNumber < 10 Then
                header += " "
            End If
            header += "" & RowNumber & "|"
            For ColNumber = 1 To max
                Sum = ColNumber * RowNumber
                If Sum < 10 Then
                    header += "  "
                ElseIf Sum < 100 Then
                    header += " "
                End If
                header += "" & Sum
                header += "|"
            Next
            header += lineb
        Next

        Console.WriteLine(header)
        Console.ReadLine()
    End Sub

End Module