Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Dia.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o = DateTime.Now.ToString("HH:mm")

        Dim Time_Mod = Time_o.Split(":")

        relok.Text = Time_Mod(0)
        relok2.Text = Time_Mod(1)
        Dia.Text = Day_o
        Label1.Text = Date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label2.Text = ":" Then
            Label2.Text = ""
        ElseIf Label2.Text = "" Then
            Label2.Text = ":"
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub relok_Click(sender As Object, e As EventArgs) Handles relok.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = True Then
            Panel1.Visible = False
        ElseIf Panel1.Visible = False Then
            Panel1.Visible = True
        End If
    End Sub
End Class
