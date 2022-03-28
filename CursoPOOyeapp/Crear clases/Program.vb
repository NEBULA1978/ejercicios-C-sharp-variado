Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Aprenderemos a crear una clase y un objeto")

        Dim numero As Integer 'que warde espacio en memoria variable numero

        'una forma de hacer
        Dim miCalculadora As CalculadoraArea 'creamos objeto
        miCalculadora = New CalculadoraArea 'inicializamos sino da error

        'otra forma de hacer lo de arriba
        '   Dim miCalculadora As CalculadoraArea =New CalculadoraArea 'inicializamos sino da error'(creamos objeto

        'otra forma de hacer lo de arriba
        ' Dim miCalculadora As CalculadoraArea As New calculadoraArea


        Console.WriteLine(miCalculadora.areaCircunferencia(26))

        miCalculadora.m2 = -10
        Console.WriteLine(miCalculadora.m2)

        miCalculadora.m1 = -20
        Console.WriteLine(miCalculadora.m1)

        'dejamos la consola a la espera
        Console.ReadKey()

    End Sub
End Module
