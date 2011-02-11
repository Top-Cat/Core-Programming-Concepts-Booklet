Imports System.IO
Module Module1

    Sub Main()
        Dim price, mpg, tankvol As Single
        Const ltg As Single = 4.54609188
        Console.WriteLine("Fuel price per litre (in pence) :") : price = Val(Console.ReadLine())
        Console.WriteLine("Car MPG :") : mpg = Val(Console.ReadLine())
        Console.WriteLine("Volume of petrol tank (in litres) :") : tankvol = Val(Console.ReadLine())

        Dim distance As Single = Math.Round((tankvol / ltg) * mpg, 1)
        Dim cost As Single = Math.Round((tankvol * price) / 100, 2)

        Console.WriteLine("Distance on full tank: " & distance)
        Console.WriteLine("Cost involved: " & FormatCurrency(cost))

        Dim fileWriter As StreamWriter = New StreamWriter("C:\petrol.csv")
        fileWriter.Write(distance & "," & cost)
        fileWriter.Close()

        Console.ReadKey()
    End Sub

End Module