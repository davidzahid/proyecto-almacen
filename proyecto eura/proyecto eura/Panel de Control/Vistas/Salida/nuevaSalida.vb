Public Class nuevaSalida

    Private Sub EntradaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EntradaBindingNavigatorSaveItem.Click
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
        txtNoNota.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(0).Value()
        txtUnidad.Text = Me.EntradaDataGridView.Rows(e.RowIndex).Cells(3).Value()

        'GENERA ID'
        txtId.Text = Val(Me.SalidaTableAdapter.identificador())

        If txtId.Text = "" Then
            txtId.Text = 0
        End If
        txtId.Text = txtId.Text + 1





    End Sub



   
    

End Class