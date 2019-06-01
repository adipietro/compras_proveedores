Imports BLL

Public Class Backup
    Implements iObservador

    Dim vTraductor As Traductor = Traductor.GetInstance

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each mControl As Control In Me.Controls
            Try
                CargarTags(mControl)
            Catch ex As Exception

            End Try
        Next
    End Sub

    Public Sub CargarTags(pControl As Control)
        pControl.Tag = pControl.Text

        If pControl.Controls.Count > 0 Then
            For Each mControl As Control In pControl.Controls
                CargarTags(mControl)
            Next
        End If
    End Sub

    Public Sub ActualizarObservador(Optional pControl As Control = Nothing) Implements iObservador.ActualizarObservador
        For Each mControl As Control In pControl.Controls
            Try
                mControl.Text = vTraductor.IdiomaSeleccionado.diccionario.Item(mControl.Tag).ToString
            Catch ex As Exception

            Finally
                If mControl.Controls.Count > 0 Then
                    ActualizarObservador(mControl)
                End If
            End Try
        Next
    End Sub



    Dim direccion As String

    Private Sub Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BackUpBLL.CrearBackup(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If System.IO.Directory.Exists("C:\ProductosProveedores") Then
            OpenFileDialog1.InitialDirectory = "C:\ProductosProveedores"
        End If

        OpenFileDialog1.ShowDialog()

        direccion = OpenFileDialog1.FileName
        TextBox2.Text = direccion
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BackUpBLL.RestaurarConexion(direccion)
    End Sub
End Class