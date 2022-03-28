Public Class CalculadoraAreaULTIM
    'ATRIBUTOS
    Dim pi As Double = 3.1416
    Dim m1 As Double
    Dim m2 As Double

    'MEtodos QUE PUEDE Y NO PUEDE HACER
    Function AreaTriangulo(ByVal base As Double, ByVal altura As Double) As Double

        Return (base * altura) / 2

    End Function

    Function areaCuadrado(ByVal lado As Double) As Double

        Return lado * lado

    End Function

    Function areaRectangulo(ByVal base As Double, ByVal altura As Double) As Double

        Return base * altura

    End Function

    Function areaCircumferencia(ByVal radio As Double) As Double


    End Function

End Class
