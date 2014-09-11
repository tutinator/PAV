Imports System.Windows.Forms

Public Class TextBoxv01
    Inherits MaskedTextBox
    Enum t_dato
        texto
        numerico
        fecha
        hora
        mixto
    End Enum
    Dim validar As Boolean = True
    Dim datoDB As Boolean = False
    Dim tipo_dato As t_dato
    Dim descriptor_del_contenido As String = ""
    Dim mensajeError As String = ""
    Dim marcarError As New ErrorProvider
    Dim mensajetooltip As String = "cambie el mensaje tip"
    Dim tooltip As New ToolTip()
    Dim nombreCampoTabla As String = ""
    Dim decimales As Integer = 0
    Dim enteros As Integer = 0
    Dim AnchoTexto As Integer = 0

    Public Property _BDnombreCampoTabla As String
        Get
            Return Me.nombreCampoTabla
        End Get
        Set(ByVal value As String)
            Me.nombreCampoTabla = value
        End Set
    End Property
    Public Property _BDdato As Boolean
        Set(ByVal value As Boolean)
            Me.datoDB = value
        End Set
        Get
            Return datoDB
        End Get
    End Property
    Public Property _BDvalor As String
        Set(ByVal value As String)
            Me.Text = value
        End Set
        Get
            Return Me.Text
        End Get
    End Property
    Public Property _Gest_mensajetooltips As String
        Get
            Return Me.mensajetooltip
        End Get
        Set(ByVal value As String)
            Me.mensajetooltip = value
        End Set
    End Property
    Public Property _Gest_marcarError As ErrorProvider
        Set(ByVal value As ErrorProvider)
            Me.marcarError = value
        End Set
        Get
            Return marcarError
        End Get
    End Property

    Public Property _descriptor_del_contenido As String
        Set(ByVal value As String)
            Me.descriptor_del_contenido = value
        End Set
        Get
            Return descriptor_del_contenido
        End Get
    End Property
    Public Property _Gest_tipo_dato As t_dato
        Set(ByVal value As t_dato)
            Me.tipo_dato = value
            Select Case Me.tipo_dato
                Case t_dato.numerico
                    If Me.decimales > 0 Then
                        Me.Mask = StrDup(Me.enteros, "9") + "," + StrDup(Me.decimales, "9")
                        Me.ValidatingType = GetType(System.Double)
                    Else
                        Me.Mask = StrDup(Me.enteros, "9")
                        Me.ValidatingType = GetType(System.Int32)
                    End If
                Case t_dato.fecha
                    Me.Mask = "00/00/0000"
                    Me.ValidatingType = GetType(System.DateTime)
                    Me.Width = 66
                Case t_dato.hora
                    Me.Mask = "00:00"
                    Me.ValidatingType = GetType(System.DateTime)
                Case t_dato.texto
                    Me.Mask = StrDup(Me.AnchoTexto, "L")
                    Me.ValidatingType = GetType(System.String)
                Case t_dato.mixto
                    Me.Mask = StrDup(Me.AnchoTexto, "A")
                    Me.ValidatingType = GetType(System.String)
            End Select
        End Set
        Get
            Return tipo_dato
        End Get
    End Property
    Public Property _Gest_decimales As Integer
        Get
            Return decimales
        End Get
        Set(ByVal value As Integer)
            Me.decimales = value
        End Set
    End Property
    Public Property _Gest_enteros As String
        Get
            Return enteros
        End Get
        Set(ByVal value As String)
            Me.enteros = value
        End Set
    End Property
    Public Property _Gest_AnchoTexto As Integer
        Get
            Return Me.AnchoTexto
        End Get
        Set(ByVal value As Integer)
            Me.AnchoTexto = value
        End Set
    End Property

  
    Public Property _Gest_validar As Boolean
        Set(ByVal value As Boolean)
            validar = value
        End Set
        Get
            Return validar
        End Get
    End Property
    Public Property _Gest_mensajeError As String
        Set(ByVal value As String)
            mensajeError = value
        End Set
        Get
            Return mensajeError
        End Get
    End Property
    Public Property _Gest_TextoNegrita As Boolean
        Get
            Return Me.Font.Bold
        End Get
        Set(ByVal value As Boolean)
            If value = True Then
                Me.Font = New Font(Font.FontFamily, 8, FontStyle.Bold)
            Else
                Me.Font = New Font(Font.FontFamily, 8, FontStyle.Regular)
            End If
        End Set
    End Property
    Public Property _Gest_ReadOnly As Boolean
        Get
            Return Me.ReadOnly
        End Get
        Set(ByVal value As Boolean)
            Me.ReadOnly = value
        End Set
    End Property
    Public Sub New()
        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Me.tooltip.SetToolTip(Me, Me.mensajetooltip)
        Me.Margin = New Padding(1)
    End Sub

    Private Sub _KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Function AutoCompleteCustomSource() As Object
        Throw New NotImplementedException
    End Function

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        
        Me.BeepOnError = True
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.ResumeLayout(False)

    End Sub

    Private Sub TextBoxv01_TypeValidationCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.TypeValidationEventArgs) Handles Me.TypeValidationCompleted
        If Me.validar = False Then
            Exit Sub
        End If

        Select Case Me.tipo_dato
            Case t_dato.fecha
                If Me.Text = "  /  /" Then
                    Me._Gest_marcarError.SetError(Me, "")
                    Exit Sub
                End If
        End Select

        If Me.Text.Equals(String.Empty) Then
            Me._Gest_marcarError.SetError(Me, "")
            Exit Sub
        End If

        If (Not e.IsValidInput) Then
            Me._Gest_marcarError.SetError(Me, "Error")
            MsgBox("Contenido invalido (" & Me.Text & ")", MsgBoxStyle.Critical, "Error Critico")
            Me.Text = ""
            Me.Focus()
        Else
            Me._Gest_marcarError.SetError(Me, "")
        End If
    End Sub
End Class
