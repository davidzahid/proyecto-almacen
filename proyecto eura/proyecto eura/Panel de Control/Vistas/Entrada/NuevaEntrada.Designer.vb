<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaEntrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevaEntrada))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.EntradaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.EntradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Entradas = New proyecto_eura.entradas()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EntradaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EntradaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtNoNota = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cbxProveedor = New System.Windows.Forms.ComboBox()
        Me.ProveedorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Entradas1 = New proyecto_eura.entradas()
        Me.ProveedorBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cbxUnidad = New System.Windows.Forms.ComboBox()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.Movimientos = New proyecto_eura.movimientos()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New proyecto_eura.movimientosTableAdapters.empleadoTableAdapter()
        Me.TableAdapterManager1 = New proyecto_eura.movimientosTableAdapters.TableAdapterManager()
        Me.Movimientos_sistemaTableAdapter = New proyecto_eura.movimientosTableAdapters.movimientos_sistemaTableAdapter()
        Me.EmpleadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Movimientos_sistemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movimientos_sistemaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblPuesto = New System.Windows.Forms.Label()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.EntradaTableAdapter = New proyecto_eura.entradasTableAdapters.entradaTableAdapter()
        Me.TableAdapterManager = New proyecto_eura.entradasTableAdapters.TableAdapterManager()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New proyecto_eura.entradasTableAdapters.proveedorTableAdapter()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.EntradaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EntradaBindingNavigator.SuspendLayout()
        CType(Me.EntradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Entradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Entradas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movimientos_sistemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movimientos_sistemaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'EntradaBindingNavigator
        '
        Me.EntradaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EntradaBindingNavigator.BindingSource = Me.EntradaBindingSource
        Me.EntradaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EntradaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EntradaBindingNavigator.Enabled = False
        Me.EntradaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EntradaBindingNavigatorSaveItem})
        Me.EntradaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EntradaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EntradaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EntradaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EntradaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EntradaBindingNavigator.Name = "EntradaBindingNavigator"
        Me.EntradaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EntradaBindingNavigator.Size = New System.Drawing.Size(1051, 25)
        Me.EntradaBindingNavigator.TabIndex = 0
        Me.EntradaBindingNavigator.Text = "BindingNavigator1"
        Me.EntradaBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'EntradaBindingSource
        '
        Me.EntradaBindingSource.DataMember = "entrada"
        Me.EntradaBindingSource.DataSource = Me.Entradas
        '
        'Entradas
        '
        Me.Entradas.DataSetName = "entradas"
        Me.Entradas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EntradaBindingNavigatorSaveItem
        '
        Me.EntradaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EntradaBindingNavigatorSaveItem.Image = CType(resources.GetObject("EntradaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EntradaBindingNavigatorSaveItem.Name = "EntradaBindingNavigatorSaveItem"
        Me.EntradaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EntradaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EntradaDataGridView
        '
        Me.EntradaDataGridView.AutoGenerateColumns = False
        Me.EntradaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EntradaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.EntradaDataGridView.DataSource = Me.EntradaBindingSource
        Me.EntradaDataGridView.Enabled = False
        Me.EntradaDataGridView.Location = New System.Drawing.Point(721, 290)
        Me.EntradaDataGridView.Name = "EntradaDataGridView"
        Me.EntradaDataGridView.Size = New System.Drawing.Size(310, 261)
        Me.EntradaDataGridView.TabIndex = 1
        Me.EntradaDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_entrada"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_entrada"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "no_nota"
        Me.DataGridViewTextBoxColumn2.HeaderText = "no_nota"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "proveedor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "proveedor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "empleado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "empleado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "tipo_unidad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "tipo_unidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "nota"
        Me.DataGridViewTextBoxColumn9.HeaderText = "nota"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(768, 22)
        Me.txtId.MaxLength = 10
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 2
        Me.txtId.Visible = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Enabled = False
        Me.lblId.Location = New System.Drawing.Point(706, 25)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(56, 13)
        Me.lblId.TabIndex = 3
        Me.lblId.Text = "Id Entrada"
        Me.lblId.Visible = False
        '
        'txtNoNota
        '
        Me.txtNoNota.Location = New System.Drawing.Point(230, 46)
        Me.txtNoNota.MaxLength = 10
        Me.txtNoNota.Name = "txtNoNota"
        Me.txtNoNota.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNoNota.Size = New System.Drawing.Size(100, 20)
        Me.txtNoNota.TabIndex = 4
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Enabled = False
        Me.lblFecha.Location = New System.Drawing.Point(590, 125)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.Visible = False
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Location = New System.Drawing.Point(122, 49)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(85, 13)
        Me.lblNota.TabIndex = 6
        Me.lblNota.Text = "Número de Nota"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Descripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Proveedor"
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Enabled = False
        Me.lblEmpleado.Location = New System.Drawing.Point(706, 80)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(54, 13)
        Me.lblEmpleado.TabIndex = 9
        Me.lblEmpleado.Text = "Empleado"
        Me.lblEmpleado.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tipo de Unidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nota"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(114, 73)
        Me.txtDescripcion.MaxLength = 60
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDescripcion.Size = New System.Drawing.Size(216, 20)
        Me.txtDescripcion.TabIndex = 14
        '
        'cbxProveedor
        '
        Me.cbxProveedor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProveedorBindingSource1, "nombre_proveedor", True))
        Me.cbxProveedor.DataSource = Me.ProveedorBindingSource2
        Me.cbxProveedor.DisplayMember = "nombre_proveedor"
        Me.cbxProveedor.FormattingEnabled = True
        Me.cbxProveedor.Location = New System.Drawing.Point(114, 98)
        Me.cbxProveedor.Name = "cbxProveedor"
        Me.cbxProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxProveedor.Size = New System.Drawing.Size(216, 21)
        Me.cbxProveedor.TabIndex = 15
        Me.cbxProveedor.ValueMember = "nombre_proveedor"
        '
        'ProveedorBindingSource1
        '
        Me.ProveedorBindingSource1.DataMember = "proveedor"
        Me.ProveedorBindingSource1.DataSource = Me.Entradas1
        '
        'Entradas1
        '
        Me.Entradas1.DataSetName = "entradas"
        Me.Entradas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource2
        '
        Me.ProveedorBindingSource2.DataMember = "proveedor"
        Me.ProveedorBindingSource2.DataSource = Me.Entradas1
        '
        'txtPrecio
        '
        Me.txtPrecio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPrecio.Location = New System.Drawing.Point(114, 125)
        Me.txtPrecio.MaxLength = 8
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPrecio.Size = New System.Drawing.Size(216, 20)
        Me.txtPrecio.TabIndex = 16
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(114, 152)
        Me.txtCantidad.MaxLength = 10
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCantidad.Size = New System.Drawing.Size(216, 20)
        Me.txtCantidad.TabIndex = 17
        '
        'cbxUnidad
        '
        Me.cbxUnidad.FormattingEnabled = True
        Me.cbxUnidad.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Metro", "Metro Cuadrado", "Metro Cubico", "Centimetro", "Centimetro Cuadrado", "Mililitros", "Litro"})
        Me.cbxUnidad.Location = New System.Drawing.Point(114, 179)
        Me.cbxUnidad.Name = "cbxUnidad"
        Me.cbxUnidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxUnidad.Size = New System.Drawing.Size(216, 21)
        Me.cbxUnidad.TabIndex = 18
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(114, 212)
        Me.txtNota.MaxLength = 255
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNota.Size = New System.Drawing.Size(216, 96)
        Me.txtNota.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(706, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Proveedor"
        Me.Label3.Visible = False
        '
        'txtProveedor
        '
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Location = New System.Drawing.Point(768, 103)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(100, 20)
        Me.txtProveedor.TabIndex = 21
        Me.txtProveedor.Visible = False
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Location = New System.Drawing.Point(768, 73)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpleado.TabIndex = 22
        Me.txtEmpleado.Visible = False
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
        'Movimientos_sistemaTableAdapter
        '
        Me.Movimientos_sistemaTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoDataGridView
        '
        Me.EmpleadoDataGridView.AutoGenerateColumns = False
        Me.EmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.EmpleadoDataGridView.DataSource = Me.EmpleadoBindingSource
        Me.EmpleadoDataGridView.Enabled = False
        Me.EmpleadoDataGridView.Location = New System.Drawing.Point(455, 147)
        Me.EmpleadoDataGridView.Name = "EmpleadoDataGridView"
        Me.EmpleadoDataGridView.Size = New System.Drawing.Size(508, 70)
        Me.EmpleadoDataGridView.TabIndex = 23
        Me.EmpleadoDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "id_empleado"
        Me.DataGridViewTextBoxColumn11.HeaderText = "id_empleado"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn12.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn13.HeaderText = "username"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn14.HeaderText = "password"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "puesto"
        Me.DataGridViewTextBoxColumn15.HeaderText = "puesto"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn16.HeaderText = "status"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Movimientos_sistemaBindingSource
        '
        Me.Movimientos_sistemaBindingSource.DataMember = "movimientos_sistema"
        Me.Movimientos_sistemaBindingSource.DataSource = Me.Movimientos
        '
        'Movimientos_sistemaDataGridView
        '
        Me.Movimientos_sistemaDataGridView.AutoGenerateColumns = False
        Me.Movimientos_sistemaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Movimientos_sistemaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.Movimientos_sistemaDataGridView.DataSource = Me.Movimientos_sistemaBindingSource
        Me.Movimientos_sistemaDataGridView.Enabled = False
        Me.Movimientos_sistemaDataGridView.Location = New System.Drawing.Point(455, 220)
        Me.Movimientos_sistemaDataGridView.Name = "Movimientos_sistemaDataGridView"
        Me.Movimientos_sistemaDataGridView.Size = New System.Drawing.Size(520, 68)
        Me.Movimientos_sistemaDataGridView.TabIndex = 24
        Me.Movimientos_sistemaDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "id_movimiento"
        Me.DataGridViewTextBoxColumn17.HeaderText = "id_movimiento"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn18.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn19.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn20.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "empleado"
        Me.DataGridViewTextBoxColumn21.HeaderText = "empleado"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Enabled = False
        Me.lblTipo.Location = New System.Drawing.Point(584, 22)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(101, 13)
        Me.lblTipo.TabIndex = 25
        Me.lblTipo.Text = "Registro de Entrada"
        Me.lblTipo.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Enabled = False
        Me.lblDescripcion.Location = New System.Drawing.Point(587, 55)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 26
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.Visible = False
        '
        'lblPuesto
        '
        Me.lblPuesto.AutoSize = True
        Me.lblPuesto.Enabled = False
        Me.lblPuesto.Location = New System.Drawing.Point(587, 89)
        Me.lblPuesto.Name = "lblPuesto"
        Me.lblPuesto.Size = New System.Drawing.Size(40, 13)
        Me.lblPuesto.TabIndex = 27
        Me.lblPuesto.Text = "Puesto"
        Me.lblPuesto.Visible = False
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Enabled = False
        Me.lblUnidad.Location = New System.Drawing.Point(452, 22)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(41, 13)
        Me.lblUnidad.TabIndex = 28
        Me.lblUnidad.Text = "Unidad"
        Me.lblUnidad.Visible = False
        '
        'EntradaTableAdapter
        '
        Me.EntradaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.entradaTableAdapter = Me.EntradaTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = proyecto_eura.entradasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.Entradas
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.Location = New System.Drawing.Point(255, 343)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 29
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmNuevaEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(362, 397)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblUnidad)
        Me.Controls.Add(Me.lblPuesto)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.Movimientos_sistemaDataGridView)
        Me.Controls.Add(Me.EmpleadoDataGridView)
        Me.Controls.Add(Me.txtEmpleado)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.cbxUnidad)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.cbxProveedor)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtNoNota)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.EntradaDataGridView)
        Me.Controls.Add(Me.EntradaBindingNavigator)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNuevaEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Entrada"
        CType(Me.EntradaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EntradaBindingNavigator.ResumeLayout(False)
        Me.EntradaBindingNavigator.PerformLayout()
        CType(Me.EntradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Entradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Entradas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movimientos_sistemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movimientos_sistemaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Entradas As proyecto_eura.entradas
    Friend WithEvents EntradaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EntradaTableAdapter As proyecto_eura.entradasTableAdapters.entradaTableAdapter
    Friend WithEvents TableAdapterManager As proyecto_eura.entradasTableAdapters.TableAdapterManager
    Friend WithEvents EntradaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EntradaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EntradaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtNoNota As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblNota As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cbxProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents cbxUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Movimientos As proyecto_eura.movimientos
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As proyecto_eura.movimientosTableAdapters.empleadoTableAdapter
    Friend WithEvents TableAdapterManager1 As proyecto_eura.movimientosTableAdapters.TableAdapterManager
    Friend WithEvents Movimientos_sistemaTableAdapter As proyecto_eura.movimientosTableAdapters.movimientos_sistemaTableAdapter
    Friend WithEvents EmpleadoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Movimientos_sistemaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Movimientos_sistemaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblPuesto As System.Windows.Forms.Label
    Friend WithEvents lblUnidad As System.Windows.Forms.Label
    Friend WithEvents ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorTableAdapter As proyecto_eura.entradasTableAdapters.proveedorTableAdapter
    Friend WithEvents Entradas1 As proyecto_eura.entradas
    Friend WithEvents ProveedorBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
