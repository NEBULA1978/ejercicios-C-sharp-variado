Imports System

Module Programu
    Sub Main()
        Dim tarjetaValida As String = "123456"
        Dim pinValido As String = "0000"

        Console.Write("Por favor introduzca su tarjeta : ")
        Dim tarjetaIntroducida As String = Console.Read
        Console.WriteLine("--------------------------------------------------------------------------") ' un separador delinea
        Console.Write("Introduzca el numero PIN : ")
        Dim PINintroducido As String = Console.ReadLine ' leemos pin introducido

        If tarjetaIntroducida = tarjetaValida And PINintroducido = pinValido Then 'operador logico AND las 2verdades se cumpla

            'Creamos la variable saldo e inicializamos
            Dim saldo As Decimal = 500.5 ' para decimales
            Dim ingreso As Decimal
            Dim retirada As Decimal

            'mostramos el menu principal
            Console.WriteLine("Bienvenido.")
            Console.WriteLine("--------------------------------------------------------------------------")
            Console.WriteLine() ' espacio en blanco para no se unan todas la letras
            Console.WriteLine("Menu Principal")
            Console.WriteLine("    1. Consulta de saldo.")
            Console.WriteLine("    2. Ingresar.")
            Console.WriteLine("    3. Retirar.")
            Console.WriteLine("    4. Salir.")

            'quedamos a la espera
            'Console.ReadLine()
            ' Dim opcionUsuario As String = Console.ReadLine 'guardamos opcion ha elegido el usuario
            Dim opcionUsuario As Integer = CInt(Console.ReadLine) 'convierte a entero resultado introduzca en la consola


            Select Case opcionUsuario
          '  Case 1 To 3 ' forma abreviada de Case1, 2, 3

                Case 1  ' tambien podemos añadir mas Case: Case1, 2, 3
                    Console.WriteLine()
                    Console.WriteLine("--------------------------------------------------------------------------")
                    Console.WriteLine("Su saldo actual es de : " & saldo & "Euros") 'concadenamos
                    Console.WriteLine("--------------------------------------------------------------------------")
                    Console.ReadLine()
                Case 2
                    Console.WriteLine()
                    Console.WriteLine("--------------------------------------------------------------------------")
                    Console.Write("Introduzca la cantiadad a ingresar: ") 'concadenamos
                    ingreso = Console.ReadLine()
                    Console.WriteLine("--------------------------------------------------------------------------")
                    Console.ReadLine()
                Case 3
                    Console.WriteLine()
                    Console.WriteLine("--------------------------------------------------------------------------")
                    Console.Write("Introduzca la cantiadad a retirar: ") 'concadenamos
                    retirada = Console.ReadLine() 'le valor introuit per ususari
                    Console.WriteLine("--------------------------------------------------------------------------")
                    Console.ReadLine()
                Case 4
                    Console.WriteLine()
                    Console.WriteLine("--------------------------------------------------------------------------")
                    Console.WriteLine("Muchas gracias por su visita. Vuelva pronto")
                    Console.WriteLine("--------------------------------------------------------------------------")
                    Console.ReadLine()

                Case Else
                    Console.WriteLine("--------------------------------------------------------------------------")
                    Console.WriteLine("Ocion no disponible")
                    Console.WriteLine("--------------------------------------------------------------------------")
                    Console.ReadLine()



                    Else
                    Console.WriteLine("--------------------------------------------------------------------------") ' un separador delinea
                    Console.WriteLine("Numero de tarjeta o numero PIN incorrectos")
                    Console.ReadLine() ' para nos de tiempo a leer enconsola

            End Select

        End If






    End Sub
End Module
