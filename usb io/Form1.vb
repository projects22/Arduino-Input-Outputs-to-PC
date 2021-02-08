Public Class Form1
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If sp1.IsOpen Then sp1.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sp1.BaudRate = 9600
        sp1.DataBits = 8
        Timer1.Interval = 100
        Timer1.Enabled = False
        Button1.Text = "START"
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
 
        If Button1.Text = "STOP" Then
            If sp1.IsOpen Then
                sp1.Close()
            Else
                sp1.Close()
            End If
            Timer1.Enabled = False
            Text1.Enabled = True
            Button1.Text = "START"

        ElseIf Button1.Text = "START" Then
            If sp1.IsOpen Then
                sp1.Close()
                sp1.PortName = "COM" + Text1.Text
                sp1.Open()
            Else
                sp1.PortName = "COM" + Text1.Text
                sp1.Open()
            End If
            Button1.Text = "STOP"
            Timer1.Enabled = True
            Text1.Enabled = False
        End If

    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim v1, v2, v3, v4 As Double
        Dim tx(2) As Byte
        Dim rx(9) As Byte

        tx(1) = 128
        tx(0) = 0
        If Check1.Checked Then tx(0) = 1
        If Check2.Checked Then tx(0) = tx(0) Or 2
        If Check3.Checked Then tx(0) = tx(0) Or 4
        If Check4.Checked Then tx(0) = tx(0) Or 8
        If Check5.Checked Then tx(0) = tx(0) Or 16
        If Check6.Checked Then tx(0) = tx(0) Or 32

        sp1.Write(tx, 0, 2)
        Sleep(30)
        sp1.Read(rx, 0, 9)

        v1 = (rx(0) + rx(1) * 256) * 5 / 1023
        v2 = (rx(2) + rx(3) * 256) * 5 / 1023
        v3 = (rx(4) + rx(5) * 256) * 5 / 1023
        v4 = (rx(6) + rx(7) * 256) * 5 / 1023

        ProgressBar1.Value = rx(0) + rx(1) * 256
        ProgressBar2.Value = rx(2) + rx(3) * 256
        ProgressBar3.Value = rx(4) + rx(5) * 256
        ProgressBar4.Value = rx(6) + rx(7) * 256
        Label1.Text = Format(v1, "0.000")
        Label2.Text = Format(v2, "0.000")
        Label3.Text = Format(v3, "0.000")
        Label4.Text = Format(v4, "0.000")
        'rx(8) = 6
        If rx(8) And 1 Then
            Panel2.BackColor = Color.Green
        Else
            Panel2.BackColor = Color.Red
        End If
        If rx(8) And 2 Then
            Panel4.BackColor = Color.Green
        Else
            Panel4.BackColor = Color.Red
        End If
        If rx(8) And 4 Then
            Panel6.BackColor = Color.Green
        Else
            Panel6.BackColor = Color.Red
        End If
        If rx(8) And 8 Then
            Panel8.BackColor = Color.Green
        Else
            Panel8.BackColor = Color.Red
        End If
        If rx(8) And 16 Then
            Panel10.BackColor = Color.Green
        Else
            Panel10.BackColor = Color.Red
        End If
        If rx(8) And 32 Then
            Panel12.BackColor = Color.Green
        Else
            Panel12.BackColor = Color.Red
        End If

    End Sub
End Class
