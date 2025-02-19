Module Module1
    Class Bank
        Public Overridable Function itrate() As Integer
            Return 0
        End Function
    End Class
    Class SBI
        Inherits Bank
        Public Overrides Function itrate() As Integer
            Return 7
        End Function
    End Class
    Class HDFC
        Inherits Bank
        Public Overrides Function itrate() As Integer
            Return 8
        End Function
    End Class
    Class ICICI
        Inherits Bank
        Public Overrides Function itrate() As Integer
            Return 9
        End Function
    End Class
    Sub Main()
        Dim s As Bank = New SBI()
        Dim h As Bank = New HDFC()
        Dim i As Bank = New ICICI()
        System.Console.WriteLine("SBI rate of interest:" & s.itrate())
        System.Console.WriteLine("HDFC rate of interest:" & h.itrate())
        System.Console.WriteLine("ICICI rate of interest:" & i.itrate())
    End Sub

End Module
