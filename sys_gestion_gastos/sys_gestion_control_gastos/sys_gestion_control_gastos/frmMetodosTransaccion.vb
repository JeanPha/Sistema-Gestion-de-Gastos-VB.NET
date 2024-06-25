Public Class frmMetodosTransaccion
    Private Sub frmMetodosTransaccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Me.Size = New Size(700, 500)
        End If

        llenarJuicios()
        Me.dgvMetodos.Focus()


        ConsultaSql.ActualizarSumaIngresos()
        lbIngresos.Text = ConsultaSql.sumaIngresos.ToString("C")

        ConsultaSql.ActualizarSumaGastos()
        lbGastos.Text = ConsultaSql.sumaGastos.ToString("C")

        ConsultaSql.ActualizarDiferencia()
        lbSaldos.Text = ConsultaSql.diferencia.ToString("C")
    End Sub
    Private Sub llenarJuicios()
        Dim sql As String = "select idMetodo as 'ID TRANSACCÍON' ,nombreMetodo as 'NOMBRE' from metodos_transaccion"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Juicios")
        adp.Fill(ds.Tables("Juicios"))
        Me.dgvMetodos.DataSource = ds.Tables("Juicios")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If Me.txtCodigo.Text <> "" Or Me.txtDescripcion.Text <> "" Then
            Me.txtCodigo.Clear()
            Me.txtDescripcion.Clear()
        End If

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
        Dim sql As String = "insert into metodos_transaccion values ('" & Me.txtCodigo.Text & "','" & Me.txtDescripcion.Text & "')"
        cmd.CommandText = sql

        'validacion
        If Me.txtCodigo.Text <> "" Then
            If Me.txtDescripcion.Text <> "" Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarJuicios()
                    generarIdJuicio()
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
            MsgBox("DESEAS ELIMINAR EL METODO DE TRANSACCÍON ")
            deleteJuicios()
            Me.txtCodigo.Text = ""
            Me.txtDescripcion.Text = ""
        End If
        Me.dgvMetodos.Focus()
        Me.txtCodigo.Enabled = False
        Me.txtDescripcion.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvMetodos.Rows.Count > 0 Then ' Verificar si hay filas en el DataGridView
            flag_abm = 2 'UPDATE
            wcp = Me.dgvMetodos.CurrentRow.Cells(0).Value
            Me.txtCodigo.Text = wcp
            Me.txtDescripcion.Text = Me.dgvMetodos.CurrentRow.Cells(1).Value.ToString
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
        Dim sql As String = "update metodos_transaccion set nombreMetodo = '" & Me.txtDescripcion.Text & "' where idMetodo = '" & wcp & "'"

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
        If dgvMetodos.Rows.Count > 0 Then ' Verificar si hay filas en el DataGridView
            flag_abm = 3 'DELETE
            wcp = Me.dgvMetodos.CurrentRow.Cells(0).Value
            Me.txtCodigo.Text = wcp
            Me.txtDescripcion.Text = Me.dgvMetodos.CurrentRow.Cells(1).Value.ToString
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
        Dim sql As String = "delete from metodos_transaccion where idMetodo = '" & wcp & "'"

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
        Dim sql As String = "select max(idMetodo) from metodos_transaccion"
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

    'Private Sub dgvMetodos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvMetodos.KeyDown
    '    If flag_where = 4 Then
    '        If e.KeyCode = Keys.Enter Then
    '            Dim selectedRow = dgvMetodos.CurrentRow
    '            If selectedRow IsNot Nothing Then
    '                Dim Metodo As String = selectedRow.Cells(1).Value.ToString()
    '                Dim NumExpediente As String = selectedRow.Cells(0).Value.ToString()
    '                Dim formIngresos As frmIngresos = Application.OpenForms("frmIngresos")
    '                If formIngresos IsNot Nothing Then
    '                    Dim textBoxExpediente As TextBox = formIngresos.Controls.Find("txtDescripcion", True).FirstOrDefault()
    '                    Dim textBoxNumExpediente As TextBox = formIngresos.Controls.Find("txtCodigo", True).FirstOrDefault()
    '                    If textBoxExpediente IsNot Nothing Then
    '                        textBoxExpediente.Text = Metodo
    '                        textBoxNumExpediente.Text = NumExpediente
    '                        Dim formExpedientes As frmMetodosTransaccion = Application.OpenForms("frmMetodosTransaccion")
    '                        If formExpedientes IsNot Nothing Then
    '                            formExpedientes.Close()
    '                            flag_where = 0
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub


    Public MetodoSeleccionado As String
    Public IdMetodoSeleccionado As String


    Private Sub dgvMetodos_keyDown(sender As Object, e As KeyEventArgs) Handles dgvMetodos.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Verifica si hay una fila seleccionada
            If dgvMetodos.SelectedRows.Count > 0 Then
                'captura los valores de las celdas 
                IdMetodoSeleccionado = dgvMetodos.SelectedRows(0).Cells(0).Value.ToString()
                MetodoSeleccionado = dgvMetodos.SelectedRows(0).Cells(1).Value.ToString()

                'Cierra el formulario actual 
                Me.Close()


            End If
        End If
    End Sub


    Private Sub frmMetodosTransaccion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Me.Owner IsNot Nothing AndAlso TypeOf Me.Owner Is frmIngresos Then
            Dim frmIngresos As frmIngresos = CType(Me.Owner, frmIngresos)
            frmIngresos.txtMonto.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        ' Convertir el texto a mayúsculas y asignarlo de nuevo al TextBox
        txtDescripcion.Text = txtDescripcion.Text.ToUpper()
        ' Colocar el cursor al final del texto
        txtDescripcion.SelectionStart = txtDescripcion.Text.Length
    End Sub

    Private Sub frmMetodosTransaccion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verificar si se presiona la tecla F1
        If e.KeyCode = Keys.F1 Then
            ' Llamar al método btnNuevo_Click
            btnNuevo_Click(Nothing, Nothing)

            'Me.txtDescripcion.Clear()
            ''Me.txtCodigo.Clear()

            ' Establecer el foco en txtDescripcion
            txtDescripcion.Focus()


        ElseIf e.KeyCode = Keys.F2 Then
            ' Llamar al método btnNuevo_Click
            btnModificar_Click(Nothing, Nothing)

            ' Establecer el foco en txtDescripcion
            txtDescripcion.Focus()
        ElseIf e.KeyCode = Keys.F3 Then
            ' Llamar al método btnNuevo_Click
            btnEliminar_Click(Nothing, Nothing)

            ' Establecer el foco en txtDescripcion
            Me.btnListo.Focus()

        ElseIf e.KeyCode = Keys.Escape Then
            ' Llamar al método btnNuevo_Click
            Me.Close()
        End If
    End Sub





    Private Sub btnCerrar_Click_2(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    'Titulo de cada columna FUENTE negrita
    Private Sub dgvMetodos_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvMetodos.CellPainting
        ' Verifica si es una celda de encabezado y si es la primera fila (que contiene los nombres de las columnas)
        If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
            ' Establece el formato de la fuente en negrita
            Dim headerFont As New Font(dgvMetodos.Font, FontStyle.Bold)

            ' Dibuja el texto del encabezado con la fuente en negrita
            e.PaintBackground(e.CellBounds, True)
            e.Graphics.DrawString(e.Value.ToString(), headerFont, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5)
            e.Handled = True
        End If
    End Sub
End Class