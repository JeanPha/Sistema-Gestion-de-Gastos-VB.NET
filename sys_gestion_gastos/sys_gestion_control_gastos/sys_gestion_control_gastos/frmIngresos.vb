Imports System.Data.SqlClient

Public Class frmIngresos
    Private Sub frmIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GroupBox1.Visible = False

        Me.Size = New Size(1135, 535)

        ' Asignar la fecha del DateTimePicker al TextBox al cargar el formulario


        'Me.ControlBox = False
        'Me.FormBorderStyle = FormBorderStyle.Sizable ' o Fixed3D, FixedDialog, FixedSingle
        Me.MaximizeBox = False ' Desactiva el botón de maximizar
        Me.MinimizeBox = False ' Desactiva el botón de minimizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Desactiva la capacidad de redimensionar verticalmente



        'Activar la propriedad keypreview
        Me.KeyPreview = True
        ' Configura el TextBox para aceptar solo números
        txtMonto.ShortcutsEnabled = False

        llenarIngresos()

        ConsultaSql.ActualizarSumaIngresos()
        lbIngresos.Text = ConsultaSql.sumaIngresos.ToString("C")

        ConsultaSql.ActualizarSumaGastos()
        lbGastos.Text = ConsultaSql.sumaGastos.ToString("C")

        ConsultaSql.ActualizarDiferencia()
        lbSaldos.Text = ConsultaSql.diferencia.ToString("C")

    End Sub

    Private Sub llenarIngresos()
        Dim sql As String = "select ingresos.idIngreso as 'CODIGO',
                                ingresos.montoIngresos as 'MONTO',
                                metodos_transaccion.nombreMetodo as 'METODO_TRANSACCÍON',
                                metodos_transaccion.idMetodo as 'CODIGO METODO',
                                ingresos.fecha as 'FECHA'                                
                            from ingresos
                            inner join metodos_transaccion on ingresos.idMetodo = metodos_transaccion.idMetodo"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("ingresos")
        adp.Fill(ds.Tables("ingresos"))
        Me.dgvExpedientes.DataSource = ds.Tables("ingresos")

        ' Ocultar la columna 'CODIGO METODO' (columna 3)
        Me.dgvExpedientes.Columns("CODIGO METODO").Visible = False
    End Sub



    'NUEVA MARCA
    Private Sub nuevoIngreso()
        Try
            If Me.txtCodigo.Text <> "" AndAlso Me.txtIdMetodo.Text <> "" AndAlso Me.txtMonto.Text <> "" Then
                ' Obtener la fecha del DateTimePicker como un objeto DateTime
                Dim fecha As DateTime = DateTimePicker1.Value

                ' Formatear la fecha como una cadena en el formato "yyyy-MM-dd"
                Dim fechaFormateada As String = fecha.ToString("yyyy-MM-dd")

                Dim sql As String = "INSERT INTO ingresos (idIngreso, idMetodo, montoIngresos, fecha) " &
                                "VALUES ('" & Me.txtCodigo.Text & "','" & Me.txtIdMetodo.Text & "','" & Me.txtMonto.Text & "', '" & fechaFormateada & "')"
                cmd.Connection = conexion.conexion
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarIngresos()
                limpiar()
            Else
                MsgBox("Debes completar todos los campos.", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error al intentar insertar el registro: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            'conexion.conexion.Close()
        End Try
    End Sub







    'UPDATE  expedientes 
    Private Sub updateIngresos()
        ' Cerrar la conexión si está abierta
        conexion.conexion.Close()

        Dim sql As String = "UPDATE ingresos SET
                        idIngreso = @idIngreso,
                        idMetodo = @idMetodo,
                        montoIngresos = @montoIngresos,
                        fecha = @fecha
                    WHERE idIngreso = @idIngresoParam"

        Using command As New SqlCommand(sql, conexion.conexion)
            ' Agregar parámetros
            command.Parameters.AddWithValue("@idIngreso", Me.txtCodigo.Text)
            command.Parameters.AddWithValue("@idMetodo", Me.txtIdMetodo.Text)

            ' Convertir y agregar el parámetro montoIngresos
            Dim monto As Decimal
            If Decimal.TryParse(Me.txtMonto.Text, monto) Then
                command.Parameters.AddWithValue("@montoIngresos", monto)
            Else
                ' Si no se puede convertir, se asigna DBNull
                command.Parameters.AddWithValue("@montoIngresos", DBNull.Value)
            End If

            ' Obtener la fecha del DateTimePicker
            Dim fecha As DateTime = DateTimePicker1.Value
            ' Formatear la fecha como una cadena en el formato "yyyy-MM-dd"
            Dim fechaFormateada As String = fecha.ToString("yyyy-MM-dd")
            ' Agregar el parámetro fecha
            command.Parameters.AddWithValue("@fecha", fechaFormateada)

            ' Agregar el parámetro idIngresoParam (para la cláusula WHERE)
            command.Parameters.AddWithValue("@idIngresoParam", Me.txtCodigo.Text)

            Try
                ' Abrir la conexión y ejecutar la consulta
                conexion.conexion.Open()
                command.ExecuteNonQuery()
                Console.Beep()
                llenarIngresos()
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










    'DELETE Localidades
    Private Sub deleteIngreso()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete from ingresos where idIngreso = '" & wcp & "'"

        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarIngresos()
            Me.txtCodigo.Clear()
            'Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.btnListo.Focus()
    End Sub

    Private Sub generarIdIngreso() ' funcion para numero autoincrementar al agregar un ingreso nuevo
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "select max(idIngreso) from ingresos"
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
        Me.txtIdMetodo.Clear()
        Me.txtMetodo.Clear()
        Me.txtMonto.Clear()
        Me.txtFecha.Clear()

    End Sub



    'FECHA
    Private Sub txtFecha_Click(sender As Object, e As EventArgs)
        DateTimePicker1.Location = New Point(txtFecha.Location.X, txtFecha.Location.Y + txtFecha.Height)
        DateTimePicker1.Visible = True
        DateTimePicker1.BringToFront()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtFecha.Text = DateTimePicker1.Value.ToShortDateString()
        'DateTimePicker1.Visible = False
    End Sub

    Private Sub txtFecha_Enter(sender As Object, e As EventArgs) Handles txtFecha.Enter
        ' Asignar la fecha seleccionada en el DateTimePicker al TextBox txtFecha
        txtFecha.Text = DateTimePicker1.Value.ToString("dd/MM/yyyy")
    End Sub


    Private Sub btnMetodo_Click(sender As Object, e As EventArgs) Handles btnMetodo.Click
        flag_where = 1

        Dim metodoForm As New frmMetodosTransaccion()
        metodoForm.Owner = Me ' Establecer el formulario principal como propietario
        metodoForm.ShowDialog()

        'Actualiza los campos en frmIngresos cuando frmMetodosTransaccion se cierra 
        txtIdMetodo.Text = metodoForm.IdMetodoSeleccionado
        txtMetodo.Text = metodoForm.MetodoSeleccionado

        Me.txtMonto.Focus()
        flag_where = 0

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

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        ' Verificar si se presionó la tecla Enter
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            ' Cambiar el foco al DateTimePicker
            e.Handled = True ' Evita que se produzca el "beep" al presionar Enter
            txtFecha.Focus()
        End If
    End Sub

    Private Sub txtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecha.KeyPress
        ' Verificar si se presionó la tecla Enter
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            ' Cambiar el foco al botón btnListo
            e.Handled = True ' Evita que se produzca el "beep" al presionar Enter
            btnListo.Focus()
        End If
    End Sub






    Private Sub frmIngresos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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



    'Private Sub txtFecha_Enter(sender As Object, e As EventArgs)
    '    ' Asignar la fecha seleccionada en el DateTimePicker al TextBox txtFecha
    '    txtFecha.Text = txtFecha.Value.ToString("dd/MM/yyyy")
    'End Sub

    Private Sub txtFecha_KeyDown(sender As Object, e As KeyEventArgs)
        ' Verificar si se presiona la tecla Enter
        If e.KeyCode = Keys.Enter Then
            ' Establecer el foco en el botón btnListo
            btnListo.Focus()
        End If
    End Sub


    Private Sub btnCerrar_Click_2(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txtEntrada1_TextChanged(sender As Object, e As EventArgs) Handles txtEntrada1.TextChanged
        Dim filtro As String = ""

        filtro = $"FORMA LIKE '%{txtEntrada1.Text.Trim()}%'"

        CType(dgvExpedientes.DataSource, DataTable).DefaultView.RowFilter = filtro
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.GroupBox1.Visible = True
        flag_abm = 1 'ALTA
        limpiar()
        Me.txtCodigo.Enabled = True
        Me.txtMetodo.Enabled = True
        Me.txtMonto.Enabled = True
        Me.txtFecha.Enabled = True
        Me.DateTimePicker1.Enabled = True
        Me.btnMetodo.Focus()

        generarIdIngreso()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvExpedientes.Rows.Count > 0 Then ' Verificar si hay filas en el DataGridView

            Me.GroupBox1.Visible = True
            flag_abm = 2 'UPDATE

            wcp = Me.dgvExpedientes.CurrentRow.Cells(0).Value
            Me.txtCodigo.Text = wcp

            Me.txtMonto.Text = Me.dgvExpedientes.CurrentRow.Cells(1).Value.ToString
            Me.txtMonto.Enabled = True
            Me.txtMonto.Focus()

            Me.txtMetodo.Text = Me.dgvExpedientes.CurrentRow.Cells(2).Value.ToString
            Me.txtMetodo.Enabled = True

            Me.txtIdMetodo.Text = Me.dgvExpedientes.CurrentRow.Cells(3).Value.ToString
            Me.txtIdMetodo.Enabled = True

            Me.txtFecha.Text = Me.dgvExpedientes.CurrentRow.Cells(4).Value.ToShortDateString()
            Me.txtFecha.Enabled = True
        Else
            MsgBox("No hay registros para modificar.", MsgBoxStyle.Information, "Información")
        End If

        Me.btnMetodo.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvExpedientes.Rows.Count > 0 Then ' Verificar si hay filas en el DataGridView

            Me.GroupBox1.Visible = True
            flag_abm = 3 'UPDATE

            wcp = Me.dgvExpedientes.CurrentRow.Cells(0).Value
            Me.txtCodigo.Text = wcp

            Me.txtMonto.Text = Me.dgvExpedientes.CurrentRow.Cells(1).Value.ToString
            Me.txtMonto.Enabled = True
            Me.txtMonto.Focus()

            Me.txtMetodo.Text = Me.dgvExpedientes.CurrentRow.Cells(2).Value.ToString
            Me.txtMetodo.Enabled = True

            Me.txtIdMetodo.Text = Me.dgvExpedientes.CurrentRow.Cells(3).Value.ToString
            Me.txtIdMetodo.Enabled = True

            Me.txtFecha.Text = Me.dgvExpedientes.CurrentRow.Cells(4).Value.ToShortDateString()
            Me.txtFecha.Enabled = True
        Else
            MsgBox("No hay registros para eliminar.", MsgBoxStyle.Information, "Información")
        End If
        Me.btnListo.Focus()
    End Sub

    'Titulo de cada columna FUENTE negrita
    Private Sub dgvExpedientes_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvExpedientes.CellPainting
        ' Verifica si es una celda de encabezado y si es la primera fila (que contiene los nombres de las columnas)
        If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
            ' Establece el formato de la fuente en negrita
            Dim headerFont As New Font(dgvExpedientes.Font, FontStyle.Bold)

            ' Dibuja el texto del encabezado con la fuente en negrita
            e.PaintBackground(e.CellBounds, True)
            e.Graphics.DrawString(e.Value.ToString(), headerFont, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5)
            e.Handled = True
        End If
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If flag_abm = 1 Then 'ALTA
            nuevoIngreso()
        ElseIf flag_abm = 2 Then 'UPDATE
            updateIngresos()
        ElseIf flag_abm = 3 Then 'DELETE
            If MessageBox.Show("¿Estás seguro de que deseas eliminar el Gasto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' Código para eliminar el cliente
                deleteIngreso()
                'MsgBox("Gasto eliminado correctamente.")
                ' Aquí puedes ejecutar cualquier otra lógica que necesites después de eliminar el cliente
            End If

            'MsgBox("Eliminar Cliente")
            'deleteIngreso()
        End If
        Me.GroupBox1.Visible = False
        Me.dgvExpedientes.Focus()
    End Sub

    Private Sub txtFecha_TextChanged(sender As Object, e As EventArgs) Handles txtFecha.TextChanged

    End Sub
End Class


