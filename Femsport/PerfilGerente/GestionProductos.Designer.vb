<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionProductos))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BAgregarProducto = New System.Windows.Forms.Button()
        Me.BEliminarProducto = New System.Windows.Forms.Button()
        Me.BEditarProducto = New System.Windows.Forms.Button()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.ComboFiltrar = New System.Windows.Forms.ComboBox()
        Me.TBuscarProd = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column6, Me.Column7, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(23, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(750, 189)
        Me.DataGridView1.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Marca"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Talle"
        Me.Column7.Name = "Column7"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Descripción"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Imagen"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Precio"
        Me.Column5.Name = "Column5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(20, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Filtrar"
        '
        'BAgregarProducto
        '
        Me.BAgregarProducto.Image = Global.Femsport.My.Resources.Resources.if_sign_add_299068
        Me.BAgregarProducto.Location = New System.Drawing.Point(656, 22)
        Me.BAgregarProducto.Name = "BAgregarProducto"
        Me.BAgregarProducto.Size = New System.Drawing.Size(35, 31)
        Me.BAgregarProducto.TabIndex = 13
        Me.BAgregarProducto.UseVisualStyleBackColor = True
        '
        'BEliminarProducto
        '
        Me.BEliminarProducto.Image = Global.Femsport.My.Resources.Resources.if_Close_1891023
        Me.BEliminarProducto.Location = New System.Drawing.Point(697, 22)
        Me.BEliminarProducto.Name = "BEliminarProducto"
        Me.BEliminarProducto.Size = New System.Drawing.Size(35, 31)
        Me.BEliminarProducto.TabIndex = 13
        Me.BEliminarProducto.UseVisualStyleBackColor = True
        '
        'BEditarProducto
        '
        Me.BEditarProducto.Image = Global.Femsport.My.Resources.Resources.if_edit_change_pencil_2931178
        Me.BEditarProducto.Location = New System.Drawing.Point(738, 22)
        Me.BEditarProducto.Name = "BEditarProducto"
        Me.BEditarProducto.Size = New System.Drawing.Size(35, 31)
        Me.BEditarProducto.TabIndex = 13
        Me.BEditarProducto.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.Image = Global.Femsport.My.Resources.Resources.if_icon_111_search_3146893
        Me.BBuscar.Location = New System.Drawing.Point(421, 22)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(35, 31)
        Me.BBuscar.TabIndex = 13
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'ComboFiltrar
        '
        Me.ComboFiltrar.FormattingEnabled = True
        Me.ComboFiltrar.Items.AddRange(New Object() {"Codigo", "Nombre", "Tipo", "Marca"})
        Me.ComboFiltrar.Location = New System.Drawing.Point(78, 28)
        Me.ComboFiltrar.Name = "ComboFiltrar"
        Me.ComboFiltrar.Size = New System.Drawing.Size(154, 21)
        Me.ComboFiltrar.TabIndex = 24
        '
        'TBuscarProd
        '
        Me.TBuscarProd.Location = New System.Drawing.Point(265, 28)
        Me.TBuscarProd.Name = "TBuscarProd"
        Me.TBuscarProd.Size = New System.Drawing.Size(150, 20)
        Me.TBuscarProd.TabIndex = 25
        '
        'GestionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.Femsport.My.Resources.Resources.pink_yellow_gradient_wallpaper_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(785, 292)
        Me.Controls.Add(Me.TBuscarProd)
        Me.Controls.Add(Me.ComboFiltrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BAgregarProducto)
        Me.Controls.Add(Me.BEliminarProducto)
        Me.Controls.Add(Me.BEditarProducto)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionProductos"
        Me.Text = "Gestión de Productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BEditarProducto As Button
    Friend WithEvents BEliminarProducto As Button
    Friend WithEvents BAgregarProducto As Button
    Friend WithEvents ComboFiltrar As ComboBox
    Friend WithEvents TBuscarProd As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
