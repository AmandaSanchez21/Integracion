<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VinosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmacenDataSet1 = New WindowsApp1.AlmacenDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nCantidad = New System.Windows.Forms.NumericUpDown()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.VinosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmacenDataSet = New WindowsApp1.AlmacenDataSet()
        Me.VinosTableAdapter = New WindowsApp1.AlmacenDataSetTableAdapters.VinosTableAdapter()
        Me.VinosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmacenDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VinosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VinosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VinosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(439, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.nCantidad)
        Me.GroupBox1.Controls.Add(Me.btnRetirar)
        Me.GroupBox1.Controls.Add(Me.btnAñadir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(759, 254)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'VinosBindingSource2
        '
        Me.VinosBindingSource2.DataMember = "Vinos"
        Me.VinosBindingSource2.DataSource = Me.AlmacenDataSet1
        '
        'AlmacenDataSet1
        '
        Me.AlmacenDataSet1.DataSetName = "AlmacenDataSet"
        Me.AlmacenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PRODUCTOS DISPONIBLES"
        '
        'nCantidad
        '
        Me.nCantidad.Location = New System.Drawing.Point(504, 12)
        Me.nCantidad.Name = "nCantidad"
        Me.nCantidad.Size = New System.Drawing.Size(49, 20)
        Me.nCantidad.TabIndex = 2
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(660, 11)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(75, 23)
        Me.btnRetirar.TabIndex = 5
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(579, 11)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAñadir.TabIndex = 4
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Introducir Vino"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(133, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Eliminar Vino"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'VinosBindingSource
        '
        Me.VinosBindingSource.DataMember = "Vinos"
        Me.VinosBindingSource.DataSource = Me.AlmacenDataSet
        '
        'AlmacenDataSet
        '
        Me.AlmacenDataSet.DataSetName = "AlmacenDataSet"
        Me.AlmacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VinosTableAdapter
        '
        Me.VinosTableAdapter.ClearBeforeFill = True
        '
        'VinosBindingSource1
        '
        Me.VinosBindingSource1.DataMember = "Vinos"
        Me.VinosBindingSource1.DataSource = Me.AlmacenDataSet
        '
        'AlmacenDataSetBindingSource
        '
        Me.AlmacenDataSetBindingSource.DataSource = Me.AlmacenDataSet
        Me.AlmacenDataSetBindingSource.Position = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(327, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(787, 307)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VinosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VinosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VinosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbOrdenar As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnRetirar As Button
    Friend WithEvents AlmacenDataSet As AlmacenDataSet
    Friend WithEvents VinosBindingSource As BindingSource
    Friend WithEvents VinosTableAdapter As AlmacenDataSetTableAdapters.VinosTableAdapter
    Friend WithEvents FechaDeEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents nCantidad As NumericUpDown
    Friend WithEvents VinosBindingSource1 As BindingSource
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AlmacenDataSetBindingSource As BindingSource
    Friend WithEvents AlmacenDataSet1 As AlmacenDataSet
    Friend WithEvents VinosBindingSource2 As BindingSource
    Friend WithEvents Button3 As Button
End Class
