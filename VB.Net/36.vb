Module Module1

    Sub Main()
        Dim a(3, 3) As Integer
        a(0, 0) = 10
        a(0, 1) = 20
        a(1, 0) = 30
        a(1, 1) = 40
        a(1, 2) = 50
        a(2, 0) = 60
        a(2, 1) = 70
        a(2, 2) = 80
        Console.WriteLine(a(2, 0))
    End Sub

End Module
