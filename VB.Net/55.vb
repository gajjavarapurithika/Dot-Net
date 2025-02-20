Module Module1
    Class Test
        Public x As Integer
        Property y As Integer
            Get
                Return x
            End Get
            Set(t As Integer)
                x = t
            End Set
        End Property
    End Class
    Sub Main()
        Dim T As New Test()
        T.y = 10
        Console.WriteLine(T.x)
    End Sub

End Module
