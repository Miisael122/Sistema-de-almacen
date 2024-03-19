Public Class Ventas

    Private _idventa As Integer
    Private _fechaventa As Date
    Private _subtotal As Double
    Private _iva As Double
    Private _total As Double
    Private _idproducto As Integer
    Private _cantidad As Integer
    Private _precio As Double

    Public Property idventa As Integer

        Get
            Return _idventa
        End Get

        Set(value As Integer)
            _idventa = value
        End Set

    End Property

    Public Property fechaventa As Date

        Get
            Return _fechaventa
        End Get

        Set(value As Date)
            _fechaventa = value
        End Set

    End Property

    Public Property subtotal As Double

        Get
            Return _subtotal
        End Get

        Set(value As Double)
            _subtotal = value
        End Set

    End Property

    Public Property iva As Double

        Get
            Return _iva
        End Get

        Set(value As Double)
            _iva = value
        End Set

    End Property

    Public Property total As Double

        Get
            Return _total
        End Get

        Set(value As Double)
            _total = value
        End Set

    End Property

    Public Property idproducto As Integer

        Get
            Return _idproducto
        End Get

        Set(value As Integer)
            _idproducto = value
        End Set

    End Property

    Public Property cantidad As Integer

        Get
            Return _cantidad
        End Get

        Set(value As Integer)
            _cantidad = value
        End Set

    End Property

    Public Property precio As Double

        Get
            Return _precio
        End Get

        Set(value As Double)
            _precio = value
        End Set

    End Property

End Class
