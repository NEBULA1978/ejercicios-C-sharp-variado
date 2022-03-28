Imports System

Module Program
    Sub Main(args As String())

        Dim trabajador1 As New Empleado("Juan", 39)
        Dim trabajador2 As New Empleado("Luis", 25)

        Console.WriteLine(trabajador1.Nombre)
        Console.WriteLine(trabajador1.Edad)
        Console.WriteLine(trabajador1.Salario)
        Console.WriteLine(Empleado.Recuento)

        Console.WriteLine() 'separador para nose junten objetos

        Console.WriteLine(trabajador2.Nombre)
        Console.WriteLine(trabajador2.Edad)
        Console.WriteLine(trabajador2.Salario)
        Console.WriteLine(Empleado.Recuento)
        Console.WriteLine("---------------------------------------------------------")
        trabajador1.Recuento = 50 'variable de la propia clase

        Console.WriteLine("---------------------------------------------------------")


        Console.WriteLine(trabajador1.Nombre)
        Console.WriteLine(trabajador1.Edad)
        Console.WriteLine(trabajador1.Salario)
        Console.WriteLine(Empleado.Recuento)

        Console.WriteLine() 'separador para nose junten objetos

        Console.WriteLine(trabajador2.Nombre)
        Console.WriteLine(trabajador2.Edad)
        Console.WriteLine(trabajador2.Salario)
        Console.WriteLine(Empleado.Recuento)

        'dejamos la consola en espera
        Console.ReadKey()


    End Sub
End Module
