
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AlmacenDataSet1.Vinos' Puede moverla o quitarla según sea necesario.
        Me.VinosTableAdapter.Fill(Me.AlmacenDataSet1.Vinos)

        Dim path As String
        path = Application.StartupPath
        path = path.Replace("\bin\Debug", "\Almacen.accdb")
        'DBBroker.FILEPATH = path
    End Sub

    'Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
    '    Dim v = New Vino
    '    v.nombre = Convert.ToString(grid.CurrentRow.Cells(0).Value)
    '    v.read()
    '    Dim n As Integer
    '    n = v.cantidad + nCantidad.Value
    '    v.cantidad = n
    '    v.añadirCantidad()

    '    Me.VinosTableAdapter.modificarCantidad(n, v.nombre)
    '    Me.VinosTableAdapter.Fill(Me.AlmacenDataSet1.Vinos)
    '    MsgBox("Se han modificado las unidades de: " + v.nombre)
    'End Sub

    'Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
    '    Dim v = New Vino
    '    v.nombre = Convert.ToString(grid.CurrentRow.Cells(0).Value)
    '    v.read()
    '    Dim n As Integer
    '    n = v.cantidad - nCantidad.Value
    '    v.cantidad = n
    '    v.añadirCantidad()

    '    Me.VinosTableAdapter.modificarCantidad(n, v.nombre)
    '    Me.VinosTableAdapter.Fill(Me.AlmacenDataSet1.Vinos)
    '    MsgBox("Se han modificado las unidades de: " + v.nombre)

    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim v As Vino = New Vino
    '    v.nombre = Convert.ToString(grid.CurrentRow.Cells(0).Value)
    '    v.año = Convert.ToString(grid.CurrentRow.Cells(1).Value)
    '    v.grados = Convert.ToString(grid.CurrentRow.Cells(2).Value)
    '    v.cantidad = Convert.ToString(grid.CurrentRow.Cells(3).Value)
    '    v.fechaEntrada = Convert.ToString(grid.CurrentRow.Cells(4).Value)
    '    v.tipo = Convert.ToString(grid.CurrentRow.Cells(5).Value)
    '    v.precio = Convert.ToString(grid.CurrentRow.Cells(6).Value)

    '    v.insertarVino()

    '    Me.VinosTableAdapter.insertarVino(v.nombre, v.año, v.grados, v.cantidad, v.fechaEntrada, v.tipo, v.precio)
    '    Me.VinosTableAdapter.Fill(Me.AlmacenDataSet1.Vinos)

    '    MsgBox("Se ha añadido el vino a la base de datos")
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim v As Vino = New Vino
    '    v.nombre = Convert.ToString(grid.CurrentRow.Cells(0).Value)

    '    v.eliminarVino()

    '    Me.VinosTableAdapter.eliminarVino(v.nombre)
    '    Me.VinosTableAdapter.Fill(Me.AlmacenDataSet1.Vinos)

    '    MsgBox("Se ha eliminado el vino de la base de datos")
    'End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim db As New DBBroker()
    End Sub
End Class