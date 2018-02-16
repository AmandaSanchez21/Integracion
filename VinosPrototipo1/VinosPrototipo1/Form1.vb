Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AlmacenDataSet.Vinos' Puede moverla o quitarla según sea necesario.
        Me.VinosTableAdapter.Fill(Me.AlmacenDataSet.Vinos)
        'Dim path As String
        'Dim i As Integer = Application.StartupPath.Length
        'i = i - 25
        'path = Application.StartupPath.Remove(i, Application.StartupPath.Length)
        'DBBroker.FILEPATH = path
        'MsgBox(path)
        cbOrdenar.Items.Add("Nombre")
        cbOrdenar.Items.Add("Año")
        cbOrdenar.Items.Add("Tipo")
        cbOrdenar.Items.Add("Precio")
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim v = New Vino
        v.nombre = Convert.ToString(grid.CurrentRow.Cells(0).Value)
        v.read()
        Dim n As Integer
        n = v.cantidad + nCantidad.Value
        v.cantidad = n
        v.añadirCantidad()
        'MsgBox("Se añadió el vino")
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        MsgBox("Se retiró el vino")
    End Sub

End Class