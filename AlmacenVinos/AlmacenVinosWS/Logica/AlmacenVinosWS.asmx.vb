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


    <WebMethod()>
    Public Function Consulta() As DataSet
        Return DBBroker.getDB().readAlmacen()
    End Function

    <WebMethod()>
    Public Function ComprobarStock(v As String) As Boolean
        Dim stock As Boolean
        Dim cantidad As Integer = DBBroker.getDB().comprobarStock(v)

        If cantidad <= 0 Then
            stock = False
        Else
            stock = True
        End If
        Return stock
    End Function

    <WebMethod()>
    Public Function CambiarStock(stock As String, id As String) As Integer
        Return DBBroker.getDB().actualizarStock(stock, id)
    End Function

End Class