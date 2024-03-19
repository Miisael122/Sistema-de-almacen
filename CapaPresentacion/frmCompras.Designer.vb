<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgcompra = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtidproveedor = New System.Windows.Forms.TextBox()
        Me.txtidcompra = New System.Windows.Forms.TextBox()
        Me.txtsaldo = New System.Windows.Forms.TextBox()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtfactura = New System.Windows.Forms.TextBox()
        Me.cbonomproveedor = New System.Windows.Forms.ComboBox()
        Me.cbonomproducto = New System.Windows.Forms.ComboBox()
        Me.cbocondicion = New System.Windows.Forms.ComboBox()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.txtexistencias = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.dgcompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "idProveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Saldo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 13)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "idCompra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 225)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 169)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "idProducto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(204, 225)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Costo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 171)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Factura"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(340, 88)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Condición"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(204, 171)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(340, 49)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Fecha"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(637, 442)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(68, 24)
        Me.cmdSalir.TabIndex = 17
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(457, 220)
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(68, 24)
        Me.cmdGuardar.TabIndex = 16
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(368, 220)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(68, 24)
        Me.cmdAceptar.TabIndex = 15
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(624, 46)
        Me.cmdNuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(68, 24)
        Me.cmdNuevo.TabIndex = 14
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(639, 315)
        Me.txtsubtotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.ReadOnly = True
        Me.txtsubtotal.Size = New System.Drawing.Size(68, 20)
        Me.txtsubtotal.TabIndex = 25
        '
        'txtiva
        '
        Me.txtiva.Location = New System.Drawing.Point(639, 354)
        Me.txtiva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.ReadOnly = True
        Me.txtiva.Size = New System.Drawing.Size(68, 20)
        Me.txtiva.TabIndex = 24
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(639, 396)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(68, 20)
        Me.txttotal.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(589, 398)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Total"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(589, 356)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "IVA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(589, 317)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Subtotal"
        '
        'dgcompra
        '
        Me.dgcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgcompra.Location = New System.Drawing.Point(8, 292)
        Me.dgcompra.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgcompra.Name = "dgcompra"
        Me.dgcompra.RowHeadersWidth = 62
        Me.dgcompra.RowTemplate.Height = 28
        Me.dgcompra.Size = New System.Drawing.Size(565, 168)
        Me.dgcompra.TabIndex = 27
        '
        'Column1
        '
        Me.Column1.HeaderText = "idCompra"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "idProducto"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "NombreProducto"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Costo"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Importe"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'txtidproveedor
        '
        Me.txtidproveedor.Location = New System.Drawing.Point(99, 13)
        Me.txtidproveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtidproveedor.Name = "txtidproveedor"
        Me.txtidproveedor.ReadOnly = True
        Me.txtidproveedor.Size = New System.Drawing.Size(68, 20)
        Me.txtidproveedor.TabIndex = 28
        '
        'txtidcompra
        '
        Me.txtidcompra.Location = New System.Drawing.Point(395, 11)
        Me.txtidcompra.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtidcompra.Name = "txtidcompra"
        Me.txtidcompra.ReadOnly = True
        Me.txtidcompra.Size = New System.Drawing.Size(68, 20)
        Me.txtidcompra.TabIndex = 29
        '
        'txtsaldo
        '
        Me.txtsaldo.Location = New System.Drawing.Point(99, 88)
        Me.txtsaldo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.ReadOnly = True
        Me.txtsaldo.Size = New System.Drawing.Size(68, 20)
        Me.txtsaldo.TabIndex = 30
        '
        'txtidproducto
        '
        Me.txtidproducto.Location = New System.Drawing.Point(94, 167)
        Me.txtidproducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.ReadOnly = True
        Me.txtidproducto.Size = New System.Drawing.Size(68, 20)
        Me.txtidproducto.TabIndex = 31
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(257, 223)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(68, 20)
        Me.txtprecio.TabIndex = 32
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(257, 169)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(68, 20)
        Me.txtcantidad.TabIndex = 33
        '
        'txtfactura
        '
        Me.txtfactura.Location = New System.Drawing.Point(387, 169)
        Me.txtfactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Size = New System.Drawing.Size(68, 20)
        Me.txtfactura.TabIndex = 34
        '
        'cbonomproveedor
        '
        Me.cbonomproveedor.FormattingEnabled = True
        Me.cbonomproveedor.Location = New System.Drawing.Point(99, 49)
        Me.cbonomproveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbonomproveedor.Name = "cbonomproveedor"
        Me.cbonomproveedor.Size = New System.Drawing.Size(100, 21)
        Me.cbonomproveedor.TabIndex = 35
        '
        'cbonomproducto
        '
        Me.cbonomproducto.FormattingEnabled = True
        Me.cbonomproducto.Location = New System.Drawing.Point(94, 220)
        Me.cbonomproducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbonomproducto.Name = "cbonomproducto"
        Me.cbonomproducto.Size = New System.Drawing.Size(100, 21)
        Me.cbonomproducto.TabIndex = 36
        '
        'cbocondicion
        '
        Me.cbocondicion.FormattingEnabled = True
        Me.cbocondicion.Location = New System.Drawing.Point(397, 85)
        Me.cbocondicion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbocondicion.Name = "cbocondicion"
        Me.cbocondicion.Size = New System.Drawing.Size(100, 21)
        Me.cbocondicion.TabIndex = 37
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(395, 47)
        Me.DTP1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(201, 20)
        Me.DTP1.TabIndex = 38
        '
        'txtexistencias
        '
        Me.txtexistencias.Location = New System.Drawing.Point(540, 171)
        Me.txtexistencias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtexistencias.Name = "txtexistencias"
        Me.txtexistencias.Size = New System.Drawing.Size(68, 20)
        Me.txtexistencias.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(476, 174)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Existencias"
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 472)
        Me.Controls.Add(Me.txtexistencias)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.cbocondicion)
        Me.Controls.Add(Me.cbonomproducto)
        Me.Controls.Add(Me.cbonomproveedor)
        Me.Controls.Add(Me.txtfactura)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtidproducto)
        Me.Controls.Add(Me.txtsaldo)
        Me.Controls.Add(Me.txtidcompra)
        Me.Controls.Add(Me.txtidproveedor)
        Me.Controls.Add(Me.dgcompra)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmCompras"
        Me.Text = "frmCompras"
        CType(Me.dgcompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents txtiva As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dgcompra As DataGridView
    Friend WithEvents txtidproveedor As TextBox
    Friend WithEvents txtidcompra As TextBox
    Friend WithEvents txtsaldo As TextBox
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtfactura As TextBox
    Friend WithEvents cbonomproveedor As ComboBox
    Friend WithEvents cbonomproducto As ComboBox
    Friend WithEvents cbocondicion As ComboBox
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txtexistencias As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
