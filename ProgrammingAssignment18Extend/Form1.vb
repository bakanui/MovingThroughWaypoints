Public Class Form1
    Dim counter As Integer = 0
    Dim X, Y As Integer
    Dim canvas As Graphics
    Dim V, dy, dx, vy, vx, a, dir, prevdir As Double
    Dim posx As Integer = 5
    Dim posy As Integer = 5
    Dim waypoints = New List(Of Rectangle)
    Dim Vmax As Integer = 50
    Dim firstTime As Boolean = True
    Dim accelerate As Boolean = True
    Dim dirwaypoint As Double
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
        If firstTime = True Then
            Dim waypoint = New Rectangle(X, Y, 10, 10)
            canvas.DrawRectangle(Pens.Black, X + 5, Y + 5, 10, 10)
            waypoints.Add(waypoint)
        Else
            MessageBox.Show("Please reset the program first using the Reset Button.", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.DrawEllipse(Pens.Blue, posx, posy, 20, 20)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StrtBtn.Click
        If SpdBox.Text = "" Then
            MessageBox.Show("The speed box cannot be left empty!", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf SpdBox.Text < 0 Or SpdBox.Text > 100 Then
            MessageBox.Show("The car can only go from 1-50.", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf SpdBox.Text = 0 Then
            MessageBox.Show("You can't expect a car to move with a speed of 0.", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf waypoints.Count = 0 Then
            MessageBox.Show("The car needs waypoints to pass through. Please input the waypoints.", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TorqBox.Text = "" Then
            MessageBox.Show("The torque box cannot be left empty!", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            V = SpdBox.Text
            a = 0.1
            dir = 0
            moveCar.Enabled = True
            firstTime = False
            accelerate = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles StpBtn.Click
        accelerate = False
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
        prevdir = 0
        canvas.DrawEllipse(Pens.Blue, posx + 5, posy + 5, 10, 10)
        PictureBox1.Refresh()
        firstTime = True
    End Sub
    Private Sub moveCar_Tick(sender As Object, e As EventArgs) Handles moveCar.Tick
        If counter < waypoints.Count Then
            dy = waypoints(counter).Y - posy
            dx = waypoints(counter).X - posx
            Dim dist As Integer = Math.Sqrt(dy ^ 2 + dx ^ 2)
            Dim radians = Math.Atan2(dy, dx)
            dirwaypoint = radians * (180 / Math.PI)
            Dim z As Double = (vx * dy) - (vy * dx)
            If z > 0 Then
                dir = dir + TorqBox.Text
            ElseIf z < 0 Then
                dir = dir - TorqBox.Text
            End If
            If V + 69 > dist AndAlso counter = waypoints.Count - 1 Then
                accelerate = False
            End If
            acceldecel(accelerate)
            vx = V * Math.Cos(dir * (Math.PI / 180))
            vy = V * Math.Sin(dir * (Math.PI / 180))
            canvas.DrawEllipse(Pens.White, posx, posy, 20, 20)
            posx = posx + vx
            posy = posy + vy
            canvas.DrawEllipse(Pens.Blue, posx, posy, 20, 20)
            If V > dist Then
                canvas.DrawRectangle(Pens.White, waypoints(counter).X + 5, waypoints(counter).Y + 5, 10, 10)
                counter = counter + 1
            End If
        Else
            moveCar.Enabled = False
        End If
    End Sub
    Function acceldecel(accel As Boolean)
        If accel = True Then
            If V < Vmax Then
                V = V + a
            End If
        ElseIf accel = False Then
            V = V - a
            If V < 0 Then
                V = 0
                moveCar.Enabled = False
            End If
        End If
    End Function
End Class