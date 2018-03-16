Public Class Almacen

    Private _estado As String
    Private _idProducto, _stock As Integer
    Private _pvp As Double

    Private DAO As DAOAlmacen

    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Property id As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
        End Set
    End Property

    Public Property pvp As Double
        Get
            Return _pvp
        End Get
        Set(value As Double)
            _pvp = value
        End Set
    End Property


    Public Sub New()
        Me.DAO = New DAOAlmacen
    End Sub

    Public Sub insertarVino()
        DAO.insert(Me)
    End Sub

    Public Sub eliminarVino()
        DAO.delete(Me)
    End Sub

    Public Sub añadirCantidad()
        DAO.update(Me)
    End Sub
    Public Sub retirarCantidad()
        DAO.update(Me)
    End Sub
    Public Sub read()
        DAO.read(Me)
    End Sub
    Public Function readAll() As Collection
        DAO.readAll()
        Return DAO.lista
    End Function
End Class
