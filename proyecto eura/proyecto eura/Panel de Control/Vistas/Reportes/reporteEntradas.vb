Public Class reporteEntradas

    Private Sub reporteEntradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'entradas.entrada' Puede moverla o quitarla según sea necesario.
        Me.entradaTableAdapter.Fill(Me.entradas.entrada)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class