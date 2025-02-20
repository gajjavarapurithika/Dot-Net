Module Module1
    Class Myclaci
        Public a As Integer
        Public b As Integer
        Public c As Integer
        Function mysum()
            Return a + b + c
        End Function
        Function mysum(x As Integer, y As Integer)
            a = x
            b = y
            Return x + y
        End Function
        Function mysum(x As Integer, y As Integer, z As Integer)
            a = x
            b = y
            c = z
            Return a + b + c
        End Function
    End Class
    Sub Main()
        Dim x As New Myclaci()
        x.a = 1
        x.b = 2
        x.c = 3
        Console.WriteLine("Sum=" & x.mysum())
        Console.WriteLine("Sum=" & x.mysum(10, 20))
        Console.WriteLine("Sum=" & x.mysum(10, 20, 30))
    End Sub

End Module
