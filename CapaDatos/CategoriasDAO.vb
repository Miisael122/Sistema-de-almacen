Imports System.Data.SqlClient
Imports CapaEntidad

Public Class CategoriasDAO

    Dim objConecta As New Conexion
    Dim conec As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim comando As SqlCommand

    Public Function mostrardatos() As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("MOSTRARDATOS", conec)
            adaptador.Fill(data, "MUESTRA")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()
    End Function

    Public Sub insertadatos(ByVal e As String)
        Try
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("INSERTAREG", conec)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            adaptador.SelectCommand.Parameters.Add("@CON", SqlDbType.VarChar).Value = e
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

End Class
