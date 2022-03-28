Public Class Alumno
    Inherits Personas ' de la clase alumno herede de la clase persona

    'creamos constructor
    Public Sub New()

    End Sub


    'Atributos
    Private _notaMedia As Double
    Public Property NotaMedia() As Double
        Get
            Return _notaMedia
        End Get
        Set(ByVal value As Double)
            _notaMedia = value
        End Set
    End Property


    'Metodos
    Public Overloads Sub Hablar()
        MyBase.Hablar()
        Console.WriteLine("Estoy cansado de tanto estudiar")
    End Sub

End Class
