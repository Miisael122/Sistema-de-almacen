Imports System.Data.SqlClient

Public Class Historico

    Dim conexion, conexion2, conexiona As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim ca As SqlCommand = conexiona.CreateCommand
    Dim comando2 As SqlCommand = conexion2.CreateCommand
    Dim lector, l2 As SqlDataReader
    Dim r, r2 As String

    Private Sub HistoricoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=Almacen; Integrated Security=SSPI"
        conexion.Open()

        conexiona.ConnectionString = "server=.; DataBase=Almacen; Integrated Security=SSPI"
        conexiona.Open()

        conexion2.ConnectionString = "server=.; DataBase=HAlmacen; Integrated Security=SSPI"
        conexion2.Open()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If MsgBox("Desea realizar el traspaso?", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then

            r2 = "truncate table productos"
            comando2.CommandText = r2
            comando2.ExecuteNonQuery()

            r2 = "truncate table categorias"
            comando2.CommandText = r2
            comando2.ExecuteNonQuery()

            r2 = "truncate table proveedores"
            comando2.CommandText = r2
            comando2.ExecuteNonQuery()

            r = "select * from categorias"
            comando.CommandText = r
            lector = comando.ExecuteReader

            While lector.Read

                r2 = "insert into categorias values (" & Val(lector(0)) & ",'" & lector(1) & "')"
                comando2.CommandText = r2
                comando2.ExecuteNonQuery()

            End While
            lector.Close()

            r = "select * from productos"
            comando.CommandText = r
            lector = comando.ExecuteReader

            While lector.Read

                r2 = "insert into productos values (" & Val(lector(0)) & "," & Val(lector(1)) & ",'" & lector(2) & "'," & CDbl(lector(3)) & "," & CDbl(lector(4)) & "," & Val(lector(5)) & "," & Val(lector(6)) & "," & Val(lector(7)) & ")"
                comando2.CommandText = r2
                comando2.ExecuteNonQuery()

            End While
            lector.Close()

            r = "select * from proveedores"
            comando.CommandText = r
            lector = comando.ExecuteReader


            While lector.Read

                r2 = "insert into proveedores values (" & Val(lector(0)) & ",'" & lector(1) & "','" & lector(2) & "','" & lector(3) & "','" & lector(4) & "','" & lector(5) & "','" & lector(6) & "','" & lector(7) & "','" & lector(8) & "'," & CDbl(lector(9)) & ")"
                comando2.CommandText = r2
                comando2.ExecuteNonQuery()

            End While
            lector.Close()

            ''----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            r = "select * from ventas where Year(fechaVenta)=" & Val(c.Text)
            comando.CommandText = r
            lector = comando.ExecuteReader

            While lector.Read

                r2 = "insert into ventas values(" & Val(lector(0)) & ",'" & lector(1) & "'," & CDbl(lector(2)) & "," & CDbl(lector(3)) & "," & CDbl(lector(4)) & ")"
                comando2.CommandText = r2
                comando2.ExecuteNonQuery()

                r = "select * from detventa where idVenta=" & Val(lector(0))
                ca.CommandText = r
                l2 = ca.ExecuteReader

                While l2.Read

                    r2 = "insert into detventa values (" & Val(l2(0)) & "," & Val(l2(1)) & "," & Val(l2(2)) & "," & CDbl(l2(3)) & ")"
                    comando2.CommandText = r2
                    comando2.ExecuteNonQuery()

                End While
                l2.Close()

            End While
            lector.Close()


            r = "select * from ventas where Year(fechaVenta)=" & Val(c.Text)
            comando.CommandText = r
            lector = comando.ExecuteReader

            While lector.Read

                r = "delete from detventa where idVenta=" & Val(lector(0))
                ca.CommandText = r
                ca.ExecuteNonQuery()

            End While
            lector.Close()

            r = "select * from ventas where Year(fechaVenta)=" & Val(c.Text)
            comando.CommandText = r
            lector = comando.ExecuteReader

            While lector.Read

                r = "delete from ventas where idVenta=" & Val(lector(0))
                ca.CommandText = r
                ca.ExecuteNonQuery()

            End While

            lector.Close()

            ''------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            r = "select * from compra where saldoComp=0 and Year(fechaCompra)=" & Val(c.Text)
            comando.CommandText = r
            lector = comando.ExecuteReader

            While lector.Read

                r2 = "insert into compra values (" & Val(lector(0)) & "," & Val(lector(1)) & ",'" & lector(2) & "','" & lector(3) & "'," & CDbl(lector(4)) & "," & CDbl(lector(5)) & "," & CDbl(lector(6)) & "," & CDbl(lector(7)) & ",'" & lector(8) & "')"
                comando2.CommandText = r2
                comando2.ExecuteNonQuery()

                r = "select * from detcompra where idCompra=" & Val(lector(0))
                ca.CommandText = r
                l2 = ca.ExecuteReader

                While l2.Read

                    r2 = "insert into detcompra values (" & Val(l2(0)) & "," & Val(l2(1)) & "," & Val(l2(2)) & "," & CDbl(l2(3)) & ")"
                    comando2.CommandText = r2
                    comando2.ExecuteNonQuery()

                End While
                l2.Close()

                r = "select * from pagos where idCompra=" & Val(lector(0))
                ca.CommandText = r
                l2 = ca.ExecuteReader()

                While l2.Read

                    r2 = "insert into pagos values (" & Val(l2(0)) & "," & Val(l2(1)) & ",'" & l2(2) & "','" & l2(3) & "','" & l2(4) & "'," & CDbl(l2(5)) & ")"
                    comando2.CommandText = r2
                    comando2.ExecuteNonQuery()

                End While
                l2.Close()

            End While
            lector.Close()

            r = "select * from compra where saldoComp=0 and Year(fechaCompra)=" & Val(c.Text)
            comando.CommandText = r
            lector = comando.ExecuteReader

            While lector.Read

                r = "delete from detcompra where idCompra=" & Val(lector(0))
                ca.CommandText = r
                ca.ExecuteNonQuery()

                r = "delete from pagos where idCompra=" & Val(lector(0))
                ca.CommandText = r
                ca.ExecuteNonQuery()

            End While
            lector.Close()

            r = "select * from compra where saldoComp=0 and Year(fechaCompra)=" & Val(c.Text)
            comando.CommandText = r
            lector = comando.ExecuteReader

            While lector.Read

                r = "delete from compra where idCompra=" & Val(lector(0))
                ca.CommandText = r
                ca.ExecuteNonQuery()

            End While

            lector.Close()
            c.Text = ""
            MsgBox("Traspaso realizado")

        Else

            MsgBox("Traspaso cancelado")

        End If

    End Sub


End Class