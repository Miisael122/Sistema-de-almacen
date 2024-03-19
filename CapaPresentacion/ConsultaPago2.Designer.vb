<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaPago2
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
        Me.dgventa = New System.Windows.Forms.DataGridView()
        Me.cboproveedor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgventa
        '
        Me.dgventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgventa.Location = New System.Drawing.Point(26, 217)
        Me.dgventa.Name = "dgventa"
        Me.dgventa.RowHeadersWidth = 62
        Me.dgventa.RowTemplate.Height = 28
        Me.dgventa.Size = New System.Drawing.Size(1500, 151)
        Me.dgventa.TabIndex = 10
        '
        'cboproveedor
        '
        Me.cboproveedor.FormattingEnabled = True
        Me.cboproveedor.Location = New System.Drawing.Point(663, 123)
        Me.cboproveedor.Name = "cboproveedor"
        Me.cboproveedor.Size = New System.Drawing.Size(192, 28)
        Me.cboproveedor.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(579, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Pago"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(549, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Consulta por id de Pago"
        '
        'ConsultaPago2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1545, 692)
        Me.Controls.Add(Me.dgventa)
        Me.Controls.Add(Me.cboproveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ConsultaPago2"
        Me.Text = "ConsultaPago2"
        CType(Me.dgventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgventa As DataGridView
    Friend WithEvents cboproveedor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
