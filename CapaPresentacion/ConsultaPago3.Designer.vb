<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaPago3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.Consultar = New System.Windows.Forms.Button()
        CType(Me.dgventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgventa
        '
        Me.dgventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgventa.Location = New System.Drawing.Point(26, 285)
        Me.dgventa.Name = "dgventa"
        Me.dgventa.RowHeadersWidth = 62
        Me.dgventa.RowTemplate.Height = 28
        Me.dgventa.Size = New System.Drawing.Size(1500, 151)
        Me.dgventa.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(546, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 37)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Consulta por Periodo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(498, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Primera fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(498, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Segunda fecha"
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(633, 103)
        Me.DTP1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(318, 26)
        Me.DTP1.TabIndex = 17
        '
        'DTP2
        '
        Me.DTP2.Location = New System.Drawing.Point(633, 157)
        Me.DTP2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(318, 26)
        Me.DTP2.TabIndex = 18
        '
        'Consultar
        '
        Me.Consultar.Location = New System.Drawing.Point(664, 222)
        Me.Consultar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(112, 35)
        Me.Consultar.TabIndex = 19
        Me.Consultar.Text = "Consultar"
        Me.Consultar.UseVisualStyleBackColor = True
        '
        'ConsultaPago3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1542, 692)
        Me.Controls.Add(Me.Consultar)
        Me.Controls.Add(Me.DTP2)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgventa)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ConsultaPago3"
        Me.Text = "ConsultaPago3"
        CType(Me.dgventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgventa As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents DTP2 As DateTimePicker
    Friend WithEvents Consultar As Button
End Class
