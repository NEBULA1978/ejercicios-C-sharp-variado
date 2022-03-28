Public Class Empleado
    Inherits Personas

    'creamos constructor

    Public Sub New(ByVal nombre As String, ByVal edad As Integer, ByVal salario As Double)
        _salario = salario
        Me.Nombre = nombre ' palabre especial tenem aces todos camps de clase
        Me.Edad = edad



    End Sub

    'atributos
    Private _salario As Double
    Public Property Salario() As Double
        Get
            Return _salario
        End Get
        Set(ByVal value As Double)
            _salario = value
        End Set
    End Property



    'metodos
    Public Overloads Sub Hablar()
        MyBase.Hablar()
        Console.WriteLine("Estoy cansado de tanto trabajar")
    End Sub

End Class
