<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ABMclubes
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
        Me.cmb_codPos = New System.Windows.Forms.ComboBox()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_codPostal = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.txt_telefono = New Asociacion.TextBoxv01()
        Me.txt_nroCalle = New Asociacion.TextBoxv01()
        Me.txt_codClub = New Asociacion.TextBoxv01()
        Me.cmd_nuevoCP = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_nuevoCP)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.txt_nroCalle)
        Me.GroupBox1.Controls.Add(Me.txt_codClub)
        Me.GroupBox1.Controls.Add(Me.cmb_codPos)
        Me.GroupBox1.Controls.Add(Me.txt_calle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_codPostal)
        Me.GroupBox1.Controls.Add(Me.lbl_numero)
        Me.GroupBox1.Controls.Add(Me.lbl_calle)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 255)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Club"
        '
        'cmb_codPos
        '
        Me.cmb_codPos.FormattingEnabled = True
        Me.cmb_codPos.Location = New System.Drawing.Point(87, 129)
        Me.cmb_codPos.Name = "cmb_codPos"
        Me.cmb_codPos.Size = New System.Drawing.Size(89, 21)
        Me.cmb_codPos.TabIndex = 4
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(87, 81)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(145, 20)
        Me.txt_calle.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Teléfono"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(87, 57)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(145, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'lbl_codPostal
        '
        Me.lbl_codPostal.AutoSize = True
        Me.lbl_codPostal.Location = New System.Drawing.Point(10, 135)
        Me.lbl_codPostal.Name = "lbl_codPostal"
        Me.lbl_codPostal.Size = New System.Drawing.Size(71, 13)
        Me.lbl_codPostal.TabIndex = 3
        Me.lbl_codPostal.Text = "Código postal"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(37, 110)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(44, 13)
        Me.lbl_numero.TabIndex = 4
        Me.lbl_numero.Text = "Número"
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(51, 85)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(30, 13)
        Me.lbl_calle.TabIndex = 5
        Me.lbl_calle.Text = "Calle"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código Club"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(37, 60)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 6
        Me.lbl_nombre.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(265, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 255)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Clubes registrados"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 216)
        Me.DataGridView1.TabIndex = 0
        '
        'cmd_salir
        '
        Me.cmd_salir.Location = New System.Drawing.Point(477, 274)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 6
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(276, 274)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_buscar.TabIndex = 5
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(126, 274)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_eliminar.TabIndex = 3
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(70, 274)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_guardar.TabIndex = 2
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(14, 274)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.cmd_nuevo.TabIndex = 1
        Me.cmd_nuevo.Text = "Crear"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(182, 274)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_cancelar.TabIndex = 4
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'txt_telefono
        '
        Me.txt_telefono._BDdato = False
        Me.txt_telefono._BDnombreCampoTabla = ""
        Me.txt_telefono._BDvalor = ""
        Me.txt_telefono._descriptor_del_contenido = ""
        Me.txt_telefono._Gest_AnchoTexto = 0
        Me.txt_telefono._Gest_decimales = 0
        Me.txt_telefono._Gest_enteros = "0"
        Me.txt_telefono._Gest_mensajeError = ""
        Me.txt_telefono._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_telefono._Gest_ReadOnly = False
        Me.txt_telefono._Gest_TextoNegrita = False
        Me.txt_telefono._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_telefono._Gest_validar = True
        Me.txt_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_telefono.Location = New System.Drawing.Point(87, 154)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_telefono.Mask = "99999999999999"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 5
        Me.txt_telefono.ValidatingType = GetType(String)
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
        Me.txt_nroCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nroCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_nroCalle.Location = New System.Drawing.Point(87, 105)
        Me.txt_nroCalle.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_nroCalle.Mask = "99999"
        Me.txt_nroCalle.Name = "txt_nroCalle"
        Me.txt_nroCalle.Size = New System.Drawing.Size(100, 20)
        Me.txt_nroCalle.TabIndex = 3
        Me.txt_nroCalle.ValidatingType = GetType(Integer)
        '
        'txt_codClub
        '
        Me.txt_codClub._BDdato = False
        Me.txt_codClub._BDnombreCampoTabla = ""
        Me.txt_codClub._BDvalor = ""
        Me.txt_codClub._descriptor_del_contenido = ""
        Me.txt_codClub._Gest_AnchoTexto = 0
        Me.txt_codClub._Gest_decimales = 0
        Me.txt_codClub._Gest_enteros = "0"
        Me.txt_codClub._Gest_mensajeError = ""
        Me.txt_codClub._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_codClub._Gest_ReadOnly = False
        Me.txt_codClub._Gest_TextoNegrita = True
        Me.txt_codClub._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_codClub._Gest_validar = True
        Me.txt_codClub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_codClub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txt_codClub.Location = New System.Drawing.Point(87, 33)
        Me.txt_codClub.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_codClub.Mask = "99999"
        Me.txt_codClub.Name = "txt_codClub"
        Me.txt_codClub.Size = New System.Drawing.Size(42, 20)
        Me.txt_codClub.TabIndex = 0
        Me.txt_codClub.ValidatingType = GetType(Integer)
        '
        'cmd_nuevoCP
        '
        Me.cmd_nuevoCP.Location = New System.Drawing.Point(182, 129)
        Me.cmd_nuevoCP.Name = "cmd_nuevoCP"
        Me.cmd_nuevoCP.Size = New System.Drawing.Size(64, 21)
        Me.cmd_nuevoCP.TabIndex = 7
        Me.cmd_nuevoCP.Text = "Nuevo CP"
        Me.cmd_nuevoCP.UseVisualStyleBackColor = True
        '
        'frm_ABMclubes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 333)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_ABMclubes"
        Me.Text = "Gestión de Clubes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents lbl_codPostal As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmb_codPos As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_codClub As Asociacion.TextBoxv01
    Friend WithEvents txt_nroCalle As Asociacion.TextBoxv01
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As Asociacion.TextBoxv01
    Friend WithEvents cmd_nuevoCP As System.Windows.Forms.Button
End Class
