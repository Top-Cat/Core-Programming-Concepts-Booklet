Module Module1

    Sub Main()
        Dim op As Byte = 0
        While Val(op) < 7
            op = 0
            While Val(op) < 1 Or Val(op) > 7
                Console.Clear()
                Console.WriteLine("************************************************************************" + vbCrLf + _
                                  "*        1: Decimal to Binary                                          *" + vbCrLf + _
                                  "*        2: Decimal to Hexadecimal                                     *" + vbCrLf + _
                                  "*        3: Binary to Decimal                                          *" + vbCrLf + _
                                  "*        4: Binary to Hexadecimal                                      *" + vbCrLf + _
                                  "*        5: Hexadecimal to Decimal                                     *" + vbCrLf + _
                                  "*        6: Hexadecimal to Binary                                      *" + vbCrLf + _
                                  "*                                                                      *" + vbCrLf + _
                                  "*        7: Exit                                                       *" + vbCrLf + _
                                  "*                                                                      *" + vbCrLf + _
                                  "*                                                                      *" + vbCrLf + _
                                  "*        Enter operation to carry out                                  *" + vbCrLf + _
                                  "************************************************************************")
                op = Console.ReadLine
            End While
            If Val(op) < 7 Then
                Dim num As String
                Console.WriteLine("Enter number to process: ") : num = Console.ReadLine()
                Try
                    Select Case op
                        Case 1
                            DtoB(num)
                        Case 2
                            DtoH(num)
                        Case 3
                            BtoD(num)
                        Case 4
                            BtoH(num)
                        Case 5
                            HtoD(num)
                        Case 6
                            HtoB(num)
                    End Select
                    Console.WriteLine("Output: " & num)
                Catch e As OverflowException
                    Console.WriteLine("Overflow")
                Catch e As FormatException
                    Console.WriteLine("Format error")
                End Try
                Console.ReadLine()
            End If
        End While
    End Sub

    Sub DtoB(ByRef num As String)
        num = Convert.ToString(Integer.Parse(num), 2)
    End Sub

    Sub DtoH(ByRef num As String)
        num = Convert.ToString(Integer.Parse(num), 16)
    End Sub

    Sub BtoD(ByRef num As String)
        num = Convert.ToInt32(num, 2)
    End Sub

    Sub BtoH(ByRef num As String)
        num = Convert.ToString(Convert.ToInt32(num, 2), 16)
    End Sub

    Sub HtoD(ByRef num As String)
        num = Convert.ToInt32(num, 16)
    End Sub

    Sub HtoB(ByRef num As String )
        num = Convert.ToString(Convert.ToInt32(num, 16), 2)
    End Sub

End Module