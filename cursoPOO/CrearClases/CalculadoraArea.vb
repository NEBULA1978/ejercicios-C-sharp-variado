Public Class CalculadoraArea
    Private pi As Double = 3.1416

    Private _m1 As Double
    Public m2 As Double

    Public Property m1() As Double 'creamos una propiedad m1 ,obtener dato Get y asignar un dato es el Set

        Get
            Return _m1
        End Get

        Set(value As Double)
            If value < 0 Then
                Console.WriteLine("El area indicada no es valida.")
            Else
                _m1 = value


            End If


        End Set

    End Property

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
