<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporteMovimentosSistema
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
        Me.movimientos = New proyecto_eura.movimientos()
        Me.movimientos_sistemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.movimientos_sistemaTableAdapter = New proyecto_eura.movimientosTableAdapters.movimientos_sistemaTableAdapter()
        CType(Me.movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.movimientos_sistemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.movimientos_sistemaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_eura.movimientos_sistema.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(18, 7)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(676, 424)
        Me.ReportViewer1.TabIndex = 0
        '
        'movimientos
        '
        Me.movimientos.DataSetName = "movimientos"
        Me.movimientos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'movimientos_sistemaBindingSource
        '
        Me.movimientos_sistemaBindingSource.DataMember = "movimientos_sistema"
        Me.movimientos_sistemaBindingSource.DataSource = Me.movimientos
        '
        'movimientos_sistemaTableAdapter
        '
        Me.movimientos_sistemaTableAdapter.ClearBeforeFill = True
        '
        'reporteMovimentosSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 440)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "reporteMovimentosSistema"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Movimientos del Sistema"
        CType(Me.movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.movimientos_sistemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents movimientos_sistemaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents movimientos As proyecto_eura.movimientos
    Friend WithEvents movimientos_sistemaTableAdapter As proyecto_eura.movimientosTableAdapters.movimientos_sistemaTableAdapter
End Class
