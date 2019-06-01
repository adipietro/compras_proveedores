Imports DAL
Imports BE


Public Class FormularioBLL

    Public Shared Function ObtenerFormulariosUsuario(usuario As UsuarioBE) As HashSet(Of FormularioBE)
        Return FormularioDAL.ObtenerFormulariosUsuario(usuario)
    End Function

    Public Shared Function ObtenerFormulariosPatente(patente As PatenteBE) As HashSet(Of FormularioBE)
        Return FormularioDAL.ObtenerFormulariosPatente(patente)
    End Function

End Class
