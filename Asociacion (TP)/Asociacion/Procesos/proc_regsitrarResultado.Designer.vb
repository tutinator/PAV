<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proc_regsitrarResultado
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmd_cancelar_competencia = New System.Windows.Forms.Button()
        Me.cmd_buscarCompetencia = New System.Windows.Forms.Button()
        Me.lbl_especialidad = New System.Windows.Forms.Label()
        Me.lbl_año = New System.Windows.Forms.Label()
        Me.lbl_torneo = New System.Windows.Forms.Label()
        Me.cmb_año = New System.Windows.Forms.ComboBox()
        Me.cmb_especialidad = New System.Windows.Forms.ComboBox()
        Me.cmb_torneo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grid_competencias = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grid_inscripciones = New System.Windows.Forms.DataGridView()
        Me.cmd_guardar_resultado = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_apellido_nad = New System.Windows.Forms.TextBox()
        Me.txt_nombre_nad = New System.Windows.Forms.TextBox()
        Me.txt_cod_nad = New Asociacion.TextBoxv01()
        Me.cmd_cancelar_nad = New System.Windows.Forms.Button()
        Me.cmd_buscar_nad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_cod_nad = New System.Windows.Forms.ComboBox()
        Me.txt_tiempo = New Asociacion.TextBoxv01()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid_competencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid_inscripciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmd_cancelar_competencia)
        Me.GroupBox3.Controls.Add(Me.cmd_buscarCompetencia)
        Me.GroupBox3.Controls.Add(Me.lbl_especialidad)
        Me.GroupBox3.Controls.Add(Me.lbl_año)
        Me.GroupBox3.Controls.Add(Me.lbl_torneo)
        Me.GroupBox3.Controls.Add(Me.cmb_año)
        Me.GroupBox3.Controls.Add(Me.cmb_especialidad)
        Me.GroupBox3.Controls.Add(Me.cmb_torneo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(486, 86)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Competencia"
        '
        'cmd_cancelar_competencia
        '
        Me.cmd_cancelar_competencia.BackgroundImage = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_cancelar_competencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_cancelar_competencia.Location = New System.Drawing.Point(376, 51)
        Me.cmd_cancelar_competencia.Name = "cmd_cancelar_competencia"
        Me.cmd_cancelar_competencia.Size = New System.Drawing.Size(30, 30)
        Me.cmd_cancelar_competencia.TabIndex = 32
        Me.cmd_cancelar_competencia.UseVisualStyleBackColor = True
        '
        'cmd_buscarCompetencia
        '
        Me.cmd_buscarCompetencia.BackgroundImage = Global.Asociacion.My.Resources.Resources.buscar
        Me.cmd_buscarCompetencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscarCompetencia.Location = New System.Drawing.Point(333, 51)
        Me.cmd_buscarCompetencia.Name = "cmd_buscarCompetencia"
        Me.cmd_buscarCompetencia.Size = New System.Drawing.Size(30, 30)
        Me.cmd_buscarCompetencia.TabIndex = 31
        Me.cmd_buscarCompetencia.UseVisualStyleBackColor = True
        '
        'lbl_especialidad
        '
        Me.lbl_especialidad.AutoSize = True
        Me.lbl_especialidad.Location = New System.Drawing.Point(9, 54)
        Me.lbl_especialidad.Name = "lbl_especialidad"
        Me.lbl_especialidad.Size = New System.Drawing.Size(67, 13)
        Me.lbl_especialidad.TabIndex = 18
        Me.lbl_especialidad.Text = "Especialidad"
        '
        'lbl_año
        '
        Me.lbl_año.AutoSize = True
        Me.lbl_año.Location = New System.Drawing.Point(301, 22)
        Me.lbl_año.Name = "lbl_año"
        Me.lbl_año.Size = New System.Drawing.Size(26, 13)
        Me.lbl_año.TabIndex = 17
        Me.lbl_año.Text = "Año"
        '
        'lbl_torneo
        '
        Me.lbl_torneo.AutoSize = True
        Me.lbl_torneo.Location = New System.Drawing.Point(35, 27)
        Me.lbl_torneo.Name = "lbl_torneo"
        Me.lbl_torneo.Size = New System.Drawing.Size(41, 13)
        Me.lbl_torneo.TabIndex = 16
        Me.lbl_torneo.Text = "Torneo"
        '
        'cmb_año
        '
        Me.cmb_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año.FormattingEnabled = True
        Me.cmb_año.Location = New System.Drawing.Point(333, 19)
        Me.cmb_año.Name = "cmb_año"
        Me.cmb_año.Size = New System.Drawing.Size(73, 21)
        Me.cmb_año.TabIndex = 12
        '
        'cmb_especialidad
        '
        Me.cmb_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_especialidad.FormattingEnabled = True
        Me.cmb_especialidad.Location = New System.Drawing.Point(82, 51)
        Me.cmb_especialidad.Name = "cmb_especialidad"
        Me.cmb_especialidad.Size = New System.Drawing.Size(183, 21)
        Me.cmb_especialidad.TabIndex = 13
        '
        'cmb_torneo
        '
        Me.cmb_torneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_torneo.FormattingEnabled = True
        Me.cmb_torneo.Location = New System.Drawing.Point(82, 19)
        Me.cmb_torneo.Name = "cmb_torneo"
        Me.cmb_torneo.Size = New System.Drawing.Size(183, 21)
        Me.cmb_torneo.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grid_competencias)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 159)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Competencias Registradas"
        '
        'grid_competencias
        '
        Me.grid_competencias.AllowUserToAddRows = False
        Me.grid_competencias.AllowUserToDeleteRows = False
        Me.grid_competencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_competencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_competencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_competencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_competencias.Location = New System.Drawing.Point(7, 19)
        Me.grid_competencias.Name = "grid_competencias"
        Me.grid_competencias.ReadOnly = True
        Me.grid_competencias.RowHeadersVisible = False
        Me.grid_competencias.Size = New System.Drawing.Size(473, 134)
        Me.grid_competencias.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grid_inscripciones)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 367)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 197)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultados"
        '
        'grid_inscripciones
        '
        Me.grid_inscripciones.AllowUserToAddRows = False
        Me.grid_inscripciones.AllowUserToDeleteRows = False
        Me.grid_inscripciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_inscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_inscripciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_inscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_inscripciones.Location = New System.Drawing.Point(12, 19)
        Me.grid_inscripciones.Name = "grid_inscripciones"
        Me.grid_inscripciones.ReadOnly = True
        Me.grid_inscripciones.RowHeadersVisible = False
        Me.grid_inscripciones.Size = New System.Drawing.Size(468, 172)
        Me.grid_inscripciones.TabIndex = 2
        '
        'cmd_guardar_resultado
        '
        Me.cmd_guardar_resultado.BackgroundImage = Global.Asociacion.My.Resources.Resources.save
        Me.cmd_guardar_resultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_guardar_resultado.Location = New System.Drawing.Point(440, 54)
        Me.cmd_guardar_resultado.Name = "cmd_guardar_resultado"
        Me.cmd_guardar_resultado.Size = New System.Drawing.Size(40, 38)
        Me.cmd_guardar_resultado.TabIndex = 12
        Me.cmd_guardar_resultado.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tiempo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_tiempo)
        Me.GroupBox4.Controls.Add(Me.txt_apellido_nad)
        Me.GroupBox4.Controls.Add(Me.txt_nombre_nad)
        Me.GroupBox4.Controls.Add(Me.txt_cod_nad)
        Me.GroupBox4.Controls.Add(Me.cmd_cancelar_nad)
        Me.GroupBox4.Controls.Add(Me.cmd_buscar_nad)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.cmd_guardar_resultado)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cmb_cod_nad)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 269)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(486, 99)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Nadador"
        '
        'txt_apellido_nad
        '
        Me.txt_apellido_nad.Location = New System.Drawing.Point(235, 48)
        Me.txt_apellido_nad.Name = "txt_apellido_nad"
        Me.txt_apellido_nad.Size = New System.Drawing.Size(144, 20)
        Me.txt_apellido_nad.TabIndex = 34
        '
        'txt_nombre_nad
        '
        Me.txt_nombre_nad.Location = New System.Drawing.Point(53, 48)
        Me.txt_nombre_nad.Name = "txt_nombre_nad"
        Me.txt_nombre_nad.Size = New System.Drawing.Size(128, 20)
        Me.txt_nombre_nad.TabIndex = 34
        '
        'txt_cod_nad
        '
        Me.txt_cod_nad._BDdato = False
        Me.txt_cod_nad._BDnombreCampoTabla = ""
        Me.txt_cod_nad._BDvalor = ""
        Me.txt_cod_nad._descriptor_del_contenido = ""
        Me.txt_cod_nad._Gest_AnchoTexto = 0
        Me.txt_cod_nad._Gest_decimales = 0
        Me.txt_cod_nad._Gest_enteros = "0"
        Me.txt_cod_nad._Gest_mensajeError = ""
        Me.txt_cod_nad._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_cod_nad._Gest_ReadOnly = False
        Me.txt_cod_nad._Gest_TextoNegrita = False
        Me.txt_cod_nad._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_cod_nad._Gest_validar = True
        Me.txt_cod_nad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_cod_nad.Location = New System.Drawing.Point(53, 17)
        Me.txt_cod_nad.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cod_nad.Name = "txt_cod_nad"
        Me.txt_cod_nad.Size = New System.Drawing.Size(60, 20)
        Me.txt_cod_nad.TabIndex = 33
        Me.txt_cod_nad.ValidatingType = GetType(String)
        '
        'cmd_cancelar_nad
        '
        Me.cmd_cancelar_nad.BackgroundImage = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_cancelar_nad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_cancelar_nad.Location = New System.Drawing.Point(241, 15)
        Me.cmd_cancelar_nad.Name = "cmd_cancelar_nad"
        Me.cmd_cancelar_nad.Size = New System.Drawing.Size(30, 30)
        Me.cmd_cancelar_nad.TabIndex = 32
        Me.cmd_cancelar_nad.UseVisualStyleBackColor = True
        '
        'cmd_buscar_nad
        '
        Me.cmd_buscar_nad.BackgroundImage = Global.Asociacion.My.Resources.Resources.buscar
        Me.cmd_buscar_nad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_nad.Location = New System.Drawing.Point(190, 15)
        Me.cmd_buscar_nad.Name = "cmd_buscar_nad"
        Me.cmd_buscar_nad.Size = New System.Drawing.Size(30, 30)
        Me.cmd_buscar_nad.TabIndex = 31
        Me.cmd_buscar_nad.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Codigo"
        '
        'cmb_cod_nad
        '
        Me.cmb_cod_nad.FormattingEnabled = True
        Me.cmb_cod_nad.Location = New System.Drawing.Point(53, 15)
        Me.cmb_cod_nad.Name = "cmb_cod_nad"
        Me.cmb_cod_nad.Size = New System.Drawing.Size(60, 21)
        Me.cmb_cod_nad.TabIndex = 35
        Me.cmb_cod_nad.Visible = False
        '
        'txt_tiempo
        '
        Me.txt_tiempo._BDdato = False
        Me.txt_tiempo._BDnombreCampoTabla = ""
        Me.txt_tiempo._BDvalor = "  :  :"
        Me.txt_tiempo._descriptor_del_contenido = ""
        Me.txt_tiempo._Gest_AnchoTexto = 0
        Me.txt_tiempo._Gest_decimales = 0
        Me.txt_tiempo._Gest_enteros = "0"
        Me.txt_tiempo._Gest_mensajeError = ""
        Me.txt_tiempo._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_tiempo._Gest_ReadOnly = False
        Me.txt_tiempo._Gest_TextoNegrita = False
        Me.txt_tiempo._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_tiempo._Gest_validar = True
        Me.txt_tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_tiempo.Location = New System.Drawing.Point(412, 15)
        Me.txt_tiempo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_tiempo.Mask = "99:99:99"
        Me.txt_tiempo.Name = "txt_tiempo"
        Me.txt_tiempo.Size = New System.Drawing.Size(55, 20)
        Me.txt_tiempo.TabIndex = 37
        Me.txt_tiempo.ValidatingType = GetType(String)
        '
        'proc_regsitrarResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 576)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "proc_regsitrarResultado"
        Me.Text = "Regsitrar Resultado Competencia"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid_competencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grid_inscripciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_especialidad As System.Windows.Forms.Label
    Friend WithEvents lbl_año As System.Windows.Forms.Label
    Friend WithEvents lbl_torneo As System.Windows.Forms.Label
    Friend WithEvents cmb_año As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_torneo As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_cancelar_competencia As System.Windows.Forms.Button
    Friend WithEvents cmd_buscarCompetencia As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grid_competencias As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grid_inscripciones As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_guardar_resultado As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_nad As Asociacion.TextBoxv01
    Friend WithEvents cmd_cancelar_nad As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_nad As System.Windows.Forms.Button
    Friend WithEvents txt_apellido_nad As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_nad As System.Windows.Forms.TextBox
    Friend WithEvents cmb_cod_nad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_tiempo As Asociacion.TextBoxv01
End Class
