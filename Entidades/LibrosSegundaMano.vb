Public Class LibrosSegundaMano
    Public Property id As Integer
    Public Property NombreUsuario As String
    Public Property NombreLibro As String
    Public Property PrecioLibro As Decimal
    Public Property CantidadLibros As Integer
    Public Property Editorial As String
    Public Property Curso As String
    Public Property EstadoLibro As String
    Public Property Curso2 As String
    Public Property InformacionAdicional As String

    Public Sub New(ByVal NombreUsuario As String, ByVal NombreLibro As String, ByVal PrecioLibro As Decimal, ByVal CantidadLibros As Integer, ByVal Editorial As String, ByVal Curso As String, ByVal EstadoLibro As String, ByVal Curso2 As String, ByVal InformacionAdicional As String)
        Me.NombreUsuario = NombreUsuario
        Me.NombreLibro = NombreLibro
        Me.PrecioLibro = PrecioLibro
        Me.CantidadLibros = CantidadLibros
        Me.Editorial = Editorial
        Me.Curso = Curso
        Me.EstadoLibro = EstadoLibro
        Me.Curso2 = Curso2
        Me.InformacionAdicional = InformacionAdicional
    End Sub

    Public Sub New()

    End Sub
End Class
