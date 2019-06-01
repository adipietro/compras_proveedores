Imports System.Data.SqlClient
Imports BE


Public Class OrdenCompraDAL

    Public Shared Function CargarBE(ocBE As OrdenCompraBE, pRow As DataRow) As OrdenCompraBE
        ocBE.ID = pRow("Id_OC")
        ocBE.Fecha = pRow("Fecha")

        ocBE.Proveedor = New ProveedorBE
        ocBE.Proveedor.ID = pRow("Proveedor")
        ocBE.Proveedor.Nombre = pRow("NombreProveedor")
        ocBE.Area = New AreaBE
        ocBE.Area.ID = pRow("Area")
        ocBE.Area.Nombre = pRow("NombreArea")

        ocBE.Importe = pRow("Importe")
        ocBE.dvh = pRow("dvh")

        Return ocBE
    End Function

    Public Shared Function CargarBEporOC(ocBE As OrdenCompraBE, pRow As DataRow) As OrdenCompraBE
        ocBE.ID = pRow("Id_OC")

        Return ocBE
    End Function


    Public Shared Function ObtenerOC(ID As Integer) As OrdenCompraBE
        Dim ocBE As New OrdenCompraBE
        Dim mCommand As String = "SELECT * FROM OrdenCompra WHERE Id_OC = @pID"
        Dim sqlParams() As SqlParameter = New SqlParameter() _
            {
                 New SqlParameter("@pID", ID)
            }

        Try
            Dim mDataSet As DataSet = Conexion.ExecuteDataSet(mCommand, sqlParams)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                ocBE = CargarBE(ocBE, mDataSet.Tables(0).Rows(0))
                Return ocBE
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - ocDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Sub GuardarNuevo(ocbe As BE.OrdenCompraBE)

        Dim mCommand As String = ""
        mCommand = "INSERT INTO OrdenCompra (Fecha, Proveedor, Area,  Importe,  dvh)" &
                    "VALUES ('" & ocbe.Fecha & "','" & ocbe.Proveedor.ID & "','" & ocbe.Area.ID & "','" & ocbe.Importe & "','" & ocbe.dvh & "')"
        Try

            Conexion.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - ocDAL")
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Shared Function ObtenerUltimaOC() As OrdenCompraBE
        Dim ocBE As New OrdenCompraBE
        Dim mCommand As String = "select Id_OC from OrdenCompra WHERE Id_OC = (SELECT MAX(id_oc) FROM OrdenCompra )"

        Try
            Dim mDataSet As DataSet = Conexion.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then

                ocBE = CargarBEporOC(ocBE, mDataSet.Tables(0).Rows(0))
                Return ocBE
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - ocDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    '  Public Shared Sub GuardarModificacion(ocBE As BE.OrdenCompraBE)
    '
    '
    '      Dim mCommand As String = "UPDATE Pedido SET " &
    '                          "FechaPedido= '" & ocBE.Fecha &
    '                          "', Proveedor= '" & ocBE.Proveedor &
    '                          "', Area = '" & ocBE.Area &
    '                          "', Importe = '" & ocBE.Importe &
    '                          "', dvh = '" & ocBE.dvh &
    '                        "' WHERE Id_Pedido = " & ocBE.ID
    '
    '      Try
    '          Conexion.ExecuteNonQuery(mCommand)
    '      Catch ex As Exception
    '          MsgBox("Error - Modificacion - PedidoDAL")
    '          MsgBox(ex.Message)
    '      End Try
    '
    '
    '  End Sub


    Public Shared Sub Eliminar(ocBE As BE.OrdenCompraBE)
        Dim mCommand As String = "DELETE FROM OrdenCompra WHERE Id_OC = " & ocBE.ID

        Try
            Conexion.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - ocDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Shared Function Listar() As List(Of BE.OrdenCompraBE)
        Dim mLista As New List(Of BE.OrdenCompraBE)
        Dim mCommand As String = String.Empty
        Dim mDataSet As DataSet

        Try

            mCommand = "SELECT o.*, p.NombreProveedor, a.NombreArea FROM OrdenCompra o inner join proveedor p ON O.Proveedor = O.Proveedor inner join Area a on a.Id_Area = o.Area"
            mDataSet = Conexion.ExecuteDataSet(mCommand)


            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim ocBE As New OrdenCompraBE

                    ocBE = CargarBE(ocBE, mRow)

                    mLista.Add(ocBE)
                Next

                Return mLista
            Else
                Return New List(Of OrdenCompraBE)
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - ocDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class




