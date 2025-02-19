Module Module1
    Class Person
        Public Sub Walk()
            System.Console.WriteLine("Person walks slowly")
        End Sub
    End Class
    Class Employee
        Inherits Person
        Public Sub Walk()
            System.Console.WriteLine("Employee walks fastly")
        End Sub
    End Class
    Sub Main()
        Dim e As New Employee()
        e.Walk()
    End Sub

End Module
