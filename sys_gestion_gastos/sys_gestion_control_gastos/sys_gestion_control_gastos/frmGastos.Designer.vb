<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGastos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gpConsultas = New System.Windows.Forms.GroupBox()
        Me.rbCategoria = New System.Windows.Forms.RadioButton()
        Me.rbTipo = New System.Windows.Forms.RadioButton()
        Me.rbMetodo = New System.Windows.Forms.RadioButton()
        Me.txtEntrada1 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnListo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.PictureBox()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        Me.btnNuevo = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvGastos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdTipo = New System.Windows.Forms.TextBox()
        Me.btnTipo = New System.Windows.Forms.Button()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdMetodo = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.btnMetodo = New System.Windows.Forms.Button()
        Me.txtMetodo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbSaldos = New System.Windows.Forms.Label()
        Me.lbGastos = New System.Windows.Forms.Label()
        Me.lbIngresos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.gpConsultas.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.gpConsultas)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1575, 720)
        Me.Panel2.TabIndex = 11
        '
        'gpConsultas
        '
        Me.gpConsultas.Controls.Add(Me.rbCategoria)
        Me.gpConsultas.Controls.Add(Me.rbTipo)
        Me.gpConsultas.Controls.Add(Me.rbMetodo)
        Me.gpConsultas.Controls.Add(Me.txtEntrada1)
        Me.gpConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpConsultas.ForeColor = System.Drawing.Color.Navy
        Me.gpConsultas.Location = New System.Drawing.Point(1311, 464)
        Me.gpConsultas.Name = "gpConsultas"
        Me.gpConsultas.Size = New System.Drawing.Size(255, 244)
        Me.gpConsultas.TabIndex = 41
        Me.gpConsultas.TabStop = False
        Me.gpConsultas.Text = "CONSULTAS"
        '
        'rbCategoria
        '
        Me.rbCategoria.AutoSize = True
        Me.rbCategoria.Location = New System.Drawing.Point(51, 65)
        Me.rbCategoria.Name = "rbCategoria"
        Me.rbCategoria.Size = New System.Drawing.Size(180, 24)
        Me.rbCategoria.TabIndex = 76
        Me.rbCategoria.TabStop = True
        Me.rbCategoria.Text = "POR CATEGORÍA"
        Me.rbCategoria.UseVisualStyleBackColor = True
        '
        'rbTipo
        '
        Me.rbTipo.AutoSize = True
        Me.rbTipo.Location = New System.Drawing.Point(51, 95)
        Me.rbTipo.Name = "rbTipo"
        Me.rbTipo.Size = New System.Drawing.Size(116, 24)
        Me.rbTipo.TabIndex = 75
        Me.rbTipo.TabStop = True
        Me.rbTipo.Text = "POR TIPO"
        Me.rbTipo.UseVisualStyleBackColor = True
        '
        'rbMetodo
        '
        Me.rbMetodo.AutoSize = True
        Me.rbMetodo.Location = New System.Drawing.Point(51, 35)
        Me.rbMetodo.Name = "rbMetodo"
        Me.rbMetodo.Size = New System.Drawing.Size(139, 24)
        Me.rbMetodo.TabIndex = 74
        Me.rbMetodo.TabStop = True
        Me.rbMetodo.Text = "POR FORMA"
        Me.rbMetodo.UseVisualStyleBackColor = True
        '
        'txtEntrada1
        '
        Me.txtEntrada1.Location = New System.Drawing.Point(17, 157)
        Me.txtEntrada1.Name = "txtEntrada1"
        Me.txtEntrada1.Size = New System.Drawing.Size(216, 26)
        Me.txtEntrada1.TabIndex = 71
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.btnListo)
        Me.Panel4.Controls.Add(Me.btnModificar)
        Me.Panel4.Controls.Add(Me.btnEliminar)
        Me.Panel4.Controls.Add(Me.btnNuevo)
        Me.Panel4.Location = New System.Drawing.Point(1311, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(251, 450)
        Me.Panel4.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(43, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 25)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "F3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(43, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 25)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "F2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(43, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 25)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "F1"
        '
        'btnListo
        '
        Me.btnListo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnListo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListo.ForeColor = System.Drawing.Color.Navy
        Me.btnListo.Location = New System.Drawing.Point(60, 377)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(147, 66)
        Me.btnListo.TabIndex = 25
        Me.btnListo.Text = "LISTO"
        Me.btnListo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnModificar.Image = Global.sys_gestion_control_gastos.My.Resources.Resources.actualize_arrows_couple_in_circle
        Me.btnModificar.Location = New System.Drawing.Point(86, 149)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(92, 89)
        Me.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnModificar.TabIndex = 24
        Me.btnModificar.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEliminar.Image = Global.sys_gestion_control_gastos.My.Resources.Resources.rounded_remove_button
        Me.btnEliminar.Location = New System.Drawing.Point(86, 273)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 89)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEliminar.TabIndex = 23
        Me.btnEliminar.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNuevo.Image = Global.sys_gestion_control_gastos.My.Resources.Resources.plus
        Me.btnNuevo.Location = New System.Drawing.Point(86, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(92, 95)
        Me.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNuevo.TabIndex = 22
        Me.btnNuevo.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgvGastos)
        Me.Panel6.Controls.Add(Me.GroupBox1)
        Me.Panel6.Location = New System.Drawing.Point(27, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1278, 906)
        Me.Panel6.TabIndex = 40
        '
        'dgvGastos
        '
        Me.dgvGastos.AllowUserToAddRows = False
        Me.dgvGastos.AllowUserToDeleteRows = False
        Me.dgvGastos.AllowUserToResizeColumns = False
        Me.dgvGastos.AllowUserToResizeRows = False
        Me.dgvGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGastos.Location = New System.Drawing.Point(6, 3)
        Me.dgvGastos.Name = "dgvGastos"
        Me.dgvGastos.ReadOnly = True
        Me.dgvGastos.RowHeadersWidth = 62
        Me.dgvGastos.RowTemplate.Height = 28
        Me.dgvGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGastos.Size = New System.Drawing.Size(1265, 396)
        Me.dgvGastos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtIdTipo)
        Me.GroupBox1.Controls.Add(Me.btnTipo)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtIdCategoria)
        Me.GroupBox1.Controls.Add(Me.btnCategoria)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtIdMetodo)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.btnMetodo)
        Me.GroupBox1.Controls.Add(Me.txtMetodo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbCliente)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lbFecha)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(6, 405)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1265, 303)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(205, 161)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(373, 48)
        Me.txtDescripcion.TabIndex = 66
        Me.txtDescripcion.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 25)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "DESCRIPCIÓN:"
        '
        'txtIdTipo
        '
        Me.txtIdTipo.Location = New System.Drawing.Point(810, 74)
        Me.txtIdTipo.Name = "txtIdTipo"
        Me.txtIdTipo.ReadOnly = True
        Me.txtIdTipo.Size = New System.Drawing.Size(373, 26)
        Me.txtIdTipo.TabIndex = 64
        Me.txtIdTipo.Visible = False
        '
        'btnTipo
        '
        Me.btnTipo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTipo.BackgroundImage = Global.sys_gestion_control_gastos.My.Resources.Resources.search1
        Me.btnTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTipo.Location = New System.Drawing.Point(1197, 102)
        Me.btnTipo.Name = "btnTipo"
        Me.btnTipo.Size = New System.Drawing.Size(50, 36)
        Me.btnTipo.TabIndex = 63
        Me.btnTipo.UseVisualStyleBackColor = False
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(810, 106)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(373, 26)
        Me.txtTipo.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(693, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 25)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "TIPO: "
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.Location = New System.Drawing.Point(205, 70)
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.ReadOnly = True
        Me.txtIdCategoria.Size = New System.Drawing.Size(373, 26)
        Me.txtIdCategoria.TabIndex = 60
        Me.txtIdCategoria.Visible = False
        '
        'btnCategoria
        '
        Me.btnCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCategoria.BackgroundImage = Global.sys_gestion_control_gastos.My.Resources.Resources.search1
        Me.btnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategoria.Location = New System.Drawing.Point(593, 98)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(50, 36)
        Me.btnCategoria.TabIndex = 59
        Me.btnCategoria.UseVisualStyleBackColor = False
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(205, 102)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(373, 26)
        Me.txtCategoria.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 25)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "CATEGORÍA:"
        '
        'txtIdMetodo
        '
        Me.txtIdMetodo.Location = New System.Drawing.Point(810, 1)
        Me.txtIdMetodo.Name = "txtIdMetodo"
        Me.txtIdMetodo.ReadOnly = True
        Me.txtIdMetodo.Size = New System.Drawing.Size(373, 26)
        Me.txtIdMetodo.TabIndex = 55
        Me.txtIdMetodo.Visible = False
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(810, 184)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(373, 26)
        Me.txtFecha.TabIndex = 54
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(205, 231)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(373, 26)
        Me.txtMonto.TabIndex = 52
        '
        'btnMetodo
        '
        Me.btnMetodo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMetodo.BackgroundImage = Global.sys_gestion_control_gastos.My.Resources.Resources.search1
        Me.btnMetodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMetodo.Location = New System.Drawing.Point(1197, 29)
        Me.btnMetodo.Name = "btnMetodo"
        Me.btnMetodo.Size = New System.Drawing.Size(50, 36)
        Me.btnMetodo.TabIndex = 51
        Me.btnMetodo.UseVisualStyleBackColor = False
        '
        'txtMetodo
        '
        Me.txtMetodo.Location = New System.Drawing.Point(810, 33)
        Me.txtMetodo.Name = "txtMetodo"
        Me.txtMetodo.ReadOnly = True
        Me.txtMetodo.Size = New System.Drawing.Size(373, 26)
        Me.txtMetodo.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "MONTO:"
        '
        'lbCliente
        '
        Me.lbCliente.AutoSize = True
        Me.lbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCliente.Location = New System.Drawing.Point(650, 34)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(114, 25)
        Me.lbCliente.TabIndex = 35
        Me.lbCliente.Text = "METODO:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(810, 216)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(373, 26)
        Me.DateTimePicker1.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "CODIGO:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(205, 29)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(373, 26)
        Me.txtCodigo.TabIndex = 25
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(676, 184)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(92, 25)
        Me.lbFecha.TabIndex = 34
        Me.lbFecha.Text = "FECHA:"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(27, 720)
        Me.Panel5.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbSaldos)
        Me.Panel1.Controls.Add(Me.lbGastos)
        Me.Panel1.Controls.Add(Me.lbIngresos)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1575, 71)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sys_gestion_control_gastos.My.Resources.Resources.logo_bloom
        Me.PictureBox1.Location = New System.Drawing.Point(33, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'lbSaldos
        '
        Me.lbSaldos.AutoSize = True
        Me.lbSaldos.BackColor = System.Drawing.Color.AliceBlue
        Me.lbSaldos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldos.ForeColor = System.Drawing.Color.Navy
        Me.lbSaldos.Location = New System.Drawing.Point(1155, 27)
        Me.lbSaldos.Name = "lbSaldos"
        Me.lbSaldos.Size = New System.Drawing.Size(79, 25)
        Me.lbSaldos.TabIndex = 70
        Me.lbSaldos.Text = "Saldos"
        '
        'lbGastos
        '
        Me.lbGastos.AutoSize = True
        Me.lbGastos.BackColor = System.Drawing.Color.AliceBlue
        Me.lbGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGastos.ForeColor = System.Drawing.Color.DarkRed
        Me.lbGastos.Location = New System.Drawing.Point(726, 25)
        Me.lbGastos.Name = "lbGastos"
        Me.lbGastos.Size = New System.Drawing.Size(80, 25)
        Me.lbGastos.TabIndex = 69
        Me.lbGastos.Text = "Gastos"
        '
        'lbIngresos
        '
        Me.lbIngresos.AutoSize = True
        Me.lbIngresos.BackColor = System.Drawing.Color.AliceBlue
        Me.lbIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIngresos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbIngresos.Location = New System.Drawing.Point(293, 27)
        Me.lbIngresos.Name = "lbIngresos"
        Me.lbIngresos.Size = New System.Drawing.Size(95, 25)
        Me.lbIngresos.TabIndex = 68
        Me.lbIngresos.Text = "Ingresos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(622, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 22)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "GASTOS:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(1054, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 22)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "SALDOS:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(169, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 22)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "INGRESOS:"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Red
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(1489, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(73, 50)
        Me.btnCerrar.TabIndex = 36
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1575, 791)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULARIO GASTOS"
        Me.Panel2.ResumeLayout(False)
        Me.gpConsultas.ResumeLayout(False)
        Me.gpConsultas.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgvGastos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIdMetodo As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents btnMetodo As Button
    Friend WithEvents txtMetodo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbCliente As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnModificar As PictureBox
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnListo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtIdTipo As TextBox
    Friend WithEvents btnTipo As Button
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents btnCategoria As Button
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lbSaldos As Label
    Friend WithEvents lbGastos As Label
    Friend WithEvents lbIngresos As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents gpConsultas As GroupBox
    Friend WithEvents rbCategoria As RadioButton
    Friend WithEvents rbTipo As RadioButton
    Friend WithEvents rbMetodo As RadioButton
    Friend WithEvents txtEntrada1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
