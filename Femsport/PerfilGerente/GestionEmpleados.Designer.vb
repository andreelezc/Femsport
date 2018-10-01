<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionEmpleados))
        Me.TBuscarEmp = New System.Windows.Forms.TextBox()
        Me.ComboFiltrar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.BAgregarEmpleado = New System.Windows.Forms.Button()
        Me.BEliminarEmpleado = New System.Windows.Forms.Button()
        Me.BEditarEmpleado = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBuscarEmp
        '
        Me.TBuscarEmp.Location = New System.Drawing.Point(273, 30)
        Me.TBuscarEmp.Name = "TBuscarEmp"
        Me.TBuscarEmp.Size = New System.Drawing.Size(150, 20)
        Me.TBuscarEmp.TabIndex = 38
        '
        'ComboFiltrar
        '
        Me.ComboFiltrar.FormattingEnabled = True
        Me.ComboFiltrar.Items.AddRange(New Object() {"CUIT", "DNI", "Nombre", "Apellido", "Pais", "Provincia", "Nombre", "Telefono", "Dirección"})
        Me.ComboFiltrar.Location = New System.Drawing.Point(86, 30)
        Me.ComboFiltrar.Name = "ComboFiltrar"
        Me.ComboFiltrar.Size = New System.Drawing.Size(154, 21)
        Me.ComboFiltrar.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(28, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Filtrar"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column7, Me.Column8, Me.Column3, Me.Column4, Me.Column5, Me.Column9, Me.Column10, Me.Column11})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridView1.Size = New System.Drawing.Size(635, 183)
        Me.DataGridView1.TabIndex = 34
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
        'Column2
        '
        Me.Column2.HeaderText = "Nombre y Apellido"
        Me.Column2.Name = "Column2"
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
        'Column11
        '
        Me.Column11.HeaderText = "Fecha de Ingreso"
        Me.Column11.Name = "Column11"
        '
        'BBuscar
        '
        Me.BBuscar.Image = Global.Femsport.My.Resources.Resources.if_icon_111_search_3146893
        Me.BBuscar.Location = New System.Drawing.Point(429, 24)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(35, 31)
        Me.BBuscar.TabIndex = 36
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'BAgregarEmpleado
        '
        Me.BAgregarEmpleado.Image = Global.Femsport.My.Resources.Resources.if_sign_add_299068
        Me.BAgregarEmpleado.Location = New System.Drawing.Point(543, 20)
        Me.BAgregarEmpleado.Name = "BAgregarEmpleado"
        Me.BAgregarEmpleado.Size = New System.Drawing.Size(35, 31)
        Me.BAgregarEmpleado.TabIndex = 39
        Me.BAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'BEliminarEmpleado
        '
        Me.BEliminarEmpleado.Image = Global.Femsport.My.Resources.Resources.if_Close_1891023
        Me.BEliminarEmpleado.Location = New System.Drawing.Point(584, 20)
        Me.BEliminarEmpleado.Name = "BEliminarEmpleado"
        Me.BEliminarEmpleado.Size = New System.Drawing.Size(35, 31)
        Me.BEliminarEmpleado.TabIndex = 40
        Me.BEliminarEmpleado.UseVisualStyleBackColor = True
        '
        'BEditarEmpleado
        '
        Me.BEditarEmpleado.Image = Global.Femsport.My.Resources.Resources.if_edit_change_pencil_2931178
        Me.BEditarEmpleado.Location = New System.Drawing.Point(625, 20)
        Me.BEditarEmpleado.Name = "BEditarEmpleado"
        Me.BEditarEmpleado.Size = New System.Drawing.Size(35, 31)
        Me.BEditarEmpleado.TabIndex = 41
        Me.BEditarEmpleado.UseVisualStyleBackColor = True
        '
        'GestionEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Femsport.My.Resources.Resources.pink_yellow_gradient_wallpaper_16
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(691, 277)
        Me.Controls.Add(Me.BAgregarEmpleado)
        Me.Controls.Add(Me.BEliminarEmpleado)
        Me.Controls.Add(Me.BEditarEmpleado)
        Me.Controls.Add(Me.TBuscarEmp)
        Me.Controls.Add(Me.ComboFiltrar)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionEmpleados"
        Me.Text = "Lista de Empleados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBuscarEmp As TextBox
    Friend WithEvents ComboFiltrar As ComboBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents BAgregarEmpleado As Button
    Friend WithEvents BEliminarEmpleado As Button
    Friend WithEvents BEditarEmpleado As Button
End Class
