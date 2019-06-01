Public Class IdiomaBE
    Inherits ID
    Public Property nombre As String


    Public Property diccionario As Dictionary(Of String, String)

    Public Overrides Function ToString() As String
        Return Me.nombre
    End Function


End Class
