Public Class gestionObras

    Private Sub Obra_destinoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Obra_destinoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Obra_destinoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Salidas)

    End Sub

    Private Sub gestionObras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Salidas.obra_destino' Puede moverla o quitarla según sea necesario.
        Me.Obra_destinoTableAdapter.Fill(Me.Salidas.obra_destino)

    End Sub


End Class