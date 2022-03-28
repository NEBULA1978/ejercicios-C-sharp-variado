Module Module1

    Sub Main()

        Dim dividendo As Integer
        Dim divisor As Integer


        Dim repite As Boolean = True
        Do While repite

            Try 'intenta

                'introducir el dividendo
                Console.WriteLine("Introduzca el dividendo...")

                dividendo = Console.ReadLine()

                Console.Write("Introduzca el divisor...")

                divisor = Console.ReadLine()
                repite = False

            Catch ex As System.OverflowException ' ex es un objeto y tiene sus propiedades para POO
                Console.WriteLine("ex.Message")

            Catch ex As System.InvalidCastException
                Console.WriteLine(ex.Message)

            Finally
                Console.WriteLine("Estas lineas se ejcutan siempre") 'cerrar conexiones tanto si hay errores como sino

            End Try ' repite el bucle hasta a falso
            'System.OverflowExcepcion     ERROR  por desbordamiento
            'System.InvalidCastException  ERROR caracter a numero


        Loop


        Console.WriteLine("El cociente de lad division es : {0}", dividir(dividendo, divisor))

        Console.ReadKey() ' para pode ver sino tan rapido que no se ve

    End Sub


    Function dividir(ByVal num1 As Integer, ByVal num2 As Integer) As Double

        Dim resultado As Double
        resultado = num1 / num2

        Return resultado

    End Function

End Module
