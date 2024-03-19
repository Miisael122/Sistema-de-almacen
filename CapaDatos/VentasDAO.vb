Imports System.Data.SqlClient
Imports CapaEntidad



Public Class VentasDAO

    Dim objConecta As New Conexion
    Dim conec As SqlConnection = objConecta.Conecta
    Dim adaptador As SqlDataAdapter
    Dim l As SqlDataReader




    Public Sub insertadatos(ByVal d(,) As String, ByVal a2 As String, ByVal a3 As Double, ByVal a4 As Double, ByVal a5 As Double, ByVal c As Integer, ByVal a1 As Integer)

        Using connection As New SqlConnection("Data Source=.; Initial Catalog= Almacen; Integrated Security=SSPI")
            connection.Open()

            Dim comando As SqlCommand = connection.CreateCommand()
            Dim tran As SqlTransaction

            tran = connection.BeginTransaction

            comando.Connection = connection
            comando.Transaction = tran



            Try


                comando.CommandText = "exec dbo.INSERTAVENTA " & Val(a1) & ",'" & a2 & "'," & CDbl(a3) & "," & CDbl(a4) & "," & CDbl(a5)
                comando.ExecuteNonQuery()



                For i = 0 To c

                    comando.CommandText = "exec dbo.INSERTADETVEN " & Val(d(i, 0)) & "," & Val(d(i, 1)) & "," & Val(d(i, 2)) & "," & CDbl(d(i, 3))
                    comando.ExecuteNonQuery()

                Next

                If MsgBox("desea ejecutar transacción", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then
                    tran.Commit()
                Else
                    tran.Rollback()
                    MsgBox("Transacción cancelada")
                End If

            Catch ex As Exception
                MsgBox("Commit Exception Type: {0}no se pudo insertar por error")
                Try
                    tran.Rollback()
                Catch ex2 As Exception
                    ' Este bloque de catch manejará los errores
                    ' que pueden ser ocurridos en el servidor y que podrían causar el rollback tal como una conexión cerrada.
                    MsgBox("Error Rollback")
                End Try






            End Try
            connection.Close()
        End Using

    End Sub

    Public Function subecbo() As DataSet
        Using data As New DataSet
            conec.Open()
            adaptador = New SqlDataAdapter("SUBECBOVENTA", conec)
            adaptador.Fill(data, "SUBE")
            Return data
        End Using
        adaptador.Dispose()
        conec.Close()
    End Function

    Public Function nuevo() As Integer

        Dim comando As SqlCommand = conec.CreateCommand
        Dim n As Integer

        comando.CommandText = "select count(*) from ventas"
        l = comando.ExecuteReader
        l.Read()
        n = l(0)
        l.Close()
        n += 1
        conec.Close
        Return n
    End Function

    Public Function precio(ByVal prec As String) As Double

        Dim comando As SqlCommand = conec.CreateCommand
        Dim n As Integer
        conec.Open()
        comando.CommandText = "Select precioVenta from productos where idProducto=" + prec
        l = comando.ExecuteReader
        l.Read()
        n = l(0)
        l.Close()
        conec.Close()
        Return n
    End Function

    Public Function cantidad(ByVal cant As String) As Integer

        Dim comando As SqlCommand = conec.CreateCommand
        Dim n As Integer
        conec.Open()
        comando.CommandText = "Select existencia from productos where idProducto=" + cant
        l = comando.ExecuteReader
        l.Read()
        n = l(0)
        l.Close()
        conec.Close()
        Return n
    End Function




End Class

