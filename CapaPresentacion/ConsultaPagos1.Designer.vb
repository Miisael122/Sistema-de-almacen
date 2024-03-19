<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaPagos1
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
        Me.cboproveedor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgventa = New System.Windows.Forms.DataGridView()
        CType(Me.dgventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboproveedor
        '
        Me.cboproveedor.FormattingEnabled = True
        Me.cboproveedor.Location = New System.Drawing.Point(681, 103)
        Me.cboproveedor.Name = "cboproveedor"
        Me.cboproveedor.Size = New System.Drawing.Size(192, 28)
        Me.cboproveedor.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(570, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Proveedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(540, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Consulta por proveedor"
        '
        'dgventa
        '
        Me.dgventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgventa.Location = New System.Drawing.Point(16, 197)
        Me.dgventa.Name = "dgventa"
        Me.dgventa.RowHeadersWidth = 62
        Me.dgventa.RowTemplate.Height = 28
        Me.dgventa.Size = New System.Drawing.Size(1473, 151)
        Me.dgventa.TabIndex = 6
        '
        'ConsultaPagos1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1556, 449)
        Me.Controls.Add(Me.dgventa)
        Me.Controls.Add(Me.cboproveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsultaPagos1"
        Me.Text = "ConsultaPagos1"
        CType(Me.dgventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboproveedor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgventa As DataGridView
End Class
