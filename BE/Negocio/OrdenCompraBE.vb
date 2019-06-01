Public Class OrdenCompraBE
    Inherits ID

    Public Property Fecha As DateTime
    Public Property Proveedor As BE.ProveedorBE
    Public Property Area As BE.AreaBE
    Public Property Importe As Double
    Public Property dvh As String
    Public Property ltsRegistros As List(Of BE.RegistroCompraBE)


    Sub New()


    End Sub

End Class
