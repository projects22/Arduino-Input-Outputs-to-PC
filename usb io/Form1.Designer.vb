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
        Me.sp1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Check6 = New System.Windows.Forms.CheckBox()
        Me.Check5 = New System.Windows.Forms.CheckBox()
        Me.Check4 = New System.Windows.Forms.CheckBox()
        Me.Check3 = New System.Windows.Forms.CheckBox()
        Me.Check2 = New System.Windows.Forms.CheckBox()
        Me.Check1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'sp1
        '
        Me.sp1.PortName = "COM7"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Check6)
        Me.GroupBox1.Controls.Add(Me.Check5)
        Me.GroupBox1.Controls.Add(Me.Check4)
        Me.GroupBox1.Controls.Add(Me.Check3)
        Me.GroupBox1.Controls.Add(Me.Check2)
        Me.GroupBox1.Controls.Add(Me.Check1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(86, 194)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Outputs"
        '
        'Check6
        '
        Me.Check6.AutoSize = True
        Me.Check6.Location = New System.Drawing.Point(6, 19)
        Me.Check6.Name = "Check6"
        Me.Check6.Size = New System.Drawing.Size(56, 17)
        Me.Check6.TabIndex = 5
        Me.Check6.Text = "PIN13"
        Me.Check6.UseVisualStyleBackColor = True
        '
        'Check5
        '
        Me.Check5.AutoSize = True
        Me.Check5.Location = New System.Drawing.Point(6, 51)
        Me.Check5.Name = "Check5"
        Me.Check5.Size = New System.Drawing.Size(56, 17)
        Me.Check5.TabIndex = 4
        Me.Check5.Text = "PIN12"
        Me.Check5.UseVisualStyleBackColor = True
        '
        'Check4
        '
        Me.Check4.AutoSize = True
        Me.Check4.Location = New System.Drawing.Point(6, 79)
        Me.Check4.Name = "Check4"
        Me.Check4.Size = New System.Drawing.Size(56, 17)
        Me.Check4.TabIndex = 3
        Me.Check4.Text = "PIN11"
        Me.Check4.UseVisualStyleBackColor = True
        '
        'Check3
        '
        Me.Check3.AutoSize = True
        Me.Check3.Location = New System.Drawing.Point(6, 108)
        Me.Check3.Name = "Check3"
        Me.Check3.Size = New System.Drawing.Size(56, 17)
        Me.Check3.TabIndex = 2
        Me.Check3.Text = "PIN10"
        Me.Check3.UseVisualStyleBackColor = True
        '
        'Check2
        '
        Me.Check2.AutoSize = True
        Me.Check2.Location = New System.Drawing.Point(6, 134)
        Me.Check2.Name = "Check2"
        Me.Check2.Size = New System.Drawing.Size(50, 17)
        Me.Check2.TabIndex = 1
        Me.Check2.Text = "PIN9"
        Me.Check2.UseVisualStyleBackColor = True
        '
        'Check1
        '
        Me.Check1.AutoSize = True
        Me.Check1.Location = New System.Drawing.Point(6, 162)
        Me.Check1.Name = "Check1"
        Me.Check1.Size = New System.Drawing.Size(50, 17)
        Me.Check1.TabIndex = 0
        Me.Check1.Text = "PIN8"
        Me.Check1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Panel11)
        Me.GroupBox2.Controls.Add(Me.Panel9)
        Me.GroupBox2.Controls.Add(Me.Panel7)
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Location = New System.Drawing.Point(114, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(86, 194)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inputs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "PIN6"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "PIN7"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "PIN2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "PIN3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "PIN5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "PIN4"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Location = New System.Drawing.Point(7, 160)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(20, 20)
        Me.Panel11.TabIndex = 5
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Red
        Me.Panel12.ForeColor = System.Drawing.Color.Red
        Me.Panel12.Location = New System.Drawing.Point(2, 2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(16, 16)
        Me.Panel12.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Location = New System.Drawing.Point(7, 134)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(20, 20)
        Me.Panel9.TabIndex = 4
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Red
        Me.Panel10.ForeColor = System.Drawing.Color.Red
        Me.Panel10.Location = New System.Drawing.Point(2, 2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(16, 16)
        Me.Panel10.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(7, 108)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(20, 20)
        Me.Panel7.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Red
        Me.Panel8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel8.Location = New System.Drawing.Point(2, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(16, 16)
        Me.Panel8.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(7, 79)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(20, 20)
        Me.Panel5.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Red
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel6.Location = New System.Drawing.Point(2, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(16, 16)
        Me.Panel6.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(7, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(20, 20)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel4.Location = New System.Drawing.Point(2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(16, 16)
        Me.Panel4.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(7, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(20, 20)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(16, 16)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.ProgressBar4)
        Me.GroupBox3.Controls.Add(Me.ProgressBar3)
        Me.GroupBox3.Controls.Add(Me.ProgressBar2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ProgressBar1)
        Me.GroupBox3.Location = New System.Drawing.Point(216, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 142)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Analog"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(158, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "PIN A3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(158, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "PIN A2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(158, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "PIN A1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(158, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "PIN A0"
        '
        'ProgressBar4
        '
        Me.ProgressBar4.Location = New System.Drawing.Point(6, 19)
        Me.ProgressBar4.Maximum = 1024
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar4.TabIndex = 7
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(6, 48)
        Me.ProgressBar3.Maximum = 1024
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar3.TabIndex = 6
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(6, 77)
        Me.ProgressBar2.Maximum = 1024
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(112, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(112, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(112, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(112, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 105)
        Me.ProgressBar1.Maximum = 1024
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(348, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(295, 181)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(27, 20)
        Me.Text1.TabIndex = 4
        Me.Text1.Text = "7"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(219, 183)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "COM PORT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 220)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "USB Input Output"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sp1 As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Check6 As System.Windows.Forms.CheckBox
    Friend WithEvents Check5 As System.Windows.Forms.CheckBox
    Friend WithEvents Check4 As System.Windows.Forms.CheckBox
    Friend WithEvents Check3 As System.Windows.Forms.CheckBox
    Friend WithEvents Check2 As System.Windows.Forms.CheckBox
    Friend WithEvents Check1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Text1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar4 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
