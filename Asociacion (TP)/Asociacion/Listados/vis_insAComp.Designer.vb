<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vis_insAComp
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_generar = New System.Windows.Forms.Button()
        Me.cmb_espe = New System.Windows.Forms.ComboBox()
        Me.cmb_año = New System.Windows.Forms.ComboBox()
        Me.cmb_torneo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rv_insAComp = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.natacionDataSet = New WindowsApplication1.natacionDataSet()
        Me.InscriptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.natacionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InscriptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_generar)
        Me.GroupBox1.Controls.Add(Me.cmb_espe)
        Me.GroupBox1.Controls.Add(Me.cmb_año)
        Me.GroupBox1.Controls.Add(Me.cmb_torneo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 82)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección Competencia"
        '
        'cmd_generar
        '
        Me.cmd_generar.Location = New System.Drawing.Point(301, 47)
        Me.cmd_generar.Name = "cmd_generar"
        Me.cmd_generar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generar.TabIndex = 2
        Me.cmd_generar.Text = "Generar"
        Me.cmd_generar.UseVisualStyleBackColor = True
        '
        'cmb_espe
        '
        Me.cmb_espe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_espe.FormattingEnabled = True
        Me.cmb_espe.Location = New System.Drawing.Point(79, 47)
        Me.cmb_espe.Name = "cmb_espe"
        Me.cmb_espe.Size = New System.Drawing.Size(155, 21)
        Me.cmb_espe.TabIndex = 1
        '
        'cmb_año
        '
        Me.cmb_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año.FormattingEnabled = True
        Me.cmb_año.Location = New System.Drawing.Point(301, 19)
        Me.cmb_año.Name = "cmb_año"
        Me.cmb_año.Size = New System.Drawing.Size(57, 21)
        Me.cmb_año.TabIndex = 1
        '
        'cmb_torneo
        '
        Me.cmb_torneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_torneo.FormattingEnabled = True
        Me.cmb_torneo.Location = New System.Drawing.Point(79, 20)
        Me.cmb_torneo.Name = "cmb_torneo"
        Me.cmb_torneo.Size = New System.Drawing.Size(155, 21)
        Me.cmb_torneo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Año"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Especialidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Torneo"
        '
        'rv_insAComp
        '
        ReportDataSource1.Name = "ds_insAcomp"
        ReportDataSource1.Value = Me.InscriptosBindingSource
        Me.rv_insAComp.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_insAComp.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report1.rdlc"
        Me.rv_insAComp.Location = New System.Drawing.Point(12, 101)
        Me.rv_insAComp.Name = "rv_insAComp"
        Me.rv_insAComp.Size = New System.Drawing.Size(642, 292)
        Me.rv_insAComp.TabIndex = 3
        '
        'natacionDataSet
        '
        Me.natacionDataSet.DataSetName = "natacionDataSet"
        Me.natacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InscriptosBindingSource
        '
        Me.InscriptosBindingSource.DataMember = "Inscriptos"
        Me.InscriptosBindingSource.DataSource = Me.natacionDataSet
        '
        'vis_insAComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 353)
        Me.Controls.Add(Me.rv_insAComp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "vis_insAComp"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.natacionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InscriptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_generar As System.Windows.Forms.Button
    Friend WithEvents cmb_espe As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_año As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_torneo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rv_insAComp As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents InscriptosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents natacionDataSet As WindowsApplication1.natacionDataSet

End Class
