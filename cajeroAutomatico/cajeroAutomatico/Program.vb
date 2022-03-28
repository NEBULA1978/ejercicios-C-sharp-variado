Imports System

Module Programu
    Sub Main()


        'mostramos el menu principal
        Console.WriteLine("Bienvenido.")
        Console.WriteLine("--------------------------------------------------------------------------")
        Console.WriteLine() ' espacio en blanco para no se unan todas la letras
        Console.WriteLine("Menu Principal")
        Console.WriteLine("    1. Sonsulta de saldo.")
        Console.WriteLine("    2. Ingresar.")
        Console.WriteLine("    3. Retirar.")
        Console.WriteLine("    4. Salir.")

        'quedamos a la espera
        'Console.ReadLine()
        ' Dim opcionUsuario As String = Console.ReadLine 'guardamos opcion ha elegido el usuario
        Dim opcionUsuario As Integer = CInt(Console.ReadLine) 'convierte a entero resultado introduzca en la consola


        Select Case opcionUsuario
            Case Case1
                Console.WriteLine("Ocion 1")
                Console.ReadLine()
            Case Case2
                Console.WriteLine("Ocion 2")
            Case Case3
                Console.WriteLine("Opcion 3")
            Case Case4
                Console.WriteLine("Selecciono salir")
            Case Else
                Console.WriteLine("Ocion no disponible")



        End Select



    End Sub
End Module
