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
            _edad = value
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

    Private Shared _recuento As Integer ' palabra Shared compartido,es un atributode la propia clase

    Public Shared Property Recuento() As Integer
        Get
            Return _recuento
        End Get
        Set(ByVal value As Integer)
            _recuento = value
        End Set
    End Property

    ''video 5 campos de clase estaticos minuto 3,15

    'Constructor
    Public Sub New(ByVal nombre As String, ByVal edad As Integer)
        _nombre = nombre
        _edad = edad
        _Salario = 1200
        _recuento += 1 ' recuento es igual a su valor mas 1 para cuando creamos otro objeto


    End Sub

End Class
