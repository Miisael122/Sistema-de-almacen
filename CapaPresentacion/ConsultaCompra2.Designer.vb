<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCompra2
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
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgcompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgcompra
        '
        Me.dgcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcompra.Location = New System.Drawing.Point(34, 243)
        Me.dgcompra.Name = "dgcompra"
        Me.dgcompra.RowHeadersWidth = 62
        Me.dgcompra.RowTemplate.Height = 28
        Me.dgcompra.Size = New System.Drawing.Size(1360, 223)
        Me.dgcompra.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(536, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "FI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(604, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Consulta por periodo"
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(597, 69)
        Me.DTP1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(338, 26)
        Me.DTP1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(702, 168)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Consulta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DTP2
        '
        Me.DTP2.Location = New System.Drawing.Point(597, 117)
        Me.DTP2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(338, 26)
        Me.DTP2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(536, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "FF"
        '
        'ConsultaCompra2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1442, 692)
        Me.Controls.Add(Me.DTP2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.dgcompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ConsultaCompra2"
        Me.Text = "ConsultaCompra2"
        CType(Me.dgcompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgcompra As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents DTP2 As DateTimePicker
    Friend WithEvents Label3 As Label
End Class
