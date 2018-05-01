Public Class _Default
    Inherits Page
    Public Shared ws As AlmacenVinosWS

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Visible = True
        Button2.Visible = True
        Label2.Visible = True
        ws = New AlmacenVinosWS
        Button1.Visible = False
        grdVinos.DataSource = ws.Consulta()
        grdVinos.DataBind()
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ws = New AlmacenVinosWS
        Dim stock As Boolean
        stock = ws.ComprobarStock(TextBox1.Text)

        If stock Then
            Label1.Text = "Hay stock disponible del artículo seleccionado"
        Else
            Label1.Text = "No hay stock disponible del artículo seleccionado"
        End If
    End Sub
End Class