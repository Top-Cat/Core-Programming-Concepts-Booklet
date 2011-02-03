Imports System.IO
Module Module1

    Sub Main()
        Dim multi As String = "C:\writerExample.txt"
        Dim stw As StreamWriter = New StreamWriter(multi)
        While multi.ToUpper <> "STOP"
            Console.WriteLine("Enter a name, or 'STOP' to end") : multi = StrConv(Console.ReadLine(), VbStrConv.ProperCase)
            If multi.ToUpper <> "STOP" Then
                stw.WriteLine(multi)
            End If
        End While
        stw.Close()
    End Sub

End Module