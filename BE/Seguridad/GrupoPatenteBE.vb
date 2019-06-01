Imports System.Windows.Forms


Public Class GrupoPatenteBE
    Inherits PatenteAbsBE


    Private setPatentes As New HashSet(Of BE.PatenteAbsBE)

    Public Property Patentes() As HashSet(Of BE.PatenteAbsBE)
        Get
            Return setPatentes
        End Get
        Set(ByVal value As HashSet(Of BE.PatenteAbsBE))
            setPatentes = value
        End Set
    End Property

End Class