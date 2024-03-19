Imports System.Data.SqlClient
Imports CapaNegocios
Imports CapaDatos

Public Class ConsultasVentas3

    Dim objConecta As New Conexion
    Dim conec As SqlConnection = objConecta.Conecta
    Dim lector As SqlDataReader
    Dim comando As SqlCommand = conec.CreateCommand()
    Dim CapaNegocio As New consulta9

    Private Sub ConsultasVentas3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conec.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim r As Double
        r = CDbl(txtprecio.Text)
        dgpago.DataSource = CapaNegocio.mostrardatosp(r).Tables("SUBE")

    End Sub

    Private Sub dgpago_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgpago.CellContentClick

        Dim r2 As Integer

        r2 = dgpago.Rows(e.RowIndex).Cells(0).Value

        dgpago2.DataSource = CapaNegocio.mostrardatosp2(r2).Tables("SUBE2")

    End Sub

End Class