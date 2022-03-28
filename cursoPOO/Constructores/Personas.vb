Public Class Personas

    'Campos de clase
    Private _nombre As String  'creando un campo de clase nombre para que todo objeto perteneciente a la clase persona tenga una propiedad que sea el nombre de esta persona
    'para poder tener accerso a este campo creamos la propiedad
    Public Property Nombre()
        Get
            Return _nombre
        End Get
        Set(value)
            _nombre = value

        End Set
    End Property

    'siguiente propiedad forma rapida ,escribo property y tabulador 2veces y se crea rapido
    'campo de clase 2
    Private _edad As Integer

    Public Property Edad() As Integer
        Get
            Return _edad

        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property

    'Constructor
    Public Sub New()
        _nombre = "Nombre no asignado"
        _edad = 0
    End Sub

    'sobrecarga de constructores
    Public Sub New(ByVal nombre As String, ByVal edad As Integer) 'pulsamos intro y senos cierra el bloque
        _nombre = nombre
        _edad = edad
    End Sub

    'creamos otro constructor
    Public Sub New(ByVal nombre As String)
        _nombre = nombre
        _edad = 0
    End Sub

    Public Sub New(ByVal edad As Integer)
        _nombre = "Nombre no asignado"
        _edad = edad

    End Sub

    'Metodos
    Public Sub Hablar()

    End Sub

    Public Sub Comer()

    End Sub

End Class
