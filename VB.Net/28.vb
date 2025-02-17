Module Module1
    Sub Main()
        Dim age As Integer

        ' Input the age of the user
        Console.WriteLine("Enter your age: ")
        age = Convert.ToInt32(Console.ReadLine())

        ' Check voter eligibility
        If age >= 18 Then
            Console.WriteLine("You are eligible to vote.")
        Else
            Console.WriteLine("You are not eligible to vote.")
        End If
    End Sub
End Module
