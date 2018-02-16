Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AlmacenDataSet.Vinos' Puede moverla o quitarla según sea necesario.
        Me.VinosTableAdapter.Fill(Me.AlmacenDataSet.Vinos)

        cbOrdenar.Items.Add("Nombre")
        cbOrdenar.Items.Add("Año")
        cbOrdenar.Items.Add("Tipo")
        cbOrdenar.Items.Add("Precio")
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        MsgBox("Se añadio el vino")
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        MsgBox("Se retiro el vino")
    End Sub


End Class