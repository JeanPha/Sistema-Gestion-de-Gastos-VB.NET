Public Class frmTipos
    Private Sub frmTipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.WindowState = FormWindowState.Maximized
        Me.Size = New Size(790, 500)
        'Me.ControlBox = False
        'Me.FormBorderStyle = FormBorderStyle.Sizable ' o Fixed3D, FixedDialog, FixedSingle
        Me.MaximizeBox = False ' Desactiva el botón de maximizar
        Me.MinimizeBox = False ' Desactiva el botón de minimizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Desactiva la capacidad de redimensionar verticalmente
        'Me.ControlBox = False

        Me.btnCerrar.Visible = False


        'Activar la propriedad keypreview
        Me.KeyPreview = True


        If flag_where = 1 Or flag_where = 2 Then
            Me.Panel4.Visible = False
            Me.Panel3.Visible = False
        End If

        llenarJuicios()
        Me.dgvTipos.Focus()

        ConsultaSql.ActualizarSumaIngresos()
        lbIngresos.Text = ConsultaSql.sumaIngresos.ToString("C")

        ConsultaSql.ActualizarSumaGastos()
        lbGastos.Text = ConsultaSql.sumaGastos.ToString("C")

        ConsultaSql.ActualizarDiferencia()
        lbSaldos.Text = ConsultaSql.diferencia.ToString("C")
    End Sub
    Private Sub llenarJuicios()
        Dim sql As String = "select idTipo as 'ID TIPO TRANSACCÍON' ,nombreTipo as NOMBRE  from tipos_transaccion"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Juicios")
        adp.Fill(ds.Tables("Juicios"))
        Me.dgvTipos.DataSource = ds.Tables("Juicios")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        Me.txtCodigo.Clear()
        Me.txtDescripcion.Clear()

        generarIdJuicio()

        flag_abm = 1 'ALTA
        Me.txtCodigo.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtDescripcion.Focus()

    End Sub
    'NUEVA Marca
    Private Sub nuevoJuicio()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "insert into tipos_transaccion values ('" & Me.txtCodigo.Text & "','" & Me.txtDescripcion.Text & "')"
        cmd.CommandText = sql

        'validacion
        If Me.txtCodigo.Text <> "" Then
            If Me.txtDescripcion.Text <> "" Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarJuicios()
                    Me.txtCodigo.Clear()
                    Me.txtDescripcion.Clear()
                    'Me.btnListo.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo NOMBRE no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                Me.txtDescripcion.Focus()
            End If
        Else
            MsgBox("El campo CODIGO no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtCodigo.Focus()
        End If
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If flag_abm = 1 Then 'ALTA
            nuevoJuicio()
        ElseIf flag_abm = 2 Then 'UPDATE
            updateJuicios()
        ElseIf flag_abm = 3 Then 'DELETE
            MsgBox("DESEAS ELIMINAR EL TIPO DE TRANSACCÍON ")
            deleteJuicios()
            Me.txtCodigo.Text = ""
            Me.txtDescripcion.Text = ""
        End If
        Me.dgvTipos.Focus()
        Me.txtCodigo.Enabled = False
        Me.txtDescripcion.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvTipos.Rows.Count > 0 Then ' Verificar si hay filas en el DataGridView
            flag_abm = 2 'UPDATE
            wcp = Me.dgvTipos.CurrentRow.Cells(0).Value
            Me.txtCodigo.Text = wcp
            Me.txtDescripcion.Text = Me.dgvTipos.CurrentRow.Cells(1).Value.ToString
            Me.txtDescripcion.Enabled = True
        Else
            MsgBox("No hay registros para modificar.", MsgBoxStyle.Information, "Información")
        End If
        Me.txtDescripcion.Focus()
    End Sub
    'UPDATE  Localidades
    Private Sub updateJuicios()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update tipos_transaccion set nombreTipo = '" & Me.txtDescripcion.Text & "' where idTipo = '" & wcp & "'"

        cmd.CommandText = sql
        'validacion
        If Me.txtDescripcion.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarJuicios()
                Me.txtCodigo.Clear()
                Me.txtDescripcion.Clear()
                'Me.btnListo.Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("El campo NOMBRE no puede estar vacio.", MsgBoxStyle.Critical, "Error")
            Me.txtDescripcion.Focus()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvTipos.Rows.Count > 0 Then ' Verificar si hay filas en el DataGridView
            flag_abm = 3 'DELETE
            wcp = Me.dgvTipos.CurrentRow.Cells(0).Value
            Me.txtCodigo.Text = wcp
            Me.txtDescripcion.Text = Me.dgvTipos.CurrentRow.Cells(1).Value.ToString
            Me.txtDescripcion.Enabled = True
        Else
            MsgBox("No hay registros para modificar.", MsgBoxStyle.Information, "Información")
        End If
        Me.btnListo.Focus()
    End Sub
    'DELETE Localidades
    Private Sub deleteJuicios()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete from tipos_transaccion where idTipo = '" & wcp & "'"

        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarJuicios()
            Me.txtCodigo.Clear()
            'Me.btnListo.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.btnListo.Focus()
    End Sub
    'Private Sub dgvJuicios_Keydown(sender As Object, e As KeyEventArgs) Handles dgvJuicios.KeyDown
    '    If flag_where = 1 Then
    '        If e.KeyCode = Keys.Enter Then
    '            Dim selectedRow = dgvJuicios.CurrentRow
    '            If selectedRow IsNot Nothing Then
    '                Dim Juicio As String = selectedRow.Cells(1).Value.ToString()
    '                Dim NroJuicio As String = selectedRow.Cells(0).Value.ToString()
    '                Dim formExpedientes As frmExpedientes = Application.OpenForms("frmExpedientes")
    '                If formExpedientes IsNot Nothing Then
    '                    Dim textBoxJuicio As TextBox = formExpedientes.Controls.Find("txtJuicio", True).FirstOrDefault()
    '                    Dim textBoxNroJuicio As TextBox = formExpedientes.Controls.Find("txtNroJuicio", True).FirstOrDefault()
    '                    If textBoxJuicio IsNot Nothing Then
    '                        textBoxJuicio.Text = Juicio
    '                        textBoxNroJuicio.Text = NroJuicio
    '                        Dim formJuicios As frmJuicios = Application.OpenForms("frmJuicios")
    '                        If formJuicios IsNot Nothing Then
    '                            formJuicios.Close()
    '                            flag_where = 0
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If

    '    If flag_where = 2 Then
    '        If e.KeyCode = Keys.Enter Then
    '            Dim selectedRow = dgvJuicios.CurrentRow
    '            If selectedRow IsNot Nothing Then
    '                Dim Juicio As String = selectedRow.Cells(1).Value.ToString()
    '                Dim formClientesExpediente As frmClientesExpediente = Application.OpenForms("frmClientesExpediente")
    '                If formClientesExpediente IsNot Nothing Then
    '                    Dim textBoxJuicio As TextBox = formClientesExpediente.Controls.Find("txtJuicio", True).FirstOrDefault()
    '                    If textBoxJuicio IsNot Nothing Then
    '                        textBoxJuicio.Text = Juicio
    '                        Dim formJuicios As frmJuicios = Application.OpenForms("frmJuicios")
    '                        If formJuicios IsNot Nothing Then
    '                            formJuicios.Close()
    '                            flag_where = 0
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If


    'End Sub
    Private Sub generarIdJuicio() ' funcion para numero autoincrementar al agregar un juicio nuevo
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "select max(idTipo) from tipos_transaccion"
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()
        Try
            If dr.HasRows Then
                While dr.Read
                    If IsDBNull(dr(0)) Then
                        wid_juicio = 1
                    Else
                        wid_juicio = dr(0) + 1
                    End If
                End While
            Else
                MsgBox("hola")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.txtCodigo.Text = wid_juicio
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True ' Evita que se produzca el "beep" al presionar Enter
            txtDescripcion.Focus()
        End If
    End Sub

    Private Sub txt_Descripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Evita que se procese la tecla Enter por defecto
            btnListo.Focus() ' Cambia el foco al botón btnListo
        End If
    End Sub

    Public IdTipoSeleccionado As String
    Public TipoSeleccionado As String


    Private Sub dgvTipos_keyDown(sender As Object, e As KeyEventArgs) Handles dgvTipos.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Verifica si hay una fila seleccionada
            If dgvTipos.SelectedRows.Count > 0 Then
                'captura los valores de las celdas 
                IdTipoSeleccionado = dgvTipos.SelectedRows(0).Cells(0).Value.ToString()
                TipoSeleccionado = dgvTipos.SelectedRows(0).Cells(1).Value.ToString()

                'Cierra el formulario actual 
                Me.Close()


            End If
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        ' Convertir el texto a mayúsculas y asignarlo de nuevo al TextBox
        txtDescripcion.Text = txtDescripcion.Text.ToUpper()
        ' Colocar el cursor al final del texto
        txtDescripcion.SelectionStart = txtDescripcion.Text.Length
    End Sub

    Private Sub frmTiposTransaccion(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            ' Llamar al método btnNuevo_Click
            btnNuevo_Click(Nothing, Nothing)

            ' Establecer el foco en txtDescripcion
            txtDescripcion.Focus()
            Me.txtDescripcion.Clear()

        ElseIf e.KeyCode = Keys.F2 Then
            ' Llamar al método btnModificar_Click   
            btnModificar_Click(Nothing, Nothing)

            ' Establecer el foco en txtDescripcion
            txtDescripcion.Focus()
        ElseIf e.KeyCode = Keys.F3 Then
            ' Llamar al método btnEliminar_Click   
            btnEliminar_Click(Nothing, Nothing)

            ' Establecer el foco en txtDescripcion
            Me.btnListo.Focus()

        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    'Titulo de cada columna FUENTE negrita
    Private Sub dgvTipos_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvTipos.CellPainting
        ' Verifica si es una celda de encabezado y si es la primera fila (que contiene los nombres de las columnas)
        If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
            ' Establece el formato de la fuente en negrita
            Dim headerFont As New Font(dgvTipos.Font, FontStyle.Bold)

            ' Dibuja el texto del encabezado con la fuente en negrita
            e.PaintBackground(e.CellBounds, True)
            e.Graphics.DrawString(e.Value.ToString(), headerFont, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5)
            e.Handled = True
        End If
    End Sub


End Class