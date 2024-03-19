Imports System.Data.SqlClient
Imports CapaEntidad


Public Class ConsultaCompra3

    Dim objConecta As New Conexion
    Dim conec As SqlConnection = objConecta.Conecta
    Dim lector As SqlDataReader
    Dim comando As SqlCommand = conec.CreateCommand()
    Dim adaptador As SqlDataAdapter

    Public Function cargacbo() As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("Select * From proveedores", conec)
            adaptador.Fill(data, "SUBE")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()

    End Function

    Public Function mostrardatosp(ByVal p1 As String) As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("select c.idCompra, c.idProveedor, p.nombre, p.saldoProv, c.fechaCompra, c.subtotal, c.iva, c.total, c.saldoComp from compra as c inner join proveedores as p on c.idProveedor = p.idProveedor where p.nombre='" & p1 & "'", conec)
            adaptador.Fill(data, "SUBE2")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()

    End Function

End Class
