Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaNegocios
Imports CapaDatos

Public Class ConsultaCompra1

    Dim objConecta As New Conexion
    Dim conec As SqlConnection = objConecta.Conecta
    Dim lector As SqlDataReader
    Dim comando As SqlCommand = conec.CreateCommand()
    Dim CapaNegocio As New Consulta1


    Private Sub ConsultaCompra1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RemoveHandler cboproveedor.SelectedIndexChanged, AddressOf cboproveedor_SelectedIndexChanged
        cboproveedor.DataSource = CapaNegocio.cargacbo.Tables("SUBE")
        cboproveedor.DisplayMember = "idCompra"
        cboproveedor.ValueMember = "idCompra"
        AddHandler cboproveedor.SelectedIndexChanged, AddressOf cboproveedor_SelectedIndexChanged

    End Sub

    Private Sub cboproveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboproveedor.SelectedIndexChanged
        Dim r As Integer
        r = Val(cboproveedor.Text)
        dgcompra.DataSource = CapaNegocio.mostrardatosp(r).Tables("SUBE2")

    End Sub
End Class