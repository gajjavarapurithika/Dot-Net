Module Module1

    Sub Main()
        Dim x As Integer
        System.Console.WriteLine("Entr a:")
        x = Convert.ToInt32(Console.ReadLine())
        If (x Mod 2 = 0) Then
            System.Console.WriteLine(x & "Number is even")
        Else
            System.Console.WriteLine(x & "Number is odd")
        End If
    End Sub

End Module
