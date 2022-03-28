Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Aprenderemos a usar una clase y un objeto")

        Dim numero As Integer
        '   numero = 5
        ' Dim miCalculadora As CalculadoraArea  ' hemos creado un objeto de un molde
        '  miCalculadora = New CalculadoraArea  'inicializamos el objeto sino no va

        'asi es lo mimo que arriba pero todo en una linea
        '   Dim miCalculadora As CalculadoraArea =  New CalculadoraArea lo mismo que arriba

        Dim miCalculadora As New CalculadoraArea  'otra forma igual arriba mas abreviada

        Console.WriteLine(miCalculadora.areaCircunferencia(26))

        miCalculadora.m2 = -10
        Console.WriteLine(miCalculadora.m2)

        miCalculadora.m1 = -20
        Console.WriteLine(miCalculadora.m1)


        'dejamos la consola en pausa 
        Console.ReadKey()




    End Sub
End Module
