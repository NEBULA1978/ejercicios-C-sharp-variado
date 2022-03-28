Imports System

Module Program
    Sub Main()
        '   Dim valor As Integer = 0
        'vid 11 yeaa
        '    Do ' Until valor = 0 'tiene que hacer hasta valor sea 0
        'Do ' Until valor = 50000 ' hasta que o mientras que valor llega a 50000 sale y continua programa  until hasta   while mientras
        '   Console.WriteLine(valor)
        '   valor += 1
        '   '  If valor = 50000 Then cuando llega a 50000 sale y continua programa
        '   Exit Do
        ' End If

        '  Loop Until valor = 0 '  aqui nos aseguramos de quealmenos 1vez seejecutara yeeee arriba noooop
        ' Loop ' While valor = 0 'Nos aseguramos de que al menos se ejecute una vez



        'vid9 bucle for
        ' Dim i As Integer se omite aqui y se pone abajo sin Dim
        '  For i As Integer = 0 To 10 'escribimos y pulsamos intro se complete el for : i = 0  ejecuta nºveces de 0 hasta 10(To 10)
        '   For i As Integer = 0 To 10 Step -1
        '      For i As Integer = 10 To 0 Step -1 ' si quermos que valla de -1 en -1 Step-1 yeaaa
        '  Console.WriteLine("El valor de i es : " & i) ' concadenamos con &

        ' Next final FOR



        'vid 8,9 borramos y hacemos un array de tarjetas 
        '  Dim tarjetaValida As String = "123456"
        '  Dim pinValido As String = "0000"


        'ARRAYS DE TARJETAS
        Dim tarjetas(2, 2) As String ' para hacer tabla 3*3

        'Ingresar los datos de la 1ºtarjeta
        tarjetas(0, 0) = "000000"
        tarjetas(0, 1) = "0000"
        tarjetas(0, 2) = "500"

        'Ingresar los datos de la 2ºtarjeta
        tarjetas(1, 0) = "111111"
        tarjetas(1, 1) = "1111"
        tarjetas(1, 2) = "1000"

        'Ingresar los datos de la 3ºtarjeta
        tarjetas(2, 0) = "222222"
        tarjetas(2, 1) = "2222"
        tarjetas(2, 2) = "1500"

        'pedimos al usuario que introduzca los datos de la tarjeta
        Console.Write("Por favor introduzca su tarjeta : ") 'introduce datos
        Dim tarjetaIntroducida As String = Console.ReadLine 'guarda los datos
        Console.WriteLine("--------------------------------------------------------------------") 'separador
        Console.Write("Introduzca numero PIN :") 'introduce datos
        Dim PINintroducido As String = Console.ReadLine 'guarda los datos



        '  Dim encontrada As Boolean = False quitamos de aqui y metemos abajo en FOR
        '  Dim saldo As Decimal quitamos de aqui y metemos abajo en FOR
        'vid 9 bucle for de arrays varias tarjetas
        Dim encontrada As Boolean = False
        Dim saldo As Decimal
        For i = 0 To 2
            If tarjetaIntroducida = tarjetas(i, 0) And PINintroducido = tarjetas(i, 1) Then
                encontrada = True
                saldo = CDec(tarjetas(i, 2)) ' convierteme a decimal CDec
            End If

        Next


        'compreobar si se cumplen nom tarj y contraseña
        '   If Not tarjetaIntroducida = tarjetaValida And PINintroducido = pinValido Then 'operadores logicos NOT las miega si es 1 da 0 y se cumpla la 2º condicion y la primera al contrario
        'If tarjetaIntroducida = tarjetaValida And PINintroducido = pinValido Then 'operadores logicos AND las 2 verdaderas se cumpla condicion : quito vid9 FOR
        If encontrada = True Then
            'MOstramos la variable saldo e inicializamos
            '  Dim saldo As Decimal = 500.5 en vid 9 lo booro tengo variable arriba en ARRAY
            Dim ingreso As Decimal
            Dim retirar As Decimal
            Dim opcionUsuario As Integer 'declaramos

            'vid 11
            Do


                'Mostramos el menu Principal

                Console.Clear() 'limpiamos consola
                Console.WriteLine() ' salto de linea
                Console.WriteLine("Bienvenido")
                Console.WriteLine("--------------------------------------------------------------------")
                Console.WriteLine()
                Console.WriteLine("Menu Principal")
                Console.WriteLine("    1. Consulta de saldo.")
                Console.WriteLine("    2. Ingresar")
                Console.WriteLine("    3. Retirar")
                Console.WriteLine("    4. Salir")


                opcionUsuario = CInt(Console.ReadLine()) 'damos valor y Quedamos a la espera no se cierre rapida la consola y podamos ver


                'SEGUNDA FORMA CON CASE
                Select Case opcionUsuario
                    Case 1 'Case 1,2,3 :si la opcion usuario es caso 1 ,2 , 3 entonces caso1 ; form abreviada Case 1 To 3 :tambien valida
                        Console.WriteLine() ' linea en blanco
                        Console.WriteLine("--------------------------------------------------------------------")
                        Console.WriteLine("Su saldo actual es de : " & saldo & "Euros") 'concadenamos con & 
                        Console.WriteLine("--------------------------------------------------------------------")
                        Console.ReadLine()


                    Case 2
                        Console.WriteLine() ' linea en blanco
                        Console.WriteLine("--------------------------------------------------------------------")
                        Console.Write("Introduzca la cantidad a ingreasar : ")
                        ingreso = CDec(Console.ReadLine) 'lee el valor introducido por el usuario falta guardarlo ponemos delante ingreso =
                        Console.WriteLine("--------------------------------------------------------------------")
                        saldo = saldo + ingreso
                        Console.ReadLine()

                    Case 3
                        Console.WriteLine() ' linea en blanco
                        Console.WriteLine("--------------------------------------------------------------------")
                        Console.Write("Introduzca la cantidad a retirar :")
                        retirar = CDec(Console.ReadLine) 'lee el valor introducido por el usuario falta guardarlo ponemos delante retirar =
                        Console.WriteLine("--------------------------------------------------------------------")

                        'condicion para que no retire mas saldo del que tiene
                        If retirar > saldo Then
                            Console.WriteLine("El saldo de su tarjetaes inferior a la cantidad a retirar. Indique una cantidad distinta")

                        Else
                            saldo = saldo - retirar

                        End If
                        Console.ReadLine()

                    Case 4
                        Console.WriteLine() ' linea en blaco
                        Console.WriteLine("--------------------------------------------------------------------") 'separador
                        Console.WriteLine("Muchas gracias por su visita. Vuelva pronto")
                        Console.WriteLine("--------------------------------------------------------------------")
                        Console.ReadLine()

                    Case Else ' Es opcional
                        Console.WriteLine("--------------------------------------------------------------------")
                        Console.WriteLine("Opcion no disponible")
                        Console.WriteLine("--------------------------------------------------------------------")
                        Console.ReadLine()

                End Select

            Loop Until opcionUsuario = 4 'termina el bucle Do , cuando pulse 4 sale
            'Loop while opcionUsuario <> 4 mientras opcionUsuario sea distintode 4 sale tambien






        Else
            Console.WriteLine("--------------------------------------------------------------------") 'separador
            Console.WriteLine("Numero de tarjeta o numero PIN incorrectos")
            Console.ReadLine() ' de tiempo a leer

        End If






        'PRIMERA FORMA MENU CON IF ELSEIF Y ELSE
        '  If opcionUsuario = 1 Then 'si opcion usuario es igual a 1 entonces:
        '  Console.WriteLine("Opcion 1")
        '    Console.ReadLine()



        '  ElseIf opcionUsuario = 2 Then 'si opcion usuario no es igual a 2 entonces abajo ejecuta :
        '  Console.WriteLine("Opcion 2")
        ' Console.ReadLine()

        '  ElseIf opcionUsuario = 3 Then 'si opcion usuario no es igual a 3 entonces abajo ejecuta :
        'Console.WriteLine("Opcion 3")
        'Console.ReadLine()


        ' ElseIf opcionUsuario = 4 Then 'si opcion usuario no es igual a 2 entonces abajo ejecuta :
        'Console.WriteLine("Seleccion salir")
        'Console.ReadLine()

        ' End If
        '---------------------------------------------------------------------------------------'


    End Sub
End Module
