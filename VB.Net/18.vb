Module Module1

    Sub Main()
        Dim sno As Integer
        Dim sname As String
        Dim sclass As Integer
        Dim ssec As String
        Dim m1, m2, m3, m4, m5, m6, tot As Integer
        Dim avg As Double
        System.Console.WriteLine("Enter sno:")
        sno = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Enter sname:")
        sname = Console.ReadLine()
        System.Console.WriteLine("Enter sclass:")
        sclass = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Enter m1:")
        m1 = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Enter m2:")
        m2 = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Enter m3:")
        m3 = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Enter m4:")
        m4 = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Enter m5:")
        m5 = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Enter m6:")
        m6 = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("------------------------------")
        System.Console.WriteLine("Student Data:")
        System.Console.WriteLine("------------------------------")
        System.Console.WriteLine("Number=" & sno)
        System.Console.WriteLine("Name=" & sname)
        System.Console.WriteLine("Class=" & sclass)
        System.Console.WriteLine("Section=" & ssec)
        System.Console.WriteLine("M1=" & m1)
        System.Console.WriteLine("M2=" & m2)
        System.Console.WriteLine("M3=" & m3)
        System.Console.WriteLine("M4=" & m4)
        System.Console.WriteLine("M5=" & m5)
        System.Console.WriteLine("M6=" & m6)
        tot = m1 + m2 + m3 + m4 + m5 + m6
        System.Console.WriteLine("total=" & tot)
        avg = tot / 6
        System.Console.WriteLine("avg=" & avg)
        System.Console.WriteLine("------------------------------")
    End Sub

End Module
