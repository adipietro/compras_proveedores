Imports BLL

Public Class DeclararFamilias
    Implements iobservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    'Dim mfamiliaSelec As BLL.FamiliaBLL

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


    ''' <summary>
    ''' Carga en pControl.Tag el texto que tiene pControl al momento de instanciar el Form
    ''' </summary>
    ''' <param name="pControl"></param>
    Public Sub CargarTags(pControl As Control)
        pControl.Tag = pControl.Text

        If pControl.Controls.Count > 0 Then
            For Each mControl As Control In pControl.Controls
                CargarTags(mControl)
            Next
        End If
    End Sub


#Region "Observer"

    Public Sub ActualizarObservador(Optional pObservador As Control = Nothing) Implements iobservador.ActualizarObservador
        For Each mControl As Control In pObservador.Controls
            Try
                mControl.Text = vTraductor.IdiomaSeleccionado.diccionario.Item(mControl.Tag).ToString
            Catch ex As Exception

            Finally
                If mControl.Controls.Count > 0 Then
                    ActualizarObservador(mControl)
                End If
            End Try
        Next
    End Sub

#End Region


#Region "Eventos Form"
    Private Sub Formfamiliaes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gruposPatentes = PatenteBLL.listarTodosGruposPatentes()
        lstGruposPatentes.DataSource = gruposPatentes.ToList
        vTraductor.Registrar(Me)
        ActualizarObservador(Me)
    End Sub
#End Region



    Private Sub lstGruposPatentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGruposPatentes.SelectedIndexChanged
        Dim grupoPatenteSeleccionado = DirectCast(lstGruposPatentes.SelectedItem, BE.GrupoPatenteBE)
        Dim patentesDeGrupoPatente = PatenteBLL.listarPatentesDeGrupoPatente(grupoPatenteSeleccionado)
        Dim todasLasPatentes = PatenteBLL.listarPatentesTotales()
        treePermisos.Nodes.Clear()
        For Each patente In todasLasPatentes
            Dim node = treePermisos.Nodes.Add(patente.nombre)
           
            node.Tag = patente
            node.Checked = patentesDeGrupoPatente.Contains(patente)

            If patente.GetType() = GetType(BE.GrupoPatenteBE) Then
                'node.BackColor = Color.AliceBlue
                node.ForeColor = Color.Blue
                node.Text = node.Text & " (Familia)"

            End If
        Next
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim grupoPatenteSeleccionado = DirectCast(lstGruposPatentes.SelectedItem, BE.GrupoPatenteBE)

        Dim patentes As New HashSet(Of BE.PatenteAbsBE)
        For Each node In treePermisos.Nodes
            If node.Checked Then
                patentes.Add(node.Tag)
            End If
        Next
        PatenteBLL.modificarPatentesHijas(grupoPatenteSeleccionado, patentes)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmAltaFamilia.Show()
    End Sub
End Class

