<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategorias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategorias))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New CapaPresentacion.DataSet1()
        Me.cmdInsertar = New System.Windows.Forms.Button()
        Me.dgCategorias = New System.Windows.Forms.DataGridView()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Concepto"
        '
        'txtConcepto
        '
        Me.txtConcepto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "concepto", True))
        Me.txtConcepto.Location = New System.Drawing.Point(165, 75)
        Me.txtConcepto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(289, 26)
        Me.txtConcepto.TabIndex = 1
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "categorias"
        Me.CategoriasBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdInsertar
        '
        Me.cmdInsertar.Enabled = False
        Me.cmdInsertar.Location = New System.Drawing.Point(219, 205)
        Me.cmdInsertar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdInsertar.Name = "cmdInsertar"
        Me.cmdInsertar.Size = New System.Drawing.Size(112, 35)
        Me.cmdInsertar.TabIndex = 2
        Me.cmdInsertar.Text = "Grabar"
        Me.cmdInsertar.UseVisualStyleBackColor = True
        '
        'dgCategorias
        '
        Me.dgCategorias.AutoGenerateColumns = False
        Me.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCategoriaDataGridViewTextBoxColumn, Me.ConceptoDataGridViewTextBoxColumn})
        Me.dgCategorias.DataSource = Me.CategoriasBindingSource
        Me.dgCategorias.Location = New System.Drawing.Point(574, 75)
        Me.dgCategorias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgCategorias.Name = "dgCategorias"
        Me.dgCategorias.ReadOnly = True
        Me.dgCategorias.RowHeadersWidth = 62
        Me.dgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCategorias.Size = New System.Drawing.Size(459, 265)
        Me.dgCategorias.TabIndex = 3
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        Me.IdCategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCategoriaDataGridViewTextBoxColumn.Width = 150
        '
        'ConceptoDataGridViewTextBoxColumn
        '
        Me.ConceptoDataGridViewTextBoxColumn.DataPropertyName = "concepto"
        Me.ConceptoDataGridViewTextBoxColumn.HeaderText = "concepto"
        Me.ConceptoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ConceptoDataGridViewTextBoxColumn.Name = "ConceptoDataGridViewTextBoxColumn"
        Me.ConceptoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConceptoDataGridViewTextBoxColumn.Width = 150
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(219, 371)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(112, 35)
        Me.cmdSalir.TabIndex = 4
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT categorias.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   categorias"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=LAPTOP-ITU4L2KC;Initial Catalog=Almacen;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "categorias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idCategoria", "idCategoria"), New System.Data.Common.DataColumnMapping("concepto", "concepto")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.CommandText = "DELETE FROM [categorias] WHERE (([idCategoria] = @Original_idCategoria) AND ((@Is" &
    "Null_concepto = 1 AND [concepto] IS NULL) OR ([concepto] = @Original_concepto)))" &
    ""
        Me.SqlDeleteCommand.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_idCategoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idCategoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_concepto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "concepto", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_concepto", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "concepto", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = "INSERT INTO [categorias] ([concepto]) VALUES (@concepto);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT idCategoria, co" &
    "ncepto FROM categorias WHERE (idCategoria = SCOPE_IDENTITY())"
        Me.SqlInsertCommand.Connection = Me.SqlConnection1
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@concepto", System.Data.SqlDbType.VarChar, 0, "concepto")})
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        Me.SqlUpdateCommand.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@concepto", System.Data.SqlDbType.VarChar, 0, "concepto"), New System.Data.SqlClient.SqlParameter("@Original_idCategoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idCategoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_concepto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "concepto", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_concepto", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "concepto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@idCategoria", System.Data.SqlDbType.Int, 4, "idCategoria")})
        '
        'cmdEditar
        '
        Me.cmdEditar.Location = New System.Drawing.Point(376, 204)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(112, 36)
        Me.cmdEditar.TabIndex = 5
        Me.cmdEditar.Text = "Editar"
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(295, 286)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(112, 35)
        Me.cmdSiguiente.TabIndex = 6
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(1, 286)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(112, 35)
        Me.cmdInicio.TabIndex = 7
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(149, 286)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(112, 35)
        Me.cmdAnterior.TabIndex = 8
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(435, 286)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(112, 35)
        Me.cmdUltimo.TabIndex = 9
        Me.cmdUltimo.Text = "Último"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(56, 204)
        Me.cmdNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(112, 35)
        Me.cmdNuevo.TabIndex = 10
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'frmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 483)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdEditar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgCategorias)
        Me.Controls.Add(Me.cmdInsertar)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCategorias"
        Me.Text = "Categorias"
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtConcepto As TextBox
    Friend WithEvents cmdInsertar As Button
    Friend WithEvents dgCategorias As DataGridView
    Friend WithEvents cmdSalir As Button
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand As SqlClient.SqlCommand
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriasBindingSource As BindingSource
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents cmdEditar As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdNuevo As Button
End Class
