<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acceso
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
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.value = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.EmpleadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movimientos = New proyecto_eura.movimientos()
        Me.Movimientos_sistemaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Movimientos_sistemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.EmpleadoTableAdapter = New proyecto_eura.movimientosTableAdapters.empleadoTableAdapter()
        Me.TableAdapterManager = New proyecto_eura.movimientosTableAdapters.TableAdapterManager()
        Me.Movimientos_sistemaTableAdapter = New proyecto_eura.movimientosTableAdapters.movimientos_sistemaTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movimientos_sistemaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movimientos_sistemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(118, 27)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(118, 73)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasena.TabIndex = 1
        '
        'btnAcceder
        '
        Me.btnAcceder.Location = New System.Drawing.Point(44, 121)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(75, 23)
        Me.btnAcceder.TabIndex = 2
        Me.btnAcceder.Text = "Entrar"
        Me.btnAcceder.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(143, 121)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'value
        '
        Me.value.AutoSize = True
        Me.value.Enabled = False
        Me.value.Location = New System.Drawing.Point(49, 100)
        Me.value.Name = "value"
        Me.value.Size = New System.Drawing.Size(0, 13)
        Me.value.TabIndex = 5
        Me.value.Visible = False
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(350, 26)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 6
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(311, 66)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(97, 13)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.Text = "Accedio al Sistema"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(313, 84)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(34, 13)
        Me.lblFecha.TabIndex = 8
        Me.lblFecha.Text = "fecha"
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(350, 107)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpleado.TabIndex = 9
        '
        'EmpleadoDataGridView
        '
        Me.EmpleadoDataGridView.AutoGenerateColumns = False
        Me.EmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.EmpleadoDataGridView.DataSource = Me.EmpleadoBindingSource
        Me.EmpleadoDataGridView.Location = New System.Drawing.Point(316, 166)
        Me.EmpleadoDataGridView.Name = "EmpleadoDataGridView"
        Me.EmpleadoDataGridView.Size = New System.Drawing.Size(300, 82)
        Me.EmpleadoDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_empleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_empleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn3.HeaderText = "username"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn4.HeaderText = "password"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "puesto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "puesto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn6.HeaderText = "status"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.Movimientos
        '
        'Movimientos
        '
        Me.Movimientos.DataSetName = "movimientos"
        Me.Movimientos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Movimientos_sistemaDataGridView
        '
        Me.Movimientos_sistemaDataGridView.AutoGenerateColumns = False
        Me.Movimientos_sistemaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Movimientos_sistemaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Movimientos_sistemaDataGridView.DataSource = Me.Movimientos_sistemaBindingSource
        Me.Movimientos_sistemaDataGridView.Location = New System.Drawing.Point(315, 254)
        Me.Movimientos_sistemaDataGridView.Name = "Movimientos_sistemaDataGridView"
        Me.Movimientos_sistemaDataGridView.Size = New System.Drawing.Size(300, 85)
        Me.Movimientos_sistemaDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id_movimiento"
        Me.DataGridViewTextBoxColumn7.HeaderText = "id_movimiento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "empleado"
        Me.DataGridViewTextBoxColumn11.HeaderText = "empleado"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Movimientos_sistemaBindingSource
        '
        Me.Movimientos_sistemaBindingSource.DataMember = "movimientos_sistema"
        Me.Movimientos_sistemaBindingSource.DataSource = Me.Movimientos
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "User"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(313, 53)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(33, 13)
        Me.lblTipo.TabIndex = 15
        Me.lblTipo.Text = "Login"
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.empleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager.movimientos_sistemaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = proyecto_eura.movimientosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Movimientos_sistemaTableAdapter
        '
        Me.Movimientos_sistemaTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Puesto"
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(358, 134)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtPuesto.TabIndex = 17
        '
        'Acceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 174)
        Me.Controls.Add(Me.txtPuesto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Movimientos_sistemaDataGridView)
        Me.Controls.Add(Me.EmpleadoDataGridView)
        Me.Controls.Add(Me.txtEmpleado)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.value)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Acceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso"
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movimientos_sistemaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movimientos_sistemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents btnAcceder As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents value As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Movimientos As proyecto_eura.movimientos
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As proyecto_eura.movimientosTableAdapters.empleadoTableAdapter
    Friend WithEvents TableAdapterManager As proyecto_eura.movimientosTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Movimientos_sistemaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Movimientos_sistemaTableAdapter As proyecto_eura.movimientosTableAdapters.movimientos_sistemaTableAdapter
    Friend WithEvents Movimientos_sistemaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPuesto As System.Windows.Forms.TextBox

End Class
