Public Class Panel


    Private Sub AdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradorToolStripMenuItem.Click
        'Limpiamos valores'
        Acceso.txtUsuario.Text = ""
        Acceso.txtContrasena.Text = ""
        'Mostramos acceso nuevamente'
        accesoadmin.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
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