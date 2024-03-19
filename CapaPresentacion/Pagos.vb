Imports CapaNegocios
Imports CapaEntidad


Public Class Pagos

    Dim CapaNegocio As New PagosCN

    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RemoveHandler cboProveedor.SelectedIndexChanged, AddressOf cboProveedor_SelectedIndexChanged
        cboProveedor.DataSource = CapaNegocio.subecbo.Tables("SUBE")
        cboProveedor.DisplayMember = "nombre"
        cboProveedor.ValueMember = "nombre"
        AddHandler cboProveedor.SelectedIndexChanged, AddressOf cboProveedor_SelectedIndexChanged

        cbocondicion.Items.Add("Efectivo")
        cbocondicion.Items.Add("Cheque")
        cbocondicion.Items.Add("Transferencia")

    End Sub

    Private Sub cboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedor.SelectedIndexChanged

        Dim t As DataTable
        t = CapaNegocio.mostrardatosp(cboProveedor.Text).Tables("MUESTRA")
        Dim r As DataRow = t.Rows(Val(cbocondicion.SelectedValue))
        txtidproveedor.Text = r("idProveedor")
        txtdomicilio.Text = r("domicilio")
        txttelefono.Text = r("telefono")
        txtsaldo.Text = r("saldoProv")

        dgpago.DataSource = CapaNegocio.mostrardatos(cboProveedor.Text).Tables("MUESTRAD")

        RemoveHandler cboidcompra.SelectedIndexChanged, AddressOf cboidcompra_SelectedIndexChanged
        cboidcompra.DataSource = CapaNegocio.subecbo2(Val(txtidproveedor.Text)).Tables("SUBE2")
        cboidcompra.DisplayMember = "idCompra"
        cboidcompra.ValueMember = "idCompra"
        AddHandler cboProveedor.SelectedIndexChanged, AddressOf cboidcompra_SelectedIndexChanged

    End Sub

    Private Sub cboidcompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboidcompra.SelectedIndexChanged

    End Sub

    Private Sub cmdnuevo_Click(sender As Object, e As EventArgs) Handles cmdnuevo.Click
        cmdguardar.Enabled = True

        txtidpago.Text = CapaNegocio.nuevo
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Me.Dispose()
    End Sub

    Private Sub cmdguardar_Click(sender As Object, e As EventArgs) Handles cmdguardar.Click

        Dim fecha As String
        fecha = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day

        CapaNegocio.insertadatos(Val(cboidcompra.SelectedValue), fecha, cbocondicion.Text, txtreferencia.Text, CDbl(txtimpote.Text), cboProveedor.Text)
        cmdguardar.Enabled = False

    End Sub
End Class