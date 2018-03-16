Public Class Vino

    Private _nombre, _tipo, _fechaEntrada As String
    Private _año, _cantidad As Integer
    Private _grados, _precio As Double

    Private DAO As DAOVino

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property fechaEntrada As String
        Get
            Return _fechaEntrada
        End Get
        Set(value As String)
            _fechaEntrada = value
        End Set
    End Property
    Public Property año As Integer
        Get
            Return _año
        End Get
        Set(value As Integer)
            _año = value
        End Set
    End Property
    Public Property tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property
    Public Property grados As Double
        Get
            Return _grados
        End Get
        Set(value As Double)
            _grados = value
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
    Public Property cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Sub New()
        Me.DAO = New DAOVino
    End Sub

    'Public Sub insertarVino()
    '    DAO.insert(Me)
    'End Sub

    'Public Sub eliminarVino()
    '    DAO.delete(Me)
    'End Sub

    'Public Sub añadirCantidad()
    '    DAO.update(Me)
    'End Sub
    'Public Sub retirarCantidad()
    '    DAO.update(Me)
    'End Sub
    'Public Sub read()
    '    DAO.read(Me)
    'End Sub
    'Public Function readAll() As Collection
    '    DAO.readAll()
    '    Return DAO.lista
    'End Function
End Class
