Public Class Form1
    Dim counter As Integer = 0
    Dim X, Y As Integer
    Dim canvas As Graphics
    Dim V, dy, dx, vy, vx, a, ax, ay, dir, tempdir As Double
    Dim posx As Integer = 5
    Dim posy As Integer = 5
    Dim car As Rectangle
    Dim waypoints = New List(Of Rectangle)
    Dim decelerate As Boolean = False
    Dim Vmax As Integer = 105
    Dim cross As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canvas = PictureBox1.CreateGraphics()
        SpdBox.Text = "1"
        TorqBox.Text = "1"
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove
        X = e.X
        Y = e.Y
        Coordinates.Text = (X & ", " & Y)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim waypoint = New Rectangle(X, Y, 10, 10)
        canvas.DrawRectangle(Pens.Black, X, Y, 10, 10)
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
            ' a = 0.1
            dir = 0
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
        TorqBox.Text = "1"
        waypoints.clear()
        posx = 5
        posy = 5
        counter = 0
        dir = 0
        tempdir = 0
        canvas.DrawEllipse(Pens.Blue, posx + 5, posy + 5, 10, 10)
        PictureBox1.Refresh()
        decelerate = False
    End Sub
    Private Sub moveCar_Tick(sender As Object, e As EventArgs) Handles moveCar.Tick
        If counter < waypoints.Count Then
            Dim dirwaypoint As Double
            Dim y2 As Integer = waypoints(counter).Y
            Dim x2 As Integer = waypoints(counter).X
            dy = y2 - posy
            dx = x2 - posx
            dirwaypoint = Math.Atan(dy / dx)
            tempdir = dir
            dir = dir + TorqBox.Text
            If dir > dirwaypoint And tempdir < dir Then
                dir = dirwaypoint
            ElseIf dir < dirwaypoint And tempdir > dir Then
                dir = dirwaypoint
            End If
            '            If V < Vmax Then
            '          V = V + a
            '      End If
            vx = V * Math.Cos(dir)
            vy = V * Math.Sin(dir)
            canvas.DrawEllipse(Pens.White, posx, posy, 20, 20)
            posx = posx + vx
            posy = posy + vy
            car.Location = New Point(posx, posy)
            canvas.DrawEllipse(Pens.Blue, posx, posy, 20, 20)
            If posx = x2 AndAlso posy = y2 Then
                counter = counter + 1
                dir = 0
            End If
        Else
            moveCar.Enabled = False
        End If
    End Sub

    Function dirCheck(dir As Double, dirwaypoint As Double)
        If dir > dirwaypoint Then
            cross = True
        ElseIf dir < dirwaypoint Then
            cross = False
        End If
    End Function
End Class