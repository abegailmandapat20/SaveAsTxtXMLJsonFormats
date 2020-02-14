Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox3.TextChanged, TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TxtBtn_Click(sender As Object, e As EventArgs) Handles TxtBtn.Click
        My.Computer.FileSystem.WriteAllText("C:\Sample\Textfile1.txt", "" & "Name: " + TextBox1.Text + Environment.NewLine & "Age: " + TextBox2.Text + Environment.NewLine & "Address: " + TextBox3.Text + Environment.NewLine, True)

    End Sub

    Private Sub XMLBtn_Click(sender As Object, e As EventArgs) Handles XMLBtn.Click
        My.Computer.FileSystem.WriteAllText("C:\Sample\Textfile1.xml", "" & "Name: " + TextBox1.Text + Environment.NewLine & "Age: " + TextBox2.Text + Environment.NewLine & "Address: " + TextBox3.Text, True)
    End Sub

    Private Sub JsonBtn_Click(sender As Object, e As EventArgs) Handles JsonBtn.Click
        My.Computer.FileSystem.WriteAllText("C:\Sample\Textfile1.json", "" & "Name: " + TextBox1.Text + Environment.NewLine & "Age: " + TextBox2.Text + Environment.NewLine & "Address: " + TextBox3.Text, True)
    End Sub
End Class
