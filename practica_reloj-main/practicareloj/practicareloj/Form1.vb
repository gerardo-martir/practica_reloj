Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Dia.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
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
End Class
