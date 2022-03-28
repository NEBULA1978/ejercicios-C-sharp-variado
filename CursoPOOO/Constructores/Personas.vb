Public Class Personas
    'Propiedad : creamos campos de clase

    Private _nombre As String  'creamos campo de clase _nombe y ponemos nombre

    'creamos la propiedad para tener aceso al campo de clase _nombre
    Public Property Nombre()
        Get
            Return _nombre
        End Get
        Set(value)
            _nombre = value
        End Set
    End Property

    Private _edad As Integer  'creamos campo de clase _edad y introducimos edad

    'creamos la propiedad para tener aceso al campo de clase _edad
    Public Property Edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property

    'CONSTRUCTOR
    Public Sub New()
        _nombre = "Nombre no asignado"
        _edad = 0
    End Sub

    'Sobrecarga de constructores
    Public Sub New(ByVal nombre As String, ByVal edad As Integer)
        _nombre = nombre
        _edad = edad


    End Sub

    'Sobrecarga de constructores2
    '  Public Sub New(ByVal nombre As String)
    '     _nombre = nombre
    '      _edad = 0


    '  End Sub

    'Sobrecarga de constructores3
    '  Public Sub New(ByVal edad As Integer)
    '      _nombre = "Nombre no asignado"
    '      _edad = edad


    '  End Sub



    'Metodos que puedo y no puede hacer
    Public Sub Hablar()
        Console.WriteLine("Necesito unas vacaciones")

    End Sub

    Public Sub comer()

    End Sub

End Class
