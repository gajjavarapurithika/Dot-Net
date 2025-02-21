Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.BackColor = Color.Blue
        Me.Text="Demo App"
        Label1.Text = "Hello World"
        Label1.ForeColor = Color.Red
        Label1.Font = New Font("Arial", 20, FontStyle.Bold)
        Label1.BackColor = Color.Yellow
    End Sub
End Class
