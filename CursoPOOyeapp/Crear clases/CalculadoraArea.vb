Public Class CalculadoraArea

    'atributos de nuestra clase primer video
    '  Dim pi As Double = 3.1416
    ' Dim m1 As Double
    '  Dim m2 As Double
    'atributos de campos de clase con Private no con Dim : 2ºvideo encapsulacion
    Private pi As Double = 3.1416 'no se puede acceder sino es desde la misma clase

    Private _m1 As Double
    Public m2 As Double

    'Propiedad _m1 forma correcta con get y set
    Public Property m1 As Double
        Get
            Return _m1
        End Get
        Set(value As Double)
            If value < 0 Then
                Console.WriteLine("El area indicada no es valida")
            Else
                m1 = value
            End If

        End Set

    End Property

    'metodos video 1
    ' Function areaTriangulo(ByVal base As Double, ByVal altura As Double) As Double

    '     Return (base * altura) / 2

    'End Function

    '  Function areaCuadrado(ByVal lado As Double) As Double

    '      Return lado * lado
    '  End Function

    '  Function areaRectangulo(ByVal base As Double, ByVal altura As Double) As Double
    '
    '      Return base * altura
    '  End Function

    '   Function areaCircunferencia(ByVal radio As Double) As Double

    '      Return pi * (radio * radio)
    '   End Function


    'metodos video 2 cambiamos a Public para poder acceder a ellos
    Public Function areaTriangulo(ByVal base As Double, ByVal altura As Double) As Double

        Return (base * altura) / 2

    End Function

    Public Function areaCuadrado(ByVal lado As Double) As Double

        Return lado * lado
    End Function

    Public Function areaRectangulo(ByVal base As Double, ByVal altura As Double) As Double

        Return base * altura
    End Function

    Public Function areaCircunferencia(ByVal radio As Double) As Double

        Return pi * (radio * radio)
    End Function

End Class
