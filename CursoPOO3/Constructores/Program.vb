Imports System

Module Program
    Sub Main(args As String())

        'creamos un objeto de cada clase persona
        Dim persona1 As New Personas()

        'creamos un objeto de cada clase alumno
        Dim estudiante1 As New Alumno()

        'creamos un objeto de cada clase empleado
        Dim trabajador1 As New Empleado("Jose", 35, 1200)

        Console.WriteLine(persona1.Nombre)
        Console.WriteLine(estudiante1.Nombre)
        Console.WriteLine(trabajador1.Nombre)



        '   persona1.Hablar()
        ' estudiante1.Hablar()
        '  trabajador1.Hablar()



        'dejamos consola en pausa
        Console.ReadKey()


        ' ejem anterio vid 3
        '   Dim per1 As New Personas()
        '   Console.WriteLine(per1.Nombre)
        '  Console.WriteLine(per1.Edad)


        '  Dim per2 As New Personas("Antonio", 35)
        ' Console.WriteLine(per2.Nombre)
        ' Console.WriteLine(per2.Edad)

        '  Dim per3 As New Personas(23)
        '  Console.WriteLine(per3.Nombre)
        '  Console.WriteLine(per3.Edad)





    End Sub
End Module
