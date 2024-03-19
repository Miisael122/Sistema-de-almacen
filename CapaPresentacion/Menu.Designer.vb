<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menucont
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
        Me.components = New System.ComponentModel.Container()
        Me.cabecera = New System.Windows.Forms.Panel()
        Me.cmdrestaurar = New System.Windows.Forms.Button()
        Me.cmdmin = New System.Windows.Forms.Button()
        Me.cmdmax = New System.Windows.Forms.Button()
        Me.cmdsalir = New System.Windows.Forms.Button()
        Me.menuop = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdmenu = New System.Windows.Forms.PictureBox()
        Me.tmOcultarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.cabecera.SuspendLayout()
        Me.menuop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cabecera
        '
        Me.cabecera.BackColor = System.Drawing.Color.Goldenrod
        Me.cabecera.Controls.Add(Me.cmdrestaurar)
        Me.cabecera.Controls.Add(Me.cmdmin)
        Me.cabecera.Controls.Add(Me.cmdmax)
        Me.cabecera.Controls.Add(Me.cmdsalir)
        Me.cabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.cabecera.Location = New System.Drawing.Point(0, 0)
        Me.cabecera.Margin = New System.Windows.Forms.Padding(2)
        Me.cabecera.Name = "cabecera"
        Me.cabecera.Size = New System.Drawing.Size(1132, 26)
        Me.cabecera.TabIndex = 0
        '
        'cmdrestaurar
        '
        Me.cmdrestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdrestaurar.BackColor = System.Drawing.Color.Goldenrod
        Me.cmdrestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdrestaurar.FlatAppearance.BorderSize = 0
        Me.cmdrestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.cmdrestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmdrestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdrestaurar.Image = Global.CapaPresentacion.My.Resources.Resources.Icono_Restaurar
        Me.cmdrestaurar.Location = New System.Drawing.Point(1072, 0)
        Me.cmdrestaurar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdrestaurar.Name = "cmdrestaurar"
        Me.cmdrestaurar.Size = New System.Drawing.Size(27, 26)
        Me.cmdrestaurar.TabIndex = 3
        Me.cmdrestaurar.UseVisualStyleBackColor = False
        Me.cmdrestaurar.Visible = False
        '
        'cmdmin
        '
        Me.cmdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdmin.BackColor = System.Drawing.Color.Goldenrod
        Me.cmdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdmin.FlatAppearance.BorderSize = 0
        Me.cmdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.cmdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdmin.Image = Global.CapaPresentacion.My.Resources.Resources.Icono_Minimizar
        Me.cmdmin.Location = New System.Drawing.Point(1042, 0)
        Me.cmdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdmin.Name = "cmdmin"
        Me.cmdmin.Size = New System.Drawing.Size(27, 26)
        Me.cmdmin.TabIndex = 2
        Me.cmdmin.UseVisualStyleBackColor = False
        '
        'cmdmax
        '
        Me.cmdmax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdmax.BackColor = System.Drawing.Color.Goldenrod
        Me.cmdmax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdmax.FlatAppearance.BorderSize = 0
        Me.cmdmax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.cmdmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmdmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdmax.Image = Global.CapaPresentacion.My.Resources.Resources.Icono_Maximizar
        Me.cmdmax.Location = New System.Drawing.Point(1072, 0)
        Me.cmdmax.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdmax.Name = "cmdmax"
        Me.cmdmax.Size = New System.Drawing.Size(27, 26)
        Me.cmdmax.TabIndex = 1
        Me.cmdmax.UseVisualStyleBackColor = False
        '
        'cmdsalir
        '
        Me.cmdsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdsalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdsalir.FlatAppearance.BorderSize = 0
        Me.cmdsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.cmdsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmdsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdsalir.Image = Global.CapaPresentacion.My.Resources.Resources.Icono_cerrar_FN
        Me.cmdsalir.Location = New System.Drawing.Point(1102, 0)
        Me.cmdsalir.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(27, 26)
        Me.cmdsalir.TabIndex = 0
        Me.cmdsalir.UseVisualStyleBackColor = True
        '
        'menuop
        '
        Me.menuop.BackColor = System.Drawing.Color.SteelBlue
        Me.menuop.Controls.Add(Me.Panel9)
        Me.menuop.Controls.Add(Me.Button9)
        Me.menuop.Controls.Add(Me.Panel8)
        Me.menuop.Controls.Add(Me.Button8)
        Me.menuop.Controls.Add(Me.Panel7)
        Me.menuop.Controls.Add(Me.Panel6)
        Me.menuop.Controls.Add(Me.Button7)
        Me.menuop.Controls.Add(Me.Button6)
        Me.menuop.Controls.Add(Me.Panel2)
        Me.menuop.Controls.Add(Me.Button2)
        Me.menuop.Controls.Add(Me.Panel1)
        Me.menuop.Controls.Add(Me.Button1)
        Me.menuop.Controls.Add(Me.Panel5)
        Me.menuop.Controls.Add(Me.Button5)
        Me.menuop.Controls.Add(Me.Panel4)
        Me.menuop.Controls.Add(Me.Button4)
        Me.menuop.Controls.Add(Me.Panel3)
        Me.menuop.Controls.Add(Me.Button3)
        Me.menuop.Controls.Add(Me.PictureBox1)
        Me.menuop.Controls.Add(Me.cmdmenu)
        Me.menuop.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuop.Location = New System.Drawing.Point(0, 26)
        Me.menuop.Margin = New System.Windows.Forms.Padding(2)
        Me.menuop.Name = "menuop"
        Me.menuop.Size = New System.Drawing.Size(190, 728)
        Me.menuop.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel9.Location = New System.Drawing.Point(0, 606)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(5, 50)
        Me.Panel9.TabIndex = 17
        '
        'Button9
        '
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(0, 604)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(190, 50)
        Me.Button9.TabIndex = 18
        Me.Button9.Text = "Espejo"
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel8.Location = New System.Drawing.Point(0, 546)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 50)
        Me.Panel8.TabIndex = 15
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Image = Global.CapaPresentacion.My.Resources.Resources.empleados
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(0, 544)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(190, 50)
        Me.Button8.TabIndex = 16
        Me.Button8.Text = "Reportes y Respaldos"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel7.Location = New System.Drawing.Point(0, 490)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 50)
        Me.Panel7.TabIndex = 13
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel6.Location = New System.Drawing.Point(0, 434)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 11
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = Global.CapaPresentacion.My.Resources.Resources.relo3
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(0, 488)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(190, 50)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Consultas"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Global.CapaPresentacion.My.Resources.Resources.pagos
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 432)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(190, 50)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Pagos"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel2.Location = New System.Drawing.Point(0, 154)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.CapaPresentacion.My.Resources.Resources.producto
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 50)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Categorías"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.Location = New System.Drawing.Point(0, 210)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.CapaPresentacion.My.Resources.Resources.venta
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 50)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Productos"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel5.Location = New System.Drawing.Point(0, 376)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 10
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = Global.CapaPresentacion.My.Resources.Resources.compras
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 378)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(190, 50)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Compras"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel4.Location = New System.Drawing.Point(0, 320)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.CapaPresentacion.My.Resources.Resources.reportes
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 320)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(190, 50)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Ventas"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel3.Location = New System.Drawing.Point(0, 264)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.CapaPresentacion.My.Resources.Resources.clientes
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 266)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(190, 50)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Proveedores"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CapaPresentacion.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(48, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cmdmenu
        '
        Me.cmdmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdmenu.Image = Global.CapaPresentacion.My.Resources.Resources.Mobile_Menu_Icon
        Me.cmdmenu.Location = New System.Drawing.Point(147, 0)
        Me.cmdmenu.Name = "cmdmenu"
        Me.cmdmenu.Size = New System.Drawing.Size(36, 32)
        Me.cmdmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cmdmenu.TabIndex = 1
        Me.cmdmenu.TabStop = False
        '
        'tmOcultarmenu
        '
        '
        'tmMostrarmenu
        '
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(190, 26)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(942, 728)
        Me.PanelContenedor.TabIndex = 2
        '
        'Menucont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 754)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.menuop)
        Me.Controls.Add(Me.cabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Menucont"
        Me.Text = "Menu"
        Me.cabecera.ResumeLayout(False)
        Me.menuop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cabecera As Panel
    Friend WithEvents cmdsalir As Button
    Friend WithEvents menuop As Panel
    Friend WithEvents cmdmax As Button
    Friend WithEvents cmdmin As Button
    Friend WithEvents cmdrestaurar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdmenu As PictureBox
    Friend WithEvents tmOcultarmenu As Timer
    Friend WithEvents tmMostrarmenu As Timer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button9 As Button
End Class
