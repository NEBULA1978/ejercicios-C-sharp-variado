Module Module1

    Sub Main()

        'Pedimos al usuario un numero
        Console.WriteLine("Introduzca un numero....")
        'almacena numero introducido en variable numero
        Dim numero As Integer = CInt(Console.ReadLine) 'almacena lo introducido por el usuario

        Dim resultado As Integer = doble(numero)

        Console.WriteLine() 'salto de linea
        Console.WriteLine("El doble de {0} es {1}", numero, resultado)

        Console.ReadKey()
    End Sub


    '   Function doble(ByVal num As Integer) As Integer esta impliicto nohece falta poner
    ' Function doble(ByRef num As Integer) As Integer '  da el doble de 20 es 20
    Function doble(ByVal num As Integer) As Integer
        num *= 2 'el resultado numero lo multiplica por 2
        ' num = num * 2  lo mismo arriba
        Return num

    End Function

End Module
