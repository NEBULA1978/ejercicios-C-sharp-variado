Imports System

Module Program
    Sub Main()

        Dim resultado As Double = promedio(7, 4.6, 9) ' si metemos 2 parametros ejecuta  2ºparametro de dos
        Console.WriteLine(resultado)
        Console.ReadKey()


    End Sub

    Function promedio(ByVal num1 As Integer, ByVal num2 As Integer) As Double

        Return (num1 + num2) / 2


    End Function

    Function promedio(ByVal num1 As Integer, ByVal num2 As Integer, ByVal num3 As Integer) As Double

        Return (num1 + num2 + num3) / 3
    End Function

    Function promedio(ByVal num1 As Double, ByVal num2 As Integer, ByVal num3 As Double) As Integer

        Return (num1 + num2 + num3) / 3
    End Function

    Function promedio(ByVal num1 As Integer, ByVal num2 As Double, ByVal num3 As Integer) As Double

        Return (num1 + num2 + num3) / 3
    End Function

End Module
