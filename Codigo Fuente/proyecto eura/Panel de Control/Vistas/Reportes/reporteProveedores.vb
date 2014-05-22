Public Class reporteProveedores

    Private Sub reporteProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'entradas.proveedor' Puede moverla o quitarla según sea necesario.
        Me.proveedorTableAdapter.Fill(Me.entradas.proveedor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class