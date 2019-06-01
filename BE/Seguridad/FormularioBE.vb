Public Class FormularioBE
    Inherits ID
    Public Property NombreFormulario As String
    Public Property Menu As String
    Property Acciones As HashSet(Of String)

    Public Function EstaAutorizado(accion As String) As Boolean
        Return Acciones.Contains(accion)
    End Function
End Class
