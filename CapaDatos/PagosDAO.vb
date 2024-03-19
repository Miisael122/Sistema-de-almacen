Imports System.Data.SqlClient
Imports CapaEntidad


Public Class PagosDAO

    Dim objConecta As New Conexion
    Dim conec As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim l As SqlDataReader


    Public Sub insertadatos(ByVal c1 As Integer, ByVal c2 As String, ByVal c3 As String, ByVal c4 As String, ByVal c5 As Double, ByVal nom As String)
        Try

            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("INSERTAPAGO", conec)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            adaptador.SelectCommand.Parameters.Add("@C1", SqlDbType.Int).Value = c1
            adaptador.SelectCommand.Parameters.Add("@C2", SqlDbType.VarChar).Value = c2
            adaptador.SelectCommand.Parameters.Add("@C3", SqlDbType.VarChar).Value = c3
            adaptador.SelectCommand.Parameters.Add("@C4", SqlDbType.VarChar).Value = c4
            adaptador.SelectCommand.Parameters.Add("@C5", SqlDbType.Money).Value = c5
            adaptador.SelectCommand.Parameters.Add("@NOM", SqlDbType.VarChar).Value = nom

            Dim resu As SqlParameter
            resu = adaptador.SelectCommand.Parameters.Add("@RESU", SqlDbType.Int)

            conec.Open()
            resu.Direction = ParameterDirection.Output
            adaptador.SelectCommand.ExecuteNonQuery()
            Dim r As Integer
            r = resu.Value
            MsgBox(r)
            If r = 1 Then
                MsgBox("Error")
            End If
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
            adaptador = New SqlDataAdapter("subirprov", conec)
            adaptador.Fill(data, "SUBE")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()
    End Function

    Public Function subecbo2(ByVal ipd As Integer) As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("subiridcompra", conec)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            adaptador.SelectCommand.Parameters.Add("@IDP", SqlDbType.Int).Value = ipd
            adaptador.Fill(data, "SUBE2")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()
    End Function

    Public Function mostrardatosp(ByVal nom As String) As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("datosprov", conec)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            adaptador.SelectCommand.Parameters.Add("@NOM", SqlDbType.VarChar).Value = nom
            adaptador.Fill(data, "MUESTRA")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()
    End Function

    Public Function mostrardatos(ByVal pr As String) As DataSet
        Using data As New DataSet
            conec = objConecta.Conecta
            adaptador = New SqlDataAdapter("comprasprov", conec)
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            adaptador.SelectCommand.Parameters.Add("@PROV", SqlDbType.VarChar).Value = pr
            adaptador.Fill(data, "MUESTRAD")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()
    End Function

    Public Function nuevo() As Integer
        conec = objConecta.Conecta
        Dim comando As SqlCommand = conec.CreateCommand
        Dim n As Integer
        conec.Open()
        comando.CommandText = "select count(*) from pagos"
        l = comando.ExecuteReader
        l.Read()
        n = l(0)
        l.Close()
        n += 1
        conec.Close()
        Return n
    End Function

End Class
