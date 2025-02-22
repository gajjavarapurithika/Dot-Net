Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("RED")
        ComboBox1.Items.Add("GREEN")
        ComboBox1.Items.Add("BLUE")
        ComboBox1.Items.Add("YELLOW")
        ComboBox1.Items.Add("CYAN")
        ComboBox1.Items.Add("MAGENTA")
        ComboBox1.Items.Add("CRYPTON")
        ComboBox1.Text = "Select a color"
        Label1.Text = " "
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Text = "You selected " & ComboBox1.Text
    End Sub
End Class
