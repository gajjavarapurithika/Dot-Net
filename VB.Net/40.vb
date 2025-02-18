Class Bird
    Sub fly()
        Console.WriteLine("They fly to fulfill natural activites")
    End Sub
    Sub buildnest()
        Console.WriteLine("They build nest to live")
    End Sub
End Class
Module Module1

    Sub Main()
        Dim parrot = New Bird()
        parrot.fly()
        parrot.buildnest()
        Console.WriteLine("----------------------")
        Dim pigeon As New Bird()
        pigeon.fly()
        pigeon.buildnest()
    End Sub

End Module
