Module roles
    Function asignar(ByVal value As String)
        'ADMINISTRADORES

        If (value = 1) Then


            'HABILITAR CERRAR SESION ADMIN'
            Panel.AdministradorToolStripMenuItem.Enabled = False
            Panel.AdministradorToolStripMenuItem.Visible = False
            Panel.CerrarSesiónToolStripMenuItem.Enabled = True
            Panel.CerrarSesiónToolStripMenuItem.Visible = True

            'ELEMENTOS DEL MENU HABILITADOS

            Panel.ProveedoresToolStripMenuItem.Visible = True
            Panel.ProveedoresToolStripMenuItem.Enabled = True
            Panel.ReportesToolStripMenuItem.Visible = True
            Panel.ReportesToolStripMenuItem.Enabled = True
            Panel.EmpleadosToolStripMenuItem.Visible = True
            Panel.EmpleadosToolStripMenuItem.Enabled = True


            'EMPLEADOS     
        ElseIf (value = 2) Then

       
            'HABILITAR CERRAR SESION ADMIN'
            Panel.CerrarSesiónToolStripMenuItem.Enabled = False
            Panel.CerrarSesiónToolStripMenuItem.Visible = False
            '
            'ELEMENTOS DEL MENU DESHABILITADOS

            Panel.ProveedoresToolStripMenuItem.Visible = False
            Panel.ProveedoresToolStripMenuItem.Enabled = False
            Panel.ReportesToolStripMenuItem.Visible = False
            Panel.ReportesToolStripMenuItem.Enabled = False
            Panel.EmpleadosToolStripMenuItem.Visible = False
            Panel.EmpleadosToolStripMenuItem.Enabled = False

            Return False


        End If

        Return True

    End Function

End Module
