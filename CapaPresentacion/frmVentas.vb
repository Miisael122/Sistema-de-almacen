Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaNegocios
Imports CapaDatos


Public Class frmVentas

    Dim CapaNegocio As New VentasCN
    Dim cdatos As New VentasDAO
    Dim objConecta As New Conexion



    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RemoveHandler cboproducto.SelectedIndexChanged, AddressOf cboproducto_SelectedIndexChanged
        cboproducto.DataSource = CapaNegocio.subecbo.Tables("SUBE")
        cboproducto.DisplayMember = "nombreProducto"
        cboproducto.ValueMember = "idProducto"
        AddHandler cboproducto.SelectedIndexChanged, AddressOf cboproducto_SelectedIndexChanged

    End Sub

    Private Sub cboproducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboproducto.SelectedIndexChanged
        txtprecio.Text = CapaNegocio.precio(cboproducto.SelectedValue)
        txtExistencia.Text = CapaNegocio.cantidad(cboproducto.SelectedValue)

    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

        Dim importe, importef, iva As Double

        importe = CDbl(txtcantidad.Text) * CDbl(txtprecio.Text)
        iva = importe * 0.16
        importef = iva + importe
        txtsubtotal.Text = Val(txtsubtotal.Text) + CStr(importe)
        txtiva.Text = Val(txtiva.Text) + CStr(iva)
        txttotal.Text = Val(txttotal.Text) + CStr(importef)

        dgventa.Rows.Add(txtidVenta.Text, cboproducto.SelectedValue, txtcantidad.Text, txtprecio.Text)

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        txtidVenta.Text = CapaNegocio.nuevo
        dgventa.Rows.Clear()

        txtsubtotal.Text = ""
        txtiva.Text = ""
        txttotal.Text = ""

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim fecha As String
        Dim k8 As Integer
        Dim datos(,) As String = New String(dgventa.Rows.Count - 2, 4) {}

        k8 = 0
        fecha = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day

        For i = 0 To dgventa.Rows.Count() - 2


            datos(i, 0) = dgventa.Item(0, i).Value
            datos(i, 1) = dgventa.Item(1, i).Value
            datos(i, 2) = dgventa.Item(2, i).Value
            datos(i, 3) = dgventa.Item(3, i).Value


        Next i

        CapaNegocio.insertadatos(datos, fecha, CDbl(txtsubtotal.Text), CDbl(txtiva.Text), CDbl(txttotal.Text), Val(dgventa.Rows.Count() - 2), Val(txtidVenta.Text))



        'For i = 0 To dgventa.Rows.Count() - 2

        'CapaNegocio.insertadatos(Val(dgventa.Item(0, i).Value), Val(dgventa.Item(1, i).Value), Val(dgventa.Item(2, i).Value), CDbl(dgventa.Item(3, i).Value), fecha, CDbl(txtsubtotal.Text), CDbl(txtiva.Text), CDbl(txttotal.Text), k8)

        'k8 = 1

        'Next i





    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Public Sub dgventa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgventa.CellContentClick

    End Sub
End Class