Public Class CalculadoraArea3

    'creamos campos de clase, no se pude acceder sino es de la clase privado
    Private pi As Double = 3.1416

    Private _m1 As Double
    Public m2 As Double

    'creamos propiedad con codicional no numeros negativos
    Public Property m1() As Double
        Get ' obtener el dato
            Return _m1
        End Get
        Set(value As Double) 'asignar un dato
            If value < 0 Then
                Console.WriteLine("El area indicada no es valida.")
            Else
                _m1 = value
            End If

        End Set
    End Property

    'Metodos de una clase
    Public Function areaTriangulo(ByVal base As Double, ByVal altura As Double) As Double

        Return (base * altura) / 2


    End Function

    Public Function areaTriangulo(ByVal lado As Double) As Double

        Return lado * lado

    End Function

    Public Function areaRectangulo(ByVal base As Double, ByVal altura As Double) As Double

        Return base * altura

    End Function

    Public Function areaCircunferencia(ByVal radio As Double) As Double

        Return pi * (radio * radio)

    End Function

End Class
