Imports CapaDatos
Imports CapaEntidad

Public Class ProveedoresCN

    Dim proveedores As New ProveedoresDAO

    Public Function mostrardatos() As DataSet
        Return proveedores.mostrardatos
    End Function

    Public Sub insertadatos(ByVal c2 As String, ByVal c3 As String, ByVal c4 As String, ByVal c5 As String, ByVal c6 As String, ByVal c7 As String, ByVal c8 As String, ByVal c9 As String, ByVal c10 As Double)
        proveedores.insertadatos(c2, c3, c4, c5, c6, c7, c8, c9, c10)
    End Sub

End Class
