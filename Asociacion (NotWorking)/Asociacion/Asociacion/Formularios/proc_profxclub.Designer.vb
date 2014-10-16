<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proc_profxclub
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grid_profxclub = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_buscarProf = New System.Windows.Forms.Button()
        Me.txt_codProfesor = New Asociacion.TextBoxv01()
        Me.cmd_nuevoProfesor = New System.Windows.Forms.Button()
        Me.lbl_nombre_profesor = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_codigo_profesor = New System.Windows.Forms.Label()
        Me.txt_apellido_profesor = New System.Windows.Forms.TextBox()
        Me.lbl_apellido_profesor = New System.Windows.Forms.Label()
        Me.txt_nombre_profesor = New System.Windows.Forms.TextBox()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_club = New System.Windows.Forms.ComboBox()
        Me.cmd_nuevoClub = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid_profxclub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grid_profxclub)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(661, 184)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profesores de clubes"
        '
        'grid_profxclub
        '
        Me.grid_profxclub.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_profxclub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_profxclub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_profxclub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_profxclub.Location = New System.Drawing.Point(6, 19)
        Me.grid_profxclub.Name = "grid_profxclub"
        Me.grid_profxclub.ReadOnly = True
        Me.grid_profxclub.Size = New System.Drawing.Size(649, 159)
        Me.grid_profxclub.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_buscarProf)
        Me.GroupBox1.Controls.Add(Me.txt_codProfesor)
        Me.GroupBox1.Controls.Add(Me.cmd_nuevoProfesor)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre_profesor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_codigo_profesor)
        Me.GroupBox1.Controls.Add(Me.txt_apellido_profesor)
        Me.GroupBox1.Controls.Add(Me.lbl_apellido_profesor)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_profesor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 89)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profesor"
        '
        'cmd_buscarProf
        '
        Me.cmd_buscarProf.Location = New System.Drawing.Point(143, 20)
        Me.cmd_buscarProf.Name = "cmd_buscarProf"
        Me.cmd_buscarProf.Size = New System.Drawing.Size(26, 23)
        Me.cmd_buscarProf.TabIndex = 31
        Me.cmd_buscarProf.Text = "..."
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
        Me.txt_codProfesor.Location = New System.Drawing.Point(96, 22)
        Me.txt_codProfesor.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_codProfesor.Mask = "99999"
        Me.txt_codProfesor.Name = "txt_codProfesor"
        Me.txt_codProfesor.Size = New System.Drawing.Size(42, 20)
        Me.txt_codProfesor.TabIndex = 25
        Me.txt_codProfesor.ValidatingType = GetType(Integer)
        '
        'cmd_nuevoProfesor
        '
        Me.cmd_nuevoProfesor.Location = New System.Drawing.Point(513, 46)
        Me.cmd_nuevoProfesor.Name = "cmd_nuevoProfesor"
        Me.cmd_nuevoProfesor.Size = New System.Drawing.Size(93, 23)
        Me.cmd_nuevoProfesor.TabIndex = 1
        Me.cmd_nuevoProfesor.Text = "Nuevo profesor"
        Me.cmd_nuevoProfesor.UseVisualStyleBackColor = True
        '
        'lbl_nombre_profesor
        '
        Me.lbl_nombre_profesor.AutoSize = True
        Me.lbl_nombre_profesor.Location = New System.Drawing.Point(269, 52)
        Me.lbl_nombre_profesor.Name = "lbl_nombre_profesor"
        Me.lbl_nombre_profesor.Size = New System.Drawing.Size(48, 13)
        Me.lbl_nombre_profesor.TabIndex = 28
        Me.lbl_nombre_profesor.Text = "Nombre*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 8
        '
        'lbl_codigo_profesor
        '
        Me.lbl_codigo_profesor.AutoSize = True
        Me.lbl_codigo_profesor.Location = New System.Drawing.Point(6, 24)
        Me.lbl_codigo_profesor.Name = "lbl_codigo_profesor"
        Me.lbl_codigo_profesor.Size = New System.Drawing.Size(86, 13)
        Me.lbl_codigo_profesor.TabIndex = 29
        Me.lbl_codigo_profesor.Text = "Código Profesor*"
        '
        'txt_apellido_profesor
        '
        Me.txt_apellido_profesor.Location = New System.Drawing.Point(96, 49)
        Me.txt_apellido_profesor.Name = "txt_apellido_profesor"
        Me.txt_apellido_profesor.Size = New System.Drawing.Size(145, 20)
        Me.txt_apellido_profesor.TabIndex = 26
        '
        'lbl_apellido_profesor
        '
        Me.lbl_apellido_profesor.AutoSize = True
        Me.lbl_apellido_profesor.Location = New System.Drawing.Point(42, 52)
        Me.lbl_apellido_profesor.Name = "lbl_apellido_profesor"
        Me.lbl_apellido_profesor.Size = New System.Drawing.Size(48, 13)
        Me.lbl_apellido_profesor.TabIndex = 30
        Me.lbl_apellido_profesor.Text = "Apellido*"
        '
        'txt_nombre_profesor
        '
        Me.txt_nombre_profesor.Location = New System.Drawing.Point(323, 49)
        Me.txt_nombre_profesor.Name = "txt_nombre_profesor"
        Me.txt_nombre_profesor.Size = New System.Drawing.Size(145, 20)
        Me.txt_nombre_profesor.TabIndex = 27
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.Asociacion.My.Resources.Resources.salir
        Me.cmd_salir.Location = New System.Drawing.Point(621, 382)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 23
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.Asociacion.My.Resources.Resources.buscar
        Me.cmd_buscar.Location = New System.Drawing.Point(464, 382)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_buscar.TabIndex = 22
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_cancelar.Location = New System.Drawing.Point(180, 382)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_cancelar.TabIndex = 21
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Image = Global.Asociacion.My.Resources.Resources.delete
        Me.cmd_eliminar.Location = New System.Drawing.Point(124, 382)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_eliminar.TabIndex = 20
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Asociacion.My.Resources.Resources.save
        Me.cmd_guardar.Location = New System.Drawing.Point(68, 382)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_guardar.TabIndex = 19
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = Global.Asociacion.My.Resources.Resources.add
        Me.cmd_nuevo.Location = New System.Drawing.Point(12, 382)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.cmd_nuevo.TabIndex = 18
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cmb_club)
        Me.GroupBox3.Controls.Add(Me.cmd_nuevoClub)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(660, 72)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Club"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Club"
        '
        'cmb_club
        '
        Me.cmb_club.FormattingEnabled = True
        Me.cmb_club.Location = New System.Drawing.Point(95, 26)
        Me.cmb_club.Name = "cmb_club"
        Me.cmb_club.Size = New System.Drawing.Size(144, 21)
        Me.cmb_club.TabIndex = 11
        '
        'cmd_nuevoClub
        '
        Me.cmd_nuevoClub.Location = New System.Drawing.Point(271, 24)
        Me.cmd_nuevoClub.Name = "cmd_nuevoClub"
        Me.cmd_nuevoClub.Size = New System.Drawing.Size(93, 23)
        Me.cmd_nuevoClub.TabIndex = 4
        Me.cmd_nuevoClub.Text = "Nuevo club"
        Me.cmd_nuevoClub.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 8
        '
        'proc_profxclub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 444)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "proc_profxclub"
        Me.Text = "Profesores por club"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid_profxclub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grid_profxclub As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_nuevoProfesor As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_codProfesor As Asociacion.TextBoxv01
    Friend WithEvents lbl_nombre_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_profesor As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_profesor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido_profesor As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_profesor As System.Windows.Forms.TextBox
    Friend WithEvents cmd_buscarProf As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_club As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_nuevoClub As System.Windows.Forms.Button
End Class
