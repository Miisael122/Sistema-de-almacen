<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgventa = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.cboproducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidVenta = New System.Windows.Forms.TextBox()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(878, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Subtotal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(878, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(878, 422)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(423, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(423, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Producto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(423, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cantidad"
        '
        'dgventa
        '
        Me.dgventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgventa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgventa.Location = New System.Drawing.Point(32, 282)
        Me.dgventa.Name = "dgventa"
        Me.dgventa.RowHeadersWidth = 62
        Me.dgventa.RowTemplate.Height = 28
        Me.dgventa.Size = New System.Drawing.Size(840, 192)
        Me.dgventa.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "IdVenta"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "IdProducto"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(732, 72)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(102, 37)
        Me.cmdNuevo.TabIndex = 10
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(732, 135)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(102, 37)
        Me.cmdAceptar.TabIndex = 11
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(732, 200)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(102, 37)
        Me.cmdGuardar.TabIndex = 12
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(934, 135)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(102, 37)
        Me.cmdSalir.TabIndex = 13
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(502, 151)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.ReadOnly = True
        Me.txtprecio.Size = New System.Drawing.Size(114, 26)
        Me.txtprecio.TabIndex = 15
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(502, 88)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(114, 26)
        Me.txtcantidad.TabIndex = 16
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(952, 418)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(100, 26)
        Me.txttotal.TabIndex = 17
        '
        'txtiva
        '
        Me.txtiva.Location = New System.Drawing.Point(952, 354)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.ReadOnly = True
        Me.txtiva.Size = New System.Drawing.Size(100, 26)
        Me.txtiva.TabIndex = 18
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(952, 294)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.ReadOnly = True
        Me.txtsubtotal.Size = New System.Drawing.Size(100, 26)
        Me.txtsubtotal.TabIndex = 19
        '
        'DTP1
        '
        Me.DTP1.Enabled = False
        Me.DTP1.Location = New System.Drawing.Point(32, 132)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(322, 26)
        Me.DTP1.TabIndex = 20
        '
        'cboproducto
        '
        Me.cboproducto.FormattingEnabled = True
        Me.cboproducto.Location = New System.Drawing.Point(502, 31)
        Me.cboproducto.Name = "cboproducto"
        Me.cboproducto.Size = New System.Drawing.Size(170, 28)
        Me.cboproducto.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "IdVenta"
        '
        'txtidVenta
        '
        Me.txtidVenta.Location = New System.Drawing.Point(100, 31)
        Me.txtidVenta.Name = "txtidVenta"
        Me.txtidVenta.ReadOnly = True
        Me.txtidVenta.Size = New System.Drawing.Size(114, 26)
        Me.txtidVenta.TabIndex = 23
        '
        'txtExistencia
        '
        Me.txtExistencia.Location = New System.Drawing.Point(502, 207)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.ReadOnly = True
        Me.txtExistencia.Size = New System.Drawing.Size(114, 26)
        Me.txtExistencia.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(423, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 20)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Existencia"
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 654)
        Me.Controls.Add(Me.txtExistencia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtidVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboproducto)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.dgventa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmVentas"
        Me.Text = "frmVentas"
        CType(Me.dgventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgventa As DataGridView
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtiva As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents cboproducto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents txtidVenta As TextBox
    Friend WithEvents txtExistencia As TextBox
    Friend WithEvents Label8 As Label
End Class
