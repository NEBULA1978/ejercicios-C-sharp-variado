Public Class EMpleada

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


    Private _salario As String
    Public Property Salario() As String
        Get
            Return _salario
        End Get
        Set(ByVal value As String)
            _salario = value
        End Set
    End Property

    'modifica a todos los objetos Shared el contador
    Private Shared _recuento As Integer ' aqui quiero almacenar cada vez que se crea un objeto ypalabra reservada Shared(compartir)
    Public Shared Property Recuento() As Integer
        Get
            Return _recuento
        End Get
        Set(ByVal value As Integer)
            _recuento = value
        End Set
    End Property

    'Constructor
    Public Sub New(ByVal nombre As String, ByVal edad As Integer)
        _nombre = nombre
        _edad = edad
        _salario = 1200
        _recuento += 1 'contador nº objetos que vamos creando

    End Sub

End Class
