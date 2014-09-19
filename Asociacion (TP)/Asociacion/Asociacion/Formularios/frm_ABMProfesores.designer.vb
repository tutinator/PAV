<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ABMProfesores
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
        Me.lbl_sexo_profesor = New System.Windows.Forms.Label()
        Me.gbo_profesor = New System.Windows.Forms.GroupBox()
        Me.txt_nroDoc_profesor = New Asociacion.TextBoxv01()
        Me.txt_codProfesor = New Asociacion.TextBoxv01()
        Me.cmd_nuevoCP = New System.Windows.Forms.Button()
        Me.txt_telefono_profesor = New Asociacion.TextBoxv01()
        Me.txt_nroCalle_profesor = New Asociacion.TextBoxv01()
        Me.cmb_codPos_profesor = New System.Windows.Forms.ComboBox()
        Me.txt_calle_profesor = New System.Windows.Forms.TextBox()
        Me.lbl_tel_profesor = New System.Windows.Forms.Label()
        Me.lbl_codPostal_profesor = New System.Windows.Forms.Label()
        Me.lbl_numero_profesor = New System.Windows.Forms.Label()
        Me.lbl_calle_profesor = New System.Windows.Forms.Label()
        Me.cmb_tipoDoc_profesor = New System.Windows.Forms.ComboBox()
        Me.opt_masculino_profesor = New System.Windows.Forms.RadioButton()
        Me.opt_femenino_profesor = New System.Windows.Forms.RadioButton()
        Me.lbl_nombre_profesor = New System.Windows.Forms.Label()
        Me.lbl_tipoDoc_profesor = New System.Windows.Forms.Label()
        Me.lbl_codigo_profesor = New System.Windows.Forms.Label()
        Me.lbl_apellido_profesor = New System.Windows.Forms.Label()
        Me.lbl_nro_doc_profesor = New System.Windows.Forms.Label()
        Me.txt_apellido_profesor = New System.Windows.Forms.TextBox()
        Me.txt_nombre_profesor = New System.Windows.Forms.TextBox()
        Me.gbo_profesores_registrados = New System.Windows.Forms.GroupBox()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.grid_profesores = New System.Windows.Forms.DataGridView()
        Me.gbo_profesor.SuspendLayout()
        Me.gbo_profesores_registrados.SuspendLayout()
        CType(Me.grid_profesores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_sexo_profesor
        '
        Me.lbl_sexo_profesor.AutoSize = True
        Me.lbl_sexo_profesor.Location = New System.Drawing.Point(405, 25)
        Me.lbl_sexo_profesor.Name = "lbl_sexo_profesor"
        Me.lbl_sexo_profesor.Size = New System.Drawing.Size(35, 13)
        Me.lbl_sexo_profesor.TabIndex = 14
        Me.lbl_sexo_profesor.Text = "Sexo*"
        '
        'gbo_profesor
        '
        Me.gbo_profesor.Controls.Add(Me.txt_nroDoc_profesor)
        Me.gbo_profesor.Controls.Add(Me.txt_codProfesor)
        Me.gbo_profesor.Controls.Add(Me.cmd_nuevoCP)
        Me.gbo_profesor.Controls.Add(Me.txt_telefono_profesor)
        Me.gbo_profesor.Controls.Add(Me.txt_nroCalle_profesor)
        Me.gbo_profesor.Controls.Add(Me.cmb_codPos_profesor)
        Me.gbo_profesor.Controls.Add(Me.txt_calle_profesor)
        Me.gbo_profesor.Controls.Add(Me.lbl_tel_profesor)
        Me.gbo_profesor.Controls.Add(Me.lbl_codPostal_profesor)
        Me.gbo_profesor.Controls.Add(Me.lbl_numero_profesor)
        Me.gbo_profesor.Controls.Add(Me.lbl_calle_profesor)
        Me.gbo_profesor.Controls.Add(Me.cmb_tipoDoc_profesor)
        Me.gbo_profesor.Controls.Add(Me.opt_masculino_profesor)
        Me.gbo_profesor.Controls.Add(Me.opt_femenino_profesor)
        Me.gbo_profesor.Controls.Add(Me.lbl_nombre_profesor)
        Me.gbo_profesor.Controls.Add(Me.lbl_tipoDoc_profesor)
        Me.gbo_profesor.Controls.Add(Me.lbl_codigo_profesor)
        Me.gbo_profesor.Controls.Add(Me.lbl_apellido_profesor)
        Me.gbo_profesor.Controls.Add(Me.lbl_nro_doc_profesor)
        Me.gbo_profesor.Controls.Add(Me.txt_apellido_profesor)
        Me.gbo_profesor.Controls.Add(Me.txt_nombre_profesor)
        Me.gbo_profesor.Controls.Add(Me.lbl_sexo_profesor)
        Me.gbo_profesor.Location = New System.Drawing.Point(9, 12)
        Me.gbo_profesor.Name = "gbo_profesor"
        Me.gbo_profesor.Size = New System.Drawing.Size(778, 171)
        Me.gbo_profesor.TabIndex = 0
        Me.gbo_profesor.TabStop = False
        Me.gbo_profesor.Text = "Profesor"
        '
        'txt_nroDoc_profesor
        '
        Me.txt_nroDoc_profesor._BDdato = False
        Me.txt_nroDoc_profesor._BDnombreCampoTabla = ""
        Me.txt_nroDoc_profesor._BDvalor = ""
        Me.txt_nroDoc_profesor._descriptor_del_contenido = ""
        Me.txt_nroDoc_profesor._Gest_AnchoTexto = 0
        Me.txt_nroDoc_profesor._Gest_decimales = 0
        Me.txt_nroDoc_profesor._Gest_enteros = "0"
        Me.txt_nroDoc_profesor._Gest_mensajeError = ""
        Me.txt_nroDoc_profesor._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_nroDoc_profesor._Gest_ReadOnly = False
        Me.txt_nroDoc_profesor._Gest_TextoNegrita = False
        Me.txt_nroDoc_profesor._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_nroDoc_profesor._Gest_validar = True
        Me.txt_nroDoc_profesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_nroDoc_profesor.Location = New System.Drawing.Point(122, 138)
        Me.txt_nroDoc_profesor.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_nroDoc_profesor.Mask = "99999999"
        Me.txt_nroDoc_profesor.Name = "txt_nroDoc_profesor"
        Me.txt_nroDoc_profesor.Size = New System.Drawing.Size(59, 20)
        Me.txt_nroDoc_profesor.TabIndex = 4
        Me.txt_nroDoc_profesor.ValidatingType = GetType(String)
        '
        'txt_codProfesor
        '
        Me.txt_codProfesor._BDdato = False
        Me.txt_codProfesor._BDnombreCampoTabla = ""
        Me.txt_codProfesor._BDvalor = ""
        Me.txt_codProfesor._descriptor_del_contenido = ""
        Me.txt_codProfesor._Gest_AnchoTexto = 0
        Me.txt_codProfesor._Gest_decimales = 0
        Me.txt_codProfesor._Gest_enteros = "0"
        Me.txt_codProfesor._Gest_mensajeError = ""
        Me.txt_codProfesor._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_codProfesor._Gest_ReadOnly = False
        Me.txt_codProfesor._Gest_TextoNegrita = True
        Me.txt_codProfesor._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_codProfesor._Gest_validar = True
        Me.txt_codProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txt_codProfesor.Location = New System.Drawing.Point(122, 22)
        Me.txt_codProfesor.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_codProfesor.Mask = "99999"
        Me.txt_codProfesor.Name = "txt_codProfesor"
        Me.txt_codProfesor.Size = New System.Drawing.Size(42, 20)
        Me.txt_codProfesor.TabIndex = 0
        Me.txt_codProfesor.ValidatingType = GetType(Integer)
        '
        'cmd_nuevoCP
        '
        Me.cmd_nuevoCP.Location = New System.Drawing.Point(535, 108)
        Me.cmd_nuevoCP.Name = "cmd_nuevoCP"
        Me.cmd_nuevoCP.Size = New System.Drawing.Size(64, 21)
        Me.cmd_nuevoCP.TabIndex = 10
        Me.cmd_nuevoCP.Text = "Nuevo CP"
        Me.cmd_nuevoCP.UseVisualStyleBackColor = True
        '
        'txt_telefono_profesor
        '
        Me.txt_telefono_profesor._BDdato = False
        Me.txt_telefono_profesor._BDnombreCampoTabla = ""
        Me.txt_telefono_profesor._BDvalor = ""
        Me.txt_telefono_profesor._descriptor_del_contenido = ""
        Me.txt_telefono_profesor._Gest_AnchoTexto = 0
        Me.txt_telefono_profesor._Gest_decimales = 0
        Me.txt_telefono_profesor._Gest_enteros = "0"
        Me.txt_telefono_profesor._Gest_mensajeError = ""
        Me.txt_telefono_profesor._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_telefono_profesor._Gest_ReadOnly = False
        Me.txt_telefono_profesor._Gest_TextoNegrita = False
        Me.txt_telefono_profesor._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_telefono_profesor._Gest_validar = True
        Me.txt_telefono_profesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_telefono_profesor.Location = New System.Drawing.Point(440, 138)
        Me.txt_telefono_profesor.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_telefono_profesor.Mask = "99999999999999"
        Me.txt_telefono_profesor.Name = "txt_telefono_profesor"
        Me.txt_telefono_profesor.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono_profesor.TabIndex = 11
        Me.txt_telefono_profesor.ValidatingType = GetType(String)
        '
        'txt_nroCalle_profesor
        '
        Me.txt_nroCalle_profesor._BDdato = False
        Me.txt_nroCalle_profesor._BDnombreCampoTabla = ""
        Me.txt_nroCalle_profesor._BDvalor = ""
        Me.txt_nroCalle_profesor._descriptor_del_contenido = ""
        Me.txt_nroCalle_profesor._Gest_AnchoTexto = 0
        Me.txt_nroCalle_profesor._Gest_decimales = 0
        Me.txt_nroCalle_profesor._Gest_enteros = "0"
        Me.txt_nroCalle_profesor._Gest_mensajeError = ""
        Me.txt_nroCalle_profesor._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_nroCalle_profesor._Gest_ReadOnly = False
        Me.txt_nroCalle_profesor._Gest_TextoNegrita = False
        Me.txt_nroCalle_profesor._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_nroCalle_profesor._Gest_validar = True
        Me.txt_nroCalle_profesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_nroCalle_profesor.Location = New System.Drawing.Point(440, 80)
        Me.txt_nroCalle_profesor.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_nroCalle_profesor.Mask = "99999"
        Me.txt_nroCalle_profesor.Name = "txt_nroCalle_profesor"
        Me.txt_nroCalle_profesor.Size = New System.Drawing.Size(42, 20)
        Me.txt_nroCalle_profesor.TabIndex = 8
        Me.txt_nroCalle_profesor.ValidatingType = GetType(Integer)
        '
        'cmb_codPos_profesor
        '
        Me.cmb_codPos_profesor.FormattingEnabled = True
        Me.cmb_codPos_profesor.Location = New System.Drawing.Point(440, 109)
        Me.cmb_codPos_profesor.Name = "cmb_codPos_profesor"
        Me.cmb_codPos_profesor.Size = New System.Drawing.Size(89, 21)
        Me.cmb_codPos_profesor.TabIndex = 9
        '
        'txt_calle_profesor
        '
        Me.txt_calle_profesor.Location = New System.Drawing.Point(440, 51)
        Me.txt_calle_profesor.Name = "txt_calle_profesor"
        Me.txt_calle_profesor.Size = New System.Drawing.Size(145, 20)
        Me.txt_calle_profesor.TabIndex = 7
        '
        'lbl_tel_profesor
        '
        Me.lbl_tel_profesor.AutoSize = True
        Me.lbl_tel_profesor.Location = New System.Drawing.Point(387, 141)
        Me.lbl_tel_profesor.Name = "lbl_tel_profesor"
        Me.lbl_tel_profesor.Size = New System.Drawing.Size(49, 13)
        Me.lbl_tel_profesor.TabIndex = 34
        Me.lbl_tel_profesor.Text = "Teléfono"
        '
        'lbl_codPostal_profesor
        '
        Me.lbl_codPostal_profesor.AutoSize = True
        Me.lbl_codPostal_profesor.Location = New System.Drawing.Point(365, 112)
        Me.lbl_codPostal_profesor.Name = "lbl_codPostal_profesor"
        Me.lbl_codPostal_profesor.Size = New System.Drawing.Size(71, 13)
        Me.lbl_codPostal_profesor.TabIndex = 35
        Me.lbl_codPostal_profesor.Text = "Código postal"
        '
        'lbl_numero_profesor
        '
        Me.lbl_numero_profesor.AutoSize = True
        Me.lbl_numero_profesor.Location = New System.Drawing.Point(392, 83)
        Me.lbl_numero_profesor.Name = "lbl_numero_profesor"
        Me.lbl_numero_profesor.Size = New System.Drawing.Size(44, 13)
        Me.lbl_numero_profesor.TabIndex = 37
        Me.lbl_numero_profesor.Text = "Número"
        '
        'lbl_calle_profesor
        '
        Me.lbl_calle_profesor.AutoSize = True
        Me.lbl_calle_profesor.Location = New System.Drawing.Point(406, 54)
        Me.lbl_calle_profesor.Name = "lbl_calle_profesor"
        Me.lbl_calle_profesor.Size = New System.Drawing.Size(34, 13)
        Me.lbl_calle_profesor.TabIndex = 39
        Me.lbl_calle_profesor.Text = "Calle*"
        '
        'cmb_tipoDoc_profesor
        '
        Me.cmb_tipoDoc_profesor.FormattingEnabled = True
        Me.cmb_tipoDoc_profesor.Location = New System.Drawing.Point(122, 109)
        Me.cmb_tipoDoc_profesor.Name = "cmb_tipoDoc_profesor"
        Me.cmb_tipoDoc_profesor.Size = New System.Drawing.Size(125, 21)
        Me.cmb_tipoDoc_profesor.TabIndex = 3
        '
        'opt_masculino_profesor
        '
        Me.opt_masculino_profesor.AutoSize = True
        Me.opt_masculino_profesor.Location = New System.Drawing.Point(440, 23)
        Me.opt_masculino_profesor.Name = "opt_masculino_profesor"
        Me.opt_masculino_profesor.Size = New System.Drawing.Size(73, 17)
        Me.opt_masculino_profesor.TabIndex = 5
        Me.opt_masculino_profesor.TabStop = True
        Me.opt_masculino_profesor.Text = "Masculino"
        Me.opt_masculino_profesor.UseVisualStyleBackColor = True
        '
        'opt_femenino_profesor
        '
        Me.opt_femenino_profesor.AutoSize = True
        Me.opt_femenino_profesor.Location = New System.Drawing.Point(519, 23)
        Me.opt_femenino_profesor.Name = "opt_femenino_profesor"
        Me.opt_femenino_profesor.Size = New System.Drawing.Size(71, 17)
        Me.opt_femenino_profesor.TabIndex = 6
        Me.opt_femenino_profesor.TabStop = True
        Me.opt_femenino_profesor.Text = "Femenino"
        Me.opt_femenino_profesor.UseVisualStyleBackColor = True
        '
        'lbl_nombre_profesor
        '
        Me.lbl_nombre_profesor.AutoSize = True
        Me.lbl_nombre_profesor.Location = New System.Drawing.Point(74, 83)
        Me.lbl_nombre_profesor.Name = "lbl_nombre_profesor"
        Me.lbl_nombre_profesor.Size = New System.Drawing.Size(48, 13)
        Me.lbl_nombre_profesor.TabIndex = 18
        Me.lbl_nombre_profesor.Text = "Nombre*"
        '
        'lbl_tipoDoc_profesor
        '
        Me.lbl_tipoDoc_profesor.AutoSize = True
        Me.lbl_tipoDoc_profesor.Location = New System.Drawing.Point(19, 112)
        Me.lbl_tipoDoc_profesor.Name = "lbl_tipoDoc_profesor"
        Me.lbl_tipoDoc_profesor.Size = New System.Drawing.Size(103, 13)
        Me.lbl_tipoDoc_profesor.TabIndex = 16
        Me.lbl_tipoDoc_profesor.Text = "Tipo de documento*"
        '
        'lbl_codigo_profesor
        '
        Me.lbl_codigo_profesor.AutoSize = True
        Me.lbl_codigo_profesor.Location = New System.Drawing.Point(36, 25)
        Me.lbl_codigo_profesor.Name = "lbl_codigo_profesor"
        Me.lbl_codigo_profesor.Size = New System.Drawing.Size(86, 13)
        Me.lbl_codigo_profesor.TabIndex = 20
        Me.lbl_codigo_profesor.Text = "Código Profesor*"
        '
        'lbl_apellido_profesor
        '
        Me.lbl_apellido_profesor.AutoSize = True
        Me.lbl_apellido_profesor.Location = New System.Drawing.Point(74, 54)
        Me.lbl_apellido_profesor.Name = "lbl_apellido_profesor"
        Me.lbl_apellido_profesor.Size = New System.Drawing.Size(48, 13)
        Me.lbl_apellido_profesor.TabIndex = 20
        Me.lbl_apellido_profesor.Text = "Apellido*"
        '
        'lbl_nro_doc_profesor
        '
        Me.lbl_nro_doc_profesor.AutoSize = True
        Me.lbl_nro_doc_profesor.Location = New System.Drawing.Point(3, 141)
        Me.lbl_nro_doc_profesor.Name = "lbl_nro_doc_profesor"
        Me.lbl_nro_doc_profesor.Size = New System.Drawing.Size(119, 13)
        Me.lbl_nro_doc_profesor.TabIndex = 19
        Me.lbl_nro_doc_profesor.Text = "Número de documento*"
        '
        'txt_apellido_profesor
        '
        Me.txt_apellido_profesor.Location = New System.Drawing.Point(122, 51)
        Me.txt_apellido_profesor.Name = "txt_apellido_profesor"
        Me.txt_apellido_profesor.Size = New System.Drawing.Size(145, 20)
        Me.txt_apellido_profesor.TabIndex = 1
        '
        'txt_nombre_profesor
        '
        Me.txt_nombre_profesor.Location = New System.Drawing.Point(122, 80)
        Me.txt_nombre_profesor.Name = "txt_nombre_profesor"
        Me.txt_nombre_profesor.Size = New System.Drawing.Size(145, 20)
        Me.txt_nombre_profesor.TabIndex = 2
        '
        'gbo_profesores_registrados
        '
        Me.gbo_profesores_registrados.Controls.Add(Me.grid_profesores)
        Me.gbo_profesores_registrados.Location = New System.Drawing.Point(9, 189)
        Me.gbo_profesores_registrados.Name = "gbo_profesores_registrados"
        Me.gbo_profesores_registrados.Size = New System.Drawing.Size(778, 248)
        Me.gbo_profesores_registrados.TabIndex = 7
        Me.gbo_profesores_registrados.TabStop = False
        Me.gbo_profesores_registrados.Text = "Profesores Registrados"
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.Asociacion.My.Resources.Resources.salir
        Me.cmd_salir.Location = New System.Drawing.Point(737, 443)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 5
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.Asociacion.My.Resources.Resources.buscar
        Me.cmd_buscar.Location = New System.Drawing.Point(278, 443)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_buscar.TabIndex = 4
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_cancelar.Location = New System.Drawing.Point(177, 443)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_cancelar.TabIndex = 3
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Image = Global.Asociacion.My.Resources.Resources.delete
        Me.cmd_eliminar.Location = New System.Drawing.Point(121, 443)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_eliminar.TabIndex = 2
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Asociacion.My.Resources.Resources.save
        Me.cmd_guardar.Location = New System.Drawing.Point(65, 443)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_guardar.TabIndex = 1
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = Global.Asociacion.My.Resources.Resources.add
        Me.cmd_nuevo.Location = New System.Drawing.Point(9, 443)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.cmd_nuevo.TabIndex = 0
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'grid_profesores
        '
        Me.grid_profesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_profesores.Location = New System.Drawing.Point(6, 20)
        Me.grid_profesores.Name = "grid_profesores"
        Me.grid_profesores.Size = New System.Drawing.Size(766, 222)
        Me.grid_profesores.TabIndex = 0
        '
        'frm_ABMProfesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 505)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.gbo_profesor)
        Me.Controls.Add(Me.gbo_profesores_registrados)
        Me.Name = "frm_ABMProfesores"
        Me.Text = "Gestión de Profesores"
        Me.gbo_profesor.ResumeLayout(False)
        Me.gbo_profesor.PerformLayout()
        Me.gbo_profesores_registrados.ResumeLayout(False)
        CType(Me.grid_profesores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_sexo_profesor As System.Windows.Forms.Label
    Friend WithEvents gbo_profesor As System.Windows.Forms.GroupBox
    Friend WithEvents gbo_profesores_registrados As System.Windows.Forms.GroupBox
    Friend WithEvents opt_femenino_profesor As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_nombre_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_nro_doc_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoDoc_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido_profesor As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_profesor As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido_profesor As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipoDoc_profesor As System.Windows.Forms.ComboBox
    Friend WithEvents opt_masculino_profesor As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_codigo_profesor As System.Windows.Forms.Label
    Friend WithEvents cmd_nuevoCP As System.Windows.Forms.Button
    Friend WithEvents txt_telefono_profesor As Asociacion.TextBoxv01
    Friend WithEvents txt_nroCalle_profesor As Asociacion.TextBoxv01
    Friend WithEvents cmb_codPos_profesor As System.Windows.Forms.ComboBox
    Friend WithEvents txt_calle_profesor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tel_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_codPostal_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_numero_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_calle_profesor As System.Windows.Forms.Label
    Friend WithEvents txt_codProfesor As Asociacion.TextBoxv01
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_nroDoc_profesor As Asociacion.TextBoxv01
    Friend WithEvents grid_profesores As System.Windows.Forms.DataGridView
End Class
