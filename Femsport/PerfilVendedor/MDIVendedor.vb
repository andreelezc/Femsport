﻿Imports System.Windows.Forms

Public Class MDIVendedor

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) 
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) 
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub FileMenu_Click(sender As Object, e As EventArgs) Handles FileMenu.Click

    End Sub

    Private Sub EditMenu_Click(sender As Object, e As EventArgs) Handles EditMenu.Click

    End Sub

    Private Sub EditarInformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ToolStripSeparator4_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator4.Click

    End Sub

    Private Sub MDIVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VerPerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPerfilToolStripMenuItem.Click
        VerPerfilVendedor.Show()
    End Sub

    Private Sub EditarInformaciónToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EditarInformaciónToolStripMenuItem.Click
        EditarInfoVendedor.Show()
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem.Click
        Facturacion.Show()
    End Sub

    Private Sub VerListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListadoToolStripMenuItem.Click
        ListaVentas.Show()
    End Sub

    Private Sub ViewMenu_Click(sender As Object, e As EventArgs) Handles ViewMenu.Click

    End Sub

    Private Sub VerListadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerListadoToolStripMenuItem1.Click
        GestionProductos.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        AltaCliente_V_.Show()
    End Sub

    Private Sub VerListadoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VerListadoToolStripMenuItem2.Click
        GestionClientes_V_.Show()
    End Sub
End Class
