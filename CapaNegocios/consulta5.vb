Imports CapaDatos
Imports CapaEntidad

Public Class consulta5

    Dim consulta As New ConsultaPagos2

    Public Function cargacbo() As DataSet
        Return consulta.cargacbo
    End Function

    Public Function mostrardatosp(ByVal p1 As Integer) As DataSet
        Return consulta.mostrardatosp(p1)
    End Function

End Class
