Imports Entidades
Imports System.Data.OleDb

Public Class Tratamiento
    Private Const cadConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\AppGrupo1.accdb"
    'Busca bien al usuario
    Public Function InicioSesion(ByVal correo As String, ByVal contraseña As String) As Usuario
        Dim sql As String = "Select * From Usuarios where Correo = @Correo"
        Dim conSql As New OleDbConnection(cadConexion)
        Dim cmdUsuario As New OleDbCommand(sql, conSql)
        cmdUsuario.Parameters.AddWithValue("@Correo", correo)
        Dim usuario As New Usuario
        Try
            conSql.Open()
            Dim dr As OleDbDataReader = cmdUsuario.ExecuteReader

            If dr.Read Then
                usuario.Correo = dr("Correo")
                usuario.Contraseña = dr("Contraseña")
                usuario.Nombre = dr("Nombre")
                usuario.Apellido = dr("Apellido")
                usuario.Estudios = dr("Estudios")
                usuario.Telefono = dr("Telefono")
                usuario.InformacionAdicionalEstudios = dr("InformacionAdicionalEstudios")
                usuario.Imagen = dr("Imagen")
                usuario.DaClase = dr("DaClase")
            End If
            Return usuario
        Catch ex As Exception
            Throw New ArgumentException("Ocurrio un error al intentar iniciar sesion")
        Finally
            conSql.Close()
        End Try
        Return Nothing
    End Function
    'Añade bien, solo hay que cambiarle el id para que tome el ultimo + 1
    Public Function InsetarNuevoUsuario(ByVal Nombre As String, ByVal Correo As String, ByVal Apellido As String, ByVal Estudios As String, ByVal Telefono As String, ByVal Contraseña As String, ByVal InformacionAdicionalEstudios As String, ByVal Imagen As String, ByVal DaClase As Boolean) As String
        Dim conSQLUsuario As New OleDbConnection(cadConexion)

        Try
            conSQLUsuario.Open()
            'Dim sql As String = "INSERT INTO Usuarios values(@id,@nombre,@correo,@apellido,@estudios,@telefono,@contraseña)"
            Dim sql As String = "INSERT INTO Usuarios values(@id,@nombre,@correo,@apellido,@estudios,@telefono,@contraseña,@InformacionAdicionalEstudios,@Imagen,@DaClase)"
            Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuario)
            Dim posicion = SacarPosicionId()
            cmdUsuarios.Parameters.AddWithValue("@id", posicion + 1)
            cmdUsuarios.Parameters.AddWithValue("@nombre", Nombre)
            cmdUsuarios.Parameters.AddWithValue("@correo", Correo)
            cmdUsuarios.Parameters.AddWithValue("@apellido", Apellido)
            cmdUsuarios.Parameters.AddWithValue("@estudios", Estudios)
            cmdUsuarios.Parameters.AddWithValue("@telefono", Telefono)
            cmdUsuarios.Parameters.AddWithValue("@contraseña", Contraseña)
            cmdUsuarios.Parameters.AddWithValue("@InformacionAdicionalEstudios", InformacionAdicionalEstudios)
            cmdUsuarios.Parameters.AddWithValue("@Imagen", Imagen)
            cmdUsuarios.Parameters.AddWithValue("@DaClase", DaClase)
            Dim nreg As Integer = cmdUsuarios.ExecuteNonQuery
            Return nreg & "Columnas afectadas"

        Catch ex As Exception
            Return "Se ha producido un error al intentar insertar un nuevo usuario"
        Finally
            conSQLUsuario.Close()
        End Try
    End Function

    Public Function InsertarNuevoLibro(ByVal libro As LibrosSegundaMano) As String
        Dim conSQLUsuario As New OleDbConnection(cadConexion)

        Try
            conSQLUsuario.Open()
            Dim sql As String = "INSERT INTO LibrosSegundaMano values(@id,@NombreUsuario,@NombreLibro,@PrecioLibro,@CantidadLibros,@Editorial,@Curso,@EstadoLibro,@Curso2,@InformacionAdicional)"
            Dim posicion As Integer = SacarPosicionIdLibros()
            Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuario)
            cmdUsuarios.Parameters.AddWithValue("@NombreUsuario", posicion + 1)
            cmdUsuarios.Parameters.AddWithValue("@NombreUsuario", libro.NombreUsuario)
            cmdUsuarios.Parameters.AddWithValue("@NombreLibro", libro.NombreLibro)
            cmdUsuarios.Parameters.AddWithValue("@PrecioLibro", libro.PrecioLibro)
            cmdUsuarios.Parameters.AddWithValue("@CantidadLibros", libro.CantidadLibros)
            cmdUsuarios.Parameters.AddWithValue("@Editorial", libro.Editorial)
            cmdUsuarios.Parameters.AddWithValue("@Curso", libro.Curso)
            cmdUsuarios.Parameters.AddWithValue("@EstadoLibro", libro.EstadoLibro)
            cmdUsuarios.Parameters.AddWithValue("@Curso2", libro.Curso2)
            cmdUsuarios.Parameters.AddWithValue("@InformacionAdicional", libro.InformacionAdicional)
            Dim nreg As Integer = cmdUsuarios.ExecuteNonQuery
            If nreg > 0 Then
                Return "Libro almacenado correctamente"
            End If

            Return "ERROR"
        Catch ex As Exception
            Return "Se ha producido un error al intentar insertar un nuevo libro"
        Finally
            conSQLUsuario.Close()
        End Try
    End Function

    Public Function Usuarios() As List(Of Usuario)
        Dim misUsuarios As New List(Of Usuario)
        Dim sql As String = "Select * From Usuarios"
        Dim conSQLUsuarios As New OleDbConnection(cadConexion)

        Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuarios)
        Try
            conSQLUsuarios.Open()
            Dim dr As OleDbDataReader = cmdUsuarios.ExecuteReader
            While dr.Read
                Dim usu As New Usuario
                usu.id = dr("id")
                usu.Nombre = dr("Nombre")
                usu.Correo = dr("Correo")
                usu.Apellido = dr("Apellido")
                usu.Estudios = dr("Estudios")
                usu.Telefono = dr("Telefono")
                usu.Contraseña = dr("Contraseña")
                usu.InformacionAdicionalEstudios = dr("InformacionAdicionalEstudios")
                usu.Imagen = dr("Imagen")
                usu.DaClase = dr("DaClase")
                misUsuarios.Add(usu)
            End While
            Return misUsuarios
        Catch ex As Exception
            Throw ex
        Finally
            conSQLUsuarios.Close()
        End Try
    End Function

    Public Function UsuariosDanClase() As List(Of Usuario)
        Dim usuDarClase As New List(Of Usuario)
        Dim sql As String = "SELECT * FROM Usuarios WHERE DaClase = True"

        Dim conSQLUsuarios As New OleDbConnection(cadConexion)
        Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuarios)

        Try
            conSQLUsuarios.Open()
            Dim dr As OleDbDataReader = cmdUsuarios.ExecuteReader
            While dr.Read
                Dim usu As New Usuario
                usu.id = dr("id")
                usu.Nombre = dr("Nombre")
                usu.Correo = dr("Correo")
                usu.Apellido = dr("Apellido")
                usu.Estudios = dr("Estudios")
                usu.Telefono = dr("Telefono")
                usu.Contraseña = dr("Contraseña")
                usu.InformacionAdicionalEstudios = dr("InformacionAdicionalEstudios")
                usu.Imagen = dr("Imagen")
                usu.DaClase = dr("DaClase")
                usuDarClase.Add(usu)
            End While
            Return usuDarClase
        Catch ex As Exception
            Throw ex
        Finally
            conSQLUsuarios.Close()
        End Try
    End Function

    'Sacamos los ids maximos de las tablas
#Region "Sacar ids"
    Public Function SacarPosicionId() As Integer
        Dim sql As String = "SELECT Max(Usuarios.id) As idMax FROM Usuarios"
        Dim conSQLUsuarios As New OleDbConnection(cadConexion)
        Dim cmdUsuario As New OleDbCommand(sql, conSQLUsuarios)
        Try
            conSQLUsuarios.Open()
            Dim dr As OleDbDataReader = cmdUsuario.ExecuteReader
            If dr.Read Then
                Dim registroId As Integer = dr("idMax")
                Return registroId
            End If
        Catch ex As Exception
            Return 0
        Finally
            conSQLUsuarios.Close()
        End Try
        Return Nothing
    End Function

    Public Function SacarPosicionIdLibros() As Integer
        Dim sql As String = "SELECT Max(LibrosSegundaMano.id) As idMax FROM LibrosSegundaMano"
        Dim conSQLUsuarios As New OleDbConnection(cadConexion)
        Dim cmdUsuario As New OleDbCommand(sql, conSQLUsuarios)
        Try
            conSQLUsuarios.Open()
            Dim dr As OleDbDataReader = cmdUsuario.ExecuteReader
            If dr.Read Then
                Dim registroId As Integer = dr("idMax")
                Return registroId
            End If
        Catch ex As Exception
            Return 0
        Finally
            conSQLUsuarios.Close()
        End Try
        Return Nothing
    End Function
#End Region



    Public Function UsuariosPorLetras(ByVal text As String) As List(Of Usuario)
        Dim misUsuarios As New List(Of Usuario)

        Dim sql As String = "Select * from Usuarios Where Usuarios.Nombre Like @texto"

        Dim conSQLUsuarios As New OleDbConnection(cadConexion)
        Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuarios)
        cmdUsuarios.Parameters.AddWithValue("@texto", "%" & text & "%")

        Try
            conSQLUsuarios.Open()
            Dim dr As OleDbDataReader = cmdUsuarios.ExecuteReader
            While dr.Read
                Dim usu As New Usuario
                usu.id = dr("id")
                usu.Nombre = dr("Nombre")
                usu.Correo = dr("Correo")
                usu.Apellido = dr("Apellido")
                usu.Estudios = dr("Estudios")
                usu.Telefono = dr("Telefono")
                usu.Contraseña = dr("Contraseña")
                usu.InformacionAdicionalEstudios = dr("InformacionAdicionalEstudios")
                usu.Imagen = dr("Imagen")
                misUsuarios.Add(usu)
            End While
            Return misUsuarios
        Catch ex As Exception
            Return Nothing
        Finally
            conSQLUsuarios.Close()
        End Try

    End Function


    Public Function LibreosSegundaMano() As List(Of LibrosSegundaMano)
        Dim misLibros As New List(Of LibrosSegundaMano)
        Dim sql As String = "Select * From LibrosSegundaMano"
        Dim conSQLLibros As New OleDbConnection(cadConexion)

        Dim cmdLibros As New OleDbCommand(sql, conSQLLibros)
        Try
            conSQLLibros.Open()
            Dim dr As OleDbDataReader = cmdLibros.ExecuteReader
            While dr.Read
                Dim libro As New LibrosSegundaMano
                libro.NombreUsuario = dr("NombreUsuario")
                libro.NombreLibro = dr("NombreLibro")
                libro.PrecioLibro = dr("PrecioLibro")
                libro.CantidadLibros = dr("CantidadLibros")
                libro.Editorial = dr("Editorial")
                libro.Curso = dr("Curso")
                libro.EstadoLibro = dr("EstadoLibro")
                libro.Curso2 = dr("Curso2")
                libro.InformacionAdicional = dr("InformacionAdicional")
                misLibros.Add(libro)
            End While
            Return misLibros
        Catch ex As Exception
            Return Nothing
        Finally
            conSQLLibros.Close()
        End Try
    End Function


    Public Function LibrosPorEditorial(ByVal text As String) As List(Of LibrosSegundaMano)
        Dim mislibros As New List(Of LibrosSegundaMano)

        Dim sql As String = "Select * from LibrosSegundaMano Where LibrosSegundaMano.Editorial Like @texto"

        Dim conSQLUsuarios As New OleDbConnection(cadConexion)
        Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuarios)
        cmdUsuarios.Parameters.AddWithValue("@texto", "%" & text & "%")

        Try
            conSQLUsuarios.Open()
            Dim dr As OleDbDataReader = cmdUsuarios.ExecuteReader
            While dr.Read
                Dim libro As New LibrosSegundaMano
                libro.NombreUsuario = dr("NombreUsuario")
                libro.NombreLibro = dr("NombreLibro")
                libro.PrecioLibro = dr("PrecioLibro")
                libro.CantidadLibros = dr("CantidadLibros")
                libro.Editorial = dr("Editorial")
                libro.Curso = dr("Curso")
                libro.EstadoLibro = dr("EstadoLibro")
                libro.Curso2 = dr("Curso2")
                mislibros.Add(libro)
            End While
            Return mislibros
        Catch ex As Exception
            Return Nothing
        Finally
            conSQLUsuarios.Close()
        End Try

    End Function


    Public Function LibrosPorPrecioMenorOIgual(ByVal precio As Integer) As List(Of LibrosSegundaMano)
        Dim mislibros As New List(Of LibrosSegundaMano)

        Dim sql As String = "Select * from LibrosSegundaMano Where LibrosSegundaMano.PrecioLibro <= @precio"

        Dim conSQLUsuarios As New OleDbConnection(cadConexion)
        Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuarios)
        cmdUsuarios.Parameters.AddWithValue("@precio", precio)

        Try
            conSQLUsuarios.Open()
            Dim dr As OleDbDataReader = cmdUsuarios.ExecuteReader
            While dr.Read
                Dim libro As New LibrosSegundaMano
                libro.NombreUsuario = dr("NombreUsuario")
                libro.NombreLibro = dr("NombreLibro")
                libro.PrecioLibro = dr("PrecioLibro")
                libro.CantidadLibros = dr("CantidadLibros")
                libro.Editorial = dr("Editorial")
                libro.Curso = dr("Curso")
                libro.EstadoLibro = dr("EstadoLibro")
                libro.Curso2 = dr("Curso2")
                mislibros.Add(libro)
            End While
            Return mislibros
        Catch ex As Exception
            Return Nothing
        Finally
            conSQLUsuarios.Close()
        End Try

    End Function


    Public Function LibrosPorPrecioExacto(ByVal precio As Integer) As List(Of LibrosSegundaMano)
        Dim mislibros As New List(Of LibrosSegundaMano)

        Dim sql As String = "Select * from LibrosSegundaMano Where LibrosSegundaMano.PrecioLibro LIKE @precio"

        Dim conSQLUsuarios As New OleDbConnection(cadConexion)
        Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuarios)
        cmdUsuarios.Parameters.AddWithValue("@precio", precio)

        Try
            conSQLUsuarios.Open()
            Dim dr As OleDbDataReader = cmdUsuarios.ExecuteReader
            While dr.Read
                Dim libro As New LibrosSegundaMano
                libro.NombreUsuario = dr("NombreUsuario")
                libro.NombreLibro = dr("NombreLibro")
                libro.PrecioLibro = dr("PrecioLibro")
                libro.CantidadLibros = dr("CantidadLibros")
                libro.Editorial = dr("Editorial")
                libro.Curso = dr("Curso")
                libro.EstadoLibro = dr("EstadoLibro")
                libro.Curso2 = dr("Curso2")
                mislibros.Add(libro)
            End While
            Return mislibros
        Catch ex As Exception
            Return Nothing
        Finally
            conSQLUsuarios.Close()
        End Try

    End Function

    Public Function ActualizarCorreo(ByVal correoAntiguo As String, ByVal correoNuevo As String) As String
        Dim sql As String = "UPDATE Usuarios SET Usuarios.Correo = @correoNuevo where Correo = @correoAntiguo"
        Dim conSQLUsuarios As New OleDbConnection(cadConexion)
        Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuarios)
        cmdUsuarios.Parameters.AddWithValue("@correoNuevo", correoNuevo)
        cmdUsuarios.Parameters.AddWithValue("@correoAntiguo", correoAntiguo)
        Try
            conSQLUsuarios.Open()
            Dim nfilas As Integer = cmdUsuarios.ExecuteNonQuery
            If nfilas = 0 Then
                Return "No se ha modificado ningun registro"
            End If
            Return "Se han modificado " & nfilas & " filas"
        Catch ex As Exception
            Return "Se ha producido un error al cambiar el correo"
        Finally
            conSQLUsuarios.Close()
        End Try
    End Function

    Public Function ActualizarImagenPerfil(ByVal imagen As String, ByVal correo As String) As String
        Dim sql As String = "UPDATE Usuarios SET Usuarios.Imagen = @Imagen WHERE Correo = @Correo"
        Dim conSQLUsuarios As New OleDbConnection(cadConexion)
        Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuarios)
        cmdUsuarios.Parameters.AddWithValue("@Imagen", imagen)
        cmdUsuarios.Parameters.AddWithValue("@Correo", correo)
        Try
            conSQLUsuarios.Open()
            Dim nfilas As Integer = cmdUsuarios.ExecuteNonQuery
            If nfilas = 0 Then
                Return "ERROR, no se ha modificado la imagen"
            End If
            Return "Exito al cambiar la imagen de perfil"
        Catch ex As Exception
            Return "ERROR"
        Finally
            conSQLUsuarios.Close()
        End Try
    End Function

    Public Function BorrarUsuario(ByVal Correo As String, ByVal nombreUsuario As String) As String
        Dim sql As String = "DELETE * FROM Usuarios WHERE Correo = @Correo AND NombreUsuario = @NombreUsuario"
        Dim conSQLUsuario As New OleDbConnection(cadConexion)
        Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuario)
        cmdUsuarios.Parameters.AddWithValue("@Correo", Correo)
        cmdUsuarios.Parameters.AddWithValue("@NombreUsuario", nombreUsuario)
        Try
            conSQLUsuario.Open()
            Dim nreg As Integer = cmdUsuarios.ExecuteNonQuery()
            If nreg > 0 Then
                Return "El usuario se ha eliminado correctamente"
            End If
        Catch ex As Exception
            Return "ERROR"
        Finally
            conSQLUsuario.Close()
        End Try
        Return Nothing
    End Function

    Public Function BorrarLibrosUsuario(ByVal nombreUsuario As String) As String
        Dim sql As String = "DELETE * FROM LibrosSegundaMano WHERE NombreUsuario = @NombreUsuario"
        Dim conSQLUsuario As New OleDbConnection(cadConexion)
        Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuario)
        cmdUsuarios.Parameters.AddWithValue("@NombreUsuario", nombreUsuario)
        Try
            conSQLUsuario.Open()
            Dim nreg As Integer = cmdUsuarios.ExecuteNonQuery()
            If nreg > 0 Then
                Return "Los libros del usuario se ha eliminado correctamente"
            End If
        Catch ex As Exception
            Return "ERROR"
        Finally
            conSQLUsuario.Close()
        End Try
        Return Nothing
    End Function
End Class
