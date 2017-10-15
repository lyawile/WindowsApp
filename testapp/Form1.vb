Public Class Form1
    Private Sub form1_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.Text = "Enter the first number"
        TextBox2.Text = "Enter the second number"
        TextBox3.Text = "Enter the third number"

    End Sub
    Private Sub form1_test()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.Clear()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        TextBox2.Clear()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        TextBox3.Clear()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "Enter the first Number"
        End If
    End Sub
End Class
