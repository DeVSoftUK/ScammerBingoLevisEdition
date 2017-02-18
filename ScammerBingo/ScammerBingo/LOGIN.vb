Public Class LOGIN
    Private Sub Login()
        If TextBox1.Text = "Lewis" Then
            If TextBox2.Text = "technology" Then
                Form2.Visible = True
                Me.Visible = False
            End If
        Else
            MsgBox("Invaild Name Or Password!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        About.Visible = True
    End Sub
End Class
