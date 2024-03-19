<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagos
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
        Me.dgpago = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdguardar = New System.Windows.Forms.Button()
        Me.cmdnuevo = New System.Windows.Forms.Button()
        Me.cmdsalir = New System.Windows.Forms.Button()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.txtidproveedor = New System.Windows.Forms.TextBox()
        Me.txtdomicilio = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtsaldo = New System.Windows.Forms.TextBox()
        Me.txtidpago = New System.Windows.Forms.TextBox()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.cboidcompra = New System.Windows.Forms.ComboBox()
        Me.cbocondicion = New System.Windows.Forms.ComboBox()
        Me.txtimpote = New System.Windows.Forms.TextBox()
        Me.txtreferencia = New System.Windows.Forms.TextBox()
        CType(Me.dgpago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "idProveedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Teléfono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(407, 86)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Saldo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(565, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "idPago"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(565, 85)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha"
        '
        'dgpago
        '
        Me.dgpago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpago.Location = New System.Drawing.Point(8, 125)
        Me.dgpago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgpago.Name = "dgpago"
        Me.dgpago.RowHeadersWidth = 62
        Me.dgpago.RowTemplate.Height = 28
        Me.dgpago.Size = New System.Drawing.Size(655, 153)
        Me.dgpago.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 301)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "idCompra"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 355)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Forma de pago"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(250, 301)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Referencia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(250, 355)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Importe"
        '
        'cmdguardar
        '
        Me.cmdguardar.Enabled = False
        Me.cmdguardar.Location = New System.Drawing.Point(715, 184)
        Me.cmdguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(63, 24)
        Me.cmdguardar.TabIndex = 12
        Me.cmdguardar.Text = "Guardar"
        Me.cmdguardar.UseVisualStyleBackColor = True
        '
        'cmdnuevo
        '
        Me.cmdnuevo.Location = New System.Drawing.Point(715, 136)
        Me.cmdnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(63, 24)
        Me.cmdnuevo.TabIndex = 13
        Me.cmdnuevo.Text = "Nuevo"
        Me.cmdnuevo.UseVisualStyleBackColor = True
        '
        'cmdsalir
        '
        Me.cmdsalir.Location = New System.Drawing.Point(715, 236)
        Me.cmdsalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(63, 24)
        Me.cmdsalir.TabIndex = 14
        Me.cmdsalir.Text = "Salir"
        Me.cmdsalir.UseVisualStyleBackColor = True
        '
        'cboProveedor
        '
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(66, 13)
        Me.cboProveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(111, 21)
        Me.cboProveedor.TabIndex = 15
        '
        'txtidproveedor
        '
        Me.txtidproveedor.Enabled = False
        Me.txtidproveedor.Location = New System.Drawing.Point(261, 13)
        Me.txtidproveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtidproveedor.Name = "txtidproveedor"
        Me.txtidproveedor.Size = New System.Drawing.Size(55, 20)
        Me.txtidproveedor.TabIndex = 16
        '
        'txtdomicilio
        '
        Me.txtdomicilio.Enabled = False
        Me.txtdomicilio.Location = New System.Drawing.Point(59, 86)
        Me.txtdomicilio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdomicilio.Name = "txtdomicilio"
        Me.txtdomicilio.Size = New System.Drawing.Size(165, 20)
        Me.txtdomicilio.TabIndex = 17
        '
        'txttelefono
        '
        Me.txttelefono.Enabled = False
        Me.txttelefono.Location = New System.Drawing.Point(284, 84)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(115, 20)
        Me.txttelefono.TabIndex = 18
        '
        'txtsaldo
        '
        Me.txtsaldo.Enabled = False
        Me.txtsaldo.Location = New System.Drawing.Point(455, 84)
        Me.txtsaldo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.Size = New System.Drawing.Size(68, 20)
        Me.txtsaldo.TabIndex = 19
        '
        'txtidpago
        '
        Me.txtidpago.Enabled = False
        Me.txtidpago.Location = New System.Drawing.Point(607, 13)
        Me.txtidpago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtidpago.Name = "txtidpago"
        Me.txtidpago.Size = New System.Drawing.Size(68, 20)
        Me.txtidpago.TabIndex = 20
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(607, 82)
        Me.DTP1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(203, 20)
        Me.DTP1.TabIndex = 21
        '
        'cboidcompra
        '
        Me.cboidcompra.FormattingEnabled = True
        Me.cboidcompra.Location = New System.Drawing.Point(72, 299)
        Me.cboidcompra.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboidcompra.Name = "cboidcompra"
        Me.cboidcompra.Size = New System.Drawing.Size(82, 21)
        Me.cboidcompra.TabIndex = 22
        '
        'cbocondicion
        '
        Me.cbocondicion.FormattingEnabled = True
        Me.cbocondicion.Location = New System.Drawing.Point(99, 353)
        Me.cbocondicion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbocondicion.Name = "cbocondicion"
        Me.cbocondicion.Size = New System.Drawing.Size(125, 21)
        Me.cbocondicion.TabIndex = 23
        '
        'txtimpote
        '
        Me.txtimpote.Location = New System.Drawing.Point(312, 353)
        Me.txtimpote.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtimpote.Name = "txtimpote"
        Me.txtimpote.Size = New System.Drawing.Size(68, 20)
        Me.txtimpote.TabIndex = 24
        '
        'txtreferencia
        '
        Me.txtreferencia.Location = New System.Drawing.Point(312, 299)
        Me.txtreferencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtreferencia.Name = "txtreferencia"
        Me.txtreferencia.Size = New System.Drawing.Size(68, 20)
        Me.txtreferencia.TabIndex = 25
        '
        'Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 400)
        Me.Controls.Add(Me.txtreferencia)
        Me.Controls.Add(Me.txtimpote)
        Me.Controls.Add(Me.cbocondicion)
        Me.Controls.Add(Me.cboidcompra)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.txtidpago)
        Me.Controls.Add(Me.txtsaldo)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtdomicilio)
        Me.Controls.Add(Me.txtidproveedor)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.cmdnuevo)
        Me.Controls.Add(Me.cmdguardar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgpago)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Pagos"
        Me.Text = "Pagos"
        CType(Me.dgpago, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgpago As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmdguardar As Button
    Friend WithEvents cmdnuevo As Button
    Friend WithEvents cmdsalir As Button
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents txtidproveedor As TextBox
    Friend WithEvents txtdomicilio As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtsaldo As TextBox
    Friend WithEvents txtidpago As TextBox
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents cboidcompra As ComboBox
    Friend WithEvents cbocondicion As ComboBox
    Friend WithEvents txtimpote As TextBox
    Friend WithEvents txtreferencia As TextBox
End Class
