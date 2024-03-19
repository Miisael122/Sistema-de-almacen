Imports CapaDatos
Imports CapaEntidad

Public Class consulta9

    Dim consulta As New ConsultaVentas3



    Public Function mostrardatosp(ByVal f1 As Double) As DataSet
        Return consulta.mostrardatosp(f1)
    End Function

    Public Function mostrardatosp2(ByVal p1 As Integer) As DataSet
        Return consulta.mostrardatosp2(p1)
    End Function


End Class
