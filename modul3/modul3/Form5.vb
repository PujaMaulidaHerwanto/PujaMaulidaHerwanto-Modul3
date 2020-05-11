Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = " " Then
            MsgBox("Maaf Makanan Harus Diisi")
        ElseIf ListBox1.Items.Contains(TextBox1.Text) Then
            MsgBox("Maaf makanan yang anda masukan sudah tersedia")
        Else
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Text = " "

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItem = " " Then
            MsgBox("Pilih Makanan Yang ingin anda hapus")
        Else
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class