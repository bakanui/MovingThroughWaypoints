Public Class Form1
    Dim counter As Integer = 0
    Dim X, Y As Integer
    Dim canvas As Graphics
    Dim V, dy, dx, vy, vx, a, ax, ay, dir As Double
    Dim posx As Integer = 5
    Dim posy As Integer = 5
    Dim waypoints = New List(Of Rectangle)
    Dim decelerate As Boolean = False
    Dim Vmax As Integer = 105
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
        e.Graphics.DrawEllipse(Pens.Blue, posx, posy, 20, 20)
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
            V = 1
            a = 1
            moveCar.Interval = 101 - SpdBox.Text
            moveCar.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles StpBtn.Click
        moveCar.Enabled = False
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
        If counter < waypoints.Count Then
            dy = waypoints(counter).Y - posy
            dx = waypoints(counter).X - posx
            dir = Math.Atan(dy / dx)
            dir = dir + TorqBox.Text
            If V < Vmax Then
                V = V + a
            End If
            Vx = V * Math.Cos(dir)
            Vy = V * Math.Sin(dir)
            canvas.DrawEllipse(Pens.White, posx, posy, 20, 20)
            posx = posx + Vx
            posy = posy + Vy
            canvas.DrawEllipse(Pens.Blue, posx, posy, 20, 20)
            If posx = waypoints(counter).X AndAlso posy = waypoints(counter).Y Then
                moveCar.Enabled = False
            End If
        Else
            moveCar.Enabled = False
        End If
    End Sub
End Class