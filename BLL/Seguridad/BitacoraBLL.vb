Imports BE

Public Class BitacoraBLL

    Public Sub New()

    End Sub


    Public Sub Guardarnuevo(mBitacora As BE.Bitacora)

        DAL.bitacoraDAL.GuardarNuevo(mBitacora)

    End Sub


    Public Shared Function Listarbitacora() As List(Of Bitacora)

        Dim mListaDTO As List(Of BE.Bitacora) = DAL.bitacoraDAL.Listarbitacora

       
        Return mListaDTO
    End Function

End Class
