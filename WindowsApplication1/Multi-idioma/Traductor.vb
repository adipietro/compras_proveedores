Public Class Traductor
    Implements iObservado


    Private Shared vTraductor As Traductor

    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As Traductor
        If vTraductor Is Nothing Then
            vTraductor = New Traductor
            vTraductor.IdiomaSeleccionado = vTraductor.GetIdiomas().Item(0)

        End If
        Return vTraductor
    End Function

    Public Function Traducir(traduccion As String)
        If Not IsNothing(Me.IdiomaSeleccionado) AndAlso Me.IdiomaSeleccionado.diccionario.ContainsKey(traduccion) Then
            Return Me.IdiomaSeleccionado.diccionario(traduccion)
        Else
            Return traduccion
        End If
    End Function


    Private vIdiomaSeleccionado As BE.IdiomaBE
    Public Property IdiomaSeleccionado() As BE.IdiomaBE
        Get
            Return vIdiomaSeleccionado
        End Get
        Set(ByVal value As BE.IdiomaBE)
            If vIdiomaSeleccionado Is Nothing OrElse vIdiomaSeleccionado.nombre <> value.Nombre Then
                vIdiomaSeleccionado = value
                Notificar()
            End If
        End Set
    End Property

    Dim vListaRegistrados As New List(Of iObservador)
    'Dim vIdiomaBLL As New BLL.idiomaBLL

    Public ReadOnly Property Registrados As List(Of iObservador) Implements iObservado.Registrados
        Get
            Return vListaRegistrados
        End Get

    End Property

    Public Sub Notificar() Implements iObservado.Notificar
        For Each vRegistrado As iObservador In vListaRegistrados
            vRegistrado.ActualizarObservador(vRegistrado)
        Next
    End Sub

    Public Sub Registrar(pObservador As iObservador) Implements iObservado.Registrar
        If vListaRegistrados.Count > 0 Then
            For Each vRegistrado As iObservador In vListaRegistrados
                If vRegistrado.ToString = pObservador.ToString Then
                    vListaRegistrados.Remove(vRegistrado)
                    Exit For
                End If
            Next
        End If
        vListaRegistrados.Add(pObservador)
    End Sub

    Public Function GetIdiomas() As List(Of BE.IdiomaBE)
        Dim vLista As New List(Of BE.IdiomaBE)
        For Each vIdioma As BE.IdiomaBE In BLL.idiomaBLL.Listaridiomas
            vLista.Add(vIdioma)
        Next
        Return vLista
    End Function

    Public Sub AltaIdioma(pNombre As String, pDiccionario As Dictionary(Of String, String))
        Dim vIdioma As New BE.IdiomaBE()
        Dim idiomaBLL As New BLL.idiomaBLL
        vIdioma.nombre = pNombre
        vIdioma.diccionario = pDiccionario
        idiomaBLL.Guardar(vIdioma)
    End Sub

    Public Sub BajaIdioma(pIdioma As BE.IdiomaBE)
        Dim idiomabll As New BLL.idiomaBLL
        idiomabll.Eliminar(pIdioma)
    End Sub

    Public Sub ModificacionIdioma(pIdioma As BE.IdiomaBE)
        Dim idiomabll As New BLL.idiomaBLL
        idiomabll.Guardar(pIdioma)
    End Sub



End Class
