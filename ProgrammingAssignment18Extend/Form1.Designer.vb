<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StrtBtn = New System.Windows.Forms.Button()
        Me.StpBtn = New System.Windows.Forms.Button()
        Me.RstBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TorqBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Coordinates = New System.Windows.Forms.Label()
        Me.SpdBox = New System.Windows.Forms.TextBox()
        Me.moveCar = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(12, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(785, 284)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'StrtBtn
        '
        Me.StrtBtn.Location = New System.Drawing.Point(12, 9)
        Me.StrtBtn.Name = "StrtBtn"
        Me.StrtBtn.Size = New System.Drawing.Size(75, 23)
        Me.StrtBtn.TabIndex = 17
        Me.StrtBtn.Text = "Start"
        Me.StrtBtn.UseVisualStyleBackColor = True
        '
        'StpBtn
        '
        Me.StpBtn.Location = New System.Drawing.Point(93, 9)
        Me.StpBtn.Name = "StpBtn"
        Me.StpBtn.Size = New System.Drawing.Size(75, 23)
        Me.StpBtn.TabIndex = 16
        Me.StpBtn.Text = "Stop"
        Me.StpBtn.UseVisualStyleBackColor = True
        '
        'RstBtn
        '
        Me.RstBtn.Location = New System.Drawing.Point(174, 9)
        Me.RstBtn.Name = "RstBtn"
        Me.RstBtn.Size = New System.Drawing.Size(75, 23)
        Me.RstBtn.TabIndex = 16
        Me.RstBtn.Text = "Reset"
        Me.RstBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(439, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Torque"
        '
        'TorqBox
        '
        Me.TorqBox.Location = New System.Drawing.Point(484, 12)
        Me.TorqBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TorqBox.Name = "TorqBox"
        Me.TorqBox.Size = New System.Drawing.Size(76, 20)
        Me.TorqBox.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(322, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Speed"
        '
        'Coordinates
        '
        Me.Coordinates.AutoSize = True
        Me.Coordinates.Location = New System.Drawing.Point(743, 22)
        Me.Coordinates.Name = "Coordinates"
        Me.Coordinates.Size = New System.Drawing.Size(23, 13)
        Me.Coordinates.TabIndex = 19
        Me.Coordinates.Text = "x, y"
        '
        'SpdBox
        '
        Me.SpdBox.Location = New System.Drawing.Point(364, 12)
        Me.SpdBox.Name = "SpdBox"
        Me.SpdBox.Size = New System.Drawing.Size(61, 20)
        Me.SpdBox.TabIndex = 18
        '
        'moveCar
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(809, 334)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TorqBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Coordinates)
        Me.Controls.Add(Me.SpdBox)
        Me.Controls.Add(Me.RstBtn)
        Me.Controls.Add(Me.StpBtn)
        Me.Controls.Add(Me.StrtBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Moving Through Waypoints"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StrtBtn As Button
    Friend WithEvents StpBtn As Button
    Friend WithEvents RstBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TorqBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Coordinates As Label
    Friend WithEvents SpdBox As TextBox
    Friend WithEvents moveCar As Timer
End Class
