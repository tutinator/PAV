<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listado_clubes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rv_listadoClubes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bs_listadoClubes = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds_listadoClubes = New Asociacion.ds_listadoClubes()
        CType(Me.bs_listadoClubes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_listadoClubes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rv_listadoClubes
        '
        Me.rv_listadoClubes.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ds_lstClubes"
        ReportDataSource1.Value = Me.bs_listadoClubes
        Me.rv_listadoClubes.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_listadoClubes.LocalReport.ReportEmbeddedResource = "Asociacion.rep_listadoClubes.rdlc"
        Me.rv_listadoClubes.Location = New System.Drawing.Point(0, 0)
        Me.rv_listadoClubes.Name = "rv_listadoClubes"
        Me.rv_listadoClubes.Size = New System.Drawing.Size(892, 400)
        Me.rv_listadoClubes.TabIndex = 0
        '
        'ds_listadoClubes
        '
        Me.ds_listadoClubes.DataSetName = "ds_listadoClubes"
        Me.ds_listadoClubes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'listado_clubes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 400)
        Me.Controls.Add(Me.rv_listadoClubes)
        Me.Name = "listado_clubes"
        Me.Text = "Listado de Clubes Asociados"
        CType(Me.bs_listadoClubes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_listadoClubes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rv_listadoClubes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ds_listadoClubes As Asociacion.ds_listadoClubes
    Friend WithEvents bs_listadoClubes As System.Windows.Forms.BindingSource
End Class
