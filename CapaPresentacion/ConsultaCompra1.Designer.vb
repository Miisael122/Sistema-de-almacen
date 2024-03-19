<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaCompra1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboproveedor = New System.Windows.Forms.ComboBox()
        Me.dgcompra = New System.Windows.Forms.DataGridView()
        CType(Me.dgcompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(502, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consulta por id de Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(532, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Compra"
        '
        'cboproveedor
        '
        Me.cboproveedor.FormattingEnabled = True
        Me.cboproveedor.Location = New System.Drawing.Point(644, 103)
        Me.cboproveedor.Name = "cboproveedor"
        Me.cboproveedor.Size = New System.Drawing.Size(192, 28)
        Me.cboproveedor.TabIndex = 2
        '
        'dgcompra
        '
        Me.dgcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcompra.Location = New System.Drawing.Point(12, 198)
        Me.dgcompra.Name = "dgcompra"
        Me.dgcompra.RowHeadersWidth = 62
        Me.dgcompra.RowTemplate.Height = 28
        Me.dgcompra.Size = New System.Drawing.Size(1360, 223)
        Me.dgcompra.TabIndex = 3
        '
        'ConsultaCompra1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1409, 460)
        Me.Controls.Add(Me.dgcompra)
        Me.Controls.Add(Me.cboproveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsultaCompra1"
        Me.Text = "ConsultaCompra1"
        CType(Me.dgcompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents cboproveedor As Windows.Forms.ComboBox
    Friend WithEvents dgcompra As Windows.Forms.DataGridView
End Class
