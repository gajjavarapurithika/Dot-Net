Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Text = "CASH"
        RadioButton2.Text = "CREDIT CARD"
        RadioButton3.Text = "DEBIT CARD"
        Label1.Text = ""
        Button1.Text = "CHOICE"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = True) Then
            Label1.Text = "You have selected CASH"
        End If
        If (RadioButton2.Checked = True) Then
            Label1.Text = "You have selected CREDIT CARD"
        End If
        If (RadioButton3.Checked = True) Then
            Label1.Text = "You have selected DEBIT CARD"
        End If
    End Sub
End Class
