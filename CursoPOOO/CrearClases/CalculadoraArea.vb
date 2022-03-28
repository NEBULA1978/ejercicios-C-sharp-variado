Public Class CalculadoraArea
    'Creacion de una clase atributos
    Private pi As Double = 3.1416 'con private creamos cam

    Private _m1 As Double 'variable para la memoria para  guardar dato
    Private _m2 As Double 'variable para la memoria para  guardar dato

    Public Property m1() As Double 'ENCAPSULACION
        Get

            Return _m1

        End Get
        Set(value As Double)
            If value < 0 Then ' condiciono que hallan numeros negativos para medir areas,tienen que ser numero positivos

                Console.WriteLine("EL area indicada no es valida")
            Else
                _m1 = value
            End If

        End Set

    End Property


    'para m2
    Public Property m2() As Double 'ENCAPSULACION
        Get

            Return _m2

        End Get
        Set(value As Double)
            If value < 0 Then ' condiciono que hallan numeros negativos para medir areas,tienen que ser numero positivos

                Console.WriteLine("EL area indicada no es valida")
            Else
                _m2 = value
            End If

        End Set

    End Property

    'METODOS : añado public para la encapsulacion antes sin public era clase
    Public Function areaTriangulo(ByVal base As Double, ByVal altura As Double) As Double

        Return (base * altura)

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
