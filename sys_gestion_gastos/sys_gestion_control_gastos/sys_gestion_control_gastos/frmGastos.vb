Imports System.Data.SqlClient
Imports sys_gestion_control_gastos.sys_gestion_gastosDataSetTableAdapters

Public Class frmGastos
    Private Sub frmGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GroupBox1.Visible = False


        Me.Size = New Size(1070, 560)

        'Me.ControlBox = False
        'Me.FormBorderStyle = FormBorderStyle.Sizable ' o Fixed3D, FixedDialog, FixedSingle
        Me.MaximizeBox = False ' Desactiva el botón de maximizar
        Me.MinimizeBox = False ' Desactiva el botón de minimizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Desactiva la capacidad de redimensionar verticalmente
        ' Establecer la posición inicial del formulario en el centro de la pantalla
        Me.StartPosition = FormStartPosition.CenterScreen

        Me.btnCerrar.Visible = False

        Me.txtDescripcion.Enabled = False

        'Activar la propriedad keypreview
        Me.KeyPreview = True

        llenarGastos()

        ConsultaSql.ActualizarSumaIngresos()
        lbIngresos.Text = ConsultaSql.sumaIngresos.ToString("C")

        ConsultaSql.ActualizarSumaGastos()
        lbGastos.Text = ConsultaSql.sumaGastos.ToString("C")

        ConsultaSql.ActualizarDiferencia()
        lbSaldos.Text = ConsultaSql.diferencia.ToString("C")
    End Sub

    Private Sub llenarGastos()
        Dim sql As String = "select gastos.idGasto as 'CODIGO',
                                metodos_transaccion.idMetodo as 'CODIGO METODO',
                                metodos_transaccion.nombreMetodo as 'FORMA',
                                categorias.idCategoria as 'CODIGO CATEGORIA',
                                categorias.nombreCategoria as 'CATEGORíA',
                                gastos.descripcion as 'DESCRIPCIÓN',
                                tipos_transaccion.idTipo as 'CODIGO TIPO',
                                tipos_transaccion.nombreTipo as 'TIPO',
                                gastos.montoGastos as 'MONTO',
                                gastos.fecha as 'FECHA'
                            from gastos
                            inner join metodos_transaccion on gastos.idMetodo = metodos_transaccion.idMetodo
                            inner join categorias on gastos.idCategoria = categorias.idCategoria
                            inner join tipos_transaccion on gastos.idTipo = tipos_transaccion.idTipo"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("gastos")
        adp.Fill(ds.Tables("gastos"))
        Me.dgvGastos.DataSource = ds.Tables("gastos")
        Me.dgvGastos.Columns("CODIGO METODO").Visible = False
        Me.dgvGastos.Columns("CODIGO CATEGORIA").Visible = False
        Me.dgvGastos.Columns("CODIGO TIPO").Visible = False
    End Sub



    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvGastos.Rows.Count > 0 Then ' Verificar si hay filas en el DataGridView
            'Me.Size = New Size(1150, 560)
            Me.GroupBox1.Visible = True
            flag_abm = 2 'UPDATE

            wcp = Me.dgvGastos.CurrentRow.Cells(0).Value
            Me.txtCodigo.Text = wcp

            Me.txtIdMetodo.Text = Me.dgvGastos.CurrentRow.Cells(1).Value
            Me.txtIdMetodo.Enabled = True

            Me.txtMetodo.Text = Me.dgvGastos.CurrentRow.Cells(2).Value.ToString
            Me.txtMetodo.Enabled = True
            'Me.txtMetodo.Focus()

            Me.txtIdCategoria.Text = Me.dgvGastos.CurrentRow.Cells(3).Value
            Me.txtIdCategoria.Enabled = True

            Me.txtCategoria.Text = Me.dgvGastos.CurrentRow.Cells(4).Value.ToString
            Me.txtCategoria.Enabled = True

            Me.txtDescripcion.Text = Me.dgvGastos.CurrentRow.Cells(5).Value.ToString
            Me.txtDescripcion.Enabled = True

            Me.txtIdTipo.Text = Me.dgvGastos.CurrentRow.Cells(6).Value
            Me.txtIdTipo.Enabled = True

            Me.txtTipo.Text = Me.dgvGastos.CurrentRow.Cells(6).Value.ToString
            Me.txtTipo.Enabled = True

            Me.txtMonto.Text = Me.dgvGastos.CurrentRow.Cells(8).Value.ToString ''''''''''''''''''''''
            Me.txtMonto.Enabled = True

            Me.txtFecha.Text = Me.dgvGastos.CurrentRow.Cells(9).Value.ToShortDateString()
            Me.txtFecha.Enabled = True
        Else
            MsgBox("No hay registros para modificar.", MsgBoxStyle.Information, "Información")
        End If
        Me.btnMetodo.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvGastos.Rows.Count > 0 Then ' Verificar si hay filas en el DataGridView
            'Me.Size = New Size(1150, 560)
            Me.GroupBox1.Visible = True
            flag_abm = 3 'UPDATE

            wcp = Me.dgvGastos.CurrentRow.Cells(0).Value
            Me.txtCodigo.Text = wcp

            Me.txtIdMetodo.Text = Me.dgvGastos.CurrentRow.Cells(1).Value
            Me.txtIdMetodo.Enabled = True

            Me.txtMetodo.Text = Me.dgvGastos.CurrentRow.Cells(2).Value.ToString
            Me.txtMetodo.Enabled = True

            Me.txtIdCategoria.Text = Me.dgvGastos.CurrentRow.Cells(3).Value
            Me.txtIdCategoria.Enabled = True

            Me.txtCategoria.Text = Me.dgvGastos.CurrentRow.Cells(4).Value.ToString
            Me.txtCategoria.Enabled = True

            Me.txtDescripcion.Text = Me.dgvGastos.CurrentRow.Cells(5).Value.ToString
            Me.txtDescripcion.Enabled = True

            Me.txtIdTipo.Text = Me.dgvGastos.CurrentRow.Cells(6).Value
            Me.txtIdTipo.Enabled = True

            Me.txtTipo.Text = Me.dgvGastos.CurrentRow.Cells(6).Value.ToString
            Me.txtTipo.Enabled = True

            Me.txtMonto.Text = Me.dgvGastos.CurrentRow.Cells(8).Value.ToString ''''''''''''''''''''''
            Me.txtMonto.Enabled = True

            Me.txtFecha.Text = Me.dgvGastos.CurrentRow.Cells(9).Value.ToShortDateString()
            Me.txtFecha.Enabled = True
        Else
            MsgBox("No hay registros para eliminar.", MsgBoxStyle.Information, "Información")
        End If

        Me.btnListo.Focus()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Me.Size = New Size(1150, 560)
        Me.GroupBox1.Visible = True
        flag_abm = 1 'ALTA
        limpiar()
        generarIdGasto()
        'Me.txtCodigo.Enabled = True
        'Me.txtMetodo.Enabled = True
        'Me.txtMonto.Enabled = True
        'Me.txtFecha.Enabled = True
        'Me.DateTimePicker1.Enabled = True
        Me.btnMetodo.Focus()
    End Sub

    'NUEVO GASTO
    Public Sub nuevoGasto()
        Try
            If Me.txtCodigo.Text <> "" AndAlso Me.txtMetodo.Text <> "" AndAlso Me.txtCategoria.Text <> "" AndAlso Me.txtTipo.Text <> "" AndAlso Me.txtMonto.Text <> "" Then
                ' Obtener la fecha del DateTimePicker como un objeto DateTime
                Dim fecha As DateTime = DateTimePicker1.Value

                ' Formatear la fecha como una cadena en el formato "yyyy-MM-dd"
                Dim fechaFormateada As String = fecha.ToString("yyyy-MM-dd")

                Dim sql As String = "INSERT INTO gastos (idGasto, idMetodo, idCategoria, descripcion, idTipo, montoGastos, fecha) " &
                            "VALUES ('" & Me.txtCodigo.Text & "', '" & Me.txtIdMetodo.Text & "', '" & Me.txtIdCategoria.Text & "', '" & Me.txtDescripcion.Text & "', '" & Me.txtIdTipo.Text & "', '" & Me.txtMonto.Text & "', '" & fechaFormateada & "')"
                cmd.Connection = conexion.conexion
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarGastos()
                limpiar()
            Else
                MsgBox("Debes completar todos los campos.", MsgBoxStyle.Critical, "Error")
            End If

        Catch ex As Exception
            MsgBox("Error al intentar insertar el registro: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        'conexion.conexion.Close()
    End Sub


    'UPDATE  expedientes 
    Private Sub updateGasto()
        ' Verificar si la conexión está abierta antes de intentar cerrarla
        If conexion.conexion.State = ConnectionState.Open Then
            conexion.conexion.Close()
        End If

        Dim sql As String = "UPDATE gastos SET
                        idGasto = @idGasto,
                        idMetodo = @idMetodo,
                        idCategoria = @idCategoria,
                        descripcion = @descripcion,
                        idTipo = @idTipo,
                        montoGastos = @montoGastos,
                        fecha = @fecha
                    WHERE idGasto = @idGastoParam"

        Using command As New SqlCommand(sql, conexion.conexion)
            ' Agregar parámetros
            command.Parameters.AddWithValue("@idGasto", Me.txtCodigo.Text)
            command.Parameters.AddWithValue("@idMetodo", Me.txtIdMetodo.Text)
            command.Parameters.AddWithValue("@idCategoria", Me.txtIdCategoria.Text)
            command.Parameters.AddWithValue("@descripcion", Me.txtDescripcion.Text)
            command.Parameters.AddWithValue("@idTipo", Me.txtIdTipo.Text)

            ' Convertir y agregar el parámetro montoGastos
            Dim monto As Decimal
            If Decimal.TryParse(Me.txtMonto.Text, monto) Then
                command.Parameters.AddWithValue("@montoGastos", monto)
            Else
                ' Si no se puede convertir, se asigna DBNull
                command.Parameters.AddWithValue("@montoGastos", DBNull.Value)
            End If

            ' Obtener la fecha del DateTimePicker como un objeto DateTime
            Dim fecha As DateTime = DateTimePicker1.Value

            ' Formatear la fecha como una cadena en el formato "yyyy-MM-dd"
            Dim fechaFormateada As String = fecha.ToString("yyyy-MM-dd")

            ' Agregar el parámetro fecha formateado
            command.Parameters.AddWithValue("@fecha", fechaFormateada)

            ' Agregar el parámetro idGastoParam (para la cláusula WHERE)
            command.Parameters.AddWithValue("@idGastoParam", Me.txtCodigo.Text)

            Try
                ' Abrir la conexión y ejecutar la consulta
                conexion.conexion.Open()
                command.ExecuteNonQuery()
                Console.Beep()
                llenarGastos()
                limpiar()
                'Me.btnListo.Visible = False
            Catch ex As Exception
                MsgBox("Error al actualizar los datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                ' Cerrar la conexión
                'conexion.conexion.Close()
            End Try
        End Using
    End Sub



    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If flag_abm = 1 Then 'ALTA
            nuevoGasto()
        ElseIf flag_abm = 2 Then 'UPDATE
            updateGasto()
        ElseIf flag_abm = 3 Then 'DELETE
            If MessageBox.Show("¿Estás seguro de que deseas eliminar el gasto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' Código para eliminar el cliente
                deleteGasto()
                'MsgBox("Gasto eliminado correctamente.")
                ' Aquí puedes ejecutar cualquier otra lógica que necesites después de eliminar el cliente
            End If

            'MsgBox("Eliminar Cliente")
            'deleteIngreso()
            Me.GroupBox1.Visible = False
        End If

        Me.dgvGastos.Focus()
        'Me.txtCodigo.Enabled = False
        'Me.txtMetodo.Enabled = False
        'Me.txtMonto.Enabled = False
        'Me.txtFecha.Enabled = False

    End Sub

    Private Sub deleteGasto()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete from gastos where idGasto = '" & wcp & "'"

        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarGastos()
            Me.txtCodigo.Clear()
            'Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.btnListo.Focus()
    End Sub

    Private Sub generarIdGasto() ' funcion para numero autoincrementar al agregar un ingreso nuevo
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "select max(idGasto) from gastos"
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()
        Try
            If dr.HasRows Then
                While dr.Read
                    If IsDBNull(dr(0)) Then
                        wid_juzgado = 1
                    Else
                        wid_juzgado = dr(0) + 1
                    End If
                End While
            Else
                MsgBox("hola")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.txtCodigo.Text = wid_juzgado
    End Sub

    Private Sub limpiar()
        Me.txtCodigo.Clear()
        Me.txtMetodo.Clear()
        Me.txtIdMetodo.Clear()
        Me.txtIdCategoria.Clear()
        Me.txtCategoria.Clear()
        Me.txtDescripcion.Clear()
        Me.txtIdTipo.Clear()
        Me.txtTipo.Clear()
        Me.txtMonto.Clear()
        Me.txtFecha.Clear()

    End Sub

    'FECHA
    Private Sub txtFecha_Click(sender As Object, e As EventArgs) Handles txtFecha.Click
        DateTimePicker1.Location = New Point(txtFecha.Location.X, txtFecha.Location.Y + txtFecha.Height)
        DateTimePicker1.Visible = True
        DateTimePicker1.BringToFront()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtFecha.Text = DateTimePicker1.Value.ToShortDateString()
        'DateTimePicker1.Visible = False
    End Sub

    Private Sub btnMetodo_Click(sender As Object, e As EventArgs) Handles btnMetodo.Click
        flag_where = 1

        Dim metodoForm As New frmMetodosTransaccion()
        metodoForm.Owner = Me ' Establecer el formulario principal como propietario
        metodoForm.ShowDialog()

        'Actualiza los campos en frmIngresos cuando frmMetodosTransaccion se cierra 
        txtIdMetodo.Text = metodoForm.IdMetodoSeleccionado
        txtMetodo.Text = metodoForm.MetodoSeleccionado

        Me.btnCategoria.Focus()
        flag_where = 0

    End Sub

    Private Sub btnTipo_Click(sender As Object, e As EventArgs) Handles btnTipo.Click
        flag_where = 1

        Dim metodoForm As New frmTipos()
        metodoForm.Owner = Me ' Establecer el formulario principal como propietario
        metodoForm.ShowDialog()

        'Actualiza los campos en frmIngresos cuando frmMetodosTransaccion se cierra 
        txtIdTipo.Text = metodoForm.IdTipoSeleccionado
        txtTipo.Text = metodoForm.TipoSeleccionado

        Me.txtDescripcion.Focus()
        flag_where = 0
    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        flag_where = 1

        Dim metodoForm As New frmCategorias()
        metodoForm.Owner = Me ' Establecer el formulario principal como propietario
        metodoForm.ShowDialog()

        'Actualiza los campos en frmIngresos cuando frmMetodosTransaccion se cierra 
        txtIdCategoria.Text = metodoForm.IdCategoriaSeleccionado
        txtCategoria.Text = metodoForm.CategoriaSeleccionado

        Me.btnTipo.Focus()

        flag_where = 0

    End Sub

    Private Sub frmGastoss_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verificar si se presiona la tecla F1
        If e.KeyCode = Keys.F1 Then
            ' Llamar al método btnNuevo_Click
            btnNuevo_Click(Nothing, Nothing)

            ' Establecer el foco en txtDescripcion
            'btnMetodo.Focus()

        ElseIf e.KeyCode = Keys.F2 Then
            ' Llamar al método btnNuevo_Click
            btnModificar_Click(Nothing, Nothing)

            ' Establecer el foco en txtDescripcion
            'btnMetodo.Focus()
        ElseIf e.KeyCode = Keys.F3 Then
            ' Llamar al método btnNuevo_Click
            btnEliminar_Click(Nothing, Nothing)
            'Me.btnListo.Focus()


        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub



    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        Dim newText As String = ""
        Dim validChars As String = "0123456789.," ' Caracteres válidos

        ' Filtrar los caracteres no permitidos y construir la nueva cadena de texto
        For Each c As Char In txtMonto.Text
            If validChars.Contains(c) Then
                newText &= c
            End If
        Next

        ' Actualizar el texto del TextBox solo si ha habido cambios
        If newText <> txtMonto.Text Then
            txtMonto.Text = newText
            ' Establecer el cursor al final del texto
            txtMonto.SelectionStart = newText.Length
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        ' Verificar si se presiona la tecla Enter
        If e.KeyCode = Keys.Enter Then
            ' Establecer el foco en el botón btnMonto
            txtMonto.Focus()
        End If
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        ' Verificar si se presionó la tecla Enter
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            ' Cambiar el foco al DateTimePicker
            e.Handled = True ' Evita que se produzca el "beep" al presionar Enter
            txtFecha.Focus()
        End If
    End Sub



    Private Sub txtFecha_Enter(sender As Object, e As EventArgs) Handles txtFecha.Enter
        ' Asignar la fecha seleccionada en el DateTimePicker al TextBox txtFecha
        txtFecha.Text = DateTimePicker1.Value.ToString("dd/MM/yyyy")
    End Sub

    Private Sub txtFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFecha.KeyDown
        ' Verificar si se presiona la tecla Enter
        If e.KeyCode = Keys.Enter Then
            ' Establecer el foco en el botón btnListo
            btnListo.Focus()
        End If
    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtTipo_TextChanged(sender As Object, e As EventArgs) Handles txtTipo.TextChanged
        If txtCategoria.Text <> "VARIOS" Then
            txtDescripcion.Text = "-" ' Establece el texto como "-"
            txtDescripcion.Enabled = False ' Deshabilita el control
        Else
            txtDescripcion.Text = "" ' Limpia el texto
            txtDescripcion.Enabled = True ' Habilita el control
        End If
        Me.txtMonto.Focus()
    End Sub

    'Titulo de cada columna en negrita
    Private Sub dgvGastos_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvGastos.CellPainting
        ' Verifica si es una celda de encabezado y si es la primera fila (que contiene los nombres de las columnas)
        If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
            ' Establece el formato de la fuente en negrita
            Dim headerFont As New Font(dgvGastos.Font, FontStyle.Bold)

            ' Dibuja el texto del encabezado con la fuente en negrita
            e.PaintBackground(e.CellBounds, True)
            e.Graphics.DrawString(e.Value.ToString(), headerFont, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5)
            e.Handled = True
        End If
    End Sub




    Private Sub txtEntrada1_TextChanged(sender As Object, e As EventArgs) Handles txtEntrada1.TextChanged
        Dim filtro As String = ""

        If rbMetodo.Checked Then
            filtro = $"FORMA LIKE '%{txtEntrada1.Text.Trim()}%'"
        ElseIf rbTipo.Checked Then
            filtro = $"TIPO LIKE '%{txtEntrada1.Text.Trim()}%'"
        ElseIf rbCategoria.Checked Then
            filtro = $"CATEGORÍA LIKE '%{txtEntrada1.Text.Trim()}%'"
        End If

        CType(dgvGastos.DataSource, DataTable).DefaultView.RowFilter = filtro
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        ' Convertir el texto a mayúsculas y asignarlo de nuevo al TextBox
        txtDescripcion.Text = txtDescripcion.Text.ToUpper()
        ' Colocar el cursor al final del texto
        txtDescripcion.SelectionStart = txtDescripcion.Text.Length
    End Sub
End Class