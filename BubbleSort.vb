Module Module1

    Sub Main()
        Dim nums() As Integer = getnums()
        Dim passes = sort(nums)
        disp(passes, nums)
        Console.ReadKey()
    End Sub

    Function getnums() As Array
        Dim nums(7) As Integer
        For i = 0 To 7
            Console.WriteLine("Enter a number (1-100) :")
            Dim tmp As String = Console.ReadLine
            If Not isWholeNumber(tmp) Then
                tmp = 0
            End If
            nums(i) = tmp
            If nums(i) < 1 Or nums(i) > 100 Then
                Console.WriteLine("Number was invalid or outside range!")
                i -= 1
            End If
        Next
        Return nums
    End Function

    Function isWholeNumber(ByVal s As String) As Boolean
        Try
            Dim i As Integer = s
            Return i = s
        Catch : End Try
    End Function

    Function sort(ByVal nums() As Integer) As Integer
        sort = 0
        Dim m As Boolean
        Dim tmp As Integer
        Do
            m = False
            For i As Integer = 0 To nums.GetUpperBound(0) - 1
                If nums(i) > nums(i + 1) Then
                    m = True
                    tmp = nums(i + 1)
                    nums(i + 1) = nums(i)
                    nums(i) = tmp
                End If
            Next
            sort += 1
        Loop While m = True
    End Function

    Sub disp(ByVal p As Integer, ByVal numsd() As Integer)
        Console.Clear()
        Console.WriteLine(p & " pass(es)")
        For i As Integer = 0 To numsd.GetUpperBound(0)
            If i > 0 Then Console.Write(", ")
            Console.Write(numsd(i))
        Next
        Console.WriteLine()
    End Sub

End Module