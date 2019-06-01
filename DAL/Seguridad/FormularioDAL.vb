Imports BE

Public Class FormularioDAL

    Public Shared Function CargarFormBE(pRow As DataRow) As FormularioBE
        Dim form As New FormularioBE
        form.ID = pRow("ID")
        form.Menu = pRow("M")
        form.NombreFormulario = pRow("NF")
        Return form
    End Function

    Public Shared Function ObtenerFormulariosUsuario(usuario As UsuarioBE) As HashSet(Of FormularioBE)
        Dim patentes = PatenteDAL.listarPatentesUsuario(usuario)
        Dim formularios As New Dictionary(Of String, FormularioBE)
        Try
            For Each patente As PatenteBE In patentes
                Dim formNuevos = ObtenerFormulariosPatente(patente)
                For Each nuevo As FormularioBE In formNuevos
                    Dim prevForm As New FormularioBE
                    If formularios.TryGetValue(nuevo.NombreFormulario, prevForm) Then
                        prevForm.Acciones.UnionWith(nuevo.Acciones)
                        formularios.Add(nuevo.NombreFormulario, prevForm)
                    Else
                        formularios.Add(nuevo.NombreFormulario, nuevo)
                    End If
                Next
            Next

        Dim ret As New HashSet(Of FormularioBE)
        For Each kvp As KeyValuePair(Of String, FormularioBE) In formularios
            ret.Add(kvp.Value)
        Next
            Return ret
        Catch ex As Exception
            MsgBox("Error - ObtenerFormulariosUsuario - FormularioDAL")
            MsgBox(ex.Message)
        End Try
    End Function


    Public Shared Function ObtenerFormulariosPatente(patente As PatenteBE) As HashSet(Of FormularioBE)
        Dim forms As New Dictionary(Of String, FormularioBE)
        Dim mCommand As String = "SELECT f.Id As ID, f.Menu As M, f.NombreFormulario As NF, fp.Accion As Accion FROM Formularios f, FormularioPatente fp Where f.Id = fp.IdFormulario and fp.IdPatente = " & patente.ID
        Dim mDataSet As DataSet

        Try
            mDataSet = Conexion.ExecuteDataSet(mCommand)
            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows

                    Dim form As FormularioBE = CargarFormBE(mRow)
                    Dim prevForm As New FormularioBE
                    If (forms.TryGetValue(form.NombreFormulario, prevForm)) Then
                        prevForm.Acciones.Add(mRow("Acciones"))
                        forms.Add(prevForm.NombreFormulario, prevForm)
                    Else
                        forms.Add(form.NombreFormulario, form)
                    End If
                Next
                Dim ret As New HashSet(Of FormularioBE)
                For Each kvp As KeyValuePair(Of String, FormularioBE) In forms
                    ret.Add(kvp.Value)
                Next
                Return ret
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - ObtenerFormulariosPatente - FormularioDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
