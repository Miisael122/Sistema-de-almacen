Imports System.Data.SqlClient
Imports CapaEntidad

Public Class ConsultaCompra2

    Dim objConecta As New Conexion
    Dim conec As SqlConnection = objConecta.Conecta
    Dim lector As SqlDataReader
    Dim comando As SqlCommand = conec.CreateCommand()
    Dim adaptador As SqlDataAdapter

    Public Function mostrardatosp(ByVal f1 As String, ByVal f2 As String) As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("select c.idCompra, c.idProveedor, p.nombre, p.saldoProv, c.fechaCompra, c.subtotal, c.iva, c.total, c.saldoComp from compra as c inner join proveedores as p on c.idProveedor = p.idProveedor where c.fechaCompra >='" & f1 & "' and c.fechaCompra <='" & f2 & "'", conec)
            adaptador.Fill(data, "SUBE")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()

    End Function

End Class
