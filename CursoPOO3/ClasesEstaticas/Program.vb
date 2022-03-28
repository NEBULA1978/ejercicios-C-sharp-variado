Imports System

Module Program
    Sub Main(args As String())

        Dim calc1 As New CalculadoraArea3()
        Dim calc2 As New CalculadoraArea3()


        Console.WriteLine(CalculadoraArea3Modulo.areaRectangulo(15, 20))

        Console.WriteLine("Esto es una clase estatica")


        'dejamosconsolaenpausa
        Console.ReadKey()



    End Sub
End Module
