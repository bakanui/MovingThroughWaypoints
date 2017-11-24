Public Class Form1
    Dim rectList As New List(Of Rectangle)
    Dim counter As Integer = 0
    Dim counter2 As Integer = 0


    Private Sub createWaypoints(ByVal x As Integer, ByVal y As Integer)
        Dim myGraphics As Graphics = PictureBox1.CreateGraphics
        If CheckBox1.Checked = True Then
            Dim klik As Rectangle = New Rectangle(x, y, 0, 0)
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
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim a1 As Point
        a1 = PictureBox1.PointToClient(Control.MousePosition)
        createWaypoints(a1.X, a1.Y)
        counter = counter + 1

    End Sub
    Private Sub mouse_move(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        TextBox1.Text = e.X
        TextBox2.Text = e.Y
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'PictureBox2.Location = New Point(a3 + 5, a4 + 20)
        ' x= 41y=175
    End Sub

    Private Sub StrtBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrtBtn.Click
        Dim a1, a2, a3, a4 As Integer
        Dim p As Point
        a1 = rectList(counter2).X
        a2 = rectList(counter2).Y
        a3 = PictureBox2.Location.X
        a4 = PictureBox2.Location.Y
        While counter2 < counter
            While rectList(counter2).X <> PictureBox2.Location.X Or rectList(counter2).Y <> PictureBox2.Location.Y
                If rectList(counter2).X <> PictureBox2.Location.X AndAlso rectList(counter2).X > PictureBox2.Location.X Then
                    a3 = a3 + 1
                ElseIf rectList(counter2).X <> PictureBox2.Location.X AndAlso rectList(counter2).X < PictureBox2.Location.X Then
                    a3 = a3 - 1
                End If
                If rectList(counter2).Y <> PictureBox2.Location.Y AndAlso rectList(counter2).Y > PictureBox2.Location.Y Then
                    a4 = a4 + 1
                ElseIf rectList(counter2).Y <> PictureBox2.Location.Y AndAlso rectList(counter2).Y < PictureBox2.Location.Y Then
                    a4 = a4 - 1
                End If
                p = New Point(a3, a4)
                PictureBox2.Location = p
                Timer1.Start()
                Timer1.Stop()
            End While
            counter2 = counter2 + 1
        End While
        PictureBox2.Location = New Point(p.X, p.Y)
        Timer1.Enabled = True
    End Sub

    Private Sub StpBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StpBtn.Click
        Timer1.Enabled = False
    End Sub

    Public Sub RstBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RstBtn.Click
        PictureBox2.Left = 41
        PictureBox2.Top = 175
        PictureBox1.Refresh()
        rectList.Clear()
        ListBox1.Items.Clear()
        Timer1.Enabled = False
        counter2 = 0
        counter = 0
    End Sub


End Class
