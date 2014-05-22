Public Class reporteSalidas

    Private Sub reporteSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'salidas.salida' Puede moverla o quitarla según sea necesario.
        Me.salidaTableAdapter.Fill(Me.salidas.salida)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class