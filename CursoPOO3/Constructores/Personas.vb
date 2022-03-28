Public Class Personas
    'propiedades campo de clase privado encapsulacion
    'campo de clase nombre
    Private _nombre As String
    Public Property Nombre()
        Get
            Return _nombre
        End Get
        Set(value)
            _nombre = value
        End Set
    End Property

    'campo de clase edad
    Private _edad As Integer

    Public Property Edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property

    'constructor
    Public Sub New()
        _nombre = "Nombre no asignado"
        _edad = 0
    End Sub

    'sobrecarga de constructores
    '  Public Sub New(ByVal nombre As String, ByVal edad As Integer)
    '      _nombre = nombre
    '      _edad = edad
    '   End Sub


    '  Public Sub New(ByVal nombre As String)
    '      _nombre = nombre
    '      _edad = 0


    '   End Sub

    '  Public Sub New(ByVal edad As Integer)
    '      _nombre = "Nombre no asignado"
    '      _edad = edad
    '  End Sub

    'Metodos
    Public Sub Hablar()
        Console.WriteLine("Necesito unas vacaciones")

    End Sub

    Public Sub Comer()

    End Sub

End Class
