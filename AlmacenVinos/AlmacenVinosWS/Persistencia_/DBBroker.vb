Imports MySql.Data.MySqlClient

Public Class DBBroker
    Public Shared mConexion As MySqlConnection
    Public Shared mAdaptador As MySqlDataAdapter
    Public Shared mDataSet As DataSet
    Private Shared instancia As DBBroker

    Public Sub New()
        Try
            mConexion = New MySqlConnection("Server= 161.67.27.97; Port=3306; Database=bbdd_compravinos ;Uid=isi1718_vinos; Pwd=CAzr9w9N;")
            mConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function readAlmacen() As DataSet
        mAdaptador = New MySqlDataAdapter("select * from tb_stockvino", mConexion)
        mDataSet = New DataSet("tb_stockvino")
        mAdaptador.FillSchema(mDataSet, SchemaType.Source, "tb_stockvino")
        mAdaptador.Fill(mDataSet, "tb_stockvino")
        Return mDataSet
    End Function

    Public Function comprobarStock(ByVal id As String) As Integer
        Dim sql As String = "SELECT stock FROM tb_stockvino where idProducto= " & Integer.Parse(id) & ";"
        Dim cmd = New MySqlCommand(sql, mConexion)
        Dim stock As Integer
        Dim read As MySqlDataReader

        Try
            read = cmd.ExecuteReader()
            While read.Read()
                stock = Integer.Parse(read(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        read.Close()

        Return stock
    End Function

    Public Function actualizarStock(ByVal stock As String, ByVal id As String) As String
        Dim sql As String = "UPDATE tb_stockvino SET stock = " & Integer.Parse(stock) & " WHERE idProducto= " & Integer.Parse(id) & ";"
        Dim cmd = New MySqlCommand(sql, mConexion)
        Dim result As Integer
        Try
            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result
    End Function

    Public Shared Function getDB() As DBBroker
        If instancia Is Nothing Then
            instancia = New DBBroker()
        End If
        Return instancia
    End Function

End Class
