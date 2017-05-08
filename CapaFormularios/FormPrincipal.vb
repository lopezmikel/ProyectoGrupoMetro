Imports Entidades
Imports CapaDatos
Imports System.ComponentModel
Imports MetroFramework

Public Class FormPrincipal
    Private DatosUsuario As New Usuario
    Private Trat As New Tratamiento
    Private Color As New Controls.MetroTile
    Private BotonSelect As New Controls.MetroTile
    Private cursos() As String = {"1", "2", "3", "4"}
    Private cursos2() As String = {"1", "2"}
    Private LibroAñadir As Boolean = False
    Private CambiarCorreoMostrar As Boolean = False
    Private CambiarColoresMostrar As Boolean = False
    Private EliminacionCorrecta As Boolean = False

    Private Sub FormPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim frmInicio As New FormInicio
        frmInicio.Close()
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroPanelOpciones.Visible = False
        MetroPanelOpciones.Visible = False
        MetroPanelOpciones.Visible = False
        MetroPanelOpciones.Visible = False
        DatosUsuario = Module1.usu
        MetroTabPage1.Text = "Mostrar Usuarios"
        MetroTabPage3.Text = "Dan clase"
        MetroTabPage4.Text = "Libros segunda mano"
        MetroTabPage5.Text = "Perfil Usuario"
        MetroTabPage6.Text = "Quienes somos"
        ActualizarDataGrid()
        ActualizarDataGridLibros()
        actualizarDataGridDanClase()

        dgvLibros.Columns("id").Visible = False
        dgvDanClase.Columns("id").Visible = False
        dgvUsuarios.Columns("id").Visible = False
        dgvUsuarios.Columns("Imagen").Visible = False
        dgvDanClase.Columns("Imagen").Visible = False
        dgvUsuarios.Columns("contraseña").Visible = False
        dgvUsuarios.Columns("DaClase").Visible = False
        dgvDanClase.Columns("DaClase").Visible = False
        dgvUsuarios.Columns("InformacionAdicionalEstudios").Width = 600
        dgvDanClase.Columns("InformacionAdicionalEstudios").Width = 600
        dgvLibros.Columns("InformacionAdicional").Width = 500

        lblCorreoAntiguo.Text = "Correo a cambiar: " & DatosUsuario.Correo


        MetroPanelAñadirLibro.Visible = False
        MetroPanelCambiarCorreo.Visible = False

        If DatosUsuario.Imagen = "Imagen" Then
            PictureBox1.Image = CapaFormularios.My.Resources.Resources.Circled_User_Male_100px
        Else
            PictureBox1.ImageLocation = DatosUsuario.Imagen
        End If

    End Sub


    Private Sub btnMetroAjustes_Click(sender As Object, e As EventArgs)
        MetroPanelOpciones.Visible = True
    End Sub

    Private Sub FormPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormInicio.Close()
    End Sub


    Private Sub txtBuscarNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNombre.TextChanged
        Dim usu As New List(Of Usuario)
        usu = Trat.UsuariosPorLetras(txtBuscarNombre.Text)
        dgvUsuarios.DataSource = usu
    End Sub

    Private Sub btnAplicar_Click_1(sender As Object, e As EventArgs) Handles btnAplicar.Click
        If txtColor.Text <> "" AndAlso txtControlSeleccionado.Text <> "" Then
            Dim metrocolor As New MetroFramework.MetroColorStyle
            BotonSelect.Style = Color.Style
        Else
            MetroMessageBox.Show(Me, "Selecciona elemento y color para modificar", "Completa los campos", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
        End If
    End Sub



    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile6.Click, MetroTile5.Click, MetroTile4.Click, MetroTile3.Click, MetroTile2.Click, MetroTile1.Click
        Dim buton As Button = TryCast(sender, MetroFramework.Controls.MetroTile)
        txtColor.Text = buton.Tag
        Color = buton
    End Sub

    Private Sub btnMetroAjustes_Click_1(sender As Object, e As EventArgs) Handles btnMetroAjustes.Click
        If CambiarColoresMostrar = False Then
            MetroPanelOpciones.Visible = True
            CambiarColoresMostrar = True
        Else
            MetroPanelOpciones.Visible = False
            CambiarColoresMostrar = False
        End If

    End Sub

    Private Sub btnApellidoUsuario_Click(sender As Object, e As EventArgs) Handles btnTelefonoUsuario.Click, btnNombreUsuario.Click, btnEstudiosUsuario.Click, btnCorreoUsuario.Click, btnApellidoUsuario.Click
        Dim buton As Button = TryCast(sender, MetroFramework.Controls.MetroTile)
        txtControlSeleccionado.Text = buton.Tag
        BotonSelect = buton
    End Sub

    Private Sub btnCambiarCorreo_Click(sender As Object, e As EventArgs) Handles btnCambiarCorreo.Click
        Dim respuesta As String

        If lblCorreoAntiguo.Text = "Correo a cambiar: " Then
            MetroMessageBox.Show(Me, "Hay un problema con el correo actual, reinicie la aplicación", "Error con el correo", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtCorreoNuevo.Text) Then
            MetroMessageBox.Show(Me, "Introduce un correo nuevo para cambiarlo por el antiguo", "Error al introducir el correo", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
            Exit Sub
        End If


        respuesta = Trat.ActualizarCorreo(DatosUsuario.Correo, txtCorreoNuevo.Text)
        If respuesta.Contains("error") Then
            MetroMessageBox.Show(Me, respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
        Else
            MetroMessageBox.Show(Me, "Se ha cambiado correctamente el correo", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, 200)
            DatosUsuario.Correo = txtCorreoNuevo.Text
            ActualizarDataGrid()
        End If


    End Sub

    Private Sub ActualizarDataGrid()
        Dim usuarios As New List(Of Usuario)
        usuarios = Trat.Usuarios
        dgvUsuarios.DataSource = usuarios

        btnNombreUsuario.Text = "Nombre Usuario: " & ControlChars.NewLine & DatosUsuario.Nombre
        btnApellidoUsuario.Text = "Apellido: " & ControlChars.NewLine & DatosUsuario.Apellido
        btnEstudiosUsuario.Text = "Estudios: " & ControlChars.NewLine & DatosUsuario.Estudios
        btnCorreoUsuario.Text = "Correo Usuario: " & ControlChars.NewLine & DatosUsuario.Correo
        btnTelefonoUsuario.Text = "Telefono: " & ControlChars.NewLine & DatosUsuario.Telefono
    End Sub

    Private Sub ActualizarDataGridLibros()
        Dim libros As New List(Of LibrosSegundaMano)
        libros = Trat.LibreosSegundaMano
        dgvLibros.DataSource = libros
    End Sub

    Private Sub actualizarDataGridDanClase()
        Dim usuarios As New List(Of Usuario)
        usuarios = Trat.UsuariosDanClase
        dgvDanClase.DataSource = usuarios
    End Sub


    Private Sub cboCurso2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCurso2.SelectedIndexChanged

        If cboCurso2.Text <> "" Then
            cboCurso1.Enabled = True
            If cboCurso2.Text = "UNIVERSIDAD" OrElse cboCurso2.Text = "ESO" Then
                cboCurso1.Items.Clear()
                cboCurso1.Items.AddRange(cursos)
            Else
                cboCurso1.Items.Clear()
                cboCurso1.Items.AddRange(cursos2)
            End If
        End If
        cboCurso1.Enabled = True
    End Sub

    Private Sub MetroTrackBar1_Scroll_1(sender As Object, e As ScrollEventArgs) Handles tbPrecioLibro.Scroll
        bunifuMedioCirculoPrecio.Value = tbPrecioLibro.Value
        lblPrecioLibro.Text = tbPrecioLibro.Value
    End Sub

    Private Sub btnAñadirLibro_Click(sender As Object, e As EventArgs) Handles btnAñadirLibro.Click
        Dim respuesta As String = ""
        If String.IsNullOrWhiteSpace(txtEditorial.Text) Then
            MetroMessageBox.Show(Me, "Introduce una editorial", "Error al introducir la editorial", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtNombreLibro.Text) Then
            MetroMessageBox.Show(Me, "Introduce el nombre del libro que vas a vender", "Error al introducir el nombre del libro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cboCurso1.Text) Then
            MetroMessageBox.Show(Me, "Selecciona el curso al que pertenece el libro", "Error al seleccionar el curso", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cboCurso2.Text) Then
            MetroMessageBox.Show(Me, "Selecciona el grado al que pertenece el libro", "Error al seleccionar el grado", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cboEstadoLibro.Text) Then
            MetroMessageBox.Show(Me, "Selecciona el estado del libro", "Error al seleccionar estado del libro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtInformacionAdicionalLibro.Text) Then
            txtInformacionAdicionalLibro.Text = "Sin información Adicional"
        End If
        respuesta = Trat.InsertarNuevoLibro(New LibrosSegundaMano(DatosUsuario.Nombre, txtNombreLibro.Text, lblPrecioLibro.Text, txtCantidadLibros.Value, txtEditorial.Text, cboCurso1.Text, cboEstadoLibro.Text, cboCurso2.Text, txtInformacionAdicionalLibro.Text))
        If respuesta.ToUpper.Contains("ERROR") Then
            MetroMessageBox.Show(Me, "Error al intentar añadir el libro, vuelva a intentarlo", "Error al introducir el libro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
        Else
            MetroMessageBox.Show(Me, respuesta, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, 200)
            ActualizarDataGridLibros()
        End If

    End Sub

    Private Sub txtBuscarPorEditorial_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarPorEditorial.TextChanged
        Dim libro As New List(Of LibrosSegundaMano)
        libro = Trat.LibrosPorEditorial(txtBuscarPorEditorial.Text)
        dgvLibros.DataSource = libro
    End Sub

    Private Sub btnMostrarAñadirLibro_Click(sender As Object, e As EventArgs) Handles btnMostrarAñadirLibro.Click
        If LibroAñadir = False Then
            MetroPanelAñadirLibro.Visible = True
            LibroAñadir = True
        Else
            MetroPanelAñadirLibro.Visible = False
            LibroAñadir = False
            txtEditorial.Text = ""
            txtNombreLibro.Text = ""
            txtInformacionAdicionalLibro.Text = ""
            lblPrecioLibro.Text = "0"
            bunifuMedioCirculoPrecio.Value = 0
            tbPrecioLibro.Value = 0
            txtCantidadLibros.Value = 1
        End If
        cboCurso1.Enabled = False
    End Sub

    Private Sub btnMostrarCambirCorreo_Click(sender As Object, e As EventArgs) Handles btnMostrarCambirCorreo.Click
        If CambiarCorreoMostrar = False Then
            MetroPanelCambiarCorreo.Visible = True
            CambiarCorreoMostrar = True
        Else
            MetroPanelCambiarCorreo.Visible = False
            CambiarCorreoMostrar = False
        End If
    End Sub

    Private Sub btnEliminarUsuario_Click_1(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        Dim respuesta As String = ""
        Dim resp As DialogResult = MetroMessageBox.Show(Me, "Estas seguro de que deseas eliminar tu perfil, una vez hecho no habra vuelta atras", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 200)
        If resp = DialogResult.OK Then
            respuesta = Trat.BorrarUsuario(DatosUsuario.Correo, DatosUsuario.Nombre)
            If respuesta <> Nothing Then
                If respuesta.ToUpper.Contains("ERROR") Then
                    MetroMessageBox.Show(Me, "Error al eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
                Else
                    MetroMessageBox.Show(Me, respuesta, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, 200)
                    ActualizarDataGrid()
                    EliminacionCorrecta = True
                End If
            End If

            respuesta = Trat.BorrarLibrosUsuario(DatosUsuario.Nombre)
            If respuesta <> Nothing Then
                If respuesta.ToUpper.Contains("ERROR") Then
                    MetroMessageBox.Show(Me, "Error al eliminar los libros del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
                Else
                    MetroMessageBox.Show(Me, respuesta, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, 200)
                    ActualizarDataGridLibros()
                End If
            End If

            If EliminacionCorrecta = True Then
                FormInicio.Close()
            End If
        End If
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick

        Dim resp As DialogResult = MetroMessageBox.Show(Me, "¿Quieres modificar tu imagen de perfil?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 200)
        If resp = DialogResult.OK Then
            Dim dlgAbrir As New OpenFileDialog
            dlgAbrir.Filter = "Imagen (*.jpg)|*.jpg|Todos los archivos (*.*)|*.*"
            If dlgAbrir.ShowDialog = DialogResult.Cancel Then Exit Sub
            Dim ficheroConRuta As String = dlgAbrir.FileName
            PictureBox1.ImageLocation = ficheroConRuta
            Dim respuesta As String = Trat.ActualizarImagenPerfil(ficheroConRuta, DatosUsuario.Correo)
            If respuesta.Contains("ERROR") Then
                MetroMessageBox.Show(Me, "Error al modificar la imagen de perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
            Else
                MetroMessageBox.Show(Me, respuesta, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, 200)
            End If
        End If


    End Sub

    Private Sub MetroTrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles tbPrecioBuscar.Scroll
        Dim misLibros As New List(Of LibrosSegundaMano)
        misLibros = Trat.LibrosPorPrecioMenorOIgual(tbPrecioBuscar.Value)
        dgvLibros.DataSource = misLibros
        MedioCirculoPrecioABusar.Value = tbPrecioBuscar.Value
        lblPrecioABuscar.Text = tbPrecioBuscar.Value
    End Sub

    Private Sub btnBuscarLibroPorPrecio_Click(sender As Object, e As EventArgs) Handles btnBuscarLibroPorPrecio.Click
        Dim misLibros As New List(Of LibrosSegundaMano)
        misLibros = Trat.LibrosPorPrecioExacto(tbPrecioBuscar.Value)
        dgvLibros.DataSource = misLibros
    End Sub

    Private Sub btnLimpiarDgvLibros_Click(sender As Object, e As EventArgs) Handles btnLimpiarDgvLibros.Click
        ActualizarDataGridLibros()
    End Sub
End Class