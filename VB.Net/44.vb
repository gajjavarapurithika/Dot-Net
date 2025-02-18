Class Rectangle
    Public length As Double
    Public breadth As Double
    Sub New()
        length = 20
        breadth = 20
    End Sub
    Sub shwvals()
        Console.WriteLine("Length:" & length)
        Console.WriteLine("breadth:" & breadth)
    End Sub
    Function carea() As Integer
        Return length * breadth
    End Function
End Class
Module Module1

    Sub Main()
        Dim r As New Rectangle()
        r.shwvals()
        System.Console.WriteLine("Area=" & r.carea())
    End Sub

End Module
