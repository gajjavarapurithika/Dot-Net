Class Mycalci
    Public a As Integer
    Public b As Integer
    Public c As Integer
    Public Sub New()
        a = 10
        b = 10
        c = 5
    End Sub
    Public Sub putvalsone()
        System.Console.WriteLine("a=" & a & "b=" & b & "c=" & c)
    End Sub
    Public Sub New(x As Integer, y As Integer)
        a = x
        b = y
    End Sub
    Public Sub putvalstwo()
        System.Console.WriteLine("a=" & a & " b=" & b)
    End Sub
    Public Sub New(x As Integer, y As Integer, z As Integer)
        a = x
        b = y
        c = z
    End Sub
    Public Sub putvalsthree()
        System.Console.WriteLine("a=" & a & "b=" & b & "c=" & c)
    End Sub
End Class
Module Module1

    Sub Main()
        Dim mc1 = New Mycalci()
        mc1.putvalsone()
        Dim mc2 = New Mycalci(10, 20)
        mc2.putvalstwo()
        Dim mc3 = New Mycalci(10, 20, 30)
        mc3.putvalsthree()
    End Sub

End Module
