Imports CapaDatos
Imports CapaEntidad

Public Class VentasCN

    Dim venta As New VentasDAO

    Public Function subecbo() As DataSet
        Return venta.subecbo
    End Function

    Public Function nuevo() As Integer
        Return venta.nuevo
    End Function

    Public Function precio(ByVal prec As Double) As Double
        Return venta.precio(prec)
    End Function

    Public Function cantidad(ByVal cant As Integer) As Integer
        Return venta.cantidad(cant)
    End Function

    Public Sub insertadatos(ByVal d(,) As String, ByVal a2 As String, ByVal a3 As Double, ByVal a4 As Double, ByVal a5 As Double, ByVal c As Integer, ByVal a1 As Integer)
        venta.insertadatos(d, a2, a3, a4, a5, c, a1)
    End Sub

End Class

