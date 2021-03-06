﻿Public Class nuevaSalida

    Private Sub EntradaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EntradaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Salidas)

    End Sub

    Private Sub nuevaSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Movimientos.movimientos_sistema' Puede moverla o quitarla según sea necesario.
        Me.Movimientos_sistemaTableAdapter.Fill(Me.Movimientos.movimientos_sistema)
        'TODO: esta línea de código carga datos en la tabla 'Movimientos.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.Movimientos.empleado)
        'TODO: esta línea de código carga datos en la tabla 'Salidas.salida' Puede moverla o quitarla según sea necesario.
        Me.SalidaTableAdapter.Fill(Me.Salidas.salida)
        'TODO: esta línea de código carga datos en la tabla 'Salidas.obra_destino' Puede moverla o quitarla según sea necesario.
        Me.Obra_destinoTableAdapter.Fill(Me.Salidas.obra_destino)
        'TODO: esta línea de código carga datos en la tabla 'Salidas.entrada' Puede moverla o quitarla según sea necesario.
        Me.EntradaTableAdapter.Fill(Me.Salidas.entrada)

        'DATOS QUE SE ENVIARAN AL LOS MOVIMIENTOS DEL SISTEMA'

        'GENERAR ID'
        txtId2.Text = Val(Me.Movimientos_sistemaTableAdapter.identificador())
        If txtId2.Text = "" Then
            txtId2.Text = 0
        End If
        txtId2.Text = txtId2.Text + 1

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
                lblDescripcion.Text = "Salida GUARDADA por administrador: " + Acceso.txtUsuario.Text
            Case Else
                lblDescripcion.Text = "Salida GUARDADA por empleado: " + Acceso.txtUsuario.Text
        End Select

        'termina el validador de casos'
        'generar fecha y hora actual del sistema
        Dim timestamp As Date = Format(Now)
        lblFecha.Text = timestamp.ToString(("dd/MM/yyyy HH:mm:ss"))

        'TERMINA LOS DATOS ENVIADOS'


    End Sub

    Private Sub EntradaDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EntradaDataGridView.CellClick

        'generar fecha y hora actual del sistema
        Dim timestamp As Date = Format(Now)
        txtFecha.Text = timestamp.ToString(("dd/MM/yyyy HH:mm tt"))
        txtNoNotaId.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(0).Value()
        txtNoNota.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(1).Value()
        lblDes.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(2).Value()
        txtCantidad.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(3).Value()
        txtUnidad.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(4).Value()
        lblPro.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(5).Value()
        lblEmp.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(6).Value()
        lblPre.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(7).Value()
        lblNot.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(8).Value()
        lblFec.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(9).Value()

        txtNoSalidas.Enabled = True
        'GENERA ID'
        txtId.Text = Val(Me.SalidaTableAdapter.identificador())

        If txtId.Text = "" Then
            txtId.Text = 0
        End If
        txtId.Text = txtId.Text + 1

        'cantidad'

    End Sub


    Private Sub txtNoSalidas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoSalidas.KeyPress
        Dim resultado As TextBox = DirectCast(sender, TextBox)
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub


    Private Sub cbxObra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxObra.KeyPress
        e.Handled = True
    End Sub




    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'VALIDAR '

        If (txtCantidad.Text < txtNoSalidas.Text) Then
            MessageBox.Show("Cantidad Disponible:" + txtCantidad.Text)
            txtNoSalidas.Text = ""
        ElseIf (txtNoSalidas.Text = "") Then
            MessageBox.Show("Inserte un Número de salidas")
        ElseIf (txtNoSalidas.Text = 0) Then
            MessageBox.Show("Intento fallido")
            txtNoSalidas.Text = ""
        Else
            If (txtObra.Text = "") Then
                MessageBox.Show("Por favor seleccione obra de destino")
            Else
                txtCantidad.Text = txtCantidad.Text - txtNoSalidas.Text


                Dim Mensaje, Estilo, Título, Respuesta, MiCadena
                Mensaje = "¿Esta seguro que desea realizar esta operación?"
                Estilo = vbYesNo + vbCritical
                Título = "ADVERTENCIA"
                Respuesta = MsgBox(Mensaje, Estilo, Título)
                If Respuesta = vbYes Then
                    MiCadena = "S"


                    Me.EntradaTableAdapter.actualizar(txtNoNota.Text, lblDes.Text, lblPro.Text, lblEmp.Text, lblPre.Text, txtCantidad.Text, txtUnidad.Text, lblNot.Text, lblFec.Text, txtNoNotaId.Text)
                    Me.EntradaTableAdapter.Fill(Me.Salidas.entrada)

                    Me.SalidaTableAdapter.guardar_salida(txtId.Text, txtFecha.Text, txtUnidad.Text, txtObra.Text, txtNota.Text, txtNoSalidas.Text, txtNoNotaId.Text)
                    Me.SalidaTableAdapter.Fill(Me.Salidas.salida)

                    'AQUI SE REGISTRA EL MOVIMIENTO'

                    Me.Movimientos_sistemaTableAdapter.guarda_movimiento(lblTipo.Text, lblDescripcion.Text, lblFecha.Text, txtEmpleado.Text)
                    Me.Movimientos_sistemaTableAdapter.Fill(Me.Movimientos.movimientos_sistema)

                    txtObra.Text = ""
                    txtNoSalidas.Text = ""
                    txtNota.Text = ""
                    txtNoNotaId.Text = ""

                    EntradaDataGridView.ClearSelection()
                    EntradaDataGridView.Refresh()



                Else

                End If
            End If

        End If



        'AQUI SE REALIZARA LA ACTUALIZACIÓN

    End Sub


    Private Sub cbxObra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxObra.SelectedIndexChanged
        txtObra.Text = cbxObra.SelectedValue()
        txtObra.Text = Val(Me.Obra_destinoTableAdapter.id_de_obra(txtObra.Text))
    End Sub
End Class