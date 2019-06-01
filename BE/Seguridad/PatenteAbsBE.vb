Imports System.Windows.Forms

Public MustInherit Class PatenteAbsBE
    Inherits ID

    Public Property nombre As String


    Public Overrides Function ToString() As String
        Return Me.nombre
    End Function

End Class
