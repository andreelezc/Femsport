<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Facturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturacion))
        Me.LNroFact = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TNroFactura = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelDNI = New System.Windows.Forms.Label()
        Me.LabelNyA = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.LNyACliente = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LabelCUIT = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.BAgregarVendedor = New System.Windows.Forms.Button()
        Me.LCUIT = New System.Windows.Forms.Label()
        Me.LNyAVendedor = New System.Windows.Forms.Label()
        Me.DataListaProductos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TMarca = New System.Windows.Forms.TextBox()
        Me.TSubtotal = New System.Windows.Forms.TextBox()
        Me.TTipo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BConfirmar = New System.Windows.Forms.Button()
        Me.BEliminarProducto = New System.Windows.Forms.Button()
        Me.BCargarProducto = New System.Windows.Forms.Button()
        Me.TTipoFactura = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataListaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LNroFact
        '
        Me.LNroFact.AutoSize = True
        Me.LNroFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LNroFact.Location = New System.Drawing.Point(6, 24)
        Me.LNroFact.Name = "LNroFact"
        Me.LNroFact.Size = New System.Drawing.Size(70, 16)
        Me.LNroFact.TabIndex = 0
        Me.LNroFact.Text = "Factura N°"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label3.Location = New System.Drawing.Point(120, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo"
        '
        'TNroFactura
        '
        Me.TNroFactura.Location = New System.Drawing.Point(79, 23)
        Me.TNroFactura.Name = "TNroFactura"
        Me.TNroFactura.Size = New System.Drawing.Size(35, 20)
        Me.TNroFactura.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TTipoFactura)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TNroFactura)
        Me.GroupBox1.Controls.Add(Me.LNroFact)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 59)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Femsport.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(515, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LabelDNI)
        Me.GroupBox2.Controls.Add(Me.LabelNyA)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.LDNI)
        Me.GroupBox2.Controls.Add(Me.LNyACliente)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(636, 56)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'LabelDNI
        '
        Me.LabelDNI.AutoSize = True
        Me.LabelDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LabelDNI.ForeColor = System.Drawing.Color.Red
        Me.LabelDNI.Location = New System.Drawing.Point(430, 18)
        Me.LabelDNI.Name = "LabelDNI"
        Me.LabelDNI.Size = New System.Drawing.Size(65, 16)
        Me.LabelDNI.TabIndex = 8
        Me.LabelDNI.Text = "LabelDNI"
        '
        'LabelNyA
        '
        Me.LabelNyA.AutoSize = True
        Me.LabelNyA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LabelNyA.ForeColor = System.Drawing.Color.Red
        Me.LabelNyA.Location = New System.Drawing.Point(183, 20)
        Me.LabelNyA.Name = "LabelNyA"
        Me.LabelNyA.Size = New System.Drawing.Size(68, 16)
        Me.LabelNyA.TabIndex = 8
        Me.LabelNyA.Text = "LabelNyA"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(592, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LDNI.Location = New System.Drawing.Point(350, 21)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(31, 16)
        Me.LDNI.TabIndex = 0
        Me.LDNI.Text = "DNI"
        '
        'LNyACliente
        '
        Me.LNyACliente.AutoSize = True
        Me.LNyACliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LNyACliente.Location = New System.Drawing.Point(11, 18)
        Me.LNyACliente.Name = "LNyACliente"
        Me.LNyACliente.Size = New System.Drawing.Size(120, 16)
        Me.LNyACliente.TabIndex = 0
        Me.LNyACliente.Text = "Nombre y Apellido"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label9.Location = New System.Drawing.Point(429, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Subtotal"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.LabelCUIT)
        Me.GroupBox5.Controls.Add(Me.LabelNombre)
        Me.GroupBox5.Controls.Add(Me.BAgregarVendedor)
        Me.GroupBox5.Controls.Add(Me.LCUIT)
        Me.GroupBox5.Controls.Add(Me.LNyAVendedor)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 67)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(635, 59)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vendedor"
        '
        'LabelCUIT
        '
        Me.LabelCUIT.AutoSize = True
        Me.LabelCUIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LabelCUIT.ForeColor = System.Drawing.Color.Red
        Me.LabelCUIT.Location = New System.Drawing.Point(429, 22)
        Me.LabelCUIT.Name = "LabelCUIT"
        Me.LabelCUIT.Size = New System.Drawing.Size(73, 16)
        Me.LabelCUIT.TabIndex = 7
        Me.LabelCUIT.Text = "LabelCUIT"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LabelNombre.ForeColor = System.Drawing.Color.Red
        Me.LabelNombre.Location = New System.Drawing.Point(168, 26)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(91, 16)
        Me.LabelNombre.TabIndex = 6
        Me.LabelNombre.Text = "LabelNombre"
        '
        'BAgregarVendedor
        '
        Me.BAgregarVendedor.BackgroundImage = CType(resources.GetObject("BAgregarVendedor.BackgroundImage"), System.Drawing.Image)
        Me.BAgregarVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BAgregarVendedor.Location = New System.Drawing.Point(591, 10)
        Me.BAgregarVendedor.Name = "BAgregarVendedor"
        Me.BAgregarVendedor.Size = New System.Drawing.Size(38, 39)
        Me.BAgregarVendedor.TabIndex = 5
        Me.BAgregarVendedor.UseVisualStyleBackColor = True
        '
        'LCUIT
        '
        Me.LCUIT.AutoSize = True
        Me.LCUIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LCUIT.Location = New System.Drawing.Point(349, 22)
        Me.LCUIT.Name = "LCUIT"
        Me.LCUIT.Size = New System.Drawing.Size(39, 16)
        Me.LCUIT.TabIndex = 0
        Me.LCUIT.Text = "CUIT"
        '
        'LNyAVendedor
        '
        Me.LNyAVendedor.AutoSize = True
        Me.LNyAVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LNyAVendedor.Location = New System.Drawing.Point(10, 26)
        Me.LNyAVendedor.Name = "LNyAVendedor"
        Me.LNyAVendedor.Size = New System.Drawing.Size(120, 16)
        Me.LNyAVendedor.TabIndex = 0
        Me.LNyAVendedor.Text = "Nombre y Apellido"
        '
        'DataListaProductos
        '
        Me.DataListaProductos.BackgroundColor = System.Drawing.Color.White
        Me.DataListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataListaProductos.Location = New System.Drawing.Point(114, 314)
        Me.DataListaProductos.Name = "DataListaProductos"
        Me.DataListaProductos.Size = New System.Drawing.Size(445, 150)
        Me.DataListaProductos.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Marca"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tipo"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio"
        Me.Column4.Name = "Column4"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TMarca)
        Me.GroupBox3.Controls.Add(Me.TSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TTipo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 220)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(635, 57)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle"
        '
        'TMarca
        '
        Me.TMarca.Location = New System.Drawing.Point(277, 19)
        Me.TMarca.Name = "TMarca"
        Me.TMarca.Size = New System.Drawing.Size(111, 21)
        Me.TMarca.TabIndex = 11
        '
        'TSubtotal
        '
        Me.TSubtotal.Location = New System.Drawing.Point(506, 18)
        Me.TSubtotal.Name = "TSubtotal"
        Me.TSubtotal.Size = New System.Drawing.Size(111, 21)
        Me.TSubtotal.TabIndex = 4
        '
        'TTipo
        '
        Me.TTipo.Location = New System.Drawing.Point(69, 19)
        Me.TTipo.Name = "TTipo"
        Me.TTipo.Size = New System.Drawing.Size(111, 21)
        Me.TTipo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label4.Location = New System.Drawing.Point(213, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Marca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label5.Location = New System.Drawing.Point(14, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tipo"
        '
        'TTotal
        '
        Me.TTotal.Location = New System.Drawing.Point(265, 505)
        Me.TTotal.Name = "TTotal"
        Me.TTotal.Size = New System.Drawing.Size(156, 20)
        Me.TTotal.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label6.Location = New System.Drawing.Point(191, 509)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Total $"
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.BCancelar.BackgroundImage = Global.Femsport.My.Resources.Resources.if_f_cross_256_282471
        Me.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCancelar.Location = New System.Drawing.Point(607, 493)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(42, 36)
        Me.BCancelar.TabIndex = 23
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BConfirmar
        '
        Me.BConfirmar.BackColor = System.Drawing.SystemColors.Control
        Me.BConfirmar.BackgroundImage = Global.Femsport.My.Resources.Resources.Ok_icon
        Me.BConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BConfirmar.Location = New System.Drawing.Point(548, 493)
        Me.BConfirmar.Name = "BConfirmar"
        Me.BConfirmar.Size = New System.Drawing.Size(44, 36)
        Me.BConfirmar.TabIndex = 22
        Me.BConfirmar.UseVisualStyleBackColor = False
        '
        'BEliminarProducto
        '
        Me.BEliminarProducto.BackColor = System.Drawing.SystemColors.Control
        Me.BEliminarProducto.BackgroundImage = Global.Femsport.My.Resources.Resources.icons8_Clear_Shopping_Cart_481
        Me.BEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BEliminarProducto.Location = New System.Drawing.Point(82, 499)
        Me.BEliminarProducto.Name = "BEliminarProducto"
        Me.BEliminarProducto.Size = New System.Drawing.Size(40, 37)
        Me.BEliminarProducto.TabIndex = 9
        Me.BEliminarProducto.UseVisualStyleBackColor = False
        '
        'BCargarProducto
        '
        Me.BCargarProducto.BackColor = System.Drawing.SystemColors.Control
        Me.BCargarProducto.BackgroundImage = Global.Femsport.My.Resources.Resources.icons8_Buy_48
        Me.BCargarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCargarProducto.Location = New System.Drawing.Point(22, 499)
        Me.BCargarProducto.Name = "BCargarProducto"
        Me.BCargarProducto.Size = New System.Drawing.Size(40, 37)
        Me.BCargarProducto.TabIndex = 7
        Me.BCargarProducto.UseVisualStyleBackColor = False
        '
        'TTipoFactura
        '
        Me.TTipoFactura.Location = New System.Drawing.Point(162, 24)
        Me.TTipoFactura.Name = "TTipoFactura"
        Me.TTipoFactura.Size = New System.Drawing.Size(35, 20)
        Me.TTipoFactura.TabIndex = 5
        '
        'Facturacion
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Femsport.My.Resources.Resources.pink_yellow_gradient_wallpaper_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(656, 558)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BConfirmar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TTotal)
        Me.Controls.Add(Me.BEliminarProducto)
        Me.Controls.Add(Me.BCargarProducto)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataListaProductos)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Facturacion"
        Me.Text = "Facturación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataListaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LNroFact As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TNroFactura As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LNyACliente As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LDNI As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LCUIT As Label
    Friend WithEvents LNyAVendedor As Label
    Friend WithEvents BAgregarVendedor As Button
    Friend WithEvents DataListaProductos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TMarca As TextBox
    Friend WithEvents TSubtotal As TextBox
    Friend WithEvents TTipo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BCargarProducto As Button
    Friend WithEvents BEliminarProducto As Button
    Friend WithEvents TTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents LabelDNI As Label
    Friend WithEvents LabelNyA As Label
    Friend WithEvents LabelCUIT As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents BConfirmar As Button
    Friend WithEvents TTipoFactura As TextBox
End Class
