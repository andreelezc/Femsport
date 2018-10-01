<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionUsuarios))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BAgregarUsuario = New System.Windows.Forms.Button()
        Me.BEliminarUsuario = New System.Windows.Forms.Button()
        Me.BEditarUsuario = New System.Windows.Forms.Button()
        Me.TBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.ComboFiltrar = New System.Windows.Forms.ComboBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column6, Me.Column1, Me.Column12, Me.Column3, Me.Column4, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(635, 183)
        Me.DataGridView1.TabIndex = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre y Apellido"
        Me.Column2.Name = "Column2"
        '
        'Column6
        '
        Me.Column6.HeaderText = "CUIT"
        Me.Column6.Name = "Column6"
        '
        'Column1
        '
        Me.Column1.HeaderText = "DNI"
        Me.Column1.Name = "Column1"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Fecha de Ingreso"
        Me.Column12.Name = "Column12"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha de Nacimiento"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Email"
        Me.Column4.Name = "Column4"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Cargo"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Pais"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Provincia"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Localidad"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Dirección"
        Me.Column11.Name = "Column11"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Teléfono"
        Me.Column5.Name = "Column5"
        '
        'BAgregarUsuario
        '
        Me.BAgregarUsuario.Image = CType(resources.GetObject("BAgregarUsuario.Image"), System.Drawing.Image)
        Me.BAgregarUsuario.Location = New System.Drawing.Point(548, 24)
        Me.BAgregarUsuario.Name = "BAgregarUsuario"
        Me.BAgregarUsuario.Size = New System.Drawing.Size(35, 31)
        Me.BAgregarUsuario.TabIndex = 41
        Me.BAgregarUsuario.UseVisualStyleBackColor = True
        '
        'BEliminarUsuario
        '
        Me.BEliminarUsuario.Image = CType(resources.GetObject("BEliminarUsuario.Image"), System.Drawing.Image)
        Me.BEliminarUsuario.Location = New System.Drawing.Point(589, 24)
        Me.BEliminarUsuario.Name = "BEliminarUsuario"
        Me.BEliminarUsuario.Size = New System.Drawing.Size(35, 31)
        Me.BEliminarUsuario.TabIndex = 42
        Me.BEliminarUsuario.UseVisualStyleBackColor = True
        '
        'BEditarUsuario
        '
        Me.BEditarUsuario.Image = CType(resources.GetObject("BEditarUsuario.Image"), System.Drawing.Image)
        Me.BEditarUsuario.Location = New System.Drawing.Point(630, 24)
        Me.BEditarUsuario.Name = "BEditarUsuario"
        Me.BEditarUsuario.Size = New System.Drawing.Size(35, 31)
        Me.BEditarUsuario.TabIndex = 43
        Me.BEditarUsuario.UseVisualStyleBackColor = True
        '
        'TBuscarUsuario
        '
        Me.TBuscarUsuario.Location = New System.Drawing.Point(277, 30)
        Me.TBuscarUsuario.Name = "TBuscarUsuario"
        Me.TBuscarUsuario.Size = New System.Drawing.Size(150, 20)
        Me.TBuscarUsuario.TabIndex = 47
        '
        'ComboFiltrar
        '
        Me.ComboFiltrar.FormattingEnabled = True
        Me.ComboFiltrar.Items.AddRange(New Object() {"DNI", "Nombre", "Apellido", "Pais", "Provincia", "Localidad", "Telefono", "Direccion"})
        Me.ComboFiltrar.Location = New System.Drawing.Point(90, 30)
        Me.ComboFiltrar.Name = "ComboFiltrar"
        Me.ComboFiltrar.Size = New System.Drawing.Size(154, 21)
        Me.ComboFiltrar.TabIndex = 46
        '
        'BBuscar
        '
        Me.BBuscar.Image = Global.Femsport.My.Resources.Resources.if_icon_111_search_3146893
        Me.BBuscar.Location = New System.Drawing.Point(433, 24)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(35, 31)
        Me.BBuscar.TabIndex = 45
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(32, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Filtrar"
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Femsport.My.Resources.Resources.pink_yellow_gradient_wallpaper_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(691, 277)
        Me.Controls.Add(Me.TBuscarUsuario)
        Me.Controls.Add(Me.ComboFiltrar)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BAgregarUsuario)
        Me.Controls.Add(Me.BEliminarUsuario)
        Me.Controls.Add(Me.BEditarUsuario)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionUsuarios"
        Me.Text = "Listado de Usuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BAgregarUsuario As Button
    Friend WithEvents BEliminarUsuario As Button
    Friend WithEvents BEditarUsuario As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents TBuscarUsuario As TextBox
    Friend WithEvents ComboFiltrar As ComboBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents Label1 As Label
End Class
