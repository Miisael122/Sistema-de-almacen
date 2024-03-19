<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.dgProductos = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinimosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New CapaPresentacion.DataSet1()
        Me.cmdInsertar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaximos = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMinimos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgProductos
        '
        Me.dgProductos.AutoGenerateColumns = False
        Me.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.IdCategoriaDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.MaximosDataGridViewTextBoxColumn, Me.MinimosDataGridViewTextBoxColumn})
        Me.dgProductos.DataSource = Me.ProductosBindingSource
        Me.dgProductos.Location = New System.Drawing.Point(13, 357)
        Me.dgProductos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgProductos.Name = "dgProductos"
        Me.dgProductos.RowHeadersWidth = 62
        Me.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProductos.Size = New System.Drawing.Size(1010, 251)
        Me.dgProductos.TabIndex = 0
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProductoDataGridViewTextBoxColumn.Width = 150
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        Me.IdCategoriaDataGridViewTextBoxColumn.Width = 150
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "nombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        Me.NombreProductoDataGridViewTextBoxColumn.Width = 150
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "precioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "precioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        Me.PrecioVentaDataGridViewTextBoxColumn.Width = 150
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.Width = 150
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.Width = 150
        '
        'MaximosDataGridViewTextBoxColumn
        '
        Me.MaximosDataGridViewTextBoxColumn.DataPropertyName = "maximos"
        Me.MaximosDataGridViewTextBoxColumn.HeaderText = "maximos"
        Me.MaximosDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaximosDataGridViewTextBoxColumn.Name = "MaximosDataGridViewTextBoxColumn"
        Me.MaximosDataGridViewTextBoxColumn.Width = 150
        '
        'MinimosDataGridViewTextBoxColumn
        '
        Me.MinimosDataGridViewTextBoxColumn.DataPropertyName = "minimos"
        Me.MinimosDataGridViewTextBoxColumn.HeaderText = "minimos"
        Me.MinimosDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MinimosDataGridViewTextBoxColumn.Name = "MinimosDataGridViewTextBoxColumn"
        Me.MinimosDataGridViewTextBoxColumn.Width = 150
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdInsertar
        '
        Me.cmdInsertar.Enabled = False
        Me.cmdInsertar.Location = New System.Drawing.Point(469, 191)
        Me.cmdInsertar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdInsertar.Name = "cmdInsertar"
        Me.cmdInsertar.Size = New System.Drawing.Size(112, 35)
        Me.cmdInsertar.TabIndex = 15
        Me.cmdInsertar.Text = "Insertar"
        Me.cmdInsertar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(883, 222)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(112, 35)
        Me.cmdSalir.TabIndex = 16
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(682, 263)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(112, 35)
        Me.cmdUltimo.TabIndex = 20
        Me.cmdUltimo.Text = "Último"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(396, 263)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(112, 35)
        Me.cmdAnterior.TabIndex = 19
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(248, 263)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(112, 35)
        Me.cmdInicio.TabIndex = 18
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(542, 263)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(112, 35)
        Me.cmdSiguiente.TabIndex = 17
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdEditar
        '
        Me.cmdEditar.Location = New System.Drawing.Point(630, 190)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(112, 36)
        Me.cmdEditar.TabIndex = 22
        Me.cmdEditar.Text = "Editar"
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(300, 191)
        Me.cmdNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(112, 35)
        Me.cmdNuevo.TabIndex = 21
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cboCategoria
        '
        Me.cboCategoria.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "idCategoria", True))
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(151, 33)
        Me.cboCategoria.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(180, 28)
        Me.cboCategoria.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Categoría"
        '
        'txtCosto
        '
        Me.txtCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "costo", True))
        Me.txtCosto.Location = New System.Drawing.Point(875, 33)
        Me.txtCosto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(120, 26)
        Me.txtCosto.TabIndex = 33
        '
        'txtExistencia
        '
        Me.txtExistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "existencia", True))
        Me.txtExistencia.Enabled = False
        Me.txtExistencia.Location = New System.Drawing.Point(151, 116)
        Me.txtExistencia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Size = New System.Drawing.Size(120, 26)
        Me.txtExistencia.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre"
        '
        'txtMaximos
        '
        Me.txtMaximos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "maximos", True))
        Me.txtMaximos.Location = New System.Drawing.Point(423, 111)
        Me.txtMaximos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMaximos.Name = "txtMaximos"
        Me.txtMaximos.Size = New System.Drawing.Size(120, 26)
        Me.txtMaximos.TabIndex = 35
        '
        'txtPrecio
        '
        Me.txtPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precioVenta", True))
        Me.txtPrecio.Location = New System.Drawing.Point(685, 33)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(120, 26)
        Me.txtPrecio.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(621, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Precio"
        '
        'txtMinimos
        '
        Me.txtMinimos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "minimos", True))
        Me.txtMinimos.Location = New System.Drawing.Point(700, 111)
        Me.txtMinimos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMinimos.Name = "txtMinimos"
        Me.txtMinimos.Size = New System.Drawing.Size(120, 26)
        Me.txtMinimos.TabIndex = 36
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "nombreProducto", True))
        Me.txtNombre.Location = New System.Drawing.Point(417, 33)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(193, 26)
        Me.txtNombre.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(815, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Costo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(621, 116)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Mínimos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(341, 120)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Máximos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 120)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Existencia"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT productos.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   productos"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=LAPTOP-ITU4L2KC;Initial Catalog=Almacen;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@idCategoria", System.Data.SqlDbType.Int, 0, "idCategoria"), New System.Data.SqlClient.SqlParameter("@nombreProducto", System.Data.SqlDbType.VarChar, 0, "nombreProducto"), New System.Data.SqlClient.SqlParameter("@precioVenta", System.Data.SqlDbType.Money, 0, "precioVenta"), New System.Data.SqlClient.SqlParameter("@costo", System.Data.SqlDbType.Money, 0, "costo"), New System.Data.SqlClient.SqlParameter("@existencia", System.Data.SqlDbType.Int, 0, "existencia"), New System.Data.SqlClient.SqlParameter("@maximos", System.Data.SqlDbType.Int, 0, "maximos"), New System.Data.SqlClient.SqlParameter("@minimos", System.Data.SqlDbType.Int, 0, "minimos")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@idCategoria", System.Data.SqlDbType.Int, 0, "idCategoria"), New System.Data.SqlClient.SqlParameter("@nombreProducto", System.Data.SqlDbType.VarChar, 0, "nombreProducto"), New System.Data.SqlClient.SqlParameter("@precioVenta", System.Data.SqlDbType.Money, 0, "precioVenta"), New System.Data.SqlClient.SqlParameter("@costo", System.Data.SqlDbType.Money, 0, "costo"), New System.Data.SqlClient.SqlParameter("@existencia", System.Data.SqlDbType.Int, 0, "existencia"), New System.Data.SqlClient.SqlParameter("@maximos", System.Data.SqlDbType.Int, 0, "maximos"), New System.Data.SqlClient.SqlParameter("@minimos", System.Data.SqlDbType.Int, 0, "minimos"), New System.Data.SqlClient.SqlParameter("@Original_idProducto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idProducto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_idCategoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "idCategoria", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_idCategoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idCategoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombreProducto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombreProducto", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombreProducto", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreProducto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_precioVenta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "precioVenta", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_precioVenta", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "precioVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_costo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "costo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_costo", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_existencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "existencia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_existencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "existencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_maximos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "maximos", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_maximos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "maximos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_minimos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "minimos", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_minimos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "minimos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@idProducto", System.Data.SqlDbType.Int, 4, "idProducto")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_idProducto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idProducto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_idCategoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "idCategoria", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_idCategoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idCategoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombreProducto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombreProducto", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombreProducto", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreProducto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_precioVenta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "precioVenta", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_precioVenta", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "precioVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_costo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "costo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_costo", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_existencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "existencia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_existencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "existencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_maximos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "maximos", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_maximos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "maximos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_minimos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "minimos", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_minimos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "minimos", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "productos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idProducto", "idProducto"), New System.Data.Common.DataColumnMapping("idCategoria", "idCategoria"), New System.Data.Common.DataColumnMapping("nombreProducto", "nombreProducto"), New System.Data.Common.DataColumnMapping("precioVenta", "precioVenta"), New System.Data.Common.DataColumnMapping("costo", "costo"), New System.Data.Common.DataColumnMapping("existencia", "existencia"), New System.Data.Common.DataColumnMapping("maximos", "maximos"), New System.Data.Common.DataColumnMapping("minimos", "minimos")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 622)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtExistencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaximos)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMinimos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdEditar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdInsertar)
        Me.Controls.Add(Me.dgProductos)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmProductos"
        Me.Text = "frmProductos"
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgProductos As DataGridView
    Friend WithEvents cmdInsertar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdEditar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtExistencia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaximos As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMinimos As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinimosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductosBindingSource As BindingSource
End Class
