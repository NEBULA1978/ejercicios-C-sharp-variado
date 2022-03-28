Module Module1

    Sub Main()

        encabezado("Bienvenidos a todos.....")

        'pedimos el primer factor
        Console.Write("Introduzca el primer factor")
        Dim factor1 As Integer = CInt(Console.ReadLine)

        'pedimos el segundo factor
        Console.Write("Introduzca el segundo factor")
        Dim factor2 As Integer = CInt(Console.ReadLine)

        encabezado("Resultado de la multiplicacion....")
        multiplica(factor1, factor2)

    End Sub

    Private Sub multiplica(f1 As Integer, f2 As Integer)

        Dim producto As Integer = f1 * f2
        Console.WriteLine(producto)

        Console.ReadKey() ' para nos detiempo a pulsarr una tecla

    End Sub

    Private Sub encabezado(texto As String) ' nuesto procedimiento necesitamos introducir 1parametro

        Console.WriteLine() 'salto linea
        Console.WriteLine("-----------------------------------------------------") 'separador
        Console.WriteLine(texto) ' un cartel
        Console.WriteLine("-----------------------------------------------------") 'separador
        Console.WriteLine() 'salto de linea


    End Sub

End Module
