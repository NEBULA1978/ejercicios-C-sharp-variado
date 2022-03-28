Public Class CalculadoraArea
    'atributos de nuestra clase'
    'CAMPOS DE CLASE PRIVADOS
    Private pi As Double = 3.1416

    Private _m1 As Double
    Public m2 As Double
    'Tenemos el diseño de nustra clase no tenemos ningun objeto
    'atributos de nuestra clase hacia arriba'

    'Bloque de la propiedad
    Public Property m1() As Double
        Get 'bloque de codigo obtener el dato
            Return _m1
        End Get 'bloque codigo asignar el dato
        Set(value As Double)
            If value < 0 Then
                Console.WriteLine("El area indicada no es valida.")
            Else
                _m1 = value
            End If

        End Set

    End Property

    'Bloque de la propiedad hacia arriba

    'Metosdos de la clase que puede y no puede hacer'
    'encapsulamos con Private y Public
    Public Function areaTriangulo(ByVal base As Double, ByVal altura As Double) As Double 'parametro base * altura

        Return (base * altura) / 2

    End Function

    Public Function areaCuadrado(ByVal lado As Double) As Double 'parametro lado
        Return lado * lado

    End Function

    Public Function areaRectangulo(ByVal base As Double, ByVal altura As Double) As Double 'parametro base * altura

        Return base * altura

    End Function

    Public Function areaCircunferencia(ByVal radio As Double) As Double

        Return pi * (radio * radio)

    End Function

End Class
