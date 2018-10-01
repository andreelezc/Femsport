<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarInfoAdministrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarInfoAdministrador))
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TCargo = New System.Windows.Forms.TextBox()
        Me.LCargo = New System.Windows.Forms.Label()
        Me.DateFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.TLocalidad = New System.Windows.Forms.TextBox()
        Me.TProvincia = New System.Windows.Forms.TextBox()
        Me.TPais = New System.Windows.Forms.TextBox()
        Me.TEmail = New System.Windows.Forms.TextBox()
        Me.TDNI = New System.Windows.Forms.TextBox()
        Me.TCUIT = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.LIngreso = New System.Windows.Forms.Label()
        Me.LCuit = New System.Windows.Forms.Label()
        Me.LEmailVendedor = New System.Windows.Forms.Label()
        Me.LFechaNac = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.LLocalidad = New System.Windows.Forms.Label()
        Me.LProvincia = New System.Windows.Forms.Label()
        Me.LPais = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BGuardar
        '
        Me.BGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.BGuardar.Image = Global.Femsport.My.Resources.Resources.if_Confirm_40044
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BGuardar.Location = New System.Drawing.Point(296, 383)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(91, 40)
        Me.BGuardar.TabIndex = 5
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TCargo)
        Me.GroupBox1.Controls.Add(Me.LCargo)
        Me.GroupBox1.Controls.Add(Me.DateFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.DateFechaNac)
        Me.GroupBox1.Controls.Add(Me.TTelefono)
        Me.GroupBox1.Controls.Add(Me.TDireccion)
        Me.GroupBox1.Controls.Add(Me.TLocalidad)
        Me.GroupBox1.Controls.Add(Me.TProvincia)
        Me.GroupBox1.Controls.Add(Me.TPais)
        Me.GroupBox1.Controls.Add(Me.TEmail)
        Me.GroupBox1.Controls.Add(Me.TDNI)
        Me.GroupBox1.Controls.Add(Me.TCUIT)
        Me.GroupBox1.Controls.Add(Me.TApellido)
        Me.GroupBox1.Controls.Add(Me.TNombre)
        Me.GroupBox1.Controls.Add(Me.LIngreso)
        Me.GroupBox1.Controls.Add(Me.LCuit)
        Me.GroupBox1.Controls.Add(Me.LEmailVendedor)
        Me.GroupBox1.Controls.Add(Me.LFechaNac)
        Me.GroupBox1.Controls.Add(Me.LDni)
        Me.GroupBox1.Controls.Add(Me.LApellido)
        Me.GroupBox1.Controls.Add(Me.LTelefono)
        Me.GroupBox1.Controls.Add(Me.LDireccion)
        Me.GroupBox1.Controls.Add(Me.LLocalidad)
        Me.GroupBox1.Controls.Add(Me.LProvincia)
        Me.GroupBox1.Controls.Add(Me.LPais)
        Me.GroupBox1.Controls.Add(Me.LNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(603, 336)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'TCargo
        '
        Me.TCargo.Enabled = False
        Me.TCargo.Location = New System.Drawing.Point(93, 275)
        Me.TCargo.Name = "TCargo"
        Me.TCargo.Size = New System.Drawing.Size(199, 20)
        Me.TCargo.TabIndex = 6
        Me.TCargo.Text = "Administrador"
        '
        'LCargo
        '
        Me.LCargo.AutoSize = True
        Me.LCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LCargo.Location = New System.Drawing.Point(20, 279)
        Me.LCargo.Name = "LCargo"
        Me.LCargo.Size = New System.Drawing.Size(45, 16)
        Me.LCargo.TabIndex = 4
        Me.LCargo.Text = "Cargo"
        '
        'DateFechaIngreso
        '
        Me.DateFechaIngreso.Location = New System.Drawing.Point(444, 230)
        Me.DateFechaIngreso.Name = "DateFechaIngreso"
        Me.DateFechaIngreso.Size = New System.Drawing.Size(139, 20)
        Me.DateFechaIngreso.TabIndex = 2
        '
        'DateFechaNac
        '
        Me.DateFechaNac.Location = New System.Drawing.Point(162, 183)
        Me.DateFechaNac.Name = "DateFechaNac"
        Me.DateFechaNac.Size = New System.Drawing.Size(130, 20)
        Me.DateFechaNac.TabIndex = 2
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(429, 182)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(154, 20)
        Me.TTelefono.TabIndex = 1
        '
        'TDireccion
        '
        Me.TDireccion.Location = New System.Drawing.Point(429, 140)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(154, 20)
        Me.TDireccion.TabIndex = 1
        '
        'TLocalidad
        '
        Me.TLocalidad.Location = New System.Drawing.Point(429, 103)
        Me.TLocalidad.Name = "TLocalidad"
        Me.TLocalidad.Size = New System.Drawing.Size(154, 20)
        Me.TLocalidad.TabIndex = 1
        '
        'TProvincia
        '
        Me.TProvincia.Location = New System.Drawing.Point(429, 68)
        Me.TProvincia.Name = "TProvincia"
        Me.TProvincia.Size = New System.Drawing.Size(154, 20)
        Me.TProvincia.TabIndex = 1
        '
        'TPais
        '
        Me.TPais.Location = New System.Drawing.Point(429, 31)
        Me.TPais.Name = "TPais"
        Me.TPais.Size = New System.Drawing.Size(154, 20)
        Me.TPais.TabIndex = 1
        '
        'TEmail
        '
        Me.TEmail.Location = New System.Drawing.Point(93, 226)
        Me.TEmail.Name = "TEmail"
        Me.TEmail.Size = New System.Drawing.Size(199, 20)
        Me.TEmail.TabIndex = 1
        '
        'TDNI
        '
        Me.TDNI.Location = New System.Drawing.Point(93, 141)
        Me.TDNI.Name = "TDNI"
        Me.TDNI.Size = New System.Drawing.Size(199, 20)
        Me.TDNI.TabIndex = 1
        '
        'TCUIT
        '
        Me.TCUIT.Location = New System.Drawing.Point(93, 103)
        Me.TCUIT.Name = "TCUIT"
        Me.TCUIT.Size = New System.Drawing.Size(199, 20)
        Me.TCUIT.TabIndex = 1
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(93, 68)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(199, 20)
        Me.TApellido.TabIndex = 1
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(93, 31)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(199, 20)
        Me.TNombre.TabIndex = 1
        '
        'LIngreso
        '
        Me.LIngreso.AutoSize = True
        Me.LIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LIngreso.Location = New System.Drawing.Point(325, 230)
        Me.LIngreso.Name = "LIngreso"
        Me.LIngreso.Size = New System.Drawing.Size(113, 16)
        Me.LIngreso.TabIndex = 0
        Me.LIngreso.Text = "Fecha de Ingreso"
        '
        'LCuit
        '
        Me.LCuit.AutoSize = True
        Me.LCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LCuit.Location = New System.Drawing.Point(20, 107)
        Me.LCuit.Name = "LCuit"
        Me.LCuit.Size = New System.Drawing.Size(39, 16)
        Me.LCuit.TabIndex = 0
        Me.LCuit.Text = "CUIT"
        '
        'LEmailVendedor
        '
        Me.LEmailVendedor.AutoSize = True
        Me.LEmailVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LEmailVendedor.Location = New System.Drawing.Point(20, 230)
        Me.LEmailVendedor.Name = "LEmailVendedor"
        Me.LEmailVendedor.Size = New System.Drawing.Size(42, 16)
        Me.LEmailVendedor.TabIndex = 0
        Me.LEmailVendedor.Text = "Email"
        '
        'LFechaNac
        '
        Me.LFechaNac.AutoSize = True
        Me.LFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LFechaNac.Location = New System.Drawing.Point(20, 183)
        Me.LFechaNac.Name = "LFechaNac"
        Me.LFechaNac.Size = New System.Drawing.Size(136, 16)
        Me.LFechaNac.TabIndex = 0
        Me.LFechaNac.Text = "Fecha de Nacimiento"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LDni.Location = New System.Drawing.Point(20, 145)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(31, 16)
        Me.LDni.TabIndex = 0
        Me.LDni.Text = "DNI"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LApellido.Location = New System.Drawing.Point(20, 68)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(58, 16)
        Me.LApellido.TabIndex = 0
        Me.LApellido.Text = "Apellido"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LTelefono.Location = New System.Drawing.Point(325, 183)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(62, 16)
        Me.LTelefono.TabIndex = 0
        Me.LTelefono.Text = "Teléfono"
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LDireccion.Location = New System.Drawing.Point(325, 141)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(65, 16)
        Me.LDireccion.TabIndex = 0
        Me.LDireccion.Text = "Dirección"
        '
        'LLocalidad
        '
        Me.LLocalidad.AutoSize = True
        Me.LLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LLocalidad.Location = New System.Drawing.Point(325, 104)
        Me.LLocalidad.Name = "LLocalidad"
        Me.LLocalidad.Size = New System.Drawing.Size(68, 16)
        Me.LLocalidad.TabIndex = 0
        Me.LLocalidad.Text = "Localidad"
        '
        'LProvincia
        '
        Me.LProvincia.AutoSize = True
        Me.LProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LProvincia.Location = New System.Drawing.Point(325, 68)
        Me.LProvincia.Name = "LProvincia"
        Me.LProvincia.Size = New System.Drawing.Size(64, 16)
        Me.LProvincia.TabIndex = 0
        Me.LProvincia.Text = "Provincia"
        '
        'LPais
        '
        Me.LPais.AutoSize = True
        Me.LPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LPais.Location = New System.Drawing.Point(325, 31)
        Me.LPais.Name = "LPais"
        Me.LPais.Size = New System.Drawing.Size(35, 16)
        Me.LPais.TabIndex = 0
        Me.LPais.Text = "Pais"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LNombre.Location = New System.Drawing.Point(20, 31)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(57, 16)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre"
        '
        'EditarInfoAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Femsport.My.Resources.Resources.pink_yellow_gradient_wallpaper_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(666, 447)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditarInfoAdministrador"
        Me.Text = "Editar Información de Perfil"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BGuardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateFechaIngreso As DateTimePicker
    Friend WithEvents DateFechaNac As DateTimePicker
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents TLocalidad As TextBox
    Friend WithEvents TProvincia As TextBox
    Friend WithEvents TPais As TextBox
    Friend WithEvents TEmail As TextBox
    Friend WithEvents TDNI As TextBox
    Friend WithEvents TCUIT As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents LIngreso As Label
    Friend WithEvents LCuit As Label
    Friend WithEvents LEmailVendedor As Label
    Friend WithEvents LFechaNac As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LDireccion As Label
    Friend WithEvents LLocalidad As Label
    Friend WithEvents LProvincia As Label
    Friend WithEvents LPais As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LCargo As Label
    Friend WithEvents TCargo As TextBox
End Class
