using System;
using System.Collections.Generic;

namespace delegadoPRedicado68
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Personas> gente = new List<Personas>();

            Personas P1 = new Personas();
            P1.Nombre1 = "Juan";
            P1.Edad = 18;

            Personas P2 = new Personas();
            P2.Nombre2 = "Maria";
            P2.Edad = 28;

            

            /*Personas P3 = new Personas();
            P3.Nombre1 = "Ana";
            P3.Edad = 37;

            gente.AddRange(new Personas[] { P1, P2, P3 });

            Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteJuan);

            bool existe = gente.Exists(elPredicado);

            if (existe) Console.WriteLine("Hay personas que se llaman Juan");
            else Console.WriteLine("No hay nadie llamado Juan");



            Console.WriteLine("Hello World!");*/
            //OperacionesMatematicas operaciones = new OperacionesMatematicas((num1, num2)=> num1*num2);

            //Console.WriteLine(operaciones(4,7));

           // List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ComparaPersonas comparaEdad = (persona1, persona2) => persona1 == persona2;

            Console.WriteLine(comparaEdad(P1.Edad, P2.Edad);

        }

        public delegate bool ComparaPersonas(int edad, int edad2);
        
               //public delegate int OperacionesMatematicas(int num1, int num2);
        /* public static  int Cuadrado(int num)
           {

               return num = num; 

           }

           static bool ExisteJuan(Personas personas)
           {

               if (personas.Nombre1 == "Juan") return true;
               else return false;

           }*/

        //public delegate int OperacionesMatematicas(int numero1, int numero2);



        /*public delegate int OpeacionesMatematicas(int numero);
        public static int Cuadrado(int num)
        {

            return num + num;

        }*/

    }
    class Personas
    {
        private string Nombre;
        private int edad;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Nombre2 { get; internal set; }
    }
}
