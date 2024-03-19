Imports CapaDatos
Imports CapaEntidad

Public Class consulta7

    Dim consulta As New ConsultaVentas1



    Public Function mostrardatosp(ByVal f1 As String, ByVal f2 As String) As DataSet
        Return consulta.mostrardatosp(f1, f2)
    End Function

    Public Function mostrardatosp2(ByVal p1 As Integer) As DataSet
        Return consulta.mostrardatosp2(p1)
    End Function

End Class