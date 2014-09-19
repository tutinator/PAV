<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ABMEspecialidades
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
        Me.txt_tiempoRecord = New Asociacion.TextBoxv01()
        Me.txt_codEspe = New Asociacion.TextBoxv01()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grid_especialidades = New System.Windows.Forms.DataGridView()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid_especialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_tiempoRecord)
        Me.GroupBox1.Controls.Add(Me.txt_codEspe)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Especialidad"
        '
        'txt_tiempoRecord
        '
        Me.txt_tiempoRecord._BDdato = False
        Me.txt_tiempoRecord._BDnombreCampoTabla = ""
        Me.txt_tiempoRecord._BDvalor = "  :  :"
        Me.txt_tiempoRecord._descriptor_del_contenido = ""
        Me.txt_tiempoRecord._Gest_AnchoTexto = 0
        Me.txt_tiempoRecord._Gest_decimales = 0
        Me.txt_tiempoRecord._Gest_enteros = "0"
        Me.txt_tiempoRecord._Gest_mensajeError = ""
        Me.txt_tiempoRecord._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_tiempoRecord._Gest_ReadOnly = False
        Me.txt_tiempoRecord._Gest_TextoNegrita = False
        Me.txt_tiempoRecord._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_tiempoRecord._Gest_validar = True
        Me.txt_tiempoRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_tiempoRecord.Location = New System.Drawing.Point(114, 88)
        Me.txt_tiempoRecord.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_tiempoRecord.Mask = "99:99:99"
        Me.txt_tiempoRecord.Name = "txt_tiempoRecord"
        Me.txt_tiempoRecord.Size = New System.Drawing.Size(55, 20)
        Me.txt_tiempoRecord.TabIndex = 2
        Me.txt_tiempoRecord.ValidatingType = GetType(String)
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
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(114, 57)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(139, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tiempo récord"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Especialidad*"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grid_especialidades)
        Me.GroupBox2.Location = New System.Drawing.Point(279, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 295)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Especialidades registradas"
        '
        'grid_especialidades
        '
        Me.grid_especialidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_especialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_especialidades.Location = New System.Drawing.Point(7, 20)
        Me.grid_especialidades.Name = "grid_especialidades"
        Me.grid_especialidades.Size = New System.Drawing.Size(368, 269)
        Me.grid_especialidades.TabIndex = 0
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.Asociacion.My.Resources.Resources.salir
        Me.cmd_salir.Location = New System.Drawing.Point(605, 317)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 6
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.Asociacion.My.Resources.Resources.buscar
        Me.cmd_buscar.Location = New System.Drawing.Point(279, 317)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_buscar.TabIndex = 5
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_cancelar.Location = New System.Drawing.Point(190, 317)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_cancelar.TabIndex = 4
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Image = Global.Asociacion.My.Resources.Resources.delete
        Me.cmd_eliminar.Location = New System.Drawing.Point(134, 317)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_eliminar.TabIndex = 3
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Asociacion.My.Resources.Resources.save
        Me.cmd_guardar.Location = New System.Drawing.Point(78, 317)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_guardar.TabIndex = 2
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = Global.Asociacion.My.Resources.Resources.add
        Me.cmd_nuevo.Location = New System.Drawing.Point(22, 317)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.cmd_nuevo.TabIndex = 1
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'frm_ABMEspecialidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 379)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_ABMEspecialidades"
        Me.Text = "Gestión de Especialidades"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid_especialidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_codEspe As Asociacion.TextBoxv01
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents grid_especialidades As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_tiempoRecord As Asociacion.TextBoxv01
End Class
