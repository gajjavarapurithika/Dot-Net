Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Text = "Button demo"
        Me.BackColor = Color.LightGray
        Button1.Text = "RED"
        Button2.Text = "GREEN"
        Button3.Text = "BLUE"
        Button4.Text = "QUIT"
        Label1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackColor = Color.Red
        Label1.BackColor = Color.Red
        Label1.Text = "Red selected"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BackColor = Color.Green
        Label1.BackColor = Color.Green
        Label1.Text = "Green selected"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.BackColor = Color.Blue
        Label1.BackColor = Color.Blue
        Label1.Text = "Blue selected"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
