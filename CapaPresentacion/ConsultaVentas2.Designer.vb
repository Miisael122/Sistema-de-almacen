<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaVentas2
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
        Me.dgpago = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgpago2 = New System.Windows.Forms.DataGridView()
        Me.cboventa = New System.Windows.Forms.ComboBox()
        CType(Me.dgpago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpago2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgpago
        '
        Me.dgpago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpago.Location = New System.Drawing.Point(34, 205)
        Me.dgpago.Name = "dgpago"
        Me.dgpago.RowHeadersWidth = 62
        Me.dgpago.RowTemplate.Height = 28
        Me.dgpago.Size = New System.Drawing.Size(841, 151)
        Me.dgpago.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Consulta por id Venta"
        '
        'dgpago2
        '
        Me.dgpago2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpago2.Location = New System.Drawing.Point(110, 406)
        Me.dgpago2.Name = "dgpago2"
        Me.dgpago2.RowHeadersWidth = 62
        Me.dgpago2.RowTemplate.Height = 28
        Me.dgpago2.Size = New System.Drawing.Size(683, 151)
        Me.dgpago2.TabIndex = 19
        '
        'cboventa
        '
        Me.cboventa.FormattingEnabled = True
        Me.cboventa.Location = New System.Drawing.Point(367, 121)
        Me.cboventa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboventa.Name = "cboventa"
        Me.cboventa.Size = New System.Drawing.Size(180, 28)
        Me.cboventa.TabIndex = 20
        '
        'ConsultaVentas2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 692)
        Me.Controls.Add(Me.cboventa)
        Me.Controls.Add(Me.dgpago2)
        Me.Controls.Add(Me.dgpago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ConsultaVentas2"
        Me.Text = "ConsultaVentas2"
        CType(Me.dgpago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpago2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgpago As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgpago2 As DataGridView
    Friend WithEvents cboventa As ComboBox
End Class
