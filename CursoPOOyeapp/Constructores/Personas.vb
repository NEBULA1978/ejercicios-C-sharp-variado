Public Class Personas 'clase persona

    'Propiedades de este objeto persona : campo de clase privado respetar normas encapsulacion
    'Campos de clase
    Private _nombre As String  'campo de clase Nombre
    'para pode tener acceso a este campo tenemos crear la propiedad
    Public Property Nombre() 'Propiedad a lo que haya guardado o darle valor nuevo
        Get
            Return _nombre
        End Get
        Set(value)
            _nombre = value
        End Set
    End Property

    'siguiente propiedad : property y tabulador 2ves se crea automatico
    Private _edad As Integer

    Public Property Edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property


    'Constructor:
    'Constructor:
    'metodo especial,tener acceso "Public Sub New"
    Public Sub New()
        _nombre = "Nombre no asignado"
        _edad = 0
    End Sub

    'Sobrecarga de constructores
    Public Sub New(ByVal nombre As String, ByVal edad As Integer)
        _nombre = nombre
        _edad = edad
    End Sub








    'otro constructor
    '  Public Sub New(ByVal nombre As String)
    '     _nombre = nombre
    '      _edad = 0
    ' End Sub


    'otro constructor
    '  Public Sub New(ByVal edad As Integer)
    '      _nombre = "Nombre no asignado"
    '      _edad = edad

    '   End Sub



    'Metodos :que puedo o no puede hacer el objeto persona que vamo a crear
    Public Sub Hablar()
        Console.WriteLine("Necesito unas vacaciones")
    End Sub

    Public Sub Comer()

    End Sub

End Class
