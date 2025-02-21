Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Label1.Text = "breadth"
        Label2.Text = "Height"
        Label3.Text = ""
        Button1.Text = "Calculate"
        Button2.Text = "Exit"
    End Sub
    Dim b, h, a As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b = Convert.ToInt32(TextBox1.Text)
        h = Convert.ToInt32(TextBox2.Text)
        a = 1 / 2 * (b * h)
        Label3.Text = Convert.ToString(a)
    End Sub
End Class
