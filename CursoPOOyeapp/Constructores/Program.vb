Imports System

Module Program
    Sub Main(args As String())
        'video 3 constructores
        ' Dim per1 As New Personas() 'creamos y delaramos e inicializamos objeto persona
        '  Console.WriteLine(per1.Nombre)
        '  Console.WriteLine(per1.Edad)


        'Persona2
        '  Dim per2 As New Personas("Antoni", 35) 'creamos y delaramos e inicializamos objeto persona
        ' Console.WriteLine(per2.Nombre)
        ' Console.WriteLine(per2.Edad)

        'Persona3
        ' Dim per3 As New Personas(23) 'creamos y delaramos e inicializamos objeto persona
        '  Console.WriteLine(per3.Nombre)
        ' Console.WriteLine(per3.Edad)
        '

        ' Console.WriteLine("Hello World!")

        'dejamos la consola a la espera
        ' Console.ReadKey()


        'VIDEO 4 HERENCIA



        'creamos objeto de la clase Persona e inicializamos todos en una linea
        Dim persona1 As New Personas() 'siempre sean metodos o constructores poner parentesis
        'creamos un objeto de cada clase que tenemos:  1º objeto1 :persona1 de la clase Personas


        'creamos objeto de la clase Alumno e inicializamos todos en una linea
        Dim estudiante1 As New Alumno() 'siempre sean metodos o constructores poner parentesis
        'creamos un objeto de cada clase que tenemos:  1º objeto1 :estudiante1 de la clase Alumno

        'creamos objeto de la clase Empleado  e inicializamos todos en una linea
        Dim trabajador1 As New Empleado("Jose", 35, 1200) 'siempre sean metodos o constructores poner parentesis: introduciomos parametros del constructor creado en su clase
        'creamos un objeto de cada clase que tenemos:  1º objeto1 :trabajador1 de la clase Empleado

        Console.WriteLine(persona1.Nombre)
        Console.WriteLine(estudiante1.Nombre)
        Console.WriteLine(trabajador1.Nombre)

        Console.WriteLine(persona1.Edad)
        Console.WriteLine(estudiante1.Edad)
        Console.WriteLine(trabajador1.Edad)


        persona1.Hablar()
        estudiante1.Hablar()
        trabajador1.Hablar()



        'dejamos la consola a la espera
        Console.ReadKey()

    End Sub
End Module
