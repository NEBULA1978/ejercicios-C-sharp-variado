Imports System

Module Program
    Sub Main(args As String())

        'video 4 herencia
        Dim persona1 As New Personas() 'creamos un objeto de la clase persona :siempre que sean metodos o constructores ()
        Dim estudiante1 As New Alumno() 'creamos un objeto de la clase Alumno
        Dim trabajador1 As New empleado() ''creamos un objeto de la clase empleado

        trabajador1.Hablar()
        estudiante1.Hablar()
        trabajador1.Hablar()



        'video 3

        '   Dim per1 As New Personas()
        '   Console.WriteLine(per1.Nombre)
        '  Console.WriteLine(per1.Edad)

        '  Dim per2 As New Personas("Antonio", 35)
        '   Console.WriteLine(per2.Nombre)
        '   Console.WriteLine(per2.Edad)

        '  Dim per3 As New Personas(23) ' Declaramos otra instancia de una clase
        ' Console.WriteLine(per3.Nombre)
        '   Console.WriteLine(per3.Edad)
        'video 3




        'dejamos consola en pausa
        Console.ReadKey()


    End Sub
End Module
