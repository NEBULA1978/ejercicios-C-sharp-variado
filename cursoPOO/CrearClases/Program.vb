Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("Aprenderemos a crear una clase y un  objeto...")


        Dim miCalculadora As New CalculadoraArea



        Console.WriteLine(miCalculadora.areaCircunferencia(26))

        miCalculadora.m2 = -10
        Console.WriteLine(miCalculadora.m2)

        miCalculadora.m1 = -20
        Console.WriteLine(miCalculadora.m1)



        ' dejamos la consola en pausa
        Console.ReadKey()


    End Sub
End Module
