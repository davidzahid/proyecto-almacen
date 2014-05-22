Public Class Panel


    Private Sub AdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradorToolStripMenuItem.Click

        'Limpiamos valores'
        Acceso.txtUsuario.Text = ""
        Acceso.txtContrasena.Text = ""
        Acceso.contador = 0
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


    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        acercade.Show()
    End Sub


    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem.Click
        reporteSalidas.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        reporteProveedores.Show()
    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click
        'FALTA DISEÑAR EL FORMULARIO DE EMPLEADOS'
        nuevoEmpleado.Show()

    End Sub

    Private Sub GestionDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeProveedoresToolStripMenuItem.Click
        'FALTA DISEÑAR EL FORMULARIO DE EMPLEADOS'
        nuevoProveedor.Show()
    End Sub

    Private Sub GestionDeObrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeObrasToolStripMenuItem.Click
        gestionObras.Show()
    End Sub
End Class