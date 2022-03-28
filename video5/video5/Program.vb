Imports System

Module Program
    Sub Main()
        Console.WriteLine("Bienvenidos")
        Console.WriteLine("Introduzca el primer sumando...")

        'obtenemos el dato introducido por el usario
        Dim sumando1 As Integer
        'sumando1 = Console.ReadLine 'valor sumando1 lo que introduzca usuario
        sumando1 = CInt(Console.ReadLine) ' convierte a entero el valor introducido usuario


        Console.WriteLine("Introduzca el segundo sumando...")

        Dim sumando2 As Integer = Console.ReadLine 'valor sumando2 lo que introduzca usuario
        sumando2 = CInt(Console.ReadLine) ' convierte a entero el valor introducido usuario


        Console.WriteLine("El resultado es  : " & sumando1 + sumando2)
        ' Console.WriteLine("El resultado es  : " & CInt(sumando1) + (sumando2)) 'CInt converion datos texto a numerico
        'CStr conertis dato numerico a texto
        'CDbl converit a doble
        Console.ReadKey() 'que espere sino se cierra consola




    End Sub
End Module
