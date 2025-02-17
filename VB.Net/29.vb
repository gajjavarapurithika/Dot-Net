Module Module1
    Sub Main()
        Dim marks As Integer
        Dim grade As String

        ' Input the marks of the student
        Console.WriteLine("Enter the marks obtained by the student: ")
        marks = Convert.ToInt32(Console.ReadLine())

        ' Determine the grade based on the marks
        If marks >= 90 Then
            grade = "A"
        ElseIf marks >= 80 Then
            grade = "B"
        ElseIf marks >= 70 Then
            grade = "C"
        ElseIf marks >= 60 Then
            grade = "D"
        Else
            grade = "F"
        End If

        ' Output the grade
        Console.WriteLine("The grade for the marks " & marks & " is: " & grade)
    End Sub
End Module
