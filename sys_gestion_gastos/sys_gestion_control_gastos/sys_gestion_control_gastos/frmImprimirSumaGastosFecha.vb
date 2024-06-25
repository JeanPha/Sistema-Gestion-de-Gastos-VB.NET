Public Class frmImprimirSumaGastosFecha
    Private Sub frmImprimirSumaGastosFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        'Activar la propriedad keypreview
        Me.KeyPreview = True


        'TODO: esta línea de código carga datos en la tabla 'EJER5DataSet.spuConsultarExpedientesPorFecha' Puede moverla o quitarla según sea necesario.
        Me.SumaGastosPorFechasTableAdapter.Fill(Me.Sys_gestion_gastosDataSet.SumaGastosPorFechas, fechaInicio:=wid_fecha_inicio, fechaFin:=wid_fecha_fin)



        Me.ReportViewer1.RefreshReport()
    End Sub
End Class