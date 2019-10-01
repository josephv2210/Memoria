Public Class MenuPrincipal
    Private Sub Btn_Facil_Click(sender As Object, e As EventArgs) Handles Btn_Facil.Click
        Me.Visible = False
        Facil.Show()

    End Sub

    Private Sub Btn_Medio_Click(sender As Object, e As EventArgs) Handles Btn_Medio.Click
        Me.Visible = False
        Medio.Show()
    End Sub

    Private Sub Btn_Dificil_Click(sender As Object, e As EventArgs) Handles Btn_Dificil.Click
        Me.Visible = False
        Dificil.Show()
    End Sub


End Class
