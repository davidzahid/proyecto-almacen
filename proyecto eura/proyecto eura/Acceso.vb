Public Class Acceso

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        If (empleado(txtUsuario.Text, txtContrasena.Text)) Then
            value.Text = 2
            asignar(value.Text)


            Panel.Show()


        Else
            MessageBox.Show("ACCESO INCORRECTO")
        End If

    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        'CON LA SIGUIENTE INSTRUCCIÓN, AL MOMENTO DE PRESIONAR LA TECLA
        'ENTER NOS DIRIGIRA AL BOTON DE ACCEDER'

        If e.KeyCode = Keys.Enter Then
            btnAcceder_Click(sender, e)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUsuario.Text = "Em14457"
        txtContrasena.Text = "14747"

    End Sub
End Class
