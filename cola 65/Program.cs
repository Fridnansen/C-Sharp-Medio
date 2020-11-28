using System;
using System.Collections;
using System.Collections.Generic;

namespace cola_65
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();

            foreach(int numero in new int[5] { 2, 4, 6, 8, 10})
            {

                numeros.Push(numero);

            }

            Console.WriteLine("Recorriendo el Queue");

            foreach (int numero in numeros)
            {
                
                Console.WriteLine(numero);

            }

            Console.WriteLine("Elminando elementos");

            numeros.Pop();

            foreach(int numero in numeros)
            {

                Console.WriteLine(numero);

            }
        }
    }
}
