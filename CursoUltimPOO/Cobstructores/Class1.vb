Public Class Personas
    'Creamos Campo de clase  _nombre
    Private _nombre As String
    Public Property Nombre()
        Get
            Return _nombre
        End Get
        Set(value)
            _nombre = value
        End Set
    End Property
    'Creamos campo de clase nombre  hacia arriba


    'Creamos campo de clase _edad
    Private _edad As Integer   ' escribimos property y tabulador 2 veces se hace automatico,cambiar nombres
    Public Property Edad() As Integer  ' escribimos property y tabulador 2 veces se hace automatico,cambiar nombres
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)  'escribimos property y tabulador 2 veces se hace automatico,cambiar nombres)
            _edad = value
        End Set
    End Property
    'Creamos campo de clase _edad del nombre hacia arriba codigo

    'CONSTRUCTOR
    Public Sub New()
        _nombre = "Nombre no asignado"
        _edad = 0
    End Sub

    'SOBRECARGA DE CONSTRUCTOR
    Public Sub New(ByVal nombre As String, ByVal edad As Integer)
        _nombre = nombre
        _edad = edad
    End Sub

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
        Console.WriteLine("Necesito unas vacaciones")
    End Sub

    Public Sub comer()

    End Sub

End Class
