Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowIcon = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox1.Text = 0 Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = 0 Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text = TextBox1.Text + "1"
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text = 0 Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text = TextBox1.Text + "2"
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = 0 Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text = TextBox1.Text + "3"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox1.Text = 0 Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text = TextBox1.Text + "4"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TextBox1.Text = 0 Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text = TextBox1.Text + "5"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text = 0 Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text = TextBox1.Text + "6"
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox1.Text = 0 Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text = TextBox1.Text + "7"
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox1.Text = 0 Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text = TextBox1.Text + "8"
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox1.Text = 0 Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text = TextBox1.Text + "9"
        End If
    End Sub

End Class
