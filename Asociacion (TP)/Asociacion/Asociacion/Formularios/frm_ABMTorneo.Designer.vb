<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ABMTorneo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ABMTorneo))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grid_codTorneo = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_codTorneo = New Asociacion.TextBoxv01()
        Me.lbl_codTorneo = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid_codTorneo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grid_codTorneo)
        Me.GroupBox2.Location = New System.Drawing.Point(273, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 255)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Torneos Registrados"
        '
        'grid_codTorneo
        '
        Me.grid_codTorneo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_codTorneo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_codTorneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_codTorneo.Location = New System.Drawing.Point(6, 19)
        Me.grid_codTorneo.Name = "grid_codTorneo"
        Me.grid_codTorneo.ReadOnly = True
        Me.grid_codTorneo.Size = New System.Drawing.Size(283, 230)
        Me.grid_codTorneo.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_codTorneo)
        Me.GroupBox1.Controls.Add(Me.lbl_codTorneo)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 94)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Torneo"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(102, 56)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(137, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_codTorneo
        '
        Me.txt_codTorneo._BDdato = False
        Me.txt_codTorneo._BDnombreCampoTabla = ""
        Me.txt_codTorneo._BDvalor = ""
        Me.txt_codTorneo._descriptor_del_contenido = ""
        Me.txt_codTorneo._Gest_AnchoTexto = 0
        Me.txt_codTorneo._Gest_decimales = 0
        Me.txt_codTorneo._Gest_enteros = "0"
        Me.txt_codTorneo._Gest_mensajeError = ""
        Me.txt_codTorneo._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_codTorneo._Gest_ReadOnly = False
        Me.txt_codTorneo._Gest_TextoNegrita = False
        Me.txt_codTorneo._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_codTorneo._Gest_validar = True
        Me.txt_codTorneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_codTorneo.Location = New System.Drawing.Point(102, 30)
        Me.txt_codTorneo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_codTorneo.Mask = "9999"
        Me.txt_codTorneo.Name = "txt_codTorneo"
        Me.txt_codTorneo.Size = New System.Drawing.Size(34, 20)
        Me.txt_codTorneo.TabIndex = 0
        Me.txt_codTorneo.ValidatingType = GetType(String)
        '
        'lbl_codTorneo
        '
        Me.lbl_codTorneo.AutoSize = True
        Me.lbl_codTorneo.Location = New System.Drawing.Point(17, 33)
        Me.lbl_codTorneo.Name = "lbl_codTorneo"
        Me.lbl_codTorneo.Size = New System.Drawing.Size(81, 13)
        Me.lbl_codTorneo.TabIndex = 6
        Me.lbl_codTorneo.Text = "Código Torneo*"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(53, 59)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(48, 13)
        Me.lbl_nombre.TabIndex = 6
        Me.lbl_nombre.Text = "Nombre*"
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = CType(resources.GetObject("cmd_salir.Image"), System.Drawing.Image)
        Me.cmd_salir.Location = New System.Drawing.Point(512, 289)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 14
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = CType(resources.GetObject("cmd_buscar.Image"), System.Drawing.Image)
        Me.cmd_buscar.Location = New System.Drawing.Point(273, 290)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_buscar.TabIndex = 13
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = CType(resources.GetObject("cmd_cancelar.Image"), System.Drawing.Image)
        Me.cmd_cancelar.Location = New System.Drawing.Point(180, 290)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_cancelar.TabIndex = 12
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Image = CType(resources.GetObject("cmd_eliminar.Image"), System.Drawing.Image)
        Me.cmd_eliminar.Location = New System.Drawing.Point(124, 290)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_eliminar.TabIndex = 11
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = CType(resources.GetObject("cmd_guardar.Image"), System.Drawing.Image)
        Me.cmd_guardar.Location = New System.Drawing.Point(68, 290)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_guardar.TabIndex = 10
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = CType(resources.GetObject("cmd_nuevo.Image"), System.Drawing.Image)
        Me.cmd_nuevo.Location = New System.Drawing.Point(12, 290)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.cmd_nuevo.TabIndex = 9
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'frm_ABMTorneo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 350)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_ABMTorneo"
        Me.Text = "Gestión de Torneos"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid_codTorneo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grid_codTorneo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_codTorneo As Asociacion.TextBoxv01
    Friend WithEvents lbl_codTorneo As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
End Class
