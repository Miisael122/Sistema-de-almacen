<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaVentas1
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
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.dgpago = New System.Windows.Forms.DataGridView()
        Me.dgpago2 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgpago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpago2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Consulta por periodo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha de inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha de final:"
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(386, 97)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(296, 26)
        Me.DTP1.TabIndex = 7
        '
        'DTP2
        '
        Me.DTP2.Location = New System.Drawing.Point(386, 144)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(296, 26)
        Me.DTP2.TabIndex = 8
        '
        'dgpago
        '
        Me.dgpago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpago.Location = New System.Drawing.Point(38, 286)
        Me.dgpago.Name = "dgpago"
        Me.dgpago.RowHeadersWidth = 62
        Me.dgpago.RowTemplate.Height = 28
        Me.dgpago.Size = New System.Drawing.Size(850, 151)
        Me.dgpago.TabIndex = 9
        '
        'dgpago2
        '
        Me.dgpago2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpago2.Location = New System.Drawing.Point(188, 477)
        Me.dgpago2.Name = "dgpago2"
        Me.dgpago2.RowHeadersWidth = 62
        Me.dgpago2.RowTemplate.Height = 28
        Me.dgpago2.Size = New System.Drawing.Size(538, 151)
        Me.dgpago2.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(415, 214)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Consulta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ConsultaVentas1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 637)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgpago2)
        Me.Controls.Add(Me.dgpago)
        Me.Controls.Add(Me.DTP2)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsultaVentas1"
        Me.Text = "ConsultaVentas1"
        CType(Me.dgpago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpago2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents DTP2 As DateTimePicker
    Friend WithEvents dgpago As DataGridView
    Friend WithEvents dgpago2 As DataGridView
    Friend WithEvents Button1 As Button
End Class
