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
        Console.WriteLine("Age of parrot=" & parrot.age)
        Console.WriteLine("Number of wings=" & parrot.wings)
        Console.WriteLine("Weight of parrot=" & parrot.wt)
        Console.WriteLine("Color of parrot=" & parrot.color)
    End Sub

End Module
