<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proc_profesxclub
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
        Me.gbo_profesor = New System.Windows.Forms.GroupBox()
        Me.cmd_nuevoprof = New System.Windows.Forms.Button()
        Me.cmd_buscarProf = New System.Windows.Forms.Button()
        Me.txt_codProfesor = New Asociacion.TextBoxv01()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nombre_profesor = New System.Windows.Forms.Label()
        Me.lbl_codigo_profesor = New System.Windows.Forms.Label()
        Me.txt_apellido_profesor = New System.Windows.Forms.TextBox()
        Me.txt_nombre_profesor = New System.Windows.Forms.TextBox()
        Me.lbl_apellido_profesor = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_nuevoClub = New System.Windows.Forms.Button()
        Me.cmb_club = New System.Windows.Forms.ComboBox()
        Me.grid_profxclub = New System.Windows.Forms.DataGridView()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.gbo_profesor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid_profxclub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbo_profesor
        '
        Me.gbo_profesor.Controls.Add(Me.cmd_nuevoprof)
        Me.gbo_profesor.Controls.Add(Me.cmd_buscarProf)
        Me.gbo_profesor.Controls.Add(Me.txt_codProfesor)
        Me.gbo_profesor.Controls.Add(Me.Label1)
        Me.gbo_profesor.Controls.Add(Me.lbl_nombre_profesor)
        Me.gbo_profesor.Controls.Add(Me.lbl_codigo_profesor)
        Me.gbo_profesor.Controls.Add(Me.txt_apellido_profesor)
        Me.gbo_profesor.Controls.Add(Me.txt_nombre_profesor)
        Me.gbo_profesor.Location = New System.Drawing.Point(12, 12)
        Me.gbo_profesor.Name = "gbo_profesor"
        Me.gbo_profesor.Size = New System.Drawing.Size(487, 93)
        Me.gbo_profesor.TabIndex = 1
        Me.gbo_profesor.TabStop = False
        Me.gbo_profesor.Text = "Profesor"
        '
        'cmd_nuevoprof
        '
        Me.cmd_nuevoprof.Location = New System.Drawing.Point(343, 20)
        Me.cmd_nuevoprof.Name = "cmd_nuevoprof"
        Me.cmd_nuevoprof.Size = New System.Drawing.Size(93, 23)
        Me.cmd_nuevoprof.TabIndex = 21
        Me.cmd_nuevoprof.Text = "Nuevo Profesor"
        Me.cmd_nuevoprof.UseVisualStyleBackColor = True
        '
        'cmd_buscarProf
        '
        Me.cmd_buscarProf.BackgroundImage = Global.Asociacion.My.Resources.Resources.buscar
        Me.cmd_buscarProf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscarProf.Location = New System.Drawing.Point(166, 14)
        Me.cmd_buscarProf.Name = "cmd_buscarProf"
        Me.cmd_buscarProf.Size = New System.Drawing.Size(35, 35)
        Me.cmd_buscarProf.TabIndex = 2
        Me.cmd_buscarProf.UseVisualStyleBackColor = True
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
        Me.txt_codProfesor.Location = New System.Drawing.Point(101, 22)
        Me.txt_codProfesor.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_codProfesor.Mask = "99999"
        Me.txt_codProfesor.Name = "txt_codProfesor"
        Me.txt_codProfesor.Size = New System.Drawing.Size(42, 20)
        Me.txt_codProfesor.TabIndex = 0
        Me.txt_codProfesor.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Apellido"
        '
        'lbl_nombre_profesor
        '
        Me.lbl_nombre_profesor.AutoSize = True
        Me.lbl_nombre_profesor.Location = New System.Drawing.Point(273, 62)
        Me.lbl_nombre_profesor.Name = "lbl_nombre_profesor"
        Me.lbl_nombre_profesor.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre_profesor.TabIndex = 18
        Me.lbl_nombre_profesor.Text = "Nombre"
        '
        'lbl_codigo_profesor
        '
        Me.lbl_codigo_profesor.AutoSize = True
        Me.lbl_codigo_profesor.Location = New System.Drawing.Point(15, 25)
        Me.lbl_codigo_profesor.Name = "lbl_codigo_profesor"
        Me.lbl_codigo_profesor.Size = New System.Drawing.Size(86, 13)
        Me.lbl_codigo_profesor.TabIndex = 20
        Me.lbl_codigo_profesor.Text = "Código Profesor*"
        '
        'txt_apellido_profesor
        '
        Me.txt_apellido_profesor.Location = New System.Drawing.Point(101, 59)
        Me.txt_apellido_profesor.Name = "txt_apellido_profesor"
        Me.txt_apellido_profesor.Size = New System.Drawing.Size(145, 20)
        Me.txt_apellido_profesor.TabIndex = 1
        '
        'txt_nombre_profesor
        '
        Me.txt_nombre_profesor.Location = New System.Drawing.Point(323, 59)
        Me.txt_nombre_profesor.Name = "txt_nombre_profesor"
        Me.txt_nombre_profesor.Size = New System.Drawing.Size(145, 20)
        Me.txt_nombre_profesor.TabIndex = 2
        '
        'lbl_apellido_profesor
        '
        Me.lbl_apellido_profesor.AutoSize = True
        Me.lbl_apellido_profesor.Location = New System.Drawing.Point(67, 28)
        Me.lbl_apellido_profesor.Name = "lbl_apellido_profesor"
        Me.lbl_apellido_profesor.Size = New System.Drawing.Size(28, 13)
        Me.lbl_apellido_profesor.TabIndex = 20
        Me.lbl_apellido_profesor.Text = "Club"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_nuevoClub)
        Me.GroupBox1.Controls.Add(Me.cmb_club)
        Me.GroupBox1.Controls.Add(Me.lbl_apellido_profesor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 72)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Club"
        '
        'cmd_nuevoClub
        '
        Me.cmd_nuevoClub.Location = New System.Drawing.Point(343, 28)
        Me.cmd_nuevoClub.Name = "cmd_nuevoClub"
        Me.cmd_nuevoClub.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevoClub.TabIndex = 22
        Me.cmd_nuevoClub.Text = "Nuevo Club"
        Me.cmd_nuevoClub.UseVisualStyleBackColor = True
        '
        'cmb_club
        '
        Me.cmb_club.FormattingEnabled = True
        Me.cmb_club.Location = New System.Drawing.Point(101, 25)
        Me.cmb_club.Name = "cmb_club"
        Me.cmb_club.Size = New System.Drawing.Size(145, 21)
        Me.cmb_club.TabIndex = 21
        '
        'grid_profxclub
        '
        Me.grid_profxclub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_profxclub.Location = New System.Drawing.Point(13, 190)
        Me.grid_profxclub.Name = "grid_profxclub"
        Me.grid_profxclub.Size = New System.Drawing.Size(486, 176)
        Me.grid_profxclub.TabIndex = 23
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.Asociacion.My.Resources.Resources.salir
        Me.cmd_salir.Location = New System.Drawing.Point(449, 372)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 29
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_cancelar.Location = New System.Drawing.Point(178, 372)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_cancelar.TabIndex = 27
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Image = Global.Asociacion.My.Resources.Resources.delete
        Me.cmd_eliminar.Location = New System.Drawing.Point(122, 372)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_eliminar.TabIndex = 26
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Asociacion.My.Resources.Resources.save
        Me.cmd_guardar.Location = New System.Drawing.Point(66, 372)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_guardar.TabIndex = 25
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = Global.Asociacion.My.Resources.Resources.add
        Me.cmd_nuevo.Location = New System.Drawing.Point(10, 372)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.cmd_nuevo.TabIndex = 24
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'proc_profesxclub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 427)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grid_profxclub)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbo_profesor)
        Me.Name = "proc_profesxclub"
        Me.Text = "Profesores por club"
        Me.gbo_profesor.ResumeLayout(False)
        Me.gbo_profesor.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid_profxclub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbo_profesor As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_buscarProf As System.Windows.Forms.Button
    Friend WithEvents txt_codProfesor As Asociacion.TextBoxv01
    Friend WithEvents lbl_nombre_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido_profesor As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_profesor As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_profesor As System.Windows.Forms.TextBox
    Friend WithEvents cmd_nuevoprof As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_club As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_nuevoClub As System.Windows.Forms.Button
    Friend WithEvents grid_profxclub As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
End Class
