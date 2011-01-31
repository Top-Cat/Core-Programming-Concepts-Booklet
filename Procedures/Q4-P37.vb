Module Module1

    Sub Main()
        Dim num1 As Integer = getNum()
        Dim num2 As Integer = getNum()
        Dim num3 As Integer = getNum()

        Dim avg As Integer = CalcAvg(num1, num2, num3)
        Dim total As Integer = CalcTotal(num1, num2, num3)

        Console.WriteLine("The total is: " & total & ", and the average is: " & avg)
        Console.ReadLine()
    End Sub

    Function getNum() As Integer
        Console.WriteLine("Enter a number: ") : Return Console.ReadLine
    End Function

    Function CalcAvg(ByVal ParamArray num()) As Integer
        Dim total As Integer
        For Each i As Integer In num
            total += i
        Next
        total /= num.Length
        Return total
    End Function

    Function CalcTotal(ByVal ParamArray num()) As Integer
        Dim total As Integer
        For Each i As Integer In num
            total += i
        Next
        Return total
    End Function

End Module

