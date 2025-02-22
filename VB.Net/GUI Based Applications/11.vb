Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("BOOK")
        ListBox1.Items.Add("PEN")
        ListBox1.Items.Add("PENCIL")
        ListBox1.Items.Add("RUBBER")
        ListBox1.Items.Add("SHARPENER")
        Label1.Text = " "
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = ListBox1.SelectedItem
    End Sub
End Class
