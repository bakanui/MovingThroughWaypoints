Public Class Form1
    Dim X As Integer
    Dim Y As Integer
    Dim canvas As Graphics
    Dim pen As Pen = New Pen(Color.Black)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canvas = PictureBox1.CreateGraphics()
        canvas.DrawRectangle(pen, 25, 25, 25, 25)
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove
        Coordinate.Text = (e.X & ", " & e.Y)
        X = e.X
        Y = e.Y
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        canvas.DrawRectangle(pen, X - 5, Y - 5, 10, 10)
    End Sub
End Class
