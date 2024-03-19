<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCompra3
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
        Me.dgcompra = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboproveedor = New System.Windows.Forms.ComboBox()
        CType(Me.dgcompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgcompra
        '
        Me.dgcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcompra.Location = New System.Drawing.Point(34, 235)
        Me.dgcompra.Name = "dgcompra"
        Me.dgcompra.RowHeadersWidth = 62
        Me.dgcompra.RowTemplate.Height = 28
        Me.dgcompra.Size = New System.Drawing.Size(1360, 223)
        Me.dgcompra.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(573, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Proveedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(538, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Consulta por proveedor"
        '
        'cboproveedor
        '
        Me.cboproveedor.FormattingEnabled = True
        Me.cboproveedor.Location = New System.Drawing.Point(664, 100)
        Me.cboproveedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboproveedor.Name = "cboproveedor"
        Me.cboproveedor.Size = New System.Drawing.Size(180, 28)
        Me.cboproveedor.TabIndex = 13
        '
        'ConsultaCompra3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1461, 692)
        Me.Controls.Add(Me.cboproveedor)
        Me.Controls.Add(Me.dgcompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ConsultaCompra3"
        Me.Text = "ConsultaCompra3"
        CType(Me.dgcompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgcompra As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboproveedor As ComboBox
End Class
