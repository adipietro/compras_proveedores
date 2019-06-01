Imports DAL
Imports BE

Public Class ProductoBLL

    Public Sub Guardar(mBE As BE.ProductoBE)
        If mBE.ID = 0 Then
            ProductoDAL.GuardarNuevo(mBE)
        Else
            ProductoDAL.GuardarModificacion(mBE)
        End If
    End Sub

    'Public Sub Eliminar(unProducto As BE.ProductoBE)
    '    ProductoDAL.Eliminar(unProducto)
    'End Sub

    Public Function Listar() As List(Of BE.ProductoBE)
        Dim mLista As List(Of BE.ProductoBE) = ProductoDAL.Listar
        'Dim prod As New BE.ProductoBE
        'mLista.Add(prod)
        Return mLista
    End Function

    Public Function ObtenerProducto(Producto As String)
        Dim prod As BE.ProductoBE = ProductoDAL.ObtenerProducto(Producto)
        Return prod
    End Function

End Class
