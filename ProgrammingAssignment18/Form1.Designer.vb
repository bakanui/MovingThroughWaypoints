<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StrtBtn = New System.Windows.Forms.Button()
        Me.StpBtn = New System.Windows.Forms.Button()
        Me.RstBtn = New System.Windows.Forms.Button()
        Me.SpdBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.moveCar = New System.Windows.Forms.Timer(Me.components)
        Me.Coordinates = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StrtBtn
        '
        Me.StrtBtn.Location = New System.Drawing.Point(16, 15)
        Me.StrtBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.StrtBtn.Name = "StrtBtn"
        Me.StrtBtn.Size = New System.Drawing.Size(100, 28)
        Me.StrtBtn.TabIndex = 2
        Me.StrtBtn.Text = "Start"
        Me.StrtBtn.UseVisualStyleBackColor = True
        '
        'StpBtn
        '
        Me.StpBtn.Location = New System.Drawing.Point(124, 15)
        Me.StpBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.StpBtn.Name = "StpBtn"
        Me.StpBtn.Size = New System.Drawing.Size(100, 28)
        Me.StpBtn.TabIndex = 3
        Me.StpBtn.Text = "Stop"
        Me.StpBtn.UseVisualStyleBackColor = True
        '
        'RstBtn
        '
        Me.RstBtn.Location = New System.Drawing.Point(232, 15)
        Me.RstBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RstBtn.Name = "RstBtn"
        Me.RstBtn.Size = New System.Drawing.Size(100, 28)
        Me.RstBtn.TabIndex = 4
        Me.RstBtn.Text = "Reset"
        Me.RstBtn.UseVisualStyleBackColor = True
        '
        'SpdBox
        '
        Me.SpdBox.Location = New System.Drawing.Point(983, 141)
        Me.SpdBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SpdBox.Name = "SpdBox"
        Me.SpdBox.Size = New System.Drawing.Size(80, 22)
        Me.SpdBox.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(16, 50)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(943, 350)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'moveCar
        '
        '
        'Coordinates
        '
        Me.Coordinates.AutoSize = True
        Me.Coordinates.Location = New System.Drawing.Point(1001, 384)
        Me.Coordinates.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Coordinates.Name = "Coordinates"
        Me.Coordinates.Size = New System.Drawing.Size(29, 17)
        Me.Coordinates.TabIndex = 12
        Me.Coordinates.Text = "x, y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(987, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Speed Box"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1076, 415)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Coordinates)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SpdBox)
        Me.Controls.Add(Me.RstBtn)
        Me.Controls.Add(Me.StpBtn)
        Me.Controls.Add(Me.StrtBtn)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StrtBtn As System.Windows.Forms.Button
    Friend WithEvents StpBtn As System.Windows.Forms.Button
    Friend WithEvents RstBtn As System.Windows.Forms.Button
    Friend WithEvents SpdBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents moveCar As Timer
    Friend WithEvents Coordinates As Label
    Friend WithEvents Label1 As Label
End Class
