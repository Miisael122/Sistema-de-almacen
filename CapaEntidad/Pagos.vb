Public Class Pagos

    Private _idcompra As Integer
    Private _fecha As Date
    Private _formapago As String
    Private _referencia As String
    Private _importe As Double

    Public Property idcompra As Integer

        Get
            Return _idcompra
        End Get

        Set(value As Integer)
            _idcompra = value
        End Set

    End Property

    Public Property fecha As Date

        Get
            Return _fecha
        End Get

        Set(value As Date)
            _fecha = value
        End Set

    End Property

    Public Property formadepago As String

        Get
            Return _formapago
        End Get

        Set(value As String)
            _formapago = value
        End Set

    End Property

    Public Property referencia As String

        Get
            Return _referencia
        End Get

        Set(value As String)
            _referencia = value
        End Set

    End Property

    Public Property importe As Double

        Get
            Return _importe
        End Get

        Set(value As Double)
            _importe = value
        End Set

    End Property

End Class
