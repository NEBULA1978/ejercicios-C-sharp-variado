using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //muestra como usar swicth con otros tipos
            //aparte de in

            //Variables que usaremos con el switch

            bool booleana = false;
            char caracter = 'a';
            string cadena = "Priviet";

            //con bool
            switch (booleana)
            {
                case true:
                    Console.WriteLine("La variable tiene true");
                    break;
                case false:
                    Console.WriteLine("La variable tiene false");
                    break;


             
            }

            Console.ReadKey();

        }
    }
}
