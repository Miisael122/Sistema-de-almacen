<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New CapaPresentacion.DataSet1()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdomicilio = New System.Windows.Forms.TextBox()
        Me.txtcolonia = New System.Windows.Forms.TextBox()
        Me.txtcp = New System.Windows.Forms.TextBox()
        Me.txtciudad = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txtrepresentante = New System.Windows.Forms.TextBox()
        Me.txtsaldo = New System.Windows.Forms.TextBox()
        Me.dgproveedores = New System.Windows.Forms.DataGridView()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepresentanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdinsertar = New System.Windows.Forms.Button()
        Me.cmdsaldo = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgproveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(498, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Domicilio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(802, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Colonia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(176, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ciudad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(464, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Correo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(740, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Representante"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Saldo"
        '
        'txtnombre
        '
        Me.txtnombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "nombre", True))
        Me.txtnombre.Location = New System.Drawing.Point(82, 22)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(164, 26)
        Me.txtnombre.TabIndex = 10
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txttelefono
        '
        Me.txttelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "telefono", True))
        Me.txttelefono.Location = New System.Drawing.Point(330, 22)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(164, 26)
        Me.txttelefono.TabIndex = 11
        '
        'txtdomicilio
        '
        Me.txtdomicilio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "domicilio", True))
        Me.txtdomicilio.Location = New System.Drawing.Point(576, 22)
        Me.txtdomicilio.Name = "txtdomicilio"
        Me.txtdomicilio.Size = New System.Drawing.Size(222, 26)
        Me.txtdomicilio.TabIndex = 12
        '
        'txtcolonia
        '
        Me.txtcolonia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "colonia", True))
        Me.txtcolonia.Location = New System.Drawing.Point(872, 22)
        Me.txtcolonia.Name = "txtcolonia"
        Me.txtcolonia.Size = New System.Drawing.Size(210, 26)
        Me.txtcolonia.TabIndex = 13
        '
        'txtcp
        '
        Me.txtcp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "cp", True))
        Me.txtcp.Location = New System.Drawing.Point(48, 91)
        Me.txtcp.Name = "txtcp"
        Me.txtcp.Size = New System.Drawing.Size(96, 26)
        Me.txtcp.TabIndex = 14
        '
        'txtciudad
        '
        Me.txtciudad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "ciudad", True))
        Me.txtciudad.Location = New System.Drawing.Point(240, 91)
        Me.txtciudad.Name = "txtciudad"
        Me.txtciudad.Size = New System.Drawing.Size(206, 26)
        Me.txtciudad.TabIndex = 15
        '
        'txtcorreo
        '
        Me.txtcorreo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "correo", True))
        Me.txtcorreo.Location = New System.Drawing.Point(526, 91)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(206, 26)
        Me.txtcorreo.TabIndex = 16
        '
        'txtrepresentante
        '
        Me.txtrepresentante.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "representante", True))
        Me.txtrepresentante.Location = New System.Drawing.Point(862, 91)
        Me.txtrepresentante.Name = "txtrepresentante"
        Me.txtrepresentante.Size = New System.Drawing.Size(206, 26)
        Me.txtrepresentante.TabIndex = 17
        '
        'txtsaldo
        '
        Me.txtsaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "saldoProv", True))
        Me.txtsaldo.Enabled = False
        Me.txtsaldo.Location = New System.Drawing.Point(68, 148)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.ReadOnly = True
        Me.txtsaldo.Size = New System.Drawing.Size(96, 26)
        Me.txtsaldo.TabIndex = 18
        '
        'dgproveedores
        '
        Me.dgproveedores.AutoGenerateColumns = False
        Me.dgproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgproveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.CpDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.RepresentanteDataGridViewTextBoxColumn, Me.SaldoProvDataGridViewTextBoxColumn})
        Me.dgproveedores.DataSource = Me.ProveedoresBindingSource
        Me.dgproveedores.Location = New System.Drawing.Point(12, 341)
        Me.dgproveedores.Name = "dgproveedores"
        Me.dgproveedores.ReadOnly = True
        Me.dgproveedores.RowHeadersWidth = 62
        Me.dgproveedores.RowTemplate.Height = 28
        Me.dgproveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgproveedores.Size = New System.Drawing.Size(1053, 288)
        Me.dgproveedores.TabIndex = 19
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProveedorDataGridViewTextBoxColumn.Width = 150
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 150
        '
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        Me.DomicilioDataGridViewTextBoxColumn.ReadOnly = True
        Me.DomicilioDataGridViewTextBoxColumn.Width = 150
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ColoniaDataGridViewTextBoxColumn.Width = 150
        '
        'CpDataGridViewTextBoxColumn
        '
        Me.CpDataGridViewTextBoxColumn.DataPropertyName = "cp"
        Me.CpDataGridViewTextBoxColumn.HeaderText = "cp"
        Me.CpDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CpDataGridViewTextBoxColumn.Name = "CpDataGridViewTextBoxColumn"
        Me.CpDataGridViewTextBoxColumn.ReadOnly = True
        Me.CpDataGridViewTextBoxColumn.Width = 150
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "ciudad"
        Me.CiudadDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        Me.CiudadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CiudadDataGridViewTextBoxColumn.Width = 150
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "correo"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoDataGridViewTextBoxColumn.Width = 150
        '
        'RepresentanteDataGridViewTextBoxColumn
        '
        Me.RepresentanteDataGridViewTextBoxColumn.DataPropertyName = "representante"
        Me.RepresentanteDataGridViewTextBoxColumn.HeaderText = "representante"
        Me.RepresentanteDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RepresentanteDataGridViewTextBoxColumn.Name = "RepresentanteDataGridViewTextBoxColumn"
        Me.RepresentanteDataGridViewTextBoxColumn.ReadOnly = True
        Me.RepresentanteDataGridViewTextBoxColumn.Width = 150
        '
        'SaldoProvDataGridViewTextBoxColumn
        '
        Me.SaldoProvDataGridViewTextBoxColumn.DataPropertyName = "saldoProv"
        Me.SaldoProvDataGridViewTextBoxColumn.HeaderText = "saldoProv"
        Me.SaldoProvDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SaldoProvDataGridViewTextBoxColumn.Name = "SaldoProvDataGridViewTextBoxColumn"
        Me.SaldoProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoProvDataGridViewTextBoxColumn.Width = 150
        '
        'cmdinsertar
        '
        Me.cmdinsertar.Location = New System.Drawing.Point(502, 172)
        Me.cmdinsertar.Name = "cmdinsertar"
        Me.cmdinsertar.Size = New System.Drawing.Size(104, 32)
        Me.cmdinsertar.TabIndex = 20
        Me.cmdinsertar.Text = "Insertar"
        Me.cmdinsertar.UseVisualStyleBackColor = True
        '
        'cmdsaldo
        '
        Me.cmdsaldo.Location = New System.Drawing.Point(947, 208)
        Me.cmdsaldo.Name = "cmdsaldo"
        Me.cmdsaldo.Size = New System.Drawing.Size(104, 32)
        Me.cmdsaldo.TabIndex = 21
        Me.cmdsaldo.Text = "Salir"
        Me.cmdsaldo.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(722, 256)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(112, 35)
        Me.cmdUltimo.TabIndex = 25
        Me.cmdUltimo.Text = "Último"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(436, 256)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(112, 35)
        Me.cmdAnterior.TabIndex = 24
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(288, 256)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(112, 35)
        Me.cmdInicio.TabIndex = 23
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(582, 256)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(112, 35)
        Me.cmdSiguiente.TabIndex = 22
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(347, 172)
        Me.cmdNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(112, 35)
        Me.cmdNuevo.TabIndex = 26
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdEditar
        '
        Me.cmdEditar.Location = New System.Drawing.Point(645, 170)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(112, 36)
        Me.cmdEditar.TabIndex = 27
        Me.cmdEditar.Text = "Editar"
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT proveedores.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   proveedores"
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 0, "telefono"), New System.Data.SqlClient.SqlParameter("@domicilio", System.Data.SqlDbType.VarChar, 0, "domicilio"), New System.Data.SqlClient.SqlParameter("@colonia", System.Data.SqlDbType.VarChar, 0, "colonia"), New System.Data.SqlClient.SqlParameter("@cp", System.Data.SqlDbType.VarChar, 0, "cp"), New System.Data.SqlClient.SqlParameter("@ciudad", System.Data.SqlDbType.VarChar, 0, "ciudad"), New System.Data.SqlClient.SqlParameter("@correo", System.Data.SqlDbType.VarChar, 0, "correo"), New System.Data.SqlClient.SqlParameter("@representante", System.Data.SqlDbType.VarChar, 0, "representante"), New System.Data.SqlClient.SqlParameter("@saldoProv", System.Data.SqlDbType.Money, 0, "saldoProv")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 0, "telefono"), New System.Data.SqlClient.SqlParameter("@domicilio", System.Data.SqlDbType.VarChar, 0, "domicilio"), New System.Data.SqlClient.SqlParameter("@colonia", System.Data.SqlDbType.VarChar, 0, "colonia"), New System.Data.SqlClient.SqlParameter("@cp", System.Data.SqlDbType.VarChar, 0, "cp"), New System.Data.SqlClient.SqlParameter("@ciudad", System.Data.SqlDbType.VarChar, 0, "ciudad"), New System.Data.SqlClient.SqlParameter("@correo", System.Data.SqlDbType.VarChar, 0, "correo"), New System.Data.SqlClient.SqlParameter("@representante", System.Data.SqlDbType.VarChar, 0, "representante"), New System.Data.SqlClient.SqlParameter("@saldoProv", System.Data.SqlDbType.Money, 0, "saldoProv"), New System.Data.SqlClient.SqlParameter("@Original_idProveedor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idProveedor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_domicilio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "domicilio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_domicilio", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "domicilio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "colonia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_colonia", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "colonia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cp", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cp", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ciudad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ciudad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ciudad", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciudad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_correo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "correo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_correo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "correo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_representante", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "representante", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_representante", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "representante", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_saldoProv", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "saldoProv", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_saldoProv", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "saldoProv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@idProveedor", System.Data.SqlDbType.Int, 4, "idProveedor")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_idProveedor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idProveedor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_domicilio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "domicilio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_domicilio", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "domicilio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "colonia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_colonia", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "colonia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cp", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cp", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ciudad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ciudad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ciudad", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciudad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_correo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "correo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_correo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "correo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_representante", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "representante", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_representante", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "representante", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_saldoProv", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "saldoProv", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_saldoProv", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "saldoProv", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "proveedores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idProveedor", "idProveedor"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("domicilio", "domicilio"), New System.Data.Common.DataColumnMapping("colonia", "colonia"), New System.Data.Common.DataColumnMapping("cp", "cp"), New System.Data.Common.DataColumnMapping("ciudad", "ciudad"), New System.Data.Common.DataColumnMapping("correo", "correo"), New System.Data.Common.DataColumnMapping("representante", "representante"), New System.Data.Common.DataColumnMapping("saldoProv", "saldoProv")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 669)
        Me.Controls.Add(Me.cmdEditar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdsaldo)
        Me.Controls.Add(Me.cmdinsertar)
        Me.Controls.Add(Me.dgproveedores)
        Me.Controls.Add(Me.txtsaldo)
        Me.Controls.Add(Me.txtrepresentante)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.txtciudad)
        Me.Controls.Add(Me.txtcp)
        Me.Controls.Add(Me.txtcolonia)
        Me.Controls.Add(Me.txtdomicilio)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmProveedores"
        Me.Text = "frmProveedores"
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgproveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdomicilio As TextBox
    Friend WithEvents txtcolonia As TextBox
    Friend WithEvents txtcp As TextBox
    Friend WithEvents txtciudad As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txtrepresentante As TextBox
    Friend WithEvents txtsaldo As TextBox
    Friend WithEvents dgproveedores As DataGridView
    Friend WithEvents cmdinsertar As Button
    Friend WithEvents cmdsaldo As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdEditar As Button
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RepresentanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
