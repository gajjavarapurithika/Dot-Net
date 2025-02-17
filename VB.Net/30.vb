Module Module1
    Sub Main()
        Dim units As Double
        Dim billAmount As Double

        ' Input the number of units consumed
        Console.WriteLine("Enter the number of units consumed: ")
        units = Convert.ToDouble(Console.ReadLine())

        ' Calculate bill based on the unit consumption
        If units <= 100 Then
            billAmount = units * 1.5 ' Rate for first 100 units
        ElseIf units <= 200 Then
            billAmount = 100 * 1.5 + (units - 100) * 2 ' Rate for next 100 units
        ElseIf units <= 300 Then
            billAmount = 100 * 1.5 + 100 * 2 + (units - 200) * 3 ' Rate for next 100 units
        Else
            billAmount = 100 * 1.5 + 100 * 2 + 100 * 3 + (units - 300) * 4 ' Rate for above 300 units
        End If

        ' Display the bill amount
        Console.WriteLine("The electricity bill for " & units & " units is: Rs. " & billAmount)
    End Sub
End Module
