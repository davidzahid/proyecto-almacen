<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporteProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reporteProveedores))
        Me.entradas = New proyecto_eura.entradas()
        Me.proveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.proveedorTableAdapter = New proyecto_eura.entradasTableAdapters.proveedorTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.entradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.proveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'entradas
        '
        Me.entradas.DataSetName = "entradas"
        Me.entradas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'proveedorBindingSource
        '
        Me.proveedorBindingSource.DataMember = "proveedor"
        Me.proveedorBindingSource.DataSource = Me.entradas
        '
        'proveedorTableAdapter
        '
        Me.proveedorTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.proveedorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_eura.reporteProveedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(692, 405)
        Me.ReportViewer1.TabIndex = 0
        '
        'reporteProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 440)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "reporteProveedores"
        Me.Text = "Detalle de Proveedores"
        CType(Me.entradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.proveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents proveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents entradas As proyecto_eura.entradas
    Friend WithEvents proveedorTableAdapter As proyecto_eura.entradasTableAdapters.proveedorTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
