Imports System.Runtime.InteropServices

Class Rectangle
    Public length As Double
    Public breadth As Double
    Sub shwvals()
        Console.WriteLine("Lenght:" & length)
        Console.WriteLine("Breadth:" & breadth)
    End Sub
    Function carea() As Integer
        Return length * breadth
    End Function
End Class
Module Module1

    Sub Main()
        Dim r As New Rectangle()
        r.length = 20
        r.breadth = 10
        r.shwvals()
        Console.WriteLine("Area=" & r.carea())
    End Sub

End Module
