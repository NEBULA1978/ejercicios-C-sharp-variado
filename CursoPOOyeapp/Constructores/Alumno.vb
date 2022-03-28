Public Class Alumno

    'usamos la herencia para heredar metodos y todas sus propiedades 
    Inherits Personas ' le decimos que la clase Alumno herede de la clase Personas

    'creamos constructores
    Public Sub New()

    End Sub




    'ATRIBUTOS
    Private _notaMedia As Double
    Public Property notaMediay() As Double
        Get
            Return _notaMedia
        End Get
        Set(ByVal value As Double)
            _notaMedia = value
        End Set
    End Property

    'METODOS
    Public Overloads Sub Hablar()  '    SOBREESCRIBIMOS EL TEXTO CON oberloads de la clase principal heredado
        MyBase.Hablar()  'ejecuta el metodo hablar de la clase padre
        Console.WriteLine("Estoy cansado de tanto estudiar")
    End Sub


End Class
