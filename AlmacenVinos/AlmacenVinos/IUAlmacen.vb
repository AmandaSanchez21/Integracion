Public Class IUAlmacen
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Almacen = New Almacen()
        Dim c As Collection = a.readAll()

        For Each a In c
            grid.Rows.Add(a.id, a.stock, a.pvp, a.estado)
        Next
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim v = New Almacen
        v.id = Convert.ToString(grid.CurrentRow.Cells(0).Value)
        v.read()
        Dim n As Integer
        n = v.stock + nStock.Value
        v.stock = n
        v.añadirStock()

        grid.CurrentRow.Cells(1).Value = n
        MsgBox("Se han modificado las unidades del vino con Id: " + v.id.ToString)
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim v = New Almacen
        v.id = Convert.ToString(grid.CurrentRow.Cells(0).Value)
        v.read()
        Dim n As Integer
        n = v.stock - nStock.Value
        v.stock = n
        v.añadirStock()

        grid.CurrentRow.Cells(1).Value = n
        MsgBox("Se han modificado las unidades del vino con Id: " + v.id.ToString)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v As Almacen = New Almacen
        v.id = Convert.ToString(grid.CurrentRow.Cells(0).Value)
        v.stock = Convert.ToString(grid.CurrentRow.Cells(1).Value)
        v.pvp = Convert.ToString(grid.CurrentRow.Cells(2).Value)
        v.estado = Convert.ToString(grid.CurrentRow.Cells(3).Value)

        v.insertarVino()

        MsgBox("Se han añadido el vino con Id: " + v.id.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim v As Almacen = New Almacen
        v.id = Convert.ToString(grid.CurrentRow.Cells(0).Value)

        v.eliminarVino()

        grid.Rows.Remove(grid.CurrentRow)
        MsgBox("Se han eliminado el vino con Id: " + v.id.ToString)
    End Sub
End Class