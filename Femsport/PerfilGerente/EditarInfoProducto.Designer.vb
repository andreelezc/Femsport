<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarInfoProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarInfoProducto))
        Me.DateFechaAltaProd = New System.Windows.Forms.DateTimePicker()
        Me.TStockMin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxMarca = New System.Windows.Forms.ComboBox()
        Me.TComentarios = New System.Windows.Forms.TextBox()
        Me.TStock = New System.Windows.Forms.TextBox()
        Me.TPrecio = New System.Windows.Forms.TextBox()
        Me.TColor = New System.Windows.Forms.TextBox()
        Me.TTalle = New System.Windows.Forms.TextBox()
        Me.TModelo = New System.Windows.Forms.TextBox()
        Me.TTipoArticulo = New System.Windows.Forms.TextBox()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.LFechaAlta = New System.Windows.Forms.Label()
        Me.LComentarios = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LColor = New System.Windows.Forms.Label()
        Me.LTalle = New System.Windows.Forms.Label()
        Me.LModelo = New System.Windows.Forms.Label()
        Me.LMarcaArt = New System.Windows.Forms.Label()
        Me.LTipoArt = New System.Windows.Forms.Label()
        Me.LCodArt = New System.Windows.Forms.Label()
        Me.LNombreProd = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BConfirmar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateFechaAltaProd
        '
        Me.DateFechaAltaProd.Location = New System.Drawing.Point(434, 198)
        Me.DateFechaAltaProd.Name = "DateFechaAltaProd"
        Me.DateFechaAltaProd.Size = New System.Drawing.Size(247, 20)
        Me.DateFechaAltaProd.TabIndex = 36
        '
        'TStockMin
        '
        Me.TStockMin.Location = New System.Drawing.Point(524, 284)
        Me.TStockMin.Name = "TStockMin"
        Me.TStockMin.Size = New System.Drawing.Size(69, 20)
        Me.TStockMin.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(430, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Stock Mínimo"
        '
        'ComboBoxMarca
        '
        Me.ComboBoxMarca.FormattingEnabled = True
        Me.ComboBoxMarca.Location = New System.Drawing.Point(114, 175)
        Me.ComboBoxMarca.Name = "ComboBoxMarca"
        Me.ComboBoxMarca.Size = New System.Drawing.Size(182, 21)
        Me.ComboBoxMarca.TabIndex = 33
        '
        'TComentarios
        '
        Me.TComentarios.Location = New System.Drawing.Point(433, 71)
        Me.TComentarios.Multiline = True
        Me.TComentarios.Name = "TComentarios"
        Me.TComentarios.Size = New System.Drawing.Size(248, 84)
        Me.TComentarios.TabIndex = 31
        '
        'TStock
        '
        Me.TStock.Location = New System.Drawing.Point(524, 247)
        Me.TStock.Name = "TStock"
        Me.TStock.Size = New System.Drawing.Size(69, 20)
        Me.TStock.TabIndex = 27
        '
        'TPrecio
        '
        Me.TPrecio.Location = New System.Drawing.Point(114, 353)
        Me.TPrecio.Name = "TPrecio"
        Me.TPrecio.Size = New System.Drawing.Size(182, 20)
        Me.TPrecio.TabIndex = 26
        '
        'TColor
        '
        Me.TColor.Location = New System.Drawing.Point(114, 309)
        Me.TColor.Name = "TColor"
        Me.TColor.Size = New System.Drawing.Size(182, 20)
        Me.TColor.TabIndex = 25
        '
        'TTalle
        '
        Me.TTalle.Location = New System.Drawing.Point(114, 265)
        Me.TTalle.Name = "TTalle"
        Me.TTalle.Size = New System.Drawing.Size(182, 20)
        Me.TTalle.TabIndex = 24
        '
        'TModelo
        '
        Me.TModelo.Location = New System.Drawing.Point(114, 224)
        Me.TModelo.Name = "TModelo"
        Me.TModelo.Size = New System.Drawing.Size(182, 20)
        Me.TModelo.TabIndex = 28
        '
        'TTipoArticulo
        '
        Me.TTipoArticulo.Location = New System.Drawing.Point(146, 135)
        Me.TTipoArticulo.Name = "TTipoArticulo"
        Me.TTipoArticulo.Size = New System.Drawing.Size(150, 20)
        Me.TTipoArticulo.TabIndex = 23
        '
        'TCodigo
        '
        Me.TCodigo.Location = New System.Drawing.Point(114, 89)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(182, 20)
        Me.TCodigo.TabIndex = 22
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(114, 43)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(182, 20)
        Me.TNombre.TabIndex = 21
        '
        'LFechaAlta
        '
        Me.LFechaAlta.AutoSize = True
        Me.LFechaAlta.BackColor = System.Drawing.Color.Transparent
        Me.LFechaAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LFechaAlta.Location = New System.Drawing.Point(430, 167)
        Me.LFechaAlta.Name = "LFechaAlta"
        Me.LFechaAlta.Size = New System.Drawing.Size(91, 16)
        Me.LFechaAlta.TabIndex = 19
        Me.LFechaAlta.Text = "Fecha de Alta"
        '
        'LComentarios
        '
        Me.LComentarios.AutoSize = True
        Me.LComentarios.BackColor = System.Drawing.Color.Transparent
        Me.LComentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LComentarios.Location = New System.Drawing.Point(430, 43)
        Me.LComentarios.Name = "LComentarios"
        Me.LComentarios.Size = New System.Drawing.Size(84, 16)
        Me.LComentarios.TabIndex = 18
        Me.LComentarios.Text = "Comentarios"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.BackColor = System.Drawing.Color.Transparent
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LStock.Location = New System.Drawing.Point(430, 248)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(42, 16)
        Me.LStock.TabIndex = 17
        Me.LStock.Text = "Stock"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.BackColor = System.Drawing.Color.Transparent
        Me.LPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LPrecio.Location = New System.Drawing.Point(38, 354)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(47, 16)
        Me.LPrecio.TabIndex = 16
        Me.LPrecio.Text = "Precio"
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.BackColor = System.Drawing.Color.Transparent
        Me.LColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LColor.Location = New System.Drawing.Point(38, 309)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(40, 16)
        Me.LColor.TabIndex = 15
        Me.LColor.Text = "Color"
        '
        'LTalle
        '
        Me.LTalle.AutoSize = True
        Me.LTalle.BackColor = System.Drawing.Color.Transparent
        Me.LTalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LTalle.Location = New System.Drawing.Point(38, 266)
        Me.LTalle.Name = "LTalle"
        Me.LTalle.Size = New System.Drawing.Size(39, 16)
        Me.LTalle.TabIndex = 14
        Me.LTalle.Text = "Talle"
        '
        'LModelo
        '
        Me.LModelo.AutoSize = True
        Me.LModelo.BackColor = System.Drawing.Color.Transparent
        Me.LModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LModelo.Location = New System.Drawing.Point(38, 224)
        Me.LModelo.Name = "LModelo"
        Me.LModelo.Size = New System.Drawing.Size(54, 16)
        Me.LModelo.TabIndex = 13
        Me.LModelo.Text = "Modelo"
        '
        'LMarcaArt
        '
        Me.LMarcaArt.AutoSize = True
        Me.LMarcaArt.BackColor = System.Drawing.Color.Transparent
        Me.LMarcaArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LMarcaArt.Location = New System.Drawing.Point(38, 180)
        Me.LMarcaArt.Name = "LMarcaArt"
        Me.LMarcaArt.Size = New System.Drawing.Size(46, 16)
        Me.LMarcaArt.TabIndex = 12
        Me.LMarcaArt.Text = "Marca"
        '
        'LTipoArt
        '
        Me.LTipoArt.AutoSize = True
        Me.LTipoArt.BackColor = System.Drawing.Color.Transparent
        Me.LTipoArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LTipoArt.Location = New System.Drawing.Point(38, 135)
        Me.LTipoArt.Name = "LTipoArt"
        Me.LTipoArt.Size = New System.Drawing.Size(102, 16)
        Me.LTipoArt.TabIndex = 11
        Me.LTipoArt.Text = "Tipo de Artículo"
        '
        'LCodArt
        '
        Me.LCodArt.AutoSize = True
        Me.LCodArt.BackColor = System.Drawing.Color.Transparent
        Me.LCodArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LCodArt.Location = New System.Drawing.Point(38, 89)
        Me.LCodArt.Name = "LCodArt"
        Me.LCodArt.Size = New System.Drawing.Size(52, 16)
        Me.LCodArt.TabIndex = 20
        Me.LCodArt.Text = "Código"
        '
        'LNombreProd
        '
        Me.LNombreProd.AutoSize = True
        Me.LNombreProd.BackColor = System.Drawing.Color.Transparent
        Me.LNombreProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LNombreProd.Location = New System.Drawing.Point(38, 43)
        Me.LNombreProd.Name = "LNombreProd"
        Me.LNombreProd.Size = New System.Drawing.Size(57, 16)
        Me.LNombreProd.TabIndex = 10
        Me.LNombreProd.Text = "Nombre"
        '
        'BCancelar
        '
        Me.BCancelar.Image = Global.Femsport.My.Resources.Resources.if_f_cross_256_282471
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCancelar.Location = New System.Drawing.Point(569, 338)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(89, 48)
        Me.BCancelar.TabIndex = 30
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BConfirmar
        '
        Me.BConfirmar.Image = Global.Femsport.My.Resources.Resources.if_Confirm_40044
        Me.BConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BConfirmar.Location = New System.Drawing.Point(434, 338)
        Me.BConfirmar.Name = "BConfirmar"
        Me.BConfirmar.Size = New System.Drawing.Size(93, 48)
        Me.BConfirmar.TabIndex = 29
        Me.BConfirmar.Text = "Confirmar"
        Me.BConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BConfirmar.UseVisualStyleBackColor = True
        '
        'EditarInfoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Femsport.My.Resources.Resources.pink_yellow_gradient_wallpaper_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(719, 419)
        Me.Controls.Add(Me.DateFechaAltaProd)
        Me.Controls.Add(Me.TStockMin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxMarca)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditarInfoProducto"
        Me.Text = "Editar Información de Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateFechaAltaProd As DateTimePicker
    Friend WithEvents TStockMin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxMarca As ComboBox
    Friend WithEvents TComentarios As TextBox
    Friend WithEvents BCancelar As Button
    Friend WithEvents BConfirmar As Button
    Friend WithEvents TStock As TextBox
    Friend WithEvents TPrecio As TextBox
    Friend WithEvents TColor As TextBox
    Friend WithEvents TTalle As TextBox
    Friend WithEvents TModelo As TextBox
    Friend WithEvents TTipoArticulo As TextBox
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents LFechaAlta As Label
    Friend WithEvents LComentarios As Label
    Friend WithEvents LStock As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LColor As Label
    Friend WithEvents LTalle As Label
    Friend WithEvents LModelo As Label
    Friend WithEvents LMarcaArt As Label
    Friend WithEvents LTipoArt As Label
    Friend WithEvents LCodArt As Label
    Friend WithEvents LNombreProd As Label
End Class
