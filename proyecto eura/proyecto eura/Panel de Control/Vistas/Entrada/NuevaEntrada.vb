Public Class frmNuevaEntrada

    Private Sub EntradaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EntradaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EntradaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Entradas)

    End Sub

    Private Sub frmNuevaEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Entradas1.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.Entradas1.proveedor)
        'TODO: esta línea de código carga datos en la tabla 'Entradas1.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.Entradas1.proveedor)
        'TODO: esta línea de código carga datos en la tabla 'Entradas.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.Entradas.proveedor)
        'TODO: esta línea de código carga datos en la tabla 'Movimientos.movimientos_sistema' Puede moverla o quitarla según sea necesario.
        Me.Movimientos_sistemaTableAdapter.Fill(Me.Movimientos.movimientos_sistema)
        'TODO: esta línea de código carga datos en la tabla 'Movimientos.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.Movimientos.empleado)

        'TODO: esta línea de código carga datos en la tabla 'Entradas.entrada' Puede moverla o quitarla según sea necesario.
        Me.EntradaTableAdapter.Fill(Me.Entradas.entrada)



        'DATOS QUE SE ENVIARAN AL LOS MOVIMIENTOS DEL SISTEMA'

        'GENERAR ID'
        txtId.Text = Val(Me.Movimientos_sistemaTableAdapter.identificador())
        If txtId.Text = "" Then
            txtId.Text = 0
        End If
        txtId.Text = txtId.Text + 1

        'pasamos la id del usuario que haya accedido'
        txtEmpleado.Text = Acceso.txtUsuario.Text
        txtEmpleado.Text = Val(EmpleadoTableAdapter.idEmpleado(txtEmpleado.Text))
        'VALIDAR AQUE PUESTO PERTENECE QUIEN ENTRO'


        'pasamos el puesto del usuario que haya accedido
        lblPuesto.Text = Acceso.txtUsuario.Text
        lblPuesto.Text = Val(EmpleadoTableAdapter.tipoPuesto(lblPuesto.Text))
        Dim numero As Integer = lblPuesto.Text
        Select Case numero
            Case 1
                lblDescripcion.Text = "Entrada GUARDADA por administrador: " + Acceso.txtUsuario.Text
            Case Else
                lblDescripcion.Text = "Entrada GUARDADA por empleado: " + Acceso.txtUsuario.Text
        End Select

        'termina el validador de casos'
        'generar fecha y hora actual del sistema
        Dim timestamp As Date = Format(Now)
        lblFecha.Text = timestamp.ToString(("dd/MM/yyyy HH:mm:ss"))

        'TERMINA LOS DATOS ENVIADOS'

  


    End Sub


    Private Sub cbxUnidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUnidad.SelectedIndexChanged
        'RECIBE SELECCION DE COMBOBOX TIPOUNIDAD
        lblUnidad.Text = cbxUnidad.SelectedItem
    End Sub
    'VALIDADORES DE TEXTO
    Private Sub cbxProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxProveedor.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxUnidad.KeyPress
        e.Handled = True
    End Sub
    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        Dim resultado As TextBox = DirectCast(sender, TextBox)
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "." And txtPrecio.Text.IndexOf(".") < 0) Or (e.KeyChar = "-" And txtPrecio.Text.Length = 0)) Then
            e.Handled = True

        End If
        Dim validador As Integer
        validador = txtPrecio.TextLength

        If (validador = 8) Then
            txtPrecio.Text = txtPrecio.Text + ".0"
        ElseIf (txtPrecio.Text.IndexOf(".")) Then

        End If


    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        Dim resultado As TextBox = DirectCast(sender, TextBox)
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub



    Private Sub cbxProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProveedor.SelectedIndexChanged
        'RECIBE SELECCION DE COMBO BOX PROVEEDOR
        txtProveedor.Text = cbxProveedor.SelectedValue()
        txtProveedor.Text = Val(Me.ProveedorTableAdapter.consulta_proveedor(txtProveedor.Text))
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (txtNoNota.Text = "" Or txtDescripcion.Text = "" Or txtCantidad.Text = "" Or cbxProveedor.Text = "") Then
            MessageBox.Show("LLENE TODOS LOS CAMPOS")
        Else

            Me.EntradaTableAdapter.Guardar(txtNoNota.Text, txtDescripcion.Text, txtProveedor.Text, txtEmpleado.Text, txtPrecio.Text, txtCantidad.Text, lblUnidad.Text, txtNota.Text, lblFecha.Text)
            Me.EntradaTableAdapter.Fill(Me.Entradas.entrada)
            'AQUI SE REGISTRA EL MOVIMIENTO'

            Me.Movimientos_sistemaTableAdapter.guarda_movimiento(lblTipo.Text, lblDescripcion.Text, lblFecha.Text, txtEmpleado.Text)
            Me.Movimientos_sistemaTableAdapter.Fill(Me.Movimientos.movimientos_sistema)

            'TERMINA REGISTRO'

            txtNoNota.Text = ""
            txtDescripcion.Text = ""
            cbxProveedor.ResetText()
            txtPrecio.Text = ""
            cbxUnidad.ResetText()
            txtNota.Text = ""
            txtCantidad.Text = ""

        End If
    End Sub



End Class