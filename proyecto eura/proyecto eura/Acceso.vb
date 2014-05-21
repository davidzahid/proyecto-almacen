Public Class Acceso
    Dim contador As Integer = 0

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        If (empleado(txtUsuario.Text, txtContrasena.Text)) Then
           


            'DATOS QUE SE ENVIARAN AL LOS MOVIMIENTOS DEL SISTEMA'

            'GENERAR ID'
            txtId.Text = Val(Me.Movimientos_sistemaTableAdapter.identificador())
            If txtId.Text = "" Then
                txtId.Text = 0
            End If
            txtId.Text = txtId.Text + 1

            'pasamos la id del usuario que haya accedido'
            txtEmpleado.Text = txtUsuario.Text
            txtEmpleado.Text = Val(EmpleadoTableAdapter.nombreEmpleado(txtEmpleado.Text))
            'VALIDAR AQUE PUESTO PERTENECE QUIEN ENTRO'


            'pasamos el puesto del usuario que haya accedido
            txtPuesto.Text = txtUsuario.Text
            txtPuesto.Text = Val(EmpleadoTableAdapter.tipoPuesto(txtPuesto.Text))
            Dim numero As Integer = txtPuesto.Text
            Select Case numero
                Case 1
                    lblDescripcion.Text = "Accedio al Sistema un Administrador registrado como: " + txtUsuario.Text
                    value.Text = 1
                    asignar(value.Text)


                Case Else

                    lblDescripcion.Text = "Accedio al Sistema un Empleado registrado como: " + txtUsuario.Text
                    value.Text = 2
                    asignar(value.Text)

            End Select

            'termina el validador de casos'
            'generar fecha y hora actual del sistema
            Dim timestamp As Date = Format(Now)
            lblFecha.Text = timestamp.ToString(("dd/MM/yyyy HH:mm:ss"))

            'TERMINA LOS DATOS ENVIADOS'

            'AQUI SE REGISTRA EL MOVIMIENTO'

            Me.Movimientos_sistemaTableAdapter.guarda_movimiento(lblTipo.Text, lblDescripcion.Text, lblFecha.Text, txtEmpleado.Text)
            Me.Movimientos_sistemaTableAdapter.Fill(Me.Movimientos.movimientos_sistema)


            Panel.Show()
            Me.Visible = False

        Else

            contador = contador + 1
            If (contador > 2) Then
                MessageBox.Show("Ha excedido el número maximo de intentos", "Error")
                Me.Close()
            End If
            MessageBox.Show("Usuario y/o Contraseña Incorrectos", "Error")
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
        'TODO: esta línea de código carga datos en la tabla 'Movimientos.movimientos_sistema' Puede moverla o quitarla según sea necesario.
        Me.Movimientos_sistemaTableAdapter.Fill(Me.Movimientos.movimientos_sistema)
        'TODO: esta línea de código carga datos en la tabla 'Movimientos.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.Movimientos.empleado)




    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged



     


    End Sub

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Movimientos)

    End Sub


End Class
