﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte4
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
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(144, 188)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox2.TabIndex = 19
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(144, 129)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(156, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "hasta: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Ventas con un total de: "
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 34)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Reporte de compras por precio total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Reporte4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 344)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Reporte4"
        Me.Text = "Reporte4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
