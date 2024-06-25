Public Class frmFechasSumaGastos
    Private Sub frmFechasDetalleGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecer los TextBox como ReadOnly en el evento Load del formulario
        txtFechaInicio.ReadOnly = True
        txtFechaFin.ReadOnly = True

        'Me.WindowState = FormWindowState.Maximized
        Me.Size = New Size(850, 200)
        'Me.ControlBox = False
        'Me.FormBorderStyle = FormBorderStyle.Sizable ' o Fixed3D, FixedDialog, FixedSingle
        Me.MaximizeBox = False ' Desactiva el botón de maximizar
        Me.MinimizeBox = False ' Desactiva el botón de minimizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Desactiva la capacidad de redimensionar verticalmente

        ' Establecer la posición inicial del formulario en el centro de la pantalla
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub txtFechaInicio_Click(sender As Object, e As EventArgs) Handles txtFechaInicio.Click
        DateTimePicker1.Location = New Point(txtFechaInicio.Location.X, txtFechaInicio.Location.Y + txtFechaInicio.Height)
        DateTimePicker1.Visible = True
        DateTimePicker1.BringToFront()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtFechaInicio.Text = DateTimePicker1.Value.Date
        'DateTimePicker1.Visible = False
    End Sub
    Private Sub txtFechaFin_Click(sender As Object, e As EventArgs) Handles txtFechaFin.Click
        DateTimePicker2.Location = New Point(txtFechaFin.Location.X, txtFechaFin.Location.Y + txtFechaFin.Height)
        DateTimePicker2.Visible = True
        DateTimePicker2.BringToFront()
    End Sub
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        txtFechaFin.Text = DateTimePicker2.Value.Date
        'DateTimePicker2.Visible = False
    End Sub

    Private Sub btnIngresosPorMetodo_Click(sender As Object, e As EventArgs) Handles btnIngresosPorMetodo.Click
        If Me.txtFechaInicio.Text = "" Or Me.txtFechaFin.Text = "" Then
            MsgBox("POR FAVOR LLENAR LOS CAMPOS ")
        Else
            wid_fecha_inicio = Me.txtFechaInicio.Text
            wid_fecha_fin = Me.txtFechaFin.Text
            Dim frm As New frmImprimirSumaGastosFecha
            frm.ShowDialog()
            Me.txtFechaInicio.Text = ""
            Me.txtFechaFin.Text = ""
            Me.Close()
        End If
    End Sub
End Class