Module Module1

    Sub Main()
        Dim eno As Integer
        Dim ename As String
        Dim esal As Double
        Dim egrade As String
        Dim ews As Boolean
        System.Console.WriteLine("Enter eno:")
        eno = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Enter ename:")
        ename = Console.ReadLine()
        System.Console.WriteLine("Enter esal:")
        esal = Convert.ToDouble(Console.ReadLine())
        System.Console.WriteLine("Enter egrade:")
        egrade = Console.ReadLine()
        System.Console.WriteLine("Enter ews:")
        ews = Console.ReadLine()
        System.Console.WriteLine("=================================")
        System.Console.WriteLine("Employee data:")
        System.Console.WriteLine("=================================")
        System.Console.WriteLine("Number=" & eno)
        System.Console.WriteLine("Name=" & ename)
        System.Console.WriteLine("Salary=" & esal)
        System.Console.WriteLine("Grade=" & egrade)
        System.Console.WriteLine("Working status=" & ews)
        System.Console.WriteLine("=================================")
    End Sub

End Module
