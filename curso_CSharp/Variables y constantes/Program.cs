using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_y_constantes
{
    class Program
    {
        static void Main(string[] args)
        {//flujo de ejecucion de arriba a abajo

            byte num1 = 10;
            short num2 = 200;
            int num3 = 3000;
           
            long num4 = 40000;//si pongo muchos 0 me sale error excepcion 

            // num3 = 50 * 5;//puedo realizar operaciones matematicas
            // num3 = num2;//puedo intercambiar valores de variables conversion implicita
            num3 = Convert.ToInt32(num4);
            //num3 = Convert.ToInt32(num4);//si pongo muchos 0 me sale error excepcion 
            Console.WriteLine(num3);

            //variables de tipo numerica (con decimales)
            float num5 = 10.123456789123456789123456789f;//sufijo f para flotantes, para el peso de una persona
            double num6 = 10.123456789123456789123456789;//numeros ficos de fisica
            decimal num7 = 10.123456789123456789123456789m;//sufijo m al final decimales en economia

            //variables tipo texto
            char caracter = 'a';
            string caracteres = "10";//onemos comillas para no se confunda con string antonio linea anterior

          //string nombre = Console.ReadLine();
            //Console.WriteLine(valor * valor);da error no pueden mezclar datos sin convertir

            //variables de tipo boleana
            bool feliz = false;


            // Console.ReadLine();//para introducir datos por el usuario,siempre nos devuelve un texto

            int valor = Convert.ToInt32(Console.ReadLine()); //todo lo que el usuario introduzca sera convertido a dato numerico
            Console.WriteLine(valor * valor);

            // Console.WriteLine(num1 + num1);//podemos hacer operaciones matematicas
            // Console.WriteLine(caracteres + caracteres);//concadena los caracteres no los suma como en num1,etc

            //dejamos a la consola a la espera
            Console.ReadKey();

        }
    }
}


