Imports System

Module Program
    Sub Main(args As String())

        'declaracion de variables
        '  Dim miVariable As String = "Hola Mundo"

        'Mostramos el mensaje por consola
        '  Console.WriteLine(miVariable)
        '   Console.ReadKey()

        'declaracion de Array
        '  Dim miArray() As String = {"Antonio", "Francisco", "Juan"}
        Dim miArray(2) As String
        miArray(0) = "Antonio"
        miArray(1) = "Francisco"
        miArray(2) = "Juan"


        '  ReDim Preserve miArray(1) ' enves de 3 elements le  decimo 2 palñabras especiales


        'Mostramos el valor por consola
        Console.WriteLine(miArray(2))
        Console.Read()


    End Sub
End Module
