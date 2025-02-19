Imports System.Threading

Module Module1
    Interface A
        Sub greetone()
    End Interface
    Interface B
        Sub greettwo()
    End Interface
    Class C
        Implements A, B
        Public Sub greetone() Implements A.greetone
            Console.WriteLine("Hello from greet one")
        End Sub

        Public Sub greettwo() Implements B.greettwo
            Console.WriteLine("Hello from greet two")
        End Sub
    End Class
    Sub Main()
        Dim objc = New C()
        objc.greetone()
        objc.greettwo()

    End Sub

End Module
