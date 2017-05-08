<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
    Inherits MetroFramework.Forms.MetroForm

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
        Me.TabControlInicioSesion = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.lblRespuesta = New MetroFramework.Controls.MetroLabel()
        Me.lblMensajeErrorCorreo = New MetroFramework.Controls.MetroLabel()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.txtInformacionAdicionalEstudios = New MetroFramework.Controls.MetroTextBox()
        Me.btnSiguiente = New MetroFramework.Controls.MetroButton()
        Me.cboEstudios = New MetroFramework.Controls.MetroComboBox()
        Me.btnRegistro = New MetroFramework.Controls.MetroButton()
        Me.txtContraseña = New MetroFramework.Controls.MetroTextBox()
        Me.txtCorreo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtTelefonoRegistro = New MetroFramework.Controls.MetroTextBox()
        Me.txtApellidoRegistro = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombreRegistro = New MetroFramework.Controls.MetroTextBox()
        Me.txtContraseñaRegistro = New MetroFramework.Controls.MetroTextBox()
        Me.txtCorreoRegistro = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControlInicioSesion.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlInicioSesion
        '
        Me.TabControlInicioSesion.Controls.Add(Me.MetroTabPage1)
        Me.TabControlInicioSesion.Controls.Add(Me.MetroTabPage2)
        Me.TabControlInicioSesion.Location = New System.Drawing.Point(-3, 63)
        Me.TabControlInicioSesion.Name = "TabControlInicioSesion"
        Me.TabControlInicioSesion.SelectedIndex = 0
        Me.TabControlInicioSesion.Size = New System.Drawing.Size(519, 393)
        Me.TabControlInicioSesion.TabIndex = 0
        Me.TabControlInicioSesion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TabControlInicioSesion.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.PictureBox1)
        Me.MetroTabPage1.Controls.Add(Me.lblRespuesta)
        Me.MetroTabPage1.Controls.Add(Me.lblMensajeErrorCorreo)
        Me.MetroTabPage1.Controls.Add(Me.btnLogin)
        Me.MetroTabPage1.Controls.Add(Me.txtContraseña)
        Me.MetroTabPage1.Controls.Add(Me.txtCorreo)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(511, 351)
        Me.MetroTabPage1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "MetroTabPage1"
        Me.MetroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'lblRespuesta
        '
        Me.lblRespuesta.Location = New System.Drawing.Point(87, 203)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(304, 23)
        Me.lblRespuesta.Style = MetroFramework.MetroColorStyle.Red
        Me.lblRespuesta.TabIndex = 6
        Me.lblRespuesta.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblRespuesta.UseStyleColors = True
        '
        'lblMensajeErrorCorreo
        '
        Me.lblMensajeErrorCorreo.Location = New System.Drawing.Point(87, 127)
        Me.lblMensajeErrorCorreo.Name = "lblMensajeErrorCorreo"
        Me.lblMensajeErrorCorreo.Size = New System.Drawing.Size(304, 23)
        Me.lblMensajeErrorCorreo.Style = MetroFramework.MetroColorStyle.Red
        Me.lblMensajeErrorCorreo.TabIndex = 5
        Me.lblMensajeErrorCorreo.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblMensajeErrorCorreo.UseStyleColors = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(179, 257)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(107, 40)
        Me.btnLogin.Style = MetroFramework.MetroColorStyle.Orange
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnLogin.UseSelectable = True
        Me.btnLogin.UseStyleColors = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.txtInformacionAdicionalEstudios)
        Me.MetroTabPage2.Controls.Add(Me.btnSiguiente)
        Me.MetroTabPage2.Controls.Add(Me.cboEstudios)
        Me.MetroTabPage2.Controls.Add(Me.btnRegistro)
        Me.MetroTabPage2.Controls.Add(Me.MetroButton1)
        Me.MetroTabPage2.Controls.Add(Me.txtTelefonoRegistro)
        Me.MetroTabPage2.Controls.Add(Me.txtApellidoRegistro)
        Me.MetroTabPage2.Controls.Add(Me.txtNombreRegistro)
        Me.MetroTabPage2.Controls.Add(Me.txtContraseñaRegistro)
        Me.MetroTabPage2.Controls.Add(Me.txtCorreoRegistro)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(511, 351)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "MetroTabPage2"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'txtInformacionAdicionalEstudios
        '
        '
        '
        '
        Me.txtInformacionAdicionalEstudios.CustomButton.Image = Nothing
        Me.txtInformacionAdicionalEstudios.CustomButton.Location = New System.Drawing.Point(264, 2)
        Me.txtInformacionAdicionalEstudios.CustomButton.Name = ""
        Me.txtInformacionAdicionalEstudios.CustomButton.Size = New System.Drawing.Size(71, 71)
        Me.txtInformacionAdicionalEstudios.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtInformacionAdicionalEstudios.CustomButton.TabIndex = 1
        Me.txtInformacionAdicionalEstudios.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtInformacionAdicionalEstudios.CustomButton.UseSelectable = True
        Me.txtInformacionAdicionalEstudios.CustomButton.Visible = False
        Me.txtInformacionAdicionalEstudios.Lines = New String(-1) {}
        Me.txtInformacionAdicionalEstudios.Location = New System.Drawing.Point(68, 224)
        Me.txtInformacionAdicionalEstudios.MaxLength = 32767
        Me.txtInformacionAdicionalEstudios.Multiline = True
        Me.txtInformacionAdicionalEstudios.Name = "txtInformacionAdicionalEstudios"
        Me.txtInformacionAdicionalEstudios.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInformacionAdicionalEstudios.PromptText = "Introduce información adicional de tus estudios"
        Me.txtInformacionAdicionalEstudios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInformacionAdicionalEstudios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInformacionAdicionalEstudios.SelectedText = ""
        Me.txtInformacionAdicionalEstudios.SelectionLength = 0
        Me.txtInformacionAdicionalEstudios.SelectionStart = 0
        Me.txtInformacionAdicionalEstudios.ShortcutsEnabled = True
        Me.txtInformacionAdicionalEstudios.Size = New System.Drawing.Size(338, 76)
        Me.txtInformacionAdicionalEstudios.Style = MetroFramework.MetroColorStyle.Orange
        Me.txtInformacionAdicionalEstudios.TabIndex = 21
        Me.txtInformacionAdicionalEstudios.UseSelectable = True
        Me.txtInformacionAdicionalEstudios.UseStyleColors = True
        Me.txtInformacionAdicionalEstudios.WaterMark = "Introduce información adicional de tus estudios"
        Me.txtInformacionAdicionalEstudios.WaterMarkColor = System.Drawing.Color.Teal
        Me.txtInformacionAdicionalEstudios.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(455, 7)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(36, 31)
        Me.btnSiguiente.Style = MetroFramework.MetroColorStyle.Orange
        Me.btnSiguiente.TabIndex = 20
        Me.btnSiguiente.Text = "->"
        Me.btnSiguiente.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnSiguiente.UseSelectable = True
        Me.btnSiguiente.UseStyleColors = True
        '
        'cboEstudios
        '
        Me.cboEstudios.FormattingEnabled = True
        Me.cboEstudios.ItemHeight = 23
        Me.cboEstudios.Items.AddRange(New Object() {"ESO", "GRADO MEDIO", "BACHILLER", "CURSO PUENTE", "GRADO SUPERIOR", "UNIVERSIDAD", "OTROS"})
        Me.cboEstudios.Location = New System.Drawing.Point(68, 189)
        Me.cboEstudios.Name = "cboEstudios"
        Me.cboEstudios.Size = New System.Drawing.Size(338, 29)
        Me.cboEstudios.Style = MetroFramework.MetroColorStyle.Orange
        Me.cboEstudios.TabIndex = 19
        Me.cboEstudios.UseSelectable = True
        Me.cboEstudios.UseStyleColors = True
        '
        'btnRegistro
        '
        Me.btnRegistro.Location = New System.Drawing.Point(196, 317)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(107, 31)
        Me.btnRegistro.Style = MetroFramework.MetroColorStyle.Orange
        Me.btnRegistro.TabIndex = 7
        Me.btnRegistro.Text = "Registro"
        Me.btnRegistro.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnRegistro.UseSelectable = True
        Me.btnRegistro.UseStyleColors = True
        '
        'txtContraseña
        '
        '
        '
        '
        Me.txtContraseña.CustomButton.Image = Nothing
        Me.txtContraseña.CustomButton.Location = New System.Drawing.Point(276, 2)
        Me.txtContraseña.CustomButton.Name = ""
        Me.txtContraseña.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtContraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtContraseña.CustomButton.TabIndex = 1
        Me.txtContraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContraseña.CustomButton.UseSelectable = True
        Me.txtContraseña.CustomButton.Visible = False
        Me.txtContraseña.DisplayIcon = True
        Me.txtContraseña.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtContraseña.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtContraseña.Icon = Global.CapaFormularios.My.Resources.Resources.Password_20px
        Me.txtContraseña.Lines = New String(-1) {}
        Me.txtContraseña.Location = New System.Drawing.Point(87, 171)
        Me.txtContraseña.MaxLength = 32767
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.PromptText = "Contraseña"
        Me.txtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContraseña.SelectedText = ""
        Me.txtContraseña.SelectionLength = 0
        Me.txtContraseña.SelectionStart = 0
        Me.txtContraseña.ShortcutsEnabled = True
        Me.txtContraseña.Size = New System.Drawing.Size(304, 30)
        Me.txtContraseña.Style = MetroFramework.MetroColorStyle.Orange
        Me.txtContraseña.TabIndex = 3
        Me.txtContraseña.UseSelectable = True
        Me.txtContraseña.UseStyleColors = True
        Me.txtContraseña.WaterMark = "Contraseña"
        Me.txtContraseña.WaterMarkColor = System.Drawing.Color.DarkCyan
        Me.txtContraseña.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCorreo
        '
        '
        '
        '
        Me.txtCorreo.CustomButton.Image = Global.CapaFormularios.My.Resources.Resources.Message_20px
        Me.txtCorreo.CustomButton.Location = New System.Drawing.Point(276, 2)
        Me.txtCorreo.CustomButton.Name = ""
        Me.txtCorreo.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCorreo.CustomButton.TabIndex = 1
        Me.txtCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCorreo.CustomButton.UseSelectable = True
        Me.txtCorreo.CustomButton.Visible = False
        Me.txtCorreo.DisplayIcon = True
        Me.txtCorreo.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCorreo.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtCorreo.Icon = Global.CapaFormularios.My.Resources.Resources.Message_20px
        Me.txtCorreo.Lines = New String(-1) {}
        Me.txtCorreo.Location = New System.Drawing.Point(87, 95)
        Me.txtCorreo.MaxLength = 32767
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo.PromptText = "Correo"
        Me.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCorreo.SelectedText = ""
        Me.txtCorreo.SelectionLength = 0
        Me.txtCorreo.SelectionStart = 0
        Me.txtCorreo.ShortcutsEnabled = True
        Me.txtCorreo.Size = New System.Drawing.Size(304, 30)
        Me.txtCorreo.Style = MetroFramework.MetroColorStyle.Orange
        Me.txtCorreo.TabIndex = 2
        Me.txtCorreo.UseSelectable = True
        Me.txtCorreo.UseStyleColors = True
        Me.txtCorreo.WaterMark = "Correo"
        Me.txtCorreo.WaterMarkColor = System.Drawing.Color.Teal
        Me.txtCorreo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.Transparent
        Me.MetroButton1.BackgroundImage = Global.CapaFormularios.My.Resources.Resources.Preview_Pane_20px
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton1.Location = New System.Drawing.Point(380, 47)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(22, 23)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton1.TabIndex = 22
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtTelefonoRegistro
        '
        '
        '
        '
        Me.txtTelefonoRegistro.CustomButton.Image = Nothing
        Me.txtTelefonoRegistro.CustomButton.Location = New System.Drawing.Point(310, 2)
        Me.txtTelefonoRegistro.CustomButton.Name = ""
        Me.txtTelefonoRegistro.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTelefonoRegistro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelefonoRegistro.CustomButton.TabIndex = 1
        Me.txtTelefonoRegistro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelefonoRegistro.CustomButton.UseSelectable = True
        Me.txtTelefonoRegistro.CustomButton.Visible = False
        Me.txtTelefonoRegistro.DisplayIcon = True
        Me.txtTelefonoRegistro.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtTelefonoRegistro.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtTelefonoRegistro.Icon = Global.CapaFormularios.My.Resources.Resources.Circled_User_Male_20px
        Me.txtTelefonoRegistro.Lines = New String(-1) {}
        Me.txtTelefonoRegistro.Location = New System.Drawing.Point(68, 152)
        Me.txtTelefonoRegistro.MaxLength = 32767
        Me.txtTelefonoRegistro.Name = "txtTelefonoRegistro"
        Me.txtTelefonoRegistro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefonoRegistro.PromptText = "Telefono"
        Me.txtTelefonoRegistro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefonoRegistro.SelectedText = ""
        Me.txtTelefonoRegistro.SelectionLength = 0
        Me.txtTelefonoRegistro.SelectionStart = 0
        Me.txtTelefonoRegistro.ShortcutsEnabled = True
        Me.txtTelefonoRegistro.ShowClearButton = True
        Me.txtTelefonoRegistro.Size = New System.Drawing.Size(338, 30)
        Me.txtTelefonoRegistro.Style = MetroFramework.MetroColorStyle.Orange
        Me.txtTelefonoRegistro.TabIndex = 18
        Me.txtTelefonoRegistro.UseSelectable = True
        Me.txtTelefonoRegistro.UseStyleColors = True
        Me.txtTelefonoRegistro.WaterMark = "Telefono"
        Me.txtTelefonoRegistro.WaterMarkColor = System.Drawing.Color.DarkCyan
        Me.txtTelefonoRegistro.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtApellidoRegistro
        '
        '
        '
        '
        Me.txtApellidoRegistro.CustomButton.Image = Nothing
        Me.txtApellidoRegistro.CustomButton.Location = New System.Drawing.Point(310, 2)
        Me.txtApellidoRegistro.CustomButton.Name = ""
        Me.txtApellidoRegistro.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtApellidoRegistro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtApellidoRegistro.CustomButton.TabIndex = 1
        Me.txtApellidoRegistro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtApellidoRegistro.CustomButton.UseSelectable = True
        Me.txtApellidoRegistro.CustomButton.Visible = False
        Me.txtApellidoRegistro.DisplayIcon = True
        Me.txtApellidoRegistro.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtApellidoRegistro.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtApellidoRegistro.Icon = Global.CapaFormularios.My.Resources.Resources.Circled_User_Male_20px
        Me.txtApellidoRegistro.Lines = New String(-1) {}
        Me.txtApellidoRegistro.Location = New System.Drawing.Point(68, 116)
        Me.txtApellidoRegistro.MaxLength = 32767
        Me.txtApellidoRegistro.Name = "txtApellidoRegistro"
        Me.txtApellidoRegistro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellidoRegistro.PromptText = "Apellido"
        Me.txtApellidoRegistro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApellidoRegistro.SelectedText = ""
        Me.txtApellidoRegistro.SelectionLength = 0
        Me.txtApellidoRegistro.SelectionStart = 0
        Me.txtApellidoRegistro.ShortcutsEnabled = True
        Me.txtApellidoRegistro.ShowClearButton = True
        Me.txtApellidoRegistro.Size = New System.Drawing.Size(338, 30)
        Me.txtApellidoRegistro.Style = MetroFramework.MetroColorStyle.Orange
        Me.txtApellidoRegistro.TabIndex = 17
        Me.txtApellidoRegistro.UseSelectable = True
        Me.txtApellidoRegistro.UseStyleColors = True
        Me.txtApellidoRegistro.WaterMark = "Apellido"
        Me.txtApellidoRegistro.WaterMarkColor = System.Drawing.Color.DarkCyan
        Me.txtApellidoRegistro.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNombreRegistro
        '
        '
        '
        '
        Me.txtNombreRegistro.CustomButton.Image = Global.CapaFormularios.My.Resources.Resources.Message_20px
        Me.txtNombreRegistro.CustomButton.Location = New System.Drawing.Point(310, 2)
        Me.txtNombreRegistro.CustomButton.Name = ""
        Me.txtNombreRegistro.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNombreRegistro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombreRegistro.CustomButton.TabIndex = 1
        Me.txtNombreRegistro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombreRegistro.CustomButton.UseSelectable = True
        Me.txtNombreRegistro.CustomButton.Visible = False
        Me.txtNombreRegistro.DisplayIcon = True
        Me.txtNombreRegistro.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNombreRegistro.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtNombreRegistro.Icon = Global.CapaFormularios.My.Resources.Resources.Circled_User_Male_20px
        Me.txtNombreRegistro.Lines = New String(-1) {}
        Me.txtNombreRegistro.Location = New System.Drawing.Point(68, 80)
        Me.txtNombreRegistro.MaxLength = 32767
        Me.txtNombreRegistro.Name = "txtNombreRegistro"
        Me.txtNombreRegistro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreRegistro.PromptText = "Nombre"
        Me.txtNombreRegistro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreRegistro.SelectedText = ""
        Me.txtNombreRegistro.SelectionLength = 0
        Me.txtNombreRegistro.SelectionStart = 0
        Me.txtNombreRegistro.ShortcutsEnabled = True
        Me.txtNombreRegistro.Size = New System.Drawing.Size(338, 30)
        Me.txtNombreRegistro.Style = MetroFramework.MetroColorStyle.Orange
        Me.txtNombreRegistro.TabIndex = 16
        Me.txtNombreRegistro.UseSelectable = True
        Me.txtNombreRegistro.UseStyleColors = True
        Me.txtNombreRegistro.WaterMark = "Nombre"
        Me.txtNombreRegistro.WaterMarkColor = System.Drawing.Color.Teal
        Me.txtNombreRegistro.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtContraseñaRegistro
        '
        '
        '
        '
        Me.txtContraseñaRegistro.CustomButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtContraseñaRegistro.CustomButton.BackgroundImage = Global.CapaFormularios.My.Resources.Resources.Preview_Pane_20px_2
        Me.txtContraseñaRegistro.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtContraseñaRegistro.CustomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContraseñaRegistro.CustomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtContraseñaRegistro.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtContraseñaRegistro.CustomButton.Image = Global.CapaFormularios.My.Resources.Resources.Preview_Pane_20px
        Me.txtContraseñaRegistro.CustomButton.Location = New System.Drawing.Point(310, 2)
        Me.txtContraseñaRegistro.CustomButton.Name = ""
        Me.txtContraseñaRegistro.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtContraseñaRegistro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtContraseñaRegistro.CustomButton.TabIndex = 1
        Me.txtContraseñaRegistro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtContraseñaRegistro.CustomButton.UseSelectable = True
        Me.txtContraseñaRegistro.CustomButton.UseStyleColors = True
        Me.txtContraseñaRegistro.CustomButton.UseVisualStyleBackColor = False
        Me.txtContraseñaRegistro.CustomButton.Visible = False
        Me.txtContraseñaRegistro.DisplayIcon = True
        Me.txtContraseñaRegistro.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtContraseñaRegistro.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtContraseñaRegistro.Icon = Global.CapaFormularios.My.Resources.Resources.Password_20px
        Me.txtContraseñaRegistro.Lines = New String(-1) {}
        Me.txtContraseñaRegistro.Location = New System.Drawing.Point(68, 44)
        Me.txtContraseñaRegistro.MaxLength = 32767
        Me.txtContraseñaRegistro.Name = "txtContraseñaRegistro"
        Me.txtContraseñaRegistro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContraseñaRegistro.PromptText = "Contraseña"
        Me.txtContraseñaRegistro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContraseñaRegistro.SelectedText = ""
        Me.txtContraseñaRegistro.SelectionLength = 0
        Me.txtContraseñaRegistro.SelectionStart = 0
        Me.txtContraseñaRegistro.ShortcutsEnabled = True
        Me.txtContraseñaRegistro.ShowClearButton = True
        Me.txtContraseñaRegistro.Size = New System.Drawing.Size(338, 30)
        Me.txtContraseñaRegistro.Style = MetroFramework.MetroColorStyle.Orange
        Me.txtContraseñaRegistro.TabIndex = 15
        Me.txtContraseñaRegistro.UseSelectable = True
        Me.txtContraseñaRegistro.UseStyleColors = True
        Me.txtContraseñaRegistro.WaterMark = "Contraseña"
        Me.txtContraseñaRegistro.WaterMarkColor = System.Drawing.Color.DarkCyan
        Me.txtContraseñaRegistro.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCorreoRegistro
        '
        '
        '
        '
        Me.txtCorreoRegistro.CustomButton.Image = Global.CapaFormularios.My.Resources.Resources.Message_20px
        Me.txtCorreoRegistro.CustomButton.Location = New System.Drawing.Point(310, 2)
        Me.txtCorreoRegistro.CustomButton.Name = ""
        Me.txtCorreoRegistro.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtCorreoRegistro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCorreoRegistro.CustomButton.TabIndex = 1
        Me.txtCorreoRegistro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCorreoRegistro.CustomButton.UseSelectable = True
        Me.txtCorreoRegistro.CustomButton.Visible = False
        Me.txtCorreoRegistro.DisplayIcon = True
        Me.txtCorreoRegistro.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCorreoRegistro.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtCorreoRegistro.Icon = Global.CapaFormularios.My.Resources.Resources.Message_20px
        Me.txtCorreoRegistro.Lines = New String(-1) {}
        Me.txtCorreoRegistro.Location = New System.Drawing.Point(68, 8)
        Me.txtCorreoRegistro.MaxLength = 32767
        Me.txtCorreoRegistro.Name = "txtCorreoRegistro"
        Me.txtCorreoRegistro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreoRegistro.PromptText = "Correo"
        Me.txtCorreoRegistro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCorreoRegistro.SelectedText = ""
        Me.txtCorreoRegistro.SelectionLength = 0
        Me.txtCorreoRegistro.SelectionStart = 0
        Me.txtCorreoRegistro.ShortcutsEnabled = True
        Me.txtCorreoRegistro.Size = New System.Drawing.Size(338, 30)
        Me.txtCorreoRegistro.Style = MetroFramework.MetroColorStyle.Orange
        Me.txtCorreoRegistro.TabIndex = 14
        Me.txtCorreoRegistro.UseSelectable = True
        Me.txtCorreoRegistro.UseStyleColors = True
        Me.txtCorreoRegistro.WaterMark = "Correo"
        Me.txtCorreoRegistro.WaterMarkColor = System.Drawing.Color.Teal
        Me.txtCorreoRegistro.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CapaFormularios.My.Resources.Resources.ba31a7c1_d0f6_4804_a9c0_7d1511feecda
        Me.PictureBox1.Location = New System.Drawing.Point(197, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 457)
        Me.Controls.Add(Me.TabControlInicioSesion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormInicio"
        Me.Text = "Golumba"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TabControlInicioSesion.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlInicioSesion As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtCorreo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtContraseña As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRegistro As MetroFramework.Controls.MetroButton
    Friend WithEvents lblRespuesta As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMensajeErrorCorreo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtApellidoRegistro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombreRegistro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtContraseñaRegistro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCorreoRegistro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelefonoRegistro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboEstudios As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnSiguiente As MetroFramework.Controls.MetroButton
    Friend WithEvents txtInformacionAdicionalEstudios As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
