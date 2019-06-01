Public Class EvaluaciónProveedorBE

    Inherits ID

    Public Property Proveedor As BE.ProveedorBE
    Public Property CalificacionTiempos As Integer
    Public Property CalificacionAtencion As Integer
    Public Property CalificacionComunicacion As Integer
    Public Property CalificacionCalidad As Integer
    Public Property Fecha As String


    Public Property Promedio() As Double
        Get
            Dim prom = ((CalificacionTiempos + CalificacionComunicacion + CalificacionCalidad + CalificacionAtencion) / 4)
            Return prom
        End Get
        Set(ByVal value As Double)

        End Set
    End Property


    Sub New()

    End Sub

End Class
