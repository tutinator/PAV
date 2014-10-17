<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proc_profeXEspe
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
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_buscar_id = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.cmd_desagregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lista_especialidades = New System.Windows.Forms.ListBox()
        Me.lista_esp_profesor = New System.Windows.Forms.ListBox()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar_id)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 117)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profesor"
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.BackgroundImage = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_limpiar.Location = New System.Drawing.Point(285, 17)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(30, 30)
        Me.cmd_limpiar.TabIndex = 26
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_buscar_id
        '
        Me.cmd_buscar_id.BackgroundImage = Global.Asociacion.My.Resources.Resources.buscar
        Me.cmd_buscar_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_id.Location = New System.Drawing.Point(211, 17)
        Me.cmd_buscar_id.Name = "cmd_buscar_id"
        Me.cmd_buscar_id.Size = New System.Drawing.Size(30, 30)
        Me.cmd_buscar_id.TabIndex = 25
        Me.cmd_buscar_id.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(165, 23)
        Me.txt_id.Mask = "99999"
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(40, 20)
        Me.txt_id.TabIndex = 24
        Me.txt_id.ValidatingType = GetType(Integer)
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(165, 79)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(151, 20)
        Me.txt_nombre.TabIndex = 23
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(164, 51)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(151, 20)
        Me.txt_apellido.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(100, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "ID profesor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Apellido"
        '
        'cmd_agregar
        '
        Me.cmd_agregar.Location = New System.Drawing.Point(194, 190)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_agregar.TabIndex = 26
        Me.cmd_agregar.Text = "<<"
        Me.cmd_agregar.UseVisualStyleBackColor = True
        '
        'cmd_desagregar
        '
        Me.cmd_desagregar.Location = New System.Drawing.Point(194, 233)
        Me.cmd_desagregar.Name = "cmd_desagregar"
        Me.cmd_desagregar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_desagregar.TabIndex = 25
        Me.cmd_desagregar.Text = ">>"
        Me.cmd_desagregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Especialidades existentes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Especialidades del profesor"
        '
        'lista_especialidades
        '
        Me.lista_especialidades.FormattingEnabled = True
        Me.lista_especialidades.Location = New System.Drawing.Point(278, 175)
        Me.lista_especialidades.Name = "lista_especialidades"
        Me.lista_especialidades.Size = New System.Drawing.Size(172, 95)
        Me.lista_especialidades.TabIndex = 22
        '
        'lista_esp_profesor
        '
        Me.lista_esp_profesor.FormattingEnabled = True
        Me.lista_esp_profesor.Location = New System.Drawing.Point(12, 175)
        Me.lista_esp_profesor.Name = "lista_esp_profesor"
        Me.lista_esp_profesor.Size = New System.Drawing.Size(176, 95)
        Me.lista_esp_profesor.TabIndex = 21
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.Asociacion.My.Resources.Resources.salir
        Me.cmd_salir.Location = New System.Drawing.Point(400, 285)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 28
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'ProfeXEspe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 352)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_agregar)
        Me.Controls.Add(Me.cmd_desagregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lista_especialidades)
        Me.Controls.Add(Me.lista_esp_profesor)
        Me.Name = "ProfeXEspe"
        Me.Text = "Profesores por especialidad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_id As System.Windows.Forms.Button
    Friend WithEvents txt_id As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_desagregar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lista_especialidades As System.Windows.Forms.ListBox
    Friend WithEvents lista_esp_profesor As System.Windows.Forms.ListBox
End Class
