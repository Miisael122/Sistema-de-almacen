Imports CapaDatos
Imports CapaEntidad

Public Class PagosCN

    Dim pago As New PagosDAO

    Public Function mostrardatosp(ByVal nom As String) As DataSet
        Return pago.mostrardatosp(nom)
    End Function

    Public Function mostrardatos(ByVal pr As String) As DataSet
        Return pago.mostrardatos(pr)
    End Function


    Public Function subecbo() As DataSet
        Return pago.subecbo
    End Function

    Public Function subecbo2(ByVal ipd As Integer) As DataSet
        Return pago.subecbo2(ipd)
    End Function

    Public Function nuevo() As Integer
        Return pago.nuevo
    End Function


    Public Sub insertadatos(ByVal c1 As Integer, ByVal c2 As String, ByVal c3 As String, ByVal c4 As String, ByVal c5 As Double, ByVal nom As String)
        pago.insertadatos(c1, c2, c3, c4, c5, nom)
    End Sub

End Class


