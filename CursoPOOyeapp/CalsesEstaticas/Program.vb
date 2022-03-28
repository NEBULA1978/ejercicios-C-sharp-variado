Imports System

Module Program
    Sub Main(args As String())

        'creamos 2 objetos
        Dim calc1 As New CalculadoraArea()
        Dim calc2 As New CalculadoraArea()


        ' Console.WriteLine(calc1.areaTriangulo(10, 10)) no hace falta llamar al objeto
        Console.WriteLine(CalculadoraAreaModulo.areaRectangulo(15, 20)) ' no hace falta llamar al objeto
        '  Hemos      creado una clase estatica en visual basic se llaman modulos

        Console.WriteLine("Esto es una clase eestatica")

        'dejamos consola en pausa
        Console.ReadKey()

        'Console.WriteLine("Hello World!")
    End Sub
End Module
