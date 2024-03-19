Imports System.Data.SqlClient
Imports CapaEntidad

Public Class ConsultaVentas1

    Dim objConecta As New Conexion
    Dim conec As SqlConnection = objConecta.Conecta
    Dim lector As SqlDataReader
    Dim comando As SqlCommand = conec.CreateCommand()
    Dim adaptador As SqlDataAdapter

    Public Function mostrardatosp(ByVal f1 As String, ByVal f2 As String) As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("select * from ventas where fechaVenta >= '" & f1 & "' and fechaVenta <='" & f2 & "'", conec)
            adaptador.Fill(data, "SUBE")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()

    End Function

    Public Function mostrardatosp2(ByVal p1 As Integer) As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("select * from detventa where idVenta=" & p1, conec)
            adaptador.Fill(data, "SUBE2")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()

    End Function

End Class
