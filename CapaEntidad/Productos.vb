Public Class Productos

    Private _idproducto As Integer
    Private _idcategoria As Integer
    Private _nombreproducto As String
    Private _precioventa As Double
    Private _costo As Double
    Private _existencia As Integer
    Private _maximos As Integer
    Private _minimos As Integer

    Public Property idproducto As Integer

        Get
            Return _idproducto
        End Get

        Set(value As Integer)
            _idproducto = value
        End Set

    End Property

    Public Property idcategoria As Integer

        Get
            Return _idcategoria
        End Get

        Set(value As Integer)
            _idcategoria = value
        End Set

    End Property

    Public Property nombreproducto As String

        Get
            Return _nombreproducto
        End Get

        Set(value As String)
            _nombreproducto = value
        End Set

    End Property

    Public Property precioventa As Double

        Get
            Return _precioventa
        End Get

        Set(value As Double)
            _precioventa = value
        End Set

    End Property

    Public Property costo As Double

        Get
            Return _costo
        End Get

        Set(value As Double)
            _costo = value
        End Set

    End Property

    Public Property existencia As Integer

        Get
            Return _existencia
        End Get

        Set(value As Integer)
            _existencia = value
        End Set

    End Property

    Public Property maximos As Integer

        Get
            Return _maximos
        End Get

        Set(value As Integer)
            _maximos = value
        End Set

    End Property

    Public Property minimos As Integer

        Get
            Return _minimos
        End Get

        Set(value As Integer)
            _minimos = value
        End Set

    End Property

End Class
