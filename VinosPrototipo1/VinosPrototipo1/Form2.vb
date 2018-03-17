Public Class Form2
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

        'Me.AlmacenTableAdapter.modificarstock(n, v.id)
        'Me.AlmacenTableAdapter.Fill(Me.AlmacenDataSet1.Almacen)
        'MsgBox("Se han modificado las unidades de: " + v.id)
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim v = New Almacen
        v.id = Convert.ToString(grid.CurrentRow.Cells(0).Value)
        v.read()
        Dim n As Integer
        n = v.stock - nStock.Value
        v.stock = n
        v.añadirStock()

        'Me.AlmacenTableAdapter.modificarstock(n, v.id)
        'Me.AlmacenTableAdapter.Fill(Me.AlmacenDataSet1.Almacen)
        'MsgBox("Se han modificado las unidades de: " + v.id)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v As Almacen = New Almacen
        v.id = Convert.ToString(grid.CurrentRow.Cells(0).Value)
        v.stock = Convert.ToString(grid.CurrentRow.Cells(1).Value)
        v.pvp = Convert.ToString(grid.CurrentRow.Cells(2).Value)
        v.estado = Convert.ToString(grid.CurrentRow.Cells(3).Value)

        v.insertarVino()

        'Me.AlmacenTableAdapter.insertarVino(v.id, v.stock, v.pvp, v.estado)
        'Me.AlmacenTableAdapter.Fill(Me.AlmacenDataSet1.Almacen)
        'MsgBox("Se ha añadido el Almacen a la base de datos")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim v As Almacen = New Almacen
        v.id = Convert.ToString(grid.CurrentRow.Cells(0).Value)

        v.eliminarVino()

        'Me.AlmacenTableAdapter.eliminarVino(v.id)
        'Me.AlmacenTableAdapter.Fill(Me.AlmacenDataSet1.Almacen)
        'MsgBox("Se ha eliminado el Almacen de la base de datos")
    End Sub
End Class