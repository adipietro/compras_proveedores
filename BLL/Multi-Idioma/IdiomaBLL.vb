Imports BE
Imports DAL

Public Class idiomaBLL



    Public Sub Guardar(mBE As BE.IdiomaBE)

        IdiomaDAL.GuardarNuevo(mBE)

    End Sub

    Public Sub GuardarModificacion(mBE As BE.IdiomaBE)
        IdiomaDAL.GuardarModificacion(mBE)

    End Sub


    Public Sub Eliminar(mBE As BE.IdiomaBE)
        IdiomaDAL.Eliminar(mBE)
    End Sub


    Public Shared Function Listaridiomas() As List(Of IdiomaBE)
        Dim mListaBE As List(Of BE.IdiomaBE) = IdiomaDAL.ListarIdiomas

        Return mListaBE
    End Function


End Class
