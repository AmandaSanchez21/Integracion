Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports MySql.Data.MySqlClient

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class AlmacenVinosWS
    Inherits System.Web.Services.WebService
    Public Shared mConexion As MySqlConnection
    Public Shared mAdaptador As MySqlDataAdapter
    Public Shared mDataSet As DataSet

    Public Sub New()
        Try
            mConexion = New MySqlConnection("Server= 161.67.27.97; Port=3306; Database=bbdd_compravinos ;Uid=isi1718_vinos; Pwd=CAzr9w9N;")
            mConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function Consulta() As DataSet
        mAdaptador = New MySqlDataAdapter("select * from tb_stockvino", mConexion)
        mDataSet = New DataSet("tb_stockvino")
        mAdaptador.FillSchema(mDataSet, SchemaType.Source, "tb_stockvino")
        mAdaptador.Fill(mDataSet, "tb_stockvino")
        Return mDataSet

    End Function

    Public Function ComprobarStock(v As String) As Boolean
        Dim stock As Boolean
        Dim sql As String = "SELECT stock FROM tb_stockvino where idProducto= " & Integer.Parse(v) & ";"
        Dim cmd = New MySqlCommand(sql, mConexion)
        Dim read As MySqlDataReader = cmd.ExecuteReader()
        While read.Read()

            If Convert.ToInt32(read(0)) <= 0 Then
                stock = False
            Else
                stock = True
            End If
        End While
        read.Close()

        Return stock
    End Function

    Public Function CambiarStock(s As String, v As String) As Integer
        MsgBox(s)
        Dim sql As String = "UPDATE tb_stockvino SET stock = " & Integer.Parse(s) & "WHERE idProducto= " & Integer.Parse(v) & ";"
        Dim cmd = New MySqlCommand(sql, mConexion)
        Dim result As Integer
        Try
            result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

End Class