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
        Inherits B
        Sub fofcc()
            Console.WriteLine("Procedure of class C")
        End Sub
    End Class
    Sub Main()
        Dim objB = New B()
        objB.fofca()
        objB.fofcb()
        Console.WriteLine("==============================")
        Dim objC = New C()
        objC.fofca()
        objC.fofcb()
        objC.fofcc()
    End Sub

End Module
