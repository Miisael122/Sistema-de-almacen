Imports CapaDatos
Imports CapaEntidad

Public Class consulta8

    Dim consulta As New ConsultaVentas2



    Public Function mostrardatosp(ByVal f1 As Integer) As DataSet
        Return consulta.mostrardatosp(f1)
    End Function

    Public Function mostrardatosp2(ByVal p1 As Integer) As DataSet
        Return consulta.mostrardatosp2(p1)
    End Function

    Public Function cargacbo() As DataSet
        Return consulta.cargacbo
    End Function

End Class