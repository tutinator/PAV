<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proc_inscripciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_buscarTorneo = New System.Windows.Forms.Button()
        Me.txt_codTorneo = New Asociacion.TextBoxv01()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txt_año = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_codTorneo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_buscarNadador = New System.Windows.Forms.Button()
        Me.txt_codNadador = New Asociacion.TextBoxv01()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_codNadador = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_codEspe = New Asociacion.TextBoxv01()
        Me.txt_nombreEspe = New System.Windows.Forms.TextBox()
        Me.lbl_nombreEspe = New System.Windows.Forms.Label()
        Me.lbl_codEspe = New System.Windows.Forms.Label()
        Me.cmd_buscarEspecialidad = New System.Windows.Forms.Button()
        Me.grp_inscripciones = New System.Windows.Forms.GroupBox()
        Me.grid_realizaciones = New System.Windows.Forms.DataGridView()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp_inscripciones.SuspendLayout()
        CType(Me.grid_realizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_buscarTorneo)
        Me.GroupBox1.Controls.Add(Me.txt_codTorneo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.txt_año)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_codTorneo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 91)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Torneo"
        '
        'cmd_buscarTorneo
        '
        Me.cmd_buscarTorneo.Location = New System.Drawing.Point(161, 21)
        Me.cmd_buscarTorneo.Name = "cmd_buscarTorneo"
        Me.cmd_buscarTorneo.Size = New System.Drawing.Size(42, 23)
        Me.cmd_buscarTorneo.TabIndex = 13
        Me.cmd_buscarTorneo.Text = "..."
        Me.cmd_buscarTorneo.UseVisualStyleBackColor = True
        '
        'txt_codTorneo
        '
        Me.txt_codTorneo._BDdato = False
        Me.txt_codTorneo._BDnombreCampoTabla = ""
        Me.txt_codTorneo._BDvalor = ""
        Me.txt_codTorneo._descriptor_del_contenido = ""
        Me.txt_codTorneo._Gest_AnchoTexto = 0
        Me.txt_codTorneo._Gest_decimales = 0
        Me.txt_codTorneo._Gest_enteros = "0"
        Me.txt_codTorneo._Gest_mensajeError = ""
        Me.txt_codTorneo._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_codTorneo._Gest_ReadOnly = False
        Me.txt_codTorneo._Gest_TextoNegrita = False
        Me.txt_codTorneo._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_codTorneo._Gest_validar = True
        Me.txt_codTorneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_codTorneo.Location = New System.Drawing.Point(105, 23)
        Me.txt_codTorneo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_codTorneo.Mask = "9999"
        Me.txt_codTorneo.Name = "txt_codTorneo"
        Me.txt_codTorneo.Size = New System.Drawing.Size(34, 20)
        Me.txt_codTorneo.TabIndex = 11
        Me.txt_codTorneo.ValidatingType = GetType(String)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Código Torneo*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(366, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Club sede"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(427, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(105, 53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'txt_año
        '
        Me.txt_año.Location = New System.Drawing.Point(249, 53)
        Me.txt_año.Name = "txt_año"
        Me.txt_año.Size = New System.Drawing.Size(100, 20)
        Me.txt_año.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Año"
        '
        'lbl_codTorneo
        '
        Me.lbl_codTorneo.AutoSize = True
        Me.lbl_codTorneo.Location = New System.Drawing.Point(17, 60)
        Me.lbl_codTorneo.Name = "lbl_codTorneo"
        Me.lbl_codTorneo.Size = New System.Drawing.Size(81, 13)
        Me.lbl_codTorneo.TabIndex = 6
        Me.lbl_codTorneo.Text = "Nombre Torneo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_buscarNadador)
        Me.GroupBox2.Controls.Add(Me.txt_codNadador)
        Me.GroupBox2.Controls.Add(Me.txt_apellido)
        Me.GroupBox2.Controls.Add(Me.lbl_codNadador)
        Me.GroupBox2.Controls.Add(Me.lbl_apellido)
        Me.GroupBox2.Controls.Add(Me.lbl_nombre)
        Me.GroupBox2.Controls.Add(Me.txt_nombre)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 92)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nadador"
        '
        'cmd_buscarNadador
        '
        Me.cmd_buscarNadador.Location = New System.Drawing.Point(161, 21)
        Me.cmd_buscarNadador.Name = "cmd_buscarNadador"
        Me.cmd_buscarNadador.Size = New System.Drawing.Size(42, 23)
        Me.cmd_buscarNadador.TabIndex = 3
        Me.cmd_buscarNadador.Text = "..."
        Me.cmd_buscarNadador.UseVisualStyleBackColor = True
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
        Me.txt_codNadador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_codNadador.Location = New System.Drawing.Point(105, 23)
        Me.txt_codNadador.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_codNadador.Mask = "999999"
        Me.txt_codNadador.Name = "txt_codNadador"
        Me.txt_codNadador.Size = New System.Drawing.Size(43, 20)
        Me.txt_codNadador.TabIndex = 0
        Me.txt_codNadador.ValidatingType = GetType(String)
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(70, 54)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(145, 20)
        Me.txt_apellido.TabIndex = 1
        '
        'lbl_codNadador
        '
        Me.lbl_codNadador.AutoSize = True
        Me.lbl_codNadador.Location = New System.Drawing.Point(15, 26)
        Me.lbl_codNadador.Name = "lbl_codNadador"
        Me.lbl_codNadador.Size = New System.Drawing.Size(88, 13)
        Me.lbl_codNadador.TabIndex = 1
        Me.lbl_codNadador.Text = "Código Nadador*"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(15, 57)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(232, 57)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(286, 54)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(145, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmd_buscarEspecialidad)
        Me.GroupBox3.Controls.Add(Me.txt_codEspe)
        Me.GroupBox3.Controls.Add(Me.txt_nombreEspe)
        Me.GroupBox3.Controls.Add(Me.lbl_nombreEspe)
        Me.GroupBox3.Controls.Add(Me.lbl_codEspe)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 207)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(635, 64)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Especialidad"
        '
        'txt_codEspe
        '
        Me.txt_codEspe._BDdato = False
        Me.txt_codEspe._BDnombreCampoTabla = ""
        Me.txt_codEspe._BDvalor = ""
        Me.txt_codEspe._descriptor_del_contenido = ""
        Me.txt_codEspe._Gest_AnchoTexto = 0
        Me.txt_codEspe._Gest_decimales = 0
        Me.txt_codEspe._Gest_enteros = "0"
        Me.txt_codEspe._Gest_mensajeError = ""
        Me.txt_codEspe._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_codEspe._Gest_ReadOnly = False
        Me.txt_codEspe._Gest_TextoNegrita = False
        Me.txt_codEspe._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_codEspe._Gest_validar = True
        Me.txt_codEspe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_codEspe.Location = New System.Drawing.Point(114, 24)
        Me.txt_codEspe.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_codEspe.Mask = "99999"
        Me.txt_codEspe.Name = "txt_codEspe"
        Me.txt_codEspe.Size = New System.Drawing.Size(42, 20)
        Me.txt_codEspe.TabIndex = 0
        Me.txt_codEspe.ValidatingType = GetType(Integer)
        '
        'txt_nombreEspe
        '
        Me.txt_nombreEspe.Location = New System.Drawing.Point(286, 24)
        Me.txt_nombreEspe.Name = "txt_nombreEspe"
        Me.txt_nombreEspe.Size = New System.Drawing.Size(139, 20)
        Me.txt_nombreEspe.TabIndex = 1
        '
        'lbl_nombreEspe
        '
        Me.lbl_nombreEspe.AutoSize = True
        Me.lbl_nombreEspe.Location = New System.Drawing.Point(232, 27)
        Me.lbl_nombreEspe.Name = "lbl_nombreEspe"
        Me.lbl_nombreEspe.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombreEspe.TabIndex = 1
        Me.lbl_nombreEspe.Text = "Nombre"
        '
        'lbl_codEspe
        '
        Me.lbl_codEspe.AutoSize = True
        Me.lbl_codEspe.Location = New System.Drawing.Point(3, 27)
        Me.lbl_codEspe.Name = "lbl_codEspe"
        Me.lbl_codEspe.Size = New System.Drawing.Size(107, 13)
        Me.lbl_codEspe.TabIndex = 0
        Me.lbl_codEspe.Text = "Código Especialidad*"
        '
        'cmd_buscarEspecialidad
        '
        Me.cmd_buscarEspecialidad.Location = New System.Drawing.Point(173, 22)
        Me.cmd_buscarEspecialidad.Name = "cmd_buscarEspecialidad"
        Me.cmd_buscarEspecialidad.Size = New System.Drawing.Size(42, 23)
        Me.cmd_buscarEspecialidad.TabIndex = 4
        Me.cmd_buscarEspecialidad.Text = "..."
        Me.cmd_buscarEspecialidad.UseVisualStyleBackColor = True
        '
        'grp_inscripciones
        '
        Me.grp_inscripciones.Controls.Add(Me.grid_realizaciones)
        Me.grp_inscripciones.Location = New System.Drawing.Point(18, 277)
        Me.grp_inscripciones.Name = "grp_inscripciones"
        Me.grp_inscripciones.Size = New System.Drawing.Size(629, 184)
        Me.grp_inscripciones.TabIndex = 17
        Me.grp_inscripciones.TabStop = False
        Me.grp_inscripciones.Text = "Inscripciones Realizadas"
        '
        'grid_realizaciones
        '
        Me.grid_realizaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_realizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_realizaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_realizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_realizaciones.Location = New System.Drawing.Point(6, 19)
        Me.grid_realizaciones.Name = "grid_realizaciones"
        Me.grid_realizaciones.ReadOnly = True
        Me.grid_realizaciones.Size = New System.Drawing.Size(617, 159)
        Me.grid_realizaciones.TabIndex = 2
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.Asociacion.My.Resources.Resources.salir
        Me.cmd_salir.Location = New System.Drawing.Point(597, 468)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 23
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.Asociacion.My.Resources.Resources.buscar
        Me.cmd_buscar.Location = New System.Drawing.Point(341, 468)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_buscar.TabIndex = 22
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_cancelar.Location = New System.Drawing.Point(186, 468)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_cancelar.TabIndex = 21
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Image = Global.Asociacion.My.Resources.Resources.delete
        Me.cmd_eliminar.Location = New System.Drawing.Point(130, 468)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_eliminar.TabIndex = 20
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Asociacion.My.Resources.Resources.save
        Me.cmd_guardar.Location = New System.Drawing.Point(74, 468)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_guardar.TabIndex = 19
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = Global.Asociacion.My.Resources.Resources.add
        Me.cmd_nuevo.Location = New System.Drawing.Point(18, 468)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.cmd_nuevo.TabIndex = 18
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'proc_inscripciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 530)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grp_inscripciones)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "proc_inscripciones"
        Me.Text = "Inscripcion a Torneo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grp_inscripciones.ResumeLayout(False)
        CType(Me.grid_realizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_año As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_codTorneo As System.Windows.Forms.Label
    Friend WithEvents txt_codTorneo As Asociacion.TextBoxv01
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscarTorneo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_buscarNadador As System.Windows.Forms.Button
    Friend WithEvents txt_codNadador As Asociacion.TextBoxv01
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_codNadador As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_buscarEspecialidad As System.Windows.Forms.Button
    Friend WithEvents txt_codEspe As Asociacion.TextBoxv01
    Friend WithEvents txt_nombreEspe As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombreEspe As System.Windows.Forms.Label
    Friend WithEvents lbl_codEspe As System.Windows.Forms.Label
    Friend WithEvents grp_inscripciones As System.Windows.Forms.GroupBox
    Friend WithEvents grid_realizaciones As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
End Class
