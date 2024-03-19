Imports System.Data.SqlClient
Imports CapaEntidad

Public Class ProveedoresDAO

    Dim objConecta As New Conexion
    Dim conec As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim comando As SqlCommand

    Public Function mostrardatos() As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("DATOSPROVE", conec)
            adaptador.Fill(data, "MUESTRA")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()
    End Function

    Public Sub insertadatos(ByVal c2 As String, ByVal c3 As String, ByVal c4 As String, ByVal c5 As String, ByVal c6 As String, ByVal c7 As String, ByVal c8 As String, ByVal c9 As String, ByVal c10 As Double)
        Try
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("INSERTAREGPROV", conec)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            adaptador.SelectCommand.Parameters.Add("@C2", SqlDbType.VarChar).Value = c2
            adaptador.SelectCommand.Parameters.Add("@C3", SqlDbType.VarChar).Value = c3
            adaptador.SelectCommand.Parameters.Add("@C4", SqlDbType.VarChar).Value = c4
            adaptador.SelectCommand.Parameters.Add("@C5", SqlDbType.VarChar).Value = c5
            adaptador.SelectCommand.Parameters.Add("@C6", SqlDbType.VarChar).Value = c6
            adaptador.SelectCommand.Parameters.Add("@C7", SqlDbType.VarChar).Value = c7
            adaptador.SelectCommand.Parameters.Add("@C8", SqlDbType.VarChar).Value = c8
            adaptador.SelectCommand.Parameters.Add("@C9", SqlDbType.VarChar).Value = c9
            adaptador.SelectCommand.Parameters.Add("@C10", SqlDbType.Money).Value = c10
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
