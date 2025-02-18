Class Bird
    Public age As Integer
    Public wings As Integer
    Public wt As Double
    Public color As String
    Sub fly()
        Console.WriteLine("They fly to fulfiii natural activites")
    End Sub
End Class
Module Module1

    Sub Main()

        Dim parrot = New Bird()
        parrot.age = 5
        parrot.wings = 2
        parrot.wt = 4.5
        parrot.color = "green"
        parrot.fly()
    End Sub

End Module
