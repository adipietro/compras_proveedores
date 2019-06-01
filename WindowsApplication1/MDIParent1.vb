Imports System.Windows.Forms
Imports System.Reflection
Imports BLL

Public Class MDIParent1

    Implements iObservador

    Dim vTraductor As Traductor = Traductor.GetInstance

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each mControl As Control In Me.Controls
            Try
                CargarTags(mControl)
            Catch ex As Exception

            End Try
        Next
    End Sub

    Public Sub CargarTags(pControl As Control)
        pControl.Tag = pControl.Text

        If pControl.Controls.Count > 0 Then
            For Each mControl As Control In pControl.Controls
                CargarTags(mControl)
            Next
        End If
    End Sub

    Private Sub CargarIdiomas()
        For Each Idioma As BE.IdiomaBE In BLL.idiomaBLL.Listaridiomas
            ComboBox1.Items.Add(Idioma)
        Next
    End Sub

    Public Sub TraducirMenuItem(pItem As ToolStripMenuItem)
        pItem.Text = vTraductor.IdiomaSeleccionado.diccionario.Item(pItem.Tag.Texto).ToString

        If pItem.HasDropDownItems Then
            For Each mItem As ToolStripMenuItem In pItem.DropDownItems
                TraducirMenuItem(mItem)
            Next
        End If
    End Sub

    Public Sub ActualizarObservador(Optional pControl As Control = Nothing) Implements iObservador.ActualizarObservador
        For Each mControl As Control In pControl.Controls
            Try
                If Not TypeOf mControl Is MenuStrip Then
                    mControl.Text = vTraductor.IdiomaSeleccionado.diccionario.Item(mControl.Tag).ToString
                Else
                    For Each mItem As ToolStripMenuItem In CType(mControl, MenuStrip).Items
                        TraducirMenuItem(mItem)
                    Next
                End If
            Catch ex As Exception

            Finally
                If mControl.Controls.Count > 0 Then
                    ActualizarObservador(mControl)
                End If
            End Try
        Next
    End Sub


    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub

#Region "ToolStripMenuItem"

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
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
    Private m_ChildFormNumber As Integer

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

#End Region


    Public Property UsuarioActivo As BE.UsuarioBE

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim mPermisoComp As New BLL.GrupoPatenteBLL
        Dim frm As New frmLogin
        frm.StartPosition = FormStartPosition.CenterScreen

        If frm.ShowDialog = DialogResult.OK Then
            frm.Close()
            frm.Dispose()

            MostrarEnMenuStrip(MenuStrip, Me.UsuarioActivo, Me)

            'For Each mItem As ToolStripMenuItem In MenuStrip.Items
            '    CargarTagsMenu(mItem)
            'Next

            CargarIdiomas()
            ComboBox1.SelectedItem = ComboBox1.Items(0)

            vTraductor.Registrar(Me)
            ActualizarObservador(Me)

        End If
    End Sub

    Public Sub MostrarEnMenuStrip(MenuStrip As MenuStrip, usuario As BE.UsuarioBE, pFormulario As Form)

        Dim formulariosUsuario = FormularioBLL.ObtenerFormulariosUsuario(usuario)

        Dim menues As New HashSet(Of String)

        For Each frm In formulariosUsuario
            menues.Add(frm.Menu)
        Next

        '------------------------

        For Each menu_individual In menues
            Dim mMenuItem As New ToolStripMenuItem()

            mMenuItem.Name = menu_individual
            'mMenuItem.Tag = patenteHoja.formulario

            MenuStrip.Items.Add(mMenuItem)
            MenuStrip.Items.Item(mMenuItem.Name).Text = menu_individual

            For Each frm In formulariosUsuario
                If frm.Menu = menu_individual Then
                    Dim subMenuItem As New ToolStripMenuItem
                    subMenuItem.Name = frm.NombreFormulario

                    subMenuItem.Text = frm.NombreFormulario
                    subMenuItem.Tag = frm.NombreFormulario
                    mMenuItem.DropDownItems.Add(subMenuItem)
                    AddHandler subMenuItem.Click, AddressOf Event_Menu_Click
                End If
            Next



            '            For Each patenteHoja In patentesHojasUsuario
            '                If patenteHoja.menu = menu_individual Then
            '                    Dim subMenuItem As New ToolStripMenuItem
            '                    subMenuItem.Name = patenteHoja.nombre
            '                    subMenuItem.Text = patenteHoja.nombre
            '                    subMenuItem.Tag = patenteHoja.formulario
            '                    mMenuItem.DropDownItems.Add(subMenuItem)
            '                    AddHandler subMenuItem.Click, AddressOf Event_Menu_Click
            '                End If
            '            Next
        Next
    End Sub



    Public Sub Event_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mMenuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Event_Click(mMenuItem)
    End Sub


    Private Sub Event_Click(pMenuItem As ToolStripItem)
        Dim mFormName As String = DirectCast(pMenuItem.Tag, String)
        Dim mAssembly As Assembly = Assembly.GetEntryAssembly
        Dim mType As Type = mAssembly.GetType(mFormName)
        Dim mForm = Activator.CreateInstance(mType)
        mForm.ShowDialog()
    End Sub



#Region "Menu"
    Private Sub mnuAlta_Click(sender As Object, e As EventArgs)
        Dim frm As New frmAltaUsuarios
        frm.StartPosition = FormStartPosition.CenterParent

        frm.Show()

    End Sub
    Private Sub mnuAltaProducto_Click(sender As Object, e As EventArgs)
        Dim frm As New frmProducto
        frm.StartPosition = FormStartPosition.CenterParent

        frm.Show()
    End Sub

    Private Sub mnuAltaProveedor_Click(sender As Object, e As EventArgs)
        Dim frm As New frmProveedor
        frm.StartPosition = FormStartPosition.CenterParent

        frm.Show()
    End Sub


    Private Sub ModificarIdiomasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmIdioma As New frmSeleccionIdioma
        frmIdioma.StartPosition = FormStartPosition.CenterParent

        frmIdioma.Show()

    End Sub

    Private Sub AltaNuevoIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmIdioma
        frm.StartPosition = FormStartPosition.CenterParent

        frm.Show()
    End Sub

    Private Sub SeleccionarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New WindowsApplication1.Usuarios
        frm.StartPosition = FormStartPosition.CenterParent

        frm.Show()
    End Sub


#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vTraductor.IdiomaSeleccionado = ComboBox1.SelectedItem
        MsgBox("Se seleccionó nuevo idioma")

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
