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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_codPostal = New System.Windows.Forms.TextBox()
        Me.txt_nroCalle = New System.Windows.Forms.TextBox()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_codPostal = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_codPostal)
        Me.GroupBox1.Controls.Add(Me.txt_nroCalle)
        Me.GroupBox1.Controls.Add(Me.txt_calle)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_codPostal)
        Me.GroupBox1.Controls.Add(Me.lbl_numero)
        Me.GroupBox1.Controls.Add(Me.lbl_calle)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Club"
        '
        'txt_codPostal
        '
        Me.txt_codPostal.Location = New System.Drawing.Point(87, 138)
        Me.txt_codPostal.Name = "txt_codPostal"
        Me.txt_codPostal.Size = New System.Drawing.Size(53, 20)
        Me.txt_codPostal.TabIndex = 7
        '
        'txt_nroCalle
        '
        Me.txt_nroCalle.Location = New System.Drawing.Point(87, 112)
        Me.txt_nroCalle.Name = "txt_nroCalle"
        Me.txt_nroCalle.Size = New System.Drawing.Size(53, 20)
        Me.txt_nroCalle.TabIndex = 8
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(87, 82)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(145, 20)
        Me.txt_calle.TabIndex = 9
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(87, 56)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(145, 20)
        Me.txt_nombre.TabIndex = 10
        '
        'lbl_codPostal
        '
        Me.lbl_codPostal.AutoSize = True
        Me.lbl_codPostal.Location = New System.Drawing.Point(10, 141)
        Me.lbl_codPostal.Name = "lbl_codPostal"
        Me.lbl_codPostal.Size = New System.Drawing.Size(71, 13)
        Me.lbl_codPostal.TabIndex = 3
        Me.lbl_codPostal.Text = "Código postal"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(37, 115)
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
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(37, 59)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 6
        Me.lbl_nombre.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(87, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(53, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Código Club"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(265, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'frm_ABMclubes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 504)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_ABMclubes"
        Me.Text = "ABMClubes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_codPostal As System.Windows.Forms.TextBox
    Friend WithEvents txt_nroCalle As System.Windows.Forms.TextBox
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_codPostal As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
