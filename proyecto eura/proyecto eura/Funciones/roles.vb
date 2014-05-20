Module roles
    Function asignar(ByVal value As String)
        'ADMINISTRADORES

        If (value = 1) Then

            Panel.Button1.Enabled = True
            'HABILITAR CERRAR SESION ADMIN'
            Panel.btnCerrar.Enabled = True
            Panel.btnCerrar.Visible = True


            'EMPLEADOS     
        ElseIf (value = 2) Then

            Panel.Button1.Enabled = False

            'HABILITAR CERRAR SESION ADMIN'
            Panel.btnCerrar.Enabled = False
            Panel.btnCerrar.Visible = False



            Return False


        End If

        Return True

    End Function

End Module
