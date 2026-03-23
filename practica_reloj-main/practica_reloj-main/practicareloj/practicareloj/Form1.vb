Public Class Form1
    Dim formato As Boolean = True
    Dim start_e As Boolean = False
    Dim tiempo_crono As Integer = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Dia.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o = ""

        'tengohambre
        If formato = True Then
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If


        Dim Time_Mod = Time_o.Split(":")
        relok.Text = Time_Mod(0)
        relok2.Text = Time_Mod(1)
        relok3.Text = Time_Mod(2)
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim color_texto As String = ComboBox1.SelectedItem.ToString()
        If color_texto = "blanco" Then
            relok.ForeColor = Color.White
            Dia.ForeColor = Color.White
            Label1.ForeColor = Color.White
            relok2.ForeColor = Color.White
            Label2.ForeColor = Color.White
            relok3.ForeColor = Color.White
        ElseIf color_texto = "rojo" Then
            relok.ForeColor = Color.Red
            Dia.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            relok2.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
            relok3.ForeColor = Color.Red
        ElseIf color_texto = "azul" Then
            relok.ForeColor = Color.Blue
            Dia.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            relok2.ForeColor = Color.Blue
            Label2.ForeColor = Color.Blue
            relok3.ForeColor = Color.Blue
        ElseIf color_texto = "verde" Then
            relok.ForeColor = Color.Green
            Dia.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
            relok2.ForeColor = Color.Green
            Label2.ForeColor = Color.Green
            relok3.ForeColor = Color.Green
        ElseIf color_texto = "amarillo" Then
            relok.ForeColor = Color.Yellow
            Dia.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            relok2.ForeColor = Color.Yellow
            Label2.ForeColor = Color.Yellow
            relok3.ForeColor = Color.Yellow
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12h"
            formato = False
        ElseIf formato = False Then
            Button1.Text = "24h"
            formato = True
        End If
    End Sub

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        If start_e = False Then
            Timer3.Enabled = True
            start_e = True
            start.Text = "stop"
        ElseIf start_e = True Then
            Timer3.Enabled = False
            start_e = False
            start.Text = "start"
        End If
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        tiempo_crono = 0
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        tiempo_crono = tiempo_crono + 1
        tempo.Text = tiempo_crono.ToString()
    End Sub
End Class
