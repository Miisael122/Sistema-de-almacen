Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocios

Public Class ConsultaPagos1

    Dim objConecta As New Conexion
    Dim conec As SqlConnection = objConecta.Conecta
    Dim lector As SqlDataReader
    Dim comando As SqlCommand = conec.CreateCommand()
    Dim CapaNegocio As New consulta4

    Private Sub ConsultaPagos1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RemoveHandler cboproveedor.SelectedIndexChanged, AddressOf cboproveedor_SelectedIndexChanged
        cboproveedor.DataSource = CapaNegocio.cargacbo.Tables("SUBE")
        cboproveedor.DisplayMember = "nombre"
        cboproveedor.ValueMember = "nombre"
        AddHandler cboproveedor.SelectedIndexChanged, AddressOf cboproveedor_SelectedIndexChanged

    End Sub

    Private Sub cboproveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboproveedor.SelectedIndexChanged

        Dim r As String
        r = cboproveedor.Text
        dgventa.DataSource = CapaNegocio.mostrardatosp(r).Tables("SUBE2")

    End Sub
End Class