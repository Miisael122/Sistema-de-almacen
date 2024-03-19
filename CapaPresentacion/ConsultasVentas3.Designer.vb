<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultasVentas3
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
        Me.dgpago2 = New System.Windows.Forms.DataGridView()
        Me.dgpago = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgpago2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgpago2
        '
        Me.dgpago2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpago2.Location = New System.Drawing.Point(140, 421)
        Me.dgpago2.Name = "dgpago2"
        Me.dgpago2.RowHeadersWidth = 62
        Me.dgpago2.RowTemplate.Height = 28
        Me.dgpago2.Size = New System.Drawing.Size(662, 151)
        Me.dgpago2.TabIndex = 24
        '
        'dgpago
        '
        Me.dgpago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpago.Location = New System.Drawing.Point(50, 220)
        Me.dgpago.Name = "dgpago"
        Me.dgpago.RowHeadersWidth = 62
        Me.dgpago.RowTemplate.Height = 28
        Me.dgpago.Size = New System.Drawing.Size(838, 151)
        Me.dgpago.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Ventas con un total mayor a:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 37)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Consulta por precio"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(387, 125)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(148, 26)
        Me.txtprecio.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(401, 161)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Consulta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ConsultasVentas3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 599)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.dgpago2)
        Me.Controls.Add(Me.dgpago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ConsultasVentas3"
        Me.Text = "ConsultasVentas3"
        CType(Me.dgpago2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgpago2 As DataGridView
    Friend WithEvents dgpago As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Button1 As Button
End Class
