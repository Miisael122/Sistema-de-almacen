Public Class Proveedores

    Private _idproveedor As Integer
    Private _nombre As String
    Private _telefono As String
    Private _domicilio As String
    Private _colonia As String
    Private _cp As String
    Private _ciudad As String
    Private _correo As String
    Private _representante As String
    Private _saldoprov As Double


    Public Property idcategoria As Integer

        Get
            Return _idproveedor
        End Get

        Set(value As Integer)
            _idproveedor = value
        End Set

    End Property

    Public Property nombre As String

        Get
            Return _nombre
        End Get

        Set(value As String)
            _nombre = value
        End Set

    End Property

    Public Property telefono As String

        Get
            Return _telefono
        End Get

        Set(value As String)
            _telefono = value
        End Set

    End Property

    Public Property domicilio As String

        Get
            Return _domicilio
        End Get

        Set(value As String)
            _domicilio = value
        End Set

    End Property

    Public Property colonia As String

        Get
            Return _colonia
        End Get

        Set(value As String)
            _colonia = value
        End Set

    End Property

    Public Property cp As String

        Get
            Return _cp
        End Get

        Set(value As String)
            _cp = value
        End Set

    End Property

    Public Property ciudad As String

        Get
            Return _ciudad
        End Get

        Set(value As String)
            _ciudad = value
        End Set

    End Property

    Public Property correo As String

        Get
            Return _correo
        End Get

        Set(value As String)
            _correo = value
        End Set

    End Property

    Public Property representante As String

        Get
            Return _representante
        End Get

        Set(value As String)
            _representante = value
        End Set

    End Property

    Public Property saldoprov As Double

        Get
            Return _saldoprov
        End Get

        Set(value As Double)
            _saldoprov = value
        End Set

    End Property

End Class
