using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_POO_yea
{
    
    class Program
    {//lo que esta dentro de estas llaves sera ejecutao por visual studio   
        static void Main(string[] args)
        {
            Pokemon Pikachu = new Pokemon();
            Pokemon Chansey = new Pokemon();

            //Pikachu
            Pikachu.ataque = 60;
            Pikachu.velocidad = 100;
            Pikachu.vida = 120;

            //Chansey
            Chansey.ataque = 30;
            Chansey.velocidad = 30;
            Chansey.vida = 300;

            Console.WriteLine(Pikachu.vida);

        }
    }
}
