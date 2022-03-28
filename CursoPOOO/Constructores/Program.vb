Imports System

Module Program
    Sub Main(args As String())
        'video 4 herencia
        Dim persona1 As New Personas() 'creamos un onjeto clase persona
        Dim estudiante1 As New Alumno() 'creamos un onjeto clase alumno
        Dim trabajador1 As New Empleado("Jose", 35, 1200) 'creamos un onjeto clase empleado



        Console.WriteLine(persona1.Nombre)
        Console.WriteLine(estudiante1.Nombre)
        Console.WriteLine(trabajador1.Nombre)


        '  persona1.Hablar()
        ' estudiante1.Hablar()
        '  trabajador1.Hablar()















        'Video 3 constructor hacia abajo

        '   Dim per1 As New Personas() 'creamos objetp per1 y lo inicializamos
        '  Console.WriteLine(per1.Nombre)
        ' Console.WriteLine(per1.Edad)
        '

        'creamos persona2
        ' Dim per2 As New Personas("Antonio", 35) 'creamos objet per1 y lo inicializamos
        'Console.WriteLine(per2.Nombre)
        '   Console.WriteLine(per2.Edad)

        'creamos persona3
        '   Dim per3 As New Personas(23) 'creamos objet per1 y lo inicializamos
        '  Console.WriteLine(per3.Nombre)
        ' Console.WriteLine(per3.Edad)

        'dejamos lac consola en pausa
        Console.ReadKey()

    End Sub
End Module
