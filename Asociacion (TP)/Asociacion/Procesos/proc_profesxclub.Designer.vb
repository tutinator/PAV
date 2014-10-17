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
        Me.gbo_profesor = New System.Windows.Forms.GroupBox()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_nuevoprof = New System.Windows.Forms.Button()
        Me.cmd_buscarProf = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nombre_profesor = New System.Windows.Forms.Label()
        Me.lbl_codigo_profesor = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre_profe = New System.Windows.Forms.TextBox()
        Me.cmb_codProfe = New System.Windows.Forms.ComboBox()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_quitar = New System.Windows.Forms.Button()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lst_clubesTrabajo = New System.Windows.Forms.ListBox()
        Me.lst_clubes = New System.Windows.Forms.ListBox()
        Me.txt_codProfe = New System.Windows.Forms.MaskedTextBox()
        Me.gbo_profesor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbo_profesor
        '
        Me.gbo_profesor.Controls.Add(Me.txt_codProfe)
        Me.gbo_profesor.Controls.Add(Me.cmd_cancelar)
        Me.gbo_profesor.Controls.Add(Me.cmd_nuevoprof)
        Me.gbo_profesor.Controls.Add(Me.cmd_buscarProf)
        Me.gbo_profesor.Controls.Add(Me.Label1)
        Me.gbo_profesor.Controls.Add(Me.lbl_nombre_profesor)
        Me.gbo_profesor.Controls.Add(Me.lbl_codigo_profesor)
        Me.gbo_profesor.Controls.Add(Me.txt_apellido)
        Me.gbo_profesor.Controls.Add(Me.txt_nombre_profe)
        Me.gbo_profesor.Controls.Add(Me.cmb_codProfe)
        Me.gbo_profesor.Location = New System.Drawing.Point(12, 12)
        Me.gbo_profesor.Name = "gbo_profesor"
        Me.gbo_profesor.Size = New System.Drawing.Size(450, 93)
        Me.gbo_profesor.TabIndex = 1
        Me.gbo_profesor.TabStop = False
        Me.gbo_profesor.Text = "Profesor"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.BackgroundImage = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_cancelar.Location = New System.Drawing.Point(196, 17)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(30, 30)
        Me.cmd_cancelar.TabIndex = 30
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_nuevoprof
        '
        Me.cmd_nuevoprof.Location = New System.Drawing.Point(322, 21)
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
        Me.cmd_buscarProf.Location = New System.Drawing.Point(145, 17)
        Me.cmd_buscarProf.Name = "cmd_buscarProf"
        Me.cmd_buscarProf.Size = New System.Drawing.Size(30, 30)
        Me.cmd_buscarProf.TabIndex = 2
        Me.cmd_buscarProf.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Apellido"
        '
        'lbl_nombre_profesor
        '
        Me.lbl_nombre_profesor.AutoSize = True
        Me.lbl_nombre_profesor.Location = New System.Drawing.Point(243, 62)
        Me.lbl_nombre_profesor.Name = "lbl_nombre_profesor"
        Me.lbl_nombre_profesor.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre_profesor.TabIndex = 18
        Me.lbl_nombre_profesor.Text = "Nombre"
        '
        'lbl_codigo_profesor
        '
        Me.lbl_codigo_profesor.AutoSize = True
        Me.lbl_codigo_profesor.Location = New System.Drawing.Point(35, 25)
        Me.lbl_codigo_profesor.Name = "lbl_codigo_profesor"
        Me.lbl_codigo_profesor.Size = New System.Drawing.Size(40, 13)
        Me.lbl_codigo_profesor.TabIndex = 20
        Me.lbl_codigo_profesor.Text = "Código"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(81, 59)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(145, 20)
        Me.txt_apellido.TabIndex = 2
        '
        'txt_nombre_profe
        '
        Me.txt_nombre_profe.Location = New System.Drawing.Point(293, 59)
        Me.txt_nombre_profe.Name = "txt_nombre_profe"
        Me.txt_nombre_profe.Size = New System.Drawing.Size(145, 20)
        Me.txt_nombre_profe.TabIndex = 2
        '
        'cmb_codProfe
        '
        Me.cmb_codProfe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_codProfe.FormattingEnabled = True
        Me.cmb_codProfe.Location = New System.Drawing.Point(81, 23)
        Me.cmb_codProfe.Name = "cmb_codProfe"
        Me.cmb_codProfe.Size = New System.Drawing.Size(58, 21)
        Me.cmb_codProfe.TabIndex = 23
        Me.cmb_codProfe.Visible = False
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.Asociacion.My.Resources.Resources.salir
        Me.cmd_salir.Location = New System.Drawing.Point(412, 311)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 29
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_quitar)
        Me.GroupBox1.Controls.Add(Me.cmd_agregar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lst_clubesTrabajo)
        Me.GroupBox1.Controls.Add(Me.lst_clubes)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 194)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Club"
        '
        'cmd_quitar
        '
        Me.cmd_quitar.Location = New System.Drawing.Point(191, 115)
        Me.cmd_quitar.Name = "cmd_quitar"
        Me.cmd_quitar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_quitar.TabIndex = 10
        Me.cmd_quitar.Text = "<<"
        Me.cmd_quitar.UseVisualStyleBackColor = True
        '
        'cmd_agregar
        '
        Me.cmd_agregar.Location = New System.Drawing.Point(191, 75)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_agregar.TabIndex = 9
        Me.cmd_agregar.Text = ">>"
        Me.cmd_agregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Clubes de Trabajo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clubes No Asignados"
        '
        'lst_clubesTrabajo
        '
        Me.lst_clubesTrabajo.FormattingEnabled = True
        Me.lst_clubesTrabajo.Location = New System.Drawing.Point(295, 35)
        Me.lst_clubesTrabajo.Name = "lst_clubesTrabajo"
        Me.lst_clubesTrabajo.Size = New System.Drawing.Size(120, 147)
        Me.lst_clubesTrabajo.TabIndex = 0
        '
        'lst_clubes
        '
        Me.lst_clubes.FormattingEnabled = True
        Me.lst_clubes.Location = New System.Drawing.Point(42, 35)
        Me.lst_clubes.Name = "lst_clubes"
        Me.lst_clubes.Size = New System.Drawing.Size(120, 147)
        Me.lst_clubes.TabIndex = 0
        '
        'txt_codProfe
        '
        Me.txt_codProfe.Location = New System.Drawing.Point(81, 23)
        Me.txt_codProfe.Mask = "99999"
        Me.txt_codProfe.Name = "txt_codProfe"
        Me.txt_codProfe.Size = New System.Drawing.Size(58, 20)
        Me.txt_codProfe.TabIndex = 31
        Me.txt_codProfe.ValidatingType = GetType(Integer)
        '
        'proc_profesxclub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 370)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbo_profesor)
        Me.Name = "proc_profesxclub"
        Me.Text = "Profesores por club"
        Me.gbo_profesor.ResumeLayout(False)
        Me.gbo_profesor.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbo_profesor As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_buscarProf As System.Windows.Forms.Button
    Friend WithEvents txt_codProfesor As Asociacion.TextBoxv01
    Friend WithEvents lbl_nombre_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_profesor As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_profe As System.Windows.Forms.TextBox
    Friend WithEvents cmd_nuevoprof As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_quitar As System.Windows.Forms.Button
    Friend WithEvents cmd_agregar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lst_clubesTrabajo As System.Windows.Forms.ListBox
    Friend WithEvents lst_clubes As System.Windows.Forms.ListBox
    Friend WithEvents cmb_codProfe As System.Windows.Forms.ComboBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_codProfe As System.Windows.Forms.MaskedTextBox
End Class
