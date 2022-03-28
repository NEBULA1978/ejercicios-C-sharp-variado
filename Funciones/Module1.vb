Module Module1

    Sub Main()
        'pedimos el alto del triangulo
        Console.WriteLine("Introduzca el alto del triangulo...")
        Dim alto As Integer = CInt(Console.ReadLine)

        'pedimos el ancho del triangulo
        Console.WriteLine("Introduzca el ancho del triangulo...")


        Dim ancho As Integer = CInt(Console.ReadLine)

        'creamos la variable miArea y la obtiene llamando a la funcion areaTriangulo
        Dim miArea As Double = areaTriangulo(alto, ancho)

        'Otra forma de concadenar
        ' Console.WriteLine("El area del triangulo es " & miArea) 'concadenamos &
        'Otra forma de concadenar
        Console.WriteLine("El area del triangulo es {0} porque su alto es {1} y su ancho es {2}", miArea, alto, ancho) 'concadenamos &
        ' indice 0 miArea indice 1 alto y  indice2 ancho  yeeep

        'area(alto, ancho) 'llamamos al procedimiento area


        ' Dim miArea As Double = 



        Console.ReadKey() ' para visualizar sino no da tiempo a ver


    End Sub

    Sub area(al As Integer, an As Integer) 'hemos creado el procedimiento 

        Dim area As Double = (al * an) / 2
        Console.WriteLine("El area del triangulo es " & area) 'min 6,30


    End Sub

    Function areaTriangulo(al As Integer, an As Integer) As Double


        Dim area As Double = (al * an) / 2
        Return area

    End Function

End Module
