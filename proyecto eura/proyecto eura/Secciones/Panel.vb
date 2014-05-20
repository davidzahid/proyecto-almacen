Public Class Panel
 

 
    Private Sub Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub Administrador_Click(sender As Object, e As EventArgs) Handles Administrador.Click
        Acceso.Show()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        value.Text = 2
        asignar(value.Text)
        'Limpiamos valores'
        Acceso.txtUsuario.Text = ""
        Acceso.txtContrasena.Text = ""
        'Mostramos acceso nuevamente'
        Acceso.Show()
        Me.Close()

    End Sub
End Class