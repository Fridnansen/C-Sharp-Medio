using System;
using System.Collections.Generic;

namespace colecciones_63
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>(); // Declarar una lista 

            Console.WriteLine("Cuantos elementos quieres introducir");

            int elem = Int32.Parse(Console.ReadLine());

            for (int i=0; i < elem; i++)
            {

                numeros.Add(Int32.Parse(Console.ReadLine()));

            }

            for (int i = 0; i < elem; i++)
            {

                Console.WriteLine(numeros[i]);

            }

                /*numeros.Add(5);

                numeros.Add(7);

                numeros.Add(9);*/
                /* int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };

                 for (int i = 0; i < 5; i++)
                 {

                     numeros.Add(listaNumeros[i]);

                 }

                 for (int i=0; i< 5; i++)
                 {

                     Console.WriteLine(numeros[i]);

                 }
                 */





             //   Console.WriteLine("Hello World!");


        }
    }
}
