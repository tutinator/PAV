<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoNadadoresXClub
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
        Me.cbo_clubes = New System.Windows.Forms.ComboBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_vertodo = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ds_nadxclub = New Asociacion.ds_nadxclub()
        Me.NadadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NadadoresTableAdapter = New Asociacion.ds_nadxclubTableAdapters.NadadoresTableAdapter()
        Me.DsnadxclubBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ds_nadxclub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsnadxclubBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbo_clubes
        '
        Me.cbo_clubes.FormattingEnabled = True
        Me.cbo_clubes.Location = New System.Drawing.Point(167, 16)
        Me.cbo_clubes.Name = "cbo_clubes"
        Me.cbo_clubes.Size = New System.Drawing.Size(148, 21)
        Me.cbo_clubes.TabIndex = 0
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(321, 15)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 1
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_vertodo
        '
        Me.cmd_vertodo.Location = New System.Drawing.Point(449, 15)
        Me.cmd_vertodo.Name = "cmd_vertodo"
        Me.cmd_vertodo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_vertodo.TabIndex = 1
        Me.cmd_vertodo.Text = "Ver todo"
        Me.cmd_vertodo.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ds_nadadoresxclub"
        ReportDataSource1.Value = Me.NadadoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Asociacion.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 60)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(690, 405)
        Me.ReportViewer1.TabIndex = 2
        '
        'ds_nadxclub
        '
        Me.ds_nadxclub.DataSetName = "ds_nadxclub"
        Me.ds_nadxclub.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NadadoresBindingSource
        '
        Me.NadadoresBindingSource.DataMember = "Nadadores"
        Me.NadadoresBindingSource.DataSource = Me.ds_nadxclub
        '
        'NadadoresTableAdapter
        '
        Me.NadadoresTableAdapter.ClearBeforeFill = True
        '
        'DsnadxclubBindingSource
        '
        Me.DsnadxclubBindingSource.DataSource = Me.ds_nadxclub
        Me.DsnadxclubBindingSource.Position = 0
        '
        'ListadoNadadoresXClub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 477)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.cmd_vertodo)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cbo_clubes)
        Me.Name = "ListadoNadadoresXClub"
        Me.Text = "Listado nadadores por club"
        CType(Me.ds_nadxclub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsnadxclubBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbo_clubes As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_vertodo As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents NadadoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ds_nadxclub As Asociacion.ds_nadxclub
    Friend WithEvents NadadoresTableAdapter As Asociacion.ds_nadxclubTableAdapters.NadadoresTableAdapter
    Friend WithEvents DsnadxclubBindingSource As System.Windows.Forms.BindingSource
End Class
