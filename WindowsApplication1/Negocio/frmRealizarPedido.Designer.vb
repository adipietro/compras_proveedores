<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRealizarPedido
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalDesc = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Producto = New System.Windows.Forms.Label()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.btnAgregarDetalle = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.clmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtCantidadDesc = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalPedido = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.cmbEmpleados = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbProv = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCargarProveedor = New System.Windows.Forms.Button()
        Me.btnGuardarOC = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSugerir = New System.Windows.Forms.Button()
        Me.txtSugerencia = New System.Windows.Forms.TextBox()
        Me.cmbProd2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 171)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(491, 270)
        Me.DataGridView2.TabIndex = 27
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.DimGray
        Me.btnCalcular.Enabled = False
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalcular.Location = New System.Drawing.Point(542, 282)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 27)
        Me.btnCalcular.TabIndex = 29
        Me.btnCalcular.Text = "Calcular Total"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(311, 468)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 30
        '
        'txtTotalDesc
        '
        Me.txtTotalDesc.Enabled = False
        Me.txtTotalDesc.Location = New System.Drawing.Point(311, 510)
        Me.txtTotalDesc.Name = "txtTotalDesc"
        Me.txtTotalDesc.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalDesc.TabIndex = 31
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(311, 551)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(308, 452)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "SubTotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 493)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Total Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(308, 534)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Total "
        '
        'Producto
        '
        Me.Producto.AutoSize = True
        Me.Producto.Location = New System.Drawing.Point(529, 174)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(50, 13)
        Me.Producto.TabIndex = 58
        Me.Producto.Text = "Producto"
        '
        'txtProd
        '
        Me.txtProd.Enabled = False
        Me.txtProd.Location = New System.Drawing.Point(532, 190)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(100, 20)
        Me.txtProd.TabIndex = 57
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(562, 236)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(70, 20)
        Me.txtCantidad.TabIndex = 59
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(559, 220)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(49, 13)
        Me.lbl.TabIndex = 60
        Me.lbl.Text = "Cantidad"
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.BackColor = System.Drawing.Color.DimGray
        Me.btnAgregarDetalle.Enabled = False
        Me.btnAgregarDetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(542, 315)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(100, 27)
        Me.btnAgregarDetalle.TabIndex = 61
        Me.btnAgregarDetalle.Text = "Agregar a Detalle"
        Me.btnAgregarDetalle.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmProducto, Me.clmCantidad, Me.clmPrecio, Me.clmDesc, Me.clmTotal})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView3.Location = New System.Drawing.Point(648, 174)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView3.Size = New System.Drawing.Size(516, 212)
        Me.DataGridView3.TabIndex = 62
        '
        'clmProducto
        '
        Me.clmProducto.HeaderText = "Producto"
        Me.clmProducto.Name = "clmProducto"
        Me.clmProducto.ReadOnly = True
        '
        'clmCantidad
        '
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.ReadOnly = True
        '
        'clmPrecio
        '
        Me.clmPrecio.HeaderText = "Precio"
        Me.clmPrecio.Name = "clmPrecio"
        Me.clmPrecio.ReadOnly = True
        '
        'clmDesc
        '
        Me.clmDesc.HeaderText = "Descuento"
        Me.clmDesc.Name = "clmDesc"
        '
        'clmTotal
        '
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(244, 517)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(50, 20)
        Me.txtDescuento.TabIndex = 63
        '
        'txtCantidadDesc
        '
        Me.txtCantidadDesc.Enabled = False
        Me.txtCantidadDesc.Location = New System.Drawing.Point(244, 492)
        Me.txtCantidadDesc.Name = "txtCantidadDesc"
        Me.txtCantidadDesc.Size = New System.Drawing.Size(50, 20)
        Me.txtCantidadDesc.TabIndex = 64
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(244, 466)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(50, 20)
        Me.txtPrecio.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(179, 517)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Descuento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 495)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Cantidad necesario para Descuento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(201, 469)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Precio"
        '
        'txtTotalPedido
        '
        Me.txtTotalPedido.Enabled = False
        Me.txtTotalPedido.Location = New System.Drawing.Point(1079, 411)
        Me.txtTotalPedido.Name = "txtTotalPedido"
        Me.txtTotalPedido.Size = New System.Drawing.Size(85, 20)
        Me.txtTotalPedido.TabIndex = 69
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.DimGray
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBorrar.Location = New System.Drawing.Point(648, 395)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(100, 27)
        Me.btnBorrar.TabIndex = 71
        Me.btnBorrar.Text = "Borrar registro"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(1101, 553)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 37)
        Me.Button5.TabIndex = 73
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(847, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(754, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Se genero OC N°:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox10)
        Me.TabPage3.Controls.Add(Me.PictureBox9)
        Me.TabPage3.Controls.Add(Me.PictureBox8)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Controls.Add(Me.LinkLabel2)
        Me.TabPage3.Controls.Add(Me.cmbEmpleados)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.btnImprimir)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.cmbProv)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.cmbArea)
        Me.TabPage3.Controls.Add(Me.DateTimePicker1)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.btnCargarProveedor)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1148, 127)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Orden de compra"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PictureBox10
        '
        Me.PictureBox10.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j__2_
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Image = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox10.Location = New System.Drawing.Point(6, 95)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox10.TabIndex = 80
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Visible = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Image = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox9.Location = New System.Drawing.Point(938, 46)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(37, 26)
        Me.PictureBox9.TabIndex = 81
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Image = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox8.Location = New System.Drawing.Point(938, 14)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(37, 26)
        Me.PictureBox8.TabIndex = 80
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox1.Location = New System.Drawing.Point(110, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 26)
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(214, 44)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(67, 13)
        Me.LinkLabel2.TabIndex = 66
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Proveedores"
        '
        'cmbEmpleados
        '
        Me.cmbEmpleados.FormattingEnabled = True
        Me.cmbEmpleados.Location = New System.Drawing.Point(770, 73)
        Me.cmbEmpleados.Name = "cmbEmpleados"
        Me.cmbEmpleados.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpleados.TabIndex = 39
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(981, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 32)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Ver Ordenes de Compra"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(27, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(482, 14)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "(*) Se recomienda acceder a pantalla                        para conocer mas info" & _
    "rmación del proveedor"
        '
        'btnImprimir
        '
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Location = New System.Drawing.Point(981, 11)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(142, 28)
        Me.btnImprimir.TabIndex = 37
        Me.btnImprimir.Text = "Imprimir OC"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(709, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Solicitante:"
        '
        'cmbProv
        '
        Me.cmbProv.FormattingEnabled = True
        Me.cmbProv.Location = New System.Drawing.Point(118, 19)
        Me.cmbProv.Name = "cmbProv"
        Me.cmbProv.Size = New System.Drawing.Size(121, 21)
        Me.cmbProv.TabIndex = 63
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(53, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Proveedor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(736, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Area:"
        '
        'cmbArea
        '
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(770, 42)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(121, 21)
        Me.cmbArea.TabIndex = 30
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(643, 14)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(248, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(600, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha"
        '
        'btnCargarProveedor
        '
        Me.btnCargarProveedor.BackColor = System.Drawing.Color.Transparent
        Me.btnCargarProveedor.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.flecha_hacia_abajo_en_un_circulo_318_55532
        Me.btnCargarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCargarProveedor.Location = New System.Drawing.Point(153, 73)
        Me.btnCargarProveedor.Name = "btnCargarProveedor"
        Me.btnCargarProveedor.Size = New System.Drawing.Size(48, 48)
        Me.btnCargarProveedor.TabIndex = 64
        Me.btnCargarProveedor.UseVisualStyleBackColor = False
        '
        'btnGuardarOC
        '
        Me.btnGuardarOC.BackColor = System.Drawing.Color.DarkGray
        Me.btnGuardarOC.Enabled = False
        Me.btnGuardarOC.Location = New System.Drawing.Point(1079, 463)
        Me.btnGuardarOC.Name = "btnGuardarOC"
        Me.btnGuardarOC.Size = New System.Drawing.Size(85, 32)
        Me.btnGuardarOC.TabIndex = 67
        Me.btnGuardarOC.Text = "Guardar OC"
        Me.btnGuardarOC.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.btnSugerir)
        Me.TabPage1.Controls.Add(Me.txtSugerencia)
        Me.TabPage1.Controls.Add(Me.cmbProd2)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1148, 127)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Sugerencia de Proveedores"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DimGray
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(1023, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 47)
        Me.Button3.TabIndex = 73
        Me.Button3.Text = "Ver evaluaciones de Proveedores"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(583, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(434, 108)
        Me.DataGridView1.TabIndex = 56
        '
        'btnSugerir
        '
        Me.btnSugerir.BackColor = System.Drawing.Color.White
        Me.btnSugerir.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Disp
        Me.btnSugerir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSugerir.Location = New System.Drawing.Point(192, 6)
        Me.btnSugerir.Name = "btnSugerir"
        Me.btnSugerir.Size = New System.Drawing.Size(48, 48)
        Me.btnSugerir.TabIndex = 55
        Me.btnSugerir.UseVisualStyleBackColor = False
        '
        'txtSugerencia
        '
        Me.txtSugerencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSugerencia.Location = New System.Drawing.Point(255, 6)
        Me.txtSugerencia.Multiline = True
        Me.txtSugerencia.Name = "txtSugerencia"
        Me.txtSugerencia.Size = New System.Drawing.Size(313, 74)
        Me.txtSugerencia.TabIndex = 54
        '
        'cmbProd2
        '
        Me.cmbProd2.FormattingEnabled = True
        Me.cmbProd2.Location = New System.Drawing.Point(67, 18)
        Me.cmbProd2.Name = "cmbProd2"
        Me.cmbProd2.Size = New System.Drawing.Size(121, 21)
        Me.cmbProd2.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Producto"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1156, 153)
        Me.TabControl1.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1072, 395)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Total Detalle:"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Image = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox7.Location = New System.Drawing.Point(1036, 465)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(37, 26)
        Me.PictureBox7.TabIndex = 79
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Image = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox5.Location = New System.Drawing.Point(507, 316)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(37, 26)
        Me.PictureBox5.TabIndex = 77
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox4.Location = New System.Drawing.Point(507, 283)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(37, 26)
        Me.PictureBox4.TabIndex = 76
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.C_VFIO7XcAEwX0j
        Me.PictureBox3.Location = New System.Drawing.Point(519, 230)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 26)
        Me.PictureBox3.TabIndex = 70
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._refresh_55882
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources._refresh_55882
        Me.Button1.Location = New System.Drawing.Point(1042, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 31)
        Me.Button1.TabIndex = 83
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmRealizarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1180, 602)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnGuardarOC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.txtTotalPedido)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtCantidadDesc)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.btnAgregarDetalle)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Producto)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtTotalDesc)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Name = "frmRealizarPedido"
        Me.Text = "Realizar Pedido"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Producto As System.Windows.Forms.Label
    Friend WithEvents txtProd As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents btnAgregarDetalle As System.Windows.Forms.Button
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPedido As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents clmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbEmpleados As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbProv As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCargarProveedor As System.Windows.Forms.Button
    Friend WithEvents cmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSugerir As System.Windows.Forms.Button
    Friend WithEvents txtSugerencia As System.Windows.Forms.TextBox
    Friend WithEvents cmbProd2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents btnGuardarOC As System.Windows.Forms.Button
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
