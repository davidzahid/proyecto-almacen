<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporteSalidas
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
        Me.salidas = New proyecto_eura.salidas()
        Me.salidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.salidaTableAdapter = New proyecto_eura.salidasTableAdapters.salidaTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.salidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salidas
        '
        Me.salidas.DataSetName = "salidas"
        Me.salidas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'salidaBindingSource
        '
        Me.salidaBindingSource.DataMember = "salida"
        Me.salidaBindingSource.DataSource = Me.salidas
        '
        'salidaTableAdapter
        '
        Me.salidaTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.salidaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_eura.reporteSalidas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(692, 416)
        Me.ReportViewer1.TabIndex = 0
        '
        'reporteSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 440)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "reporteSalidas"
        Me.Text = "Detalle de Salidas del Almacén"
        CType(Me.salidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents salidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents salidas As proyecto_eura.salidas
    Friend WithEvents salidaTableAdapter As proyecto_eura.salidasTableAdapters.salidaTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
