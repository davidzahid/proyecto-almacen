Public Class nuevaSalida

    Private Sub EntradaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EntradaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Salidas)

    End Sub

    Private Sub nuevaSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Salidas.salida' Puede moverla o quitarla según sea necesario.
        Me.SalidaTableAdapter.Fill(Me.Salidas.salida)
        'TODO: esta línea de código carga datos en la tabla 'Salidas.obra_destino' Puede moverla o quitarla según sea necesario.
        Me.Obra_destinoTableAdapter.Fill(Me.Salidas.obra_destino)
        'TODO: esta línea de código carga datos en la tabla 'Salidas.entrada' Puede moverla o quitarla según sea necesario.
        Me.EntradaTableAdapter.Fill(Me.Salidas.entrada)



    End Sub

    Private Sub EntradaDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EntradaDataGridView.CellClick

        'generar fecha y hora actual del sistema
        Dim timestamp As Date = Format(Now)
        txtFecha.Text = timestamp.ToString(("dd/MM/yyyy HH:mm tt"))
        txtNoNotaId.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(0).Value()
        txtNoNota.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(1).Value()
        txtCantidad.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(3).Value()
        txtUnidad.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(4).Value()
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
        Try
            If (txtCantidad.Text < txtNoSalidas.Text) Then
                MessageBox.Show("Cantidad Disponible:" + txtCantidad.Text)
                txtNoSalidas.Text = ""
            ElseIf (txtNoSalidas.Text = "") Then
                MessageBox.Show("Inserte un Número de salidas")
            ElseIf (txtNoSalidas.Text = 0) Then
                MessageBox.Show("Intento fallido")
                txtNoSalidas.Text = ""
            Else

                txtCantidad.Text = txtCantidad.Text - txtNoSalidas.Text
                MessageBox.Show("Operación realizada con exito")



            End If
        Catch ex As Exception

        End Try
  
    End Sub
End Class