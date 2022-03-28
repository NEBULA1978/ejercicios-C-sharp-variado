using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitchYeaa
{
    class Program
    {
        static void Main(string[] args)
        {
            //muestra como usar swicth con otros tipos
            //aparte de in

            //Variables que usaremos con el switch

            bool booleana = false;
          //  char caracter = 'w';
            string cadena = "Priviet";

            //con bool
       //     switch (booleana)
        //    {
        //        case true:
        //            Console.WriteLine("La variable tiene true");
        //            break;
     //           case false:
      //              Console.WriteLine("La variable tiene false");
       //             break;



       //     }

      //      Console.ReadKey();

            //con caracter
    /*        switch (caracter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Es vocal");
                    break;
                default:
                    Console.WriteLine("Es consonate");
                    break;
    */
            
            //con cadena
            switch (cadena)
            {
                case "Hola":
                   Console.WriteLine("Español");
                   break;
                case "Hellow":
                   Console.WriteLine("Ingles");
                   break;
                case "Priviet":
                   Console.WriteLine("Ruso");
                   break;
            }

            Console.ReadKey();
        }
        
            

        }

    
}
