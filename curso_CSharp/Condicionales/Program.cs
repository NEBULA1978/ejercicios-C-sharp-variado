using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 7;
            //si se cumple el if se sale del bucle no entra else if
            if (valor == 1) // valor es diferente de 10 da falso y no se cumple la condicion
            {
                Console.WriteLine("valor es 1");
            }
            else if(valor == 2)
            {
                Console.WriteLine("valor es 2");
            }
            else if (valor == 3)
            {
                Console.WriteLine("valor es3");
            }
            else 
            {
                Console.WriteLine("No es ni 1 ni 2 ni 3");
            }

            Console.ReadKey();

        /*
            int valor = 10;
            //si se cumple el if se sale del bucle no entra else if
            if (valor < 9) // valor es diferente de 10 da falso y no se cumple la condicion
            {
                Console.WriteLine("La condicion se cumple");
            }
            else if (valor < 10)
            {
                Console.WriteLine("valor es menor que 10");
            }
            else if (valor > 10)
            {
                Console.WriteLine("valor es mayor que 10");
            }
            else
            {
                Console.WriteLine("No que da otra mas que sea  10");
            }

            Console.ReadKey();
        */
        }
    }
}
