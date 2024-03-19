Public Class Categorias

    Private _idcategoria As Integer
    Private _concepto As String

    Public Property idcategoria As Integer

        Get
            Return _idcategoria
        End Get

        Set(value As Integer)
            _idcategoria = value
        End Set

    End Property

    Public Property concepto As String

        Get
            Return _concepto
        End Get

        Set(value As String)
            _concepto = value
        End Set

    End Property

End Class
