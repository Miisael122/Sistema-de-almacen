Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocios

Public Class ConsultaCompra2

    Dim objConecta As New Conexion
    Dim conec As SqlConnection = objConecta.Conecta
    Dim lector As SqlDataReader
    Dim comando As SqlCommand = conec.CreateCommand()
    Dim CapaNegocio As New consulta2

    Private Sub ConsultaCompra2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conec.Open()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim FI, FF As String
        FI = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day
        FF = DTP2.Value.Year & "/" & DTP2.Value.Month & "/" & DTP2.Value.Day

        dgcompra.DataSource = CapaNegocio.mostrardatosp(FI, FF).Tables("SUBE")


    End Sub
End Class