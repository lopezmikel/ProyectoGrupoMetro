Imports CapaDatos
Imports Entidades
Imports MetroFramework

Public Class FormInicio
    Private trat As New Tratamiento
    Private ContArrobas As Integer = 0
    Private contPuntos As Integer = 0
    Private contra As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabPage1.Text = "Inicio Sesion"
        MetroTabPage2.Text = "Crear Cuenta"
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtCorreo.Text) OrElse String.IsNullOrWhiteSpace(txtContraseña.Text) Then
            lblRespuesta.Text = "Introduce un correo y una contraseña"
            Exit Sub
        End If
        lblMensajeErrorCorreo.Text = ""
        lblRespuesta.Text = ""
        Dim usu As New Usuario
        usu = trat.InicioSesion(txtCorreo.Text, txtContraseña.Text)
        If usu.Correo = txtCorreo.Text AndAlso usu.Contraseña = txtContraseña.Text Then
            Me.Style = MetroColorStyle.Blue
            lblRespuesta.Text = "Bienvenido " & usu.Nombre
            lblRespuesta.Style = MetroColorStyle.Blue
            btnLogin.Style = MetroColorStyle.Blue
            txtCorreo.Text = ""
            txtContraseña.Text = ""
            Module1.usu = usu
            Me.Visible = False
            FormPrincipal.Show()
        Else
            Me.Style = MetroColorStyle.Red
            txtContraseña.Text = ""
            lblRespuesta.Text = "Error, el usuario no existe"
            btnLogin.Style = MetroColorStyle.Red
        End If
    End Sub

    Private Sub txtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreo.KeyPress

        If e.KeyChar = "@" Then
            If txtCorreo.Text <> "" Then
                If txtCorreo.Text.Contains("@") Then
                    e.KeyChar = ""
                    lblMensajeErrorCorreo.Text = "Solo puede haber un @ en el correo"
                End If
            Else
                lblMensajeErrorCorreo.Text = "Debe de tener algo de texto antes del @"
                e.KeyChar = ""
            End If

        End If

        If e.KeyChar = "." Then
            If Not txtCorreo.Text.Contains("@") Then
                lblMensajeErrorCorreo.Text = "El punto solo puede ir por detras del @"
                e.KeyChar = ""
            End If

            If txtCorreo.Text.Contains(".") Then
                e.KeyChar = ""
                lblMensajeErrorCorreo.Text = "Solo puede haber un . en el correo"
            End If
        End If



    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim estudios As String = ""
        Dim respuesta As String = ""
        If String.IsNullOrWhiteSpace(cboEstudios.Text) Then
            estudios = "Sin estudios"
        Else
            estudios = cboEstudios.Text
        End If

        If String.IsNullOrWhiteSpace(txtInformacionAdicionalEstudios.Text) Then
            txtInformacionAdicionalEstudios.Text = "Sin información"
        End If

        respuesta = trat.InsetarNuevoUsuario(txtNombreRegistro.Text, txtCorreoRegistro.Text, txtApellidoRegistro.Text, estudios, txtTelefonoRegistro.Text, txtContraseñaRegistro.Text, txtInformacionAdicionalEstudios.Text, "Imagen", False)
        If respuesta.Contains("Columnas afectadas") Then
            txtNombreRegistro.Text = ""
            txtApellidoRegistro.Text = ""
            txtContraseñaRegistro.Text = ""
            txtCorreoRegistro.Text = ""
            txtTelefonoRegistro.Text = ""
            txtInformacionAdicionalEstudios.Text = ""
            cboEstudios.Text = ""
        End If
        MetroMessageBox.Show(Me, respuesta)
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        FormPrincipal.Show()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If contra = False Then
            txtContraseñaRegistro.PasswordChar = ""
            contra = True
        Else
            txtContraseñaRegistro.PasswordChar = "*"
            contra = False
        End If
    End Sub
End Class
