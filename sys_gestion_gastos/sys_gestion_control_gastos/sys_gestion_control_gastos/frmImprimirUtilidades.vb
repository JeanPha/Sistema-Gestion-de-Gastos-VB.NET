Public Class frmImprimirUtilidades
    Private Sub frmImprimirUtilidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        'Activar la propriedad keypreview
        Me.KeyPreview = True

        'TODO: esta línea de código carga datos en la tabla 'Sys_gestion_gastosDataSet.spUtilidad' Puede moverla o quitarla según sea necesario.
        Me.SpUtilidadTableAdapter.Fill(Me.Sys_gestion_gastosDataSet.spUtilidad)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class