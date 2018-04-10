Imports MySql.Data.MySqlClient

Public Class DAOAlmacen
    Private _lista As Collection

    Public Property lista As Collection
        Get
            Return _lista
        End Get
        Set(value As Collection)
            _lista = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub insert(ByVal av As Almacen)
        Dim sql As String = "INSERT INTO tb_stockvino VALUES (" & av.id & ", " & av.stock & ", " & av.pvp & ", '" & av.estado & "');"
        DBBroker.getDB.change(sql)
    End Sub

    Public Sub delete(ByVal a As Almacen)
        Dim sql As String = "DELETE FROM tb_stockvino WHERE idProducto =" & a.id & ";"
        DBBroker.getDB.change(sql)
    End Sub

    Public Function update(ByVal a As Almacen) As Integer
        'SQL sentence for modifying the attributes of a paper
        Return DBBroker.getDB.change("UPDATE tb_stockvino SET stock=" & a.stock & " WHERE idProducto=" & a.id & ";")
    End Function

    Public Sub read(ByRef a As Almacen)
        Dim reader As MySqlDataReader
        Dim sql As String = "SELECT stock, pvp, estado FROM tb_stockvino WHERE idProducto =" & a.id & ";"
        reader = DBBroker.getDB.read(sql)
        While reader.Read()
            a.stock = Convert.ToInt32(reader(0))
            a.pvp = Convert.ToInt32(reader(1))
            a.estado = Convert.ToString(reader(2))
        End While
        reader.Close()
    End Sub

    Public Sub readAll()
        Dim reader As MySqlDataReader
        Dim sql As String = "SELECT * FROM tb_stockvino"
        reader = DBBroker.getDB.read(sql)
        _lista = New Collection
        While reader.Read()
            Dim a As Almacen = New Almacen()
            a.id = Integer.Parse(reader(0).ToString)
            a.stock = Convert.ToInt32(reader(1))
            a.pvp = Convert.ToDouble(reader(2))
            a.estado = Convert.ToString(reader(3))

            _lista.Add(a)
        End While
        reader.Close()
    End Sub

End Class
