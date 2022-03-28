Public Class Alumno

    Inherits Personas ' clase alumno herede de la clase persona

    'creamos constructores
    Public Sub New()

    End Sub


    'ATRIBUTOS
    Private _notaMedia As Double
    Public Property NotaMedia() As Double
        Get
            Return _notaMedia
        End Get
        Set(ByVal value As Double)
            _notaMedia = value
        End Set
    End Property



    'METODOS
    'sobrescribimos el metodo hablar de la case padre con overloads
    Public Overloads Sub Hablar() ' personalizamos la clase heredada de la clase padre
        MyBase.Hablar()
        Console.WriteLine("Estoy cansado de tanto estudiar")
    End Sub
End Class
