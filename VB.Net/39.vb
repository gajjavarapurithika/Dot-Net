Class Bird
    Sub fly()
        Console.WriteLine("They fly to fulfill natural activites")
    End Sub
End Class
Module Module1

    Sub Main()
        Dim parrot = New Bird()
        parrot.fly()
        Dim pigeon As New Bird()
        pigeon.fly()
    End Sub

End Module
