<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaProducto))
        Me.LNombreProd = New System.Windows.Forms.Label()
        Me.LCodArt = New System.Windows.Forms.Label()
        Me.LTipoArt = New System.Windows.Forms.Label()
        Me.LMarcaArt = New System.Windows.Forms.Label()
        Me.LModelo = New System.Windows.Forms.Label()
        Me.LTalle = New System.Windows.Forms.Label()
        Me.LColor = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LComentarios = New System.Windows.Forms.Label()
        Me.LFechaAlta = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.TTipoArticulo = New System.Windows.Forms.TextBox()
        Me.TModelo = New System.Windows.Forms.TextBox()
        Me.TTalle = New System.Windows.Forms.TextBox()
        Me.TColor = New System.Windows.Forms.TextBox()
        Me.TPrecio = New System.Windows.Forms.TextBox()
        Me.TStock = New System.Windows.Forms.TextBox()
        Me.BConfirmar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.TComentarios = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBoxMarca = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TStockMin = New System.Windows.Forms.TextBox()
        Me.DateFechaAltaProd = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LNombreProd
        '
        Me.LNombreProd.AutoSize = True
        Me.LNombreProd.BackColor = System.Drawing.Color.Transparent
        Me.LNombreProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LNombreProd.Location = New System.Drawing.Point(40, 44)
        Me.LNombreProd.Name = "LNombreProd"
        Me.LNombreProd.Size = New System.Drawing.Size(57, 16)
        Me.LNombreProd.TabIndex = 0
        Me.LNombreProd.Text = "Nombre"
        '
        'LCodArt
        '
        Me.LCodArt.AutoSize = True
        Me.LCodArt.BackColor = System.Drawing.Color.Transparent
        Me.LCodArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LCodArt.Location = New System.Drawing.Point(40, 90)
        Me.LCodArt.Name = "LCodArt"
        Me.LCodArt.Size = New System.Drawing.Size(52, 16)
        Me.LCodArt.TabIndex = 0
        Me.LCodArt.Text = "Código"
        '
        'LTipoArt
        '
        Me.LTipoArt.AutoSize = True
        Me.LTipoArt.BackColor = System.Drawing.Color.Transparent
        Me.LTipoArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LTipoArt.Location = New System.Drawing.Point(40, 136)
        Me.LTipoArt.Name = "LTipoArt"
        Me.LTipoArt.Size = New System.Drawing.Size(102, 16)
        Me.LTipoArt.TabIndex = 0
        Me.LTipoArt.Text = "Tipo de Artículo"
        '
        'LMarcaArt
        '
        Me.LMarcaArt.AutoSize = True
        Me.LMarcaArt.BackColor = System.Drawing.Color.Transparent
        Me.LMarcaArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LMarcaArt.Location = New System.Drawing.Point(40, 181)
        Me.LMarcaArt.Name = "LMarcaArt"
        Me.LMarcaArt.Size = New System.Drawing.Size(46, 16)
        Me.LMarcaArt.TabIndex = 0
        Me.LMarcaArt.Text = "Marca"
        '
        'LModelo
        '
        Me.LModelo.AutoSize = True
        Me.LModelo.BackColor = System.Drawing.Color.Transparent
        Me.LModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LModelo.Location = New System.Drawing.Point(40, 225)
        Me.LModelo.Name = "LModelo"
        Me.LModelo.Size = New System.Drawing.Size(54, 16)
        Me.LModelo.TabIndex = 0
        Me.LModelo.Text = "Modelo"
        '
        'LTalle
        '
        Me.LTalle.AutoSize = True
        Me.LTalle.BackColor = System.Drawing.Color.Transparent
        Me.LTalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LTalle.Location = New System.Drawing.Point(40, 267)
        Me.LTalle.Name = "LTalle"
        Me.LTalle.Size = New System.Drawing.Size(39, 16)
        Me.LTalle.TabIndex = 0
        Me.LTalle.Text = "Talle"
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.BackColor = System.Drawing.Color.Transparent
        Me.LColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LColor.Location = New System.Drawing.Point(40, 310)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(40, 16)
        Me.LColor.TabIndex = 0
        Me.LColor.Text = "Color"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.BackColor = System.Drawing.Color.Transparent
        Me.LPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LPrecio.Location = New System.Drawing.Point(40, 355)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(47, 16)
        Me.LPrecio.TabIndex = 0
        Me.LPrecio.Text = "Precio"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.BackColor = System.Drawing.Color.Transparent
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LStock.Location = New System.Drawing.Point(432, 249)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(42, 16)
        Me.LStock.TabIndex = 0
        Me.LStock.Text = "Stock"
        '
        'LComentarios
        '
        Me.LComentarios.AutoSize = True
        Me.LComentarios.BackColor = System.Drawing.Color.Transparent
        Me.LComentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LComentarios.Location = New System.Drawing.Point(432, 44)
        Me.LComentarios.Name = "LComentarios"
        Me.LComentarios.Size = New System.Drawing.Size(84, 16)
        Me.LComentarios.TabIndex = 0
        Me.LComentarios.Text = "Comentarios"
        '
        'LFechaAlta
        '
        Me.LFechaAlta.AutoSize = True
        Me.LFechaAlta.BackColor = System.Drawing.Color.Transparent
        Me.LFechaAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LFechaAlta.Location = New System.Drawing.Point(432, 168)
        Me.LFechaAlta.Name = "LFechaAlta"
        Me.LFechaAlta.Size = New System.Drawing.Size(91, 16)
        Me.LFechaAlta.TabIndex = 0
        Me.LFechaAlta.Text = "Fecha de Alta"
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(116, 40)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(182, 20)
        Me.TNombre.TabIndex = 1
        '
        'TCodigo
        '
        Me.TCodigo.Location = New System.Drawing.Point(116, 90)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(182, 20)
        Me.TCodigo.TabIndex = 1
        '
        'TTipoArticulo
        '
        Me.TTipoArticulo.Location = New System.Drawing.Point(148, 136)
        Me.TTipoArticulo.Name = "TTipoArticulo"
        Me.TTipoArticulo.Size = New System.Drawing.Size(150, 20)
        Me.TTipoArticulo.TabIndex = 1
        '
        'TModelo
        '
        Me.TModelo.Location = New System.Drawing.Point(116, 225)
        Me.TModelo.Name = "TModelo"
        Me.TModelo.Size = New System.Drawing.Size(182, 20)
        Me.TModelo.TabIndex = 1
        '
        'TTalle
        '
        Me.TTalle.Location = New System.Drawing.Point(116, 266)
        Me.TTalle.Name = "TTalle"
        Me.TTalle.Size = New System.Drawing.Size(182, 20)
        Me.TTalle.TabIndex = 1
        '
        'TColor
        '
        Me.TColor.Location = New System.Drawing.Point(116, 310)
        Me.TColor.Name = "TColor"
        Me.TColor.Size = New System.Drawing.Size(182, 20)
        Me.TColor.TabIndex = 1
        '
        'TPrecio
        '
        Me.TPrecio.Location = New System.Drawing.Point(116, 354)
        Me.TPrecio.Name = "TPrecio"
        Me.TPrecio.Size = New System.Drawing.Size(182, 20)
        Me.TPrecio.TabIndex = 1
        '
        'TStock
        '
        Me.TStock.Location = New System.Drawing.Point(526, 248)
        Me.TStock.Name = "TStock"
        Me.TStock.Size = New System.Drawing.Size(69, 20)
        Me.TStock.TabIndex = 1
        '
        'BConfirmar
        '
        Me.BConfirmar.Image = Global.Femsport.My.Resources.Resources.if_Confirm_40044
        Me.BConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BConfirmar.Location = New System.Drawing.Point(436, 339)
        Me.BConfirmar.Name = "BConfirmar"
        Me.BConfirmar.Size = New System.Drawing.Size(93, 48)
        Me.BConfirmar.TabIndex = 3
        Me.BConfirmar.Text = "Confirmar"
        Me.BConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BConfirmar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Image = Global.Femsport.My.Resources.Resources.if_f_cross_256_282471
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCancelar.Location = New System.Drawing.Point(571, 339)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(89, 48)
        Me.BCancelar.TabIndex = 3
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'TComentarios
        '
        Me.TComentarios.Location = New System.Drawing.Point(435, 72)
        Me.TComentarios.Multiline = True
        Me.TComentarios.Name = "TComentarios"
        Me.TComentarios.Size = New System.Drawing.Size(248, 84)
        Me.TComentarios.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(43, 428)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(640, 102)
        Me.DataGridView1.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Código"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tipo de Producto"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Marca"
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
        'ComboBoxMarca
        '
        Me.ComboBoxMarca.FormattingEnabled = True
        Me.ComboBoxMarca.Location = New System.Drawing.Point(116, 176)
        Me.ComboBoxMarca.Name = "ComboBoxMarca"
        Me.ComboBoxMarca.Size = New System.Drawing.Size(182, 21)
        Me.ComboBoxMarca.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(432, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Stock Mínimo"
        '
        'TStockMin
        '
        Me.TStockMin.Location = New System.Drawing.Point(526, 285)
        Me.TStockMin.Name = "TStockMin"
        Me.TStockMin.Size = New System.Drawing.Size(69, 20)
        Me.TStockMin.TabIndex = 8
        '
        'DateFechaAltaProd
        '
        Me.DateFechaAltaProd.Location = New System.Drawing.Point(436, 199)
        Me.DateFechaAltaProd.Name = "DateFechaAltaProd"
        Me.DateFechaAltaProd.Size = New System.Drawing.Size(247, 20)
        Me.DateFechaAltaProd.TabIndex = 9
        '
        'AltaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Femsport.My.Resources.Resources.pink_yellow_gradient_wallpaper_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(719, 568)
        Me.Controls.Add(Me.DateFechaAltaProd)
        Me.Controls.Add(Me.TStockMin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxMarca)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TComentarios)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BConfirmar)
        Me.Controls.Add(Me.TStock)
        Me.Controls.Add(Me.TPrecio)
        Me.Controls.Add(Me.TColor)
        Me.Controls.Add(Me.TTalle)
        Me.Controls.Add(Me.TModelo)
        Me.Controls.Add(Me.TTipoArticulo)
        Me.Controls.Add(Me.TCodigo)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.LFechaAlta)
        Me.Controls.Add(Me.LComentarios)
        Me.Controls.Add(Me.LStock)
        Me.Controls.Add(Me.LPrecio)
        Me.Controls.Add(Me.LColor)
        Me.Controls.Add(Me.LTalle)
        Me.Controls.Add(Me.LModelo)
        Me.Controls.Add(Me.LMarcaArt)
        Me.Controls.Add(Me.LTipoArt)
        Me.Controls.Add(Me.LCodArt)
        Me.Controls.Add(Me.LNombreProd)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaProducto"
        Me.Text = "Alta Producto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LNombreProd As Label
    Friend WithEvents LCodArt As Label
    Friend WithEvents LTipoArt As Label
    Friend WithEvents LMarcaArt As Label
    Friend WithEvents LModelo As Label
    Friend WithEvents LTalle As Label
    Friend WithEvents LColor As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LStock As Label
    Friend WithEvents LComentarios As Label
    Friend WithEvents LFechaAlta As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents TTipoArticulo As TextBox
    Friend WithEvents TModelo As TextBox
    Friend WithEvents TTalle As TextBox
    Friend WithEvents TColor As TextBox
    Friend WithEvents TPrecio As TextBox
    Friend WithEvents TStock As TextBox
    Friend WithEvents BConfirmar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents TComentarios As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBoxMarca As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TStockMin As TextBox
    Friend WithEvents DateFechaAltaProd As DateTimePicker
End Class
