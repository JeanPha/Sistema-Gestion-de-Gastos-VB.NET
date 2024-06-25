<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnImprimirSumaIngresos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Sys_gestion_gastosDataSet = New sys_gestion_control_gastos.sys_gestion_gastosDataSet()
        Me.SumaIngresosPorFechasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SumaIngresosPorFechasTableAdapter = New sys_gestion_control_gastos.sys_gestion_gastosDataSetTableAdapters.SumaIngresosPorFechasTableAdapter()
        CType(Me.Sys_gestion_gastosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SumaIngresosPorFechasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSetSumaIngresosFecha"
        ReportDataSource2.Value = Me.SumaIngresosPorFechasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sys_gestion_control_gastos.rptSumaIngresosFechas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Sys_gestion_gastosDataSet
        '
        Me.Sys_gestion_gastosDataSet.DataSetName = "sys_gestion_gastosDataSet"
        Me.Sys_gestion_gastosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SumaIngresosPorFechasBindingSource
        '
        Me.SumaIngresosPorFechasBindingSource.DataMember = "SumaIngresosPorFechas"
        Me.SumaIngresosPorFechasBindingSource.DataSource = Me.Sys_gestion_gastosDataSet
        '
        'SumaIngresosPorFechasTableAdapter
        '
        Me.SumaIngresosPorFechasTableAdapter.ClearBeforeFill = True
        '
        'frnImprimirSumaIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frnImprimirSumaIngresos"
        Me.Text = "REPORTE SUMA INGRESOS POR FECHA"
        CType(Me.Sys_gestion_gastosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SumaIngresosPorFechasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SumaIngresosPorFechasBindingSource As BindingSource
    Friend WithEvents Sys_gestion_gastosDataSet As sys_gestion_gastosDataSet
    Friend WithEvents SumaIngresosPorFechasTableAdapter As sys_gestion_gastosDataSetTableAdapters.SumaIngresosPorFechasTableAdapter
End Class
