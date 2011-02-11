Imports System.IO

Module Module1

    Sub Main()

        Const gallonslitres As Single = 0.23
        Dim petrol_price As Single
        Dim mpg As Decimal
        Dim litres_held As Integer
        Dim price_full_tank As Single
        Dim miles As Single
        Dim gallons As Single
        Dim fileName As String
        Dim fileWriter As StreamWriter
        Dim strEntry As String

        fileName = "C:\petrol.csv"
        fileWriter = New StreamWriter(fileName)


        Console.WriteLine("Please enter the price of a litre of petrol: ")
        petrol_price = Console.ReadLine()
        Console.WriteLine("Please enter the miles per gallon of your car: ")
        mpg = Console.ReadLine()
        Console.WriteLine("Please enter how many litres of petrol your car's petrol tank can hold: ")
        litres_held = Console.ReadLine()

        price_full_tank = litres_held * petrol_price
        gallons = litres_held * gallonslitres
        miles = mpg * gallons

        Console.WriteLine("It costs: " & price_full_tank & " to fill your car up.")
        Console.WriteLine("The number of miles your car can travel is: " & miles & ".")
        Console.ReadLine()

        strEntry = miles & "," & price_full_tank
        fileWriter.Write(strEntry)

        fileWriter.Close()
        Console.ReadLine()
    End Sub

End Module