Imports System.Data.SqlClient
Imports CapaEntidad

Public Class ProductosDAO

    Dim objConecta As New Conexion
    Dim conec As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim comando As SqlCommand

    Public Function mostrardatos() As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("DATOSPRODUCT", conec)
            adaptador.Fill(data, "MUESTRA")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()
    End Function

    Public Sub insertadatos(ByVal c2 As Integer, ByVal c3 As String, ByVal c4 As Double, ByVal c5 As Double, ByVal c6 As Integer, ByVal c7 As Integer, ByVal c8 As Integer)
        Try
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("INSERTAREGPRODUCT", conec)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            adaptador.SelectCommand.Parameters.Add("@C2", SqlDbType.Int).Value = c2
            adaptador.SelectCommand.Parameters.Add("@C3", SqlDbType.VarChar).Value = c3
            adaptador.SelectCommand.Parameters.Add("@C4", SqlDbType.Money).Value = c4
            adaptador.SelectCommand.Parameters.Add("@C5", SqlDbType.Money).Value = c5
            adaptador.SelectCommand.Parameters.Add("@C6", SqlDbType.Int).Value = c6
            adaptador.SelectCommand.Parameters.Add("@C7", SqlDbType.Int).Value = c7
            adaptador.SelectCommand.Parameters.Add("@C8", SqlDbType.Int).Value = c8
            conec.Open()
            adaptador.SelectCommand.ExecuteNonQuery()
            conec.Close()
        Catch
            MsgBox("Ocurrió un error " & Err.Description)
        Finally
            adaptador.Dispose()
            conec.Dispose()
        End Try

    End Sub

    Public Function subecbo() As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("SUBECBOPRODUCTO", conec)
            adaptador.Fill(data, "SUBE")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()
    End Function

End Class
