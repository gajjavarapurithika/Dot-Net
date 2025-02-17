Module Module1
    Sub Main()
        Dim num1, num2, num3 As Integer

        ' Input the three numbers
        Console.WriteLine("Enter first number: ")
        num1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter second number: ")
        num2 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter third number: ")
        num3 = Convert.ToInt32(Console.ReadLine())

        ' Find the largest number
        If num1 >= num2 AndAlso num1 >= num3 Then
            Console.WriteLine("The largest number is " & num1)
        ElseIf num2 >= num1 AndAlso num2 >= num3 Then
            Console.WriteLine("The largest number is " & num2)
        Else
            Console.WriteLine("The largest number is " & num3)
        End If
    End Sub
End Module
