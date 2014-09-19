<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ABMTipoDocumento
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
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_codTipoDoc = New Asociacion.TextBoxv01()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_codTipoDoc = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grid_tipoDoc = New System.Windows.Forms.DataGridView()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid_tipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_codTipoDoc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_codTipoDoc)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 243)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Documento"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(130, 45)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(128, 20)
        Me.txt_nombre.TabIndex = 3
        '
        'txt_codTipoDoc
        '
        Me.txt_codTipoDoc._BDdato = False
        Me.txt_codTipoDoc._BDnombreCampoTabla = ""
        Me.txt_codTipoDoc._BDvalor = ""
        Me.txt_codTipoDoc._descriptor_del_contenido = ""
        Me.txt_codTipoDoc._Gest_AnchoTexto = 0
        Me.txt_codTipoDoc._Gest_decimales = 0
        Me.txt_codTipoDoc._Gest_enteros = "0"
        Me.txt_codTipoDoc._Gest_mensajeError = ""
        Me.txt_codTipoDoc._Gest_mensajetooltips = "cambie el mensaje tip"
        Me.txt_codTipoDoc._Gest_ReadOnly = False
        Me.txt_codTipoDoc._Gest_TextoNegrita = False
        Me.txt_codTipoDoc._Gest_tipo_dato = Asociacion.TextBoxv01.t_dato.texto
        Me.txt_codTipoDoc._Gest_validar = True
        Me.txt_codTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txt_codTipoDoc.Location = New System.Drawing.Point(130, 20)
        Me.txt_codTipoDoc.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_codTipoDoc.Mask = "99999"
        Me.txt_codTipoDoc.Name = "txt_codTipoDoc"
        Me.txt_codTipoDoc.Size = New System.Drawing.Size(47, 20)
        Me.txt_codTipoDoc.TabIndex = 2
        Me.txt_codTipoDoc.ValidatingType = GetType(Integer)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre*"
        '
        'lbl_codTipoDoc
        '
        Me.lbl_codTipoDoc.AutoSize = True
        Me.lbl_codTipoDoc.Location = New System.Drawing.Point(6, 23)
        Me.lbl_codTipoDoc.Name = "lbl_codTipoDoc"
        Me.lbl_codTipoDoc.Size = New System.Drawing.Size(126, 13)
        Me.lbl_codTipoDoc.TabIndex = 0
        Me.lbl_codTipoDoc.Text = "Código Tipo Documento*"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grid_tipoDoc)
        Me.GroupBox2.Location = New System.Drawing.Point(283, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 243)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipos de documento registrados"
        '
        'grid_tipoDoc
        '
        Me.grid_tipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_tipoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_tipoDoc.Location = New System.Drawing.Point(7, 20)
        Me.grid_tipoDoc.Name = "grid_tipoDoc"
        Me.grid_tipoDoc.Size = New System.Drawing.Size(248, 217)
        Me.grid_tipoDoc.TabIndex = 0
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.Asociacion.My.Resources.Resources.salir
        Me.cmd_salir.Location = New System.Drawing.Point(488, 261)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_salir.TabIndex = 12
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.Asociacion.My.Resources.Resources.buscar
        Me.cmd_buscar.Location = New System.Drawing.Point(281, 262)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_buscar.TabIndex = 11
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Asociacion.My.Resources.Resources.cancel
        Me.cmd_cancelar.Location = New System.Drawing.Point(182, 262)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_cancelar.TabIndex = 10
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Image = Global.Asociacion.My.Resources.Resources.delete
        Me.cmd_eliminar.Location = New System.Drawing.Point(126, 262)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_eliminar.TabIndex = 9
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Asociacion.My.Resources.Resources.save
        Me.cmd_guardar.Location = New System.Drawing.Point(70, 262)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_guardar.TabIndex = 8
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = Global.Asociacion.My.Resources.Resources.add
        Me.cmd_nuevo.Location = New System.Drawing.Point(14, 262)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.cmd_nuevo.TabIndex = 7
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'frm_ABMTipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 323)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_ABMTipoDocumento"
        Me.Text = "Gestión de Tipo de Documento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid_tipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_codTipoDoc As Asociacion.TextBoxv01
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_codTipoDoc As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents grid_tipoDoc As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
End Class
