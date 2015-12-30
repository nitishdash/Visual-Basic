Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("My first VS2015 app! - Nitish Dash ♥")
        Me.exit()
        Dim lastTime, nextTime As Integer = 3
    End Sub

    Private Sub [exit]()
        Throw New NotImplementedException()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Integer = Integer.Parse(TextBox1.Text())
        Dim num2 As Integer = Integer.Parse(TextBox2.Text())
        Dim sum As Integer = num1 + num2
        TextBox3.Text = sum.ToString
        TextBox3.BackColor = Color.BurlyWood


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
