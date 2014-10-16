<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ABMnadadores
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
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.cmb_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.lbl_tipoDoc = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.opt_masculino = New System.Windows.Forms.RadioButton()
        Me.opt_femenino = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.msk_fechaNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.lbl_codPostal = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_nuevoClub = New System.Windows.Forms.Button()
        Me.txt_nroCalle = New Asociacion.TextBoxv01()
        Me.txt_codNadador = New Asociacion.TextBoxv01()
        Me.txt_nroDoc = New Asociacion.TextBoxv01()
        Me.cmd_nuevoProfe = New System.Windows.Forms.Button()
        Me.cmd_nuevoCP = New System.Windows.Forms.Button()
        Me.cmb_club = New System.Windows.Forms.ComboBox()
        Me.cmb_profesor = New System.Windows.Forms.ComboBox()
        Me.cmb_codPos = New System.Windows.Forms.ComboBox()
        Me.lbl_club = New System.Windows.Forms.Label()
        Me.lbl_profesor = New System.Windows.Forms.Label()
        Me.lbl_codNadador = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grid_nadadores = New System.Windows.Forms.DataGridView()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid_nadadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(114, 97)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(48, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre*"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(114, 65)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(48, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido*"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(168, 94)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(145, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(168, 62)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(145, 20)
        Me.txt_apellido.TabIndex = 1
        '
        'cmb_tipoDoc
        '
        Me.cmb_tipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipoDoc.FormattingEnabled = True
        Me.cmb_tipoDoc.Location = New System.Drawing.Point(168, 126)
        Me.cmb_tipoDoc.Name = "cmb_tipoDoc"
        Me.cmb_tipoDoc.Size = New System.Drawing.Size(125, 21)
        Me.cmb_tipoDoc.TabIndex = 4
        '
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(59, 129)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(103, 13)
        Me.lbl_tipoDoc.TabIndex = 0
        Me.lbl_tipoDoc.Text = "Tipo de documento*"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(68, 199)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(94, 13)
        Me.lbl_email.TabIndex = 0
        Me.lbl_email.Text = "Correo Electrónico"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(168, 192)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(145, 20)
        Me.txt_email.TabIndex = 6
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Location = New System.Drawing.Point(91, 232)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_sexo.TabIndex = 0
        Me.lbl_sexo.Text = "Sexo*"
        '
        'opt_masculino
        '
        Me.opt_masculino.AutoSize = True
        Me.opt_masculino.Location = New System.Drawing.Point(145, 230)
        Me.opt_masculino.Name = "opt_masculino"
        Me.opt_masculino.Size = New System.Drawing.Size(73, 17)
        Me.opt_masculino.TabIndex = 7
        Me.opt_masculino.TabStop = True
        Me.opt_masculino.Text = "Masculino"
        Me.opt_masculino.UseVisualStyleBackColor = True
        '
        'opt_femenino
        '
        Me.opt_femenino.AutoSize = True
        Me.opt_femenino.Location = New System.Drawing.Point(239, 230)
        Me.opt_femenino.Name = "opt_femenino"
        Me.opt_femenino.Size = New System.Drawing.Size(71, 17)
        Me.opt_femenino.TabIndex = 8
        Me.opt_femenino.TabStop = True
        Me.opt_femenino.Text = "Femenino"
        Me.opt_femenino.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de documento*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha de nacimiento"
        Me.Label2.Visible = False
        '
        'msk_fechaNacimiento
        '
        Me.msk_fechaNacimiento.Enabled = False
        Me.msk_fechaNacimiento.Location = New System.Drawing.Point(168, 126)
        Me.msk_fechaNacimiento.Mask = "00/00/0000"
        Me.msk_fechaNacimiento.Name = "msk_fechaNacimiento"
        Me.msk_fechaNacimiento.Size = New System.Drawing.Size(77, 20)
        Me.msk_fechaNacimiento.TabIndex = 3
        Me.msk_fechaNacimiento.Visible = False
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(431, 32)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(30, 13)
        Me.lbl_calle.TabIndex = 0
        Me.lbl_calle.Text = "Calle"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(417, 60)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(44, 13)
        Me.lbl_numero.TabIndex = 0
        Me.lbl_numero.Text = "Número"
        '
        'lbl_codPostal
        '
        Me.lbl_codPostal.AutoSize = True
        Me.lbl_codPostal.Location = New System.Drawing.Point(390, 93)
        Me.lbl_codPostal.Name = "lbl_codPostal"
        Me.lbl_codPostal.Size = New System.Drawing.Size(71, 13)
        Me.lbl_codPostal.TabIndex = 0
        Me.lbl_codPostal.Text = "Código postal"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(467, 32)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(240, 20)
        Me.txt_calle.TabIndex = 9
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = Global.Asociacion.My.Resources.Resources.add
        Me.cmd_nuevo.Location = New System.Drawing.Point(13, 523)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.cmd_nuevo.TabIndex = 8
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Asociacion.My.Resources.Resources.save
        Me.cmd_guardar.Location = New System.Drawing.Point(69, 523)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_guardar.TabIndex = 1
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_cancelar.Location = New System.Drawing.Point(181, 523)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_cancelar.TabIndex = 3
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.Asociacion.My.Resources.Resources.buscar
        Me.cmd_buscar.Location = New System.Drawing.Point(468, 523)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_buscar.TabIndex = 4
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.Asociacion.My.Resources.Resources.salir
        Me.cmd_salir.Location = New System.Drawing.Point(709, 523)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 5
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_nuevoClub)
        Me.GroupBox1.Controls.Add(Me.txt_nroCalle)
        Me.GroupBox1.Controls.Add(Me.txt_codNadador)
        Me.GroupBox1.Controls.Add(Me.txt_nroDoc)
        Me.GroupBox1.Controls.Add(Me.cmd_nuevoProfe)
        Me.GroupBox1.Controls.Add(Me.cmd_nuevoCP)
        Me.GroupBox1.Controls.Add(Me.cmb_club)
        Me.GroupBox1.Controls.Add(Me.cmb_profesor)
        Me.GroupBox1.Controls.Add(Me.cmb_codPos)
        Me.GroupBox1.Controls.Add(Me.opt_femenino)
        Me.GroupBox1.Controls.Add(Me.opt_masculino)
        Me.GroupBox1.Controls.Add(Me.lbl_sexo)
        Me.GroupBox1.Controls.Add(Me.lbl_club)
        Me.GroupBox1.Controls.Add(Me.lbl_profesor)
        Me.GroupBox1.Controls.Add(Me.lbl_numero)
        Me.GroupBox1.Controls.Add(Me.lbl_codPostal)
        Me.GroupBox1.Controls.Add(Me.txt_calle)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.lbl_calle)
        Me.GroupBox1.Controls.Add(Me.lbl_codNadador)
        Me.GroupBox1.Controls.Add(Me.lbl_apellido)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Controls.Add(Me.cmb_tipoDoc)
        Me.GroupBox1.Controls.Add(Me.lbl_email)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_tipoDoc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.msk_fechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(746, 262)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nadador"
        '
        'cmd_nuevoClub
        '
        Me.cmd_nuevoClub.Location = New System.Drawing.Point(566, 197)
        Me.cmd_nuevoClub.Name = "cmd_nuevoClub"
        Me.cmd_nuevoClub.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevoClub.TabIndex = 15
        Me.cmd_nuevoClub.Text = "Nuevo Club"
        Me.cmd_nuevoClub.UseVisualStyleBackColor = True
        '
        'txt_nroCalle
        '
        Me.txt_nroCalle._BDdato = False
        Me.txt_nroCalle._BDnombreCampoTabla = ""
        Me.txt_nroCalle._BDvalor = ""
        Me.txt_nroCalle._descriptor_del_contenido = ""
        Me.txt_nroCalle._Gest_AnchoTexto = 0
        Me.txt_nroCalle._Gest_decimales = 0
        Me.txt_nroCalle._Gest_enteros = "0"
        Me.txt_nroCalle._Gest_mensajeError = ""
        Me.txt_nroCalle._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_nroCalle._Gest_ReadOnly = False
        Me.txt_nroCalle._Gest_TextoNegrita = False
        Me.txt_nroCalle._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_nroCalle._Gest_validar = True
        Me.txt_nroCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_nroCalle.Location = New System.Drawing.Point(467, 57)
        Me.txt_nroCalle.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_nroCalle.Mask = "99999"
        Me.txt_nroCalle.Name = "txt_nroCalle"
        Me.txt_nroCalle.Size = New System.Drawing.Size(38, 20)
        Me.txt_nroCalle.TabIndex = 10
        Me.txt_nroCalle.ValidatingType = GetType(Integer)
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
        Me.txt_codNadador.Location = New System.Drawing.Point(168, 29)
        Me.txt_codNadador.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_codNadador.Mask = "999999"
        Me.txt_codNadador.Name = "txt_codNadador"
        Me.txt_codNadador.Size = New System.Drawing.Size(43, 20)
        Me.txt_codNadador.TabIndex = 0
        Me.txt_codNadador.ValidatingType = GetType(String)
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc._BDdato = False
        Me.txt_nroDoc._BDnombreCampoTabla = ""
        Me.txt_nroDoc._BDvalor = ""
        Me.txt_nroDoc._descriptor_del_contenido = ""
        Me.txt_nroDoc._Gest_AnchoTexto = 0
        Me.txt_nroDoc._Gest_decimales = 0
        Me.txt_nroDoc._Gest_enteros = "0"
        Me.txt_nroDoc._Gest_mensajeError = ""
        Me.txt_nroDoc._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_nroDoc._Gest_ReadOnly = False
        Me.txt_nroDoc._Gest_TextoNegrita = False
        Me.txt_nroDoc._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_nroDoc._Gest_validar = True
        Me.txt_nroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_nroDoc.Location = New System.Drawing.Point(168, 164)
        Me.txt_nroDoc.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_nroDoc.Mask = "999999999"
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(76, 20)
        Me.txt_nroDoc.TabIndex = 5
        Me.txt_nroDoc.ValidatingType = GetType(String)
        '
        'cmd_nuevoProfe
        '
        Me.cmd_nuevoProfe.Location = New System.Drawing.Point(546, 142)
        Me.cmd_nuevoProfe.Name = "cmd_nuevoProfe"
        Me.cmd_nuevoProfe.Size = New System.Drawing.Size(95, 22)
        Me.cmd_nuevoProfe.TabIndex = 14
        Me.cmd_nuevoProfe.Text = "Nuevo Profesor"
        Me.cmd_nuevoProfe.UseVisualStyleBackColor = True
        '
        'cmd_nuevoCP
        '
        Me.cmd_nuevoCP.Location = New System.Drawing.Point(526, 88)
        Me.cmd_nuevoCP.Name = "cmd_nuevoCP"
        Me.cmd_nuevoCP.Size = New System.Drawing.Size(66, 23)
        Me.cmd_nuevoCP.TabIndex = 12
        Me.cmd_nuevoCP.Text = "Nuevo CP"
        Me.cmd_nuevoCP.UseVisualStyleBackColor = True
        '
        'cmb_club
        '
        Me.cmb_club.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_club.FormattingEnabled = True
        Me.cmb_club.Location = New System.Drawing.Point(467, 170)
        Me.cmb_club.Name = "cmb_club"
        Me.cmb_club.Size = New System.Drawing.Size(174, 21)
        Me.cmb_club.TabIndex = 13
        '
        'cmb_profesor
        '
        Me.cmb_profesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_profesor.FormattingEnabled = True
        Me.cmb_profesor.Location = New System.Drawing.Point(467, 115)
        Me.cmb_profesor.Name = "cmb_profesor"
        Me.cmb_profesor.Size = New System.Drawing.Size(174, 21)
        Me.cmb_profesor.TabIndex = 13
        '
        'cmb_codPos
        '
        Me.cmb_codPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_codPos.FormattingEnabled = True
        Me.cmb_codPos.Location = New System.Drawing.Point(467, 88)
        Me.cmb_codPos.Name = "cmb_codPos"
        Me.cmb_codPos.Size = New System.Drawing.Size(53, 21)
        Me.cmb_codPos.TabIndex = 11
        '
        'lbl_club
        '
        Me.lbl_club.AutoSize = True
        Me.lbl_club.Location = New System.Drawing.Point(424, 173)
        Me.lbl_club.Name = "lbl_club"
        Me.lbl_club.Size = New System.Drawing.Size(28, 13)
        Me.lbl_club.TabIndex = 0
        Me.lbl_club.Text = "Club"
        '
        'lbl_profesor
        '
        Me.lbl_profesor.AutoSize = True
        Me.lbl_profesor.Location = New System.Drawing.Point(415, 123)
        Me.lbl_profesor.Name = "lbl_profesor"
        Me.lbl_profesor.Size = New System.Drawing.Size(46, 13)
        Me.lbl_profesor.TabIndex = 0
        Me.lbl_profesor.Text = "Profesor"
        '
        'lbl_codNadador
        '
        Me.lbl_codNadador.AutoSize = True
        Me.lbl_codNadador.Location = New System.Drawing.Point(78, 32)
        Me.lbl_codNadador.Name = "lbl_codNadador"
        Me.lbl_codNadador.Size = New System.Drawing.Size(88, 13)
        Me.lbl_codNadador.TabIndex = 1
        Me.lbl_codNadador.Text = "Código Nadador*"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grid_nadadores)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(746, 237)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nadadores Registrados"
        '
        'grid_nadadores
        '
        Me.grid_nadadores.AllowUserToAddRows = False
        Me.grid_nadadores.AllowUserToDeleteRows = False
        Me.grid_nadadores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_nadadores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_nadadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_nadadores.Location = New System.Drawing.Point(6, 18)
        Me.grid_nadadores.Name = "grid_nadadores"
        Me.grid_nadadores.ReadOnly = True
        Me.grid_nadadores.RowHeadersVisible = False
        Me.grid_nadadores.Size = New System.Drawing.Size(732, 211)
        Me.grid_nadadores.TabIndex = 0
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Image = Global.Asociacion.My.Resources.Resources.delete
        Me.cmd_eliminar.Location = New System.Drawing.Point(125, 523)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_eliminar.TabIndex = 2
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'frm_ABMnadadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 580)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frm_ABMnadadores"
        Me.Text = "Nadadores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid_nadadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipoDoc As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents lbl_sexo As System.Windows.Forms.Label
    Friend WithEvents opt_masculino As System.Windows.Forms.RadioButton
    Friend WithEvents opt_femenino As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents msk_fechaNacimiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents lbl_codPostal As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents grid_nadadores As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_codPos As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_nuevoProfe As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevoCP As System.Windows.Forms.Button
    Friend WithEvents cmb_profesor As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_profesor As System.Windows.Forms.Label
    Friend WithEvents txt_nroDoc As Asociacion.TextBoxv01
    Friend WithEvents txt_nroCalle As Asociacion.TextBoxv01
    Friend WithEvents txt_codNadador As Asociacion.TextBoxv01
    Friend WithEvents lbl_codNadador As System.Windows.Forms.Label
    Friend WithEvents cmd_nuevoClub As System.Windows.Forms.Button
    Friend WithEvents cmb_club As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_club As System.Windows.Forms.Label

End Class
