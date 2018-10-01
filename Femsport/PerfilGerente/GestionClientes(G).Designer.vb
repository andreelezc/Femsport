<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionClientes_G_
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionClientes_G_))
        Me.TBuscarCliente = New System.Windows.Forms.TextBox()
        Me.ComboFiltrar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.BAgregarCliente = New System.Windows.Forms.Button()
        Me.BEliminarCliente = New System.Windows.Forms.Button()
        Me.BEditarCliente = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBuscarCliente
        '
        Me.TBuscarCliente.Location = New System.Drawing.Point(272, 29)
        Me.TBuscarCliente.Name = "TBuscarCliente"
        Me.TBuscarCliente.Size = New System.Drawing.Size(150, 20)
        Me.TBuscarCliente.TabIndex = 37
        '
        'ComboFiltrar
        '
        Me.ComboFiltrar.FormattingEnabled = True
        Me.ComboFiltrar.Items.AddRange(New Object() {"Codigo", "Nombre", "Tipo", "Marca"})
        Me.ComboFiltrar.Location = New System.Drawing.Point(85, 29)
        Me.ComboFiltrar.Name = "ComboFiltrar"
        Me.ComboFiltrar.Size = New System.Drawing.Size(154, 21)
        Me.ComboFiltrar.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(27, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Filtrar"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column6, Me.Column7, Me.Column8, Me.Column3, Me.Column4, Me.Column5, Me.Column9, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(29, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(635, 183)
        Me.DataGridView1.TabIndex = 30
        '
        'Column1
        '
        Me.Column1.HeaderText = "DNI"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Apellido"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Fecha de Nacimiento"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Email"
        Me.Column8.Name = "Column8"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Pais"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Provincia"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Localidad"
        Me.Column5.Name = "Column5"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Dirección"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Teléfono"
        Me.Column10.Name = "Column10"
        '
        'BBuscar
        '
        Me.BBuscar.Image = Global.Femsport.My.Resources.Resources.if_icon_111_search_3146893
        Me.BBuscar.Location = New System.Drawing.Point(428, 23)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(35, 31)
        Me.BBuscar.TabIndex = 35
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'BAgregarCliente
        '
        Me.BAgregarCliente.Image = Global.Femsport.My.Resources.Resources.if_sign_add_299068
        Me.BAgregarCliente.Location = New System.Drawing.Point(547, 23)
        Me.BAgregarCliente.Name = "BAgregarCliente"
        Me.BAgregarCliente.Size = New System.Drawing.Size(35, 31)
        Me.BAgregarCliente.TabIndex = 31
        Me.BAgregarCliente.UseVisualStyleBackColor = True
        '
        'BEliminarCliente
        '
        Me.BEliminarCliente.Image = Global.Femsport.My.Resources.Resources.if_Close_1891023
        Me.BEliminarCliente.Location = New System.Drawing.Point(588, 23)
        Me.BEliminarCliente.Name = "BEliminarCliente"
        Me.BEliminarCliente.Size = New System.Drawing.Size(35, 31)
        Me.BEliminarCliente.TabIndex = 32
        Me.BEliminarCliente.UseVisualStyleBackColor = True
        '
        'BEditarCliente
        '
        Me.BEditarCliente.Image = Global.Femsport.My.Resources.Resources.if_edit_change_pencil_2931178
        Me.BEditarCliente.Location = New System.Drawing.Point(629, 23)
        Me.BEditarCliente.Name = "BEditarCliente"
        Me.BEditarCliente.Size = New System.Drawing.Size(35, 31)
        Me.BEditarCliente.TabIndex = 33
        Me.BEditarCliente.UseVisualStyleBackColor = True
        '
        'GestionClientes_G_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Femsport.My.Resources.Resources.pink_yellow_gradient_wallpaper_110
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(691, 277)
        Me.Controls.Add(Me.TBuscarCliente)
        Me.Controls.Add(Me.ComboFiltrar)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BAgregarCliente)
        Me.Controls.Add(Me.BEliminarCliente)
        Me.Controls.Add(Me.BEditarCliente)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionClientes_G_"
        Me.Text = "Gestion de Clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBuscarCliente As TextBox
    Friend WithEvents ComboFiltrar As ComboBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BAgregarCliente As Button
    Friend WithEvents BEliminarCliente As Button
    Friend WithEvents BEditarCliente As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
