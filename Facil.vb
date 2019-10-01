Public Class Facil

    Public contador, segundos, segundos2, Puntaje, Ganar As Integer

    Private Sub Btn_Menu_Click(sender As Object, e As EventArgs) Handles Btn_Menu.Click
        Me.Visible = False
        MenuPrincipal.Show()
    End Sub

    Public Sub Pareja(ByVal Pareja1 As Object, ByVal Img As Object, ByVal Pareja2 As Object)
        Timer1.Enabled = True
        contador = contador + 1
        Pareja1.Image = Img.Image
        If Pareja1.Image.Equals(Img.Image) And Pareja2.Image.Equals(Img.Image) Then
            Pareja1.Visible = False
            Pareja2.Visible = False
            Puntaje = Puntaje + 2
            Ganar = Ganar + 1
        ElseIf contador = 2 Then
            Timer2.Enabled = True
            Puntaje = Puntaje - 1
        End If
        If contador = 2 Then
            contador = 0
        End If
        Lbl_Puntaje.Text = Puntaje
        Valida_Ganar(Ganar)
    End Sub

    Public Sub Valida_Ganar(ByVal Ganar As Integer)
        If Ganar = 8 Then
            Timer1.Enabled = False
            MsgBox(“Felicidades, juego terminado”)
        End If
    End Sub

    Private Sub Img_Pareja1_1_Click(sender As Object, e As EventArgs) Handles Img_Pareja1_1.Click
        Pareja(Img_Pareja1_1, Img_Img1, Img_Pareja1_2)
    End Sub

    Private Sub Img_Pareja1_2_Click(sender As Object, e As EventArgs) Handles Img_Pareja1_2.Click
        Pareja(Img_Pareja1_2, Img_Img1, Img_Pareja1_1)
    End Sub

    Private Sub Img_Pareja2_1_Click(sender As Object, e As EventArgs) Handles Img_Pareja2_1.Click
        Pareja(Img_Pareja2_1, Img_Img2, Img_Pareja2_2)
    End Sub

    Private Sub Img_Pareja2_2_Click(sender As Object, e As EventArgs) Handles Img_Pareja2_2.Click
        Pareja(Img_Pareja2_2, Img_Img2, Img_Pareja2_1)
    End Sub

    Private Sub Img_Pareja3_1_Click(sender As Object, e As EventArgs) Handles Img_Pareja3_1.Click
        Pareja(Img_Pareja3_1, Img_Img3, Img_Pareja3_2)
    End Sub

    Private Sub Img_Pareja3_2_Click(sender As Object, e As EventArgs) Handles Img_Pareja3_2.Click
        Pareja(Img_Pareja3_2, Img_Img3, Img_Pareja3_1)
    End Sub

    Private Sub Img_Pareja4_1_Click(sender As Object, e As EventArgs) Handles Img_Pareja4_1.Click
        Pareja(Img_Pareja4_1, Img_Img4, Img_Pareja4_2)
    End Sub

    Private Sub Img_Pareja4_2_Click(sender As Object, e As EventArgs) Handles Img_Pareja4_2.Click
        Pareja(Img_Pareja4_2, Img_Img4, Img_Pareja4_1)
    End Sub

    Private Sub Img_Pareja5_1_Click(sender As Object, e As EventArgs) Handles Img_Pareja5_1.Click
        Pareja(Img_Pareja5_1, Img_Img5, Img_Pareja5_2)
    End Sub

    Private Sub Img_Pareja5_2_Click(sender As Object, e As EventArgs) Handles Img_Pareja5_2.Click
        Pareja(Img_Pareja5_2, Img_Img5, Img_Pareja5_1)
    End Sub

    Private Sub Facil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Img_Pareja6_1_Click(sender As Object, e As EventArgs) Handles Img_Pareja6_1.Click
        Pareja(Img_Pareja6_1, Img_Img6, Img_Pareja6_2)
    End Sub

    Private Sub Img_Pareja6_2_Click(sender As Object, e As EventArgs) Handles Img_Pareja6_2.Click
        Pareja(Img_Pareja6_2, Img_Img6, Img_Pareja6_1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        segundos = segundos + 1
        Lbl_Tiempo.Text = segundos
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        segundos2 = segundos2 + 1
        If segundos2 = 4 Then
            Img_Pareja1_1.Image = Img_Estandar.Image
            Img_Pareja1_2.Image = Img_Estandar.Image
            Img_Pareja2_1.Image = Img_Estandar.Image
            Img_Pareja2_2.Image = Img_Estandar.Image
            Img_Pareja3_1.Image = Img_Estandar.Image
            Img_Pareja3_2.Image = Img_Estandar.Image
            Img_Pareja4_1.Image = Img_Estandar.Image
            Img_Pareja4_2.Image = Img_Estandar.Image
            Img_Pareja5_1.Image = Img_Estandar.Image
            Img_Pareja5_2.Image = Img_Estandar.Image
            Img_Pareja6_1.Image = Img_Estandar.Image
            Img_Pareja6_2.Image = Img_Estandar.Image
            segundos2 = 0
            Timer2.Enabled = False
        End If
    End Sub
End Class