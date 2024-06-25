<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirDetalleGastos
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
        Me.DetallesGastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sys_gestion_gastosDataSet = New sys_gestion_control_gastos.sys_gestion_gastosDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DetallesGastosTableAdapter = New sys_gestion_control_gastos.sys_gestion_gastosDataSetTableAdapters.DetallesGastosTableAdapter()
        CType(Me.DetallesGastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sys_gestion_gastosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DetallesGastosBindingSource
        '
        Me.DetallesGastosBindingSource.DataMember = "DetallesGastos"
        Me.DetallesGastosBindingSource.DataSource = Me.Sys_gestion_gastosDataSet
        '
        'Sys_gestion_gastosDataSet
        '
        Me.Sys_gestion_gastosDataSet.DataSetName = "sys_gestion_gastosDataSet"
        Me.Sys_gestion_gastosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetDetalleGastos"
        ReportDataSource1.Value = Me.DetallesGastosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sys_gestion_control_gastos.rptDetalleGastos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1339, 648)
        Me.ReportViewer1.TabIndex = 0
        '
        'DetallesGastosTableAdapter
        '
        Me.DetallesGastosTableAdapter.ClearBeforeFill = True
        '
        'frmImprimirDetalleGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 648)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmImprimirDetalleGastos"
        Me.Text = "REPORTE DETALLE GASTOS"
        CType(Me.DetallesGastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sys_gestion_gastosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DetallesGastosBindingSource As BindingSource
    Friend WithEvents Sys_gestion_gastosDataSet As sys_gestion_gastosDataSet
    Friend WithEvents DetallesGastosTableAdapter As sys_gestion_gastosDataSetTableAdapters.DetallesGastosTableAdapter
End Class
