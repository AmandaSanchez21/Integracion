Imports MySql.Data.MySqlClient

Public Class DBBroker
    Public conn As New MySqlConnection
    Private Shared mConexion As MySqlConnection
    Private Shared instancia As DBBroker

    Public Sub New()
        Try
            mConexion = New MySqlConnection()
            mConexion.ConnectionString = "Server= 161.67.27.97; Port=3306; Database=bbdd_compravinos ;Uid=isi1718_vinos; Pwd=CAzr9w9N;"
            mConexion.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Shared Function getDB() As DBBroker
        If instancia Is Nothing Then
            instancia = New DBBroker()
        End If
        Return instancia
    End Function
End Class
