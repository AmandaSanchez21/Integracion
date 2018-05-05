Public Class _Default
    Inherits Page
    Public Shared ws As AlmacenVinosWS

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Label2.Visible = True
        ws = New AlmacenVinosWS
        Button1.Visible = False
        grdVinos.DataSource = ws.Consulta()
        grdVinos.DataBind()
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Visible = False
        Button4.Visible = False

        ws = New AlmacenVinosWS
        Dim stock As Boolean
        stock = ws.ComprobarStock(TextBox1.Text)

        If stock Then
            Label1.Text = "Hay stock disponible del artículo seleccionado"
        Else
            Label1.Text = "No hay stock disponible del artículo seleccionado"
        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = ""
        TextBox2.Visible = True
        Button4.Visible = True

    End Sub


    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ws = New AlmacenVinosWS
        Dim result As Integer = ws.CambiarStock(TextBox2.Text, TextBox1.Text)

        If result = 1 Then
            Label3.Text = "Stock actualizado"
        End If

        grdVinos.DataSource = ws.Consulta()
        grdVinos.DataBind()
    End Sub
End Class