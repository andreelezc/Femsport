<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturaDetalle))
        Me.TBuscarProd = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LFiltrar = New System.Windows.Forms.Label()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BConfirmar = New System.Windows.Forms.Button()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.TCantidad = New System.Windows.Forms.TextBox()
        Me.ComboFiltrar = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBuscarProd
        '
        Me.TBuscarProd.Location = New System.Drawing.Point(413, 22)
        Me.TBuscarProd.Name = "TBuscarProd"
        Me.TBuscarProd.Size = New System.Drawing.Size(195, 20)
        Me.TBuscarProd.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 178)
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
        'Column3
        '
        Me.Column3.HeaderText = "Descripcion"
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
        'Column6
        '
        Me.Column6.HeaderText = "Stock"
        Me.Column6.Name = "Column6"
        '
        'LFiltrar
        '
        Me.LFiltrar.AutoSize = True
        Me.LFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.LFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LFiltrar.Location = New System.Drawing.Point(9, 26)
        Me.LFiltrar.Name = "LFiltrar"
        Me.LFiltrar.Size = New System.Drawing.Size(41, 16)
        Me.LFiltrar.TabIndex = 12
        Me.LFiltrar.Text = "Filtrar"
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LCantidad.Location = New System.Drawing.Point(12, 279)
        Me.LCantidad.Name = "LCantidad"
        Me.LCantidad.Size = New System.Drawing.Size(62, 16)
        Me.LCantidad.TabIndex = 19
        Me.LCantidad.Text = "Cantidad"
        '
        'BCancelar
        '
        Me.BCancelar.BackgroundImage = Global.Femsport.My.Resources.Resources.if_f_cross_256_282471
        Me.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCancelar.Location = New System.Drawing.Point(606, 265)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(42, 36)
        Me.BCancelar.TabIndex = 21
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BConfirmar
        '
        Me.BConfirmar.BackgroundImage = Global.Femsport.My.Resources.Resources.Ok_icon
        Me.BConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BConfirmar.Location = New System.Drawing.Point(545, 265)
        Me.BConfirmar.Name = "BConfirmar"
        Me.BConfirmar.Size = New System.Drawing.Size(44, 36)
        Me.BConfirmar.TabIndex = 20
        Me.BConfirmar.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BBuscar.Image = Global.Femsport.My.Resources.Resources.if_icon_111_search_3146893
        Me.BBuscar.Location = New System.Drawing.Point(624, 14)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(35, 31)
        Me.BBuscar.TabIndex = 13
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'TCantidad
        '
        Me.TCantidad.Location = New System.Drawing.Point(80, 274)
        Me.TCantidad.Multiline = True
        Me.TCantidad.Name = "TCantidad"
        Me.TCantidad.Size = New System.Drawing.Size(73, 27)
        Me.TCantidad.TabIndex = 22
        '
        'ComboFiltrar
        '
        Me.ComboFiltrar.FormattingEnabled = True
        Me.ComboFiltrar.Items.AddRange(New Object() {"Codigo", "Tipo", "Marca"})
        Me.ComboFiltrar.Location = New System.Drawing.Point(67, 23)
        Me.ComboFiltrar.Name = "ComboFiltrar"
        Me.ComboFiltrar.Size = New System.Drawing.Size(154, 21)
        Me.ComboFiltrar.TabIndex = 23
        '
        'FacturaDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Femsport.My.Resources.Resources.pink_yellow_gradient_wallpaper_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(672, 322)
        Me.Controls.Add(Me.ComboFiltrar)
        Me.Controls.Add(Me.TCantidad)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BConfirmar)
        Me.Controls.Add(Me.LCantidad)
        Me.Controls.Add(Me.TBuscarProd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.LFiltrar)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FacturaDetalle"
        Me.Text = "Detalle Factura"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBuscarProd As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BBuscar As Button
    Friend WithEvents LFiltrar As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents LCantidad As Label
    Friend WithEvents BConfirmar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents TCantidad As TextBox
    Friend WithEvents ComboFiltrar As ComboBox
End Class
