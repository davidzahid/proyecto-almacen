<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporteEntradas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.entradas = New proyecto_eura.entradas()
        Me.entradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.entradaTableAdapter = New proyecto_eura.entradasTableAdapters.entradaTableAdapter()
        CType(Me.entradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.entradaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_eura.reporte_entradas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(19, 10)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(676, 424)
        Me.ReportViewer1.TabIndex = 0
        '
        'entradas
        '
        Me.entradas.DataSetName = "entradas"
        Me.entradas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'entradaBindingSource
        '
        Me.entradaBindingSource.DataMember = "entrada"
        Me.entradaBindingSource.DataSource = Me.entradas
        '
        'entradaTableAdapter
        '
        Me.entradaTableAdapter.ClearBeforeFill = True
        '
        'reporteEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 440)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "reporteEntradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Entradas"
        CType(Me.entradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents entradaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents entradas As proyecto_eura.entradas
    Friend WithEvents entradaTableAdapter As proyecto_eura.entradasTableAdapters.entradaTableAdapter
End Class
