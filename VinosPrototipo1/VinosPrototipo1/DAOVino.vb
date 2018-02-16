Imports System.Data.OleDb

Public Class DAOVino
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

    Public Sub insert(ByRef v As Vino)
        Dim sql As String = "INSERT INTO Vinos (Nombre, Año, Tipo, Grados, Cantidad, Precio, Fecha de Entrada) VALUES (" & v.nombre & ", '" & v.año & "', " & v.tipo & ", '" & v.grados & "', '" & v.cantidad & "', '" & v.precio & v.fechaEntrada & "')"
        DBBroker.getDB.change(sql)
    End Sub

    Public Sub delete(ByRef v As Vino)
        Dim sql As String = "DELETE FROM Vinos WHERE Nombre=" & v.nombre & ";"
        DBBroker.getDB.change(sql)
    End Sub

    Public Function update(ByVal v As Vino) As Integer
        'SQL sentence for modifying the attributes of a paper
        Return DBBroker.getDB.change("UPDATE Vinos SET Cantidad=" & v.cantidad & " WHERE Nombre='" & v.nombre & "';")
    End Function

    Public Sub read(ByRef v As Vino)
        Dim reader As OleDbDataReader
        Dim sql As String = "SELECT Nombre, Año, Tipo, Grados, Cantidad, Precio FROM Vinos WHERE Nombre='" & v.nombre & "';"
        reader = DBBroker.getDB.read(sql)
        While reader.Read()
            v.nombre = Convert.ToString(reader(0))
            v.año = Convert.ToInt32(reader(1))
            v.tipo = Convert.ToString(reader(2))
            v.grados = Convert.ToDouble(reader(3))
            v.cantidad = Convert.ToInt32(reader(4))
            v.precio = Convert.ToDouble(reader(5))
        End While
        reader.Close()
    End Sub
    Public Sub readAll()
        Dim reader As OleDbDataReader
        Dim sql As String = "SELECT Nombre, Año, Tipo, Grados, Cantidad, Precio FROM Vinos"
        reader = DBBroker.getDB.read(sql)
        _lista = New Collection
        While reader.Read()
            Dim v As Vino = New Vino()
            v.nombre = Convert.ToString(reader(0))
            v.año = Convert.ToInt32(reader(1))
            v.tipo = Convert.ToString(reader(2))
            v.grados = Convert.ToDouble(reader(3))
            v.cantidad = Convert.ToInt32(reader(4))
            v.precio = Convert.ToDouble(reader(5))
            _lista.Add(v)
        End While
        reader.Close()
    End Sub
End Class
