<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirUtilidades
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SpUtilidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sys_gestion_gastosDataSet = New sys_gestion_control_gastos.sys_gestion_gastosDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SpUtilidadTableAdapter = New sys_gestion_control_gastos.sys_gestion_gastosDataSetTableAdapters.spUtilidadTableAdapter()
        CType(Me.SpUtilidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sys_gestion_gastosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpUtilidadBindingSource
        '
        Me.SpUtilidadBindingSource.DataMember = "spUtilidad"
        Me.SpUtilidadBindingSource.DataSource = Me.Sys_gestion_gastosDataSet
        '
        'Sys_gestion_gastosDataSet
        '
        Me.Sys_gestion_gastosDataSet.DataSetName = "sys_gestion_gastosDataSet"
        Me.Sys_gestion_gastosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetSaldo"
        ReportDataSource1.Value = Me.SpUtilidadBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sys_gestion_control_gastos.rptSaldo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'SpUtilidadTableAdapter
        '
        Me.SpUtilidadTableAdapter.ClearBeforeFill = True
        '
        'frmImprimirUtilidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmImprimirUtilidades"
        Me.Text = "REPORTE SALDO"
        CType(Me.SpUtilidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sys_gestion_gastosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sys_gestion_gastosDataSet As sys_gestion_gastosDataSet
    Friend WithEvents SpUtilidadBindingSource As BindingSource
    Friend WithEvents SpUtilidadTableAdapter As sys_gestion_gastosDataSetTableAdapters.spUtilidadTableAdapter
End Class
