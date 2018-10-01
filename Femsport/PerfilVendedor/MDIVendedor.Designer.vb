<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIVendedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIVendedor))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarInformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListadoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsMenu, Me.FileMenu, Me.ViewMenu, Me.EditMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerPerfilToolStripMenuItem, Me.EditarInformaciónToolStripMenuItem, Me.ToolStripSeparator1, Me.CerrarSesiónToolStripMenuItem})
        Me.ToolsMenu.Image = Global.Femsport.My.Resources.Resources.User_blue256_25016
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(79, 20)
        Me.ToolsMenu.Text = "Mi Perfil"
        '
        'VerPerfilToolStripMenuItem
        '
        Me.VerPerfilToolStripMenuItem.Image = Global.Femsport.My.Resources.Resources.if_eye_preview_see_seen_view_392505
        Me.VerPerfilToolStripMenuItem.Name = "VerPerfilToolStripMenuItem"
        Me.VerPerfilToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.VerPerfilToolStripMenuItem.Text = "Ver Perfil"
        '
        'EditarInformaciónToolStripMenuItem
        '
        Me.EditarInformaciónToolStripMenuItem.Image = Global.Femsport.My.Resources.Resources.if_office_41_8095931
        Me.EditarInformaciónToolStripMenuItem.Name = "EditarInformaciónToolStripMenuItem"
        Me.EditarInformaciónToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EditarInformaciónToolStripMenuItem.Text = "Editar Información"
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
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.NuevaToolStripMenuItem, Me.VerListadoToolStripMenuItem})
        Me.FileMenu.Image = Global.Femsport.My.Resources.Resources.if_6_3319634
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(69, 20)
        Me.FileMenu.Text = "Ventas"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(128, 6)
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'VerListadoToolStripMenuItem
        '
        Me.VerListadoToolStripMenuItem.Name = "VerListadoToolStripMenuItem"
        Me.VerListadoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.VerListadoToolStripMenuItem.Text = "Ver Listado"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerListadoToolStripMenuItem1})
        Me.ViewMenu.Image = Global.Femsport.My.Resources.Resources.if_05_Tag_290145
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(89, 20)
        Me.ViewMenu.Text = "Productos"
        '
        'VerListadoToolStripMenuItem1
        '
        Me.VerListadoToolStripMenuItem1.Name = "VerListadoToolStripMenuItem1"
        Me.VerListadoToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.VerListadoToolStripMenuItem1.Text = "Ver Listado"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.VerListadoToolStripMenuItem2})
        Me.EditMenu.Image = Global.Femsport.My.Resources.Resources.if_icon_ios7_people_211793
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(77, 20)
        Me.EditMenu.Text = "Clientes"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'VerListadoToolStripMenuItem2
        '
        Me.VerListadoToolStripMenuItem2.Name = "VerListadoToolStripMenuItem2"
        Me.VerListadoToolStripMenuItem2.Size = New System.Drawing.Size(131, 22)
        Me.VerListadoToolStripMenuItem2.Text = "Ver Listado"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Image = Global.Femsport.My.Resources.Resources.if_questionssvg_1579793
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(69, 20)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
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
        'MDIVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Femsport.My.Resources.Resources.mdis5002
        Me.ClientSize = New System.Drawing.Size(634, 461)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIVendedor"
        Me.Text = "Perfil Vendedor"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarInformaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditMenu As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListadoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
