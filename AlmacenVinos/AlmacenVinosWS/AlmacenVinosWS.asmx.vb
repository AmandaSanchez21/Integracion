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

    <WebMethod()>
    Public Function Consulta() As DataSet
        Try
            mConexion = New MySqlConnection("Server= 161.67.27.97; Port=3306; Database=bbdd_compravinos ;Uid=isi1718_vinos; Pwd=CAzr9w9N;")
            mConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        mAdaptador = New MySqlDataAdapter("select * from tb_stockvino", mConexion)
        mDataSet = New DataSet("tb_stockvino")
        mAdaptador.FillSchema(mDataSet, SchemaType.Source, "tb_stockvino")
        mAdaptador.Fill(mDataSet, "tb_stockvino")
        Return mDataSet
    End Function

End Class