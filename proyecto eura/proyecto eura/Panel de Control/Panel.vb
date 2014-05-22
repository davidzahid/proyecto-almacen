Public Class Panel


    Private Sub AdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradorToolStripMenuItem.Click

        'Limpiamos valores'
        Acceso.txtUsuario.Text = ""
        Acceso.txtContrasena.Text = ""
        'Mostramos acceso nuevamente'
        'accesoadmin.Show()
        Acceso.Show()



    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        value.Text = 2
        asignar(value.Text)
        'Limpiamos valores'
        Acceso.txtUsuario.Text = ""
        Acceso.txtContrasena.Text = ""
        'Mostramos acceso nuevamente'

        Acceso.Show()


        Me.Close()
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem.Click
        frmNuevaEntrada.Show()

    End Sub



    Private Sub Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Movimientos.movimientos_sistema' Puede moverla o quitarla según sea necesario.
        Me.Movimientos_sistemaTableAdapter.Fill(Me.Movimientos.movimientos_sistema)
        'TODO: esta línea de código carga datos en la tabla 'Movimientos.movimientos_sistema' Puede moverla o quitarla según sea necesario.
        Me.Movimientos_sistemaTableAdapter.Fill(Me.Movimientos.movimientos_sistema)
        'TODO: esta línea de código carga datos en la tabla 'Movimientos.movimientos_sistema' Puede moverla o quitarla según sea necesario.
        Me.Movimientos_sistemaTableAdapter.Fill(Me.Movimientos.movimientos_sistema)



    End Sub

    Private Sub MovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosToolStripMenuItem.Click
        reporteEntradasAlmacen.Show()

    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        reporteEntradas.Show()
    End Sub

    Private Sub NuevaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem1.Click
        nuevaSalida.Show()

    End Sub


End Class