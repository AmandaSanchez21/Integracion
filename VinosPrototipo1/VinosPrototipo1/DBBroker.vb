Imports MySql.Data.MySqlClient

Public Class DBBroker

    Public Shared mConexion As MySqlConnection
    Private Shared instancia As DBBroker

    Public Sub New()
        Try
            mConexion = New MySqlConnection("Server= 161.67.27.97; Port=3306; Database=bbdd_compravinos ;Uid=isi1718_vinos; Pwd=CAzr9w9N;")
            mConexion.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Public Sub insert(ByVal sql As String, ByRef v As Almacen)
    '    Dim cmd = New MySqlCommand(sql, conn)
    '    cmd.Parameters.AddWithValue("@idProducto", v.id)
    '    cmd.Parameters.AddWithValue("@stock", v.stock)
    '    cmd.Parameters.AddWithValue("@pvp", v.pvp)
    '    cmd.Parameters.AddWithValue("@estado", v.estado)

    '    cmd.ExecuteNonQuery()
    'End Sub

    Public Function change(ByVal sql As String) As Integer
        Dim cmd = New MySqlCommand(sql, mConexion)
        Return cmd.ExecuteNonQuery()
    End Function

    Public Function read(ByVal sql As String) As MySqlDataReader
        Dim cmd = New MySqlCommand(sql, mConexion)
        Return cmd.ExecuteReader()
    End Function

    Public Shared Function getDB() As DBBroker
        If instancia Is Nothing Then
            instancia = New DBBroker()
        End If
        Return instancia
    End Function
End Class
