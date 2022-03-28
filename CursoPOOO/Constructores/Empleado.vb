Public Class Empleado

    Inherits Personas ' clase empleado herede de la clase persona

    ' costructores
    Public Sub New(ByVal nombre As String, ByVal edad As Integer, ByVal salario As Double)
        _salario = salario 'parametro recibido
        Me.Nombre = nombre ' Me palabra reservada tenemos acceso a todos los campos de clase
        Me.Edad = edad  ' Me palabra reservada tenemos acceso a todos los campos de clase Empleado
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



    'METODOS
    Public Overloads Sub Hablar() ' personalizamos la clase heredada de la clase padre
        MyBase.Hablar()
        Console.WriteLine("Estoy cansado de tanto trabajar")
    End Sub

End Class
