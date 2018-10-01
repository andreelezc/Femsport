<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIAdministrador
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIAdministrador))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MiPerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarInformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(634, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Image = Global.Femsport.My.Resources.Resources.if_questionssvg_1579793
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(69, 20)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contenido"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.IndexToolStripMenuItem.Text = "&Índice"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SearchToolStripMenuItem.Text = "&Buscar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(173, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiPerfilToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MiPerfilToolStripMenuItem
        '
        Me.MiPerfilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerPerfilToolStripMenuItem, Me.EditarInformacionToolStripMenuItem, Me.ToolStripSeparator1, Me.CerrarSesiónToolStripMenuItem})
        Me.MiPerfilToolStripMenuItem.Image = Global.Femsport.My.Resources.Resources.User_blue256_25016
        Me.MiPerfilToolStripMenuItem.Name = "MiPerfilToolStripMenuItem"
        Me.MiPerfilToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.MiPerfilToolStripMenuItem.Text = "Mi Perfil"
        '
        'VerPerfilToolStripMenuItem
        '
        Me.VerPerfilToolStripMenuItem.Image = Global.Femsport.My.Resources.Resources.if_eye_preview_see_seen_view_392505
        Me.VerPerfilToolStripMenuItem.Name = "VerPerfilToolStripMenuItem"
        Me.VerPerfilToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.VerPerfilToolStripMenuItem.Text = "Ver Perfil"
        '
        'EditarInformacionToolStripMenuItem
        '
        Me.EditarInformacionToolStripMenuItem.Image = Global.Femsport.My.Resources.Resources.if_office_41_8095931
        Me.EditarInformacionToolStripMenuItem.Name = "EditarInformacionToolStripMenuItem"
        Me.EditarInformacionToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EditarInformacionToolStripMenuItem.Text = "Editar Informacion"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(169, 6)
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Image = Global.Femsport.My.Resources.Resources.if_exit_26769371
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerentesToolStripMenuItem, Me.VendedoresToolStripMenuItem, Me.VerTodosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Image = Global.Femsport.My.Resources.Resources.Customers
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'GerentesToolStripMenuItem
        '
        Me.GerentesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.VerListadoToolStripMenuItem})
        Me.GerentesToolStripMenuItem.Name = "GerentesToolStripMenuItem"
        Me.GerentesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.GerentesToolStripMenuItem.Text = "Gerentes"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'VerListadoToolStripMenuItem
        '
        Me.VerListadoToolStripMenuItem.Name = "VerListadoToolStripMenuItem"
        Me.VerListadoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.VerListadoToolStripMenuItem.Text = "Ver Listado"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.VerListadoToolStripMenuItem1})
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.NuevoToolStripMenuItem1.Text = "Nuevo"
        '
        'VerListadoToolStripMenuItem1
        '
        Me.VerListadoToolStripMenuItem1.Name = "VerListadoToolStripMenuItem1"
        Me.VerListadoToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.VerListadoToolStripMenuItem1.Text = "Ver Listado"
        '
        'VerTodosToolStripMenuItem
        '
        Me.VerTodosToolStripMenuItem.Name = "VerTodosToolStripMenuItem"
        Me.VerTodosToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.VerTodosToolStripMenuItem.Text = "Ver todos"
        '
        'MDIAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Femsport.My.Resources.Resources.mdis5001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 461)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIAdministrador"
        Me.Text = "Perfil Administrador"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents HelpMenu As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents MiPerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarInformacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GerentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VerListadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VerTodosToolStripMenuItem As ToolStripMenuItem
End Class
