Public Class reporteEntradasAlmacen

    Private Sub reporteMovimentosSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'movimientos.movimientos_sistema' Puede moverla o quitarla según sea necesario.
        Me.movimientos_sistemaTableAdapter.Fill(Me.movimientos.movimientos_sistema)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class