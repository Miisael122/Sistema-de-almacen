Imports CapaDatos
Imports CapaEntidad

Public Class consulta6

    Dim consulta As New ConsultaPagos3



    Public Function mostrardatosp(ByVal f1 As String, ByVal f2 As String) As DataSet
        Return consulta.mostrardatosp(f1, f2)
    End Function

End Class