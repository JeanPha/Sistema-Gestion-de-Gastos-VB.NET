Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        'Activar la propriedad keypreview
        Me.KeyPreview = True

        


        ConsultaSql.ActualizarSumaIngresos()
        lbIngresos.Text = ConsultaSql.sumaIngresos.ToString("C")

        ConsultaSql.ActualizarSumaGastos()
        lbGastos.Text = ConsultaSql.sumaGastos.ToString("C")

        ConsultaSql.ActualizarDiferencia()
        lbSaldos.Text = ConsultaSql.diferencia.ToString("C")


    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        Dim frm As New frmCategorias
        frm.ShowDialog()
    End Sub

    Private Sub btnMetodos_Click(sender As Object, e As EventArgs) Handles btnMetodos.Click
        Dim frm As New frmMetodosTransaccion
        frm.ShowDialog()
    End Sub

    Private Sub btnTipos_Click(sender As Object, e As EventArgs) Handles btnTipos.Click
        Dim frm As New frmTipos
        frm.ShowDialog()

    End Sub

    Private Sub btnIngresos_Click(sender As Object, e As EventArgs) Handles btnIngresos.Click
        Dim frm As New frmIngresos
        frm.ShowDialog()

    End Sub

    Private Sub btnGastos_Click(sender As Object, e As EventArgs) Handles btnGastos.Click
        Dim frm As New frmGastos
        frm.ShowDialog()

    End Sub


    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verificar si se presiona la tecla F1
        If e.KeyCode = Keys.F1 Then
            ' Llamar al método btnNuevo_Click
            btnCategoria_Click(Nothing, Nothing)


        ElseIf e.KeyCode = Keys.F2 Then
            ' Llamar al método btnNuevo_Click
            btnMetodos_Click(Nothing, Nothing)


        ElseIf e.KeyCode = Keys.F3 Then
            ' Llamar al método btnNuevo_Click
            btnTipos_Click(Nothing, Nothing)



        ElseIf e.KeyCode = Keys.F4 Then
            ' Llamar al método btnNuevo_Click
            btnIngresos_Click(Nothing, Nothing)



        ElseIf e.KeyCode = Keys.F5 Then
            ' Llamar al método btnNuevo_Click
            btnGastos_Click(Nothing, Nothing)

        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub



    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub ReporteUtilidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteUtilidadesToolStripMenuItem.Click
        Dim frm As New frmImprimirUtilidades
        frm.ShowDialog()
    End Sub

    'Private Sub ReporteIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    Dim frm As New frmFechasIngresosPorMetodo
    '    frm.ShowDialog()
    'End Sub



    Private Sub ReporteIngresosPorForma_Click(sender As Object, e As EventArgs) Handles ReporteIngresosPorForma.Click
        Dim frm As New frmFechasIngresosPorMetodo
        frm.ShowDialog()
    End Sub



    Private Sub btnActualizar_Click_1(sender As Object, e As EventArgs) Handles btnActualizar.Click
        ' Actualizar las sumas de ingresos, gastos y la diferencia
        ConsultaSql.ActualizarSumaIngresos()
        ConsultaSql.ActualizarSumaGastos()
        ConsultaSql.ActualizarDiferencia()

        ' Mostrar los resultados actualizados en los controles de texto
        lbIngresos.Text = ConsultaSql.sumaIngresos.ToString("C")
        lbGastos.Text = ConsultaSql.sumaGastos.ToString("C")
        lbSaldos.Text = ConsultaSql.diferencia.ToString("C")
    End Sub

    Private Sub ReporteGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteGastosToolStripMenuItem.Click
        Dim frm As New frmFechasDetalleGastos
        frm.ShowDialog()
    End Sub

    Private Sub ReporteSumaIngresosPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteSumaIngresosPorFechaToolStripMenuItem.Click
        Dim frm As New frmFechasSumaIngresos
        frm.ShowDialog()
    End Sub

    Private Sub ReporteSumaGastosPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteSumaGastosPorFechaToolStripMenuItem.Click
        Dim frm As New frmFechasSumaGastos
        frm.ShowDialog()
    End Sub
End Class