Public Class Form11

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox15.Text = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + (TextBox6.Text)
        TextBox2.Text = Val(TextBox1.Text) - (Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text))
        If TextBox15.Text <> 0 Then
            Panel1.BackColor = Color.Green
        Else
            Panel1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox16.Text = Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text)
        TextBox2.Text = Val(TextBox1.Text) - (Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text))
        If TextBox16.Text <> 0 Then
            Panel2.BackColor = Color.Green
        Else
            Panel2.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox17.Text = Val(TextBox11.Text) + Val(TextBox12.Text) + Val(TextBox13.Text) + Val(TextBox14.Text)
        TextBox2.Text = (Val(TextBox1.Text - (Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text))))
        If TextBox17.Text <> 0 Then
            Panel3.BackColor = Color.Green
        Else
            Panel3.BackColor = Color.Red

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged

    End Sub
End Class