Imports CapaDatos
Imports CapaEntidad

Public Class CategoriasCN

    Dim categoria As New CategoriasDAO

    Public Function mostrardatos() As DataSet
        Return categoria.mostrardatos
    End Function

    Public Sub insertadatos(ByVal e As String)
        categoria.insertadatos(e)
    End Sub

End Class
