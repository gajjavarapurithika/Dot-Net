Class Rectangle
    Public length As Double
    Public breadth As Double
    Sub New(x As Integer, y As Integer)
        length = x
        breadth = y
    End Sub
    Sub shwvals()
        Console.WriteLine("length=" & length)
        Console.WriteLine("breadth=" & breadth)
    End Sub
    Function carea() As Integer
        Return length * breadth
    End Function
End Class
Module Module1

    Sub Main()
        Dim r As New Rectangle(100, 150)
        r.shwvals()
        Console.WriteLine("Area=" & r.carea())
    End Sub

End Module
