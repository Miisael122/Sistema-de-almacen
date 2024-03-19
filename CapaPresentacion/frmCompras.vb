Imports CapaDatos
Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class frmCompras

    Dim objConecta As New Conexion
    Dim conec As SqlConnection = objConecta.Conecta
    Dim l As SqlDataReader
    Dim comando As SqlCommand = conec.CreateCommand()

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        conec.Open()

        cbocondicion.Items.Add("Contado")
        cbocondicion.Items.Add("Credito")

        comando.CommandText = "Select * From proveedores"
        l = comando.ExecuteReader
        While l.Read()
            cbonomproveedor.Items.Add(l(1))
        End While
        l.Close()

        comando.CommandText = "Select * From productos"
        l = comando.ExecuteReader
        While l.Read()
            cbonomproducto.Items.Add(l(2))
        End While
        l.Close()



    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        comando.CommandText = "select count(*) from compra"
        l = comando.ExecuteReader
        l.Read()
        n = l(0)
        l.Close()
        n += 1
        txtidcompra.Text = n
        dgcompra.Rows.Clear()

        txtsubtotal.Text = ""
        txtiva.Text = ""
        txttotal.Text = ""
    End Sub

    Private Sub cbonomproveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbonomproveedor.SelectedIndexChanged

        comando.CommandText = "Select idProveedor, saldoProv From proveedores Where nombre='" & cbonomproveedor.Text & "'"

        l = comando.ExecuteReader
        l.Read()
        txtidproveedor.Text = l(0)
        txtsaldo.Text = l(1)
        l.Close()


    End Sub

    Private Sub cbonomproducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbonomproducto.SelectedIndexChanged

        comando.CommandText = "Select idProducto, existencia From productos Where nombreProducto='" & cbonomproducto.Text & "'"
        l = comando.ExecuteReader
        l.Read()
        txtidproducto.Text = l(0)
        txtexistencias.Text = l(1)
        l.Close()

    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

        Dim importe, importef, iva As Double

        importe = CDbl(txtcantidad.Text) * CDbl(txtprecio.Text)
        iva = importe * 0.16
        importef = iva + importe
        txtsubtotal.Text = Val(txtsubtotal.Text) + CStr(importe)
        txtiva.Text = Val(txtiva.Text) + CStr(iva)
        txttotal.Text = Val(txttotal.Text) + CStr(importef)

        dgcompra.Rows.Add(txtidcompra.Text, txtidproducto.Text, cbonomproducto.Text, txtcantidad.Text, txtprecio.Text, importe)

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click

        Using connection As New SqlConnection("Data Source=localhost; Initial Catalog= Almacen; Integrated Security=SSPI")
            connection.Open()
            Dim fecha As String
            Dim c1, c2, c3 As Integer
            Dim c4 As Double
            fecha = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day
            Dim comando As SqlCommand = connection.CreateCommand()
            Dim tran As SqlTransaction

            tran = connection.BeginTransaction

            comando.Connection = connection
            comando.Transaction = tran



            Try

                If cbocondicion.Text = "Contado" Then

                    comando.CommandText = "insert into compra values (" & Val(txtidcompra.Text) & "," & Val(txtidproveedor.Text) & ",'" & txtfactura.Text & "','" & fecha & "'," & CDbl(txtsubtotal.Text) & "," & CDbl(txtiva.Text) & "," & CDbl(txttotal.Text) & "," & 0 & ",'" & cbocondicion.Text & "')"
                    comando.ExecuteNonQuery()

                Else

                    comando.CommandText = "insert into compra values (" & Val(txtidcompra.Text) & "," & Val(txtidproveedor.Text) & ",'" & txtfactura.Text & "','" & fecha & "'," & CDbl(txtsubtotal.Text) & "," & CDbl(txtiva.Text) & "," & CDbl(txttotal.Text) & "," & CDbl(txttotal.Text) & ",'" & cbocondicion.Text & "')"
                    comando.ExecuteNonQuery()
                    comando.CommandText = "update proveedores set saldoProv = saldoProv +" & CDbl(txttotal.Text) & " where idProveedor =" & Val(txtidproveedor.Text)
                    comando.ExecuteNonQuery()

                End If



                For i = 0 To dgcompra.Rows.Count() - 2

                    c1 = Val(dgcompra.Item(0, i).Value)
                    c2 = Val(dgcompra.Item(1, i).Value)
                    c3 = Val(dgcompra.Item(3, i).Value)
                    c4 = CDbl(dgcompra.Item(4, i).Value)

                    comando.CommandText = "insert into detcompra values (" & c1 & "," & c2 & "," & c3 & "," & c4 & ")"
                    comando.ExecuteNonQuery()

                    comando.CommandText = "Update productos set existencia=existencia +" & c3 & ", costo=" & c4 & " where idProducto='" & c2 & "'"
                    comando.ExecuteNonQuery()


                Next



                If MsgBox("desea ejecutar transacción", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then
                    tran.Commit()
                Else
                    tran.Rollback()
                    MsgBox("Transacción cancelada")
                End If

            Catch ex As Exception
                MsgBox("Error")
                Try
                tran.Rollback()
            Catch ex2 As Exception
                'Este bloque de catch manejará los errores
                ' que pueden ser ocurridos en el servidor y que podrían causar el rollback tal como una conexión cerrada.
                MsgBox("Error Rollback")
            End Try



            End Try
            connection.Close()
        End Using

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()

    End Sub
End Class