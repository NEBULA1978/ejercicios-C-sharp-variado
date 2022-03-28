Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Aprenderemos a crear una clase y un objeto")

        Dim numero As Integer
        numero = 5

        '3 maneras inicializar abajo
        '   Dim miCalculadora As CalculadoraArea3 ' creamos objeto de una clase,de que tipo es objeto
        ' miCalculadora = New CalculadoraArea3 ' inicializamos objeto
        'Dim miCalculadora As CalculadoraArea3 =  New CalculadoraArea3 lo mismo que lin arrib

        Dim miCalculadora As New CalculadoraArea3

        Dim miCalculadora2 As CalculadoraArea3 ' creamos objeto de una clase,no estainicializado
        '3 maneras inicializar arriba


        Console.WriteLine(miCalculadora.areaCircunferencia(26))
        miCalculadora.m2 = -10
        Console.WriteLine(miCalculadora.m2)

        miCalculadora.m1 = -20
        Console.WriteLine(miCalculadora.m1)

        'dejamos la consola en pausa
        Console.ReadKey()

    End Sub
End Module
