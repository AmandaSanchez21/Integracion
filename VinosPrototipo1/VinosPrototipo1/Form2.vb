Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Almacen = New Almacen()
        Dim c As Collection = a.readAll()

        For Each a In c
            grid.Rows.Add(a.id, a.stock, a.pvp, a.estado)
        Next
    End Sub
End Class