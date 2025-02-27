Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Label1.Text = "Hobbies"
        CheckBox1.Text = "Reading"
        CheckBox2.Text = "Writing"
        CheckBox3.Text = "Drawing"
        Label2.Text = "Gender"
        RadioButton1.Text = "Male"
        RadioButton2.Text = "Female"
        RadioButton3.Text = "Other"
    End Sub

  
End Class
