Module Module1

    Sub Main()
        Dim bin As String = ""

        Console.WriteLine("Enter a binary number: ") : bin = Console.ReadLine
        Console.WriteLine("Binary to decimal: " & BtoD(bin))

        Console.WriteLine("Enter a decimal number: ") : bin = Console.ReadLine
        Console.WriteLine("Decimal to binary: " & DtoB(Val(bin)))

        Console.WriteLine("Enter a deenery number: ") : bin = Console.ReadLine
        Console.WriteLine("Denery to hex: " & DtoH(bin)) ' i'm a comment =D
        Console.ReadLine()
    End Sub

    Function DtoB(ByVal bin As Integer) As String
        Dim total As String = ""
        Dim tmp As Integer = 1
        Dim count As Byte = Math.Floor(Math.Log(bin, 2)) + 1
        Do
            tmp = Math.Pow(2, count - 1)
            count -= 1

            If bin >= tmp Then
                bin -= tmp
                total = total & "1"
            Else
                total = total & "0"
            End If

        Loop Until count = 0
        Return total
    End Function

    Function BtoD(ByVal bin As String) As Integer
        Dim total As Integer
        For i As Byte = 0 To bin.Length - 1
            Dim j As Integer = Val(Mid(bin, bin.Length - i, 1))
            If j = 0 Or j = 1 Then
                total += Math.Pow(2, i) * j
            Else
                Return 0
            End If
        Next
        Return total
    End Function

    Function DtoH(ByRef bin As Long) As String
        Dim total As String = ""
        Dim tmp As Integer = 1
        Dim count As Byte = Math.Floor(Math.Log(bin, 16)) + 1 'Find the first power of 16 less than the total
        For i = count to 0
            tmp = Math.Pow(16, count - 1)
            count -= 1 'Decrease power

            Dim into As Integer = Math.Floor(bin / tmp) 'How many times does the power go in?
            Select Case into
                Case Is < 10
                    total = total & into 'Just use the number
                Case Else
                    total = total & Chr(55 + into) 'Use ascii 65 = A, 66 = B etc..
            End Select
            bin -= into * tmp 'Decrease number

        Loop Until count = 0 'When we've tried all powers we're done
        Return total 'I like return, +Good Programing Pracitce+
    End Function

End Module