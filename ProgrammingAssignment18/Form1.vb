Public Class Form1
    Dim X As Integer
    Dim Y As Integer
    Dim canvas As Graphics
    Dim waypoints = New List(Of Rectangle)
    Dim car = New Rectangle(5, 5, 20, 20)
    Dim carPositions = New List(Of Point)
    Dim waypointCounter As Integer = 0
    Dim carPosCounter As Integer = 0
    Dim speed As Integer
    Dim decelerate As Boolean = False
    Dim firstTime As Boolean = True
    Dim decCounter = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canvas = PictureBox1.CreateGraphics()
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove
        X = e.X - 5
        Y = e.Y - 5
        Coordinates.Text = (X & ", " & Y)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim waypoint = New Rectangle(X, Y, 10, 10)
        canvas.DrawRectangle(Pens.Black, X, Y, 10, 10)
        waypoints.Add(waypoint)
    End Sub
    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.DrawEllipse(Pens.Blue, car)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StrtBtn.Click
        decelerate = False
        If SpdBox.Text = "" Then
            MessageBox.Show("You cannot leave the speed box empty!", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf SpdBox.Text < 0 Or SpdBox.Text > 100 Then
            MessageBox.Show("The car can only go from 1-100.", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf SpdBox.Text = 0 Then
            MessageBox.Show("You can't expect a car to move with a speed of 0.", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If firstTime = True Then
                carMovement()
                speed = 105 - SpdBox.Text
                moveCar.Interval = speed
                moveCar.Enabled = True
            Else
                speed = 105 - SpdBox.Text
                moveCar.Interval = speed
                moveCar.Enabled = True
            End If
        End If
    End Sub

    Private Sub moveCar_Tick(sender As Object, e As EventArgs) Handles moveCar.Tick
        canvas.DrawEllipse(Pens.White, car)
        If decelerate = False Then
            decCounter = 0
            If speed > 5 Then
                speed = speed - 5
                moveCar.Interval = speed
            End If
            If carPosCounter < carPositions.Count Then
                car.Location = carPositions(carPosCounter)
                carPosCounter = carPosCounter + 1
            Else
                moveCar.Enabled = False
            End If
        Else
            If decCounter < 5 Then
                car.Location = carPositions(carPosCounter)
                carPosCounter = carPosCounter + 1
                If speed < 105 Then
                    speed = speed + 5
                    moveCar.Interval = speed
                End If
            End If
            If speed >= 105 Then
                moveCar.Enabled = False
            End If
        End If
        canvas.DrawEllipse(Pens.Blue, car)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles StpBtn.Click
        decelerate = True
    End Sub

    Function abs(n As Integer) As Integer
        If n < 0 Then
            n = n * -1
        Else 'n >= 0
            n = n * 1
        End If
        Return n
    End Function

    Sub carMovement()
        Dim dx, dy, d, dr, dur, x, y, NextPosX, NextPosY As Integer
        Dim p As Point
        ' While x <> rectList(counter3).X
        'init
        y = car.Location.Y
        x = car.Location.X
        NextPosX = x
        NextPosY = y
        'f.e
        While waypointCounter < waypoints.Count
            dx = waypoints(waypointCounter).X - NextPosX
            dy = waypoints(waypointCounter).Y - NextPosY
            If NextPosX <= waypoints(waypointCounter).X And NextPosY <= waypoints(waypointCounter).Y - 5 Then
                If dx >= dy Then
                    dr = 2 * dy
                    dur = 2 * (dy - dx)
                    d = 2 * dy - dx
                Else 'dy < dx
                    dr = 2 * dx
                    dur = 2 * (dx - dy)
                    d = 2 * dx - dy
                End If
            ElseIf NextPosX > waypoints(waypointCounter).X And NextPosY <= waypoints(waypointCounter).Y - 5 Then
                If abs(dx) >= abs(dy) Then
                    dr = -2 * dy
                    dur = -2 * (dx + dy)
                    d = -dx - 2 * dy
                Else 'dy < dx
                    dr = -2 * dx
                    dur = -2 * (dy + dx)
                    d = -dy - 2 * dx
                End If
            ElseIf NextPosX <= waypoints(waypointCounter).X And NextPosY > waypoints(waypointCounter).Y - 5 Then
                If abs(dx) >= abs(dy) Then
                    dr = 2 * dy
                    dur = 2 * (dy + dx)
                    d = 2 * dy + dx
                Else 'dy < dx
                    dr = 2 * dx
                    dur = 2 * (dx + dy)
                    d = 2 * dx + dy
                End If
            ElseIf NextPosX > waypoints(waypointCounter).X And NextPosY > waypoints(waypointCounter).Y - 5 Then
                If abs(dx) >= abs(dy) Then
                    dr = -2 * dy
                    dur = -2 * (dy - dx)
                    d = dx - 2 * dy
                Else 'dy < dx
                    dr = -2 * dx
                    dur = -2 * (dx - dy)
                    d = -dx - 2 * dy
                End If
            End If
            dx = abs(dx)
            dy = abs(dy)
            'dim point1 as new point(x1 * 20, y1 * 20)
            If NextPosX <= waypoints(waypointCounter).X - 5 And NextPosY <= waypoints(waypointCounter).Y - 5 Then
                If dx >= dy Then
                    While x < waypoints(waypointCounter).X - 5
                        carPositions.Add(New Point(x, y))
                        If d <= 0 Then
                            'd <= 0 choose r
                            d = d + dr
                        Else 'd>0, choose ur
                            d = d + dur
                            y = y + 1
                        End If
                        x += 1
                    End While
                Else 'dy < dx
                    While y < waypoints(waypointCounter).Y - 5
                        carPositions.Add(New Point(x, y))
                        If d <= 0 Then
                            'd <= 0 choose r
                            d = d + dr
                        Else 'd>0, choose ur
                            d = d + dur
                            x = x + 1
                        End If
                        y += 1
                    End While
                End If
            ElseIf NextPosX > waypoints(waypointCounter).X - 5 And NextPosY <= waypoints(waypointCounter).Y - 5 Then
                If dx >= dy Then
                    While x > waypoints(waypointCounter).X - 5
                        carPositions.Add(New Point(x, y))
                        If d > 0 Then
                            'd <= 0 choose r
                            d = d + dr
                        Else 'd>0, choose ur
                            d = d + dur
                            y = y + 1
                        End If
                        x -= 1
                    End While
                Else 'dy < dx
                    While y < waypoints(waypointCounter).Y
                        carPositions.Add(New Point(x, y))
                        If d <= 0 Then
                            'd <= 0 choose r
                            d = d + dr
                        Else 'd>0, choose ur
                            d = d + dur
                            x = x - 1
                        End If
                        y += 1
                    End While
                End If
            ElseIf NextPosX <= waypoints(waypointCounter).X - 5 And NextPosY > waypoints(waypointCounter).Y Then
                If dx >= dy Then
                    While x < waypoints(waypointCounter).X - 5
                        carPositions.Add(New Point(x, y))
                        If d > 0 Then
                            'd <= 0 choose r
                            d = d + dr
                        Else 'd>0, choose ur
                            d = d + dur
                            y = y - 1
                        End If
                        x += 1
                    End While
                Else 'dy > dx
                    While y > waypoints(waypointCounter).Y
                        carPositions.Add(New Point(x, y))
                        If d <= 0 Then
                            'd <= 0 choose r
                            d = d + dr
                        Else 'd>0, choose ur
                            d = d + dur
                            x = x + 1
                        End If
                        y -= 1
                    End While
                End If
            ElseIf NextPosX > waypoints(waypointCounter).X - 5 And NextPosY > waypoints(waypointCounter).Y Then
                If dx >= dy Then
                    While x > waypoints(waypointCounter).X - 5
                        carPositions.Add(New Point(x, y))
                        If d <= 0 Then
                            'd <= 0 choose r
                            d = d + dr
                        Else 'd>0, choose ur
                            d = d + dur
                            y = y - 1
                        End If
                        x -= 1
                    End While
                Else 'dy > dx
                    While y > waypoints(waypointCounter).Y
                        carPositions.Add(New Point(x, y))
                        If d <= 0 Then
                            'd <= 0 choose r
                            d = d + dr
                        Else 'd>0, choose ur
                            d = d + dur
                            x = x - 1
                        End If
                        y -= 1
                    End While
                End If
            End If
            waypointCounter += 1
            NextPosY = y
            NextPosX = x
        End While
    End Sub

End Class
