Imports CapaDatos
Imports CapaEntidad

Public Class consulta4

    Dim consulta As New ConsultaPagos1

    Public Function cargacbo() As DataSet
        Return consulta.cargacbo
    End Function

    Public Function mostrardatosp(ByVal p1 As String) As DataSet
        Return consulta.mostrardatosp(p1)
    End Function

End Class
