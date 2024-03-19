Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocios

Public Class ConsultaPago3

    Dim objConecta As New Conexion
    Dim conec As SqlConnection = objConecta.Conecta
    Dim lector As SqlDataReader
    Dim comando As SqlCommand = conec.CreateCommand()
    Dim CapaNegocio As New consulta6

    Private Sub ConsultaPago3_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click

        Dim FI, FF As String
        FI = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day
        FF = DTP2.Value.Year & "/" & DTP2.Value.Month & "/" & DTP2.Value.Day
        dgventa.DataSource = CapaNegocio.mostrardatosp(FI, FF).Tables("SUBE2")


    End Sub
End Class