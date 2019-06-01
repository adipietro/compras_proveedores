Imports System.Data.SqlClient
Imports BE


Public Class ProductoDAL

    Public Shared Function CargarBE(ProductoBE As ProductoBE, pRow As DataRow) As ProductoBE
        ProductoBE.ID = pRow("Id_Producto")
        ProductoBE.Nombre = pRow("Producto")
        'Dim categorias = New CategoríaProductoBE
        ProductoBE.Categoría = New CategoríaProductoBE
        ProductoBE.Categoría.ID = pRow("Categoria")
        ProductoBE.Categoría.NombreCategoria = pRow("Nombre")
        'categorias.ID = pRow("Categoria")
        Return ProductoBE
    End Function

    Public Shared Function CargarBEobtenerProducto(ProductoBE As ProductoBE, pRow As DataRow) As ProductoBE
        ProductoBE.ID = pRow("Id_Producto")
        ProductoBE.Nombre = pRow("Producto")

        Return ProductoBE
    End Function

    Public Shared Function ObtenerProducto(producto As String) As ProductoBE
        Dim ProductoBE As New ProductoBE
        Try

            Dim mCommand As String = "SELECT * FROM producto WHERE Producto = '" & producto & "'"
            Dim mDataSet As DataSet = Conexion.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                ProductoBE = CargarBEobtenerProducto(ProductoBE, mDataSet.Tables(0).Rows(0))
                Return ProductoBE
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - ProductoDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Sub GuardarNuevo(ProductoBE As BE.ProductoBE)
        Dim mCommand As String = ""


        mCommand = "INSERT INTO Producto (Producto, Categoria) " &
                    "VALUES ('" & ProductoBE.Nombre & "','" & ProductoBE.Categoría.ID & "'); SELECT @@Identity"

        Try
            Conexion.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - ProductoDAL")
            MsgBox(ex.Message)
        End Try


    End Sub


    Public Shared Sub GuardarModificacion(ProductoBE As BE.ProductoBE)
        Dim mCommand As String = String.Empty

        mCommand = "UPDATE Producto SET Producto = '" & ProductoBE.Nombre & "' WHERE Id_Producto = " & ProductoBE.ID

        Try
            Conexion.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - ProductoDAL")
            MsgBox(ex.Message)
        End Try


    End Sub


    'Public Shared Sub Eliminar(ProductoBE As BE.ProductoBE)
    '    Dim mCommand As String = "DELETE FROM Producto WHERE Id_Producto = " & ProductoBE.ID

    '    Try
    '        Conexion.ExecuteNonQuery(mCommand)
    '    Catch ex As Exception
    '        MsgBox("Error - Eliminacion - ProductoDAL")
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub


    Public Shared Function Listar() As List(Of BE.ProductoBE)
        Dim mLista As New List(Of BE.ProductoBE)
        Dim mCommand As String = String.Empty
        Dim mDataSet As DataSet

        Try
            mCommand = "SELECT p.*, c.Nombre FROM Categoria c inner join Producto p on c.id_Categoria= p.Categoria"
            mDataSet = Conexion.ExecuteDataSet(mCommand)


            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim MProducto As New ProductoBE

                    MProducto = CargarBE(MProducto, mRow)

                    mLista.Add(MProducto)
                Next

                Return mLista
            Else
                Return New List(Of ProductoBE)
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - ProductoDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class


