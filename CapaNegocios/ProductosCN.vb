Imports CapaDatos
Imports CapaEntidad

Public Class ProductosCN

    Dim producto As New ProductosDAO

    Public Function subecbo() As DataSet
        Return producto.subecbo
    End Function

    Public Function mostrardatos() As DataSet
        Return producto.mostrardatos
    End Function

    Public Sub insertadatos(ByVal c2 As Integer, ByVal c3 As String, ByVal c4 As Double, ByVal c5 As Double, ByVal c6 As Integer, ByVal c7 As Integer, ByVal c8 As Integer)
        producto.insertadatos(c2, c3, c4, c5, c6, c7, c8)
    End Sub

End Class
