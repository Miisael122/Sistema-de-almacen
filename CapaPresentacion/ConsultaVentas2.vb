Imports System.Data.SqlClient
Imports CapaNegocios
Imports CapaDatos


Public Class ConsultaVentas2

    Dim objConecta As New Conexion
    Dim conec As SqlConnection = objConecta.Conecta
    Dim lector As SqlDataReader
    Dim comando As SqlCommand = conec.CreateCommand()
    Dim CapaNegocio As New consulta8

    Private Sub ConsultaVentas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RemoveHandler cboventa.SelectedIndexChanged, AddressOf cboventa_SelectedIndexChanged
        cboventa.DataSource = CapaNegocio.cargacbo.Tables("SUBE")
        cboventa.DisplayMember = "idVenta"
        cboventa.ValueMember = "idVenta"
        AddHandler cboventa.SelectedIndexChanged, AddressOf cboventa_SelectedIndexChanged

    End Sub

    Private Sub cboventa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboventa.SelectedIndexChanged
        Dim r As Integer
        r = Val(cboventa.Text)
        dgpago.DataSource = CapaNegocio.mostrardatosp(r).Tables("SUBE")

    End Sub

    Private Sub dgpago_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgpago.CellContentClick

        Dim r2 As Integer

        r2 = dgpago.Rows(e.RowIndex).Cells(0).Value

        dgpago2.DataSource = CapaNegocio.mostrardatosp2(r2).Tables("SUBE2")

    End Sub
End Class

