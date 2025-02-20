Module Module1
    Class Myclaci
        Public a As Integer
        Public b As Integer
        Public c As Integer
        Sub dispvals()
            Console.WriteLine("a=" & a & " " & "b=" & b & " " & "c=" & c)
        End Sub
        Sub dispvals(x As Integer, y As Integer)
            a = x
            b = y
            Console.WriteLine("a=" & a & " " & "b=" & b)
        End Sub
        Sub dispvals(x As Integer, y As Integer, z As Integer)
            a = x
            b = y
            c = z
            Console.WriteLine("a=" & a & " " & "b=" & b & " " & "c=" & c)
        End Sub
    End Class
    Sub Main()
        Dim x As New Myclaci()
        x.a = 1
        x.b = 2
        x.c = 3
        x.dispvals()
        x.dispvals(10, 20)
        x.dispvals(10, 20, 30)
    End Sub

End Module
