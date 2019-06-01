

Public Class digitoverticalDAL

    Public Shared Function VerificarConexion() As Boolean
        Dim mValido As Boolean = True
        Dim mTabla As String
        Dim mStringDVs As String
        Dim mDataSetDVV As DataSet
        Dim mDataSetTabla As DataSet
        Dim mCommandDV As String
        Dim mCommandObtener As String = "select * from digitovertical where fecha not like '" & Date.Now.Date.ToString("yyyy-MM-dd") & "'"

        Try
            mDataSetDVV = Conexion.ExecuteDataSet(mCommandObtener)

            If Not IsNothing(mDataSetDVV) And mDataSetDVV.Tables.Count > 0 And mDataSetDVV.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSetDVV.Tables(0).Rows
                    mStringDVs = ""

                    mTabla = mRow("Nombretabla")

                    mCommandDV = "select * from " & mTabla

                    mDataSetTabla = Conexion.ExecuteDataSet(mCommandDV)

                    If Not IsNothing(mDataSetTabla) And mDataSetTabla.Tables.Count > 0 Then
                        If mDataSetTabla.Tables(0).Rows.Count > 0 Then
                            For Each mRowTabla As DataRow In mDataSetTabla.Tables(0).Rows
                                mStringDVs &= mRowTabla("DVH")
                            Next

                            mValido = BE.CalcularDHbe.VerificarDV(mStringDVs, mRow("digito"))

                            ActualizarFecha(mTabla)

                            If Not mValido Then
                                Exit For
                            End If
                        End If
                    Else
                        ' MsgBox("Error - ControladorDVV - TablaDV")
                        mValido = False
                        Exit For
                    End If
                Next
            Else
                'MsgBox("Error - ControladorDVV - TablaDVV")
                mValido = False
            End If

            Return mValido
        Catch ex As Exception
            'MsgBox("Error - ControladorDVV - Verificar")
            'MsgBox(ex.Message)

            Return False
        End Try
    End Function


    ''' <summary>
    ''' Actualiza la fecha de ultima verificacion de un registro de la tabla DVV de Conexion
    ''' </summary>
    ''' <param name="pTabla">Nombre de la tabla a la que corresponde el registro del que se quiere actualizar la fecha de ultima verificacion</param>
    Private Shared Sub ActualizarFecha(pTabla As String)
        Dim mCommand As String = "update digitovertical set fecha = '" & Date.Now.Date.ToString("yyyy-MM-dd") & "' where nombretabla like '" & pTabla & "'"

        Try
            Conexion.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - ControladorDVV - Cambio fecha")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Calcula el DVV para una tabla de Conexion
    ''' </summary>
    ''' <param name="pTabla">Nombre de la tabla de la que se quiere calcular el DVV</param>
    ''' <returns>DVV calculado</returns>
    Public Shared Function CalcularDVV(pTabla As String)
        Dim mStringDVs As String = ""
        Dim mCommand As String = "select DVH from " & pTabla
        Dim mDataSet As DataSet

        Try
            mDataSet = Conexion.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    mStringDVs &= mRow("DVH")
                Next
            End If

            Return BE.CalcularDHbe.CalcularDV(mStringDVs)
        Catch ex As Exception
            MsgBox("Error - ControladorDVV - CalcularDVV")
            MsgBox(ex.Message)

            Return Nothing
        End Try
    End Function


    Public Shared Sub GuardarDigito(pTabla As String, pDigito As String)
        Dim mCommand As String = "insert into digitovertical(nombretabla, digito, fecha) values('" & pTabla & "', '" & pDigito & "', '" & Date.Now.Date.ToString("yyy-MM-dd") & "')"

        Try
            Conexion.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - digitovertical")
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Shared Sub ModificarDigito(pTabla As String, pDigito As String)
        Dim mCommand As String = "update digitovertical set digito = '" & pDigito & "', fecha = '" & Date.Now.Date.ToString("yyyy-MM-dd") & "' where nombretabla like '" & pTabla & "'"

        Try
            Conexion.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificar - digitovertical")
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Shared Function Obtenerdigitovertical(pTabla As String) As String
        Dim mdigitovertical As Integer
        Dim mDataSet As DataSet
        Dim mCommand As String = "select digito from DigitoVertical where nombretabla like '" & pTabla & "'"

        Try
            mDataSet = Conexion.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) Then
                If mDataSet.Tables.Count > 0 Then
                    If mDataSet.Tables(0).Rows.Count > 0 Then
                        mdigitovertical = mDataSet.Tables(0).Rows(0)("digito")
                    End If
                End If
            End If

            Return mdigitovertical
        Catch ex As Exception
            MsgBox("Error - Obtener - digitovertical")
            MsgBox(ex.Message)

            Return Nothing
        End Try
    End Function
End Class