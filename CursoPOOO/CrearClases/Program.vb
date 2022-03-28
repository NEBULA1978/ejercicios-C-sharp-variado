Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Aprenderemos a crear una clase y un objeto...")

        Dim numero As Integer

        ' Dim miCalculadora As CalculadoraArea
        '  Dim miCalculadora2 As CalculadoraArea 'hemos declarado el objeto pero no lo hemos inicializado
        ' miCalculadora = New CalculadoraArea 'hemos inicilizado el objeto

        Dim miCalculadora As New CalculadoraArea 'en la misma linea o como arriba


        Console.WriteLine(miCalculadora.areaCircunferencia(26))

        miCalculadora.m2 = 10 * 10
        Console.WriteLine(miCalculadora.m2)

        miCalculadora.m1 = 20 * 10
        Console.WriteLine(miCalculadora.m1)

        'dejamos la consola en pausa
        Console.ReadKey()

    End Sub
End Module
