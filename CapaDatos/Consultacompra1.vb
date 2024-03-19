Imports System.Data.SqlClient
Imports CapaEntidad

Public Class Consultacompra1

    Dim objConecta As New Conexion
    Dim conec As SqlConnection = objConecta.Conecta
    Dim lector As SqlDataReader
    Dim comando As SqlCommand = conec.CreateCommand()
    Dim adaptador As SqlDataAdapter

    Public Function cargacbo() As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("Select * From compra", conec)
            adaptador.Fill(data, "SUBE")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()

    End Function

    Public Function mostrardatosp(ByVal p1 As Integer) As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("consulta1", conec)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            adaptador.SelectCommand.Parameters.Add("@p1", SqlDbType.Int).Value = p1
            adaptador.Fill(data, "SUBE2")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()

    End Function

End Class
