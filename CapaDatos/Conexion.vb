Imports System.Data.SqlClient
Imports System.Configuration

Public Class Conexion
    Dim Conexion As SqlConnection
    Public Function Conecta() As SqlConnection
        Conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
        Return Conexion
    End Function
End Class

