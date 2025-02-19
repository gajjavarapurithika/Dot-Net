Module Module1
    Class A
        Sub fofca()
            Console.WriteLine("Procedure of class A")
        End Sub
    End Class
    Class B
        Inherits A
        Sub fofcb()
            Console.WriteLine("Procedure of class B")
        End Sub
    End Class
    Class C
        Inherits A
        Sub fofcc()
            Console.WriteLine("Procedure of class C")
        End Sub
    End Class
    Class D
        Inherits A
        Sub fofcd()
            Console.WriteLine("Procedure of class D")
        End Sub
    End Class
    Sub Main()
        Dim objB = New B()
        objB.fofca()
        objB.fofcb()
        Console.WriteLine("==============================")
        Dim objC = New C()
        objC.fofca()
        objC.fofcc()
        Console.WriteLine("==============================")
        Dim objD = New D()
        objD.fofca()
        objD.fofcd()
    End Sub

End Module
