Public Class Empleado

    'atributos
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _edad As Integer

    Public Property Edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            Edad = value
        End Set
    End Property

    Private _Salario As Double
    Public Property Salario() As Double
        Get
            Return _Salario
        End Get
        Set(ByVal value As Double)
            _Salario = value
        End Set
    End Property

    'Shared palabra especial compartir atrubuto ,cuando este valor se modifique se modificara para todos los objetos
    Private Shared _recuento As Integer 'aqui donde quiero almacenar cada vez que cree un objeto
    'Shared palabra especial compartir atrubuto ,cuando este valor se modifique se modificara para todos los objetos

    Public Shared Property Recuento() As Integer
        Get
            Return _recuento
        End Get
        Set(ByVal value As Integer)
            _recuento = value
        End Set
    End Property



    'creamos constructor
    Public Sub New(ByVal nombre As String, ByVal edad As Integer)
        _nombre = nombre
        _edad = edad
        _Salario = 1200
        _recuento += 1 'cuando se cree un nuevo onjeto que sume 1,contamos nºobjetos

    End Sub





End Class
