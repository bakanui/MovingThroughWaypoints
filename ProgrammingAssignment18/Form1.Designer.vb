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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SpdBox = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(967, 139)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 21)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Waypoints"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SpdBox
        '
        Me.SpdBox.Location = New System.Drawing.Point(979, 167)
        Me.SpdBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SpdBox.Name = "SpdBox"
        Me.SpdBox.Size = New System.Drawing.Size(80, 22)
        Me.SpdBox.TabIndex = 6
        Me.SpdBox.Text = "Speed"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(967, 15)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(92, 116)
        Me.ListBox1.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(980, 386)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(35, 22)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1024, 386)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(35, 22)
        Me.TextBox2.TabIndex = 10
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
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 415)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.SpdBox)
        Me.Controls.Add(Me.CheckBox1)
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
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SpdBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As Timer
End Class
