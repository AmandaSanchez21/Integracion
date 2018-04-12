Public Class _Default
    Inherits Page
    Public Shared ws As AlmacenVinosWS

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ws = New AlmacenVinosWS
        grdVinos.DataSource = ws.Consulta()
        grdVinos.DataBind()
    End Sub
End Class