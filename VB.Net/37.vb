Module Module1
    Structure Emp
        Dim eno As Integer
        Dim ename As String
        Dim esal As Double
    End Structure
    Sub Main()
        Dim e As New Emp()
        e.eno = 101
        e.ename = "Anil"
        e.esal = 45.95
        Console.WriteLine("Employee number=" & e.eno)
        Console.WriteLine("Employee name=" & e.ename)
        Console.WriteLine("Employee salary=" & e.esal)
    End Sub

End Module
