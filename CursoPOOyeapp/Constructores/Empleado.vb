Public Class Empleado

    'usamos la herencia para heredar metodos y todas sus propiedades 
    Inherits Personas ' le decimos que la clase Empleado herede de la clase Personas

    'creamos constructores
    Public Sub New(ByVal nombre As String, ByVal edad As Integer, ByVal salario As Double) '3parametros para inicializar el objeto
        'atributo = paremtro recibido
        _salario = salario
        Me.Nombre = nombre 'hace referencia a la clase empleado que tiene un conjunto de campos de clase que aunque no estan visibles en esta clase :con me podemos aceder
        Me.Edad = edad   'hace referencia a la clase empleado que tiene un conjunto de campos de clase que aunque no estan visibles en esta

    End Sub



    'ATRIBUTOS
    Private _salario As Double
    Public Property Salario() As Double
        Get
            Return _salario
        End Get
        Set(ByVal value As Double)
            _salario = value
        End Set
    End Property

    Public Overloads Sub Hablar()  '    SOBREESCRIBIMOS EL TEXTO CON oberloads de la clase principal heredado
        MyBase.Hablar() 'ejecuta el metodo hablar de la clase padre
        Console.WriteLine("Estoy cansado de tanto trabajar")
    End Sub

End Class
