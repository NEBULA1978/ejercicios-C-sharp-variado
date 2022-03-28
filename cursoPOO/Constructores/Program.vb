Imports System

Module Program
    Sub Main(args As String())

        Dim per1 As New Personas()
        Console.WriteLine(per1.Nombre)
        Console.WriteLine(per1.Edad)

        Dim per2 As New Personas("Antonio", 35)
        Console.WriteLine(per2.Nombre)
        Console.WriteLine(per2.Edad)

        'creo tercera persona
        Dim per3 As New Personas(23)
        Console.WriteLine(per3.Nombre)
        Console.WriteLine(per3.Edad)

        'Dejamos la consola en pausa
        Console.ReadKey()


    End Sub
End Module
