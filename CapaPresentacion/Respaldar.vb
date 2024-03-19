Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Respaldar

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion.ConnectionString = "Data Source=.; Initial Catalog=master; Integrated Security=True"
        conexion.Open()
        'configuracion de algunos parametros del openFileDialog
        'directorio inicial donde se abrira
        SaveFileDialog1.InitialDirectory = "C:\\"
        'filtro de archivos.
        SaveFileDialog1.Filter = "SQL Server database backup files|*.bak"

        'codigo para abrir el cuadro de dialogo
        Dim str_RutaArchivo As String
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            str_RutaArchivo = SaveFileDialog1.FileName
            MaskedTextBox1.Text = str_RutaArchivo
            'RESSPALDAR-BACKUP CONCATENANDO str_RutaArchivo
            Try

                comando.CommandText = "alter database Almacen set offline with rollback immediate"
                comando.ExecuteNonQuery()

                comando.CommandText = "alter database Almacen set online"
                comando.ExecuteNonQuery()

                comando.CommandText = "backup database Almacen to disk= '" & str_RutaArchivo & "'"
                comando.ExecuteNonQuery()

                MsgBox("Base de datos respaldada")

            Catch ex As Exception
                MsgBox("ERROR")
            End Try
        End If
        conexion.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class