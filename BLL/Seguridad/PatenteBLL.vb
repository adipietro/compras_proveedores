Imports DAL
Imports System.Windows.Forms

Public Class PatenteBLL


    Public Shared Function listarPatentesTotales() As HashSet(Of BE.PatenteAbsBE)
        Return PatenteDAL.listarPatentesTotales()
    End Function

    Public Shared Function listarPatentesUsuario(usuarioSeleccionado As BE.UsuarioBE) As HashSet(Of BE.PatenteAbsBE)
        Return PatenteDAL.listarPatentesUsuario(usuarioSeleccionado)
    End Function


    Public Shared Function agregarPatenteAUsuario(usuario As BE.UsuarioBE, patente As BE.PatenteAbsBE) As Boolean
        Return PatenteDAL.agregarPatenteAUsuario(usuario, patente)
    End Function


    Public Shared Function removerPatenteAUsuario(usuarioSeleccionado As BE.UsuarioBE, patenteUsuario As BE.PatenteAbsBE) As Boolean
        Return PatenteDAL.removerPatenteAUsuario(usuarioSeleccionado, patenteUsuario)
    End Function

    Public Shared Function altaDePatente(nombre_patente As String, formulario As String, nombre_menu As String) As Boolean
        Return PatenteDAL.altaDePatente(nombre_patente, formulario, nombre_menu)
    End Function

    Public Shared Function listarTodosGruposPatentes() As HashSet(Of BE.GrupoPatenteBE)
        Return PatenteDAL.listarTodosGruposPatentes()
    End Function

    Public Shared Function listarPatentesDeGrupoPatente(grupo_patente As BE.GrupoPatenteBE) As HashSet(Of BE.PatenteAbsBE)
        Return PatenteDAL.listarPatentesDeGrupoPatente(grupo_patente)
    End Function

    Public Shared Sub modificarPatentesHijas(patente_padre As BE.PatenteAbsBE, patentes_hijas As HashSet(Of BE.PatenteAbsBE))
        PatenteDAL.modificarPatentesHijas(patente_padre, patentes_hijas)
    End Sub

    Public Shared Sub altaDeGrupoPatente(nombre_patente As String)
        PatenteDAL.altaDeGrupoPatente(nombre_patente)
    End Sub

End Class
