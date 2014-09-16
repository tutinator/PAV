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
        Me.txt_nroCalle = New Asociacion.TextBoxv01()
        Me.txt_nroDoc = New Asociacion.TextBoxv01()
        Me.cmd_nuevoProfe = New System.Windows.Forms.Button()
        Me.cmd_nuevoCP = New System.Windows.Forms.Button()
        Me.cmb_profesor = New System.Windows.Forms.ComboBox()
        Me.cmb_codPos = New System.Windows.Forms.ComboBox()
        Me.lbl_profesor = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(77, 54)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(57, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre (*)"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(77, 22)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(57, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido (*)"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(140, 51)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(145, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(140, 19)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(145, 20)
        Me.txt_apellido.TabIndex = 2
        '
        'cmb_tipoDoc
        '
        Me.cmb_tipoDoc.FormattingEnabled = True
        Me.cmb_tipoDoc.Location = New System.Drawing.Point(140, 115)
        Me.cmb_tipoDoc.Name = "cmb_tipoDoc"
        Me.cmb_tipoDoc.Size = New System.Drawing.Size(125, 21)
        Me.cmb_tipoDoc.TabIndex = 3
        '
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(22, 118)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(112, 13)
        Me.lbl_tipoDoc.TabIndex = 0
        Me.lbl_tipoDoc.Text = "Tipo de documento (*)"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(40, 182)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(94, 13)
        Me.lbl_email.TabIndex = 0
        Me.lbl_email.Text = "Correo Electrónico"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(140, 180)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(145, 20)
        Me.txt_email.TabIndex = 2
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Location = New System.Drawing.Point(59, 239)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(44, 13)
        Me.lbl_sexo.TabIndex = 0
        Me.lbl_sexo.Text = "Sexo (*)"
        '
        'opt_masculino
        '
        Me.opt_masculino.AutoSize = True
        Me.opt_masculino.Location = New System.Drawing.Point(113, 237)
        Me.opt_masculino.Name = "opt_masculino"
        Me.opt_masculino.Size = New System.Drawing.Size(73, 17)
        Me.opt_masculino.TabIndex = 4
        Me.opt_masculino.TabStop = True
        Me.opt_masculino.Text = "Masculino"
        Me.opt_masculino.UseVisualStyleBackColor = True
        '
        'opt_femenino
        '
        Me.opt_femenino.AutoSize = True
        Me.opt_femenino.Location = New System.Drawing.Point(207, 237)
        Me.opt_femenino.Name = "opt_femenino"
        Me.opt_femenino.Size = New System.Drawing.Size(71, 17)
        Me.opt_femenino.TabIndex = 5
        Me.opt_femenino.TabStop = True
        Me.opt_femenino.Text = "Femenino"
        Me.opt_femenino.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de documento (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha de nacimiento"
        '
        'msk_fechaNacimiento
        '
        Me.msk_fechaNacimiento.Location = New System.Drawing.Point(140, 83)
        Me.msk_fechaNacimiento.Mask = "00/00/0000"
        Me.msk_fechaNacimiento.Name = "msk_fechaNacimiento"
        Me.msk_fechaNacimiento.Size = New System.Drawing.Size(77, 20)
        Me.msk_fechaNacimiento.TabIndex = 6
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(104, 265)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(30, 13)
        Me.lbl_calle.TabIndex = 0
        Me.lbl_calle.Text = "Calle"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(90, 293)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(44, 13)
        Me.lbl_numero.TabIndex = 0
        Me.lbl_numero.Text = "Número"
        '
        'lbl_codPostal
        '
        Me.lbl_codPostal.AutoSize = True
        Me.lbl_codPostal.Location = New System.Drawing.Point(63, 326)
        Me.lbl_codPostal.Name = "lbl_codPostal"
        Me.lbl_codPostal.Size = New System.Drawing.Size(71, 13)
        Me.lbl_codPostal.TabIndex = 0
        Me.lbl_codPostal.Text = "Código postal"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(140, 265)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(145, 20)
        Me.txt_calle.TabIndex = 2
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = Global.Asociacion.My.Resources.Resources.add
        Me.cmd_nuevo.Location = New System.Drawing.Point(15, 436)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.cmd_nuevo.TabIndex = 8
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Asociacion.My.Resources.Resources.save
        Me.cmd_guardar.Location = New System.Drawing.Point(71, 436)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_guardar.TabIndex = 8
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_cancelar.Location = New System.Drawing.Point(183, 436)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_cancelar.TabIndex = 8
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.Asociacion.My.Resources.Resources.buscar
        Me.cmd_buscar.Location = New System.Drawing.Point(335, 436)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_buscar.TabIndex = 8
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.Asociacion.My.Resources.Resources.salir
        Me.cmd_salir.Location = New System.Drawing.Point(606, 436)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 8
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_nroCalle)
        Me.GroupBox1.Controls.Add(Me.txt_nroDoc)
        Me.GroupBox1.Controls.Add(Me.cmd_nuevoProfe)
        Me.GroupBox1.Controls.Add(Me.cmd_nuevoCP)
        Me.GroupBox1.Controls.Add(Me.cmb_profesor)
        Me.GroupBox1.Controls.Add(Me.cmb_codPos)
        Me.GroupBox1.Controls.Add(Me.msk_fechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.lbl_profesor)
        Me.GroupBox1.Controls.Add(Me.lbl_numero)
        Me.GroupBox1.Controls.Add(Me.lbl_codPostal)
        Me.GroupBox1.Controls.Add(Me.txt_calle)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.lbl_calle)
        Me.GroupBox1.Controls.Add(Me.lbl_apellido)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Controls.Add(Me.cmb_tipoDoc)
        Me.GroupBox1.Controls.Add(Me.lbl_email)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_tipoDoc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 418)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nadador"
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
        Me.txt_nroCalle.Location = New System.Drawing.Point(140, 290)
        Me.txt_nroCalle.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_nroCalle.Mask = "99999"
        Me.txt_nroCalle.Name = "txt_nroCalle"
        Me.txt_nroCalle.Size = New System.Drawing.Size(43, 20)
        Me.txt_nroCalle.TabIndex = 3
        Me.txt_nroCalle.ValidatingType = GetType(Integer)
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
        Me.txt_nroDoc.Location = New System.Drawing.Point(140, 148)
        Me.txt_nroDoc.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_nroDoc.Mask = "999999999"
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(76, 20)
        Me.txt_nroDoc.TabIndex = 2
        Me.txt_nroDoc.ValidatingType = GetType(String)
        '
        'cmd_nuevoProfe
        '
        Me.cmd_nuevoProfe.Location = New System.Drawing.Point(190, 375)
        Me.cmd_nuevoProfe.Name = "cmd_nuevoProfe"
        Me.cmd_nuevoProfe.Size = New System.Drawing.Size(95, 22)
        Me.cmd_nuevoProfe.TabIndex = 1
        Me.cmd_nuevoProfe.Text = "Nuevo Profesor"
        Me.cmd_nuevoProfe.UseVisualStyleBackColor = True
        '
        'cmd_nuevoCP
        '
        Me.cmd_nuevoCP.Location = New System.Drawing.Point(199, 321)
        Me.cmd_nuevoCP.Name = "cmd_nuevoCP"
        Me.cmd_nuevoCP.Size = New System.Drawing.Size(66, 23)
        Me.cmd_nuevoCP.TabIndex = 1
        Me.cmd_nuevoCP.Text = "Nuevo CP"
        Me.cmd_nuevoCP.UseVisualStyleBackColor = True
        '
        'cmb_profesor
        '
        Me.cmb_profesor.FormattingEnabled = True
        Me.cmb_profesor.Location = New System.Drawing.Point(140, 348)
        Me.cmb_profesor.Name = "cmb_profesor"
        Me.cmb_profesor.Size = New System.Drawing.Size(145, 21)
        Me.cmb_profesor.TabIndex = 0
        '
        'cmb_codPos
        '
        Me.cmb_codPos.FormattingEnabled = True
        Me.cmb_codPos.Location = New System.Drawing.Point(140, 321)
        Me.cmb_codPos.Name = "cmb_codPos"
        Me.cmb_codPos.Size = New System.Drawing.Size(53, 21)
        Me.cmb_codPos.TabIndex = 0
        '
        'lbl_profesor
        '
        Me.lbl_profesor.AutoSize = True
        Me.lbl_profesor.Location = New System.Drawing.Point(88, 356)
        Me.lbl_profesor.Name = "lbl_profesor"
        Me.lbl_profesor.Size = New System.Drawing.Size(46, 13)
        Me.lbl_profesor.TabIndex = 0
        Me.lbl_profesor.Text = "Profesor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(328, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 418)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nadadores Registrados"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(321, 392)
        Me.DataGridView1.TabIndex = 0
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Image = Global.Asociacion.My.Resources.Resources.delete
        Me.cmd_eliminar.Location = New System.Drawing.Point(127, 436)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_eliminar.TabIndex = 8
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'frm_ABMnadadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 498)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.opt_femenino)
        Me.Controls.Add(Me.opt_masculino)
        Me.Controls.Add(Me.lbl_sexo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frm_ABMnadadores"
        Me.Text = "Nadadores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_codPos As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_nuevoProfe As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevoCP As System.Windows.Forms.Button
    Friend WithEvents cmb_profesor As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_profesor As System.Windows.Forms.Label
    Friend WithEvents txt_nroDoc As Asociacion.TextBoxv01
    Friend WithEvents txt_nroCalle As Asociacion.TextBoxv01

End Class
