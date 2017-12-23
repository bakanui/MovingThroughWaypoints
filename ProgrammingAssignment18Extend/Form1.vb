Public Class Form1
    Dim X, Y As Integer
    Dim canvas As Graphics
    Dim V, ax, ay, dir As Integer
    Dim posx As Integer = 5
    Dim posy As Integer = 5
    Dim waypoints = New List(Of Rectangle)
    Dim car = New Rectangle(posx, posy, 20, 20)
    Dim speed As Integer
    Dim decelerate As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canvas = PictureBox1.CreateGraphics()
        SpdBox.Text = "1"
        TorqBox.Text = "0"
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove
        X = e.X
        Y = e.Y
        Coordinates.Text = (X & ", " & Y)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim waypoint = New Rectangle(X, Y, 10, 10)
        canvas.DrawRectangle(Pens.Black, X - 5, Y - 5, 10, 10)
        waypoints.Add(waypoint)
    End Sub
    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.DrawEllipse(Pens.Blue, car)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StrtBtn.Click
        decelerate = False
        If SpdBox.Text = "" Then
            MessageBox.Show("The speed box cannot be left empty!", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf SpdBox.Text < 0 Or SpdBox.Text > 100 Then
            MessageBox.Show("The car can only go from 1-100.", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf SpdBox.Text = 0 Then
            MessageBox.Show("You can't expect a car to move with a speed of 0.", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf waypoints.Count = 0 Then
            MessageBox.Show("The car needs waypoints to pass through. Please input the waypoints.", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TorqBox.Text = "" Then
            MessageBox.Show("The speed box cannot be left empty!", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            speed = 101 - SpdBox.Text
            moveCar.Interval = speed
            moveCar.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles StpBtn.Click
        decelerate = True
    End Sub
    Private Sub RstBtn_Click(sender As Object, e As EventArgs) Handles RstBtn.Click
        moveCar.Enabled = False
        SpdBox.Text = "1"
        TorqBox.Text = "0"
        waypoints.clear()
        PictureBox1.Refresh()
        decelerate = False
    End Sub
    Private Sub moveCar_Tick(sender As Object, e As EventArgs) Handles moveCar.Tick
        Dim counter As Integer = 0
        dir = (waypoints(counter).y - posy) / (waypoints(counter).x - posx)
        Dim Vx As Integer = V * Math.Cos(dir)
        Dim Vy As Integer = V * Math.Sin(dir)
        canvas.DrawEllipse(Pens.White, car)

        canvas.DrawEllipse(Pens.Blue, car)
    End Sub
End Class
