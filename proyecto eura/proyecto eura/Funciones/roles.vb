Module roles
    Function asignar(ByVal value As String)
        'ADMINISTRADORES

        If (value = 1) Then


            'HABILITAR CERRAR SESION ADMIN'
            Panel.AdministradorToolStripMenuItem.Enabled = False
            Panel.AdministradorToolStripMenuItem.Visible = False
            Panel.CerrarSesionToolStripMenuItem.Enabled = True
            Panel.CerrarSesionToolStripMenuItem.Visible = True

            'ELEMENTOS DEL MENU HABILITADOS

            Panel.ProveedoresToolStripMenuItem.Visible = True
            Panel.ProveedoresToolStripMenuItem.Enabled = True
            Panel.ReportesToolStripMenuItem.Visible = True
            Panel.ReportesToolStripMenuItem.Enabled = True
            Panel.EmpleadosToolStripMenuItem.Visible = True
            Panel.EmpleadosToolStripMenuItem.Enabled = True


            Panel.lblRol.Text = "Bienvenido Administrador"
            Panel.lblLogin.Text = "Usuario: " + Acceso.txtUsuario.Text

            'EMPLEADOS     
        ElseIf (value = 2) Then


            'HABILITAR CERRAR SESION ADMIN'
            Panel.CerrarSesionToolStripMenuItem.Enabled = False
            Panel.CerrarSesionToolStripMenuItem.Visible = False
            '
            'ELEMENTOS DEL MENU DESHABILITADOS

            Panel.ProveedoresToolStripMenuItem.Visible = False
            Panel.ProveedoresToolStripMenuItem.Enabled = False
            Panel.ReportesToolStripMenuItem.Visible = False
            Panel.ReportesToolStripMenuItem.Enabled = False
            Panel.EmpleadosToolStripMenuItem.Visible = False
            Panel.EmpleadosToolStripMenuItem.Enabled = False

            Panel.lblRol.Text = "Bienvenido Empleado"
            Panel.lblLogin.Text = "Usuario: " + Acceso.txtUsuario.Text
            Return False


        End If

        Return True

    End Function

End Module
