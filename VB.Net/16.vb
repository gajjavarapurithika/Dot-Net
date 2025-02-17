Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        System.Console.WriteLine("Enter a value:")
        a = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Enter b value:")
        b = Convert.ToInt32(Console.ReadLine())
        c = a + b
        System.Console.WriteLine("Addition=" & c)
        c = a - b
        System.Console.WriteLine("subtraction=" & c)
        c = a * b
        System.Console.WriteLine("Multiplication=" & c)
        c = a / b
        System.Console.WriteLine("Division=" & c)
        c = a \ b
        System.Console.WriteLine("Floor division=" & c)
        c = a Mod b
        System.Console.WriteLine("Modulus=" & c)
        c = a ^ b
        System.Console.WriteLine("Exponentional=" & c)
    End Sub

End Module
