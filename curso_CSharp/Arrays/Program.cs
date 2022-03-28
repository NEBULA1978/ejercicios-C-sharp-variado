using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                int miVariable = 600;

                string[] miArray = new string[5];

             // int[] miArray = new int[5];//creacion de array de numeros enteros
                miArray[0] ="10";//mos valor posicion 0 
                miArray[1] = "50";
                miArray[2] = "40";
                miArray[3] = "30";
                miArray[4] = "20";//posicion 5

                //array para bool otra manera Arryas
                bool[] miArray2 = new bool[5];
                miArray2[0] = true;
                miArray2[1] = false;
                miArray2[2] = false;
                miArray2[3] = true;
                miArray2[4] = true;



                //otra forma de hacer un array indicandole los valores entre llaves
                int[] otraArray = { 234, 456, 156, 99, 563 };
            */

            int miVariable1;
            miVariable1 = 12;

            int[] array1;//declaramos ael array
            array1 = new int[3];//dimensionamos array
            array1[0] =12;//si no pongo valor le pone valor 0
            array1[1] = 32;//si no pongo valor le pone valor 0
            array1[2] = 76;//si no pongo valor le pone valor 0


            //creamos otro array
            int[] array3 = new int[3] { 12, 32, 76};
            int[] array4 = { 12, 32, 76 };// otro array

            //creamos otro array
            int[,] array5 = new int[3,3];//indicamos que es de 2 dimensiones pobemos la coma entre[,] al principio
                                         //otro array 2dimensiones
                                         //   int[,] array6 = new int[,] { { 547, 4567, 32, 345 }, { 54, 456, 32, 345 } };//creando arrays 2dimensiones 2filas y 4columnas por cada fila,todas filas mismo nºcolumnas

            array5[1, 2] = 32;//fila 1 columna 2 introduzca un 32

            //minuto 12 video 6 arrays2


            Console.WriteLine(array1[1]);
          //  Console.ReadKey(); al pulsar sale tecla y el valor de la posicion del array
            Console.WriteLine(array1[2]);
         //   Console.ReadKey();
            Console.WriteLine(array1[0]);
            Console.ReadKey();//dejamos la consola a la espera para poder ver





            /*  
            
            //array string
            string[] nombreCompleto = new string[3];//creamos un array con 3posiciones
            Console.WriteLine("Introduzca su nombre....");//pedimos a usuario introduzca su nombre
            nombreCompleto[0] = Console.ReadLine();//se queda esperando a que introzca nombre y se warda en la posicion 0 del array

            string[] nombreCompleto1= new string[3];//creamos un array con 3posiciones
            Console.WriteLine("Introduzca su  primer apellido");//pedimos a usuario introduzca su nombre
            nombreCompleto[1] = Console.ReadLine();//se queda esperando a que introzca nombre y se warda en la posicion 0 del array
            



            string[] nombreCompleto2= new string[3];//creamos un array con 3posiciones
            Console.WriteLine("Introduzca su   segundo apellido");//pedimos a usuario introduzca su nombre
            nombreCompleto[2] = Console.ReadLine();//se queda esperando a que introzca nombre y se warda en la posicion 0 del array

            // Console.WriteLine(nombreCompleto[0] + nombreCompleto[1] + nombreCompleto[2]);//+ concadena textos salen juntos

            Console.WriteLine(nombreCompleto[0] + " " + nombreCompleto[1] + " " + nombreCompleto[2]);
            
            Console.ReadKey();//consola en espera para que nos de tiempo a ver el resultado
          */
        }
    }
}
