Imports System.Data.OleDb

Public Class DBBroker
    Public Shared FILEPATH As String
    Private Shared CadConexion As String
    Private Shared mConexion As OleDbConnection
    Private Shared instancia As DBBroker

    Private Sub New()
        CadConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & FILEPATH
        mConexion = New OleDbConnection(CadConexion)
        mConexion.Open()
    End Sub

    Public Property path As String
        Get
            Return FILEPATH
        End Get
        Set(value As String)
            FILEPATH = value
        End Set
    End Property

    Public Sub connectDB()
        mConexion = New OleDbConnection(CadConexion)
        mConexion.Open()
    End Sub

    Public Function read(ByVal sql As String) As OleDbDataReader
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteReader()
    End Function

    Public Function change(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()
    End Function

    Public Shared Function getDB() As DBBroker
        If instancia Is Nothing Then
            instancia = New DBBroker()
        End If
        Return instancia
    End Function
End Class
