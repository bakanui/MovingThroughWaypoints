Imports System.Drawing.Imaging
Imports System.IO

Public Class Form1
    Dim rectList As New List(Of Rectangle)
    Dim counter As Integer = 0
    Dim counter2 As Integer = 0
    Dim counter3 As Integer = 0
    Public bmp1 As New Bitmap(707, 284, PixelFormat.Format32bppArgb)
    Dim klik As Rectangle = New Rectangle(0, 0, 0, 0)
    Dim pX, pY As Integer
    Dim mycar As New Rectangle

    Function abs(n As Integer) As Integer
        If n < 0 Then
            n = n * -1
        Else 'n >= 0
            n = n * 1
        End If
        Return n
    End Function

    Structure tline
        Dim x1 As Integer
        Dim y1 As Integer
        Dim x2 As Integer
        Dim y2 As Integer
        Dim thickness As Integer
        Dim col As Color
    End Structure

    Sub createstraightline(l As tline, pict As PictureBox)
        Dim gbmp As graphics = graphics.fromimage(bmp1)
        Dim mybrush As New solidbrush(l.col)
        Dim dx, dy, d, dr, dur, x, y As Integer

        ' While x <> rectList(counter3).X
        'init
        dx = l.x2 - l.x1
        dy = l.y2 - l.y1
        l.col = Color.Black
        'f.e
        If l.x1 <= l.x2 And l.y1 <= l.y2 Then
            If dx >= dy Then
                dr = 2 * dy
                dur = 2 * (dy - dx)
                d = 2 * dy - dx
            Else 'dy < dx
                dr = 2 * dx
                dur = 2 * (dx - dy)
                d = 2 * dx - dy
            End If
        ElseIf l.x1 > l.x2 And l.y1 <= l.y2 Then
            If abs(dx) >= abs(dy) Then
                dr = -2 * dy
                dur = -2 * (dx + dy)
                d = -dx - 2 * dy
            Else 'dy < dx
                dr = -2 * dx
                dur = -2 * (dy + dx)
                d = -dy - 2 * dx
            End If
        ElseIf l.x1 <= l.x2 And l.y1 > l.y2 Then
            If abs(dx) >= abs(dy) Then
                dr = 2 * dy
                dur = 2 * (dy + dx)
                d = 2 * dy + dx
            Else 'dy < dx
                dr = 2 * dx
                dur = 2 * (dx + dy)
                d = 2 * dx + dy
            End If
        ElseIf l.x1 > l.x2 And l.y1 > l.y2 Then
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
        y = l.y1
        x = l.x1
        dx = abs(dx)
        dy = abs(dy)
        'dim point1 as new point(x1 * 20, y1 * 20)
        If l.x1 <= l.x2 And l.y1 <= l.y2 Then
            If dx >= dy Then
                While x < l.x2
                    bmp1 = New Bitmap(707, 284, PixelFormat.Format32bppArgb)
                    gbmp = Graphics.FromImage(bmp1)
                    gbmp.FillEllipse(mybrush, x, y, l.thickness, l.thickness)
                    'dim point2 as new point(x * 20, y * 20)
                    'e.graphics.drawline(pens.black, point1, point2)
                    'point1 = new point(x * 20, y * 20)
                    If d <= 0 Then
                        'd <= 0 choose r
                        d = d + dr
                    Else 'd>0, choose ur
                        d = d + dur
                        y = y + 1
                    End If
                    'gbmp.dispose()
                    While counter2 <> counter
                        Dim a1 As Rectangle
                        Dim q, w As Integer
                        a1 = rectList(counter2)
                        q = a1.X
                        w = a1.Y
                        gbmp.FillRectangle(mybrush, q, w, 8, 8)
                        counter2 += 1
                    End While
                    counter2 = 0
                    pict.Image = bmp1
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(10)
                    x += 1
                End While
            Else 'dy < dx
                While y < l.y2
                    gbmp.FillEllipse(mybrush, x, y, l.thickness, l.thickness)
                    'dim point2 as new point(x * 20, y * 20)
                    'e.graphics.drawline(pens.black, point1, point2)
                    'point1 = new point(x * 20, y * 20)
                    If d <= 0 Then
                        'd <= 0 choose r
                        d = d + dr
                    Else 'd>0, choose ur
                        d = d + dur
                        x = x + 1
                    End If
                    While counter2 <> counter
                        Dim a1 As Rectangle
                        Dim q, w As Integer
                        a1 = rectList(counter2)
                        q = a1.X
                        w = a1.Y
                        gbmp.FillRectangle(mybrush, q, w, 8, 8)
                        counter2 += 1
                    End While
                    counter2 = 0
                    pict.Image = bmp1
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(10)
                    'gbmp.dispose()
                    y += 1
                End While
            End If
        ElseIf l.x1 > l.x2 And l.y1 <= l.y2 Then
            If dx >= dy Then
                While x > l.x2
                    bmp1 = New Bitmap(707, 284, PixelFormat.Format32bppArgb)
                    gbmp = Graphics.FromImage(bmp1)
                    gbmp.FillEllipse(mybrush, x, y, l.thickness, l.thickness)
                    'dim point2 as new point(x * 20, y * 20)
                    'e.graphics.drawline(pens.black, point1, point2)
                    'point1 = new point(x * 20, y * 20)
                    If d > 0 Then
                        'd <= 0 choose r
                        d = d + dr
                    Else 'd>0, choose ur
                        d = d + dur
                        y = y + 1
                    End If
                    While counter2 <> counter
                        Dim a1 As Rectangle
                        Dim q, w As Integer
                        a1 = rectList(counter2)
                        q = a1.X
                        w = a1.Y
                        gbmp.FillRectangle(mybrush, q, w, 8, 8)
                        counter2 += 1
                    End While
                    counter2 = 0
                    pict.Image = bmp1
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(10)
                    'gbmp.dispose()
                    x -= 1
                End While
            Else 'dy < dx
                While y < l.y2
                    bmp1 = New Bitmap(707, 284, PixelFormat.Format32bppArgb)
                    gbmp = Graphics.FromImage(bmp1)
                    gbmp.FillEllipse(mybrush, x, y, l.thickness, l.thickness)
                    'dim point2 as new point(x * 20, y * 20)
                    'e.graphics.drawline(pens.black, point1, point2)
                    'point1 = new point(x * 20, y * 20)
                    If d <= 0 Then
                        'd <= 0 choose r
                        d = d + dr
                    Else 'd>0, choose ur
                        d = d + dur
                        x = x - 1
                    End If
                    While counter2 <> counter
                        Dim a1 As Rectangle
                        Dim q, w As Integer
                        a1 = rectList(counter2)
                        q = a1.X
                        w = a1.Y
                        gbmp.FillRectangle(mybrush, q, w, 8, 8)
                        counter2 += 1
                    End While
                    counter2 = 0
                    pict.Image = bmp1
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(10)
                    'gbmp.dispose()
                    'bmp1 = new bitmap(823,275, pixelformat.format32bppargb)
                    y += 1
                End While
            End If
        ElseIf l.x1 <= l.x2 And l.y1 > l.y2 Then
            If dx >= dy Then
                While x < l.x2
                    bmp1 = New Bitmap(707, 284, PixelFormat.Format32bppArgb)
                    gbmp = Graphics.FromImage(bmp1)
                    gbmp.FillEllipse(mybrush, x, y, l.thickness, l.thickness)
                    'dim point2 as new point(x * 20, y * 20)
                    'e.graphics.drawline(pens.black, point1, point2)
                    'point1 = new point(x * 20, y * 20)
                    If d > 0 Then
                        'd <= 0 choose r
                        d = d + dr
                    Else 'd>0, choose ur
                        d = d + dur
                        y = y - 1
                    End If
                    While counter2 <> counter
                        Dim a1 As Rectangle
                        Dim q, w As Integer
                        a1 = rectList(counter2)
                        q = a1.X
                        w = a1.Y
                        gbmp.FillRectangle(mybrush, q, w, 8, 8)
                        counter2 += 1
                    End While
                    counter2 = 0
                    pict.Image = bmp1
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(10)
                    'gbmp.dispose()
                    'bmp1 = new bitmap(823,275, pixelformat.format32bppargb)
                    x += 1
                End While
            Else 'dy > dx
                While y > l.y2
                    bmp1 = New Bitmap(707, 284, PixelFormat.Format32bppArgb)
                    gbmp = Graphics.FromImage(bmp1)
                    gbmp.FillEllipse(mybrush, x, y, l.thickness, l.thickness)
                    'dim point2 as new point(x * 20, y * 20)
                    'e.graphics.drawline(pens.black, point1, point2)
                    'point1 = new point(x * 20, y * 20)
                    If d <= 0 Then
                        'd <= 0 choose r
                        d = d + dr
                    Else 'd>0, choose ur
                        d = d + dur
                        x = x + 1
                    End If
                    While counter2 <> counter
                        Dim a1 As Rectangle
                        Dim q, w As Integer
                        a1 = rectList(counter2)
                        q = a1.X
                        w = a1.Y
                        gbmp.FillRectangle(mybrush, q, w, 8, 8)
                        counter2 += 1
                    End While
                    counter2 = 0
                    pict.Image = bmp1
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(10)
                    'gbmp.dispose()
                    'bmp1 = new bitmap(823,275, pixelformat.format32bppargb)
                    y -= 1
                End While
            End If
        ElseIf l.x1 > l.x2 And l.y1 > l.y2 Then
            If dx >= dy Then
                While x > l.x2
                    bmp1 = New Bitmap(707, 284, PixelFormat.Format32bppArgb)
                    gbmp = Graphics.FromImage(bmp1)
                    gbmp.FillEllipse(mybrush, x, y, l.thickness, l.thickness)
                    'dim point2 as new point(x * 20, y * 20)
                    'e.graphics.drawline(pens.black, point1, point2)
                    'point1 = new point(x * 20, y * 20)
                    If d <= 0 Then
                        'd <= 0 choose r
                        d = d + dr
                    Else 'd>0, choose ur
                        d = d + dur
                        y = y - 1
                    End If
                    While counter2 <> counter
                        Dim a1 As Rectangle
                        Dim q, w As Integer
                        a1 = rectList(counter2)
                        q = a1.X
                        w = a1.Y
                        gbmp.FillRectangle(mybrush, q, w, 8, 8)
                        counter2 += 1
                    End While
                    counter2 = 0
                    pict.Image = bmp1
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(10)
                    gbmp.Dispose()
                    'bmp1 = new bitmap(823,275, pixelformat.format32bppargb)
                    x -= 1
                End While
            Else 'dy > dx
                While y > l.y2
                    bmp1 = New Bitmap(707, 284, PixelFormat.Format32bppArgb)
                    gbmp = Graphics.FromImage(bmp1)
                    gbmp.FillEllipse(mybrush, x, y, l.thickness, l.thickness)
                    'dim point2 as new point(x * 20, y * 20)
                    'e.graphics.drawline(pens.black, point1, point2)
                    'point1 = new point(x * 20, y * 20)
                    If d <= 0 Then
                        'd <= 0 choose r
                        d = d + dr
                    Else 'd>0, choose ur
                        d = d + dur
                        x = x - 1
                    End If
                    While counter2 <> counter
                        Dim a1 As Rectangle
                        Dim q, w As Integer
                        a1 = rectList(counter2)
                        q = a1.X
                        w = a1.Y
                        gbmp.FillRectangle(mybrush, q, w, 8, 8)
                        counter2 += 1
                    End While
                    counter2 = 0
                    pict.Image = bmp1
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(10)
                    gbmp.Dispose()
                    'bmp1 = new bitmap(823,275, pixelformat.format32bppargb)
                    y -= 1
                End While
            End If
        End If
        gbmp.Dispose()



        '
    End Sub

    Private Sub createWaypoints(ByVal x As Integer, ByVal y As Integer)
        Dim myGraphics As Graphics = PictureBox1.CreateGraphics
        If CheckBox1.Checked = True Then
            klik = New Rectangle(x, y, 0, 0)
            rectList.Add(klik)
            If rectList.Count > 0 Then
                myGraphics.FillRectangle(Brushes.Black, x, y, 8, 8)
                ListBox1.Items.Add(klik)
            End If
        End If
    End Sub

    'Private Sub PictureBox1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseClick
    '    createWaypoints(e.X, e.Y)
    'End Sub
    Private Sub canvas_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim a1 As Point
        If CheckBox1.Checked Then
            a1 = PictureBox1.PointToClient(Control.MousePosition)
            pX = a1.X
            pY = a1.Y
            createWaypoints(pX, pY)
            counter = counter + 1
        End If

    End Sub
    Private Sub mouse_move(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        TextBox1.Text = e.X
        TextBox2.Text = e.Y
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'PictureBox2.Location = New Point(a3 + 5, a4 + 20)
        ' x= 41y=175
    End Sub

    'Private Sub strtbtn_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrtBtn.Click
    '    Dim a1, a2, a3, a4 As Integer
    '    Dim p As point
    '    a1 = rectlist(counter2).x
    '    a2 = rectlist(counter2).y
    '    a3 = picturebox2.location.x
    '    a4 = picturebox2.location.y
    '    While counter2 < counter
    '        While rectList(counter2).X <> PictureBox2.Location.X Or rectList(counter2).Y <> PictureBox2.Location.Y
    '            If rectList(counter2).X <> PictureBox2.Location.X AndAlso rectList(counter2).X > PictureBox2.Location.X Then
    '                a3 = a3 + 1
    '            ElseIf rectList(counter2).X <> PictureBox2.Location.X AndAlso rectList(counter2).X < PictureBox2.Location.X Then
    '                a3 = a3 - 1
    '            End If
    '            If rectList(counter2).Y <> PictureBox2.Location.Y AndAlso rectList(counter2).Y > PictureBox2.Location.Y Then
    '                a4 = a4 + 1
    '            ElseIf rectList(counter2).Y <> PictureBox2.Location.Y AndAlso rectList(counter2).Y < PictureBox2.Location.Y Then
    '                a4 = a4 - 1
    '            End If
    '            p = New Point(a3, a4)
    '            PictureBox2.Location = p
    '            System.Threading.Thread.Sleep(SpdBox.Text)
    '        End While
    '        counter2 = counter2 + 1
    '    End While
    '    Timer1.Enabled = True
    'End Sub

    Private Sub StpBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StpBtn.Click
        Timer1.Enabled = False
    End Sub

    Public Sub RstBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RstBtn.Click
        'PictureBox2.Left = 41
        'PictureBox2.Top = 175
        PictureBox1.Refresh()
        rectList.Clear()
        bmp1 = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp1
        counter = 0
        ListBox1.Items.Clear()
        Timer1.Enabled = False
        counter3 = 0
        counter2 = 0
        counter = 0
    End Sub

    Sub initline(ByRef l As tline)
        l.x1 = 0
        l.y1 = 0
        l.x2 = 0
        l.y2 = 0
        l.thickness = 10
    End Sub

    Private Sub strtbtn_click(sender As Object, e As EventArgs) Handles StrtBtn.Click
        Dim l As tline
        initline(l)
        'If rectList.Count >= 1 Then
        l.x1 = 41
        l.y1 = 175
        l.x2 = rectList(counter2).X
        l.y2 = rectList(counter2).Y
        l.col = Color.Black
        While counter3 <> counter + 1
            createstraightline(l, PictureBox1)
            l.x1 = l.x2
            l.y1 = l.y2
            counter3 += 1
        End While
        'End If
    End Sub

    'Private Sub CarBtn_Click(sender As Object, e As EventArgs) Handles CarBtn.Click

    '    Dim myPen As Pen
    '    myPen = New Pen(Drawing.Color.DarkTurquoise, 5)

    '    Dim myGraphics As Graphics = PictureBox1.CreateGraphics
    '    Dim myRectangle As New Rectangle

    '    myRectangle.X = 40
    '    myRectangle.Y = 30
    '    myRectangle.Width = 10
    '    myRectangle.Height = 10

    '    myGraphics.DrawEllipse(myPen, myRectangle)
    'End Sub

    'Private Sub form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    mycar.X = 100
    '    mycar.Y = 100
    '    mycar.Width = 10
    '    mycar.Height = 10
    '    e.Graphics.FillEllipse(Brushes.Black, mycar)
    'End Sub


    Private Sub SpdBox_Clicked(sender As Object, e As EventArgs) Handles SpdBox.Click
        SpdBox.Text = ""
    End Sub
End Class
