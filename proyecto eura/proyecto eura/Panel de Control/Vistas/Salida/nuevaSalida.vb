Public Class nuevaSalida

    Private Sub EntradaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EntradaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EntradaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Salidas)

    End Sub

    Private Sub nuevaSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Salidas.entrada' Puede moverla o quitarla según sea necesario.
        Me.EntradaTableAdapter.Fill(Me.Salidas.entrada)

    End Sub
End Class