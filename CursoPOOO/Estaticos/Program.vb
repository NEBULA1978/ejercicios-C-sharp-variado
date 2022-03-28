Imports System

Module Program
    Sub Main(args As String())

        Dim trabajador1 As New EMpleada("Juan", 39)
        Dim trabajador2 As New EMpleada("Luis", 25)
        Dim trabajador3 As New EMpleada("Pepe", 39)
        Dim trabajador4 As New EMpleada("Fernando", 25)
        Dim trabajador5 As New EMpleada("Rodri", 25)
        Dim trabajador6 As New EMpleada("Reche", 25)

        Console.WriteLine(trabajador1.Nombre)
        Console.WriteLine(trabajador1.Edad)
        Console.WriteLine(trabajador1.Salario)
        Console.WriteLine(EMpleada.Recuento)
        Console.WriteLine() 'Separador de los objetos
        Console.WriteLine(trabajador2.Nombre)
        Console.WriteLine(trabajador2.Edad)
        Console.WriteLine(trabajador2.Salario)
        Console.WriteLine(EMpleada.Recuento)
        Console.WriteLine("---------------------------------------------------------------")
        EMpleada.Recuento = 50
        Console.WriteLine("---------------------------------------------------------------")
        Console.WriteLine(trabajador3.Nombre)
        Console.WriteLine(trabajador3.Edad)
        Console.WriteLine(trabajador3.Salario)
        Console.WriteLine(EMpleada.Recuento)
        Console.WriteLine() 'Separador de los objetos
        Console.WriteLine(trabajador4.Nombre)
        Console.WriteLine(trabajador4.Edad)
        Console.WriteLine(trabajador4.Salario)
        Console.WriteLine(EMpleada.Recuento)
        Console.WriteLine("---------------------------------------------------------------")
        EMpleada.Recuento = 50
        Console.WriteLine("---------------------------------------------------------------")
        Console.WriteLine(trabajador5.Nombre)
        Console.WriteLine(trabajador5.Edad)
        Console.WriteLine(trabajador5.Salario)
        Console.WriteLine(EMpleada.Recuento)
        Console.WriteLine() 'Separador de los objetos
        Console.WriteLine(trabajador6.Nombre)
        Console.WriteLine(trabajador6.Edad)
        Console.WriteLine(trabajador6.Salario)
        Console.WriteLine(EMpleada.Recuento)


        Console.ReadKey()
        'Console.WriteLine("Hello World!")
    End Sub
End Module
