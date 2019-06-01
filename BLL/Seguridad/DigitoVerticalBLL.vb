Imports DAL
Public Class DigitoVerticalBLL

    Public Shared Sub GuardarNuevo(pTabla As String, pDigito As String)
        digitoverticalDAL.GuardarDigito(pTabla, pDigito)
    End Sub


    Public Shared Sub ModificarDigito(pTabla As String, pDigito As String)
        digitoverticalDAL.ModificarDigito(pTabla, pDigito)
    End Sub


    Public Shared Function ObtenerDigito(pTabla As String) As String
        Return digitoverticalDAL.Obtenerdigitovertical(pTabla)
    End Function

End Class