<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proc_Registro_resultado
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_torneo = New System.Windows.Forms.TextBox()
        Me.txt_año = New System.Windows.Forms.TextBox()
        Me.txt_especialidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_codTorneo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grid_competencias = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_tiempo = New Asociacion.TextBoxv01()
        Me.cmb_apellido = New System.Windows.Forms.ComboBox()
        Me.txt_codNadador = New Asociacion.TextBoxv01()
        Me.lbl_codNadador = New System.Windows.Forms.Label()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.grp_inscripciones = New System.Windows.Forms.GroupBox()
        Me.grid_inscripciones = New System.Windows.Forms.DataGridView()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grid_competencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.grp_inscripciones.SuspendLayout()
        CType(Me.grid_inscripciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_torneo)
        Me.GroupBox1.Controls.Add(Me.txt_año)
        Me.GroupBox1.Controls.Add(Me.txt_especialidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_codTorneo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 58)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Competencia Seleccionada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(392, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Especialidad"
        '
        'txt_torneo
        '
        Me.txt_torneo.Enabled = False
        Me.txt_torneo.Location = New System.Drawing.Point(56, 22)
        Me.txt_torneo.Name = "txt_torneo"
        Me.txt_torneo.Size = New System.Drawing.Size(191, 20)
        Me.txt_torneo.TabIndex = 2
        '
        'txt_año
        '
        Me.txt_año.Enabled = False
        Me.txt_año.Location = New System.Drawing.Point(286, 23)
        Me.txt_año.Name = "txt_año"
        Me.txt_año.Size = New System.Drawing.Size(100, 20)
        Me.txt_año.TabIndex = 2
        '
        'txt_especialidad
        '
        Me.txt_especialidad.Enabled = False
        Me.txt_especialidad.Location = New System.Drawing.Point(465, 22)
        Me.txt_especialidad.Name = "txt_especialidad"
        Me.txt_especialidad.Size = New System.Drawing.Size(150, 20)
        Me.txt_especialidad.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Año"
        '
        'lbl_codTorneo
        '
        Me.lbl_codTorneo.AutoSize = True
        Me.lbl_codTorneo.Location = New System.Drawing.Point(9, 26)
        Me.lbl_codTorneo.Name = "lbl_codTorneo"
        Me.lbl_codTorneo.Size = New System.Drawing.Size(41, 13)
        Me.lbl_codTorneo.TabIndex = 6
        Me.lbl_codTorneo.Text = "Torneo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grid_competencias)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(632, 184)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione una Competencia"
        '
        'grid_competencias
        '
        Me.grid_competencias.AllowUserToAddRows = False
        Me.grid_competencias.AllowUserToDeleteRows = False
        Me.grid_competencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_competencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_competencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_competencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_competencias.Location = New System.Drawing.Point(3, 16)
        Me.grid_competencias.Name = "grid_competencias"
        Me.grid_competencias.ReadOnly = True
        Me.grid_competencias.Size = New System.Drawing.Size(626, 165)
        Me.grid_competencias.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_tiempo)
        Me.GroupBox2.Controls.Add(Me.cmb_apellido)
        Me.GroupBox2.Controls.Add(Me.txt_codNadador)
        Me.GroupBox2.Controls.Add(Me.lbl_codNadador)
        Me.GroupBox2.Controls.Add(Me.cmd_guardar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lbl_apellido)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 60)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registre el Tiempo"
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
        Me.txt_tiempo.Location = New System.Drawing.Point(445, 23)
        Me.txt_tiempo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_tiempo.Mask = "00:00:00"
        Me.txt_tiempo.Name = "txt_tiempo"
        Me.txt_tiempo.Size = New System.Drawing.Size(54, 20)
        Me.txt_tiempo.TabIndex = 25
        Me.txt_tiempo.ValidatingType = GetType(String)
        '
        'cmb_apellido
        '
        Me.cmb_apellido.FormattingEnabled = True
        Me.cmb_apellido.Location = New System.Drawing.Point(220, 23)
        Me.cmb_apellido.Name = "cmb_apellido"
        Me.cmb_apellido.Size = New System.Drawing.Size(121, 21)
        Me.cmb_apellido.TabIndex = 3
        '
        'txt_codNadador
        '
        Me.txt_codNadador._BDdato = False
        Me.txt_codNadador._BDnombreCampoTabla = ""
        Me.txt_codNadador._BDvalor = ""
        Me.txt_codNadador._descriptor_del_contenido = ""
        Me.txt_codNadador._Gest_AnchoTexto = 0
        Me.txt_codNadador._Gest_decimales = 0
        Me.txt_codNadador._Gest_enteros = "0"
        Me.txt_codNadador._Gest_mensajeError = ""
        Me.txt_codNadador._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_codNadador._Gest_ReadOnly = False
        Me.txt_codNadador._Gest_TextoNegrita = False
        Me.txt_codNadador._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_codNadador._Gest_validar = True
        Me.txt_codNadador.Enabled = False
        Me.txt_codNadador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_codNadador.Location = New System.Drawing.Point(66, 24)
        Me.txt_codNadador.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_codNadador.Mask = "999999"
        Me.txt_codNadador.Name = "txt_codNadador"
        Me.txt_codNadador.Size = New System.Drawing.Size(43, 20)
        Me.txt_codNadador.TabIndex = 0
        Me.txt_codNadador.ValidatingType = GetType(String)
        '
        'lbl_codNadador
        '
        Me.lbl_codNadador.AutoSize = True
        Me.lbl_codNadador.Location = New System.Drawing.Point(15, 26)
        Me.lbl_codNadador.Name = "lbl_codNadador"
        Me.lbl_codNadador.Size = New System.Drawing.Size(40, 13)
        Me.lbl_codNadador.TabIndex = 1
        Me.lbl_codNadador.Text = "Código"
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Asociacion.My.Resources.Resources.save
        Me.cmd_guardar.Location = New System.Drawing.Point(552, 7)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(51, 50)
        Me.cmd_guardar.TabIndex = 24
        Me.cmd_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(392, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tiempo"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(169, 26)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido"
        '
        'grp_inscripciones
        '
        Me.grp_inscripciones.Controls.Add(Me.grid_inscripciones)
        Me.grp_inscripciones.Location = New System.Drawing.Point(12, 329)
        Me.grp_inscripciones.Name = "grp_inscripciones"
        Me.grp_inscripciones.Size = New System.Drawing.Size(633, 212)
        Me.grp_inscripciones.TabIndex = 18
        Me.grp_inscripciones.TabStop = False
        Me.grp_inscripciones.Text = "Tiempos Registrados"
        '
        'grid_inscripciones
        '
        Me.grid_inscripciones.AllowUserToAddRows = False
        Me.grid_inscripciones.AllowUserToDeleteRows = False
        Me.grid_inscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_inscripciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_inscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_inscripciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_inscripciones.Location = New System.Drawing.Point(3, 16)
        Me.grid_inscripciones.Name = "grid_inscripciones"
        Me.grid_inscripciones.ReadOnly = True
        Me.grid_inscripciones.Size = New System.Drawing.Size(627, 193)
        Me.grid_inscripciones.TabIndex = 2
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.Asociacion.My.Resources.Resources.salir
        Me.cmd_salir.Location = New System.Drawing.Point(591, 548)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 27
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_cancelar.Location = New System.Drawing.Point(132, 548)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_cancelar.TabIndex = 26
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'Proc_Registro_resultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 610)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.grp_inscripciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Proc_Registro_resultado"
        Me.Text = "Registrar Tiempos de Competencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grid_competencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grp_inscripciones.ResumeLayout(False)
        CType(Me.grid_inscripciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_torneo As System.Windows.Forms.TextBox
    Friend WithEvents txt_año As System.Windows.Forms.TextBox
    Friend WithEvents txt_especialidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_codTorneo As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grid_competencias As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_apellido As System.Windows.Forms.ComboBox
    Friend WithEvents txt_codNadador As Asociacion.TextBoxv01
    Friend WithEvents lbl_codNadador As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents grp_inscripciones As System.Windows.Forms.GroupBox
    Friend WithEvents grid_inscripciones As System.Windows.Forms.DataGridView
    Friend WithEvents txt_tiempo As Asociacion.TextBoxv01
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
End Class
