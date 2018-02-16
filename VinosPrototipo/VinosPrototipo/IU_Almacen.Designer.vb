<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbOrdenar = New System.Windows.Forms.ComboBox()
        Me.cbCantidad = New System.Windows.Forms.ComboBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gpBox = New System.Windows.Forms.GroupBox()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Año, Me.Tipo, Me.Grados, Me.Precio, Me.Cantidad})
        Me.grid.Location = New System.Drawing.Point(0, 35)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(644, 150)
        Me.grid.TabIndex = 0
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Año
        '
        Me.Año.HeaderText = "Año"
        Me.Año.Name = "Año"
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Grados
        '
        Me.Grados.HeaderText = "Grados"
        Me.Grados.Name = "Grados"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(488, 6)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAñadir.TabIndex = 1
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(569, 6)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(75, 23)
        Me.btnRetirar.TabIndex = 2
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ordenar por"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cantidad"
        '
        'cbOrdenar
        '
        Me.cbOrdenar.FormattingEnabled = True
        Me.cbOrdenar.Location = New System.Drawing.Point(203, 8)
        Me.cbOrdenar.Name = "cbOrdenar"
        Me.cbOrdenar.Size = New System.Drawing.Size(121, 21)
        Me.cbOrdenar.TabIndex = 5
        '
        'cbCantidad
        '
        Me.cbCantidad.FormattingEnabled = True
        Me.cbCantidad.Location = New System.Drawing.Point(55, 8)
        Me.cbCantidad.Name = "cbCantidad"
        Me.cbCantidad.Size = New System.Drawing.Size(40, 21)
        Me.cbCantidad.TabIndex = 6
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(11, 204)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(563, 20)
        Me.txtPath.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(580, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Conectar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gpBox
        '
        Me.gpBox.Controls.Add(Me.cbCantidad)
        Me.gpBox.Controls.Add(Me.cbOrdenar)
        Me.gpBox.Controls.Add(Me.Label2)
        Me.gpBox.Controls.Add(Me.Label1)
        Me.gpBox.Controls.Add(Me.btnRetirar)
        Me.gpBox.Controls.Add(Me.btnAñadir)
        Me.gpBox.Controls.Add(Me.grid)
        Me.gpBox.Enabled = False
        Me.gpBox.Location = New System.Drawing.Point(11, 12)
        Me.gpBox.Name = "gpBox"
        Me.gpBox.Size = New System.Drawing.Size(650, 190)
        Me.gpBox.TabIndex = 9
        Me.gpBox.TabStop = False
        '
        'Almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 236)
        Me.Controls.Add(Me.gpBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPath)
        Me.Name = "Almacen"
        Me.Text = "Almacen"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpBox.ResumeLayout(False)
        Me.gpBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Año As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Grados As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnRetirar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbOrdenar As ComboBox
    Friend WithEvents cbCantidad As ComboBox

    ' Private Sub Almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Dim v As Vino = New Vino()
    'Dim c As Collection = v.readAll()
    'For Each v In c
    '       grid.Rows.Add(v.nombre, v.año, v.tipo, v.grados, v.precio, v.cantidad)
    'Next
    'End Sub

    Friend WithEvents txtPath As TextBox
    Friend WithEvents Button1 As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dialogo As New OpenFileDialog
        dialogo.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        dialogo.Filter = "Access File|*.accdb"
        dialogo.ShowDialog()
        Dim filename As String = dialogo.FileName
        txtPath.Text = filename
        Try
            DBBroker.FILEPATH = filename
        Catch ex As Exception
            MsgBox("Venga crack")
        End Try
        Dim v As Vino = New Vino()
        Dim c As Collection = v.readAll()
        For Each v In c
            grid.Rows.Add(v.nombre, v.año, v.tipo, v.grados, v.precio, v.cantidad)
        Next
        gpBox.Enabled = True

        cbCantidad.Items.Add("1")
        cbCantidad.Items.Add("2")
        cbCantidad.Items.Add("3")
        cbCantidad.Items.Add("4")
        cbCantidad.Items.Add("5")
        cbOrdenar.Items.Add("Nombre")
        cbOrdenar.Items.Add("Año")
        cbOrdenar.Items.Add("Tipo")
        cbOrdenar.Items.Add("Precio")
    End Sub

    Friend WithEvents gpBox As GroupBox

    ''Esto es mierdaa
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim v As Vino = New Vino()
        v.nombre = Convert.ToString(grid.Rows(grid.Rows.Count - 1).Cells(0).Value)
        v.año = Convert.ToInt32(grid.Rows(grid.Rows.Count - 1).Cells(1).Value)
        v.tipo = Convert.ToString(grid.Rows(grid.Rows.Count - 1).Cells(2).Value)
        v.grados = Convert.ToDouble(grid.Rows(grid.Rows.Count - 1).Cells(3).Value)
        v.precio = Convert.ToDouble(grid.Rows(grid.Rows.Count - 1).Cells(4).Value)
        v.cantidad = Convert.ToInt32(grid.Rows(grid.Rows.Count - 1).Cells(5).Value)
        v.añadir()
        MsgBox("Se añadio el vino")
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim v As Vino = New Vino()
        v.nombre = Convert.ToString(grid.Rows(2).Cells(0).Value)
        MsgBox("Se retiro el vino")
    End Sub
End Class
