﻿Public Class Vino

    Private _nombre, _tipo As String
    Private _año, _cantidad As Integer
    Private _grados, _precio As Double

    Private DAO As DAOvino

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
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
        Me.DAO = New DAOvino
    End Sub

    Public Sub añadir()
        DAO.insert(Me)
    End Sub
    Public Sub retirar()
        DAO.delete(Me)
    End Sub
    Public Sub read()
        DAO.read(Me)
    End Sub
    Public Function readAll() As Collection
        DAO.readAll()
        Return DAO.lista
    End Function
End Class
