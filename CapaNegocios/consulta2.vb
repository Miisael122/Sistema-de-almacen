Imports CapaDatos
Imports CapaEntidad

Public Class consulta2

    Dim consulta As New ConsultaCompra2

    Public Function mostrardatosp(ByVal f1 As String, ByVal f2 As String) As DataSet
        Return consulta.mostrardatosp(f1, f2)
    End Function

End Class
