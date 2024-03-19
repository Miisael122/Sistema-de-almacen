Imports System.Data.SqlClient
Imports CapaEntidad

Public Class ConsultaPagos1

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
            adaptador = New SqlDataAdapter("select p.idPago, p.idCompra, pr.nombre, pr.saldoProv, c.saldoComp, p.fecha, p.formapago, p.importe from pagos as p inner join compra as c on p.idCompra=c.idCompra inner join proveedores as pr on c.idProveedor=pr.idProveedor where pr.nombre ='" & p1 & "'", conec)
            adaptador.Fill(data, "SUBE2")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()

    End Function

End Class
