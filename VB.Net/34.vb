Imports System.Net.Security

Module Module1

    Sub Main()
        Dim x As Integer
        System.Console.WriteLine("-----------------------")
        System.Console.WriteLine("Menu")
        System.Console.WriteLine("-----------------------")
        System.Console.WriteLine("1.Pen")
        System.Console.WriteLine("2.Book")
        System.Console.WriteLine("3.Eraser")
        System.Console.WriteLine("-----------------------")
        System.Console.WriteLine("Enter your choice")
        x = Convert.ToInt32(Console.ReadLine())
        Select Case x
            Case 1
                System.Console.WriteLine("You have selected pen")
            Case 2
                System.Console.WriteLine("You have selected book")
            Case 3
                System.Console.WriteLine("You have selected eraser")
            Case Else
                System.Console.WriteLine("Invalid choice")
        End Select

    End Sub

End Module
