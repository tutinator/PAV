<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AMBnadadores
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
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.cbo_tipoDoc = New System.Windows.Forms.ComboBox()
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
        Me.lst_nadadores = New System.Windows.Forms.ListBox()
        Me.txt_nroDoc = New System.Windows.Forms.TextBox()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.txt_nroCalle = New System.Windows.Forms.TextBox()
        Me.txt_codPostal = New System.Windows.Forms.TextBox()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMNadadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(83, 80)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(83, 47)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(133, 77)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(145, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(133, 44)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(145, 20)
        Me.txt_apellido.TabIndex = 2
        '
        'cbo_tipoDoc
        '
        Me.cbo_tipoDoc.FormattingEnabled = True
        Me.cbo_tipoDoc.Location = New System.Drawing.Point(133, 143)
        Me.cbo_tipoDoc.Name = "cbo_tipoDoc"
        Me.cbo_tipoDoc.Size = New System.Drawing.Size(125, 21)
        Me.cbo_tipoDoc.TabIndex = 3
        '
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(28, 147)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(99, 13)
        Me.lbl_tipoDoc.TabIndex = 0
        Me.lbl_tipoDoc.Text = "Tipo de documento"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(33, 213)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(94, 13)
        Me.lbl_email.TabIndex = 0
        Me.lbl_email.Text = "Correo Electrónico"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(133, 210)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(145, 20)
        Me.txt_email.TabIndex = 2
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Location = New System.Drawing.Point(59, 254)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_sexo.TabIndex = 0
        Me.lbl_sexo.Text = "Sexo"
        '
        'opt_masculino
        '
        Me.opt_masculino.AutoSize = True
        Me.opt_masculino.Location = New System.Drawing.Point(113, 252)
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
        Me.opt_femenino.Location = New System.Drawing.Point(207, 252)
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
        Me.Label1.Location = New System.Drawing.Point(12, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha de nacimiento"
        '
        'msk_fechaNacimiento
        '
        Me.msk_fechaNacimiento.Location = New System.Drawing.Point(133, 110)
        Me.msk_fechaNacimiento.Mask = "00/00/0000"
        Me.msk_fechaNacimiento.Name = "msk_fechaNacimiento"
        Me.msk_fechaNacimiento.Size = New System.Drawing.Size(77, 20)
        Me.msk_fechaNacimiento.TabIndex = 6
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(97, 295)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(30, 13)
        Me.lbl_calle.TabIndex = 0
        Me.lbl_calle.Text = "Calle"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(83, 325)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(44, 13)
        Me.lbl_numero.TabIndex = 0
        Me.lbl_numero.Text = "Número"
        '
        'lbl_codPostal
        '
        Me.lbl_codPostal.AutoSize = True
        Me.lbl_codPostal.Location = New System.Drawing.Point(56, 351)
        Me.lbl_codPostal.Name = "lbl_codPostal"
        Me.lbl_codPostal.Size = New System.Drawing.Size(71, 13)
        Me.lbl_codPostal.TabIndex = 0
        Me.lbl_codPostal.Text = "Código postal"
        '
        'lst_nadadores
        '
        Me.lst_nadadores.FormattingEnabled = True
        Me.lst_nadadores.Location = New System.Drawing.Point(302, 44)
        Me.lst_nadadores.Name = "lst_nadadores"
        Me.lst_nadadores.Size = New System.Drawing.Size(251, 329)
        Me.lst_nadadores.TabIndex = 7
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc.Location = New System.Drawing.Point(133, 177)
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(125, 20)
        Me.txt_nroDoc.TabIndex = 2
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(133, 292)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(145, 20)
        Me.txt_calle.TabIndex = 2
        '
        'txt_nroCalle
        '
        Me.txt_nroCalle.Location = New System.Drawing.Point(133, 322)
        Me.txt_nroCalle.Name = "txt_nroCalle"
        Me.txt_nroCalle.Size = New System.Drawing.Size(53, 20)
        Me.txt_nroCalle.TabIndex = 2
        '
        'txt_codPostal
        '
        Me.txt_codPostal.Location = New System.Drawing.Point(133, 348)
        Me.txt_codPostal.Name = "txt_codPostal"
        Me.txt_codPostal.Size = New System.Drawing.Size(53, 20)
        Me.txt_codPostal.TabIndex = 2
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(15, 410)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.cmd_nuevo.TabIndex = 8
        Me.cmd_nuevo.Text = "Crear"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(71, 410)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_guardar.TabIndex = 8
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(127, 410)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_cancelar.TabIndex = 8
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(228, 410)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_buscar.TabIndex = 8
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Location = New System.Drawing.Point(510, 410)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 8
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(13, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 359)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nadador"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(296, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 359)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nadadores Registrados"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(572, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HolaToolStripMenuItem
        '
        Me.HolaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormularToolStripMenuItem})
        Me.HolaToolStripMenuItem.Name = "HolaToolStripMenuItem"
        Me.HolaToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.HolaToolStripMenuItem.Text = "Ver"
        '
        'FormularToolStripMenuItem
        '
        Me.FormularToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMNadadoresToolStripMenuItem})
        Me.FormularToolStripMenuItem.Name = "FormularToolStripMenuItem"
        Me.FormularToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FormularToolStripMenuItem.Text = "Formulario"
        '
        'ABMNadadoresToolStripMenuItem
        '
        Me.ABMNadadoresToolStripMenuItem.Name = "ABMNadadoresToolStripMenuItem"
        Me.ABMNadadoresToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ABMNadadoresToolStripMenuItem.Text = "ABM Nadadores"
        '
        'frm_AMBnadadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 498)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.lst_nadadores)
        Me.Controls.Add(Me.msk_fechaNacimiento)
        Me.Controls.Add(Me.opt_femenino)
        Me.Controls.Add(Me.opt_masculino)
        Me.Controls.Add(Me.cbo_tipoDoc)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nroDoc)
        Me.Controls.Add(Me.txt_codPostal)
        Me.Controls.Add(Me.txt_nroCalle)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_codPostal)
        Me.Controls.Add(Me.lbl_tipoDoc)
        Me.Controls.Add(Me.lbl_numero)
        Me.Controls.Add(Me.lbl_sexo)
        Me.Controls.Add(Me.lbl_calle)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_AMBnadadores"
        Me.Text = "Nadadores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents cbo_tipoDoc As System.Windows.Forms.ComboBox
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
    Friend WithEvents lst_nadadores As System.Windows.Forms.ListBox
    Friend WithEvents txt_nroDoc As System.Windows.Forms.TextBox
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents txt_nroCalle As System.Windows.Forms.TextBox
    Friend WithEvents txt_codPostal As System.Windows.Forms.TextBox
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HolaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMNadadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
