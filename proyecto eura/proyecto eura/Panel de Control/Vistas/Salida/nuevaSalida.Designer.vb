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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nuevaSalida))
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
        Me.Obra_destinoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Salidas = New proyecto_eura.salidas()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.txtNoSalidas = New System.Windows.Forms.TextBox()
        Me.txtNoNota = New System.Windows.Forms.TextBox()
        Me.EntradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EntradaTableAdapter = New proyecto_eura.salidasTableAdapters.entradaTableAdapter()
        Me.TableAdapterManager = New proyecto_eura.salidasTableAdapters.TableAdapterManager()
        Me.EntradaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.Obra_destinoTableAdapter = New proyecto_eura.salidasTableAdapters.obra_destinoTableAdapter()
        Me.Obra_destinoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalidaTableAdapter = New proyecto_eura.salidasTableAdapters.salidaTableAdapter()
        Me.SalidaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNoNotaId = New System.Windows.Forms.TextBox()
        CType(Me.Obra_destinoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EntradaBindingNavigator.SuspendLayout()
        CType(Me.EntradaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obra_destinoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalidaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(45, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
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
        Me.txtId.Location = New System.Drawing.Point(136, 51)
        Me.txtId.Name = "txtId"
        Me.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtId.Size = New System.Drawing.Size(177, 20)
        Me.txtId.TabIndex = 1
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
        'Obra_destinoBindingSource
        '
        Me.Obra_destinoBindingSource.DataMember = "obra_destino"
        Me.Obra_destinoBindingSource.DataSource = Me.Salidas
        '
        'Salidas
        '
        Me.Salidas.DataSetName = "salidas"
        Me.Salidas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'EntradaBindingNavigator
        '
        Me.EntradaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EntradaBindingNavigator.BindingSource = Me.EntradaBindingSource
        Me.EntradaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EntradaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EntradaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EntradaBindingNavigatorSaveItem})
        Me.EntradaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EntradaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EntradaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EntradaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EntradaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EntradaBindingNavigator.Name = "EntradaBindingNavigator"
        Me.EntradaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EntradaBindingNavigator.Size = New System.Drawing.Size(862, 25)
        Me.EntradaBindingNavigator.TabIndex = 4
        Me.EntradaBindingNavigator.Text = "BindingNavigator1"
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
        Me.EntradaDataGridView.AllowUserToDeleteRows = False
        Me.EntradaDataGridView.AutoGenerateColumns = False
        Me.EntradaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EntradaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.EntradaDataGridView.DataSource = Me.EntradaBindingSource
        Me.EntradaDataGridView.Location = New System.Drawing.Point(341, 72)
        Me.EntradaDataGridView.Name = "EntradaDataGridView"
        Me.EntradaDataGridView.ReadOnly = True
        Me.EntradaDataGridView.Size = New System.Drawing.Size(436, 291)
        Me.EntradaDataGridView.TabIndex = 15
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
        'Obra_destinoTableAdapter
        '
        Me.Obra_destinoTableAdapter.ClearBeforeFill = True
        '
        'Obra_destinoDataGridView
        '
        Me.Obra_destinoDataGridView.AutoGenerateColumns = False
        Me.Obra_destinoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Obra_destinoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Obra_destinoDataGridView.DataSource = Me.Obra_destinoBindingSource
        Me.Obra_destinoDataGridView.Location = New System.Drawing.Point(48, 443)
        Me.Obra_destinoDataGridView.Name = "Obra_destinoDataGridView"
        Me.Obra_destinoDataGridView.Size = New System.Drawing.Size(300, 113)
        Me.Obra_destinoDataGridView.TabIndex = 17
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
        'SalidaBindingSource
        '
        Me.SalidaBindingSource.DataMember = "salida"
        Me.SalidaBindingSource.DataSource = Me.Salidas
        '
        'SalidaTableAdapter
        '
        Me.SalidaTableAdapter.ClearBeforeFill = True
        '
        'SalidaDataGridView
        '
        Me.SalidaDataGridView.AutoGenerateColumns = False
        Me.SalidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalidaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.SalidaDataGridView.DataSource = Me.SalidaBindingSource
        Me.SalidaDataGridView.Location = New System.Drawing.Point(376, 443)
        Me.SalidaDataGridView.Name = "SalidaDataGridView"
        Me.SalidaDataGridView.Size = New System.Drawing.Size(410, 113)
        Me.SalidaDataGridView.TabIndex = 18
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
        Me.txtNoNotaId.Location = New System.Drawing.Point(341, 388)
        Me.txtNoNotaId.Name = "txtNoNotaId"
        Me.txtNoNotaId.Size = New System.Drawing.Size(100, 20)
        Me.txtNoNotaId.TabIndex = 20
        '
        'nuevaSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(862, 733)
        Me.Controls.Add(Me.txtNoNotaId)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.SalidaDataGridView)
        Me.Controls.Add(Me.Obra_destinoDataGridView)
        Me.Controls.Add(Me.EntradaDataGridView)
        Me.Controls.Add(Me.EntradaBindingNavigator)
        Me.Controls.Add(Me.txtNoNota)
        Me.Controls.Add(Me.txtNoSalidas)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.cbxObra)
        Me.Controls.Add(Me.txtUnidad)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "nuevaSalida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Salida"
        CType(Me.Obra_destinoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EntradaBindingNavigator.ResumeLayout(False)
        Me.EntradaBindingNavigator.PerformLayout()
        CType(Me.EntradaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obra_destinoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalidaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNoNotaId As System.Windows.Forms.TextBox
End Class
