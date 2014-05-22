<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevaSalida
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.cbxObra = New System.Windows.Forms.ComboBox()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.txtNoSalidas = New System.Windows.Forms.TextBox()
        Me.txtNoNota = New System.Windows.Forms.TextBox()
        Me.EntradaDataGridView = New System.Windows.Forms.DataGridView()
        Me.id_entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.Obra_destinoDataGridView = New System.Windows.Forms.DataGridView()
        Me.SalidaDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNoNotaId = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblPro = New System.Windows.Forms.Label()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.lblPre = New System.Windows.Forms.Label()
        Me.lblNot = New System.Windows.Forms.Label()
        Me.lblFec = New System.Windows.Forms.Label()
        Me.lblDes = New System.Windows.Forms.Label()
        Me.txtObra = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Salidas = New proyecto_eura.salidas()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obra_destinoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EntradaTableAdapter = New proyecto_eura.salidasTableAdapters.entradaTableAdapter()
        Me.TableAdapterManager = New proyecto_eura.salidasTableAdapters.TableAdapterManager()
        Me.Obra_destinoTableAdapter = New proyecto_eura.salidasTableAdapters.obra_destinoTableAdapter()
        Me.SalidaTableAdapter = New proyecto_eura.salidasTableAdapters.salidaTableAdapter()
        Me.Movimientos = New proyecto_eura.movimientos()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New proyecto_eura.movimientosTableAdapters.empleadoTableAdapter()
        Me.TableAdapterManager1 = New proyecto_eura.movimientosTableAdapters.TableAdapterManager()
        Me.EmpleadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Movimientos_sistemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movimientos_sistemaTableAdapter = New proyecto_eura.movimientosTableAdapters.movimientos_sistemaTableAdapter()
        Me.Movimientos_sistemaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblPuesto = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId2 = New System.Windows.Forms.TextBox()
        CType(Me.EntradaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obra_destinoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalidaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obra_destinoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movimientos_sistemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movimientos_sistemaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(45, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(45, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha Salida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(45, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(45, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Obra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(45, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nota"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(45, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Número de Salidas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(45, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Número de Nota"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(136, 51)
        Me.txtId.Name = "txtId"
        Me.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtId.Size = New System.Drawing.Size(177, 20)
        Me.txtId.TabIndex = 1
        Me.txtId.Visible = False
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(136, 84)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFecha.Size = New System.Drawing.Size(177, 20)
        Me.txtFecha.TabIndex = 1
        '
        'txtUnidad
        '
        Me.txtUnidad.Cursor = System.Windows.Forms.Cursors.No
        Me.txtUnidad.Enabled = False
        Me.txtUnidad.Location = New System.Drawing.Point(136, 114)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUnidad.Size = New System.Drawing.Size(177, 20)
        Me.txtUnidad.TabIndex = 1
        '
        'cbxObra
        '
        Me.cbxObra.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Obra_destinoBindingSource, "obra", True))
        Me.cbxObra.DataSource = Me.Obra_destinoBindingSource
        Me.cbxObra.DisplayMember = "obra"
        Me.cbxObra.FormattingEnabled = True
        Me.cbxObra.Location = New System.Drawing.Point(136, 142)
        Me.cbxObra.Name = "cbxObra"
        Me.cbxObra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxObra.Size = New System.Drawing.Size(177, 21)
        Me.cbxObra.TabIndex = 2
        Me.cbxObra.ValueMember = "obra"
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(136, 172)
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNota.Size = New System.Drawing.Size(177, 124)
        Me.txtNota.TabIndex = 3
        '
        'txtNoSalidas
        '
        Me.txtNoSalidas.Enabled = False
        Me.txtNoSalidas.Location = New System.Drawing.Point(213, 311)
        Me.txtNoSalidas.Name = "txtNoSalidas"
        Me.txtNoSalidas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoSalidas.Size = New System.Drawing.Size(100, 20)
        Me.txtNoSalidas.TabIndex = 3
        '
        'txtNoNota
        '
        Me.txtNoNota.Cursor = System.Windows.Forms.Cursors.No
        Me.txtNoNota.Enabled = False
        Me.txtNoNota.Location = New System.Drawing.Point(213, 347)
        Me.txtNoNota.Name = "txtNoNota"
        Me.txtNoNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoNota.Size = New System.Drawing.Size(100, 20)
        Me.txtNoNota.TabIndex = 3
        '
        'EntradaDataGridView
        '
        Me.EntradaDataGridView.AllowUserToDeleteRows = False
        Me.EntradaDataGridView.AutoGenerateColumns = False
        Me.EntradaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EntradaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_entrada, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.proveedor, Me.empleado, Me.precio, Me.nota, Me.fecha})
        Me.EntradaDataGridView.DataSource = Me.EntradaBindingSource
        Me.EntradaDataGridView.Location = New System.Drawing.Point(341, 72)
        Me.EntradaDataGridView.Name = "EntradaDataGridView"
        Me.EntradaDataGridView.ReadOnly = True
        Me.EntradaDataGridView.Size = New System.Drawing.Size(436, 291)
        Me.EntradaDataGridView.TabIndex = 15
        '
        'id_entrada
        '
        Me.id_entrada.DataPropertyName = "id_entrada"
        Me.id_entrada.HeaderText = "id_entrada"
        Me.id_entrada.Name = "id_entrada"
        Me.id_entrada.ReadOnly = True
        Me.id_entrada.Visible = False
        '
        'proveedor
        '
        Me.proveedor.DataPropertyName = "proveedor"
        Me.proveedor.HeaderText = "proveedor"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.ReadOnly = True
        Me.proveedor.Visible = False
        '
        'empleado
        '
        Me.empleado.DataPropertyName = "empleado"
        Me.empleado.HeaderText = "empleado"
        Me.empleado.Name = "empleado"
        Me.empleado.ReadOnly = True
        Me.empleado.Visible = False
        '
        'precio
        '
        Me.precio.DataPropertyName = "precio"
        Me.precio.HeaderText = "precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Visible = False
        '
        'nota
        '
        Me.nota.DataPropertyName = "nota"
        Me.nota.HeaderText = "nota"
        Me.nota.Name = "nota"
        Me.nota.ReadOnly = True
        Me.nota.Visible = False
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Visible = False
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSelect.Location = New System.Drawing.Point(337, 47)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(223, 20)
        Me.lblSelect.TabIndex = 0
        Me.lblSelect.Text = "Selecciona el Número de Nota"
        '
        'Obra_destinoDataGridView
        '
        Me.Obra_destinoDataGridView.AutoGenerateColumns = False
        Me.Obra_destinoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Obra_destinoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Obra_destinoDataGridView.DataSource = Me.Obra_destinoBindingSource
        Me.Obra_destinoDataGridView.Enabled = False
        Me.Obra_destinoDataGridView.Location = New System.Drawing.Point(48, 443)
        Me.Obra_destinoDataGridView.Name = "Obra_destinoDataGridView"
        Me.Obra_destinoDataGridView.Size = New System.Drawing.Size(300, 113)
        Me.Obra_destinoDataGridView.TabIndex = 17
        Me.Obra_destinoDataGridView.Visible = False
        '
        'SalidaDataGridView
        '
        Me.SalidaDataGridView.AutoGenerateColumns = False
        Me.SalidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalidaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.SalidaDataGridView.DataSource = Me.SalidaBindingSource
        Me.SalidaDataGridView.Enabled = False
        Me.SalidaDataGridView.Location = New System.Drawing.Point(376, 443)
        Me.SalidaDataGridView.Name = "SalidaDataGridView"
        Me.SalidaDataGridView.Size = New System.Drawing.Size(410, 113)
        Me.SalidaDataGridView.TabIndex = 18
        Me.SalidaDataGridView.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(238, 386)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 19
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtNoNotaId
        '
        Me.txtNoNotaId.Enabled = False
        Me.txtNoNotaId.Location = New System.Drawing.Point(341, 388)
        Me.txtNoNotaId.Name = "txtNoNotaId"
        Me.txtNoNotaId.Size = New System.Drawing.Size(100, 20)
        Me.txtNoNotaId.TabIndex = 20
        Me.txtNoNotaId.Visible = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(480, 386)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 21
        Me.txtCantidad.Visible = False
        '
        'lblPro
        '
        Me.lblPro.AutoSize = True
        Me.lblPro.Enabled = False
        Me.lblPro.Location = New System.Drawing.Point(117, 640)
        Me.lblPro.Name = "lblPro"
        Me.lblPro.Size = New System.Drawing.Size(13, 13)
        Me.lblPro.TabIndex = 22
        Me.lblPro.Text = "2"
        Me.lblPro.Visible = False
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Enabled = False
        Me.lblEmp.Location = New System.Drawing.Point(117, 676)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(13, 13)
        Me.lblEmp.TabIndex = 22
        Me.lblEmp.Text = "3"
        Me.lblEmp.Visible = False
        '
        'lblPre
        '
        Me.lblPre.AutoSize = True
        Me.lblPre.Enabled = False
        Me.lblPre.Location = New System.Drawing.Point(362, 603)
        Me.lblPre.Name = "lblPre"
        Me.lblPre.Size = New System.Drawing.Size(13, 13)
        Me.lblPre.TabIndex = 22
        Me.lblPre.Text = "4"
        Me.lblPre.Visible = False
        '
        'lblNot
        '
        Me.lblNot.AutoSize = True
        Me.lblNot.Enabled = False
        Me.lblNot.Location = New System.Drawing.Point(362, 626)
        Me.lblNot.Name = "lblNot"
        Me.lblNot.Size = New System.Drawing.Size(13, 13)
        Me.lblNot.TabIndex = 22
        Me.lblNot.Text = "5"
        Me.lblNot.Visible = False
        '
        'lblFec
        '
        Me.lblFec.AutoSize = True
        Me.lblFec.Enabled = False
        Me.lblFec.Location = New System.Drawing.Point(362, 653)
        Me.lblFec.Name = "lblFec"
        Me.lblFec.Size = New System.Drawing.Size(13, 13)
        Me.lblFec.TabIndex = 22
        Me.lblFec.Text = "6"
        Me.lblFec.Visible = False
        '
        'lblDes
        '
        Me.lblDes.AutoSize = True
        Me.lblDes.Enabled = False
        Me.lblDes.Location = New System.Drawing.Point(117, 603)
        Me.lblDes.Name = "lblDes"
        Me.lblDes.Size = New System.Drawing.Size(13, 13)
        Me.lblDes.TabIndex = 22
        Me.lblDes.Text = "1"
        Me.lblDes.Visible = False
        '
        'txtObra
        '
        Me.txtObra.Enabled = False
        Me.txtObra.Location = New System.Drawing.Point(640, 388)
        Me.txtObra.Name = "txtObra"
        Me.txtObra.Size = New System.Drawing.Size(100, 20)
        Me.txtObra.TabIndex = 23
        Me.txtObra.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "id_salida"
        Me.DataGridViewTextBoxColumn9.HeaderText = "id_salida"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fecha_salida"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fecha_salida"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "unidad"
        Me.DataGridViewTextBoxColumn11.HeaderText = "unidad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "obra"
        Me.DataGridViewTextBoxColumn12.HeaderText = "obra"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "nota"
        Me.DataGridViewTextBoxColumn13.HeaderText = "nota"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "num_salidas"
        Me.DataGridViewTextBoxColumn14.HeaderText = "num_salidas"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "entrada"
        Me.DataGridViewTextBoxColumn15.HeaderText = "entrada"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'SalidaBindingSource
        '
        Me.SalidaBindingSource.DataMember = "salida"
        Me.SalidaBindingSource.DataSource = Me.Salidas
        '
        'Salidas
        '
        Me.Salidas.DataSetName = "salidas"
        Me.Salidas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_obra"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_obra"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "obra"
        Me.DataGridViewTextBoxColumn4.HeaderText = "obra"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nota"
        Me.DataGridViewTextBoxColumn6.HeaderText = "nota"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Obra_destinoBindingSource
        '
        Me.Obra_destinoBindingSource.DataMember = "obra_destino"
        Me.Obra_destinoBindingSource.DataSource = Me.Salidas
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "no_nota"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Número de Nota"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "tipo_unidad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'EntradaBindingSource
        '
        Me.EntradaBindingSource.DataMember = "entrada"
        Me.EntradaBindingSource.DataSource = Me.Salidas
        '
        'EntradaTableAdapter
        '
        Me.EntradaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.entradaTableAdapter = Me.EntradaTableAdapter
        Me.TableAdapterManager.obra_destinoTableAdapter = Nothing
        Me.TableAdapterManager.salidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = proyecto_eura.salidasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Obra_destinoTableAdapter
        '
        Me.Obra_destinoTableAdapter.ClearBeforeFill = True
        '
        'SalidaTableAdapter
        '
        Me.SalidaTableAdapter.ClearBeforeFill = True
        '
        'Movimientos
        '
        Me.Movimientos.DataSetName = "movimientos"
        Me.Movimientos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.Movimientos
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.empleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager1.movimientos_sistemaTableAdapter = Me.Movimientos_sistemaTableAdapter
        Me.TableAdapterManager1.UpdateOrder = proyecto_eura.movimientosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpleadoDataGridView
        '
        Me.EmpleadoDataGridView.AutoGenerateColumns = False
        Me.EmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.EmpleadoDataGridView.DataSource = Me.EmpleadoBindingSource
        Me.EmpleadoDataGridView.Enabled = False
        Me.EmpleadoDataGridView.Location = New System.Drawing.Point(855, 377)
        Me.EmpleadoDataGridView.Name = "EmpleadoDataGridView"
        Me.EmpleadoDataGridView.Size = New System.Drawing.Size(300, 72)
        Me.EmpleadoDataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "id_empleado"
        Me.DataGridViewTextBoxColumn16.HeaderText = "id_empleado"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn17.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn18.HeaderText = "username"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn19.HeaderText = "password"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "puesto"
        Me.DataGridViewTextBoxColumn20.HeaderText = "puesto"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn21.HeaderText = "status"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'Movimientos_sistemaBindingSource
        '
        Me.Movimientos_sistemaBindingSource.DataMember = "movimientos_sistema"
        Me.Movimientos_sistemaBindingSource.DataSource = Me.Movimientos
        '
        'Movimientos_sistemaTableAdapter
        '
        Me.Movimientos_sistemaTableAdapter.ClearBeforeFill = True
        '
        'Movimientos_sistemaDataGridView
        '
        Me.Movimientos_sistemaDataGridView.AutoGenerateColumns = False
        Me.Movimientos_sistemaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Movimientos_sistemaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.Movimientos_sistemaDataGridView.DataSource = Me.Movimientos_sistemaBindingSource
        Me.Movimientos_sistemaDataGridView.Enabled = False
        Me.Movimientos_sistemaDataGridView.Location = New System.Drawing.Point(855, 464)
        Me.Movimientos_sistemaDataGridView.Name = "Movimientos_sistemaDataGridView"
        Me.Movimientos_sistemaDataGridView.Size = New System.Drawing.Size(300, 92)
        Me.Movimientos_sistemaDataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "id_movimiento"
        Me.DataGridViewTextBoxColumn22.HeaderText = "id_movimiento"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn23.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn24.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn25.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "empleado"
        Me.DataGridViewTextBoxColumn26.HeaderText = "empleado"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'lblPuesto
        '
        Me.lblPuesto.AutoSize = True
        Me.lblPuesto.Enabled = False
        Me.lblPuesto.Location = New System.Drawing.Point(857, 305)
        Me.lblPuesto.Name = "lblPuesto"
        Me.lblPuesto.Size = New System.Drawing.Size(40, 13)
        Me.lblPuesto.TabIndex = 39
        Me.lblPuesto.Text = "Puesto"
        Me.lblPuesto.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Enabled = False
        Me.lblDescripcion.Location = New System.Drawing.Point(857, 271)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 38
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.Visible = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Enabled = False
        Me.lblTipo.Location = New System.Drawing.Point(854, 238)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(93, 13)
        Me.lblTipo.TabIndex = 37
        Me.lblTipo.Text = "Registro de Salida"
        Me.lblTipo.Visible = False
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Location = New System.Drawing.Point(1038, 289)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpleado.TabIndex = 36
        Me.txtEmpleado.Visible = False
        '
        'txtProveedor
        '
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Location = New System.Drawing.Point(1038, 319)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(100, 20)
        Me.txtProveedor.TabIndex = 35
        Me.txtProveedor.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(976, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Proveedor"
        Me.Label8.Visible = False
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Enabled = False
        Me.lblEmpleado.Location = New System.Drawing.Point(976, 296)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(54, 13)
        Me.lblEmpleado.TabIndex = 33
        Me.lblEmpleado.Text = "Empleado"
        Me.lblEmpleado.Visible = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Enabled = False
        Me.lblFecha.Location = New System.Drawing.Point(860, 341)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 32
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.Visible = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Enabled = False
        Me.lblId.Location = New System.Drawing.Point(976, 241)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(56, 13)
        Me.lblId.TabIndex = 31
        Me.lblId.Text = "Id Entrada"
        Me.lblId.Visible = False
        '
        'txtId2
        '
        Me.txtId2.Enabled = False
        Me.txtId2.Location = New System.Drawing.Point(1038, 238)
        Me.txtId2.MaxLength = 10
        Me.txtId2.Name = "txtId2"
        Me.txtId2.Size = New System.Drawing.Size(100, 20)
        Me.txtId2.TabIndex = 30
        Me.txtId2.Visible = False
        '
        'nuevaSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(832, 433)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPuesto)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.txtEmpleado)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtId2)
        Me.Controls.Add(Me.Movimientos_sistemaDataGridView)
        Me.Controls.Add(Me.EmpleadoDataGridView)
        Me.Controls.Add(Me.txtObra)
        Me.Controls.Add(Me.lblFec)
        Me.Controls.Add(Me.lblNot)
        Me.Controls.Add(Me.lblPre)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.lblPro)
        Me.Controls.Add(Me.lblDes)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtNoNotaId)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.SalidaDataGridView)
        Me.Controls.Add(Me.Obra_destinoDataGridView)
        Me.Controls.Add(Me.EntradaDataGridView)
        Me.Controls.Add(Me.txtNoNota)
        Me.Controls.Add(Me.txtNoSalidas)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.cbxObra)
        Me.Controls.Add(Me.txtUnidad)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "nuevaSalida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Salida"
        CType(Me.EntradaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obra_destinoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalidaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obra_destinoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movimientos_sistemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movimientos_sistemaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents cbxObra As System.Windows.Forms.ComboBox
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSalidas As System.Windows.Forms.TextBox
    Friend WithEvents txtNoNota As System.Windows.Forms.TextBox
    Friend WithEvents Salidas As proyecto_eura.salidas
    Friend WithEvents EntradaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EntradaTableAdapter As proyecto_eura.salidasTableAdapters.entradaTableAdapter
    Friend WithEvents TableAdapterManager As proyecto_eura.salidasTableAdapters.TableAdapterManager
    Friend WithEvents EntradaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents Obra_destinoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Obra_destinoTableAdapter As proyecto_eura.salidasTableAdapters.obra_destinoTableAdapter
    Friend WithEvents Obra_destinoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalidaTableAdapter As proyecto_eura.salidasTableAdapters.salidaTableAdapter
    Friend WithEvents SalidaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtNoNotaId As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblPro As System.Windows.Forms.Label
    Friend WithEvents lblEmp As System.Windows.Forms.Label
    Friend WithEvents lblPre As System.Windows.Forms.Label
    Friend WithEvents lblNot As System.Windows.Forms.Label
    Friend WithEvents lblFec As System.Windows.Forms.Label
    Friend WithEvents lblDes As System.Windows.Forms.Label
    Friend WithEvents id_entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtObra As System.Windows.Forms.TextBox
    Friend WithEvents Movimientos As proyecto_eura.movimientos
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As proyecto_eura.movimientosTableAdapters.empleadoTableAdapter
    Friend WithEvents TableAdapterManager1 As proyecto_eura.movimientosTableAdapters.TableAdapterManager
    Friend WithEvents Movimientos_sistemaTableAdapter As proyecto_eura.movimientosTableAdapters.movimientos_sistemaTableAdapter
    Friend WithEvents EmpleadoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Movimientos_sistemaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Movimientos_sistemaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblPuesto As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId2 As System.Windows.Forms.TextBox
End Class
