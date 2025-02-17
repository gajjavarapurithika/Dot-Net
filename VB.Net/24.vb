Imports System.Diagnostics.Eventing.Reader

Module Module1

    Sub Main()
        Dim x As Integer
        System.Console.WriteLine("Enter a number:")
        x = Convert.ToInt32(Console.ReadLine())
        If (x >= 0) Then
            If (x = 0) Then
                System.Console.WriteLine("Zero")
            Else
                System.Console.WriteLine("Positive")
            End If
        Else
            System.Console.WriteLine("Negative")
        End If
    End Sub

End Module
