Module Module1
    Dim l As Integer = 10
    Dim b As Integer = 10
    Sub shwvals()
        System.Console.WriteLine("length=" & l)
        System.Console.WriteLine("breadth=" & b)
    End Sub
    Function carea() As Integer
        Return l * b
    End Function
    Sub Main()
        shwvals()
        Console.WriteLine("Area of rectangle=" & carea())
    End Sub

End Module
