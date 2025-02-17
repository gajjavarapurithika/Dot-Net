Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Integer
        System.Console.WriteLine("Enter a value:")
        a = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Enter b value:")
        b = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Values before swap a=" & a & "b=" & b)
        a = a + b
        b = a - b
        a = a - b
        System.Console.WriteLine("Values after swap a=" & a & "b=" & b)
    End Sub

End Module
