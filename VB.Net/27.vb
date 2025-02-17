Module Module1
    Sub Main()
        Dim num1, num2, num3, num4, num5 As Integer

        ' Input the five numbers
        Console.WriteLine("Enter first number: ")
        num1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter second number: ")
        num2 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter third number: ")
        num3 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter fourth number: ")
        num4 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter fifth number: ")
        num5 = Convert.ToInt32(Console.ReadLine())

        ' Find the largest number
        Dim largest As Integer = num1 ' Assume the first number is the largest initially

        If num2 > largest Then
            largest = num2
        End If

        If num3 > largest Then
            largest = num3
        End If

        If num4 > largest Then
            largest = num4
        End If

        If num5 > largest Then
            largest = num5
        End If

        ' Output the largest number
        Console.WriteLine("The largest number is " & largest)
    End Sub
End Module
